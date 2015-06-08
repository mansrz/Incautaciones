Imports System.Windows.Forms.SendKeys
Imports Infoware.Reglas.General

'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Infoware.Datos
Imports Incautacion.Reglas

Public Class CtlBuscaItem
  Public ReadOnly Property Sistema() As Sistema
    Get
      Return CType(Me.ParentForm, FrmFormaBase).Sistema
    End Get
  End Property

  Public Enum EnumUbicacion
    Normal = 0
    Abajo = 1
  End Enum
  Private mUbicacion As EnumUbicacion = EnumUbicacion.Normal
  Public Property Ubicacion() As EnumUbicacion
    Get
      Return mUbicacion
    End Get
    Set(ByVal value As EnumUbicacion)
      mUbicacion = value
      Select Case mUbicacion
        Case EnumUbicacion.Normal
          Me.ComboBox1.Location = New Point(124, 0)
          Me.ComboBox1.Size = New Size(Me.Width - 124, 23)
        Case EnumUbicacion.Abajo
          Me.ComboBox1.Location = New Point(0, 24)
          Me.ComboBox1.Size = New Size(Me.Width, 23)
      End Select
    End Set
  End Property
  Public Event CambioItem As EventHandler

  Private mSucursal As Sucursal = Nothing
  Public WriteOnly Property Sucursal() As Sucursal
    Set(ByVal value As Sucursal)
      mSucursal = value

      If value IsNot Nothing Then
        llenar_datos()
      End If
    End Set
  End Property

    Private mIncautacion As Reglas.Incautacion = Nothing
    Public Property Incautacion As Reglas.Incautacion
        Get
            Return mIncautacion
        End Get
        Set(value As Reglas.Incautacion)
            mIncautacion = value
        End Set
    End Property


  Private mEstaCargando = False

  Sub llenar_datos()
    Me.ComboBox1.DisplayMember = "Item_Descripcion"
    Me.ComboBox1.ValueMember = "Item_Codigo"
    If mPardetTipoInventario IsNot Nothing Then
      mItems = ItemList.ObtenerLista(mSucursal.OperadorDatos, Nothing, mPardetTipoInventario)
    Else
      mItems = ItemList.ObtenerLista(mSucursal.OperadorDatos)
    End If
    mEstaCargando = True
    Me.ComboBox1.DataSource = mItems
    Me.ComboBox1.SelectedIndex = -1
    mEstaCargando = False
  End Sub

  Public Property ItemText() As String
    Get
      Return Me.btn_Item.Text
    End Get
    Set(ByVal value As String)
      Me.btn_Item.Text = value
    End Set
  End Property

  Private mPardetTipoInventario As WWTSParametroDet = Nothing
  Public Property PardetTipoInventario As WWTSParametroDet
    Get
      Return mPardetTipoInventario
    End Get
    Set(ByVal value As WWTSParametroDet)
      mPardetTipoInventario = value
    End Set
  End Property

  Private mItems As ItemList = Nothing
  <System.ComponentModel.Browsable(False)> _
  Public Property Item() As Item
    Get
      If Me.ComboBox1.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mItems(Me.ComboBox1.SelectedIndex)
      End If
    End Get
    Set(ByVal value As Item)
      If value Is Nothing Then
        If Not Me.ComboBox1.SelectedIndex = -1 Then
          Me.ComboBox1.SelectedIndex = -1
        End If
        'If mItems IsNot Nothing AndAlso mItems.Count > 0 Then
        '  Me.ComboBox1.SelectedIndex = 0
        '  cambiar_item()
        'End If
      Else
        Me.ComboBox1.SelectedValue = value.Item_Codigo
      End If
    End Set
  End Property

  Private Sub btn_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Item.Click, BuscarToolStripMenuItem.Click
    abrir_consulta()
  End Sub

  Private Sub abrir_consulta(Optional ByVal filtro As String = "")
    Dim _items As ItemList
    If mPardetTipoInventario IsNot Nothing Then
      _items = ItemList.ObtenerLista(mSucursal.OperadorDatos, Nothing, mPardetTipoInventario, filtro)
    Else
      _items = ItemList.ObtenerLista(mSucursal.OperadorDatos, Nothing, Nothing, filtro)
    End If

    If _items.Count = 1 Then
      mItems = ItemList.ObtenerLista(mSucursal.OperadorDatos)
      Item = _items(0)
      RaiseEvent CambioItem(Me, Nothing)
      Exit Sub
    End If

    Dim f As New FrmListaItems(Sistema, Enumerados.EnumOpciones.ListadoItems, True, Enumerados.EnumOpciones.ListadoItems)
    f.Item = Item
    f.Filtro = filtro
    f.Sucursal = mSucursal
    If f.ShowDialog() = DialogResult.OK Then
      mItems = ItemList.ObtenerLista(mSucursal.OperadorDatos)
      mEstaCargando = True
      Me.ComboBox1.DataSource = mItems
      mEstaCargando = False
      Item = f.Item
      RaiseEvent CambioItem(Me, Nothing)
    End If
  End Sub

  Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
    Item = Nothing
    RaiseEvent CambioItem(Me, Nothing)
  End Sub

  Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
    If e.KeyCode = Keys.Enter Then
      If Me.ComboBox1.SelectedIndex = -1 Then
        abrir_consulta(Me.ComboBox1.Text)
      End If
      Send("{TAB}")
      e.Handled = True
    End If
  End Sub

  Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
    If Not mEstaCargando Then
      cambiar_item()
    End If
  End Sub

  Private Sub cambiar_item()
    If Me.ComboBox1.SelectedIndex >= 0 AndAlso mItems IsNot Nothing Then
      Item = mItems(Me.ComboBox1.SelectedIndex)
      RaiseEvent CambioItem(Me, Nothing)
    End If
  End Sub

  Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    Dim f As New FrmMantenimientoItem(Sistema, Enumerados.EnumOpciones.ListadoItems, mSucursal)
    f.Item = New Item(Sistema.OperadorDatos, True)
    f.ShowDialog()

    If f.Item IsNot Nothing AndAlso Not f.Item.EsNuevo Then
      llenar_datos()
      Me.ComboBox1.SelectedValue = f.Item.Item_Codigo
    End If

    f.Dispose()
  End Sub
End Class
