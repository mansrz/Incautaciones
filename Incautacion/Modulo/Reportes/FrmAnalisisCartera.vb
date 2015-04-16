Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Infoware.Datos 
Imports System.Data.SqlClient
Imports Incautacion.Reglas

Public Class FrmAnalisisCartera
  Public Property Empresa() As Empresa
    Get
      Return mEmpresa
    End Get
    Set(ByVal value As Empresa)
      mEmpresa = value
      Llenar_datos()
    End Set
  End Property

  '#Region "IOpcion"
  '  Private mEmpresa As Empresa = Nothing
  Private mListaLlenarDatos As Boolean = False
  '  Public WriteOnly Property Empresa() As Empresa
  '    Set(ByVal value As Empresa)
  '      mEmpresa = value
  '      If value IsNot Nothing Then
  '        Me.dtfecdesde.Value = Now.Date

  '        mListaLlenarDatos = True
  '        Llenar_datos()
  '      End If
  '    End Set
  '  End Property
  '#End Region

  Private Sub Llenar_datos()
    MyBase.Titulo = "Analisis de cartera"
    If Not mListaLlenarDatos OrElse mEmpresa Is Nothing Then
      Exit Sub
    End If
    Try
      Dim info As New crpAnalisisCartera
      info.DataDefinition.FormulaFields("titulo").Text = String.Format("'{0}'", IIf(Me.rdocarteravcda.Checked, "Análisis de cartera vencida", "Análisis de cartera por vencer"))
      info.DataDefinition.FormulaFields("empresa").Text = String.Format("'{0}'", mEmpresa.NombreCompleto)
      info.DataDefinition.FormulaFields("filtro").Text = String.Format("'Cortado al {0}'", Me.dtfecdesde.Value.ToShortDateString)
      info.DataDefinition.FormulaFields("Periodo1").Text = String.Format("'{0}'", IIf(Me.rdocarteravcda.Checked, "Por vencer", "Vencido"))
      info.DataDefinition.FormulaFields("Periodo2").Text = String.Format("'{0}-{1} días'", 0, Me.txtperiodo1.Value)
      info.DataDefinition.FormulaFields("Periodo3").Text = String.Format("'{0}-{1} días'", Me.txtperiodo1.Value, Me.txtperiodo2.Value)
      info.DataDefinition.FormulaFields("Periodo4").Text = String.Format("'{0}-{1} días'", Me.txtperiodo2.Value, Me.txtperiodo3.Value)
      info.DataDefinition.FormulaFields("Periodo5").Text = String.Format("'{0} en adelante'", Me.txtperiodo3.Value)

      Dim ds As New dsAnalisisCartera
      ds = RetornarAnalisisCarteraDS(mEmpresa, Me.rdocxc.Checked, Me.rdocarteravcda.Checked, Me.dtfecdesde.Value, Me.txtperiodo1.Value, Me.txtperiodo2.Value, Me.txtperiodo3.Value)

      'If ds Is Nothing OrElse ds.Tables.Count = 0 OrElse ds.Tables(0).Rows.Count = 0 Then
      '  MsgBox("No existen registros a presentar", MsgBoxStyle.Information, "Información")
      'Else
      info.SetDataSource(ds)
      info.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
      info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
      'Me.CrystalReportViewer1.Zoom(1)
      Me.ReporteDatos = info
      'End If
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Function RetornarAnalisisCarteraDS(ByVal _Empresa As Empresa, ByVal _esCxC As Boolean, ByVal _esCarteraVencida As Boolean, ByVal _FechaCorte As DateTime, ByVal _corte1 As Integer, ByVal _corte2 As Integer, ByVal _corte3 As Integer) As dsAnalisisCartera
    Dim bReturn As Boolean = True
    Dim dsResult As New dsAnalisisCartera
    With _Empresa.OperadorDatos
      .AgregarParametro("@accion", "ac")
      .AgregarParametro("@esVcdo", _esCarteraVencida)
      .AgregarParametro("@esCxc", _esCxC)
      .AgregarParametro("@FechaCorte", _FechaCorte.Date)
      .AgregarParametro("@corte1", _corte1)
      .AgregarParametro("@corte2", _corte2)
      .AgregarParametro("@corte3", _corte3)
      .Comando.CommandText = "proc_PagosDet"

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(.Comando)
      Try
        dsResult = New dsAnalisisCartera
        DataAdapter.Fill(dsResult, "vp_AnalisisCartera")
      Catch ex As Exception
        MsgBox(ex.Message)
        bReturn = False
      End Try
      .LimpiarParametros()
    End With
    If bReturn Then
      Return dsResult
    End If
    Return Nothing
  End Function

  Private Sub chksolousuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecdesde.ValueChanged, rdocarteravcto.CheckedChanged, rdocxc.CheckedChanged, txtperiodo1.Validated, txtperiodo2.Validated, txtperiodo3.Validated
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

    Me.dtfecdesde.Value = Now.Date

    mListaLlenarDatos = True
    Llenar_datos()
  End Sub

#End Region

  Private Sub BarraEmpresa1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraEmpresa1.CambioDatos
    Empresa = Me.BarraEmpresa1.Empresa
  End Sub
End Class
