Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base 
Imports Incautacion.Reglas

Public Class FrmListaSucursales
  Public Property Empresa() As Empresa
    Get
      Return mEmpresa
    End Get
    Set(ByVal value As Empresa)
      mEmpresa = value
      Llenar_datos()
    End Set
  End Property

  Private mSucursal As Sucursal = Nothing
  Public Property Sucursal() As Sucursal
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As Sucursal)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _Sucursal As Sucursal In Me.ListBindingSource.DataSource
          If _Sucursal.Empres_Codigo = value.Empres_Codigo And _Sucursal.Sucurs_Codigo = value.Sucurs_Codigo Then
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
  Private Sub FrmListaSucursales_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaSucursales_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaSucursales_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoSucursal(Sistema, Restriccion)
    f.Sucursal = ListBindingSource.Current
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
    Dim _esnuevo As Boolean = CType(ListBindingSource.Current, Sucursal).EsNuevo
    If _esnuevo AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    End If
  End Sub

  Private Sub FrmListaSucursales_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaSucursales_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaSucursales_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mSucursales Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mSucursal As Sucursal
    mSucursal = ListBindingSource.Current
    If mSucursal.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar Sucursal" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub FrmListaSucursales_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mSucursales As SucursalList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
        MyBase.Titulo = "Bodega"
        MyBase.AgregarLeyenda = "Agregar una nueva bodega"

    'Me.DataGridView1.Columns.Clear()

    If mEmpresa Is Nothing Then
      Exit Sub
    End If
    'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Usuari_Codigo"
    'DataGridViewTextBoxColumn1.HeaderText = "Código"
    'DataGridViewTextBoxColumn1.Width = 150
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Usuari_Descripcion"
    'DataGridViewTextBoxColumn1.HeaderText = "Descripción"
    'DataGridViewTextBoxColumn1.Width = 300
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.ListBindingSource.DataSource = GetType(Sucursal)
    mSucursales = SucursalList.ObtenerLista(mEmpresa, _filtro)
    Dim mitemssort As New Infoware.Reglas.SortedView(mSucursales)
    ListBindingSource.DataSource = mitemssort
    Me.DataGridView1.AutoDiscover()
  End Sub

  Private Sub mSucursales_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mSucursales.AddingNew
    Dim _Sucursal As Sucursal = New Sucursal(mEmpresa, True)
    e.NewObject = _Sucursal
  End Sub
#End Region


#Region "New"
  Private mEmpresa As Empresa = Nothing

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, ByVal _Empresa As Empresa, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _busqueda, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    mEmpresa = _Empresa
    ' Add any initialization after the InitializeComponent() call.
    FrmListaSucursales_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, ByVal _Empresa As Empresa, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _Empresa, _OpcionNuevo)
  End Sub

  Private Sub FrmListaSucursales_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.BarraEmpresa1.Sistema = Sistema
    Me.BarraEmpresa1.Llenar_datos()
    Me.Empresa = Me.BarraEmpresa1.Empresa
    Llenar_datos()
  End Sub
#End Region

  Private Sub BarraEmpresa1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraEmpresa1.CambioDatos
    Me.Empresa = Me.BarraEmpresa1.Empresa
  End Sub
End Class
