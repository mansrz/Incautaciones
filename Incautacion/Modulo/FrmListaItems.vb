Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

'Imports WWTS.Inventario.Reglas

Public Class FrmListaItems
  Public Property Sucursal() As Sucursal
    Get
      Return mSucursal
    End Get
    Set(ByVal value As Sucursal)
      mSucursal = value
            Llenar_datos()
    End Set
  End Property

  Private Sub FrmListaAfiliados_DespuesSeleccionarCampos(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DespuesSeleccionarCampos
        'Dim DataGridViewImageColumn1 As DataGridViewImageColumn
        'DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        'DataGridViewImageColumn1.DataPropertyName = "Item_Imagen"
        'DataGridViewImageColumn1.HeaderText = "Imagen"
        'DataGridViewImageColumn1.ValuesAreIcons = False
        'DataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom
        'DataGridViewImageColumn1.Width = 50
        'Me.DataGridView1.Columns.Insert(0, DataGridViewImageColumn1)

    Dim estilonum2 As New DataGridViewCellStyle()
    estilonum2.Format = "N2"

    If mSucursal IsNot Nothing Then
      Dim _bodegas As BodegaList = BodegaList.ObtenerLista(Sistema.OperadorDatos)
      For t As Integer = 1 To _bodegas.Count
        If _bodegas(t - 1).Empres_Codigo = mSucursal.Empres_Codigo And _bodegas(t - 1).Sucurs_Codigo = mSucursal.Sucurs_Codigo Then
          Dim DataGridViewTextBoxColumn1 As New System.Windows.Forms.DataGridViewTextBoxColumn
          DataGridViewTextBoxColumn1.DataPropertyName = "SaldoBodega" & t.ToString.Trim
          DataGridViewTextBoxColumn1.HeaderText = _bodegas(t - 1).NombreCompleto
          DataGridViewTextBoxColumn1.Width = 65
          DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
          Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
        End If
      Next
    End If
  End Sub

  Private Sub FrmListaAfiliados_FormatearCelda(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Me.FormatearCelda
    If DesignMode Then
      Exit Sub
    End If
    If DataGridView1.Columns(e.ColumnIndex).HeaderText = "Imagen" Then
      Try
        Dim _item As Item
        _item = CType(Me.DataGridView1.DataSource.datasource, Infoware.Reglas.SortedView)(e.RowIndex)
        If _item.Item_Imagen Is Nothing Then
          e.Value = My.Resources.sinfoto
        Else
          e.Value = _item.Item_Imagen
        End If

      Catch ex As Exception

      End Try
    End If
  End Sub

  Private mItem As Item = Nothing
  Public Property Item() As Item
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As Item)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _Item As Item In Me.ListBindingSource.DataSource
          If _Item.Item_Codigo = value.Item_Codigo Then
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
  Private Sub FrmListaItems_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaClientes_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaItems_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    MyBase.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoItem(Sistema, Restriccion, mSucursal)
    f.Items = ListBindingSource
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    
    f.Dispose()
  End Sub

  Private Sub FrmListaItems_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaItems_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaItems_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mItems Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mItem As Item
    mItem = ListBindingSource.Current
    If mItem.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar Item" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub FrmListaItems_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mItems As ItemList = Nothing

  'Private Sub Formatear(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
  '  If DataGridView1.Columns(e.ColumnIndex).HeaderText = "Imagen" Then
  '    Dim _item As Item
  '    _item = CType(Me.DataGridView1.DataSource.datasource, Infoware.Reglas.SortedView)(e.RowIndex)

  '    e.Value = _item.Item_Imagen
  '  End If
  'End Sub

  Private Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Items"
    MyBase.AgregarLeyenda = "Agregar un nuevo Item"

    'Me.DataGridView1.Columns.Clear()

    ''Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    ''DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    ''DataGridViewTextBoxColumn0.DataPropertyName = "Client_Visible"
    ''DataGridViewTextBoxColumn0.HeaderText = "Activo"
    ''DataGridViewTextBoxColumn0.Width = 50
    ''Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Item_Codigo"
    'DataGridViewTextBoxColumn1.HeaderText = "Código"
    'DataGridViewTextBoxColumn1.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Item_Descripcion"
    'DataGridViewTextBoxColumn1.HeaderText = "Nombre del producto"
    'DataGridViewTextBoxColumn1.Width = 200
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'Dim DataGridViewImageColumn1 As DataGridViewImageColumn
    'DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
    'DataGridViewImageColumn1.DataPropertyName = "Item_Imagen"
    'DataGridViewImageColumn1.HeaderText = "Imagen"
    'DataGridViewImageColumn1.ValuesAreIcons = False
    'DataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom
    'DataGridViewImageColumn1.Width = 25
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewImageColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "GrupoString"
    'DataGridViewTextBoxColumn1.HeaderText = "Grupo"
    'DataGridViewTextBoxColumn1.Width = 70
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "MarcaString"
    'DataGridViewTextBoxColumn1.HeaderText = "Marca"
    'DataGridViewTextBoxColumn1.Width = 70
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "TipoInventarioString"
    'DataGridViewTextBoxColumn1.HeaderText = "Tipo de Inventario"
    'DataGridViewTextBoxColumn1.Width = 70
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "Item_Aplicaiva"
    'DataGridViewTextBoxColumn0.HeaderText = "IVA"
    'DataGridViewTextBoxColumn0.Width = 45
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "Item_Estangible"
    'DataGridViewTextBoxColumn0.HeaderText = "Tangible"
    'DataGridViewTextBoxColumn0.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'Dim estilonum2 As New DataGridViewCellStyle()
    'estilonum2.Format = "N2"

    'Dim _bodegas As BodegaList = BodegaList.ObtenerLista(mSucursal.OperadorDatos)
    'For t As Integer = 1 To _bodegas.Count
    '  If _bodegas(t - 1).Sucurs_Codigo = mSucursal.Sucurs_Codigo Then
    '    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    '    DataGridViewTextBoxColumn1.DataPropertyName = "SaldoBodega" & t.ToString.Trim
    '    DataGridViewTextBoxColumn1.HeaderText = _bodegas(t - 1).NombreCompleto
    '    DataGridViewTextBoxColumn1.Width = 65
    '    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    '    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
    '  End If
    'Next

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Item_CodigoAuxiliar"
    'DataGridViewTextBoxColumn1.HeaderText = "Código auxiliar"
    'DataGridViewTextBoxColumn1.Width = 90
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Item_CodigoProveedor"
    'DataGridViewTextBoxColumn1.HeaderText = "Código proveedor"
    'DataGridViewTextBoxColumn1.Width = 90
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.ListBindingSource.DataSource = GetType(Item)
        mItems = ItemList.ObtenerLista(Sistema.OperadorDatos, Nothing, Nothing, _filtro, BarraEmpresa1.Empresa)
        Dim mitemssort As New Infoware.Reglas.SortedView(mItems)
    ListBindingSource.DataSource = mitemssort
    Me.DataGridView1.AutoDiscover()
  End Sub

  Private Sub mItems_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mItems.AddingNew
    Dim _Item As Item = New Item(mSucursal.OperadorDatos, True)
    e.NewObject = _Item
  End Sub
#End Region

  Private Sub DataGridView1_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
    If DesignMode Then
      Exit Sub
    End If
    If e.ColumnIndex = -1 Or e.ColumnIndex <> 2 Or e.RowIndex = -1 Then
      Me.btnmostrar.Visible = False
      Me.ToolTipImage1.Hide(Me.btnmostrar)
      Exit Sub
    End If
    Me.btnmostrar.Visible = True
    Dim rec As Rectangle = Me.DataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
    Me.btnmostrar.Location = New Point(e.Location.X + rec.X + Me.DataGridView1.Location.X, e.Location.Y + rec.Y + DataGridView1.Location.Y)

    Dim _item As Item
    '_item = mItems(e.RowIndex)
    _item = CType(Me.DataGridView1.DataSource.datasource, Infoware.Reglas.SortedView)(e.RowIndex)
    Me.ToolTipImage1.SetToolTipImageTitle(Me.btnmostrar, "Item #" & _item.Item_Codigo)
    Me.ToolTipImage1.SetToolTipImageImage(Me.btnmostrar, _item.Item_Imagen(100))
    Me.ToolTipImage1.SetToolTipImageText(Me.btnmostrar, _item.Item_Descripcion)
    Me.ToolTipImage1.SetToolTipImageIcon(Me.btnmostrar, _item.PardetGrupo.Pardet_Imagen(25))
    Me.ToolTipImage1.Show("Descripción", Me.btnmostrar)
  End Sub

#Region "New"
  Private mSucursal As Sucursal = Nothing

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Usuarios)
    MyBase.New(_Sistema, _Restriccion, _busqueda, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    EsBusqueda = _busqueda
    'AddHandler Me.DataGridView1.CellMouseMove, AddressOf Me.DataGridView1_CellMouseMove
        Forma_Inicializar(Me, Nothing)
        Me.PuedeNuevo = False
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Usuarios)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _OpcionNuevo)
  End Sub

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.BarraEmpresa1.Sistema = Sistema
    Me.BarraEmpresa1.Llenar_datos()
    Me.Sucursal = Me.BarraEmpresa1.Sucursal
    Llenar_datos(Me.combobuscar.Text)
    Me.DataGridView1.RowTemplate.Height = 100
  End Sub
#End Region

  Private Sub BarraEmpresa1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraEmpresa1.CambioDatos
    Me.Sucursal = Me.BarraEmpresa1.Sucursal
  End Sub
End Class
