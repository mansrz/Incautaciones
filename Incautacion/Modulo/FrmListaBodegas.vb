Imports Infoware.Datos
Imports Infoware.Reglas.General
'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmListaBodegas
    Private mSucursal As Sucursal = Nothing
    Public Property Sucursal() As Sucursal
        Get
            Return mSucursal
        End Get
        Set(ByVal value As Sucursal)
            mSucursal = value
            Llenar_datos()
        End Set
    End Property

    Private mBodega As Bodega = Nothing
    Public Property Bodega() As Bodega
        Get
            If ListBindingSource.Current Is Nothing Then
                Return Nothing
            Else
                Return ListBindingSource.Current
            End If
        End Get
        Set(ByVal value As Bodega)
            If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
                Dim t As Integer = 0
                For Each _Bodega As Bodega In Me.ListBindingSource.DataSource
                    If _Bodega.Sucurs_Codigo = value.Sucurs_Codigo And _Bodega.Bodega_Codigo = value.Bodega_Codigo Then
                        ListBindingSource.Position = t
                    End If
                    t += 1
                Next
            End If
        End Set
    End Property

#Region "Eventos"
    Private Sub FrmListaBodegas_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
        Abrir_Mantenimiento()
    End Sub

    Private Sub FrmListaBodegas_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub FrmListaBodegas_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
        Me.ListBindingSource.AddNew()
        Abrir_Mantenimiento()
    End Sub

    Sub Abrir_Mantenimiento()
        If ListBindingSource.Current Is Nothing Then
            Exit Sub
        End If

        Dim f As New FrmMantenimientoBodega(Sistema, Restriccion, Enumerados.EnumOpciones.ListadoBodegas)
        f.Sucursal = mSucursal
        f.Bodegas = ListBindingSource
        f.ShowDialog()
        If ListBindingSource.Count <= 1 Then
            RefrescarLista()
        End If
        f.Dispose()
    End Sub

    Private Sub FrmListaBodegas_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
        Llenar_datos(Me.combobuscar.Text)
    End Sub

    Private Sub FrmListaBodegas_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
        Llenar_datos()
    End Sub

    Private Sub FrmListaBodegas_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
        If mBodegas Is Nothing OrElse ListBindingSource.Current Is Nothing Then
            Exit Sub
        End If
        Dim mBodega As Bodega
        mBodega = ListBindingSource.Current
        If mBodega.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
            ListBindingSource.RemoveCurrent()
        Else
            MsgBox("No se puede eliminar Bodega" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub FrmListaBodegas_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
        'imprimir
    End Sub
#End Region

#Region "Llenardatos"
    Private WithEvents mBodegas As BodegaList = Nothing

    Sub Llenar_datos(Optional ByVal _filtro As String = "")
        MyBase.Titulo = "Bodegas virtuales"
        MyBase.AgregarLeyenda = "Agregar una nueva Bodega virtual"

        If mSucursal Is Nothing Then
            Exit Sub
        End If
        'Me.DataGridView1.Columns.Clear()

        'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        'DataGridViewTextBoxColumn1.DataPropertyName = "Bodega_Codigo"
        'DataGridViewTextBoxColumn1.HeaderText = "Código"
        'DataGridViewTextBoxColumn1.Width = 120
        'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        'DataGridViewTextBoxColumn1.DataPropertyName = "NombreCompleto"
        'DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        'DataGridViewTextBoxColumn1.Width = 250
        'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        'Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
        'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        'DataGridViewTextBoxColumn0.DataPropertyName = "Bodega_Visible"
        'DataGridViewTextBoxColumn0.HeaderText = "Visible"
        'DataGridViewTextBoxColumn0.Width = 50
        'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

        Me.ListBindingSource.DataSource = GetType(Bodega)
        mBodegas = BodegaList.ObtenerLista(mSucursal, _filtro)
        Dim mitemssort As New Infoware.Reglas.SortedView(mBodegas)
        ListBindingSource.DataSource = mitemssort
        Me.DataGridView1.AutoDiscover()
    End Sub

    Private Sub mBodegas_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mBodegas.AddingNew
        Dim _Bodega As Bodega = New Bodega(mSucursal, True)
        e.NewObject = _Bodega
    End Sub
#End Region

#Region "New"
    Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Usuarios)
        MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        EsBusqueda = _busqueda
        ' Add any initialization after the InitializeComponent() call.
        FrmListaBodegas_Inicializar(Me, Nothing)
    End Sub

    Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Usuarios)
        Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _OpcionNuevo)
    End Sub

    Private Sub FrmListaBodegas_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
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
