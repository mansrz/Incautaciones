Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmMantenimientoIncautacionResolucion
    Private mIncautacion As Reglas.Incautacion = Nothing
    Public Property Incautacion As Reglas.Incautacion
        Get
            Return mIncautacion
        End Get
        Set(value As Reglas.Incautacion)
            MessageBox.Show("estoy seteando incaut en resol " + value.Incaut_Codigo.ToString)
            mIncautacion = value

        End Set
    End Property

#Region "Parametros"
    Public Property IncautacionResoluciones() As BindingSource
        Get
            Return MyBase.BindingSource1
        End Get
        Set(ByVal value As BindingSource)
            MyBase.BindingSource1 = value
            llenar_datos()
        End Set
    End Property

    Private mIncautacionResolucion As Reglas.IncautacionResolucion = Nothing
    Public Property IncautacionResolucion() As Reglas.IncautacionResolucion
        Get
            Return mIncautacionResolucion
        End Get
        Set(ByVal value As Reglas.IncautacionResolucion)
            mIncautacionResolucion = value
            If MyBase.BindingSource1.DataSource Is Nothing Then
                Dim _incautacionResoluciones As New IncautacionResolucionList
                _incautacionResoluciones.Add(mIncautacionResolucion)
                MyBase.BindingSource1.DataSource = GetType(Reglas.IncautacionResolucion)
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

        mIncautacionResolucion = IncautacionResoluciones.Current

        If mIncautacionResolucion Is Nothing Then
            Exit Sub
        End If


        Me.txtNumero.Text = mIncautacionResolucion.IncRes_Numero
        'Me.cboTipoResolucion.Parametro = mIncautacionResolucion.Parame_TipoResolucion
        Me.cboTipoResolucion.ParametroDet = mIncautacionResolucion.PardetTipoResolucion
        Me.dtpFecResol.Value = mIncautacionResolucion.IncRes_Fecha
        Me.dtpFecNotif.Value = mIncautacionResolucion.IncRes_FechaNotificacion
        Me.dtpFecEntre.Value = mIncautacionResolucion.IncRes_FechaEntrega
        Me.txtNoLiquidacion.Text = mIncautacionResolucion.IncRes_NumeroLiquidacion
        Me.txtObservacion.Text = mIncautacionResolucion.IncRes_Observacion

    End Sub
#End Region

#Region "Cerrar y Cancelar"
    Private Sub FrmMantenimientoItem_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Cancelar_Nuevo()
    End Sub

    Private Function Cancelar_Nuevo() As Boolean
        Dim _esAceptado As Boolean = mIncautacionResolucion.Aceptado
        If _esAceptado AndAlso IncautacionResoluciones.Current IsNot Nothing Then
            IncautacionResoluciones.RemoveCurrent()
        End If
        Return _esAceptado
    End Function
#End Region

#Region "IncautacionResoluciones eventos"
    Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
        Dim _IncautacionResolucion As IncautacionResolucion = New IncautacionResolucion(mIncautacion, True)
        e.NewObject = _IncautacionResolucion
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
        mIncautacionResolucion.IncRes_Numero = Me.txtNumero.Text
        mIncautacionResolucion.Parame_TipoResolucion = Me.cboTipoResolucion.Parametro
        mIncautacionResolucion.PardetTipoResolucion = Me.cboTipoResolucion.ParametroDet
        mIncautacionResolucion.IncRes_Fecha = Me.dtpFecResol.Value
        mIncautacionResolucion.IncRes_FechaNotificacion = Me.dtpFecNotif.Value
        mIncautacionResolucion.IncRes_FechaEntrega = Me.dtpFecEntre.Value
        mIncautacionResolucion.IncRes_NumeroLiquidacion = Me.txtNoLiquidacion.Text
        mIncautacionResolucion.IncRes_Observacion = Me.txtObservacion.Text
        mIncautacionResolucion.Incaut_Codigo = Incautacion.Incaut_Codigo
    End Sub

    Private Function Guardar_datos() As Boolean
        Try
            Mapear_datos()
            Dim _esnuevo As Boolean = mIncautacionResolucion.EsNuevo
            If Not mIncautacionResolucion.Guardar() Then
                Throw New Exception("No se puede guardar la Resolución")
            End If

            Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mIncautacionResolucion.IncRes_Numero)

            mIncautacionResolucion.Aceptado = True

            'llenar_datos()
            Return True
        Catch ex As Exception
            MsgBox("No se puede guardar la Resolución" & Environment.NewLine & Sistema.OperadorDatos.MsgError & ". " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub FrmMantenimientoItem_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
        If mIncautacionResolucion.Eliminar() AndAlso IncautacionResoluciones.Current IsNot Nothing Then
            IncautacionResoluciones.RemoveCurrent()
            Me.Close()
        Else
            'MyBase.BindingSource1.CancelEdit()
            MsgBox("No se puede eliminar la Resolución" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
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
        Me.cboTipoResolucion.OperadorDatos = Sistema.OperadorDatos
        Me.cboTipoResolucion.Parametro = Enumerados.EnumParametros.TipoResolucion
        Me.cboTipoResolucion.Llenar_Datos()
    End Sub

#End Region

    Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.BindingSource1 = Nothing
    End Sub


End Class
