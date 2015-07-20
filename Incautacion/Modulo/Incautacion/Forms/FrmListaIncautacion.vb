Imports Infoware.Datos
Imports Infoware.Reglas.General
'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmListaIncautacion
    Private mSucursal As Sucursal = Nothing
    Public Property Sucursal() As Sucursal
        Get
            Return mSucursal
        End Get
        Set(ByVal value As Sucursal)
            mSucursal = value
            'Llenar_datos()
        End Set
    End Property

    Private mContribuyente As Contribuyente = Nothing
    Public Property Contribuyente As Contribuyente
        Get
            Return mContribuyente
        End Get
        Set(value As Contribuyente)
            mContribuyente = value
        End Set
    End Property

    Private mIncautacion As Reglas.Incautacion = Nothing
    Public Property Incautacion() As Reglas.Incautacion
        Get
            If ListBindingSource.Current Is Nothing Then
                Return Nothing
            Else
                Return ListBindingSource.Current
            End If
        End Get
        Set(value As Reglas.Incautacion)
            If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
                Dim t As Integer = 0
                For Each _Incautacion As Reglas.Incautacion In Me.ListBindingSource.DataSource
                    If _Incautacion.Incaut_Codigo = value.Incaut_Codigo Then
                        ListBindingSource.Position = t
                    End If
                    t += 1
                Next
            End If
        End Set
    End Property

    Public Property Filtro() As String
        Get
            Return MyBase.combobuscar.Text
        End Get
        Set(ByVal value As String)
            MyBase.combobuscar.Text = value
            MyBase.Hacer_busqueda()
        End Set
    End Property

#Region "Eventos"
    Private Sub FrmListaIncautacion_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
        Abrir_Mantenimiento()
    End Sub

    Private Sub FrmListaIncautacion_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub FrmListaIncautacion_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
        Me.ListBindingSource.AddNew()
        Abrir_Mantenimiento()
    End Sub

    Sub Abrir_Mantenimiento()
        If ListBindingSource.Current Is Nothing Then
            Exit Sub
        End If

        Dim f As New FrmMantenimientoIncautacion(Sistema, Restriccion, Enumerados.EnumOpciones.ListadoBodegas)
        f.Sucursal = mSucursal
        f.Incautaciones = ListBindingSource
        f.Contribuyente = mContribuyente
        f.ShowDialog()
        If ListBindingSource.Count <= 1 Then
            RefrescarLista()
        End If
        f.Dispose()
    End Sub

    Private Sub FrmListaIncautacion_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
        Llenar_datos(Me.combobuscar.Text)
    End Sub

    Private Sub FrmListaIncautacion_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
        Llenar_datos()
    End Sub

    Private Sub FrmListaIncautacion_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
        If mIncautaciones Is Nothing OrElse ListBindingSource.Current Is Nothing Then
            Exit Sub
        End If
        Dim mIncautacion As Reglas.Incautacion
        mIncautacion = ListBindingSource.Current
        If mIncautacion.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
            ListBindingSource.RemoveCurrent()
        Else
            MsgBox("No se puede eliminar la Incautacion" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub FrmListaIncautacion_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
        'imprimir
    End Sub
#End Region

#Region "Llenardatos"
    Private WithEvents mIncautaciones As IncautacionList = Nothing

    Sub Llenar_datos(Optional ByVal _filtro As String = "")
        MyBase.Titulo = "Incautaciones"
        MyBase.AgregarLeyenda = "Agregar una nueva Incautación"

        If mSucursal Is Nothing Then
            Exit Sub
        End If

        If Sucursal.Empresa Is Nothing Then
            MessageBox.Show("Empresa es nada")
        End If

        Me.ListBindingSource.DataSource = GetType(Incautacion.Reglas.Incautacion)
        mIncautaciones = IncautacionList.ObtenerLista(Sucursal.Empresa, Contribuyente, _filtro)

        Dim mitemssort As New Infoware.Reglas.SortedView(mIncautaciones)
        ListBindingSource.DataSource = mitemssort
        Me.DataGridView1.AutoDiscover()
    End Sub

    Private Sub mBodegas_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mIncautaciones.AddingNew
        Dim _Incautacion As Reglas.Incautacion = New Reglas.Incautacion(Sistema.OperadorDatos, True)
        e.NewObject = _Incautacion
    End Sub
#End Region

#Region "New"

    Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, Optional ByVal _Contribuyente As Contribuyente = Nothing, Optional ByVal _Sucursal As Sucursal = Nothing, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListaIncautaciones)
        MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        EsBusqueda = _busqueda
        If _Sucursal IsNot Nothing Then
            mSucursal = _Sucursal
        End If
        If _Contribuyente IsNot Nothing Then
            mContribuyente = Contribuyente
        End If

        ' Add any initialization after the InitializeComponent() call.
        FrmListaIncautacion_Inicializar(Me, Nothing)
    End Sub

    Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _Contribuyente As Contribuyente = Nothing, Optional ByVal _Sucursal As Sucursal = Nothing, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListaIncautaciones)
        Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _Contribuyente, _Sucursal, _OpcionNuevo)
    End Sub

    Private Sub FrmListaIncautacion_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
        Me.BarraEmpresa1.Sistema = Sistema
        Me.BarraEmpresa1.Llenar_datos()
        Me.Sucursal = Me.BarraEmpresa1.Sucursal
        Llenar_datos()
    End Sub
#End Region

    Private Sub BarraEmpresa1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraEmpresa1.CambioDatos
        Me.Sucursal = Me.BarraEmpresa1.Sucursal
    End Sub
End Class
