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

    Private mIncautacion As Reglas.Incautacion = Nothing
    Public Property Incautacion As Reglas.Incautacion
        Get
            Return mIncautacion
        End Get
        Set(value As Reglas.Incautacion)
            mIncautacion = value
            'llenar_datos()
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

    'Nuevos items solo para nuevas incautaciones
    Private mEsNuevo As Boolean = False
    Public Property EsNuevo As Boolean
        Get
            Return mEsNuevo
        End Get
        Set(ByVal value As Boolean)
            mEsNuevo = value
        End Set
    End Property

    Private mItem As Item
    Public Property Item As Item
        Get
            Return mItem
        End Get
        Set(value As Item)
            mItem = value
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
        'btnLimpiar.Visible = False

        If mMovimientoInventarioDet Is Nothing Then
            Me.Enabled = False
            Exit Sub
        End If

        Me.Enabled = mMovimientoInventarioDet.EsNuevo
        mEstaCambiando = True

        enumTipoMovInv = mMovimientoInventarioDet.MovimientoInventario.Pardet_TipomovinvEnum
        If mMovimientoInventarioDet.MovimientoInventario.Venta IsNot Nothing Then
            PardetTipoPrecio = mMovimientoInventarioDet.MovimientoInventario.Venta.PardetTipoPrecio
        End If

        If Not EsNuevo Then
            Me.CtlBuscaItem1.PardetTipoInventario = mPardetTipoInventario
            Me.CtlBuscaItem1.Sucursal = mMovimientoInventarioDet.MovimientoInventario.Sucursal

            If mIncautacion IsNot Nothing Then
                Me.CtlBuscaItem1.Incautacion = mIncautacion
                Me.CtlBuscaItem1.llenar_datos()
                'Me.CtlBuscaItem1.Item = mMovimientoInventarioDet.Item

                If Me.CtlBuscaItem1.Item IsNot Nothing Then
                    Me.CtlBuscaItem1.Enabled = Not Me.CtlBuscaItem1.Item.Item_Combo
                End If
            End If

        Else
            If Not mMovimientoInventarioDet.EsNuevo Then
                Me.cboTipoItem.ParametroDet = mMovimientoInventarioDet.Item.PardetTipo
                Me.ComboBoxMarca1.ParametroDet = mMovimientoInventarioDet.Item.PardetMarca
                Me.txtModelo.Text = mMovimientoInventarioDet.Item.Item_Modelo
                Me.chkEsRegistroSerie.Checked = mMovimientoInventarioDet.Item.Item_esRegistroSerie
                Me.txtSerie.Text = mMovimientoInventarioDet.Item.Item_Serie
                Me.cboEstado.ParametroDet = mMovimientoInventarioDet.Item.PardetEstadoItem
                Me.txtdescripcion.Text = mMovimientoInventarioDet.Item.Item_Descripcion
                Me.txtUbicacion.Text = mMovimientoInventarioDet.Item.Item_Ubicacion
            End If
        End If

        Me.ComboBoxUnidadMedida.OperadorDatos = mMovimientoInventarioDet.OperadorDatos

        Me.txtcantidad.Value = mMovimientoInventarioDet.Moinde_Cantidad

        If mMovimientoInventarioDet.Item IsNot Nothing Then

            Me.ComboBoxUnidadMedida.Parametro = Enumerados.EnumParametros.UnidadMedida
            'Me.ComboBoxUnidadMedida.Llenar_Datos(ParametroDetList.enumTipoObjeto.UnidadMedida, Me.CtlBuscaItem1.Item.PardetUnidadMedida)
            'Me.ComboBoxUnidadMedida.ParametroDet = mMovimientoInventarioDet.PardetUnidadMedida

            If mMovimientoInventarioDet.Item IsNot Nothing Then
                'Me.txtobservacion.Text = mMovimientoInventarioDet.Moinde_Descripcion
                Me.ComboBoxUnidadMedida.ParametroDet = mMovimientoInventarioDet.PardetUnidadMedida
                Me.txtvalor.Value = mMovimientoInventarioDet.Moinde_Valor
                'Me.txtdescto.Value = mMovimientoInventarioDet.Moinde_Descto
                'Me.chkaplicaiva.Checked = mMovimientoInventarioDet.Moinde_Aplicaiva
                ' Me.txt_descripcionlugar.Text = mMovimientoInventarioDet.Moinde_DescripcionLugar
                ' Me.txt_marca.Text = mMovimientoInventarioDet.Moinde_Marca
                ' Me.txt_modelo.Text = mMovimientoInventarioDet.Moinde_Modelo
            End If
            Me.CtlBuscaItem1.Select()

            'Me.BSSeries.DataSource = MovimientoInventarioDet.DetallesSeries
            'Me.DGSeries.AutoDiscover()
            'Me.pnlserie.Visible = Me.CtlBuscaItem1.Item.Item_esRegistroSerie
            'If Me.pnlserie.Visible Then
            'Me.txtcantidad.Value = Me.BSSeries.Count
            'End If

            Me.CtlBuscaItem1.Focus()
        End If
        mEstaCambiando = False
        CambioItem()
    End Sub

  Public Event Actualizodatos As EventHandler

    Private Sub Mapear_datos()
        'MessageBox.Show("Mapear")
        If EsNuevo Then
            'MessageBox.Show("nuevo")
            Item = New Item(MovimientoInventarioDet.OperadorDatos, True)
            Item.PardetTipo = Me.cboTipoItem.ParametroDet
            Item.Item_Descripcion = Me.txtdescripcion.Text
            Item.PardetMarca = Me.ComboBoxMarca1.ParametroDet
            Item.Item_Modelo = Me.txtModelo.Text
            Item.Item_Serie = Me.txtSerie.Text
            Item.Item_Ubicacion = Me.txtUbicacion.Text
            Item.PardetEstadoItem = Me.cboEstado.ParametroDet
            Item.PardetUnidadMedida = Me.ComboBoxUnidadMedida.ParametroDet
            Item.Item_Precio = Me.txtvalor.Value
            'falta el valor
            mMovimientoInventarioDet.Moinde_Costo = Item.Item_Precio
            mMovimientoInventarioDet.Item.Item_Precio = Item.Item_Precio
            mMovimientoInventarioDet.Moinde_Valor = Me.txtvalor.Value
            'mMovimientoInventarioDet.PardetUnidadMedida = Me.ComboBoxUnidadMedida.ParametroDet
        Else
            'MessageBox.Show("no es nuevo")
            'MessageBox.Show("No es incautacion" + Me.CtlBuscaItem1.Item.Item_Codigo.ToString)
            Item = Me.CtlBuscaItem1.Item
            mMovimientoInventarioDet.Item.Item_Codigo = Item.Item_Codigo
            mMovimientoInventarioDet.Item_Codigo = Item.Item_Codigo
            mMovimientoInventarioDet.Moinde_Costo = Item.Precio

        End If

        Try
            If Item.PardetTipo Is Nothing Then
                Item.Recargar()
                If Item.PardetTipo IsNot Nothing Then
                    mMovimientoInventarioDet.Item.PardetTipo = Item.PardetTipo
                End If
            Else
                mMovimientoInventarioDet.Item.PardetTipo = Item.PardetTipo
            End If

            'mMovimientoInventarioDet.Item.PardetTipo = Item.PardetTipo
            mMovimientoInventarioDet.Item.Item_Descripcion = Item.Item_Descripcion
            mMovimientoInventarioDet.Item.PardetMarca = Item.PardetMarca
            mMovimientoInventarioDet.Item.Item_Modelo = Item.Item_Modelo
            mMovimientoInventarioDet.Item.Item_Serie = Item.Item_Serie
            mMovimientoInventarioDet.Item.Item_Ubicacion = Item.Item_Ubicacion
            mMovimientoInventarioDet.Item.PardetEstadoItem = Item.PardetEstadoItem
            mMovimientoInventarioDet.Item.PardetUnidadMedida = Item.PardetUnidadMedida
            mMovimientoInventarioDet.PardetUnidadMedida = Item.PardetUnidadMedida
            'MessageBox.Show("PardetUnidadMedida" + mMovimientoInventarioDet.Item.PardetUnidadMedida.Descripcion)
            mMovimientoInventarioDet.Parame_UnidMedStd = Item.PardetUnidadMedida.Parame_Codigo
            mMovimientoInventarioDet.Pardet_UnidMedStd = Item.PardetUnidadMedida.Pardet_Secuencia
            mMovimientoInventarioDet.Moinde_Cantidad = Me.txtcantidad.Value
            'mMovimientoInventarioDet.Moinde_Descripcion = Me.txtobservacion.Text

            'mMovimientoInventarioDet.Pardet_UnidMedStd = Me.ComboBoxUnidadMedida.ParametroDet.Pardet_Secuencia
            'mMovimientoInventarioDet.Moinde_CantidadStd = 1

            'mMovimientoInventarioDet.Moinde_Valor = Me.txtvalor.Value
            'mMovimientoInventarioDet.Moinde_Descto = Me.txtdescto.Value
            'mMovimientoInventarioDet.Moinde_Aplicaiva = Me.chkaplicaiva.Checked
            'mMovimientoInventarioDet.Moinde_DescripcionLugar = Me.txt_descripcionlugar.Text
            'mMovimientoInventarioDet.Moinde_Modelo = Me.txt_modelo.Text
            'mMovimientoInventarioDet.Moinde_Marca = Me.txt_marca.Text
            If Me Is Nothing Then
                MessageBox.Show("yo soy naa")
            End If
            'MessageBox.Show(mMovimientoInventarioDet.Item.PardetUnidadMedida.Descripcion)
            'MessageBox.Show(mMovimientoInventarioDet.Pard
            RaiseEvent Actualizodatos(Me, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.InnerException.ToString + "mesaje" + ex.Message)
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

            Select Case value
                Case Enumerados.enumTipoMovInv.AjustePos, Enumerados.enumTipoMovInv.AjusteNeg, Enumerados.enumTipoMovInv.Consumo, Enumerados.enumTipoMovInv.DesperdicioOP

                Case Enumerados.enumTipoMovInv.InvInicial
                    Me.pnlNuevo.Visible = True
                Case Enumerados.enumTipoMovInv.Incautacion
                    EsNuevo = True
                    CargarCombos()
                    ChequearEsRegistroSerie()
                    txtSerie.Text = ""
                    Me.pnlaccion.Visible = True
                    Me.pnlaccion.Enabled = True
                    Me.pnlNuevo.Visible = True
                    Me.pnlNuevo2.Visible = True
                    Me.pnlcantidad.Enabled = True
                    Me.btnLimpiar.Visible = True
                Case Enumerados.enumTipoMovInv.IncautSalida, Enumerados.enumTipoMovInv.Transferencia
                    EsNuevo = False
                    Me.pnlExistente.Visible = True
                    Me.pnlNuevo.Visible = False
                    Me.pnlNuevo2.Visible = False
                    Me.pnlcantidad.Visible = True
                    Me.btnLimpiar.Visible = False

                Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.DevVenta, Enumerados.enumTipoMovInv.Venta, Enumerados.enumTipoMovInv.DevCompra
                    Me.pnlNuevo.Visible = True
                    'Me.pnldescto.Visible = True
            End Select
        End Set
    End Property

#Region "Item"
    Private Sub CtlBuscaItem1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaItem1.CambioItem
        'MessageBox.Show("esto cambiando item")
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
        'Mapear_datos()
    End Sub

    Private Sub ComboBoxUnidadMedida_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxUnidadMedida.CambioItem, txtcantidad.Validated
        If mEstaCambiando Then
            Exit Sub
        End If
        CambioUnidadMedida()
    End Sub


    Private Sub CambioItem()
        If Not EsNuevo Then
            Me.pnlcantidad.Enabled = Me.CtlBuscaItem1.Item IsNot Nothing
            'Me.pnlNuevo.Enabled = Me.CtlBuscaItem1.Item IsNot Nothing
            'Me.pnldescto.Enabled = Me.CtlBuscaItem1.Item IsNot Nothing
            'Me.pnlserie.Enabled = Me.CtlBuscaItem1.Item IsNot Nothing
            Me.pnlaccion.Enabled = Me.CtlBuscaItem1.Item IsNot Nothing
        End If

        If Me.CtlBuscaItem1.Item Is Nothing Then
            Exit Sub
        End If
        mEstaCambiando = True

        'Me.PictureBox1.Image = Me.CtlBuscaItem1.Item.Item_Imagen
        'Me.chkaplicaiva.Checked = Me.CtlBuscaItem1.Item.Item_Aplicaiva

        Me.txtvalor.Value = CtlBuscaItem1.Item.Precio
        Me.txtvalor.Enabled = False

        Me.txtcantidad.Enabled = Not Me.CtlBuscaItem1.Item.Item_esRegistroSerie And Not Me.CtlBuscaItem1.Item.Item_Combo
        'Me.txtvalor.Enabled = Not Me.CtlBuscaItem1.Item.Item_Combo And VerConfidencial
        'Me.txtdescto.Enabled = Not Me.CtlBuscaItem1.Item.Item_Combo And VerConfidencial
        Me.ComboBoxUnidadMedida.Enabled = Not Me.CtlBuscaItem1.Item.Item_esRegistroSerie And Not Me.CtlBuscaItem1.Item.Item_Combo
        If Me.ComboBoxUnidadMedida.Items.Count <= 1 Then
            Me.ComboBoxUnidadMedida.Enabled = False
        End If
        'Me.pnlserie.Visible = Me.CtlBuscaItem1.Item.Item_esRegistroSerie
        'If Me.CtlBuscaItem1.Item.Item_esRegistroSerie Then
        '  Me.BSSeries.DataSource = Me.MovimientoInventarioDet.DetallesSeries
        '  Me.DGSeries.AutoDiscover()
        'End If
        Llenar_detallesExistencia()
        'Llenar_detallesCombo()
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
        'Me.grpcombo.Visible = Me.CtlBuscaItem1.Item.Item_Combo
        If Not Me.CtlBuscaItem1.Item.Item_Combo Then
            Exit Sub
        End If
        'Me.DGCombo.Columns.Clear()

        Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "ItemString"
        DataGridViewTextBoxColumn1.HeaderText = "Descripción"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Width = 125
        'Me.DGCombo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "Cantidad"
        DataGridViewTextBoxColumn1.HeaderText = "Cantidad"
        DataGridViewTextBoxColumn1.Width = 60
        DataGridViewTextBoxColumn1.ReadOnly = True
        Dim estilonum2 As New DataGridViewCellStyle()
        estilonum2.Format = "N2"
        DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
        'Me.DGCombo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "UnidadMedidaString"
        DataGridViewTextBoxColumn1.HeaderText = "Unid"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Width = 75
        'Me.DGCombo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "Valor"
        DataGridViewTextBoxColumn1.HeaderText = "Valor"
        DataGridViewTextBoxColumn1.Width = 60
        DataGridViewTextBoxColumn1.ReadOnly = True
        estilonum2.Format = "N2"
        DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
        'Me.DGCombo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "Total"
        DataGridViewTextBoxColumn1.HeaderText = "Total"
        DataGridViewTextBoxColumn1.Width = 60
        DataGridViewTextBoxColumn1.ReadOnly = True
        estilonum2.Format = "N2"
        DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
        'Me.DGCombo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        Me.BSCombo.DataSource = GetType(ItemDetalle)
        'mMovimientoInventarioDets = 
        BSCombo.DataSource = Me.CtlBuscaItem1.Item.DetallesCombo(mMovimientoInventarioDet.MovimientoInventario.Sucursal)
    End Sub
#End Region

    Private Sub txtcantidad_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcantidad.TextChanged, txtvalor.TextChanged
        If Not mEstaCambiando Then
            'Mapear_datos()
        End If
    End Sub


    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        If Me.CtlBuscaItem1.Item Is Nothing And Not EsNuevo Then
            Exit Sub
        End If

        Mapear_datos()

        'If Not EsNuevo Then
        'VerificarCombo()
        'End If

        'ValidarRegistros()

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

    'Private Sub DGSeries_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    If DGSeries.DataSource Is Nothing Then
    '        Exit Sub
    '    End If

    '    If DGSeries.IsCurrentRowDirty Then
    '        If DGSeries.CurrentCell.RowIndex = DGSeries.Rows.Count - 1 Then
    '            btnnuevoserie_Click(Me, Nothing)
    '        End If
    '    End If
    'End Sub

    Private mCombosCargados As Boolean = False

    Private Sub CargarCombos()
        If mMovimientoInventarioDet Is Nothing AndAlso Not mCombosCargados Then
            Exit Sub
        End If

        If Not mCombosCargados Then
            Me.cboTipoItem.Parametro = Enumerados.EnumParametros.TipoItem
            Me.cboTipoItem.OperadorDatos = mMovimientoInventarioDet.OperadorDatos
            Me.cboTipoItem.Llenar_Datos()

            Me.ComboBoxMarca1.Parametro = Enumerados.EnumParametros.Marca
            Me.ComboBoxMarca1.OperadorDatos = mMovimientoInventarioDet.OperadorDatos
            Me.ComboBoxMarca1.Llenar_Datos()

            Me.cboEstado.Parametro = Enumerados.EnumParametros.EstadoItem
            Me.cboEstado.OperadorDatos = mMovimientoInventarioDet.OperadorDatos
            Me.cboEstado.Llenar_Datos()

            Me.ComboBoxUnidadMedida.Parametro = Enumerados.EnumParametros.UnidadMedida
            Me.ComboBoxUnidadMedida.OperadorDatos = mMovimientoInventarioDet.OperadorDatos
            Me.ComboBoxUnidadMedida.Llenar_Datos()
        End If

        mCombosCargados = True
    End Sub

    Private Sub ChequearEsRegistroSerie()
        If chkEsRegistroSerie.Checked Then
            txtSerie.Enabled = True
            txtcantidad.Enabled = False
            txtcantidad.Value = 1
        Else
            txtSerie.Enabled = False
            txtcantidad.Enabled = True
        End If
    End Sub

    Private Sub chkEsRegistroSerie_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkEsRegistroSerie.CheckedChanged
        ChequearEsRegistroSerie()
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        cboTipoItem.SelectedItem = -1
        ComboBoxMarca1.SelectedItem = -1
        txtModelo.Text = ""
        chkEsRegistroSerie.Checked = False
        txtSerie.Text = ""
        txtSerie.Enabled = False
        txtcantidad.Enabled = True
        cboEstado.SelectedItem = -1
        txtvalor.Value = 0
        txtdescripcion.Text = ""
        txtUbicacion.Text = ""
        mCombosCargados = False
        CargarCombos()
    End Sub
End Class
