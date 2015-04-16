Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General

'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmMantenimientoItemDetalle
#Region "IOpcion"
  Private mItem As Item = Nothing
  Public Property Item As Item
    Get
      Return mItem
    End Get
    Set(ByVal value As Item)
      mItem = value
      MyBase.Tabla = "Detalle de combo"

      If value IsNot Nothing Then
        Me.CtlBuscaItem1.Sucursal = msucursal
        Me.CtlBuscaItem1.llenar_datos()

        Me.ComboBoxUnidadMedida.Parametro = Enumerados.EnumParametros.UnidadMedida
        Me.ComboBoxUnidadMedida.OperadorDatos = value.OperadorDatos
        Me.ComboBoxUnidadMedida.Llenar_Datos(ParametroDetList.enumTipoObjeto.UnidadMedida)
      End If
    End Set
  End Property

  Private mRegistroAceptado As Boolean = False
  Public Property RegistroAceptado As Boolean
    Get
      Return mRegistroAceptado
    End Get
    Set(ByVal value As Boolean)
      mRegistroAceptado = value
    End Set
  End Property

#End Region

  Private mEstaCambiando As Boolean = False

#Region "Parametros"
  Public Property ItemDetalles() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mItemDetalle As ItemDetalle = Nothing
  Public Property ItemDetalle() As ItemDetalle
    Get
      Return mItemDetalle
    End Get
    Set(ByVal value As ItemDetalle)
      mItemDetalle = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _ItemDetalles As New ItemDetalleList
        _ItemDetalles.Add(mItemDetalle)
        MyBase.BindingSource1.DataSource = GetType(ItemDetalle)
        MyBase.BindingSource1.DataSource = _ItemDetalles
      End If
    End Set
  End Property

  Sub llenar_datos()
    If mItem Is Nothing Then
      Exit Sub
    End If

    mItemDetalle = ItemDetalles.Current
    ValidarRegistro()
    mEstaCambiando = True
    Me.CtlBuscaItem1.Item = mItemDetalle.ItemDetalle
    Me.txtcantidad.Value = mItemDetalle.IteDet_Cantidad
    Me.txtvalor.Value = mItemDetalle.IteDet_Valor

    If Me.CtlBuscaItem1.Item IsNot Nothing Then
      Me.ComboBoxUnidadMedida.Llenar_Datos(ParametroDetList.enumTipoObjeto.UnidadMedida, Me.CtlBuscaItem1.Item.PardetUnidadMedida)
      Me.ComboBoxUnidadMedida.ParametroDet = mItemDetalle.PardetUnidadMedida
    End If

    Me.CtlBuscaItem1.Focus()
    mEstaCambiando = False
    'CambioItem()
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoItemDetallealle_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    If Not mRegistroAceptado Then
      ItemDetalles.RemoveCurrent()
    End If
    Return True
  End Function
#End Region

#Region "MovimientosContables eventos"
  Private Sub FrmMantenimientoItemDetallealle_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _ItemDetalle As ItemDetalle = New ItemDetalle(mItem, True)
    e.NewObject = _ItemDetalle
  End Sub

  Private Sub FrmMantenimientoItemDetallealle_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoItemDetallealle_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    mItemDetalle.ItemDetalle = Me.CtlBuscaItem1.Item
    mItemDetalle.IteDet_Cantidad = Me.txtcantidad.Value
    mItemDetalle.IteDet_Valor = Me.txtvalor.Value
    mItemDetalle.PardetUnidadMedida = Me.ComboBoxUnidadMedida.ParametroDet
  End Sub

  Private Function Guardar_datos() As Boolean
    ItemDetalles.EndEdit()
    Try
      Mapear_datos()
      mRegistroAceptado = True
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      Return False
    End Try
    'If mItemDetalle.Guardar() Then
    '  Return True
    'Else
    '  'MovimientosContables.CancelEdit()
    '  MsgBox("No se puede guardar Movimiento Contable" & Environment.NewLine & mItem.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    '  Return False
    'End If
    Return True
  End Function

  Private Sub FrmMantenimientoItemDetallealle_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mItemDetalle.Eliminar() AndAlso ItemDetalles.Current IsNot Nothing Then
      ItemDetalles.RemoveCurrent()
      Me.Close()
    Else
      'MovimientosContables.CancelEdit()
      MsgBox("No se puede eliminar ItemDetalle" & Environment.NewLine & mItem.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoItemDetallealle_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoItemDetallealle_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoItemDetallealle_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoItemDetallealle_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "Item"
  Private Sub CtlBuscaItem1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaItem1.CambioItem
    If mEstaCambiando Then
      Exit Sub
    End If
    mEstaCambiando = True
    Dim _unidmed As ParametroDet = Me.ComboBoxUnidadMedida.ParametroDet
    Me.ComboBoxUnidadMedida.Llenar_Datos(ParametroDetList.enumTipoObjeto.UnidadMedida, Me.CtlBuscaItem1.Item.PardetUnidadMedida)
    Me.ComboBoxUnidadMedida.ParametroDet = Me.CtlBuscaItem1.Item.PardetUnidadMedida

    'CambioItem()
    mEstaCambiando = False
  End Sub

  Private Sub ComboBoxUnidadMedida_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxUnidadMedida.CambioItem
    If mEstaCambiando Then
      Exit Sub
    End If
    'CambioItem()
  End Sub
#End Region


#Region "New"
  Private mSucursal As Sucursal = Nothing
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Sucursal As Sucursal, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    mSucursal = _Sucursal
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _Sucursal As Sucursal, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _Sucursal, _OpcionNuevo)
  End Sub
#End Region

  Private Sub FrmMantenimientoItem_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub

  Private Sub CtlBuscaItem1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlBuscaItem1.Load

  End Sub
End Class
