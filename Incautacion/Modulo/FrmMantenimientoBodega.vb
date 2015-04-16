Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

'Imports WWTS.Inventario.Reglas

Public Class FrmMantenimientoBodega
#Region "IOpcion"
  Private mSucursal As Sucursal = Nothing
  Public Property Sucursal() As Sucursal
    Get
      Return mSucursal
    End Get
    Set(ByVal value As Sucursal)
      mSucursal = value
      MyBase.Tabla = "Bodega"
      Me.CtlEntidadLugar1.Empresa = value.Empresa
    End Set
  End Property
#End Region

#Region "Parametros"
  Public Property Bodegas() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mBodega As Bodega = Nothing
  Public Property Bodega() As Bodega
    Get
      Return mBodega
    End Get
    Set(ByVal value As Bodega)
      mBodega = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _Bodegas As New BodegaList
        _Bodegas.Add(mBodega)
        MyBase.BindingSource1.DataSource = GetType(Bodega)
        MyBase.BindingSource1.DataSource = _Bodegas
      End If
    End Set
  End Property

  Sub llenar_datos()
    If mSucursal Is Nothing Then
      Exit Sub
    End If

    mBodega = Bodegas.Current
    ValidarRegistro()
    Me.CtlEntidadLugar1.EntidadLugar = mBodega.Entidadlugar
    Me.chkprincipal.Checked = mBodega.Bodega_principal
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoBodega_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mBodega.EsNuevo
    If _esnuevo AndAlso Bodegas.Current IsNot Nothing Then
      Bodegas.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Bodegas eventos"
  Private Sub FrmMantenimientoBodega_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Bodega As Bodega = New Bodega(mSucursal, True)
    e.NewObject = _Bodega
  End Sub

  Private Sub FrmMantenimientoBodega_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoBodega_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Function Guardar_datos() As Boolean
    Me.CtlEntidadLugar1.Mapear_datos()
    mBodega.Bodega_principal = Me.chkprincipal.Checked
    Dim _esnuevo As Boolean = mBodega.EsNuevo
    If mBodega.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mBodega.NombreCompleto)

      Return True
    Else
      'Bodegas.CancelEdit()
      MsgBox("No se puede guardar Bodega" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoBodega_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mBodega.Eliminar() AndAlso Bodegas.Current IsNot Nothing Then
      Bodegas.RemoveCurrent()
      Me.Close()
    Else
      'Bodegas.CancelEdit()
      MsgBox("No se puede eliminar Bodega" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoBodega_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoBodega_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoBodega_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoBodega_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Forma_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _OpcionActual, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Forma_Inicializar(Me, Nothing)
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.PuedeGuardarnuevo = False
    Me.PuedeGuardar = True
    Me.PuedeGuardarcerrar = True
    Me.PuedeNuevo = False
  End Sub
End Class
