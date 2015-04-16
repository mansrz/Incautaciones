Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Infoware.Datos 
Imports System.Data.SqlClient
Imports Incautacion.Reglas

Public Class FrmEstadoCuenta
  Public Property Empresa() As Empresa
    Get
      Return mEmpresa
    End Get
    Set(ByVal value As Empresa)
      mEmpresa = value
      Llenar_datos()
    End Set
  End Property

  Private mListaLlenarDatos As Boolean = False

  Private Sub Llenar_datos()
    MyBase.Titulo = "Estado de Cuenta"
    If Not mListaLlenarDatos OrElse mEmpresa Is Nothing Then
      Exit Sub
    End If
    Try
      Dim info As New crpEstadoCuenta
      info.DataDefinition.FormulaFields("empresa").Text = String.Format("'{0}'", mEmpresa.NombreCompleto)
      info.DataDefinition.FormulaFields("filtro").Text = String.Format("'Cortado al {0}'", Me.dtfecdesde.Value.ToShortDateString)

      Dim _entidad As Entidad = Nothing
      If Me.chkelegirentidad.Checked Then
        If Me.rdocxc.Checked Then
          _entidad = Me.CtlBuscaCliente1.Cliente.Entidad
        End If
        If Me.rdocxp.Checked Then
          _entidad = Me.CtlBuscaProveedor1.Proveedor.Entidad
        End If
      End If

      Dim ds As New dsEstadoCuenta
      ds = RetornarEstadoCuentaDS(mEmpresa, Me.rdocxc.Checked, Me.dtfecdesde.Value, Me.dtfechasta.Value, _entidad)

      'If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
      '  MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      'Else
      info.SetDataSource(ds)
      info.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
      info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
      'Me.CrystalReportViewer1.Zoom(1)
      Me.ReporteDatos = info
      'End If
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Function RetornarEstadoCuentaDS(ByVal _Empresa As Empresa, ByVal _esCxC As Boolean, ByVal _FechaDesde As DateTime, ByVal _FechaHasta As DateTime, Optional ByVal _Entidad As Entidad = Nothing) As dsEstadoCuenta
    Dim bReturn As Boolean = True
    Dim dsResult As New dsEstadoCuenta
    With _Empresa.OperadorDatos
      .AgregarParametro("@accion", "ec")
      .AgregarParametro("@esCxc", _esCxC)
      .AgregarParametro("@FechaDesde", _FechaDesde.Date)
      .AgregarParametro("@FechaHasta", _FechaHasta.Date)
      If _Entidad IsNot Nothing Then
        .AgregarParametro("@Entida_Codigo", _Entidad.Entida_Codigo)
      End If
      .Comando.CommandText = "proc_PagosDet"

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(.Comando)
      Try
        dsResult = New dsEstadoCuenta
        DataAdapter.Fill(dsResult, "vp_EstadoCuenta")
      Catch ex As Exception
        bReturn = False
      End Try
      .LimpiarParametros()
    End With
    Return dsResult
  End Function

  Private Sub chksolousuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecdesde.Validated, rdocxc.CheckedChanged, chkelegirentidad.CheckedChanged, CtlBuscaCliente1.CambioItem, CtlBuscaProveedor1.CambioItem, dtfechasta.Validated
    Me.pnlcliente.Visible = Me.chkelegirentidad.Checked And Me.rdocxc.Checked
    Me.pnlproveedor.Visible = Me.chkelegirentidad.Checked And Me.rdocxp.Checked
    Llenar_datos()
  End Sub

#Region "New"
  Private mEmpresa As Empresa = Nothing

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Forma_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.BarraEmpresa1.Sistema = Sistema
    Me.BarraEmpresa1.Llenar_datos()
    Empresa = Me.BarraEmpresa1.Empresa

    Me.CtlBuscaCliente1.OperadorDatos = Sistema.OperadorDatos
    Me.CtlBuscaProveedor1.OperadorDatos = Sistema.OperadorDatos
    Me.dtfecdesde.Value = Now.Date.AddMonths(-1)
    Me.dtfechasta.Value = Now.Date

    mListaLlenarDatos = True
    Llenar_datos()
  End Sub

#End Region

  Private Sub BarraEmpresa1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraEmpresa1.CambioDatos
    Empresa = Me.BarraEmpresa1.Empresa
  End Sub
End Class
