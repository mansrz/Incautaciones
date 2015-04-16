Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmMantenimientoEmpresa
#Region "Opcion"
  Private mEmpresa As Empresa = Nothing
  Public Property Empresa() As Empresa
    Get
      Return mEmpresa
    End Get
    Set(ByVal value As Empresa)
      mEmpresa = value
      If value IsNot Nothing Then
        llenar_datos()
      End If
    End Set
  End Property
#End Region

  Sub llenar_datos()
    Me.pnlcuerpo1.Enabled = False
    If mEmpresa Is Nothing Then
      Exit Sub
    End If
    Me.pnlcuerpo1.Enabled = True
    EsNuevo = mEmpresa.EsNuevo
    Me.CtlPersona1.Entidad = mEmpresa.Entidadjuridica.Entidad
    Me.CtlBuscaEntidadContador.EntidadNatural = mEmpresa.EntidadContador
  End Sub

  'Public Event GuardoCambios As EventHandler

  Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Guardar
    If Guardar_datos() Then
      Me.Close()
    End If
  End Sub

  Public Sub Mapear_datos()
    Me.CtlPersona1.Mapear_datos()
    mEmpresa.Entidadjuridica = Me.CtlPersona1.Entidad.Entidadjuridica
    mEmpresa.EntidadContador = Me.CtlBuscaEntidadContador.EntidadNatural
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_datos()
    Dim _esnuevo As Boolean = mEmpresa.EsNuevo
    If mEmpresa.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mEmpresa.NombreCompleto)

      Return True
    Else
      'Sucursales.CancelEdit()
      MsgBox("No se puede guardar Empresa" & Environment.NewLine & mEmpresa.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmMantenimientoEmpresa_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _OpcionActual, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmMantenimientoEmpresa_Inicializar(Me, Nothing)
  End Sub

  Private Sub FrmMantenimientoEmpresa_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Empresa"
    Me.CtlBuscaEntidadContador.OperadorDatos = Sistema.OperadorDatos
    Me.BarraEmpresa1.Sistema = Sistema
    Me.BarraEmpresa1.Llenar_datos()
    Me.Empresa = Me.BarraEmpresa1.Empresa
  End Sub
#End Region

  Private Sub BarraEmpresa1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraEmpresa1.CambioDatos
    Me.Empresa = Me.BarraEmpresa1.Empresa
  End Sub

  Private Sub BarraEmpresa1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles BarraEmpresa1.ItemClicked

  End Sub
End Class