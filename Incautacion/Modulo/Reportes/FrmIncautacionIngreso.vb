Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Infoware.Datos 
Imports System.Data.SqlClient
Imports Incautacion.Reglas
Imports Incautacion.Reglas.Incautacion
Public Class FrmIncautacionIngreso

  Public Property Incautacion() As Reglas.Incautacion
    Get
      Return mIncautacion
    End Get
    Set(ByVal value As Reglas.Incautacion)
      mIncautacion = value
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
    MyBase.Titulo = "Incautación Ingreso"
    If Not mListaLlenarDatos OrElse Incautacion Is Nothing Then
      Exit Sub
    End If
    Try
      Dim info As New crpIncautacion
      Dim ds As New dsIncautacion
      ds = RetornarIncautacionDs(Incautacion)

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

  Private Function RetornarIncautacionDs(ByVal _incautacion As Reglas.Incautacion) As dsIncautacion
    Dim bReturn As Boolean = True
    Dim dsResult As New dsIncautacion
    With _incautacion.OperadorDatos
      .AgregarParametro("@Empres_Codigo", _incautacion.Empres_Codigo)
      .AgregarParametro("@Entida_Contribuyente", _incautacion.Entida_Contribuyente)
      .Comando.CommandText = "rp_Incautacion"

      Dim DataAdapter As SqlDataAdapter
      DataAdapter = New SqlDataAdapter(.Comando)
      Try
        dsResult = New dsIncautacion
        DataAdapter.Fill(dsResult, "vp_Incautacion")
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

  Private Sub chksolousuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Llenar_datos()
  End Sub

#Region "New"
  Private mIncautacion As Reglas.Incautacion = Nothing
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

    mListaLlenarDatos = True
    Llenar_datos()
  End Sub

#End Region

  
End Class
