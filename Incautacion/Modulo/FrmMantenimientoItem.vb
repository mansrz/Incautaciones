Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmMantenimientoItem
#Region "Parametros"
  Public Property Items() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mItem As Item = Nothing
  Public Property Item() As Item
    Get
      Return mItem
    End Get
    Set(ByVal value As Item)
      mItem = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _items As New ItemList
        _items.Add(mItem)
        MyBase.BindingSource1.DataSource = GetType(Item)
        MyBase.BindingSource1.DataSource = _items
      End If
    End Set
  End Property

  Sub llenar_datos()
    'If mSucursal Is Nothing Then
    '  Exit Sub
    'End If

    mItem = MyBase.BindingSource1.Current
    If mItem IsNot Nothing Then
      mItem.Recargar()
    End If
    ValidarRegistro()
    If mItem IsNot Nothing Then
      mItem.Recargar()
      Me.txtcodigo.Enabled = mItem.EsNuevo
      Me.txtcodigo.Text = mItem.Item_Codigo
      Me.txtdescripcion.Text = mItem.Item_Descripcion
      Me.ComboBoxGrupo1.ParametroDet = mItem.PardetGrupo
      Me.ComboBoxMarca1.ParametroDet = mItem.PardetMarca
      Me.ComboBoxTipoInventario1.ParametroDet = mItem.PardetTipoInventario
      Me.ComboBoxUnidadMedida1.ParametroDet = mItem.PardetUnidadMedida
      Me.txtubicacion.Text = mItem.Item_Ubicacion
      Me.chkaplicaiva.Checked = mItem.Item_Aplicaiva
      Me.chkcombo.Checked = mItem.Item_Combo
      Me.chkestangible.Checked = mItem.Item_Estangible
      Me.chkesincluyeiva.Checked = mItem.Item_esIvaIncluido
      Me.chkesregistroserie.Checked = mItem.Item_esRegistroSerie
      Me.txtcodigoauxiliar.Text = mItem.Item_CodigoAuxiliar
      Me.txtcodigoproveedor.Text = mItem.Item_CodigoProveedor
      Me.CtlBuscaProveedor1.Proveedor = mItem.Proveedor
      Me.chkprecioxcantidad.Checked = mItem.Item_PrecioxCantidad

      Me.PictureBox1.Imagen = mItem.Item_Imagen

      Me.grpexistencias.Enabled = Not mItem.EsNuevo
      Me.grplistaprecios.Enabled = Not mItem.EsNuevo

      Llenar_detallesExistencia()
      Llenar_detallesListaPrecios()
      Llenar_detallesCombo()
      Llenar_detallesPreciosxCantidad()
    End If
    'Me.CtlKardexIndividual1.Sistema = Me.Sistema
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoItem_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mItem.EsNuevo
    If _esnuevo AndAlso MyBase.BindingSource1.Current IsNot Nothing Then
      MyBase.BindingSource1.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Items eventos"
  Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Item As Item = New Item(Sistema.OperadorDatos, True)
    e.NewObject = _Item
  End Sub

  Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoItem_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    Me.DGExistencias.EndEdit()
    Me.DGListaPrecios.EndEdit()

    mItem.Item_Codigo = Me.txtcodigo.Text
    mItem.Item_Descripcion = Me.txtdescripcion.Text
    mItem.PardetGrupo = Me.ComboBoxGrupo1.ParametroDet
    mItem.PardetMarca = Me.ComboBoxMarca1.ParametroDet
    mItem.PardetTipoInventario = Me.ComboBoxTipoInventario1.ParametroDet
    mItem.PardetUnidadMedida = Me.ComboBoxUnidadMedida1.ParametroDet
    mItem.Item_Ubicacion = Me.txtubicacion.Text
    mItem.Item_Aplicaiva = Me.chkaplicaiva.Checked
    mItem.Item_Combo = Me.chkcombo.Checked
    mItem.Item_Estangible = Me.chkestangible.Checked
    mItem.Item_esIvaIncluido = Me.chkesincluyeiva.Checked
    mItem.Item_esRegistroSerie = Me.chkesregistroserie.Checked
    mItem.Item_CodigoAuxiliar = Me.txtcodigoauxiliar.Text
    mItem.Item_CodigoProveedor = Me.txtcodigoproveedor.Text
    mItem.Proveedor = Me.CtlBuscaProveedor1.Proveedor
    mItem.Item_PrecioxCantidad = Me.chkprecioxcantidad.Checked

  End Sub

  Private Function Guardar_datos() As Boolean
    Try
      Mapear_datos()
      Dim _esnuevo As Boolean = mItem.EsNuevo
      If Not mItem.Guardar() Then
        Throw New Exception
      End If

      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mItem.Item_Descripcion)

      If Me.BindingSourceExistencias.DataSource IsNot Nothing Then
        For Each _itemxbodega As ItemxBodega In Me.BindingSourceExistencias.DataSource
          _itemxbodega.Guardar()
        Next
      End If

      For Each _ItemxTipoPrecio As ItemxTipoPrecio In Me.BindingSourceListaPrecios.DataSource
        _ItemxTipoPrecio.Guardar()
      Next
      llenar_datos()
      Return True
    Catch ex As Exception
      MsgBox("No se puede guardar Item" & Environment.NewLine & Sistema.OperadorDatos.MsgError & ". " & ex.Message, MsgBoxStyle.Critical, "Error")
      Return False
    End Try
  End Function

  Private Sub FrmMantenimientoItem_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mItem.Eliminar() AndAlso MyBase.BindingSource1.Current IsNot Nothing Then
      MyBase.BindingSource1.RemoveCurrent()
      Me.Close()
    Else
      'MyBase.BindingSource1.CancelEdit()
      MsgBox("No se puede eliminar Item" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoItem_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoItem_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoItem_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoItem_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "Imagen"
  Private Sub CambioImagen(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.CambioImagen
    If mItem Is Nothing Then
      Exit Sub
    End If
    mItem.ArchivoImagen = Me.PictureBox1.ArchivoImagen
  End Sub
#End Region

  Sub Llenar_detallesExistencia()
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

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Itebod_Costopromedio"
    DataGridViewTextBoxColumn1.HeaderText = "Costo promedio"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    Me.DGExistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Itebod_StockMinimo"
    DataGridViewTextBoxColumn1.HeaderText = "Mínimo"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.ReadOnly = False
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    Me.DGExistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Itebod_StockMaximo"
    DataGridViewTextBoxColumn1.HeaderText = "Máximo"
    DataGridViewTextBoxColumn1.Width = 60
    DataGridViewTextBoxColumn1.ReadOnly = False
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    Me.DGExistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.BindingSourceExistencias.DataSource = GetType(ItemxBodegaList)
    'mMovimientoInventarioDets = 
    BindingSourceExistencias.DataSource = mItem.ItemxBodegas(mSucursal)
    aplicar_checks()
  End Sub

  Sub Llenar_detallesListaPrecios()
    Me.DGListaPrecios.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PardetTipoPrecioString"
    DataGridViewTextBoxColumn1.HeaderText = "Tipo de precio"
    DataGridViewTextBoxColumn1.ReadOnly = True
    DataGridViewTextBoxColumn1.Width = 95
    Me.DGListaPrecios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "IteTip_Valor"
    DataGridViewTextBoxColumn1.HeaderText = "Valor"
    DataGridViewTextBoxColumn1.Width = 60
    Dim estilonum2 As New DataGridViewCellStyle()
    estilonum2.Format = "N2"
    DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
    Me.DGListaPrecios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.BindingSourceListaPrecios.DataSource = GetType(ItemxTipoPrecioList)
    'mMovimientoInventarioDets = 
    BindingSourceListaPrecios.DataSource = mItem.ItemxTipoPrecios(mSucursal)
  End Sub

  Sub Llenar_detallesCombo()
    Me.BSDetallesCombo.DataSource = GetType(ItemDetalle)
    'mMovimientoInventarioDets = 
    BSDetallesCombo.DataSource = mItem.DetallesCombo(mSucursal)
    Me.DGDetallesCombo.AutoDiscover()
  End Sub

  Sub Llenar_detallesPreciosxCantidad()
    Me.BSPreciosxcantidad.DataSource = GetType(ItemPrecioxCantidad)
    'mMovimientoInventarioDets = 
    BSPreciosxcantidad.DataSource = mItem.DetallesPrecioxCantidad(mSucursal)
    Me.DGPreciosxcantidad.AutoDiscover()
  End Sub

  Private Sub txtcodigoauxiliar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodigoauxiliar.TextChanged
    Me.lblcodigoauxiliar.Text = txtcodigoauxiliar.Text
  End Sub

#Region "New"
  Private mSucursal As Sucursal

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Sucursal As Sucursal, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    mSucursal = _Sucursal
    FrmMantenimientoItem_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _Sucursal As Sucursal, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _Sucursal, _OpcionNuevo)
  End Sub

  Private Sub FrmMantenimientoItem_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    ToolStripManager.Merge(Me.ToolStrip2, Me.ToolStrip1)
    Me.ToolStrip2.Visible = False

    MyBase.Tabla = "Item"

    Me.ComboBoxGrupo1.Op = Sistema.OperadorDatos
    Me.ComboBoxGrupo1.Parametro = Enumerados.EnumParametros.Grupo
    Me.ComboBoxGrupo1.Llenar_Datos()

    Me.ComboBoxMarca1.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxMarca1.Parametro = Enumerados.EnumParametros.Marca
    Me.ComboBoxMarca1.Llenar_Datos()

    Me.ComboBoxTipoInventario1.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxTipoInventario1.Parametro = Enumerados.EnumParametros.TipoInventario
    Me.ComboBoxTipoInventario1.Llenar_Datos()

    Me.ComboBoxUnidadMedida1.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxUnidadMedida1.Parametro = Enumerados.EnumParametros.UnidadMedida
    Me.ComboBoxUnidadMedida1.Llenar_Datos()

    Me.CtlBuscaProveedor1.OperadorDatos = Sistema.OperadorDatos
    Me.CtlBuscaProveedor1.Llenar_Datos()

    Me.grpexistencias.Height = 195
    Me.grpdetallescombo.Height = 195
    Me.grplistaprecios.Height = 195
    Me.grppreciosxcantidad.Height = 195
  End Sub

#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub

  Private Sub AbrirElemento(ByVal _fila As DataRow)
    If CInt(_fila(0)) = 0 Then
      Exit Sub
    End If

    Dim _mov As MovimientoInventario
    _mov = New MovimientoInventario(mSucursal, CType(_fila(0), Enumerados.enumTipoMovInv), CInt(_fila(2)))
    Dim f As New FrmMantenimientoMovimientoInventario(Me.Sistema, Enumerados.EnumOpciones.MovimientoInventario, mSucursal, Nothing)
    f.MovimientoInventario = _mov
    'f.Restriccion = mRestricciones.Buscar(mOpcionActual)
    f.ShowDialog()
    f.Dispose()
  End Sub

  Private Sub ComboBoxTipoInventario1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxTipoInventario1.CambioItem
    Me.chkesregistroserie.Enabled = True
    If Me.ComboBoxTipoInventario1.ParametroDet IsNot Nothing Then
      Me.chkesregistroserie.Enabled = Not CType(Me.ComboBoxTipoInventario1.ParametroDet.Pardet_Secuencia, Enumerados.EnumTipoInventario) = Enumerados.EnumTipoInventario.ActivoFijo And Not Me.chkcombo.Checked
    End If
  End Sub

  Private Sub KardexIndividualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KardexIndividualToolStripMenuItem.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.ReportesInventario)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "proc_Kardex_Individual")
    f.Valores = New Object() {Now.AddMonths(-1).Date, Now.Date, Item.Item_Codigo, mSucursal.Empres_Codigo, mSucursal.Sucurs_Codigo}
    f.objAbrirElemento = New Infoware.Reporteador.FrmLista.AbrirElemento(AddressOf AbrirElemento)
    f.ShowDialog()
  End Sub

  Private Sub ComponentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComponentesToolStripMenuItem.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.ReportesInventario)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "proc_Componentes_Ensamblados")
    f.Valores = New Object() {Item.Item_Codigo, mSucursal.Empres_Codigo}
    f.objAbrirElemento = New Infoware.Reporteador.FrmLista.AbrirElemento(AddressOf AbrirElemento)
    f.ShowDialog()
  End Sub

  Private Sub chkesincluyeiva_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkesincluyeiva.CheckedChanged
    If Me.chkesincluyeiva.Checked Then
      chkaplicaiva.Checked = True
    End If
  End Sub

  Private Sub chkcombo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcombo.CheckedChanged, chkprecioxcantidad.CheckedChanged, chkestangible.CheckedChanged
    aplicar_checks()
  End Sub

  Sub aplicar_checks()
    Me.grpexistencias.Visible = Me.chkestangible.Checked

    If chkcombo.Checked Then
      Me.chkaplicaiva.Checked = False
      Me.chkestangible.Checked = False
      Me.chkesincluyeiva.Checked = False
      Me.chkesregistroserie.Checked = False
      Me.chkprecioxcantidad.Checked = False
      Me.ComboBoxUnidadMedida1.ParametroDet = New WWTSParametroDet(Sistema.OperadorDatos, CInt(Enumerados.EnumParametros.UnidadMedida), 1)
    End If
    Me.chkaplicaiva.Enabled = Not Me.chkcombo.Checked
    Me.chkestangible.Enabled = Not Me.chkcombo.Checked
    Me.chkesincluyeiva.Enabled = Not Me.chkcombo.Checked
    Me.chkesregistroserie.Enabled = Not Me.chkcombo.Checked
    Me.chkprecioxcantidad.Enabled = Not Me.chkcombo.Checked
    Me.ComboBoxUnidadMedida1.Enabled = Not Me.chkcombo.Checked

    Me.grpdetallescombo.Visible = Me.chkcombo.Checked
    Me.grplistaprecios.Visible = Not Me.chkcombo.Checked And Not Me.chkprecioxcantidad.Checked
    Me.grppreciosxcantidad.Visible = Not Me.chkcombo.Checked And Me.chkprecioxcantidad.Checked
  End Sub

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    Dim _itemdetalle As New ItemDetalle(mItem, True)
    _itemdetalle.Sucursal = mSucursal
    CType(BSDetallesCombo.DataSource, ItemDetalleList).Add(_itemdetalle)
    BSDetallesCombo.MoveLast()

    Dim f As New FrmMantenimientoItemDetalle(Sistema, Enumerados.EnumOpciones.ListadoItems, mSucursal)
    f.RegistroAceptado = False
    f.Item = mItem
    f.ItemDetalles = Me.BSDetallesCombo
    f.ShowDialog()
    If BSDetallesCombo.Count <= 1 Then
      Me.DGDetallesCombo.AutoDiscover()
    End If
    Me.DGDetallesCombo.Invalidate()
    f.Dispose()
  End Sub

  Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
    Dim f As New FrmMantenimientoItemDetalle(Sistema, Enumerados.EnumOpciones.ListadoItems, mSucursal)
    f.RegistroAceptado = True
    f.Item = mItem
    f.ItemDetalles = Me.BSDetallesCombo
    f.ShowDialog()
    If BSDetallesCombo.Count <= 1 Then
      Me.DGDetallesCombo.AutoDiscover()
    End If
    Me.DGDetallesCombo.Invalidate()
    f.Dispose()
  End Sub

  Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
    If BSDetallesCombo.Current Is Nothing Then
      Exit Sub
    End If
    mItem.DetallesComboEliminados.Add(BSDetallesCombo.Current)
    BSDetallesCombo.RemoveCurrent()
  End Sub

  Private Sub btnnuevopxc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevopxc.Click
    Dim _pxc As New ItemPrecioxCantidad(mItem, True)
    _pxc.Sucursal = mSucursal

    Me.BSPreciosxcantidad.Add(_pxc)
    Me.BSPreciosxcantidad.MoveLast()

    If BSPreciosxcantidad.Count <= 1 Then
      Me.DGPreciosxcantidad.AutoDiscover()
    End If
    Me.DGPreciosxcantidad.Invalidate()
  End Sub

  Private Sub btnelipxc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelipxc.Click
    If mItem Is Nothing OrElse Me.BSPreciosxcantidad.Current Is Nothing Then
      Exit Sub
    End If
    mItem.DetallesPrecioxCantidadEliminados.Add(Me.BSPreciosxcantidad.Current)
    Me.BSPreciosxcantidad.RemoveCurrent()
  End Sub
End Class
