Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmMantenimientoItemPrecio
    Private mItem As Item = Nothing
    Public Property Item As Item
        Get
            Return mItem
        End Get
        Set(value As Item)
            mItem = value
        End Set
    End Property

#Region "Parametros"
    Public Property ItemPrecios() As BindingSource
        Get
            Return MyBase.BindingSource1
        End Get
        Set(ByVal value As BindingSource)
            MyBase.BindingSource1 = value
            llenar_datos()
        End Set
    End Property

    Private mItemPrecio As ItemPrecio = Nothing
    Public Property ItemPrecio() As ItemPrecio
        Get
            Return mItemPrecio
        End Get
        Set(ByVal value As ItemPrecio)
            mItemPrecio = value
            If MyBase.BindingSource1.DataSource Is Nothing Then
                Dim _incautacionResoluciones As New ItemPrecioList
                _incautacionResoluciones.Add(mItemPrecio)
                MyBase.BindingSource1.DataSource = GetType(ItemPrecioList)
                MyBase.BindingSource1.DataSource = _incautacionResoluciones
            End If
        End Set
    End Property

    Sub llenar_datos()
        'If mSucursal Is Nothing Then
        '  Exit Sub
        'End If
        If Sistema.OperadorDatos Is Nothing Then
            Exit Sub
        End If

        mItemPrecio = ItemPrecios.Current

        If mItemPrecio Is Nothing Then
            Exit Sub
        End If

        Me.txtPrecio.Value = mItemPrecio.ItePre_Valor
        Me.txtObservacion.Text = mItemPrecio.ItePre_Observacion

    End Sub
#End Region

#Region "Cerrar y Cancelar"
    Private Sub FrmMantenimientoItemPrecio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Cancelar_Nuevo()
    End Sub

    Private Function Cancelar_Nuevo() As Boolean
        'Dim _esAceptado As Boolean = mItemPrecio.Aceptado
        'If _esAceptado AndAlso ItemPrecios.Current IsNot Nothing Then
        ItemPrecios.RemoveCurrent()
        'End If
        'Return _esAceptado
        Return True
    End Function
#End Region

#Region "IncautacionResoluciones eventos"
    Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
        Dim _ItemPrecio As ItemPrecio = New ItemPrecio(Sistema.OperadorDatos, True)
        e.NewObject = _ItemPrecio
    End Sub

    Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
        llenar_datos()
    End Sub
#End Region

#Region "Guardar y Eliminar"
    Private Sub FrmMantenimientoItem_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
        e.Cancel = Not Guardar_datos()
    End Sub

    Private Sub Mapear_datos()
        mItemPrecio.ItePre_Valor = Me.txtPrecio.Value
        mItemPrecio.ItePre_Observacion = Me.txtObservacion.Text
        mItemPrecio.ItePre_Activo = True
        mItemPrecio.Item_Codigo = Item.Item_Codigo
    End Sub

    Private Function Guardar_datos() As Boolean
        Try
            Mapear_datos()
            Dim _esnuevo As Boolean = mItemPrecio.EsNuevo
            mItemPrecio.OperadorDatos = Sistema.OperadorDatos

            If Not mItemPrecio.Guardar() Then
                Throw New Exception("No se puede guardar el nuevo precio")
            End If

            Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), "Item:" + mItem.Item_Secuencia.ToString + " Descripción: " + mItem.PardetTipo.Descripcion + " Valor: " + mItemPrecio.ItePre_Valor.ToString)

            'mItemPrecio.Aceptado = True

            'llenar_datos()
            Return True
        Catch ex As Exception
            MsgBox("No se puede guardar el nuevo precio" & Environment.NewLine & Sistema.OperadorDatos.MsgError & ". " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub FrmMantenimientoItem_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
        If mItemPrecio.Eliminar() AndAlso ItemPrecios.Current IsNot Nothing Then
            ItemPrecios.RemoveCurrent()
            Me.Close()
        Else
            'MyBase.BindingSource1.CancelEdit()
            MsgBox("No se puede eliminar el nuevo precio" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        End If
    End Sub
#End Region

#Region "Mover"
    Private Sub FrmMantenimientoItem_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoItem_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoItem_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoItem_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
        e.Cancel = Cancelar_Nuevo()
    End Sub
#End Region

#Region "New"
    Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Resolucion)
        MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FrmMantenimientoIncuatacionResolucion_Inicializar(Me, Nothing)
    End Sub

    Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Resolucion)
        Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
    End Sub

    Private Sub FrmMantenimientoIncuatacionResolucion_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar

    End Sub

#End Region

    Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.BindingSource1 = Nothing
    End Sub


End Class
