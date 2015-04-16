Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

'Imports WWTS.Inventario.Reglas

Public Class FrmMantenimientoTipoMovimientoCompraVenta
#Region "IOpcion"
  Private mSucursal As Sucursal = Nothing
  Public Property Sucursal() As Sucursal
    Get
      Return mSucursal
    End Get
    Set(ByVal value As Sucursal)
      mSucursal = value
      MyBase.Tabla = "Secuenciales"
      If value IsNot Nothing Then
        Me.cbotipomovimiento.OperadorDatos = value.OperadorDatos
        Me.cbotipomovimiento.Parametro = Enumerados.EnumParametros.TipoMovInventario
        Me.cbotipomovimiento.Llenar_Datos()
      End If
    End Set
  End Property
#End Region

#Region "Parametros"
  Public Property TipoMovimientoCompraVentas() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mTipoMovimientoCompraVenta As TipoMovimientoCompraVenta = Nothing
  Public Property TipoMovimientoCompraVenta() As TipoMovimientoCompraVenta
    Get
      Return mTipoMovimientoCompraVenta
    End Get
    Set(ByVal value As TipoMovimientoCompraVenta)
      mTipoMovimientoCompraVenta = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _TipoMovimientoCompraVentas As New TipoMovimientoCompraVentaList
        _TipoMovimientoCompraVentas.Add(mTipoMovimientoCompraVenta)
        MyBase.BindingSource1.DataSource = GetType(TipoMovimientoCompraVenta)
        MyBase.BindingSource1.DataSource = _TipoMovimientoCompraVentas
      End If
    End Set
  End Property

  Sub llenar_datos()
    If mSucursal Is Nothing Then
      Exit Sub
    End If

    mTipoMovimientoCompraVenta = TipoMovimientoCompraVentas.Current
    ValidarRegistro()
    Me.cbotipomovimiento.Parametro = mTipoMovimientoCompraVenta.Parame_TipoCompraVenta
    Me.cbotipomovimiento.Llenar_Datos()
    Me.cbotipomovimiento.ParametroDet = mTipoMovimientoCompraVenta.PardetTipoCompraVenta
    Me.txtnumero.Value = mTipoMovimientoCompraVenta.TiMoCv_Secuencia
    'Me.chkseguirsecuencia.Checked = mTipoMovimientoCompraVenta.Tipmov_Seguirsecuencia
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoTipoMovimientoCompraVenta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mTipoMovimientoCompraVenta.EsNuevo
    If _esnuevo AndAlso TipoMovimientoCompraVentas.Current IsNot Nothing Then
      TipoMovimientoCompraVentas.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "TipoMovimientoCompraVentas eventos"
  Private Sub FrmMantenimientoTipoMovimientoCompraVenta_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoTipoMovimientoCompraVenta_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    mTipoMovimientoCompraVenta.PardetTipoCompraVenta = Me.cbotipomovimiento.ParametroDet
    mTipoMovimientoCompraVenta.TiMoCv_Secuencia = Me.txtnumero.Value
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_datos()

    Dim _esnuevo As Boolean = mTipoMovimientoCompraVenta.EsNuevo
    If mTipoMovimientoCompraVenta.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mTipoMovimientoCompraVenta.PardetTipoCompraVentaString)

      Return True
    Else
      'TipoMovimientoCompraVentas.CancelEdit()
      MsgBox("No se puede guardar Tipo de movimiento" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoTipoMovimientoCompraVenta_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mTipoMovimientoCompraVenta.Eliminar() AndAlso TipoMovimientoCompraVentas.Current IsNot Nothing Then
      TipoMovimientoCompraVentas.RemoveCurrent()
      Me.Close()
    Else
      'TipoMovimientoCompraVentas.CancelEdit()
      MsgBox("No se puede eliminar Tipo de movimiento" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoTipoMovimientoCompraVenta_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTipoMovimientoCompraVenta_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTipoMovimientoCompraVenta_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTipoMovimientoCompraVenta_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.PuedeGuardarnuevo = False
    Me.PuedeGuardar = True
    Me.PuedeGuardarcerrar = True
    Me.PuedeNuevo = False
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _OpcionActual, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.PuedeGuardarnuevo = False
    Me.PuedeGuardar = True
    Me.PuedeGuardarcerrar = True
    Me.PuedeNuevo = False
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub
End Class
