<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPuntodeVenta
  Inherits Infoware.Consola.Base.FrmFormaBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.AnularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.AbrirCajonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ImprimirTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
    Me.CierreDediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.TPVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnupagorapido = New System.Windows.Forms.ToolStripMenuItem()
    Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    Me.HeaderStrip1 = New Infoware.Docking.HeaderStrip()
    Me.ToolStriptitulo = New System.Windows.Forms.ToolStripLabel()
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
    Me.btnbuscar = New System.Windows.Forms.ToolStripButton()
    Me.lblnumero = New System.Windows.Forms.ToolStripLabel()
    Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
    Me.btncancelar = New System.Windows.Forms.ToolStripButton()
    Me.btnanular = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnguardar = New System.Windows.Forms.ToolStripButton()
    Me.ComboboxBodega1 = New System.Windows.Forms.ToolStripComboBox()
    Me.btnpagorapido = New System.Windows.Forms.ToolStripButton()
    Me.btnpagos = New System.Windows.Forms.ToolStripButton()
    Me.btnabrircaja = New System.Windows.Forms.ToolStripButton()
    Me.btnimprimirticket = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
    Me.btncierredia = New System.Windows.Forms.ToolStripButton()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.lbl_total = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.DataGridViewDetalles = New CtlMovimientoInventarioDet1()
    Me.pnlcliente = New System.Windows.Forms.Panel()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.ComboBoxTipoPrecio = New ComboBoxParametroDet()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.ComboBoxFormaPago = New ComboBoxParametroDet()
    Me.CtlBuscaCliente1 = New CtlBuscaCliente()
    Me.pnltotales = New System.Windows.Forms.Panel()
    Me.txtdsctoglobal = New Infoware.Controles.Base.TextBoxCalculator()
    'Me.ComboBoxIVA1 = New WWTS.SRI.Controles.ComboBoxIVA()
    Me.txtiva = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.txtbasegravada = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtsubtotal = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txttotaldescto = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtbase0 = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.pnlcuerpo = New System.Windows.Forms.Panel()
    Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
    Me.BarraEmpresa1 = New BarraEmpresa()
    Me.MenuStrip1.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.ToolStrip2.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.pnlcliente.SuspendLayout()
    Me.pnltotales.SuspendLayout()
    Me.pnlcuerpo.SuspendLayout()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'BuscarToolStripMenuItem
    '
    Me.BuscarToolStripMenuItem.Image = My.Resources.Resources.find.ToBitmap
    Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
    Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
    Me.BuscarToolStripMenuItem.Text = "&Buscar"
    '
    'CancelarToolStripMenuItem
    '
    Me.CancelarToolStripMenuItem.Image = My.Resources.Resources.undo.ToBitmap
    Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
    Me.CancelarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
    Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
    Me.CancelarToolStripMenuItem.Text = "&Limpiar"
    '
    'AnularToolStripMenuItem
    '
    Me.AnularToolStripMenuItem.Enabled = False
    Me.AnularToolStripMenuItem.Image = My.Resources.Resources.cancel16.ToBitmap
    Me.AnularToolStripMenuItem.Name = "AnularToolStripMenuItem"
    Me.AnularToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
    Me.AnularToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
    Me.AnularToolStripMenuItem.Text = "An&ular"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(193, 6)
    '
    'AbrirCajonToolStripMenuItem
    '
    Me.AbrirCajonToolStripMenuItem.Image = My.Resources.Resources.card_file.ToBitmap
    Me.AbrirCajonToolStripMenuItem.Name = "AbrirCajonToolStripMenuItem"
    Me.AbrirCajonToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
    Me.AbrirCajonToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
    Me.AbrirCajonToolStripMenuItem.Text = "&Abrir cajón"
    '
    'ImprimirTicketToolStripMenuItem
    '
    Me.ImprimirTicketToolStripMenuItem.Image = My.Resources.Resources.print.ToBitmap
    Me.ImprimirTicketToolStripMenuItem.Name = "ImprimirTicketToolStripMenuItem"
    Me.ImprimirTicketToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
    Me.ImprimirTicketToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
    Me.ImprimirTicketToolStripMenuItem.Text = "&Imprimir ticket"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(193, 6)
    '
    'CierreDediaToolStripMenuItem
    '
    Me.CierreDediaToolStripMenuItem.Image = My.Resources.Resources.summary.ToBitmap
    Me.CierreDediaToolStripMenuItem.Name = "CierreDediaToolStripMenuItem"
    Me.CierreDediaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
    Me.CierreDediaToolStripMenuItem.Text = "Cierre de &día"
    '
    'ToolStripMenuItem2
    '
    Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    Me.ToolStripMenuItem2.Size = New System.Drawing.Size(193, 6)
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TPVToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(842, 24)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'TPVToolStripMenuItem
    '
    Me.TPVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.AnularToolStripMenuItem, Me.ToolStripSeparator1, Me.GuardarToolStripMenuItem, Me.AbrirCajonToolStripMenuItem, Me.ImprimirTicketToolStripMenuItem, Me.ToolStripSeparator8, Me.mnupagorapido, Me.PagosToolStripMenuItem, Me.ToolStripSeparator3, Me.CierreDediaToolStripMenuItem})
    Me.TPVToolStripMenuItem.Name = "TPVToolStripMenuItem"
    Me.TPVToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
    Me.TPVToolStripMenuItem.Text = "&TPV"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
    '
    'GuardarToolStripMenuItem
    '
    Me.GuardarToolStripMenuItem.Image = My.Resources.Resources.save16.ToBitmap
    Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
    Me.GuardarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
    Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
    Me.GuardarToolStripMenuItem.Text = "Guardar"
    '
    'ToolStripSeparator8
    '
    Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
    Me.ToolStripSeparator8.Size = New System.Drawing.Size(168, 6)
    '
    'mnupagorapido
    '
    Me.mnupagorapido.Image = My.Resources.Resources.pagos.ToBitmap
    Me.mnupagorapido.Name = "mnupagorapido"
    Me.mnupagorapido.ShortcutKeys = System.Windows.Forms.Keys.F12
    Me.mnupagorapido.Size = New System.Drawing.Size(171, 22)
    Me.mnupagorapido.Text = "Pago &rápido"
    '
    'PagosToolStripMenuItem
    '
    Me.PagosToolStripMenuItem.Image = My.Resources.Resources.pagos.ToBitmap
    Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
    Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
    Me.PagosToolStripMenuItem.Text = "Pag&os"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(168, 6)
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.White
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStriptitulo})
    Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Size = New System.Drawing.Size(842, 25)
    Me.HeaderStrip1.TabIndex = 0
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStriptitulo
    '
    Me.ToolStriptitulo.Name = "ToolStriptitulo"
    Me.ToolStriptitulo.Size = New System.Drawing.Size(41, 22)
    Me.ToolStriptitulo.Text = "TPV"
    '
    'ToolStrip2
    '
    Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(36, 36)
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnbuscar, Me.lblnumero, Me.ToolStripSeparator5, Me.btncancelar, Me.btnanular, Me.ToolStripSeparator6, Me.btnguardar, Me.ComboboxBodega1, Me.btnpagorapido, Me.btnpagos, Me.btnabrircaja, Me.btnimprimirticket, Me.ToolStripSeparator9, Me.btncierredia})
    Me.ToolStrip2.Location = New System.Drawing.Point(0, 25)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(842, 43)
    Me.ToolStrip2.TabIndex = 1
    Me.ToolStrip2.Text = "ToolStrip2"
    '
    'btnbuscar
    '
    Me.btnbuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnbuscar.Image = My.Resources.Resources.find.ToBitmap
    Me.btnbuscar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnbuscar.Name = "btnbuscar"
    Me.btnbuscar.Size = New System.Drawing.Size(40, 40)
    Me.btnbuscar.Text = "Buscar"
    '
    'lblnumero
    '
    Me.lblnumero.Name = "lblnumero"
    Me.lblnumero.Size = New System.Drawing.Size(0, 40)
    '
    'ToolStripSeparator5
    '
    Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
    Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 43)
    '
    'btncancelar
    '
    Me.btncancelar.Image = My.Resources.Resources.undo.ToBitmap
    Me.btncancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(118, 40)
    Me.btncancelar.Text = "Limpiar <F2>"
    '
    'btnanular
    '
    Me.btnanular.Enabled = False
    Me.btnanular.Image = My.Resources.Resources.cancel16.ToBitmap
    Me.btnanular.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnanular.Name = "btnanular"
    Me.btnanular.Size = New System.Drawing.Size(113, 40)
    Me.btnanular.Text = "Anular <F4>"
    '
    'ToolStripSeparator6
    '
    Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
    Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 43)
    '
    'btnguardar
    '
    Me.btnguardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnguardar.Image = My.Resources.Resources.save16.ToBitmap
    Me.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnguardar.Name = "btnguardar"
    Me.btnguardar.Size = New System.Drawing.Size(40, 40)
    Me.btnguardar.Text = "Guardar <F7>"
    '
    'ComboboxBodega1
    '
    Me.ComboboxBodega1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.ComboboxBodega1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboboxBodega1.Name = "ComboboxBodega1"
    Me.ComboboxBodega1.Size = New System.Drawing.Size(121, 43)
    '
    'btnpagorapido
    '
    Me.btnpagorapido.Image = My.Resources.Resources.pagos.ToBitmap
    Me.btnpagorapido.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnpagorapido.Name = "btnpagorapido"
    Me.btnpagorapido.Size = New System.Drawing.Size(148, 40)
    Me.btnpagorapido.Text = "Pago rápido <F12>"
    '
    'btnpagos
    '
    Me.btnpagos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnpagos.Image = My.Resources.Resources.pagos.ToBitmap
    Me.btnpagos.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnpagos.Name = "btnpagos"
    Me.btnpagos.Size = New System.Drawing.Size(40, 40)
    Me.btnpagos.Text = "Pagos"
    '
    'btnabrircaja
    '
    Me.btnabrircaja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnabrircaja.Image = My.Resources.Resources.card_file.ToBitmap
    Me.btnabrircaja.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnabrircaja.Name = "btnabrircaja"
    Me.btnabrircaja.Size = New System.Drawing.Size(40, 40)
    Me.btnabrircaja.Text = "Abrir cajón <F8>"
    '
    'btnimprimirticket
    '
    Me.btnimprimirticket.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnimprimirticket.Image = My.Resources.Resources.print.ToBitmap
    Me.btnimprimirticket.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnimprimirticket.Name = "btnimprimirticket"
    Me.btnimprimirticket.Size = New System.Drawing.Size(40, 40)
    Me.btnimprimirticket.Text = "Imprimir ticket <F9>"
    '
    'ToolStripSeparator9
    '
    Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
    Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 43)
    '
    'btncierredia
    '
    Me.btncierredia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btncierredia.Image = My.Resources.Resources.summary.ToBitmap
    Me.btncierredia.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btncierredia.Name = "btncierredia"
    Me.btncierredia.Size = New System.Drawing.Size(40, 40)
    Me.btncierredia.Text = "Cierre de día"
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.lbl_total, 2, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.DataGridViewDetalles, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.pnlcliente, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.pnltotales, 0, 2)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 68)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.TableLayoutPanel1.RowCount = 3
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(842, 420)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'lbl_total
    '
    Me.lbl_total.AutoSize = True
    Me.lbl_total.BackColor = System.Drawing.Color.Black
    Me.lbl_total.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbl_total.ForeColor = System.Drawing.Color.Lime
    Me.lbl_total.Location = New System.Drawing.Point(631, 333)
    Me.lbl_total.Name = "lbl_total"
    Me.lbl_total.Size = New System.Drawing.Size(203, 83)
    Me.lbl_total.TabIndex = 4
    Me.lbl_total.Text = "$0,00"
    Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label3
    '
    Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(548, 333)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(77, 83)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "Total"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'DataGridViewDetalles
    '
    Me.TableLayoutPanel1.SetColumnSpan(Me.DataGridViewDetalles, 3)
    Me.DataGridViewDetalles.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridViewDetalles.FactorTamanio = New Decimal(New Integer() {1, 0, 0, 0})
    Me.DataGridViewDetalles.Location = New System.Drawing.Point(8, 62)
    Me.DataGridViewDetalles.MovimientoInventario = Nothing
    Me.DataGridViewDetalles.Name = "DataGridViewDetalles"
    Me.DataGridViewDetalles.PardetTipoPago = Nothing
    Me.DataGridViewDetalles.PardetTipoPrecio = Nothing
    Me.DataGridViewDetalles.Size = New System.Drawing.Size(826, 268)
    Me.DataGridViewDetalles.TabIndex = 1
    Me.DataGridViewDetalles.Venta = Nothing
    '
    'pnlcliente
    '
    Me.pnlcliente.Controls.Add(Me.Label14)
    Me.pnlcliente.Controls.Add(Me.ComboBoxTipoPrecio)
    Me.pnlcliente.Controls.Add(Me.Label1)
    Me.pnlcliente.Controls.Add(Me.ComboBoxFormaPago)
    Me.pnlcliente.Controls.Add(Me.CtlBuscaCliente1)
    Me.pnlcliente.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlcliente.Location = New System.Drawing.Point(8, 7)
    Me.pnlcliente.Name = "pnlcliente"
    Me.pnlcliente.Size = New System.Drawing.Size(534, 49)
    Me.pnlcliente.TabIndex = 0
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(271, 30)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(78, 13)
    Me.Label14.TabIndex = 3
    Me.Label14.Text = "Tipo de precio:"
    '
    'ComboBoxTipoPrecio
    '
    Me.ComboBoxTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoPrecio.FormattingEnabled = True
    Me.ComboBoxTipoPrecio.Location = New System.Drawing.Point(365, 26)
    Me.ComboBoxTipoPrecio.Name = "ComboBoxTipoPrecio"
    Me.ComboBoxTipoPrecio.OperadorDatos = Nothing
    Me.ComboBoxTipoPrecio.Parametro = Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipoPrecio.ParametroDet = Nothing
    Me.ComboBoxTipoPrecio.PuedeActualizar = True
    Me.ComboBoxTipoPrecio.PuedeEliminar = True
    Me.ComboBoxTipoPrecio.PuedeModificar = True
    Me.ComboBoxTipoPrecio.PuedeNuevo = True
    Me.ComboBoxTipoPrecio.Size = New System.Drawing.Size(137, 21)
    Me.ComboBoxTipoPrecio.TabIndex = 4
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(-1, 30)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(81, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Forma de pago:"
    '
    'ComboBoxFormaPago
    '
    Me.ComboBoxFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxFormaPago.FormattingEnabled = True
    Me.ComboBoxFormaPago.Location = New System.Drawing.Point(124, 26)
    Me.ComboBoxFormaPago.Name = "ComboBoxFormaPago"
    Me.ComboBoxFormaPago.OperadorDatos = Nothing
    Me.ComboBoxFormaPago.Parametro = Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxFormaPago.ParametroDet = Nothing
    Me.ComboBoxFormaPago.PuedeActualizar = True
    Me.ComboBoxFormaPago.PuedeEliminar = True
    Me.ComboBoxFormaPago.PuedeModificar = True
    Me.ComboBoxFormaPago.PuedeNuevo = True
    Me.ComboBoxFormaPago.Size = New System.Drawing.Size(137, 21)
    Me.ComboBoxFormaPago.TabIndex = 2
    '
    'CtlBuscaCliente1
    '
    Me.CtlBuscaCliente1.Cliente = Nothing
    Me.CtlBuscaCliente1.ClienteText = "Cliente"
    Me.CtlBuscaCliente1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlBuscaCliente1.ItemText = "Cliente"
    Me.CtlBuscaCliente1.Location = New System.Drawing.Point(0, 0)
    Me.CtlBuscaCliente1.Name = "CtlBuscaCliente1"
    Me.CtlBuscaCliente1.Size = New System.Drawing.Size(534, 26)
    Me.CtlBuscaCliente1.TabIndex = 0
    Me.CtlBuscaCliente1.Ubicacion = CtlBuscaCliente.EnumUbicacion.Normal
    '
    'pnltotales
    '
    Me.pnltotales.Controls.Add(Me.txtdsctoglobal)
    'Me.pnltotales.Controls.Add(Me.ComboBoxIVA1)
    Me.pnltotales.Controls.Add(Me.txtiva)
    Me.pnltotales.Controls.Add(Me.Label15)
    Me.pnltotales.Controls.Add(Me.txtbasegravada)
    Me.pnltotales.Controls.Add(Me.Label5)
    Me.pnltotales.Controls.Add(Me.txtsubtotal)
    Me.pnltotales.Controls.Add(Me.txttotaldescto)
    Me.pnltotales.Controls.Add(Me.txtbase0)
    Me.pnltotales.Controls.Add(Me.Label6)
    Me.pnltotales.Controls.Add(Me.Label8)
    Me.pnltotales.Controls.Add(Me.Label7)
    Me.pnltotales.Controls.Add(Me.Label2)
    Me.pnltotales.Controls.Add(Me.Label4)
    Me.pnltotales.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnltotales.Location = New System.Drawing.Point(8, 336)
    Me.pnltotales.Name = "pnltotales"
    Me.pnltotales.Size = New System.Drawing.Size(534, 77)
    Me.pnltotales.TabIndex = 2
    '
    'txtdsctoglobal
    '
    Me.txtdsctoglobal.Location = New System.Drawing.Point(123, 28)
    Me.txtdsctoglobal.Mensaje = ""
    Me.txtdsctoglobal.Name = "txtdsctoglobal"
    Me.txtdsctoglobal.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdsctoglobal.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdsctoglobal.PromptText = ""
    Me.txtdsctoglobal.Size = New System.Drawing.Size(54, 20)
    Me.txtdsctoglobal.TabIndex = 3
    Me.txtdsctoglobal.Text = "0,00"
    Me.txtdsctoglobal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtdsctoglobal.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtdsctoglobal.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtdsctoglobal.Value = 0.0R
    '
    'ComboBoxIVA1
    '
    'Me.ComboBoxIVA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    'Me.ComboBoxIVA1.FormattingEnabled = True
    'Me.ComboBoxIVA1.Location = New System.Drawing.Point(292, 54)
    'Me.ComboBoxIVA1.Name = "ComboBoxIVA1"
    'Me.ComboBoxIVA1.porcentajeIVA = Nothing
    'Me.ComboBoxIVA1.PuedeActualizar = False
    'Me.ComboBoxIVA1.PuedeEliminar = False
    'Me.ComboBoxIVA1.PuedeModificar = False
    'Me.ComboBoxIVA1.PuedeNuevo = False
    'Me.ComboBoxIVA1.Size = New System.Drawing.Size(45, 21)
    'Me.ComboBoxIVA1.TabIndex = 12
    'Me.ComboBoxIVA1.TabStop = False
    '
    'txtiva
    '
    Me.txtiva.Location = New System.Drawing.Point(343, 54)
    Me.txtiva.Mensaje = ""
    Me.txtiva.Name = "txtiva"
    Me.txtiva.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtiva.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtiva.PromptText = ""
    Me.txtiva.ReadOnly = True
    Me.txtiva.Size = New System.Drawing.Size(80, 20)
    Me.txtiva.TabIndex = 13
    Me.txtiva.TabStop = False
    Me.txtiva.Text = "0,00"
    Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtiva.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtiva.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtiva.Value = 0.0R
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(220, 58)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(27, 13)
    Me.Label15.TabIndex = 11
    Me.Label15.Text = "IVA:"
    '
    'txtbasegravada
    '
    Me.txtbasegravada.Location = New System.Drawing.Point(343, 29)
    Me.txtbasegravada.Mensaje = ""
    Me.txtbasegravada.Name = "txtbasegravada"
    Me.txtbasegravada.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtbasegravada.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtbasegravada.PromptText = ""
    Me.txtbasegravada.ReadOnly = True
    Me.txtbasegravada.Size = New System.Drawing.Size(80, 20)
    Me.txtbasegravada.TabIndex = 10
    Me.txtbasegravada.TabStop = False
    Me.txtbasegravada.Text = "0,00"
    Me.txtbasegravada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtbasegravada.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtbasegravada.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtbasegravada.Value = 0.0R
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(220, 31)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(120, 13)
    Me.Label5.TabIndex = 9
    Me.Label5.Text = "Base imponible gravada"
    '
    'txtsubtotal
    '
    Me.txtsubtotal.Location = New System.Drawing.Point(97, 3)
    Me.txtsubtotal.Mensaje = ""
    Me.txtsubtotal.Name = "txtsubtotal"
    Me.txtsubtotal.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtsubtotal.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtsubtotal.PromptText = ""
    Me.txtsubtotal.ReadOnly = True
    Me.txtsubtotal.Size = New System.Drawing.Size(80, 20)
    Me.txtsubtotal.TabIndex = 1
    Me.txtsubtotal.TabStop = False
    Me.txtsubtotal.Text = "0,00"
    Me.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtsubtotal.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtsubtotal.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtsubtotal.Value = 0.0R
    '
    'txttotaldescto
    '
    Me.txttotaldescto.Location = New System.Drawing.Point(97, 54)
    Me.txttotaldescto.Mensaje = ""
    Me.txttotaldescto.Name = "txttotaldescto"
    Me.txttotaldescto.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txttotaldescto.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txttotaldescto.PromptText = ""
    Me.txttotaldescto.ReadOnly = True
    Me.txttotaldescto.Size = New System.Drawing.Size(80, 20)
    Me.txttotaldescto.TabIndex = 6
    Me.txttotaldescto.TabStop = False
    Me.txttotaldescto.Text = "0,00"
    Me.txttotaldescto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txttotaldescto.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txttotaldescto.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txttotaldescto.Value = 0.0R
    '
    'txtbase0
    '
    Me.txtbase0.Location = New System.Drawing.Point(343, 3)
    Me.txtbase0.Mensaje = ""
    Me.txtbase0.Name = "txtbase0"
    Me.txtbase0.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtbase0.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtbase0.PromptText = ""
    Me.txtbase0.ReadOnly = True
    Me.txtbase0.Size = New System.Drawing.Size(80, 20)
    Me.txtbase0.TabIndex = 8
    Me.txtbase0.TabStop = False
    Me.txtbase0.Text = "0,00"
    Me.txtbase0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtbase0.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtbase0.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtbase0.Value = 0.0R
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(183, 30)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(15, 13)
    Me.Label6.TabIndex = 4
    Me.Label6.Text = "%"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(4, 6)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(49, 13)
    Me.Label8.TabIndex = 0
    Me.Label8.Text = "Subtotal:"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(4, 57)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(87, 13)
    Me.Label7.TabIndex = 5
    Me.Label7.Text = "Total descuento:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(4, 30)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(90, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Descuento global"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(220, 6)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(95, 13)
    Me.Label4.TabIndex = 7
    Me.Label4.Text = "Base imponible 0%"
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.TableLayoutPanel1)
    Me.pnlcuerpo.Controls.Add(Me.ToolStrip2)
    Me.pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 24)
    Me.pnlcuerpo.Name = "pnlcuerpo"
    Me.pnlcuerpo.Size = New System.Drawing.Size(842, 488)
    Me.pnlcuerpo.TabIndex = 5
    '
    'BarraEmpresa1
    '
    Me.BarraEmpresa1.Empresa = Nothing
    Me.BarraEmpresa1.EmpresaVisible = True
    Me.BarraEmpresa1.Location = New System.Drawing.Point(0, 24)
    Me.BarraEmpresa1.Name = "BarraEmpresa1"
    'Me.BarraEmpresa1.RegContableVisible = False
    'Me.BarraEmpresa1.RegistroContable = Nothing
    Me.BarraEmpresa1.Sistema = Nothing
    Me.BarraEmpresa1.Size = New System.Drawing.Size(842, 25)
    Me.BarraEmpresa1.Sucursal = Nothing
    Me.BarraEmpresa1.SucursalVisible = True
    Me.BarraEmpresa1.TabIndex = 1
    Me.BarraEmpresa1.Text = "BarraEmpresa1"
    '
    'FrmPuntodeVenta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(842, 512)
    Me.Controls.Add(Me.BarraEmpresa1)
    Me.Controls.Add(Me.pnlcuerpo)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Name = "FrmPuntodeVenta"
    Me.Text = "Punto de venta"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.pnlcliente.ResumeLayout(False)
    Me.pnlcliente.PerformLayout()
    Me.pnltotales.ResumeLayout(False)
    Me.pnltotales.PerformLayout()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.pnlcuerpo.PerformLayout()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AnularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents AbrirCajonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ImprimirTicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents CierreDediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents TPVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents HeaderStrip1 As Infoware.Docking.HeaderStrip
  Friend WithEvents ToolStriptitulo As System.Windows.Forms.ToolStripLabel
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnbuscar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btncancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnanular As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnguardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnabrircaja As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnimprimirticket As System.Windows.Forms.ToolStripButton
  Friend WithEvents btncierredia As System.Windows.Forms.ToolStripButton
  Friend WithEvents ComboboxBodega1 As System.Windows.Forms.ToolStripComboBox
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents lbl_total As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents DataGridViewDetalles As CtlMovimientoInventarioDet1
  Friend WithEvents pnlcliente As System.Windows.Forms.Panel
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxTipoPrecio As ComboBoxParametroDet
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxFormaPago As ComboBoxParametroDet
  Friend WithEvents CtlBuscaCliente1 As CtlBuscaCliente
  Friend WithEvents pnltotales As System.Windows.Forms.Panel
  Friend WithEvents txtdsctoglobal As Infoware.Controles.Base.TextBoxCalculator
  'Friend WithEvents ComboBoxIVA1 As SRI.Controles.ComboBoxIVA
  Friend WithEvents txtiva As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents txtbasegravada As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtbase0 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents pnlcuerpo As System.Windows.Forms.Panel
  Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
  Friend WithEvents btnpagos As System.Windows.Forms.ToolStripButton
  Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txttotaldescto As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtsubtotal As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents lblnumero As System.Windows.Forms.ToolStripLabel
  Friend WithEvents BarraEmpresa1 As BarraEmpresa
  Friend WithEvents mnupagorapido As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents btnpagorapido As System.Windows.Forms.ToolStripButton
End Class
