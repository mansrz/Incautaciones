<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlMovimientoInventario
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlMovimientoInventario))
    Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
    Me.pnlcodigo = New System.Windows.Forms.Panel()
    Me.barracancelar = New System.Windows.Forms.ToolStrip()
    Me.btncancelar = New System.Windows.Forms.ToolStripButton()
    Me.ComboBoxBodega1 = New Incautacion.Modulo.ComboBoxBodega()
    Me.pnlbodegadstno = New System.Windows.Forms.Panel()
    Me.ComboBoxBodega2 = New Incautacion.Modulo.ComboBoxBodega()
    Me.ComboBoxSucursal1 = New Incautacion.Modulo.ComboBoxSucursal()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtnumero = New Infoware.Controles.Base.TextBoxCalculator()
    Me.lbl_tipomov = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dtpFecdesde = New Infoware.Controles.Base.DateTimePickerStd()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.pnlbodega = New System.Windows.Forms.Panel()
    Me.txtobservacion = New Infoware.Controles.Base.TextBoxStd()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.pnlactivo = New System.Windows.Forms.Panel()
    Me.CtlBuscaActivo = New Incautacion.Modulo.CtlBuscaItem()
    Me.pnlclienteproveedor = New System.Windows.Forms.Panel()
    Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
    Me.CtlBuscaCliente1 = New Incautacion.Modulo.CtlBuscaCliente()
    Me.CtlBuscaProveedor1 = New Incautacion.Modulo.CtlBuscaProveedor()
    Me.CtlBuscaContribuyente1 = New Incautacion.Modulo.CtlBuscaContribuyente()
    Me.pnlIncautacion = New System.Windows.Forms.Panel()
    Me.txt_responsable = New Infoware.Controles.Base.TextBoxStd()
    Me.lbl_responable = New System.Windows.Forms.Label()
    Me.txt_codigo = New Infoware.Controles.Base.TextBoxStd()
    Me.lbl_cod = New System.Windows.Forms.Label()
    Me.CtlDireccion1 = New Incautacion.Modulo.CtlDireccion()
    Me.pnlformapago = New System.Windows.Forms.Panel()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.ComboBoxFormaPago = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.pnldatosventa = New System.Windows.Forms.Panel()
    Me.txtfactura = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label23 = New System.Windows.Forms.Label()
    Me.CtlBuscaEmpleado1 = New Incautacion.Modulo.CtlBuscaEmpleado()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.ComboBoxTipoPrecio = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.pnltipocompte = New System.Windows.Forms.Panel()
    Me.Label21 = New System.Windows.Forms.Label()
    Me.pnlnumerocompra = New System.Windows.Forms.Panel()
    Me.msk_fechacaducidad = New Infoware.Controles.Base.MaskedTextBoxStd()
    Me.msk_autorizacion = New Infoware.Controles.Base.MaskedTextBoxStd()
    Me.msk_compranumero = New Infoware.Controles.Base.MaskedTextBoxStd()
    Me.Label22 = New System.Windows.Forms.Label()
    Me.Label19 = New System.Windows.Forms.Label()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.Label20 = New System.Windows.Forms.Label()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.ComboBoxParametroDet1 = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.ComboBoxParametroDet2 = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.pnldetalles = New System.Windows.Forms.Panel()
    Me.DataGridViewDetalles = New Incautacion.Modulo.CtlMovimientoInventarioDet1()
    Me.pnltotalsimple = New System.Windows.Forms.Panel()
    Me.txttotalgeneralsimple = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label17 = New System.Windows.Forms.Label()
    Me.pnltotalcompleto = New System.Windows.Forms.Panel()
    Me.txtsubtotal = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.txttotalgeneral = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtbasegravada = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtdsctoglobal = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtporciva = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtiva = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtbase0 = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.FlowLayoutPanel1.SuspendLayout()
    Me.pnlcodigo.SuspendLayout()
    Me.barracancelar.SuspendLayout()
    Me.pnlbodegadstno.SuspendLayout()
    Me.pnlbodega.SuspendLayout()
    Me.pnlactivo.SuspendLayout()
    Me.pnlclienteproveedor.SuspendLayout()
    Me.FlowLayoutPanel2.SuspendLayout()
    Me.pnlIncautacion.SuspendLayout()
    Me.pnlformapago.SuspendLayout()
    Me.pnldatosventa.SuspendLayout()
    Me.pnltipocompte.SuspendLayout()
    Me.pnlnumerocompra.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.pnldetalles.SuspendLayout()
    Me.pnltotalsimple.SuspendLayout()
    Me.pnltotalcompleto.SuspendLayout()
    Me.SuspendLayout()
    '
    'FlowLayoutPanel1
    '
    Me.FlowLayoutPanel1.Controls.Add(Me.pnlcodigo)
    Me.FlowLayoutPanel1.Controls.Add(Me.pnlbodega)
    Me.FlowLayoutPanel1.Controls.Add(Me.pnlactivo)
    Me.FlowLayoutPanel1.Controls.Add(Me.pnlclienteproveedor)
    Me.FlowLayoutPanel1.Controls.Add(Me.pnldetalles)
    Me.FlowLayoutPanel1.Controls.Add(Me.pnltotalsimple)
    Me.FlowLayoutPanel1.Controls.Add(Me.pnltotalcompleto)
    Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
    Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1117, 600)
    Me.FlowLayoutPanel1.TabIndex = 9
    '
    'pnlcodigo
    '
    Me.pnlcodigo.BackColor = System.Drawing.Color.Transparent
    Me.pnlcodigo.Controls.Add(Me.barracancelar)
    Me.pnlcodigo.Controls.Add(Me.ComboBoxBodega1)
    Me.pnlcodigo.Controls.Add(Me.pnlbodegadstno)
    Me.pnlcodigo.Controls.Add(Me.txtnumero)
    Me.pnlcodigo.Controls.Add(Me.lbl_tipomov)
    Me.pnlcodigo.Controls.Add(Me.Label1)
    Me.pnlcodigo.Controls.Add(Me.dtpFecdesde)
    Me.pnlcodigo.Controls.Add(Me.Label10)
    Me.pnlcodigo.Controls.Add(Me.Label2)
    Me.pnlcodigo.Location = New System.Drawing.Point(3, 3)
    Me.pnlcodigo.Name = "pnlcodigo"
    Me.pnlcodigo.Size = New System.Drawing.Size(1005, 45)
    Me.pnlcodigo.TabIndex = 0
    '
    'barracancelar
    '
    Me.barracancelar.Dock = System.Windows.Forms.DockStyle.None
    Me.barracancelar.Enabled = False
    Me.barracancelar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btncancelar})
    Me.barracancelar.Location = New System.Drawing.Point(0, 1)
    Me.barracancelar.Name = "barracancelar"
    Me.barracancelar.Size = New System.Drawing.Size(35, 25)
    Me.barracancelar.TabIndex = 8
    Me.barracancelar.Text = "ToolStrip1"
    Me.barracancelar.Visible = False
    '
    'btncancelar
    '
    Me.btncancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
    Me.btncancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(23, 22)
    Me.btncancelar.Text = "ToolStripButton1"
    '
    'ComboBoxBodega1
    '
    Me.ComboBoxBodega1.Bodega = Nothing
    Me.ComboBoxBodega1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxBodega1.FormattingEnabled = True
    Me.ComboBoxBodega1.Location = New System.Drawing.Point(752, 1)
    Me.ComboBoxBodega1.Name = "ComboBoxBodega1"
    Me.ComboBoxBodega1.PuedeActualizar = False
    Me.ComboBoxBodega1.PuedeEliminar = False
    Me.ComboBoxBodega1.PuedeModificar = False
    Me.ComboBoxBodega1.PuedeNuevo = False
    Me.ComboBoxBodega1.Size = New System.Drawing.Size(121, 21)
    Me.ComboBoxBodega1.Sucursal = Nothing
    Me.ComboBoxBodega1.TabIndex = 6
    '
    'pnlbodegadstno
    '
    Me.pnlbodegadstno.Controls.Add(Me.ComboBoxBodega2)
    Me.pnlbodegadstno.Controls.Add(Me.ComboBoxSucursal1)
    Me.pnlbodegadstno.Controls.Add(Me.Label5)
    Me.pnlbodegadstno.Location = New System.Drawing.Point(634, 22)
    Me.pnlbodegadstno.Name = "pnlbodegadstno"
    Me.pnlbodegadstno.Size = New System.Drawing.Size(366, 24)
    Me.pnlbodegadstno.TabIndex = 7
    Me.pnlbodegadstno.Visible = False
    '
    'ComboBoxBodega2
    '
    Me.ComboBoxBodega2.Bodega = Nothing
    Me.ComboBoxBodega2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxBodega2.FormattingEnabled = True
    Me.ComboBoxBodega2.Location = New System.Drawing.Point(242, 2)
    Me.ComboBoxBodega2.Name = "ComboBoxBodega2"
    Me.ComboBoxBodega2.PuedeActualizar = False
    Me.ComboBoxBodega2.PuedeEliminar = False
    Me.ComboBoxBodega2.PuedeModificar = False
    Me.ComboBoxBodega2.PuedeNuevo = False
    Me.ComboBoxBodega2.Size = New System.Drawing.Size(121, 21)
    Me.ComboBoxBodega2.Sucursal = Nothing
    Me.ComboBoxBodega2.TabIndex = 5
    '
    'ComboBoxSucursal1
    '
    Me.ComboBoxSucursal1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxSucursal1.Empresa = Nothing
    Me.ComboBoxSucursal1.FormattingEnabled = True
    Me.ComboBoxSucursal1.Location = New System.Drawing.Point(117, 2)
    Me.ComboBoxSucursal1.Name = "ComboBoxSucursal1"
    Me.ComboBoxSucursal1.PuedeActualizar = False
    Me.ComboBoxSucursal1.PuedeEliminar = False
    Me.ComboBoxSucursal1.PuedeModificar = False
    Me.ComboBoxSucursal1.PuedeNuevo = False
    Me.ComboBoxSucursal1.Size = New System.Drawing.Size(122, 21)
    Me.ComboBoxSucursal1.Sucursal = Nothing
    Me.ComboBoxSucursal1.TabIndex = 1
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(-3, 5)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(84, 13)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Bodega destino:"
    '
    'txtnumero
    '
    Me.txtnumero.Location = New System.Drawing.Point(503, 1)
    Me.txtnumero.Mensaje = ""
    Me.txtnumero.Name = "txtnumero"
    Me.txtnumero.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtnumero.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtnumero.PromptText = ""
    Me.txtnumero.Size = New System.Drawing.Size(71, 20)
    Me.txtnumero.TabIndex = 2
    Me.txtnumero.Text = "0"
    Me.txtnumero.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtnumero.Value = 0.0R
    '
    'lbl_tipomov
    '
    Me.lbl_tipomov.AutoSize = True
    Me.lbl_tipomov.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbl_tipomov.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lbl_tipomov.Location = New System.Drawing.Point(47, 15)
    Me.lbl_tipomov.Name = "lbl_tipomov"
    Me.lbl_tipomov.Size = New System.Drawing.Size(185, 25)
    Me.lbl_tipomov.TabIndex = 0
    Me.lbl_tipomov.Text = "Inventario Inicial"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(631, 4)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(47, 13)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Bodega:"
    '
    'dtpFecdesde
    '
    Me.dtpFecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecdesde.Location = New System.Drawing.Point(503, 23)
    Me.dtpFecdesde.Name = "dtpFecdesde"
    Me.dtpFecdesde.Size = New System.Drawing.Size(93, 20)
    Me.dtpFecdesde.TabIndex = 4
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(379, 4)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(47, 13)
    Me.Label10.TabIndex = 1
    Me.Label10.Text = "Número:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(379, 29)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(40, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Fecha:"
    '
    'pnlbodega
    '
    Me.pnlbodega.BackColor = System.Drawing.Color.Transparent
    Me.pnlbodega.Controls.Add(Me.txtobservacion)
    Me.pnlbodega.Controls.Add(Me.Label3)
    Me.pnlbodega.Location = New System.Drawing.Point(3, 54)
    Me.pnlbodega.Name = "pnlbodega"
    Me.pnlbodega.Size = New System.Drawing.Size(1005, 20)
    Me.pnlbodega.TabIndex = 1
    '
    'txtobservacion
    '
    Me.txtobservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtobservacion.Location = New System.Drawing.Point(130, 0)
    Me.txtobservacion.Mensaje = ""
    Me.txtobservacion.Name = "txtobservacion"
    Me.txtobservacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtobservacion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtobservacion.PromptText = ""
    Me.txtobservacion.Size = New System.Drawing.Size(872, 20)
    Me.txtobservacion.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(9, 3)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(81, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Observaciones:"
    '
    'pnlactivo
    '
    Me.pnlactivo.Controls.Add(Me.CtlBuscaActivo)
    Me.pnlactivo.Location = New System.Drawing.Point(3, 80)
    Me.pnlactivo.Name = "pnlactivo"
    Me.pnlactivo.Size = New System.Drawing.Size(1005, 24)
    Me.pnlactivo.TabIndex = 2
    Me.pnlactivo.Visible = False
    '
    'CtlBuscaActivo
    '
    Me.CtlBuscaActivo.Item = Nothing
    Me.CtlBuscaActivo.ItemText = "Activo:"
    Me.CtlBuscaActivo.Location = New System.Drawing.Point(6, 2)
    Me.CtlBuscaActivo.Name = "CtlBuscaActivo"
    Me.CtlBuscaActivo.PardetTipoInventario = Nothing
    Me.CtlBuscaActivo.Size = New System.Drawing.Size(365, 22)
    Me.CtlBuscaActivo.TabIndex = 0
    Me.CtlBuscaActivo.Ubicacion = Incautacion.Modulo.CtlBuscaItem.EnumUbicacion.Normal
    '
    'pnlclienteproveedor
    '
    Me.pnlclienteproveedor.BackColor = System.Drawing.Color.Transparent
    Me.pnlclienteproveedor.Controls.Add(Me.FlowLayoutPanel2)
    Me.pnlclienteproveedor.Location = New System.Drawing.Point(3, 110)
    Me.pnlclienteproveedor.Name = "pnlclienteproveedor"
    Me.pnlclienteproveedor.Size = New System.Drawing.Size(1005, 107)
    Me.pnlclienteproveedor.TabIndex = 3
    Me.pnlclienteproveedor.Text = "Cliente"
    Me.pnlclienteproveedor.Visible = False
    '
    'FlowLayoutPanel2
    '
    Me.FlowLayoutPanel2.Controls.Add(Me.CtlBuscaCliente1)
    Me.FlowLayoutPanel2.Controls.Add(Me.CtlBuscaProveedor1)
    Me.FlowLayoutPanel2.Controls.Add(Me.CtlBuscaContribuyente1)
    Me.FlowLayoutPanel2.Controls.Add(Me.pnlIncautacion)
    Me.FlowLayoutPanel2.Controls.Add(Me.CtlDireccion1)
    Me.FlowLayoutPanel2.Controls.Add(Me.pnlformapago)
    Me.FlowLayoutPanel2.Controls.Add(Me.pnldatosventa)
    Me.FlowLayoutPanel2.Controls.Add(Me.pnltipocompte)
    Me.FlowLayoutPanel2.Controls.Add(Me.pnlnumerocompra)
    Me.FlowLayoutPanel2.Controls.Add(Me.Panel1)
    Me.FlowLayoutPanel2.Controls.Add(Me.Label11)
    Me.FlowLayoutPanel2.Controls.Add(Me.ComboBoxParametroDet2)
    Me.FlowLayoutPanel2.Controls.Add(Me.Panel2)
    Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
    Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
    Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
    Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1005, 107)
    Me.FlowLayoutPanel2.TabIndex = 0
    '
    'CtlBuscaCliente1
    '
    Me.CtlBuscaCliente1.Cliente = Nothing
    Me.CtlBuscaCliente1.ClienteText = "Cliente:"
    Me.CtlBuscaCliente1.ItemText = "Cliente:"
    Me.CtlBuscaCliente1.Location = New System.Drawing.Point(3, 3)
    Me.CtlBuscaCliente1.Name = "CtlBuscaCliente1"
    Me.CtlBuscaCliente1.Size = New System.Drawing.Size(365, 21)
    Me.CtlBuscaCliente1.TabIndex = 0
    Me.CtlBuscaCliente1.Ubicacion = Incautacion.Modulo.CtlBuscaCliente.EnumUbicacion.Normal
    '
    'CtlBuscaProveedor1
    '
    Me.CtlBuscaProveedor1.ItemText = "Proveedor"
    Me.CtlBuscaProveedor1.Location = New System.Drawing.Point(3, 30)
    Me.CtlBuscaProveedor1.Name = "CtlBuscaProveedor1"
    Me.CtlBuscaProveedor1.Proveedor = Nothing
    Me.CtlBuscaProveedor1.ProveedorText = "Proveedor"
    Me.CtlBuscaProveedor1.Size = New System.Drawing.Size(365, 21)
    Me.CtlBuscaProveedor1.TabIndex = 1
    Me.CtlBuscaProveedor1.Ubicacion = Incautacion.Modulo.CtlBuscaProveedor.EnumUbicacion.Normal
    '
    'CtlBuscaContribuyente1
    '
    Me.CtlBuscaContribuyente1.Contribuyente = Nothing
    Me.CtlBuscaContribuyente1.ContribuyenteText = "Contribuyente"
    Me.CtlBuscaContribuyente1.ItemText = "Contribuyente"
    Me.CtlBuscaContribuyente1.Location = New System.Drawing.Point(3, 57)
    Me.CtlBuscaContribuyente1.Name = "CtlBuscaContribuyente1"
    Me.CtlBuscaContribuyente1.Size = New System.Drawing.Size(365, 22)
    Me.CtlBuscaContribuyente1.TabIndex = 11
    Me.CtlBuscaContribuyente1.Ubicacion = Incautacion.Modulo.CtlBuscaContribuyente.EnumUbicacion.Normal
    '
    'pnlIncautacion
    '
    Me.pnlIncautacion.Controls.Add(Me.txt_responsable)
    Me.pnlIncautacion.Controls.Add(Me.lbl_responable)
    Me.pnlIncautacion.Controls.Add(Me.txt_codigo)
    Me.pnlIncautacion.Controls.Add(Me.lbl_cod)
    Me.pnlIncautacion.Location = New System.Drawing.Point(374, 3)
    Me.pnlIncautacion.Name = "pnlIncautacion"
    Me.pnlIncautacion.Size = New System.Drawing.Size(264, 67)
    Me.pnlIncautacion.TabIndex = 16
    Me.pnlIncautacion.Visible = False
    '
    'txt_responsable
    '
    Me.txt_responsable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_responsable.Location = New System.Drawing.Point(114, 30)
    Me.txt_responsable.Mensaje = ""
    Me.txt_responsable.Name = "txt_responsable"
    Me.txt_responsable.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_responsable.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txt_responsable.PromptText = ""
    Me.txt_responsable.Size = New System.Drawing.Size(140, 20)
    Me.txt_responsable.TabIndex = 7
    '
    'lbl_responable
    '
    Me.lbl_responable.AutoSize = True
    Me.lbl_responable.Location = New System.Drawing.Point(3, 33)
    Me.lbl_responable.Name = "lbl_responable"
    Me.lbl_responable.Size = New System.Drawing.Size(72, 13)
    Me.lbl_responable.TabIndex = 6
    Me.lbl_responable.Text = "Responsable:"
    '
    'txt_codigo
    '
    Me.txt_codigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_codigo.Location = New System.Drawing.Point(114, 3)
    Me.txt_codigo.Mensaje = ""
    Me.txt_codigo.Name = "txt_codigo"
    Me.txt_codigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_codigo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txt_codigo.PromptText = ""
    Me.txt_codigo.Size = New System.Drawing.Size(140, 20)
    Me.txt_codigo.TabIndex = 5
    '
    'lbl_cod
    '
    Me.lbl_cod.AutoSize = True
    Me.lbl_cod.Location = New System.Drawing.Point(3, 3)
    Me.lbl_cod.Name = "lbl_cod"
    Me.lbl_cod.Size = New System.Drawing.Size(76, 13)
    Me.lbl_cod.TabIndex = 4
    Me.lbl_cod.Text = "# Incautación:"
    '
    'CtlDireccion1
    '
    Me.CtlDireccion1.Entidad = Nothing
    Me.CtlDireccion1.Location = New System.Drawing.Point(644, 3)
    Me.CtlDireccion1.Name = "CtlDireccion1"
    Me.CtlDireccion1.Size = New System.Drawing.Size(365, 67)
    Me.CtlDireccion1.TabIndex = 2
    Me.CtlDireccion1.TipoDireccion = Incautacion.Reglas.Enumerados.enumTipoDireccion.Trabajo
    '
    'pnlformapago
    '
    Me.pnlformapago.Controls.Add(Me.Label12)
    Me.pnlformapago.Controls.Add(Me.ComboBoxFormaPago)
    Me.pnlformapago.Location = New System.Drawing.Point(644, 76)
    Me.pnlformapago.Name = "pnlformapago"
    Me.pnlformapago.Size = New System.Drawing.Size(248, 22)
    Me.pnlformapago.TabIndex = 10
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(2, 3)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(81, 13)
    Me.Label12.TabIndex = 5
    Me.Label12.Text = "Forma de pago:"
    '
    'ComboBoxFormaPago
    '
    Me.ComboBoxFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxFormaPago.FormattingEnabled = True
    Me.ComboBoxFormaPago.Location = New System.Drawing.Point(124, 0)
    Me.ComboBoxFormaPago.Name = "ComboBoxFormaPago"
    Me.ComboBoxFormaPago.OperadorDatos = Nothing
    Me.ComboBoxFormaPago.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxFormaPago.ParametroDet = Nothing
    Me.ComboBoxFormaPago.PuedeActualizar = True
    Me.ComboBoxFormaPago.PuedeEliminar = True
    Me.ComboBoxFormaPago.PuedeModificar = True
    Me.ComboBoxFormaPago.PuedeNuevo = True
    Me.ComboBoxFormaPago.Size = New System.Drawing.Size(122, 21)
    Me.ComboBoxFormaPago.TabIndex = 6
    '
    'pnldatosventa
    '
    Me.pnldatosventa.Controls.Add(Me.txtfactura)
    Me.pnldatosventa.Controls.Add(Me.Label23)
    Me.pnldatosventa.Controls.Add(Me.CtlBuscaEmpleado1)
    Me.pnldatosventa.Controls.Add(Me.Label14)
    Me.pnldatosventa.Controls.Add(Me.ComboBoxTipoPrecio)
    Me.pnldatosventa.Location = New System.Drawing.Point(1015, 3)
    Me.pnldatosventa.Name = "pnldatosventa"
    Me.pnldatosventa.Size = New System.Drawing.Size(368, 73)
    Me.pnldatosventa.TabIndex = 3
    '
    'txtfactura
    '
    Me.txtfactura.Enabled = False
    Me.txtfactura.Location = New System.Drawing.Point(124, 52)
    Me.txtfactura.Mensaje = ""
    Me.txtfactura.Name = "txtfactura"
    Me.txtfactura.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtfactura.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtfactura.PromptText = ""
    Me.txtfactura.Size = New System.Drawing.Size(122, 20)
    Me.txtfactura.TabIndex = 4
    Me.txtfactura.Text = "0"
    Me.txtfactura.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtfactura.Value = 0.0R
    '
    'Label23
    '
    Me.Label23.AutoSize = True
    Me.Label23.Location = New System.Drawing.Point(-1, 55)
    Me.Label23.Name = "Label23"
    Me.Label23.Size = New System.Drawing.Size(98, 13)
    Me.Label23.TabIndex = 3
    Me.Label23.Text = "Número de factura:"
    '
    'CtlBuscaEmpleado1
    '
    Me.CtlBuscaEmpleado1.Empleado = Nothing
    Me.CtlBuscaEmpleado1.EmpleadoText = "Vendedor:"
    Me.CtlBuscaEmpleado1.ItemText = "Vendedor:"
    Me.CtlBuscaEmpleado1.Location = New System.Drawing.Point(0, 26)
    Me.CtlBuscaEmpleado1.Name = "CtlBuscaEmpleado1"
    Me.CtlBuscaEmpleado1.Size = New System.Drawing.Size(365, 21)
    Me.CtlBuscaEmpleado1.TabIndex = 2
    Me.CtlBuscaEmpleado1.TipoEmpleado = Nothing
    Me.CtlBuscaEmpleado1.Ubicacion = Incautacion.Modulo.CtlBuscaEmpleado.EnumUbicacion.Normal
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(2, 3)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(78, 13)
    Me.Label14.TabIndex = 0
    Me.Label14.Text = "Tipo de precio:"
    '
    'ComboBoxTipoPrecio
    '
    Me.ComboBoxTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoPrecio.FormattingEnabled = True
    Me.ComboBoxTipoPrecio.Location = New System.Drawing.Point(124, 0)
    Me.ComboBoxTipoPrecio.Name = "ComboBoxTipoPrecio"
    Me.ComboBoxTipoPrecio.OperadorDatos = Nothing
    Me.ComboBoxTipoPrecio.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipoPrecio.ParametroDet = Nothing
    Me.ComboBoxTipoPrecio.PuedeActualizar = True
    Me.ComboBoxTipoPrecio.PuedeEliminar = True
    Me.ComboBoxTipoPrecio.PuedeModificar = True
    Me.ComboBoxTipoPrecio.PuedeNuevo = True
    Me.ComboBoxTipoPrecio.Size = New System.Drawing.Size(122, 21)
    Me.ComboBoxTipoPrecio.TabIndex = 1
    '
    'pnltipocompte
    '
    Me.pnltipocompte.Controls.Add(Me.Label21)
    Me.pnltipocompte.Location = New System.Drawing.Point(1389, 3)
    Me.pnltipocompte.Name = "pnltipocompte"
    Me.pnltipocompte.Size = New System.Drawing.Size(368, 23)
    Me.pnltipocompte.TabIndex = 4
    Me.pnltipocompte.Visible = False
    '
    'Label21
    '
    Me.Label21.AutoSize = True
    Me.Label21.Location = New System.Drawing.Point(0, 5)
    Me.Label21.Name = "Label21"
    Me.Label21.Size = New System.Drawing.Size(111, 13)
    Me.Label21.TabIndex = 0
    Me.Label21.Text = "Tipo de comprobante:"
    '
    'pnlnumerocompra
    '
    Me.pnlnumerocompra.Controls.Add(Me.msk_fechacaducidad)
    Me.pnlnumerocompra.Controls.Add(Me.msk_autorizacion)
    Me.pnlnumerocompra.Controls.Add(Me.msk_compranumero)
    Me.pnlnumerocompra.Controls.Add(Me.Label22)
    Me.pnlnumerocompra.Controls.Add(Me.Label19)
    Me.pnlnumerocompra.Controls.Add(Me.Label18)
    Me.pnlnumerocompra.Controls.Add(Me.Label20)
    Me.pnlnumerocompra.Location = New System.Drawing.Point(1763, 3)
    Me.pnlnumerocompra.Name = "pnlnumerocompra"
    Me.pnlnumerocompra.Size = New System.Drawing.Size(271, 97)
    Me.pnlnumerocompra.TabIndex = 5
    '
    'msk_fechacaducidad
    '
    Me.msk_fechacaducidad.Location = New System.Drawing.Point(130, 51)
    Me.msk_fechacaducidad.Mask = "00/0000"
    Me.msk_fechacaducidad.Name = "msk_fechacaducidad"
    Me.msk_fechacaducidad.Size = New System.Drawing.Size(116, 20)
    Me.msk_fechacaducidad.TabIndex = 5
    '
    'msk_autorizacion
    '
    Me.msk_autorizacion.Location = New System.Drawing.Point(130, 26)
    Me.msk_autorizacion.Mask = "0000000000"
    Me.msk_autorizacion.Name = "msk_autorizacion"
    Me.msk_autorizacion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
    Me.msk_autorizacion.Size = New System.Drawing.Size(116, 20)
    Me.msk_autorizacion.TabIndex = 3
    '
    'msk_compranumero
    '
    Me.msk_compranumero.Location = New System.Drawing.Point(130, 1)
    Me.msk_compranumero.Mask = "000-000-0000000"
    Me.msk_compranumero.Name = "msk_compranumero"
    Me.msk_compranumero.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
    Me.msk_compranumero.Size = New System.Drawing.Size(116, 20)
    Me.msk_compranumero.TabIndex = 1
    '
    'Label22
    '
    Me.Label22.AutoSize = True
    Me.Label22.Location = New System.Drawing.Point(3, 54)
    Me.Label22.Name = "Label22"
    Me.Label22.Size = New System.Drawing.Size(93, 13)
    Me.Label22.TabIndex = 4
    Me.Label22.Text = "Fecha caducidad:"
    '
    'Label19
    '
    Me.Label19.AutoSize = True
    Me.Label19.Location = New System.Drawing.Point(3, 29)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(122, 13)
    Me.Label19.TabIndex = 2
    Me.Label19.Text = "Número de autorización:"
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Location = New System.Drawing.Point(3, 4)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(100, 13)
    Me.Label18.TabIndex = 0
    Me.Label18.Text = "Número de compra:"
    '
    'Label20
    '
    Me.Label20.AutoSize = True
    Me.Label20.Location = New System.Drawing.Point(3, 79)
    Me.Label20.Name = "Label20"
    Me.Label20.Size = New System.Drawing.Size(95, 13)
    Me.Label20.TabIndex = 6
    Me.Label20.Text = "Sustento tributario:"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Label4)
    Me.Panel1.Controls.Add(Me.ComboBoxParametroDet1)
    Me.Panel1.Location = New System.Drawing.Point(2040, 3)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(248, 22)
    Me.Panel1.TabIndex = 12
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(2, 3)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(87, 13)
    Me.Label4.TabIndex = 5
    Me.Label4.Text = "Forma dde pago:"
    Me.Label4.Visible = False
    '
    'ComboBoxParametroDet1
    '
    Me.ComboBoxParametroDet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDet1.FormattingEnabled = True
    Me.ComboBoxParametroDet1.Location = New System.Drawing.Point(124, 0)
    Me.ComboBoxParametroDet1.Name = "ComboBoxParametroDet1"
    Me.ComboBoxParametroDet1.OperadorDatos = Nothing
    Me.ComboBoxParametroDet1.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxParametroDet1.ParametroDet = Nothing
    Me.ComboBoxParametroDet1.PuedeActualizar = True
    Me.ComboBoxParametroDet1.PuedeEliminar = True
    Me.ComboBoxParametroDet1.PuedeModificar = True
    Me.ComboBoxParametroDet1.PuedeNuevo = True
    Me.ComboBoxParametroDet1.Size = New System.Drawing.Size(122, 21)
    Me.ComboBoxParametroDet1.TabIndex = 6
    Me.ComboBoxParametroDet1.Visible = False
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(2040, 28)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(81, 13)
    Me.Label11.TabIndex = 13
    Me.Label11.Text = "Forma de pago:"
    Me.Label11.Visible = False
    '
    'ComboBoxParametroDet2
    '
    Me.ComboBoxParametroDet2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDet2.FormattingEnabled = True
    Me.ComboBoxParametroDet2.Location = New System.Drawing.Point(2040, 44)
    Me.ComboBoxParametroDet2.Name = "ComboBoxParametroDet2"
    Me.ComboBoxParametroDet2.OperadorDatos = Nothing
    Me.ComboBoxParametroDet2.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxParametroDet2.ParametroDet = Nothing
    Me.ComboBoxParametroDet2.PuedeActualizar = True
    Me.ComboBoxParametroDet2.PuedeEliminar = True
    Me.ComboBoxParametroDet2.PuedeModificar = True
    Me.ComboBoxParametroDet2.PuedeNuevo = True
    Me.ComboBoxParametroDet2.Size = New System.Drawing.Size(122, 21)
    Me.ComboBoxParametroDet2.TabIndex = 14
    Me.ComboBoxParametroDet2.Visible = False
    '
    'Panel2
    '
    Me.Panel2.Location = New System.Drawing.Point(2040, 71)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(244, 21)
    Me.Panel2.TabIndex = 15
    Me.Panel2.Visible = False
    '
    'pnldetalles
    '
    Me.pnldetalles.BackColor = System.Drawing.Color.Transparent
    Me.pnldetalles.Controls.Add(Me.DataGridViewDetalles)
    Me.pnldetalles.Location = New System.Drawing.Point(3, 223)
    Me.pnldetalles.Name = "pnldetalles"
    Me.pnldetalles.Size = New System.Drawing.Size(1005, 236)
    Me.pnldetalles.TabIndex = 4
    Me.pnldetalles.Text = "Productos y servicios"
    '
    'DataGridViewDetalles
    '
    Me.DataGridViewDetalles.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridViewDetalles.FactorTamanio = New Decimal(New Integer() {1, 0, 0, 0})
    Me.DataGridViewDetalles.Location = New System.Drawing.Point(0, 0)
    Me.DataGridViewDetalles.MovimientoInventario = Nothing
    Me.DataGridViewDetalles.Name = "DataGridViewDetalles"
    Me.DataGridViewDetalles.PardetTipoInventario = Nothing
    Me.DataGridViewDetalles.PardetTipoPago = Nothing
    Me.DataGridViewDetalles.PardetTipoPrecio = Nothing
    Me.DataGridViewDetalles.Size = New System.Drawing.Size(1005, 236)
    Me.DataGridViewDetalles.TabIndex = 0
    Me.DataGridViewDetalles.Venta = Nothing
    Me.DataGridViewDetalles.VerConfidencial = False
    '
    'pnltotalsimple
    '
    Me.pnltotalsimple.Controls.Add(Me.txttotalgeneralsimple)
    Me.pnltotalsimple.Controls.Add(Me.Label17)
    Me.pnltotalsimple.Location = New System.Drawing.Point(3, 465)
    Me.pnltotalsimple.Name = "pnltotalsimple"
    Me.pnltotalsimple.Size = New System.Drawing.Size(1005, 22)
    Me.pnltotalsimple.TabIndex = 5
    '
    'txttotalgeneralsimple
    '
    Me.txttotalgeneralsimple.Location = New System.Drawing.Point(519, 1)
    Me.txttotalgeneralsimple.Mensaje = ""
    Me.txttotalgeneralsimple.Name = "txttotalgeneralsimple"
    Me.txttotalgeneralsimple.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txttotalgeneralsimple.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txttotalgeneralsimple.PromptText = ""
    Me.txttotalgeneralsimple.ReadOnly = True
    Me.txttotalgeneralsimple.Size = New System.Drawing.Size(100, 20)
    Me.txttotalgeneralsimple.TabIndex = 1
    Me.txttotalgeneralsimple.Text = "0.00"
    Me.txttotalgeneralsimple.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txttotalgeneralsimple.Value = 0.0R
    '
    'Label17
    '
    Me.Label17.AutoSize = True
    Me.Label17.Location = New System.Drawing.Point(392, 4)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(72, 13)
    Me.Label17.TabIndex = 0
    Me.Label17.Text = "Total general:"
    '
    'pnltotalcompleto
    '
    Me.pnltotalcompleto.Controls.Add(Me.txtsubtotal)
    Me.pnltotalcompleto.Controls.Add(Me.Label13)
    Me.pnltotalcompleto.Controls.Add(Me.txttotalgeneral)
    Me.pnltotalcompleto.Controls.Add(Me.txtbasegravada)
    Me.pnltotalcompleto.Controls.Add(Me.Label16)
    Me.pnltotalcompleto.Controls.Add(Me.Label7)
    Me.pnltotalcompleto.Controls.Add(Me.txtdsctoglobal)
    Me.pnltotalcompleto.Controls.Add(Me.txtporciva)
    Me.pnltotalcompleto.Controls.Add(Me.txtiva)
    Me.pnltotalcompleto.Controls.Add(Me.txtbase0)
    Me.pnltotalcompleto.Controls.Add(Me.Label9)
    Me.pnltotalcompleto.Controls.Add(Me.Label8)
    Me.pnltotalcompleto.Controls.Add(Me.Label15)
    Me.pnltotalcompleto.Controls.Add(Me.Label6)
    Me.pnltotalcompleto.Location = New System.Drawing.Point(3, 493)
    Me.pnltotalcompleto.Name = "pnltotalcompleto"
    Me.pnltotalcompleto.Size = New System.Drawing.Size(1005, 47)
    Me.pnltotalcompleto.TabIndex = 6
    Me.pnltotalcompleto.Visible = False
    '
    'txtsubtotal
    '
    Me.txtsubtotal.Location = New System.Drawing.Point(108, 26)
    Me.txtsubtotal.Mensaje = ""
    Me.txtsubtotal.Name = "txtsubtotal"
    Me.txtsubtotal.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtsubtotal.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtsubtotal.PromptText = ""
    Me.txtsubtotal.ReadOnly = True
    Me.txtsubtotal.Size = New System.Drawing.Size(100, 20)
    Me.txtsubtotal.TabIndex = 4
    Me.txtsubtotal.Text = "0.00"
    Me.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtsubtotal.Value = 0.0R
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(9, 29)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(49, 13)
    Me.Label13.TabIndex = 3
    Me.Label13.Text = "Subtotal:"
    '
    'txttotalgeneral
    '
    Me.txttotalgeneral.Location = New System.Drawing.Point(568, 26)
    Me.txttotalgeneral.Mensaje = ""
    Me.txttotalgeneral.Name = "txttotalgeneral"
    Me.txttotalgeneral.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txttotalgeneral.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txttotalgeneral.PromptText = ""
    Me.txttotalgeneral.ReadOnly = True
    Me.txttotalgeneral.Size = New System.Drawing.Size(100, 20)
    Me.txttotalgeneral.TabIndex = 13
    Me.txttotalgeneral.Text = "0.00"
    Me.txttotalgeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txttotalgeneral.Value = 0.0R
    '
    'txtbasegravada
    '
    Me.txtbasegravada.Location = New System.Drawing.Point(360, 26)
    Me.txtbasegravada.Mensaje = ""
    Me.txtbasegravada.Name = "txtbasegravada"
    Me.txtbasegravada.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtbasegravada.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtbasegravada.PromptText = ""
    Me.txtbasegravada.ReadOnly = True
    Me.txtbasegravada.Size = New System.Drawing.Size(100, 20)
    Me.txtbasegravada.TabIndex = 8
    Me.txtbasegravada.Text = "0.00"
    Me.txtbasegravada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtbasegravada.Value = 0.0R
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Location = New System.Drawing.Point(485, 29)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(72, 13)
    Me.Label16.TabIndex = 12
    Me.Label16.Text = "Total general:"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(230, 29)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(123, 13)
    Me.Label7.TabIndex = 7
    Me.Label7.Text = "Base imponible gravada:"
    '
    'txtdsctoglobal
    '
    Me.txtdsctoglobal.Location = New System.Drawing.Point(108, 1)
    Me.txtdsctoglobal.Mensaje = ""
    Me.txtdsctoglobal.Name = "txtdsctoglobal"
    Me.txtdsctoglobal.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdsctoglobal.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdsctoglobal.PromptText = ""
    Me.txtdsctoglobal.Size = New System.Drawing.Size(64, 20)
    Me.txtdsctoglobal.TabIndex = 1
    Me.txtdsctoglobal.Text = "0.00"
    Me.txtdsctoglobal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtdsctoglobal.Value = 0.0R
    '
    'txtporciva
    '
    Me.txtporciva.Enabled = False
    Me.txtporciva.Location = New System.Drawing.Point(518, 1)
    Me.txtporciva.Mensaje = ""
    Me.txtporciva.Name = "txtporciva"
    Me.txtporciva.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtporciva.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtporciva.PromptText = ""
    Me.txtporciva.ReadOnly = True
    Me.txtporciva.Size = New System.Drawing.Size(44, 20)
    Me.txtporciva.TabIndex = 10
    Me.txtporciva.Text = "0.00"
    Me.txtporciva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtporciva.Value = 0.0R
    '
    'txtiva
    '
    Me.txtiva.Location = New System.Drawing.Point(568, 1)
    Me.txtiva.Mensaje = ""
    Me.txtiva.Name = "txtiva"
    Me.txtiva.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtiva.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtiva.PromptText = ""
    Me.txtiva.ReadOnly = True
    Me.txtiva.Size = New System.Drawing.Size(100, 20)
    Me.txtiva.TabIndex = 11
    Me.txtiva.Text = "0.00"
    Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtiva.Value = 0.0R
    '
    'txtbase0
    '
    Me.txtbase0.Location = New System.Drawing.Point(360, 1)
    Me.txtbase0.Mensaje = ""
    Me.txtbase0.Name = "txtbase0"
    Me.txtbase0.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtbase0.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtbase0.PromptText = ""
    Me.txtbase0.ReadOnly = True
    Me.txtbase0.Size = New System.Drawing.Size(100, 20)
    Me.txtbase0.TabIndex = 6
    Me.txtbase0.Text = "0.00"
    Me.txtbase0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtbase0.Value = 0.0R
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(178, 4)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(15, 13)
    Me.Label9.TabIndex = 2
    Me.Label9.Text = "%"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(9, 4)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(93, 13)
    Me.Label8.TabIndex = 0
    Me.Label8.Text = "Descuento global:"
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(485, 4)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(27, 13)
    Me.Label15.TabIndex = 9
    Me.Label15.Text = "IVA:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(230, 4)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(98, 13)
    Me.Label6.TabIndex = 5
    Me.Label6.Text = "Base imponible 0%:"
    '
    'CtlMovimientoInventario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.FlowLayoutPanel1)
    Me.Name = "CtlMovimientoInventario"
    Me.Size = New System.Drawing.Size(1117, 600)
    Me.FlowLayoutPanel1.ResumeLayout(False)
    Me.pnlcodigo.ResumeLayout(False)
    Me.pnlcodigo.PerformLayout()
    Me.barracancelar.ResumeLayout(False)
    Me.barracancelar.PerformLayout()
    Me.pnlbodegadstno.ResumeLayout(False)
    Me.pnlbodegadstno.PerformLayout()
    Me.pnlbodega.ResumeLayout(False)
    Me.pnlbodega.PerformLayout()
    Me.pnlactivo.ResumeLayout(False)
    Me.pnlclienteproveedor.ResumeLayout(False)
    Me.FlowLayoutPanel2.ResumeLayout(False)
    Me.FlowLayoutPanel2.PerformLayout()
    Me.pnlIncautacion.ResumeLayout(False)
    Me.pnlIncautacion.PerformLayout()
    Me.pnlformapago.ResumeLayout(False)
    Me.pnlformapago.PerformLayout()
    Me.pnldatosventa.ResumeLayout(False)
    Me.pnldatosventa.PerformLayout()
    Me.pnltipocompte.ResumeLayout(False)
    Me.pnltipocompte.PerformLayout()
    Me.pnlnumerocompra.ResumeLayout(False)
    Me.pnlnumerocompra.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.pnldetalles.ResumeLayout(False)
    Me.pnltotalsimple.ResumeLayout(False)
    Me.pnltotalsimple.PerformLayout()
    Me.pnltotalcompleto.ResumeLayout(False)
    Me.pnltotalcompleto.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents pnlcodigo As System.Windows.Forms.Panel
  Friend WithEvents ComboBoxBodega1 As Incautacion.Modulo.ComboBoxBodega
  Friend WithEvents pnlbodegadstno As System.Windows.Forms.Panel
  Friend WithEvents ComboBoxBodega2 As Incautacion.Modulo.ComboBoxBodega
  Friend WithEvents ComboBoxSucursal1 As Incautacion.Modulo.ComboBoxSucursal
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtnumero As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents lbl_tipomov As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents dtpFecdesde As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents pnlbodega As System.Windows.Forms.Panel
  Friend WithEvents txtobservacion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents pnlactivo As System.Windows.Forms.Panel
  Friend WithEvents CtlBuscaActivo As Incautacion.Modulo.CtlBuscaItem
  Friend WithEvents pnlclienteproveedor As System.Windows.Forms.Panel
  Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents CtlBuscaCliente1 As Incautacion.Modulo.CtlBuscaCliente
  Friend WithEvents CtlBuscaProveedor1 As Incautacion.Modulo.CtlBuscaProveedor
  Friend WithEvents pnldetalles As System.Windows.Forms.Panel
  Friend WithEvents DataGridViewDetalles As Incautacion.Modulo.CtlMovimientoInventarioDet1
  Friend WithEvents pnltotalsimple As System.Windows.Forms.Panel
  Friend WithEvents txttotalgeneralsimple As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents pnltotalcompleto As System.Windows.Forms.Panel
  Friend WithEvents txtsubtotal As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents txttotalgeneral As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtbasegravada As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtdsctoglobal As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtiva As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtbase0 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents barracancelar As System.Windows.Forms.ToolStrip
  Friend WithEvents btncancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtporciva As Infoware.Controles.Base.TextBoxCalculator
    Friend WithEvents CtlBuscaContribuyente1 As Incautacion.Modulo.CtlBuscaContribuyente
    Friend WithEvents pnlIncautacion As System.Windows.Forms.Panel
    Friend WithEvents txt_responsable As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents lbl_responable As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents lbl_cod As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxParametroDet1 As Incautacion.Modulo.ComboBoxParametroDet
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxParametroDet2 As Incautacion.Modulo.ComboBoxParametroDet
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents CtlDireccion1 As Incautacion.Modulo.CtlDireccion
  Friend WithEvents pnlformapago As System.Windows.Forms.Panel
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxFormaPago As Incautacion.Modulo.ComboBoxParametroDet
  Friend WithEvents pnldatosventa As System.Windows.Forms.Panel
  Friend WithEvents txtfactura As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label23 As System.Windows.Forms.Label
  Friend WithEvents CtlBuscaEmpleado1 As Incautacion.Modulo.CtlBuscaEmpleado
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxTipoPrecio As Incautacion.Modulo.ComboBoxParametroDet
  Friend WithEvents pnltipocompte As System.Windows.Forms.Panel
  Friend WithEvents Label21 As System.Windows.Forms.Label
  Friend WithEvents pnlnumerocompra As System.Windows.Forms.Panel
  Friend WithEvents msk_fechacaducidad As Infoware.Controles.Base.MaskedTextBoxStd
  Friend WithEvents msk_autorizacion As Infoware.Controles.Base.MaskedTextBoxStd
  Friend WithEvents msk_compranumero As Infoware.Controles.Base.MaskedTextBoxStd
  Friend WithEvents Label22 As System.Windows.Forms.Label
  Friend WithEvents Label19 As System.Windows.Forms.Label
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents Label20 As System.Windows.Forms.Label

End Class
