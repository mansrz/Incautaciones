Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmMantenimientoSucursal
#Region "IOpcion"
  Private mSucursal As Sucursal = Nothing
  Public Shadows WriteOnly Property Sucursal() As Reglas.Sucursal
    Set(ByVal value As Reglas.Sucursal)
      mSucursal = value
      Me.CtlEntidadLugar1.Empresa = value.Empresa

      If value IsNot Nothing Then
        llenar_datos()
      End If
    End Set
  End Property
#End Region

#Region "Parametros"
  Sub llenar_datos()
    If mSucursal Is Nothing Then
      Exit Sub
    End If
    EsNuevo = mSucursal.EsNuevo
    Me.CtlEntidadLugar1.EntidadLugar = mSucursal.Entidadlugar
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub GuardarCambiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Guardar
    If Guardar_datos() Then
      Me.Close()
    End If
  End Sub

  Private Sub Mapear_Datos()
    Me.CtlEntidadLugar1.Mapear_datos()
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_Datos()
    Dim _esnuevo As Boolean = mSucursal.EsNuevo
    If mSucursal.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mSucursal.NombreCompleto)

      Return True
    Else
      'Sucursales.CancelEdit()
      MsgBox("No se puede guardar Sucursal" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoProveedores)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    'Me.CtlPersona1.PuedeElegirTipoEntidad = True
    FrmMantenimientoSucursal_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoProveedores)
    MyBase.New(_Sistema, _OpcionActual, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    'Me.CtlPersona1.PuedeElegirTipoEntidad = True
    FrmMantenimientoSucursal_Inicializar(Me, Nothing)
  End Sub

  Private Sub FrmMantenimientoSucursal_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.CtlBuscaCliente1.OperadorDatos = Sistema.OperadorDatos
    MyBase.Tabla = "Zona"

    'Me.BarraEmpresa1.Sistema = Sistema
    'Me.BarraEmpresa1.Llenar_datos()
    'Me.Sucursal = Me.BarraEmpresa1.Sucursal
  End Sub
#End Region

  'Private Sub BarraEmpresa1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraEmpresa1.CambioDatos
  '  Me.Sucursal = Me.BarraEmpresa1.Sucursal
  'End Sub
End Class
