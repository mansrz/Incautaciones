Imports System.IO
Imports Infoware.Datos
Imports Infoware.Reglas.General 
'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmPuntodeVenta
  Implements IOpcion

#Region "IOpcion"
  Private mBodegas As BodegaList = Nothing
  Private tiposmovs As ParametroDetList
  Private mEmpleado As Empleado = Nothing
  Private mFondoTPV As String

  Public Property Empleado() As Empleado
    Get
      Return mEmpleado
    End Get
    Set(ByVal value As Empleado)
      If value IsNot Nothing Then
        mEmpleado = value
        Me.ToolStriptitulo.Text = String.Format("TPV - {0}", mEmpleado.NombreCompleto)
      End If
    End Set
  End Property
#End Region

  Private mSucursal As Sucursal = Nothing
  Public Property Sucursal() As Sucursal
    Get
      Return mSucursal
    End Get
    Set(ByVal value As Sucursal)
      mSucursal = value

      If value IsNot Nothing Then
        Me.ComboboxBodega1.ComboBox.DisplayMember = "NombreCompleto"
        Me.ComboboxBodega1.ComboBox.ValueMember = "Bodega_Codigo"
        mBodegas = BodegaList.ObtenerLista(mSucursal)
        Me.ComboboxBodega1.ComboBox.DataSource = mBodegas

        Venta = New Venta(mSucursal, Enumerados.enumTipoVenta.TicketPOS, True)
      End If
    End Set
  End Property


  '#Region "FullScreen"
  '  Public Event FullScreen As EventHandler
  '  Public Event noFullScreen As EventHandler

  '  Private Sub btnfullscreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfullscreen.CheckedChanged
  '    If btnfullscreen.Checked Then
  '      RaiseEvent FullScreen(Me, Nothing)
  '    Else
  '      RaiseEvent noFullScreen(Me, Nothing)
  '    End If
  '  End Sub

  '  Private Sub PantallaCompletaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
  '    Me.btnfullscreen.Checked = Not Me.btnfullscreen.Checked
  '  End Sub
  '#End Region

#Region "Parametros"
  Public Property Ventas() As BindingSource
    Get
      Return BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      BindingSource1 = value
      llenar_datos()
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
        Dim _Ventas As New VentaList
        _Ventas.Add(mVenta)
        BindingSource1.DataSource = GetType(Venta)
        BindingSource1.DataSource = _Ventas
      End If
      llenar_datos()
    End Set
  End Property
#End Region

#Region "Detalles de factura"
  Sub Llenar_detalles()
    Me.DataGridViewDetalles.Venta = mVenta
  End Sub

  Private Sub DataGridViewDetalles_Cambio_MovimientoDets(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewDetalles.Cambio_MovimientoDets, txtdsctoglobal.Validated
    mostrar_totales()
  End Sub

  Private Sub mostrar_totales()
    mVenta.MovimientoInventario.Movinv_Descto = Me.txtdsctoglobal.Value

    Me.txtsubtotal.Value = mVenta.MovimientoInventario.Subtotal
    Me.txttotaldescto.Value = mVenta.MovimientoInventario.TotalDescto
    Me.txtbase0.Value = mVenta.MovimientoInventario.Base0
    Me.txtbasegravada.Value = mVenta.MovimientoInventario.BaseGravadaIVA
    Me.txtiva.Value = mVenta.MovimientoInventario.TotalIva
    Me.lbl_total.Text = mVenta.MovimientoInventario.TotalGeneral.ToString("c")
    'If Me.DataGridViewDetalles.CtlMovimientoInventarioDet2.CurrentRow IsNot Nothing Then
    '  MostrarImagen(Me.DataGridViewDetalles.CtlMovimientoInventarioDet2.CurrentRow.Index)
    'End If
  End Sub
#End Region

  '#Region "Mostrar imagen"
  '  Private Sub DataGridViewDetalles_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewDetalles.RowEnter
  '    MostrarImagen(e.RowIndex)
  '  End Sub

  '  Private Sub MostrarImagen(ByVal fila As Integer)
  '    If fila >= 0 And fila < Me.DataGridViewDetalles.CtlMovimientoInventarioDet2.RowCount Then
  '      Me.CtlItemDatos1.MovimientoInventarioDet = Me.Venta.MovimientoInventario.Detalles(fila)
  '    Else
  '      Me.CtlItemDatos1.MovimientoInventarioDet = Nothing
  '    End If
  '  End Sub
  '#End Region

#Region "Actualizar"
  Private Sub Actualizar_datos(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboboxBodega1.SelectedIndexChanged, ComboBoxFormaPago.CambioItem, ComboBoxTipoPrecio.CambioItem 'ComboBoxIVA1.CambioItem,
    mapear_datos()
  End Sub

  Private Sub mapear_datos()
    If mestallenando Then
      Exit Sub
    End If

    If mVenta IsNot Nothing Then
      Me.DataGridViewDetalles.PardetTipoPrecio = Me.ComboBoxTipoPrecio.ParametroDet

      'Me.ComboBoxIVA1.Llenar_datos(mVenta.MovimientoInventario.Movinv_Fecha)
      'Me.ComboBoxIVA1.SelectedValue = mVenta.MovimientoInventario.SRI_iva

      mestallenando = True
      If Me.ComboboxBodega1.SelectedIndex = -1 AndAlso Me.ComboboxBodega1.Items.Count > 0 Then
        Me.ComboboxBodega1.SelectedIndex = 0
      End If
      'If Me.ComboBoxIVA1.SelectedIndex = -1 AndAlso Me.ComboBoxIVA1.Items.Count > 0 Then
      '  Me.ComboBoxIVA1.SelectedIndex = 0
      'End If
      mVenta.MovimientoInventario.Bodega = mBodegas(Me.ComboboxBodega1.SelectedIndex)
      'mVenta.MovimientoInventario.SRI_iva = Me.ComboBoxIVA1.SelectedValue
      'mVenta.MovimientoInventario.Movinv_porcIVA = Me.ComboBoxIVA1.porcentajeIVA.porcentaje
      mVenta.MovimientoInventario.Movinv_Descto = Me.txtdsctoglobal.Value

      Me.DataGridViewDetalles.PardetTipoPago = Me.ComboBoxFormaPago.ParametroDet

      mostrar_totales()

      mVenta.Cliente = Me.CtlBuscaCliente1.Cliente
      Try
        mVenta.Empleado = mEmpleado
      Catch ex As Exception

      End Try
      mVenta.PardetTipoPago = Me.ComboBoxFormaPago.ParametroDet
      mVenta.PardetTipoPrecio = Me.ComboBoxTipoPrecio.ParametroDet
      'Dim _tipo_compte As SRI.Reglas.tipo_comprobante
      '_tipo_compte = SRI.Reglas.tipos_comprobantes.ObtenerLista(mVenta.Cliente.Entidad.SRICodigo_Identificacion, mVenta.MovimientoInventario.Movinv_Fecha, SRI.Reglas.credito_tributario.EnumTipoTransaccion.Venta).BuscarCodigo("18")
      'If _tipo_compte Is Nothing Then
      '  MsgBox("El cliente no tiene una identificación válida", vbInformation, "Información")
      'Else
      '  mVenta.SRI_tipocomprobante = _tipo_compte.codigo
      '  mVenta.SRI_secuencialtransaccion = _tipo_compte.secuencial_transaciones.RetornarCodigo(mVenta.Cliente.Entidad.SRICodigo_Identificacion)
      'End If
      mestallenando = False

      If mVenta.EsNuevo Then
        Me.lblnumero.Text = ""
      Else
        Me.lblnumero.Text = String.Format("{0}{1}{2}", mVenta.PardetTipoVenta.Pardet_Descripcion, vbCrLf, mVenta.Venta_Numero)
      End If
    End If
  End Sub

  Private mestallenando As Boolean = False
  Private Sub llenar_datos()
    If mSucursal Is Nothing Then
      Exit Sub
    End If

    mVenta = Ventas.Current

    mestallenando = True
    'Me.dtpFecdesde.Value = mMovimientoInventario.Movinv_Fecha
    'Me.txtnumero.Value = mMovimientoInventario.Movinv_Secuencia
    'Me.txtobservacion.Text = mMovimientoInventario.Movinv_Observaciones
    'Me.comboTipoMovimiento.ComboBox.SelectedValue = CInt(mMovimientoInventario.Pardet_Tipomovinv)
    Me.ComboboxBodega1.ComboBox.SelectedValue = mVenta.MovimientoInventario.Bodega_Codigo
    'Me.ComboBoxBodega2.Bodega = mMovimientoInventario.BodegaDsno
    Me.txtdsctoglobal.Value = mVenta.MovimientoInventario.Movinv_Descto

    'Me.ComboBoxIVA1.SelectedValue = mVenta.MovimientoInventario.SRI_iva
    Llenar_detalles()
    mestallenando = False

    Me.CtlBuscaCliente1.Cliente = mVenta.Cliente
    Empleado = mVenta.Empleado
    Me.ComboBoxFormaPago.ParametroDet = mVenta.PardetTipoPago
    Me.ComboBoxTipoPrecio.ParametroDet = mVenta.PardetTipoPrecio
    mapear_datos()

    Me.pnlcliente.Enabled = mVenta.EsNuevo
    Me.pnltotales.Enabled = mVenta.EsNuevo
    'Me.mnupagorapido.Enabled = Not mVenta.EsNuevo
    'Me.PagosToolStripMenuItem.Enabled = Not mVenta.EsNuevo
    'Me.btnpagorapido.Enabled = Not mVenta.EsNuevo
    'Me.btnpagos.Enabled = Not mVenta.EsNuevo

    Me.CtlBuscaCliente1.Focus()
  End Sub
#End Region

  Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click, btncancelar.Click
    Venta = New Venta(mSucursal, Enumerados.enumTipoVenta.TicketPOS, True)
  End Sub

  Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click, btnbuscar.Click
    'Dim numero As String
    'numero = InputBox("Ingrese número de Ticket", "Búsqueda de ticket", "0")
    'If CInt(IIf(numero = "", "0", numero)) > 0 Then
    '  Try
    '    Venta = New Venta(mSucursal, Enumerados.enumTipoVenta.TicketPOS, CInt(IIf(numero = "", "0", numero)))
    '  Catch ex As Exception
    '  End Try
    'End If
    Dim f As New FrmBuscaMovimientoInventario
    f.Sucursal = mSucursal
    f.TipoMovInventario = Enumerados.enumTipoMovInv.Venta
    If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
      Venta = f.Venta
    End If
  End Sub

  Private Sub AbrirCajonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirCajonToolStripMenuItem.Click, btnabrircaja.Click

  End Sub

  Private Sub ImprimirTicketToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirTicketToolStripMenuItem.Click, btnimprimirticket.Click
    If mVenta.EsNuevo Then
      If Not Guardar_datos() Then
        Exit Sub
      End If
    End If

    My.Computer.FileSystem.CreateDirectory(Me.Sistema.DirectorioRaiz)
    My.Computer.FileSystem.CreateDirectory(Path.Combine(Me.Sistema.DirectorioRaiz, "Formatos"))

    Dim archivo As String
    archivo = Me.Sistema.DirectorioRaiz & "\Formatos\" & Enumerados.enumTipoVenta.TicketPOS.ToString.Trim & ".rps"
    Try
      If File.Exists(archivo) Then
        Dim _data As New Infoware.Reportes.ReportData
        _data = Infoware.Reportes.ReportData.DeSerializeList(archivo)

        Dim reporte As New Infoware.Reportes.ReportSimple
        reporte.ReportData = _data
        reporte.ReportData.HeaderData = mVenta.MovimientoInventario
        reporte.ReportData.DetailsData = mVenta.MovimientoInventario.Detalles
        reporte.Print()
      Else
        Dim f As New Infoware.Reportes.FrmReportSimple
        f.ArchivoReporte = archivo
        f.Cabecera = mVenta.MovimientoInventario
        f.Detalles = mVenta.MovimientoInventario.Detalles
        f.ShowDialog()
      End If
    Catch ex As Exception
      MsgBox("Error al abrir la impresora. Verifique que el formato esté apuntando a la impresora correcta y que la misma se encuentre lista" & Environment.NewLine & ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub CierreDediaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreDediaToolStripMenuItem.Click, btncierredia.Click

  End Sub

  Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click, GuardarToolStripMenuItem.Click
    If Guardar_datos() Then

    End If
  End Sub

  Private Function Guardar_datos() As Boolean
    Try
      mapear_datos()
      Dim esnuevo As Boolean = mVenta.EsNuevo
      If esnuevo AndAlso Me.txtsubtotal.Value = 0 Then
        Throw New Exception("Venta no tiene items")
      End If
      If Not mVenta.Guardar(True) Then 'todo
        Throw New Exception(mVenta.OperadorDatos.MsgError)
      End If
      'MsgBox(String.Format("Movimiento guardado {0} {1}" & vbNewLine & "{2} {3}", mVenta.MovimientoInventario.PardetTipoMovInv.Pardet_Descripcion, mVenta.MovimientoInventario.Movinv_Secuencia, mVenta.PardetTipoVenta.Pardet_Descripcion, mVenta.Venta_Numero))

      'If esnuevo Then
      '  mostrar_pagos()
      'End If
      llenar_datos()
      Return True
    Catch ex As Exception
      MsgBox("No se puede guardar Ticket" & Environment.NewLine & ex.Message, MsgBoxStyle.Critical, "Error")
      Return False
    End Try
  End Function

  Private Sub PagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosToolStripMenuItem.Click, btnpagos.Click
    If Guardar_datos() Then
      mostrar_pagos()
    End If
  End Sub

  Private Sub mostrar_pagos()
    Dim f As New FrmMantenimientoPagos(Sistema, Enumerados.EnumOpciones.Cuentas, mSucursal)
    f.MovimientoInventario = mVenta.MovimientoInventario
    f.ShowDialog()
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Empleado As Empleado, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    'mSucursal = _Sucursal
    Empleado = _Empleado
    ' Add any initialization after the InitializeComponent() call.
    FrmListaBodegas_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _Empleado As Empleado, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Usuarios)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _Empleado, _OpcionNuevo)
  End Sub

  Private Sub FrmListaBodegas_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.CtlBuscaCliente1.OperadorDatos = Sistema.OperadorDatos

    Me.ComboBoxFormaPago.Parametro = Enumerados.EnumParametros.TipoFormaPago
    Me.ComboBoxFormaPago.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxFormaPago.Llenar_Datos()

    Me.ComboBoxTipoPrecio.Parametro = Enumerados.EnumParametros.TipoPrecio
    Me.ComboBoxTipoPrecio.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxTipoPrecio.Llenar_Datos()

    'Llenar_datos()

    Dim mDirectorioRaiz = String.Format("{0}\{1}", My.Computer.FileSystem.SpecialDirectories.MyDocuments, My.Application.Info.Title)
    My.Computer.FileSystem.CreateDirectory(String.Format("{0}\Fondos", mDirectorioRaiz))

    mFondoTPV = String.Format("{0}\Fondos\FondoTPV.jpg", mDirectorioRaiz)

    Try
      Me.ToolStrip2.BackgroundImage = Image.FromFile(mFondoTPV)
    Catch ex As Exception

    End Try

    Me.BarraEmpresa1.Sistema = Sistema
    'Me.BarraEmpresa1.RegContableVisible = False
    Me.BarraEmpresa1.Llenar_datos()

    Sucursal = Me.BarraEmpresa1.Sucursal
  End Sub
#End Region

  'Private Sub btndeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeshacer.Click
  '  Try
  '    Me.DataGridViewDetalles.DataBindings.RemoveAt(Me.DataGridViewDetalles.DataBindings.Count - 1)
  '  Catch ex As Exception

  '  End Try
  'End Sub

  Private Sub BarraEmpresa1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraEmpresa1.CambioDatos
    Me.Sucursal = Me.BarraEmpresa1.Sucursal
  End Sub

#Region "IOpcion"
  Public ReadOnly Property Control() As System.Windows.Forms.Control Implements Infoware.Consola.Base.IOpcion.Control
    Get
      Return Me.pnlcuerpo
    End Get
  End Property

  Public ReadOnly Property MenuStrip() As System.Windows.Forms.MenuStrip Implements Infoware.Consola.Base.IOpcion.MenuStrip
    Get
      Return Me.MenuStrip1
    End Get
  End Property

  Public ReadOnly Property ToolStrip() As System.Windows.Forms.ToolStrip Implements Infoware.Consola.Base.IOpcion.ToolStrip
    Get
      Return Nothing 'Me.ToolStrip2
    End Get
  End Property
#End Region

  Private Sub btnpagorapido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpagorapido.Click, mnupagorapido.Click
    If Guardar_datos() Then
      pagorapido()
    End If
  End Sub

  Private Sub pagorapido()
    If mVenta.MovimientoInventario.TotalGeneral > 0 And mVenta.MovimientoInventario.ValorPendiente > 0 Then
      Dim f As New FrmMantenimientoPagoRapido(Sistema, Enumerados.EnumOpciones.Cuentas)
      f.MovimientoInventario = mVenta.MovimientoInventario
      f.ShowDialog()
    Else
      MsgBox("Factura totalemente cancelada", vbInformation, "Información")
    End If
  End Sub
End Class