Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports Incautacion.Reglas

'Imports WWTS.Inventario.Reglas

Public Class CtlPagosDet
  Inherits DataGridView

  Public ReadOnly Property Sistema() As Sistema
    Get
      Dim obj As Control
      obj = Me.Parent
      While Not TypeOf obj Is FrmFormaBase
        obj = obj.Parent
      End While
      If TypeOf obj Is FrmFormaBase Then
        Return CType(obj, FrmFormaBase).Sistema
      End If
      Return Nothing
    End Get
  End Property

  Private mFactorTamanio As Decimal = 1
  Public Property FactorTamanio() As Decimal
    Get
      Return mFactorTamanio
    End Get
    Set(ByVal value As Decimal)
      mFactorTamanio = value
    End Set
  End Property

  Private mSucursal As Sucursal = Nothing
  Public Property Sucursal As Sucursal
    Get
      Return mSucursal
    End Get
    Set(ByVal value As Sucursal)
      mSucursal = value
      Llenar_detalles()
    End Set
  End Property

  Private mEntidad As Entidad = Nothing
  Public Property Entidad As Entidad
    Get
      Return mEntidad
    End Get
    Set(ByVal value As Entidad)
      mEntidad = value
      Llenar_detalles()
    End Set
  End Property

  Private mTipoCuenta As Enumerados.enumTipoCuenta = Enumerados.enumTipoCuenta.cxc
  Public Property TipoCuenta As Enumerados.enumTipoCuenta
    Get
      Return mTipoCuenta
    End Get
    Set(ByVal value As Enumerados.enumTipoCuenta)
      mTipoCuenta = value
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
        If mMovimientoInventario.Compra IsNot Nothing Then
          TipoCuenta = Enumerados.enumTipoCuenta.cxp
        End If
        If mMovimientoInventario.Venta IsNot Nothing Then
          TipoCuenta = Enumerados.enumTipoCuenta.cxc
        End If
        Sucursal = mMovimientoInventario.Sucursal
        Entidad = mMovimientoInventario.Entidad
        Llenar_detalles()
      End If
    End Set
  End Property

  Public ReadOnly Property PagosDet() As PagosDet
    Get
      'Dim _movdet As PagosDet = Nothing
      'If Me.CurrentRow IsNot Nothing Then
      '  _movdet = mMovimientoInventario.Pagos.Item(Me.CurrentRow.Index)
      'End If
      Return BindingSourceDetalles.Current
    End Get
  End Property

  Public Function ValorDocumentos() As Decimal
    Dim total As Decimal = 0
    For Each _pago As PagosDet In Me.BindingSourceDetalles
      If _pago.Pardet_TipoMovPagoEnum = Enumerados.enumTipoMovPagos.Documento Then
        total += _pago.Pendiente
      End If
    Next
    Return total
  End Function

  Public Function ValorCuadrado() As Decimal
    Dim total As Decimal = 0
    For Each _pago As PagosDet In Me.BindingSourceDetalles
      total += _pago.ValorconSigno
    Next
    Return total
  End Function

  'Private mSistema As Sistema
  'Public Property Sistema() As Sistema
  '  Get
  '    Return mSistema
  '  End Get
  '  Set(ByVal value As Sistema)
  '    mSistema = value
  '  End Set
  'End Property

  Private WithEvents BindingSourceDetalles As BindingSource

#Region "Detalles de pagos"
  Private Sub Llenar_detalles()
    If mEntidad Is Nothing Or mSucursal Is Nothing Then
      Exit Sub
    End If
    Me.BindingSourceDetalles.DataSource = GetType(PagosDetList)
    BindingSourceDetalles.DataSource = PagosDetList.ObtenerListaPendientes(mSucursal, mEntidad, mTipoCuenta)
    MyBase.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "TipoMovPagoString"
    DataGridViewTextBoxColumn1.HeaderText = "Tipo de Movimiento"
    DataGridViewTextBoxColumn1.Width = 150 * mFactorTamanio
    DataGridViewTextBoxColumn1.ReadOnly = True
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewTextBoxColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Referencia"
    DataGridViewTextBoxColumn1.HeaderText = "Referencia"
    DataGridViewTextBoxColumn1.Width = 250 * mFactorTamanio
    DataGridViewTextBoxColumn1.ReadOnly = True
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewTextBoxColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Pagdet_Valor"
    DataGridViewTextBoxColumn1.HeaderText = "Valor"
    DataGridViewTextBoxColumn1.Width = 80 * mFactorTamanio
    DataGridViewTextBoxColumn1.ReadOnly = False
    Dim estilonum2 As New DataGridViewCellStyle()
    estilonum2.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Pendiente"
    DataGridViewTextBoxColumn1.HeaderText = "Pendiente"
    DataGridViewTextBoxColumn1.Width = 80 * mFactorTamanio
    DataGridViewTextBoxColumn1.ReadOnly = False
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "CuentaContableString"
    'DataGridViewTextBoxColumn1.HeaderText = "Cuenta Contable"
    'DataGridViewTextBoxColumn1.Width = 220 * mFactorTamanio
    'DataGridViewTextBoxColumn1.ReadOnly = True
    'MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewTextBoxColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "SubCuentaContableString"
    'DataGridViewTextBoxColumn1.HeaderText = "SubCuenta"
    'DataGridViewTextBoxColumn1.Width = 90 * mFactorTamanio
    'DataGridViewTextBoxColumn1.ReadOnly = True
    'MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewTextBoxColumn() {DataGridViewTextBoxColumn1})

    Dim DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewCheckBoxColumn1.DataPropertyName = "Pagdet_esContabilizado"
    DataGridViewCheckBoxColumn1.HeaderText = "Contabilizado"
    DataGridViewCheckBoxColumn1.Width = 45 * mFactorTamanio
    DataGridViewCheckBoxColumn1.ReadOnly = True
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewCheckBoxColumn() {DataGridViewCheckBoxColumn1})

    'If mMovimientoInventario.Pagos.Count = 0 Then
    '  BindingSourceDetalles.AddNew()
    'End If
    actualizar_totales()
  End Sub

  Private Sub MyBase_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MyBase.CellEndEdit
    actualizar_totales()
  End Sub

  Private Sub Mybase_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick
    AbrirDetalle(True)
  End Sub

  Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    Select Case e.KeyCode
      Case Keys.Enter
        e.Handled = True
        If BindingSourceDetalles.Current IsNot Nothing Then
          Dim _pago As PagosDet = BindingSourceDetalles.Current
          'If Not _pago.Pardet_TipoMovPago = Enumerados.enumTipoMovPagos.Documento Then
          AbrirDetalle(True)
          'End If
        End If
      Case Keys.Insert
        e.Handled = True
        AgregarPago()
      Case Keys.Delete
        e.Handled = True
        If BindingSourceDetalles.Current IsNot Nothing Then
          If PagosDet IsNot Nothing AndAlso PagosDet.Pardet_TipoMovPagoEnum = Enumerados.enumTipoMovPagos.Documento Then
            Exit Sub
          End If

          Dim _pago As PagosDet = BindingSourceDetalles.Current
          'If Not _pago.Pardet_TipoMovPago = Enumerados.enumTipoMovPagos.Documento Then
          mMovimientoInventario.PagosEliminados.Add(BindingSourceDetalles.Current)
          Me.BindingSourceDetalles.RemoveCurrent()
          actualizar_totales()
          'End If
        End If
    End Select
  End Sub

  Public Sub AgregarPago()
    Dim mpagosdet As New PagosDet(Sucursal, True)
    mpagosdet.Entidad = mEntidad
    mpagosdet.PardetTipoCuenta = New WWTSParametroDet(Sistema.OperadorDatos, CInt(Enumerados.EnumParametros.TipoCuenta), CInt(mTipoCuenta))
    mpagosdet.MovimientoInventario = mMovimientoInventario
    Me.BindingSourceDetalles.Add(mpagosdet)
    Me.BindingSourceDetalles.MoveLast()
    AbrirDetalle(False)
  End Sub

  Private Sub AbrirDetalle(ByVal _RegistroAceptado As Boolean)
    If PagosDet IsNot Nothing AndAlso PagosDet.Pardet_TipoMovPagoEnum = Enumerados.enumTipoMovPagos.Documento Then
      Exit Sub
    End If
    Dim _control As Control = Me.Parent
    While _control IsNot Nothing And Not TypeOf _control Is FrmFormaBase
      _control = _control.Parent
    End While
    If _control Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoPagosDet(CType(_control, FrmFormaBase).Sistema, Enumerados.EnumOpciones.Cuentas, Sucursal, Enumerados.EnumOpciones.MovimientoInventario)
    f.MovimientoInventario = mMovimientoInventario
    If BindingSourceDetalles.Count = 0 Then
      Dim mpagosdet As New PagosDet(Sucursal, True)
      mpagosdet.Entidad = Entidad
      mpagosdet.PardetTipoCuenta = New WWTSParametroDet(Sistema.OperadorDatos, CInt(Enumerados.EnumParametros.TipoCuenta), CInt(mTipoCuenta))
      mpagosdet.MovimientoInventario = mMovimientoInventario
      Me.BindingSourceDetalles.Add(mpagosdet)
      Me.BindingSourceDetalles.MoveLast()
      f.RegistroAceptado = False
    Else
      f.RegistroAceptado = _RegistroAceptado
    End If
    f.PagosDets = BindingSourceDetalles
    f.ShowDialog()
    'BindingSourceDetalles.EndEdit()
    MyBase.Refresh()
    actualizar_totales()
  End Sub

  Public Event Cambio_MovimientoDets As EventHandler
  Private Sub actualizar_totales()
    RaiseEvent Cambio_MovimientoDets(Me, Nothing)
  End Sub
#End Region

  Public Function GuardarPagos() As Boolean
    Dim ok As Boolean = True
    Sistema.OperadorDatos.ComenzarTransaccion()
    For Each _pago As PagosDet In Me.BindingSourceDetalles
      If Not _pago.Guardar Then
        ok = False
      End If
    Next
    If ok Then
      Sistema.OperadorDatos.TerminarTransaccion()
      For Each _pago As PagosDet In Me.BindingSourceDetalles
        _pago.AceptarCambios()
        _pago.Recargar()
      Next
    Else
      Sistema.OperadorDatos.CancelarTransaccion()
    End If
    Return ok
  End Function

  Public Sub New()
    BindingSourceDetalles = New BindingSource
    MyBase.DataSource = BindingSourceDetalles
    MyBase.AutoGenerateColumns = False
    MyBase.AllowUserToAddRows = False
    MyBase.AllowUserToDeleteRows = False
    MyBase.ReadOnly = True
  End Sub
End Class
