Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports Incautacion.Reglas

'Imports WWTS.Inventario.Reglas

Public Class CtlMovimientoInventarioDet
    'Inherits DataGridView
    Inherits Infoware.Consola.Base.DataGridViewAutoDiscover

  Private mFactorTamanio As Decimal = 1
  Public Property FactorTamanio() As Decimal
    Get
      Return mFactorTamanio
    End Get
    Set(ByVal value As Decimal)
      mFactorTamanio = value
    End Set
  End Property

  Private mVenta As Venta = Nothing
  Public Property Venta() As Venta
    Get
      Return mVenta
    End Get
    Set(ByVal value As Venta)
      mVenta = value
      If value IsNot Nothing Then
        MovimientoInventario = value.MovimientoInventario
        PardetTipoPago = value.PardetTipoPago
      End If
    End Set
  End Property

  Private mMovimientoInventario As MovimientoInventario
  Public Property MovimientoInventario() As MovimientoInventario
    Get
      Return mMovimientoInventario
    End Get
    Set(ByVal value As MovimientoInventario)
      mMovimientoInventario = value
      If value IsNot Nothing Then
        Llenar_detalles()
      End If
    End Set
  End Property

  Public ReadOnly Property MovimientoInventarioDet() As MovimientoInventarioDet
    Get
      Dim _movdet As MovimientoInventarioDet = Nothing
      If Me.CurrentRow IsNot Nothing Then
        _movdet = mMovimientoInventario.Detalles(Me.CurrentRow.Index)
      End If
      Return _movdet
    End Get
  End Property

  Private mPardetTipoPago As ParametroDet
  Public Property PardetTipoPago() As ParametroDet
    Get
      Return mPardetTipoPago
    End Get
    Set(ByVal value As ParametroDet)
      mPardetTipoPago = value
    End Set
  End Property

  'Private mSistema As Sistema
  'Public Property Sistema() As Sistema
  '  Get
  '    Return mSistema
  '  End Get
  '  Set(ByVal value As Sistema)
  '    mSistema = value
  '  End Set
  'End Property

  Private WithEvents _BindingSourceDetalles As BindingSource
  Public ReadOnly Property BindingSourceDetalles() As BindingSource
    Get
      Return _BindingSourceDetalles
    End Get
  End Property

#Region "Detalles de factura"
  Private Sub Llenar_detalles()
    _BindingSourceDetalles.DataSource = GetType(MovimientoInventarioDetList)
    _BindingSourceDetalles.DataSource = mMovimientoInventario.Detalles
        MyBase.Columns.Clear()

        Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "ItemSecuencia"
        DataGridViewTextBoxColumn1.HeaderText = "ITEM"
        DataGridViewTextBoxColumn1.Width = 40 * mFactorTamanio
        DataGridViewTextBoxColumn1.ReadOnly = False
        MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewTextBoxColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "Moinde_Cantidad"
        DataGridViewTextBoxColumn1.HeaderText = "CANTIDAD"
        DataGridViewTextBoxColumn1.Width = 70 * mFactorTamanio
        DataGridViewTextBoxColumn1.ReadOnly = False
        Dim estilonum2 As New DataGridViewCellStyle()
        estilonum2.Format = "N2"
        DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
        MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "PardetUnidadMedidaString"
        DataGridViewTextBoxColumn1.HeaderText = "UNIDAD DE MEDIDA"
        DataGridViewTextBoxColumn1.Width = 55 * mFactorTamanio
        'DataGridViewTextBoxColumn1.ReadOnly = False
        MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewTextBoxColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "ItemDescripcion"
        DataGridViewTextBoxColumn1.HeaderText = "DESCRIPCION"
        DataGridViewTextBoxColumn1.Width = 140 * mFactorTamanio
        DataGridViewTextBoxColumn1.ReadOnly = True
        MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewTextBoxColumn() {DataGridViewTextBoxColumn1})

        
        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "ItemMarca"
        DataGridViewTextBoxColumn1.HeaderText = "MARCA"
        DataGridViewTextBoxColumn1.Width = 70 * mFactorTamanio
        DataGridViewTextBoxColumn1.ReadOnly = True
        MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewTextBoxColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "ItemModelo"
        DataGridViewTextBoxColumn1.HeaderText = "MODELO"
        DataGridViewTextBoxColumn1.Width = 70 * mFactorTamanio
        DataGridViewTextBoxColumn1.ReadOnly = False
        MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewTextBoxColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "ItemSerie"
        DataGridViewTextBoxColumn1.HeaderText = "SERIE"
        DataGridViewTextBoxColumn1.Width = 100 * mFactorTamanio
        DataGridViewTextBoxColumn1.ReadOnly = False
        MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewTextBoxColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "ItemEstado"
        DataGridViewTextBoxColumn1.HeaderText = "ESTADO"
        DataGridViewTextBoxColumn1.Width = 70 * mFactorTamanio
        DataGridViewTextBoxColumn1.ReadOnly = True
        MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewTextBoxColumn() {DataGridViewTextBoxColumn1})

        'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        'DataGridViewTextBoxColumn1.DataPropertyName = "Moinde_Descripcion"
        'DataGridViewTextBoxColumn1.HeaderText = "Descripción"
        'DataGridViewTextBoxColumn1.Width = 225 * mFactorTamanio
        'DataGridViewTextBoxColumn1.ReadOnly = False
        'MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewTextBoxColumn() {DataGridViewTextBoxColumn1})

        
        

        Dim _total As Boolean = False
        Select Case mMovimientoInventario.Pardet_Tipomovinv
            Case Enumerados.enumTipoMovInv.AjustePos, Enumerados.enumTipoMovInv.AjusteNeg, Enumerados.enumTipoMovInv.Transferencia, Enumerados.enumTipoMovInv.Consumo, Enumerados.enumTipoMovInv.DesperdicioOP, Enumerados.enumTipoMovInv.OrdenProduccion
            Case Else
                DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
                DataGridViewTextBoxColumn1.DataPropertyName = "Moinde_Valor"
                DataGridViewTextBoxColumn1.HeaderText = "VALOR UNITARIO"
                DataGridViewTextBoxColumn1.Width = 65 * mFactorTamanio
                DataGridViewTextBoxColumn1.ReadOnly = False
                DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
                MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

                _total = True
        End Select

        Select Case mMovimientoInventario.Pardet_Tipomovinv
            Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.DevVenta, Enumerados.enumTipoMovInv.Venta, Enumerados.enumTipoMovInv.DevCompra
                DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
                DataGridViewTextBoxColumn1.DataPropertyName = "Moinde_Descto"
                DataGridViewTextBoxColumn1.HeaderText = "Dscto%"
                DataGridViewTextBoxColumn1.Width = 65 * mFactorTamanio
                DataGridViewTextBoxColumn1.ReadOnly = False
                DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
                MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
        End Select

        If _total Then
            DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
            DataGridViewTextBoxColumn1.DataPropertyName = "Total"
            DataGridViewTextBoxColumn1.HeaderText = "VALOR TOTAL"
            DataGridViewTextBoxColumn1.Width = 65 * mFactorTamanio
            DataGridViewTextBoxColumn1.ReadOnly = True
            DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
            MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
        End If

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "ItemCaracteristicas"
        DataGridViewTextBoxColumn1.HeaderText = "CARACTERISTICAS"
        DataGridViewTextBoxColumn1.Width = 115 * mFactorTamanio
        DataGridViewTextBoxColumn1.ReadOnly = False
        MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewTextBoxColumn() {DataGridViewTextBoxColumn1})

        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "ItemObservacion"
        DataGridViewTextBoxColumn1.HeaderText = "OBSERVACION"
        DataGridViewTextBoxColumn1.Width = 100 * mFactorTamanio
        DataGridViewTextBoxColumn1.ReadOnly = True
        MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewTextBoxColumn() {DataGridViewTextBoxColumn1})


        If mMovimientoInventario.Detalles.Count = 0 Then
            _BindingSourceDetalles.AddNew()
        Else

        End If

        actualizar_totales()
    End Sub

  Private Sub MyBase_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MyBase.CellEndEdit
    actualizar_totales()
  End Sub

  'Private Sub Mybase_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick
  '  If Me.ReadOnly Then
  '    Exit Sub
  '  End If
  '  AbrirDetalle()
  'End Sub

  Private mEstaenMantenimiento As Boolean = False

  Private Sub CtlMovimientoInventarioDet_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
    If mEstaenMantenimiento Then
      Exit Sub
    End If
    If mMovimientoInventario.Detalles.Count = 0 Then
            _BindingSourceDetalles.AddNew()
      'AbrirDetalle()
    ElseIf mMovimientoInventario.Detalles.Count = 1 AndAlso mMovimientoInventario.Detalles(0).Item_Codigo = 0 Then
      'AbrirDetalle()
    End If
  End Sub

  Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    If Me.ReadOnly Then
      Exit Sub
    End If
    Select Case e.KeyCode
      Case Keys.Enter
        e.Handled = True
        'AbrirDetalle()
      Case Keys.Insert
        e.Handled = True
        _BindingSourceDetalles.AddNew()
        'AbrirDetalle()
        'Case Keys.Delete
        '  e.Handled = True
        '  If _BindingSourceDetalles.Current IsNot Nothing Then
        '    _BindingSourceDetalles.RemoveCurrent()
        '  End If
        '  actualizar_totales()
    End Select
  End Sub

  'Private Sub AbrirDetalle()
  '  mEstaenMantenimiento = True
  '  Dim _tipopagoxprecio As TipoPagoxTipoPrecio = Nothing
  '  If mPardetTipoPago IsNot Nothing Then
  '    _tipopagoxprecio = New TipoPagoxTipoPrecio(mMovimientoInventario.Sucursal, mPardetTipoPago)
  '  End If

  '  Dim _control As Control = Me.Parent
  '  While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
  '    _control = _control.Parent
  '  End While
  '  If _control Is Nothing Then
  '    Exit Sub
  '  End If
  '  Dim f As New FrmMantenimientoMovimientoInventarioDet(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.MovimientoInventario, Enumerados.EnumOpciones.MovimientoInventario)
  '  If _tipopagoxprecio IsNot Nothing Then
  '    f.PardetTipoPrecio = _tipopagoxprecio.PardetTipoPrecio
  '  End If
  '  f.MovimientoInventario = mMovimientoInventario
  '  f.enumTipoMovInv = mMovimientoInventario.Pardet_Tipomovinv
  '  If _BindingSourceDetalles.Count = 0 Then
  '    _BindingSourceDetalles.AddNew()
  '  End If
  '  f.MovimientoInventarioDets = _BindingSourceDetalles
  '  f.ShowDialog()
  '  'BindingSourceDetalles.EndEdit()
  '  MyBase.Refresh()
  '  actualizar_totales()
  '  mEstaenMantenimiento = False
  'End Sub

  Public Event Cambio_MovimientoDets As EventHandler
  Private Sub actualizar_totales()
    RaiseEvent Cambio_MovimientoDets(Me, Nothing)
  End Sub
#End Region

  Public Sub New()
    If Not DesignMode Then
      MyBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      _BindingSourceDetalles = New BindingSource
      MyBase.DataSource = _BindingSourceDetalles
      MyBase.AutoGenerateColumns = False
      MyBase.AllowUserToAddRows = False
      MyBase.AllowUserToDeleteRows = False
      MyBase.AutoGenerateColumns = False
      MyBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    End If
  End Sub
End Class
