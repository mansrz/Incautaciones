Imports Infoware.Datos
Imports Infoware.Reglas.General
'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmListaUnidadMedidaConversiones
  Private mUnidadMedidaConversion As UnidadMedidaConversion = Nothing
  Public Property UnidadMedidaConversion() As UnidadMedidaConversion
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As UnidadMedidaConversion)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _UnidadMedidaConversion As UnidadMedidaConversion In Me.ListBindingSource.DataSource
          If _UnidadMedidaConversion.Pardet_Unidadmedida = value.Pardet_Unidadmedida And _UnidadMedidaConversion.Pardet_Unidadmedidadestino = value.Pardet_Unidadmedidadestino Then
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
  Private Sub FrmListaUnidadMedidaConversiones_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaClientes_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaUnidadMedidaConversiones_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    MyBase.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoUnidadMedidaConversion(Sistema, Restriccion, Enumerados.EnumOpciones.ListadoItems)
    f.OperadorDatos = Sistema.OperadorDatos
    f.UnidadMedidaConversiones = ListBindingSource
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
  End Sub

  Private Sub FrmListaUnidadMedidaConversiones_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaUnidadMedidaConversiones_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaUnidadMedidaConversiones_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mPardetUnidadMedidas Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mUnidadMedidaConversion As UnidadMedidaConversion
    mUnidadMedidaConversion = ListBindingSource.Current
    If mUnidadMedidaConversion.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar Unidad Medida Conversión" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub FrmListaUnidadMedidaConversiones_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mPardetUnidadMedidas As UnidadMedidaConversionList = Nothing

  'Private Sub Formatear(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
  '  If DataGridView1.Columns(e.ColumnIndex).HeaderText = "Imagen" Then
  '    Dim _PardetUnidadMedida as ParametroDet
  '    _PardetUnidadMedida = CType(Me.DataGridView1.DataSource.datasource, Infoware.Reglas.SortedView)(e.RowIndex)

  '    e.Value = _PardetUnidadMedida.PardetUnidadMedida_Imagen
  '  End If
  'End Sub

  Private Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Unidad Medida Conversión"
    MyBase.AgregarLeyenda = "Agregar una nueva Unidad Medida Conversión"

    'Me.DataGridView1.Columns.Clear()

    If Me.ComboBoxParametroDet1.ParametroDet Is Nothing Then
      Exit Sub
    End If

    'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "PardetUnidadMedidaFteString"
    'DataGridViewTextBoxColumn1.HeaderText = "De"
    'DataGridViewTextBoxColumn1.Width = 130
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "PardetUnidadMedidaDsnoString"
    'DataGridViewTextBoxColumn1.HeaderText = "a"
    'DataGridViewTextBoxColumn1.Width = 130
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.ListBindingSource.DataSource = GetType(UnidadMedidaConversion)
    mPardetUnidadMedidas = UnidadMedidaConversionList.ObtenerLista(Me.ComboBoxParametroDet1.ParametroDet)
    Dim mPardetUnidadMedidassort As New Infoware.Reglas.SortedView(mPardetUnidadMedidas)
    ListBindingSource.DataSource = mPardetUnidadMedidassort
    Me.DataGridView1.AutoDiscover()
  End Sub

  Private Sub mPardetUnidadMedidas_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mPardetUnidadMedidas.AddingNew
    Dim _PardetUnidadMedida As UnidadMedidaConversion = New UnidadMedidaConversion(Me.ComboBoxParametroDet1.ParametroDet, True)
    e.NewObject = _PardetUnidadMedida
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    EsBusqueda = _busqueda
    'Me.PuedeNuevo = False
    ' Add any initialization after the InitializeComponent() call.
    FrmListaBodegas_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _OpcionNuevo)
  End Sub

  Private Sub FrmListaBodegas_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.ComboBoxParametroDet1.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxParametroDet1.Parametro = Enumerados.EnumParametros.UnidadMedida
    Me.ComboBoxParametroDet1.Llenar_Datos()
    Llenar_datos()
  End Sub
#End Region

  Private Sub ComboBoxParametroDet1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxParametroDet1.CambioItem
    Llenar_datos()
  End Sub

  Private Sub FrmListaUnidadMedidaConversiones_DespuesSeleccionarCampos(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DespuesSeleccionarCampos
    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

    Dim estilonum2 As New DataGridViewCellStyle()
    estilonum2.Format = "N6"

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Unmeco_Factor"
    DataGridViewTextBoxColumn1.HeaderText = "Factor"
    DataGridViewTextBoxColumn1.Width = 90
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
  End Sub
End Class
