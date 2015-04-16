Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmMantenimientoContribuyente
    '#Region "IOpcion"
    '  Private mOperadorDatos As OperadorDatos = Nothing
    '  Public Property OperadorDatos() As OperadorDatos
    '    Get
    '      Return mOperadorDatos
    '    End Get
    '    Set(ByVal value As OperadorDatos)
    '      mOperadorDatos = value
    '    End Set
    '  End Property
    '#End Region

#Region "Parametros"
    Public Property Contribuyentes() As BindingSource
        Get
            Return MyBase.BindingSource1
        End Get
        Set(ByVal value As BindingSource)
            MyBase.BindingSource1 = value
            llenar_datos()
        End Set
    End Property

    Private mContribuyente As Contribuyente = Nothing
    Public Property Contribuyente() As Contribuyente
        Get
            Return mContribuyente
        End Get
        Set(ByVal value As Contribuyente)
            mContribuyente = value
            If MyBase.BindingSource1.DataSource Is Nothing Then
                Dim _Contribuyentes As New ContribuyenteList
                _Contribuyentes.Add(mContribuyente)
                MyBase.BindingSource1.DataSource = GetType(Incautacion.Reglas.Contribuyente)
                MyBase.BindingSource1.DataSource = _Contribuyentes
            End If
        End Set
    End Property

    Sub llenar_datos()
        If Sistema.OperadorDatos Is Nothing Then
            Exit Sub
        End If

        mContribuyente = Contribuyentes.Current
        ValidarRegistro()
        If mContribuyente IsNot Nothing Then
            Me.CtlPersona1.Entidad = mContribuyente.Entidad
        End If
    End Sub
#End Region

#Region "Cerrar y Cancelar"
    Private Sub FrmMantenimientoContribuyente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Cancelar_Nuevo()
    End Sub

    Private Function Cancelar_Nuevo() As Boolean
        Dim _esnuevo As Boolean = mContribuyente.EsNuevo
        If _esnuevo AndAlso Contribuyentes.Current IsNot Nothing Then
            Contribuyentes.RemoveCurrent()
        End If
        Return _esnuevo
    End Function
#End Region

#Region "Contribuyentes eventos"
    Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
        Dim _Contribuyente As Contribuyente = New Contribuyente(Sistema.OperadorDatos, True)
        e.NewObject = _Contribuyente
    End Sub

    Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
        llenar_datos()
    End Sub
#End Region

#Region "Guardar y Eliminar"
    Private Sub FrmMantenimientoContribuyente_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
        e.Cancel = Not Guardar_datos()
    End Sub

    Private Sub Mapear_Datos()
        Me.CtlPersona1.Mapear_datos()
    End Sub

    Private Function Guardar_datos() As Boolean
        Mapear_Datos()
        Dim _esnuevo As Boolean = mContribuyente.EsNuevo
        If mContribuyente.Guardar() Then
            Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mContribuyente.NombreCompleto)

            Return True
        Else
            'Contribuyentes.CancelEdit()
            MsgBox("No se puede guardar Contribuyente" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
            Return False
        End If
    End Function

    Private Sub FrmMantenimientoContribuyente_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
        If mContribuyente.Eliminar() AndAlso Contribuyentes.Current IsNot Nothing Then
            Contribuyentes.RemoveCurrent()
            Me.Close()
        Else
            'Contribuyentes.CancelEdit()
            MsgBox("No se puede eliminar Contribuyente" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        End If
    End Sub
#End Region

#Region "Mover"
    Private Sub FrmMantenimientoContribuyente_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoContribuyente_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoContribuyente_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoContribuyente_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
        e.Cancel = Cancelar_Nuevo()
    End Sub
#End Region

#Region "New"
    Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoContribuyentes)
        MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.CtlPersona1.PuedeElegirTipoEntidad = True
        FrmMantenimientoContribuyente_Inicializar(Me, Nothing)
    End Sub

    Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoContribuyentes)
        Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
    End Sub

    Private Sub FrmMantenimientoContribuyente_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
        MyBase.Tabla = "Contribuyente"
    End Sub
#End Region

    Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.BindingSource1 = Nothing
    End Sub
End Class
