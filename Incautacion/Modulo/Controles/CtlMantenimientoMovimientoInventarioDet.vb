Imports Infoware.Reglas.General
Imports Incautacion.Reglas

Public Class CtlMantenimientoMovimientoInventarioDet

  Private mMovimientoInventarioDet As MovimientoInventarioDet = Nothing

  Public Property MovimientoInventarioDet As MovimientoInventarioDet
    Get
      Return mMovimientoInventarioDet
    End Get
    Set(ByVal value As MovimientoInventarioDet)
      mMovimientoInventarioDet = value
      llenar_datos()
    End Set
  End Property

  Private mVerConfidencial As Boolean = False
  Public Property VerConfidencial As Boolean
    Get
      Return mVerConfidencial
    End Get
    Set(ByVal value As Boolean)
      mVerConfidencial = value
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

  Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged
    If BindingSource1 Is Nothing Then
      Exit Sub
    End If
    MovimientoInventarioDet = BindingSource1.Current
  End Sub

  Sub llenar_datos()
    If mMovimientoInventarioDet Is Nothing Then
      Me.Enabled = False
      Exit Sub
    End If

    Me.Enabled = mMovimientoInventarioDet.EsNuevo
    mEstaCambiando = True
    Me.CtlBuscaItem1.PardetTipoInventario = mPardetTipoInventario
    Me.CtlBuscaItem1.Sucursal = mMovimientoInventarioDet.MovimientoInventario.Sucursal
    Me.CtlBuscaItem1.Item = mMovimientoInventarioDet.Item

    If Me.CtlBuscaItem1.Item IsNot Nothing Then
      Me.CtlBuscaItem1.Enabled = Not Me.CtlBuscaItem1.Item.Item_Combo
    End If

    enumTipoMovInv = mMovimientoInventarioDet.MovimientoInventario.Pardet_TipomovinvEnum
    If mMovimientoInventarioDet.MovimientoInventario.Venta IsNot Nothing Then
      PardetTipoPrecio = mMovimientoInventarioDet.MovimientoInventario.Venta.PardetTipoPrecio
    End If

    Me.ComboBoxUnidadMedida.OperadorDatos = mMovimientoInventarioDet.OperadorDatos
    Me.txtcantidad.Value = mMovimientoInventarioDet.Moinde_Cantidad

    If mMovimientoInventarioDet.Item IsNot Nothing Then

      Me.ComboBoxUnidadMedida.Parametro = Enumerados.EnumParametros.UnidadMedida
      Me.ComboBoxUnidadMedida.Llenar_Datos(ParametroDetList.enumTipoObjeto.UnidadMedida, Me.CtlBuscaItem1.Item.PardetUnidadMedida)
      '    Me.ComboBoxUnidadMedida.ParametroDet = mMovimientoInventarioDet.PardetUnidadMedida

      If mMovimientoInventarioDet.Item IsNot Nothing Then
        'Me.txtobservacion.Text = mMovimientoInventarioDet.Moinde_Descripcion
        Me.ComboBoxUnidadMedida.ParametroDet = mMovimientoInventarioDet.PardetUnidadMedida
        Me.txtvalor.Value = mMovimientoInventarioDet.Moinde_Valor
        Me.txtdescto.Value = mMovimientoInventarioDet.Moinde_Descto
        Me.chkaplicaiva.Checked = mMovimientoInventarioDet.Moinde_Aplicaiva
        Me.txt_descripcionlugar.Text = mMovimientoInventarioDet.Moinde_DescripcionLugar
        Me.txt_marca.Text = mMovimientoInventarioDet.Moinde_Marca
        Me.txt_modelo.Text = mMovimientoInventarioDet.Moinde_Modelo
      End If
      Me.CtlBuscaItem1.Select()

      Me.BSSeries.DataSource = MovimientoInventarioDet.DetallesSeries
      Me.DGSeries.AutoDiscover()
      Me.pnlserie.Visible = Me.CtlBuscaItem1.Item.Item_esRegistroSerie
      If Me.pnlserie.Visible Then
        Me.txtcantidad.Value = Me.BSSeries.Count
      End If

      Me.CtlBuscaItem1.Focus()
    End If
    mEstaCambiando = False
    CambioItem()
  End Sub

  Public Event Actualizodatos As EventHandler

  Private Sub Mapear_datos()
    Try
      mMovimientoInventarioDet.Item = Me.CtlBuscaItem1.Item
      'mMovimientoInventarioDet.Moinde_Descripcion = Me.txtobservacion.Text
      mMovimientoInventarioDet.Moinde_Cantidad = Me.txtcantidad.Value
      mMovimientoInventarioDet.PardetUnidadMedida = Me.ComboBoxUnidadMedida.ParametroDet
      mMovimientoInventarioDet.Moinde_Valor = Me.txtvalor.Value
      mMovimientoInventarioDet.Moinde_Descto = Me.txtdescto.Value
      mMovimientoInventarioDet.Moinde_Aplicaiva = Me.chkaplicaiva.Checked
      mMovimientoInventarioDet.Moinde_DescripcionLugar = Me.txt_descripcionlugar.Text
      mMovimientoInventarioDet.Moinde_Modelo = Me.txt_modelo.Text
      mMovimientoInventarioDet.Moinde_Marca = Me.txt_marca.Text
      RaiseEvent Actualizodatos(Me, Nothing)
    Catch ex As Exception

    End Try

  End Sub

  Public Sub Eliminar()
    If mMovimientoInventarioDet IsNot Nothing AndAlso mMovimientoInventarioDet.Eliminar() Then
      Me.BindingSource1.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar MovimientoInventarioDet" & Environment.NewLine & mMovimientoInventarioDet.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private mEstaCambiando As Boolean = True
  Private mPardetTipoPrecio As ParametroDet = Nothing
  Public Property PardetTipoPrecio() As ParametroDet
    Get
      Return mPardetTipoPrecio
    End Get
    Set(ByVal value As ParametroDet)
      mPardetTipoPrecio = value
    End Set
  End Property

  Private menumTipoMovInv As Enumerados.enumTipoMovInv = Enumerados.enumTipoMovInv.InvInicial
  Public Property enumTipoMovInv() As Enumerados.enumTipoMovInv
    Get
      Return menumTipoMovInv
    End Get
    Set(ByVal value As Enumerados.enumTipoMovInv)
      menumTipoMovInv = value

      Me.pnlvalor.Visible = False
      Me.pnldescto.Visible = False
      Select Case value
        Case Enumerados.enumTipoMovInv.AjustePos, Enumerados.enumTipoMovInv.AjusteNeg, Enumerados.enumTipoMovInv.Transferencia, Enumerados.enumTipoMovInv.Consumo, Enumerados.enumTipoMovInv.DesperdicioOP
        Case Enumerados.enumTipoMovInv.InvInicial
          Me.pnlvalor.Visible = True
        Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.DevVenta, Enumerados.enumTipoMovInv.Venta, Enumerados.enumTipoMovInv.DevCompra
          Me.pnlvalor.Visible = True
          Me.pnldescto.Visible = True
      End Select
    End Set
  End Property

#Region "Item"
  Private Sub CtlBuscaItem1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaItem1.CambioItem
    If mEstaCambiando OrElse Me.CtlBuscaItem1.Item Is Nothing Then
      Exit Sub
    End If
    mEstaCambiando = True
    Dim _unidmed As ParametroDet = Me.CtlBuscaItem1.Item.PardetUnidadMedida
    Me.ComboBoxUnidadMedida.Llenar_Datos(ParametroDetList.enumTipoObjeto.UnidadMedida, Me.CtlBuscaItem1.Item.PardetUnidadMedida)
    Me.ComboBoxUnidadMedida.ParametroDet = _unidmed

    CambioItem()
    CambioUnidadMedida()
    mEstaCambiando = False
    Mapear_datos()
  End Sub

  Private Sub ComboBoxUnidadMedida_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxUnidadMedida.CambioItem, txtcantidad.Validated
    If mEstaCambiando Then
      Exit Sub
    End If
    CambioUnidadMedida()
  End Sub
  Private Sub CambioItem()
    Me.pnlcantidad.Enabled = Me.CtlBuscaItem1.Item IsNot Nothing
    Me.pnlvalor.Enabled = Me.CtlBuscaItem1.Item IsNot Nothing
    Me.pnldescto.Enabled = Me.CtlBuscaItem1.Item IsNot Nothing
    Me.pnlserie.Enabled = Me.CtlBuscaItem1.Item IsNot Nothing
    Me.pnlaccion.Enabled = Me.CtlBuscaItem1.Item IsNot Nothing

    If Me.CtlBuscaItem1.Item Is Nothing Then
      Exit Sub
    End If
    mEstaCambiando = True

    Me.PictureBox1.Image = Me.CtlBuscaItem1.Item.Item_Imagen
    Me.chkaplicaiva.Checked = Me.CtlBuscaItem1.Item.Item_Aplicaiva

    Me.txtcantidad.Enabled = Not Me.CtlBuscaItem1.Item.Item_esRegistroSerie And Not Me.CtlBuscaItem1.Item.Item_Combo
    Me.txtvalor.Enabled = Not Me.CtlBuscaItem1.Item.Item_Combo And VerConfidencial
    Me.txtdescto.Enabled = Not Me.CtlBuscaItem1.Item.Item_Combo And VerConfidencial
    Me.ComboBoxUnidadMedida.Enabled = Not Me.CtlBuscaItem1.Item.Item_esRegistroSerie And Not Me.CtlBuscaItem1.Item.Item_Combo
    If Me.ComboBoxUnidadMedida.Items.Count <= 1 Then
      Me.ComboBoxUnidadMedida.Enabled = False
    End If
    Me.pnlserie.Visible = Me.CtlBuscaItem1.Item.Item_esRegistroSerie
    If Me.CtlBuscaItem1.Item.Item_esRegistroSerie Then
      Me.BSSeries.DataSource = Me.MovimientoInventarioDet.DetallesSeries
      Me.DGSeries.AutoDiscover()
    End If
    Llenar_detallesExistencia()
    Llenar_detallesCombo()
    mEstaCambiando = False
  End Sub

  Private Sub CambioUnidadMedida()
    If mMovimientoInventarioDet.MovimientoInventario.Bodega Is Nothing Then
      Exit Sub
    End If
    Dim _valor As Decimal = Me.CtlBuscaItem1.Item.BuscarValor(mMovimientoInventarioDet.Pardet_Tipomovinv, mMovimientoInventarioDet.MovimientoInventario.Sucursal, mPardetTipoPrecio, mMovimientoInventarioDet.MovimientoInventario.Movinv_porcIVA, mMovimientoInventarioDet.MovimientoInventario.Bodega, Me.txtcantidad.Value)

    If Me.CtlBuscaItem1.Item.Item_PrecioxCantidad Then
      Me.ComboBoxUnidadMedida.ParametroDet = Me.CtlBuscaItem1.Item.PardetUnidadMedida
    End If

    If Me.ComboBoxUnidadMedida.ParametroDet Is Nothing Then
      Me.txtvalor.Value = _valor
    Else
      Dim _unidadmedidaconversion As UnidadMedidaConversion
      _unidadmedidaconversion = New UnidadMedidaConversion(Me.CtlBuscaItem1.Item.PardetUnidadMedida, Me.ComboBoxUnidadMedida.ParametroDet)
      Me.txtvalor.Value = _valor * (1 / _unidadmedidaconversion.Unmeco_Factor)
    End If

    Me.txtcantidad.TipoNumero = IIf(Me.ComboBoxUnidadMedida.ParametroDet.Pardet_DatoBit1, Infoware.Controles.Base.EnumTipoNumero.Decimales, Infoware.Controles.Base.EnumTipoNumero.Entero)
  End Sub

  Private Sub btnnuevoserie_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevoserie.Click
    If Me.BSSeries.DataSource Is Nothing Then
      Exit Sub
    End If
    Me.BSSeries.AddNew()
    Me.txtcantidad.Value = Me.BSSeries.Count
    Mapear_datos()
  End Sub

  Private Sub btneliserie_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btneliserie.Click
    If Me.BSSeries.Current Is Nothing Then
      Exit Sub
    End If
    Me.BSSeries.RemoveCurrent()
    Me.txtcantidad.Value = Me.BSSeries.Count
    Mapear_datos()
  End Sub

  Sub Llenar_detallesExistencia()
    Me.grpexistencias.Visible = Me.CtlBuscaItem1.Item.Item_Estangible
    If Not Me.CtlBuscaItem1.Item.Item_Estangible Then
      Exit Sub
    End If
    Me.DGExistencias.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "SucursalString"
    DataGridViewTextBoxColumn1.HeaderText = "Sucursal"
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.Width = 75
    Me.DGExistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "BodegaString"
    DataGridViewTextBoxColumn1.HeaderText = "Bodega"
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.Width = 75
    Me.DGExistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Itebod_Cantidad"
    DataGridViewTextBoxColumn1.HeaderText = "Cantidad"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.ReadOnly = True
    Dim estilonum2 As New DataGridViewCellStyle()
    estilonum2.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    Me.DGExistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Itebod_Costopromedio"
    'DataGridViewTextBoxColumn1.HeaderText = "Costo promedio"
    'DataGridViewTextBoxColumn1.Width = 60
    'DataGridViewTextBoxColumn1.ReadOnly = True
    'DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    'Me.DGExistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Itebod_StockMinimo"
    'DataGridViewTextBoxColumn1.HeaderText = "Mínimo"
    'DataGridViewTextBoxColumn1.Width = 60
    'DataGridViewTextBoxColumn1.ReadOnly = False
    'DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    'Me.DGExistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Itebod_StockMaximo"
    'DataGridViewTextBoxColumn1.HeaderText = "Máximo"
    'DataGridViewTextBoxColumn1.Width = 60
    'DataGridViewTextBoxColumn1.ReadOnly = False
    'DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    'Me.DGExistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.BindingSourceExistencias.DataSource = GetType(ItemxBodegaList)
    'mMovimientoInventarioDets = 
    BindingSourceExistencias.DataSource = Me.CtlBuscaItem1.Item.ItemxBodegas(mMovimientoInventarioDet.MovimientoInventario.Sucursal)
  End Sub

  Sub Llenar_detallesCombo()
    Me.grpcombo.Visible = Me.CtlBuscaItem1.Item.Item_Combo
    If Not Me.CtlBuscaItem1.Item.Item_Combo Then
      Exit Sub
    End If
    Me.DGCombo.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "ItemString"
    DataGridViewTextBoxColumn1.HeaderText = "Item"
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.Width = 125
    Me.DGCombo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Cantidad"
    DataGridViewTextBoxColumn1.HeaderText = "Cantidad"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.ReadOnly = True
    Dim estilonum2 As New DataGridViewCellStyle()
    estilonum2.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    Me.DGCombo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "UnidadMedidaString"
    DataGridViewTextBoxColumn1.HeaderText = "Unid"
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.Width = 75
    Me.DGCombo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Valor"
    DataGridViewTextBoxColumn1.HeaderText = "Valor"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.ReadOnly = True
    estilonum2.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    Me.DGCombo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Total"
    DataGridViewTextBoxColumn1.HeaderText = "Total"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.ReadOnly = True
    estilonum2.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    Me.DGCombo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.BSCombo.DataSource = GetType(ItemDetalle)
    'mMovimientoInventarioDets = 
    BSCombo.DataSource = Me.CtlBuscaItem1.Item.DetallesCombo(mMovimientoInventarioDet.MovimientoInventario.Sucursal)
  End Sub
#End Region

  Private Sub txtcantidad_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcantidad.TextChanged, txtdescto.TextChanged, txtvalor.TextChanged, chkaplicaiva.CheckedChanged
    If Not mEstaCambiando Then
      Mapear_datos()
    End If
  End Sub

  Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
    If Me.CtlBuscaItem1.Item Is Nothing Then
      Exit Sub
    End If
    Mapear_datos()
    VerificarCombo()
    ValidarRegistros()
    If CType(Me.BindingSource1.Item(Me.BindingSource1.Count - 1), MovimientoInventarioDet).Item IsNot Nothing Then
      Me.BindingSource1.AddNew()
    Else
      Me.BindingSource1.MoveLast()
    End If
  End Sub
  Sub ValidarRegistros()
    Dim contador As Integer = 0
    If MovimientoInventarioDet.Item.Item_esRegistroSerie Then


      While contador <> MovimientoInventarioDet.DetallesSeries.Count
        If MovimientoInventarioDet.DetallesSeries.Item(contador).Serie.Length < 1 Then
          Me.BSSeries.RemoveAt(contador)
          Me.txtcantidad.Value = Me.txtcantidad.Value - 1
          contador = contador - 1
        End If
        contador = contador + 1
      End While
    End If
  End Sub
  Sub VerificarCombo()
    If Me.CtlBuscaItem1.Item.Item_Combo Then
      Dim posicionpadre As Integer = Me.BindingSource1.Position
      For Each _itemdetalle As ItemDetalle In Me.CtlBuscaItem1.Item.DetallesCombo(mMovimientoInventarioDet.MovimientoInventario.Sucursal)
        Dim mmovdet As New MovimientoInventarioDet(mMovimientoInventarioDet.MovimientoInventario, True)
        mmovdet.Item = _itemdetalle.ItemDetalle
        mmovdet.PardetUnidadMedida = _itemdetalle.PardetUnidadMedida
        mmovdet.Moinde_Cantidad = _itemdetalle.IteDet_Cantidad
        mmovdet.Moinde_Valor = _itemdetalle.IteDet_Valor
        mmovdet.Moinde_esDetalleCombo = True

        posicionpadre += 1
        Me.BindingSource1.Insert(posicionpadre, mmovdet)
      Next
      RaiseEvent Actualizodatos(Me, Nothing)
    End If
  End Sub


  Private Sub btnquitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnquitar.Click
    If Me.BindingSource1.Current IsNot Nothing Then
      Dim mitem As Item = CType(Me.BindingSource1.Current, MovimientoInventarioDet).Item
      If mitem IsNot Nothing Then
        Dim mCombo As Boolean = CType(Me.BindingSource1.Current, MovimientoInventarioDet).Item.Item_Combo
        Dim mPosicion As Integer = Me.BindingSource1.Position
        Me.BindingSource1.RemoveCurrent()
        While mCombo
          If Me.BindingSource1.Count = 0 OrElse mPosicion + 1 > Me.BindingSource1.Count Then
            mCombo = False
          Else
            If CType(Me.BindingSource1.Item(mPosicion), MovimientoInventarioDet).Moinde_esDetalleCombo Then
              Me.BindingSource1.RemoveAt(mPosicion)
            Else
              mCombo = False
            End If
          End If
        End While
      End If

      If Me.BindingSource1.Count = 0 Then
        Me.BindingSource1.AddNew()
      End If
    End If
    RaiseEvent Actualizodatos(Me, Nothing)
  End Sub

  Private Sub CtlMantenimientoMovimientoInventarioDet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    mEstaCambiando = False
  End Sub

  Private Sub DGSeries_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGSeries.CellEndEdit
    If DGSeries.DataSource Is Nothing Then
      Exit Sub
    End If

    If DGSeries.IsCurrentRowDirty Then
      If DGSeries.CurrentCell.RowIndex = DGSeries.Rows.Count - 1 Then
        btnnuevoserie_Click(Me, Nothing)
      End If
    End If
  End Sub


End Class
