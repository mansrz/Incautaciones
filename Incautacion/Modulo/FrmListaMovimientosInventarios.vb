Imports Infoware.Datos
Imports Infoware.Reglas.General
'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmListaMovimientosInventarios
  Private mPuedeMostrar As Boolean = False
  Private mTipoCompraVentaVisible As Boolean = False

  Public Property Sucursal() As Sucursal
    Get
      Return mSucursal
    End Get
    Set(ByVal value As Sucursal)
      mSucursal = value
      Llenar_datos()
    End Set
  End Property

  'Public Property RegistroContable() As RegistroContable
  '  Get
  '    Return mRegistroContable
  '  End Get
  '  Set(ByVal value As RegistroContable)
  '    mRegistroContable = value
  '    Llenar_datos()
  '  End Set
  'End Property

  Private Sub FrmListaMovimientosInventarios_DespuesSeleccionarCampos(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DespuesSeleccionarCampos
    If mSoloCuentas Then
      Dim DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
      DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
      DataGridViewCheckBoxColumn1.DataPropertyName = "Movinv_autorizado"
      DataGridViewCheckBoxColumn1.HeaderText = "Autorizado"
      DataGridViewCheckBoxColumn1.Width = 60
      Me.DataGridView1.Columns.Insert(0, DataGridViewCheckBoxColumn1)
    End If
  End Sub

  Private mMovimientoInventario As MovimientoInventario = Nothing
  Public Property MovimientoInventario() As MovimientoInventario
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As MovimientoInventario)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _MovimientoInventario As MovimientoInventario In Me.ListBindingSource.DataSource
          If _MovimientoInventario.Parame_Tipomovinv = value.Parame_Tipomovinv And _MovimientoInventario.Pardet_Tipomovinv = value.Pardet_Tipomovinv And _MovimientoInventario.Movinv_Secuencia = value.Movinv_Secuencia Then
            ListBindingSource.Position = t
          End If
          t += 1
        Next
      End If
    End Set
  End Property

  Public Property FiltroRangoFechas() As Boolean
    Get
      Return Me.TskRangoFecha.IsExpanded
    End Get
    Set(ByVal value As Boolean)
      Me.TskRangoFecha.IsExpanded = value
    End Set
  End Property

  Public Property SoloPendientes() As Boolean
    Get
      Return Me.chksolopendientes.Checked
    End Get
    Set(ByVal value As Boolean)
      Me.chksolopendientes.Checked = value
    End Set
  End Property

  Private mSoloCuentas As Boolean = False
  Public Property SoloCuentas As Boolean
    Get
      Return mSoloCuentas
    End Get
    Set(ByVal value As Boolean)
      mSoloCuentas = value
      Llenar_datos()
    End Set
  End Property

  Public WriteOnly Property TipoMovInv() As Enumerados.enumTipoMovInv
    Set(ByVal value As Enumerados.enumTipoMovInv)
      Me.ComboBoxTipoMovimiento.SelectedValue = CInt(value)
      Me.TskTipomovimiento.IsExpanded = True
    End Set
  End Property

#Region "Eventos"
  Private Sub FrmListaMovimientosInventarios_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaMovimientosInventarios_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaMovimientosInventarios_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Dim _bodegas As BodegaList = BodegaList.ObtenerLista(mSucursal)
    If _bodegas.Count = 0 Then
      MsgBox("No existen bodegas en esta sucursal", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoMovimientoInventario(Sistema, Restriccion, mSucursal) ', mRegistroContable
    f.MovimientoInventarios = ListBindingSource
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
  End Sub

  Private Sub FrmListaMovimientosInventarios_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaMovimientosInventarios_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaMovimientosInventarios_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mMovimientoInventarios Is Nothing OrElse ListBindingSource.Current Is Nothing OrElse MsgBox("¿Está seguro que desea eliminar este movimiento de inventario?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    Dim mMovimientoInventario As MovimientoInventario
    mMovimientoInventario = ListBindingSource.Current
    If mMovimientoInventario.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar MovimientoInventario" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub FrmListaMovimientosInventarios_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mMovimientoInventarios As MovimientoInventarioList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    If Not mPuedeMostrar Then
      Exit Sub
    End If
    'Me.DataGridView1.Columns.Clear()

    'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "TipoMovimientoInventarioString"
    'DataGridViewTextBoxColumn1.HeaderText = "Tipo de movimiento"
    'DataGridViewTextBoxColumn1.Width = 80
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Movinv_Secuencia"
    'DataGridViewTextBoxColumn1.HeaderText = "Número"
    'DataGridViewTextBoxColumn1.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'Dim _tipomov As Enumerados.enumTipoMovInv = CType(Me.ComboBoxTipoMovimiento.ParametroDet.Pardet_Secuencia, Enumerados.enumTipoMovInv)

    'If Me.TskTipomovimiento.IsExpanded Then
    '  Select Case _tipomov
    '    Case Enumerados.enumTipoMovInv.Compra
    '      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    '      DataGridViewTextBoxColumn1.DataPropertyName = "CompraVentaString"
    '      DataGridViewTextBoxColumn1.HeaderText = "Compra"
    '      DataGridViewTextBoxColumn1.Width = 200
    '      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    '      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    '      DataGridViewTextBoxColumn1.DataPropertyName = "ClienteProveedorString"
    '      DataGridViewTextBoxColumn1.HeaderText = "Proveedor"
    '      DataGridViewTextBoxColumn1.Width = 225
    '      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    '      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    '      DataGridViewTextBoxColumn1.DataPropertyName = "SustentoTributario"
    '      DataGridViewTextBoxColumn1.HeaderText = "Sustento Tributario"
    '      DataGridViewTextBoxColumn1.Width = 50
    '      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    '    Case Enumerados.enumTipoMovInv.Venta
    '      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    '      DataGridViewTextBoxColumn1.DataPropertyName = "CompraVentaString"
    '      DataGridViewTextBoxColumn1.HeaderText = "Venta"
    '      DataGridViewTextBoxColumn1.Width = 100
    '      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    '      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    '      DataGridViewTextBoxColumn1.DataPropertyName = "ClienteProveedorString"
    '      DataGridViewTextBoxColumn1.HeaderText = "Cliente"
    '      DataGridViewTextBoxColumn1.Width = 215
    '      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
    '  End Select
    'End If

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "BodegaString"
    'DataGridViewTextBoxColumn1.HeaderText = "Bodega"
    'DataGridViewTextBoxColumn1.Width = 100
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'If Me.TskTipomovimiento.IsExpanded AndAlso _tipomov = Enumerados.enumTipoMovInv.Transferencia Then
    '  DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    '  DataGridViewTextBoxColumn1.DataPropertyName = "BodegaDsnoString"
    '  DataGridViewTextBoxColumn1.HeaderText = "Destino"
    '  DataGridViewTextBoxColumn1.Width = 100
    '  Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
    'End If

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Movinv_Fecha"
    'DataGridViewTextBoxColumn1.HeaderText = "Fecha emisión"
    'DataGridViewTextBoxColumn1.Width = 90
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'Dim estilonum2 As New DataGridViewCellStyle()
    'estilonum2.Format = "N2"

    'If Me.TskTipomovimiento.IsExpanded Then
    '  Select Case _tipomov
    '    Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.Venta
    '      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    '      DataGridViewTextBoxColumn1.DataPropertyName = "FechaVencimiento"
    '      DataGridViewTextBoxColumn1.HeaderText = "Fecha vencimiento"
    '      DataGridViewTextBoxColumn1.Width = 90
    '      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    '      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    '      DataGridViewTextBoxColumn1.DataPropertyName = "TotalGeneral"
    '      DataGridViewTextBoxColumn1.HeaderText = "Valor total"
    '      DataGridViewTextBoxColumn1.Width = 65
    '      DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    '      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    '      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    '      DataGridViewTextBoxColumn1.DataPropertyName = "ValorPendiente"
    '      DataGridViewTextBoxColumn1.HeaderText = "Valor pendiente"
    '      DataGridViewTextBoxColumn1.Width = 65
    '      DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    '      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
    '  End Select
    'End If
    Me.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    Me.DataGridView1.MultiSelect = True

    Me.ListBindingSource.DataSource = GetType(MovimientoInventario)

    mMovimientoInventarios = MovimientoInventarioList.ObtenerLista(mSucursal, Me.TskRangoFecha.IsExpanded, Me.dtfecdesde.Value, Me.dtfechasta.Value, IIf(Me.TskTipomovimiento.IsExpanded, Me.ComboBoxTipoMovimiento.ParametroDet, Nothing), IIf(mTipoCompraVentaVisible, Me.ComboBoxTipoCompraVenta.ParametroDet, Nothing), Me.chksolopendientes.Checked, _filtro)
    Dim mitemssort As New Infoware.Reglas.SortedView(mMovimientoInventarios)
    ListBindingSource.DataSource = mitemssort
    Me.DataGridView1.AutoDiscover()
  End Sub

  Private Sub mMovimientoInventarios_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mMovimientoInventarios.AddingNew
    Dim _MovimientoInventario As MovimientoInventario = New MovimientoInventario(mSucursal, IIf(Me.TskTipomovimiento.IsExpanded, CType(Me.ComboBoxTipoMovimiento.ParametroDet.Pardet_Secuencia, Enumerados.enumTipoMovInv), Enumerados.enumTipoMovInv.InvInicial), True)
    e.NewObject = _MovimientoInventario
  End Sub

  Sub Mayorizar(ByVal _estado As Boolean)
    If Me.DataGridView1.SelectedRows.Count > 0 Then
      'Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion)

      For Each _fila As DataGridViewRow In Me.DataGridView1.SelectedRows
        Dim _movcon As MovimientoInventario
        _movcon = CType(Me.DataGridView1.DataSource(_fila.Index), MovimientoInventario)
        _movcon.Movinv_autorizado = _estado
        If _movcon.Guardar() Then
          Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Confidencial, String.Format("Autorizó {0} {1}", _movcon.CompraVentaString, _movcon.ClienteProveedorString))
        End If
      Next
    End If
    'Me.DataGridView1.Refresh()
    Me.DataGridView1.Invalidate()
  End Sub

#End Region

  Private Sub ComboBoxTipoMovimiento_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxTipoMovimiento.CambioItem
    Dim _tipomovinv As Enumerados.enumTipoMovInv = CType(Me.ComboBoxTipoMovimiento.ParametroDet.Pardet_Secuencia, Enumerados.enumTipoMovInv)

    Me.chksolopendientes.Visible = False
    Select Case _tipomovinv
      Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.Venta
        Me.chksolopendientes.Visible = True
    End Select

    Me.tsk_venta.Visible = _tipomovinv = Enumerados.enumTipoMovInv.Venta

    Me.pnl_tipocompraventa.Visible = False
    mTipoCompraVentaVisible = False
    Select Case _tipomovinv
      Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.DevCompra
        Me.ComboBoxTipoCompraVenta.Parametro = Enumerados.EnumParametros.TipoCompra
        Me.ComboBoxTipoCompraVenta.Llenar_Datos()
        Me.lbl_tipocompraventa.Text = "Tipo de compra"
        Me.pnl_tipocompraventa.Visible = True
        mTipoCompraVentaVisible = True
      Case Enumerados.enumTipoMovInv.Venta, Enumerados.enumTipoMovInv.DevVenta
        Me.ComboBoxTipoCompraVenta.Parametro = Enumerados.EnumParametros.TipoVenta
        Me.ComboBoxTipoCompraVenta.Llenar_Datos()
        Me.lbl_tipocompraventa.Text = "Tipo de venta"
        Me.pnl_tipocompraventa.Visible = True
        mTipoCompraVentaVisible = True
    End Select

    Llenar_datos()
  End Sub

  Private Sub dtfecdesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecdesde.ValueChanged, dtfechasta.ValueChanged, ComboBoxTipoCompraVenta.CambioItem, chksolopendientes.CheckedChanged, TskRangoFecha.Expanded, TskRangoFecha.Collapsed, TskTipomovimiento.Expanded, TskTipomovimiento.Collapsed
    Llenar_datos()
  End Sub

#Region "New"
  Private mSucursal As Sucursal = Nothing
  'Private mRegistroContable As RegistroContable = Nothing

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, ByVal _SoloCuenta As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Usuarios)
    MyBase.New(_Sistema, _Restriccion, _busqueda, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    EsBusqueda = _busqueda
    mSoloCuentas = _SoloCuenta
    'AddHandler Me.DataGridView1.CellMouseMove, AddressOf Me.DataGridView1_CellMouseMove
    Forma_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, ByVal _SoloCuenta As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Usuarios)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _SoloCuenta, _OpcionNuevo)
  End Sub

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.BarraEmpresa1.Sistema = Sistema
    Me.BarraEmpresa1.Llenar_datos()
    Me.Sucursal = Me.BarraEmpresa1.Sucursal
    'Me.RegistroContable = Me.BarraEmpresa1.RegistroContable

    If mSoloCuentas Then
      ToolStripManager.Merge(Me.ToolStrip2, Me.ToolStrip1)
    End If
    Me.ToolStrip2.Visible = False

    mPuedeMostrar = False
    Me.dtfecdesde.Value = Now.Date.AddMonths(-1)
    Me.dtfechasta.Value = Now.Date

    Me.ComboBoxTipoMovimiento.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxTipoMovimiento.Parametro = Enumerados.EnumParametros.TipoMovInventario
    If mSoloCuentas Then
      MyBase.Titulo = "Cuentas"
      MyBase.AgregarLeyenda = "Agregar una nueva Cuenta"

      Me.ComboBoxTipoMovimiento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, New WWTSParametroDet(Sistema.OperadorDatos, 439, 1))
    Else
      MyBase.Titulo = "Movimientos de Inventario"
      MyBase.AgregarLeyenda = "Agregar un nuevo Movimiento de Inventario"

      Me.ComboBoxTipoMovimiento.Llenar_Datos()
    End If
    ComboBoxTipoCompraVenta.OperadorDatos = Sistema.OperadorDatos
    ComboBoxTipoMovimiento_CambioItem(Me, Nothing)
    mPuedeMostrar = True
    Llenar_datos()
  End Sub
#End Region

  Private Sub BarraEmpresa1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraEmpresa1.CambioDatos
    Me.Sucursal = Me.BarraEmpresa1.Sucursal
  End Sub

  Private Sub btnconciliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmayorizar.Click
    Mayorizar(True)
  End Sub

  Private Sub btndeconciliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndemayorizar.Click
    Mayorizar(False)
  End Sub

End Class
