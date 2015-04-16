Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General

'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmMantenimientoMovimientoInventarioDet
#Region "IOpcion"
  Private mMovimientoInventario As MovimientoInventario = Nothing
  Public Property MovimientoInventario() As MovimientoInventario
    Get
      Return mMovimientoInventario
    End Get
    Set(ByVal value As MovimientoInventario)
      mMovimientoInventario = value
      MyBase.Tabla = "Detalle de movimiento"

      If value IsNot Nothing Then
        Me.ComboBoxUnidadMedida.Parametro = Enumerados.EnumParametros.UnidadMedida
        Me.ComboBoxUnidadMedida.OperadorDatos = value.OperadorDatos
        Me.ComboBoxUnidadMedida.Llenar_Datos(ParametroDetList.enumTipoObjeto.UnidadMedida)

        'Me.CtlBuscaItem1.Sistema = Me.Sistema
        Me.CtlBuscaItem1.Sucursal = value.Sucursal
      End If
    End Set
  End Property
#End Region

  Private mEstaCambiando As Boolean = False
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

#Region "Parametros"
  Public Property MovimientoInventarioDets() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mMovimientoInventarioDet As MovimientoInventarioDet = Nothing
  Public Property MovimientoInventarioDet() As MovimientoInventarioDet
    Get
      Return mMovimientoInventarioDet
    End Get
    Set(ByVal value As MovimientoInventarioDet)
      mMovimientoInventarioDet = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _MovimientoInventarioDets As New MovimientoInventarioDetList
        _MovimientoInventarioDets.Add(mMovimientoInventarioDet)
        MyBase.BindingSource1.DataSource = GetType(MovimientoInventarioDet)
        MyBase.BindingSource1.DataSource = _MovimientoInventarioDets
      End If
    End Set
  End Property

  Sub llenar_datos()
    If mMovimientoInventario Is Nothing Then
      Exit Sub
    End If

    mMovimientoInventarioDet = MovimientoInventarioDets.Current
    ValidarRegistro()
    mEstaCambiando = True
    Me.CtlBuscaItem1.Item = mMovimientoInventarioDet.Item
    Me.txtcantidad.Value = mMovimientoInventarioDet.Moinde_Cantidad
    If mMovimientoInventarioDet.Item IsNot Nothing Then
      Me.txtobservacion.Text = mMovimientoInventarioDet.Moinde_Descripcion
      Me.ComboBoxUnidadMedida.ParametroDet = mMovimientoInventarioDet.PardetUnidadMedida
      Me.txtvalor.Value = mMovimientoInventarioDet.Moinde_Valor
      Me.txtdescto.Value = mMovimientoInventarioDet.Moinde_Descto
      Me.chkaplicaiva.Checked = mMovimientoInventarioDet.Moinde_Aplicaiva
    End If
    Me.CtlBuscaItem1.Select()

    Me.BSSeries.DataSource = mMovimientoInventarioDet.DetallesSeries
    Me.DGSeries.AutoDiscover()
    Me.pnlserie.Visible = Me.CtlBuscaItem1.Item.Item_esRegistroSerie
    If Me.pnlserie.Visible Then
      Me.txtcantidad.Value = Me.BSSeries.Count
    End If

    Me.CtlBuscaItem1.Focus()
    mEstaCambiando = False
    CambioItem()
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoMovimientoInventarioDet_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    'Dim _esnuevo As Boolean = mMovimientoInventarioDet.EsNuevo
    'If _esnuevo Then
    '  MovimientoInventarioDets.RemoveCurrent()
    'End If
    'Return _esnuevo
    Return False
  End Function
#End Region

#Region "MovimientosContables eventos"
  Private Sub FrmMantenimientoMovimientoInventarioDet_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _MovimientoInventarioDet As MovimientoInventarioDet = New MovimientoInventarioDet(mMovimientoInventario, True)
    e.NewObject = _MovimientoInventarioDet
  End Sub

  Private Sub FrmMantenimientoMovimientoInventarioDet_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoMovimientoInventarioDet_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    mMovimientoInventarioDet.Item = Me.CtlBuscaItem1.Item
    mMovimientoInventarioDet.Moinde_Descripcion = Me.txtobservacion.Text
    mMovimientoInventarioDet.Moinde_Cantidad = Me.txtcantidad.Value
    mMovimientoInventarioDet.PardetUnidadMedida = Me.ComboBoxUnidadMedida.ParametroDet
    mMovimientoInventarioDet.Moinde_Valor = Me.txtvalor.Value
    mMovimientoInventarioDet.Moinde_Descto = Me.txtdescto.Value
    mMovimientoInventarioDet.Moinde_Aplicaiva = Me.chkaplicaiva.Checked
  End Sub

  Private Function Guardar_datos() As Boolean
    MovimientoInventarioDets.EndEdit()
    Try
      Mapear_datos()
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      Return False
    End Try
    'If mMovimientoInventarioDet.Guardar() Then
    '  Return True
    'Else
    '  'MovimientosContables.CancelEdit()
    '  MsgBox("No se puede guardar Movimiento Contable" & Environment.NewLine & mMovimientoInventario.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    '  Return False
    'End If
    Return True
  End Function

  Private Sub FrmMantenimientoMovimientoInventarioDet_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mMovimientoInventarioDet.Eliminar() AndAlso MovimientoInventarioDets.Current IsNot Nothing Then
      MovimientoInventarioDets.RemoveCurrent()
      Me.Close()
    Else
      'MovimientosContables.CancelEdit()
      MsgBox("No se puede eliminar MovimientoInventarioDet" & Environment.NewLine & mMovimientoInventario.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoMovimientoInventarioDet_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoMovimientoInventarioDet_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoMovimientoInventarioDet_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoMovimientoInventarioDet_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "Item"
  Private Sub CtlBuscaItem1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaItem1.CambioItem
    If mEstaCambiando Then
      Exit Sub
    End If
    mEstaCambiando = True
    Dim _unidmed As ParametroDet = Me.ComboBoxUnidadMedida.ParametroDet
    Me.ComboBoxUnidadMedida.Llenar_Datos(ParametroDetList.enumTipoObjeto.UnidadMedida, Me.CtlBuscaItem1.Item.PardetUnidadMedida)
    Me.ComboBoxUnidadMedida.ParametroDet = _unidmed

    CambioItem()
    mEstaCambiando = False
  End Sub

  Private Sub ComboBoxUnidadMedida_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxUnidadMedida.CambioItem, txtcantidad.Validated
    If mEstaCambiando Then
      Exit Sub
    End If
    CambioItem()
  End Sub

  Private Sub CambioItem()
    If Me.CtlBuscaItem1.Item Is Nothing Then
      Exit Sub
    End If
    mEstaCambiando = True

    Me.PictureBox1.Image = Me.CtlBuscaItem1.Item.Item_Imagen
    Me.chkaplicaiva.Checked = Me.CtlBuscaItem1.Item.Item_Aplicaiva

    Dim _valor As Decimal = Me.CtlBuscaItem1.Item.BuscarValor(mMovimientoInventario.Pardet_Tipomovinv, mMovimientoInventario.Sucursal, mPardetTipoPrecio, mMovimientoInventario.Movinv_porcIVA, mMovimientoInventario.Bodega, Me.txtcantidad.Value)

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

    'Me.ComboBoxUnidadMedida.Enabled = True
    Me.txtcantidad.Enabled = Not Me.CtlBuscaItem1.Item.Item_esRegistroSerie
    Me.ComboBoxUnidadMedida.Enabled = Not Me.CtlBuscaItem1.Item.Item_esRegistroSerie
    If Me.ComboBoxUnidadMedida.Items.Count <= 1 Then
      Me.ComboBoxUnidadMedida.Enabled = False
    End If
    Me.pnlserie.Visible = Me.CtlBuscaItem1.Item.Item_esRegistroSerie


    'If Me.CtlBuscaItem1.Item.Item_esRegistroSerie Then
    '  Me.ComboBoxUnidadMedida.Enabled = False
    '  Me.txtcantidad.Value = 1
    '  Me.txtcantidad.Enabled = False
    'End If
    Llenar_detallesExistencia()
    mEstaCambiando = False
  End Sub
#End Region


#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _OpcionActual, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub

  Private Sub btnnuevoserie_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevoserie.Click
    If Me.BSSeries.DataSource Is Nothing Then
      Exit Sub
    End If
    Me.BSSeries.AddNew()
    Me.txtcantidad.Value = Me.BSSeries.Count
  End Sub

  Private Sub btneliserie_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btneliserie.Click
    If Me.BSSeries.Current Is Nothing Then
      Exit Sub
    End If
    Me.BSSeries.RemoveCurrent()
    Me.txtcantidad.Value = Me.BSSeries.Count
  End Sub

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
    BindingSourceExistencias.DataSource = Me.CtlBuscaItem1.Item.ItemxBodegas(MovimientoInventario.Sucursal)
  End Sub

End Class
