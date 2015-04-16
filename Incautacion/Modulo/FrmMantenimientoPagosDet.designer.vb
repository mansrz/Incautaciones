<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoPagosDet
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

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
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.pnlcuentacontable = New System.Windows.Forms.Panel()
    Me.Label17 = New System.Windows.Forms.Label()
    Me.pnlvalor = New System.Windows.Forms.Panel()
    Me.txtobservacion = New Infoware.Controles.Base.TextBoxStd()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtvalor = New Infoware.Controles.Base.TextBoxCalculator()
    Me.pnltarjeta = New System.Windows.Forms.Panel()
    Me.txtvoucher = New Infoware.Controles.Base.TextBoxStd()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.pnlcheque = New System.Windows.Forms.Panel()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.txtnumcheque = New Infoware.Controles.Base.TextBoxCalculator()
    Me.dtfechacheque = New Infoware.Controles.Base.DateTimePickerStd()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.pnlcuentabancaria = New System.Windows.Forms.Panel()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.pnlbanco = New System.Windows.Forms.Panel()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.pnlretencion = New System.Windows.Forms.Panel()
    Me.pnlcompteret = New System.Windows.Forms.Panel()
    Me.msk_autorizacion = New Infoware.Controles.Base.MaskedTextBoxStd()
    Me.Label19 = New System.Windows.Forms.Label()
    Me.msk_compteretnumero = New Infoware.Controles.Base.MaskedTextBoxStd()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtbaseimponible = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtporcret = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.pnlretencioniva = New System.Windows.Forms.Panel()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.rdoivaservicios = New System.Windows.Forms.RadioButton()
    Me.rdoivabienes = New System.Windows.Forms.RadioButton()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.pnlretencionfuente = New System.Windows.Forms.Panel()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.pnlformapago = New System.Windows.Forms.Panel()
    Me.dtfecha = New Infoware.Controles.Base.DateTimePickerStd()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.ComboBoxTarjetaCredito = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.CtlCuentaBancaria1 = New Incautacion.Modulo.CtlCuentaBancaria()
    Me.ComboBoxBanco = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.ComboBoxRetencionIVA = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.ComboBoxConceptosRetencion1 = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.CtlBloqueo1 = New Incautacion.Modulo.CtlBloqueo()
    Me.CtlBuscaEntidad21 = New Incautacion.Modulo.CtlBuscaEntidad2()
    Me.ComboBoxTipoPago = New Incautacion.Modulo.ComboBoxParametroDet()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.pnlcuentacontable.SuspendLayout()
    Me.pnlvalor.SuspendLayout()
    Me.pnltarjeta.SuspendLayout()
    Me.pnlcheque.SuspendLayout()
    Me.pnlcuentabancaria.SuspendLayout()
    Me.pnlbanco.SuspendLayout()
    Me.pnlretencion.SuspendLayout()
    Me.pnlcompteret.SuspendLayout()
    Me.pnlretencioniva.SuspendLayout()
    Me.pnlretencionfuente.SuspendLayout()
    Me.pnlformapago.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.pnlcuentacontable)
    Me.Panel1.Controls.Add(Me.pnlvalor)
    Me.Panel1.Controls.Add(Me.pnltarjeta)
    Me.Panel1.Controls.Add(Me.pnlcheque)
    Me.Panel1.Controls.Add(Me.pnlcuentabancaria)
    Me.Panel1.Controls.Add(Me.pnlbanco)
    Me.Panel1.Controls.Add(Me.pnlretencion)
    Me.Panel1.Controls.Add(Me.pnlretencioniva)
    Me.Panel1.Controls.Add(Me.pnlretencionfuente)
    Me.Panel1.Controls.Add(Me.pnlformapago)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(565, 485)
    Me.Panel1.TabIndex = 0
    '
    'pnlcuentacontable
    '
    Me.pnlcuentacontable.Controls.Add(Me.Label17)
    Me.pnlcuentacontable.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlcuentacontable.Location = New System.Drawing.Point(0, 451)
    Me.pnlcuentacontable.Name = "pnlcuentacontable"
    Me.pnlcuentacontable.Size = New System.Drawing.Size(565, 58)
    Me.pnlcuentacontable.TabIndex = 9
    Me.pnlcuentacontable.Visible = False
    '
    'Label17
    '
    Me.Label17.AutoSize = True
    Me.Label17.Location = New System.Drawing.Point(9, 33)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(107, 13)
    Me.Label17.TabIndex = 1
    Me.Label17.Text = "SubCuenta contable:"
    '
    'pnlvalor
    '
    Me.pnlvalor.Controls.Add(Me.txtobservacion)
    Me.pnlvalor.Controls.Add(Me.Label15)
    Me.pnlvalor.Controls.Add(Me.Label4)
    Me.pnlvalor.Controls.Add(Me.txtvalor)
    Me.pnlvalor.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlvalor.Location = New System.Drawing.Point(0, 402)
    Me.pnlvalor.Name = "pnlvalor"
    Me.pnlvalor.Size = New System.Drawing.Size(565, 49)
    Me.pnlvalor.TabIndex = 8
    '
    'txtobservacion
    '
    Me.txtobservacion.Location = New System.Drawing.Point(136, 26)
    Me.txtobservacion.Mensaje = ""
    Me.txtobservacion.Name = "txtobservacion"
    Me.txtobservacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtobservacion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtobservacion.PromptText = ""
    Me.txtobservacion.Size = New System.Drawing.Size(394, 20)
    Me.txtobservacion.TabIndex = 3
    Me.txtobservacion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(9, 29)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(70, 13)
    Me.Label15.TabIndex = 2
    Me.Label15.Text = "Observación:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(9, 3)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(34, 13)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "Valor:"
    '
    'txtvalor
    '
    Me.txtvalor.Location = New System.Drawing.Point(136, 1)
    Me.txtvalor.Mensaje = ""
    Me.txtvalor.Name = "txtvalor"
    Me.txtvalor.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvalor.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvalor.PromptText = ""
    Me.txtvalor.Size = New System.Drawing.Size(91, 20)
    Me.txtvalor.TabIndex = 1
    Me.txtvalor.Text = "0,00"
    Me.txtvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtvalor.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvalor.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtvalor.Value = 0.0R
    '
    'pnltarjeta
    '
    Me.pnltarjeta.Controls.Add(Me.txtvoucher)
    Me.pnltarjeta.Controls.Add(Me.Label10)
    Me.pnltarjeta.Controls.Add(Me.ComboBoxTarjetaCredito)
    Me.pnltarjeta.Controls.Add(Me.Label12)
    Me.pnltarjeta.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnltarjeta.Location = New System.Drawing.Point(0, 349)
    Me.pnltarjeta.Name = "pnltarjeta"
    Me.pnltarjeta.Size = New System.Drawing.Size(565, 53)
    Me.pnltarjeta.TabIndex = 7
    Me.pnltarjeta.Visible = False
    '
    'txtvoucher
    '
    Me.txtvoucher.Location = New System.Drawing.Point(136, 28)
    Me.txtvoucher.Mensaje = ""
    Me.txtvoucher.Name = "txtvoucher"
    Me.txtvoucher.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvoucher.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvoucher.PromptText = ""
    Me.txtvoucher.Size = New System.Drawing.Size(100, 20)
    Me.txtvoucher.TabIndex = 3
    Me.txtvoucher.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(9, 30)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(50, 13)
    Me.Label10.TabIndex = 2
    Me.Label10.Text = "Voucher:"
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(9, 3)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(93, 13)
    Me.Label12.TabIndex = 0
    Me.Label12.Text = "Tarjeta de crédito:"
    '
    'pnlcheque
    '
    Me.pnlcheque.Controls.Add(Me.Label9)
    Me.pnlcheque.Controls.Add(Me.txtnumcheque)
    Me.pnlcheque.Controls.Add(Me.dtfechacheque)
    Me.pnlcheque.Controls.Add(Me.Label7)
    Me.pnlcheque.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlcheque.Location = New System.Drawing.Point(0, 299)
    Me.pnlcheque.Name = "pnlcheque"
    Me.pnlcheque.Size = New System.Drawing.Size(565, 50)
    Me.pnlcheque.TabIndex = 6
    Me.pnlcheque.Visible = False
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(9, 4)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(86, 13)
    Me.Label9.TabIndex = 0
    Me.Label9.Text = "Número cheque:"
    '
    'txtnumcheque
    '
    Me.txtnumcheque.Location = New System.Drawing.Point(136, 2)
    Me.txtnumcheque.Mensaje = ""
    Me.txtnumcheque.Name = "txtnumcheque"
    Me.txtnumcheque.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtnumcheque.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtnumcheque.PromptText = ""
    Me.txtnumcheque.Size = New System.Drawing.Size(91, 20)
    Me.txtnumcheque.TabIndex = 1
    Me.txtnumcheque.Text = "0"
    Me.txtnumcheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtnumcheque.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtnumcheque.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtnumcheque.Value = 0.0R
    '
    'dtfechacheque
    '
    Me.dtfechacheque.Location = New System.Drawing.Point(136, 27)
    Me.dtfechacheque.Name = "dtfechacheque"
    Me.dtfechacheque.Size = New System.Drawing.Size(215, 20)
    Me.dtfechacheque.TabIndex = 3
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(9, 30)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(79, 13)
    Me.Label7.TabIndex = 2
    Me.Label7.Text = "Fecha cheque:"
    '
    'pnlcuentabancaria
    '
    Me.pnlcuentabancaria.Controls.Add(Me.Label16)
    Me.pnlcuentabancaria.Controls.Add(Me.CtlCuentaBancaria1)
    Me.pnlcuentabancaria.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlcuentabancaria.Location = New System.Drawing.Point(0, 245)
    Me.pnlcuentabancaria.Name = "pnlcuentabancaria"
    Me.pnlcuentabancaria.Size = New System.Drawing.Size(565, 54)
    Me.pnlcuentabancaria.TabIndex = 5
    Me.pnlcuentabancaria.Visible = False
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Location = New System.Drawing.Point(9, 6)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(88, 13)
    Me.Label16.TabIndex = 0
    Me.Label16.Text = "Cuenta bancaria:"
    '
    'pnlbanco
    '
    Me.pnlbanco.Controls.Add(Me.Label6)
    Me.pnlbanco.Controls.Add(Me.ComboBoxBanco)
    Me.pnlbanco.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlbanco.Location = New System.Drawing.Point(0, 217)
    Me.pnlbanco.Name = "pnlbanco"
    Me.pnlbanco.Size = New System.Drawing.Size(565, 28)
    Me.pnlbanco.TabIndex = 4
    Me.pnlbanco.Visible = False
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(9, 5)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(41, 13)
    Me.Label6.TabIndex = 0
    Me.Label6.Text = "Banco:"
    '
    'pnlretencion
    '
    Me.pnlretencion.Controls.Add(Me.pnlcompteret)
    Me.pnlretencion.Controls.Add(Me.Label1)
    Me.pnlretencion.Controls.Add(Me.txtbaseimponible)
    Me.pnlretencion.Controls.Add(Me.txtporcret)
    Me.pnlretencion.Controls.Add(Me.Label3)
    Me.pnlretencion.Controls.Add(Me.Label2)
    Me.pnlretencion.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlretencion.Location = New System.Drawing.Point(0, 165)
    Me.pnlretencion.Name = "pnlretencion"
    Me.pnlretencion.Size = New System.Drawing.Size(565, 52)
    Me.pnlretencion.TabIndex = 3
    Me.pnlretencion.Visible = False
    '
    'pnlcompteret
    '
    Me.pnlcompteret.Controls.Add(Me.msk_autorizacion)
    Me.pnlcompteret.Controls.Add(Me.Label19)
    Me.pnlcompteret.Controls.Add(Me.msk_compteretnumero)
    Me.pnlcompteret.Controls.Add(Me.Label18)
    Me.pnlcompteret.Location = New System.Drawing.Point(254, 0)
    Me.pnlcompteret.Name = "pnlcompteret"
    Me.pnlcompteret.Size = New System.Drawing.Size(311, 52)
    Me.pnlcompteret.TabIndex = 5
    Me.pnlcompteret.Visible = False
    '
    'msk_autorizacion
    '
    Me.msk_autorizacion.Location = New System.Drawing.Point(132, 28)
    Me.msk_autorizacion.Mask = "0000000000"
    Me.msk_autorizacion.Name = "msk_autorizacion"
    Me.msk_autorizacion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
    Me.msk_autorizacion.Size = New System.Drawing.Size(137, 20)
    Me.msk_autorizacion.TabIndex = 3
    '
    'Label19
    '
    Me.Label19.AutoSize = True
    Me.Label19.Location = New System.Drawing.Point(3, 30)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(122, 13)
    Me.Label19.TabIndex = 2
    Me.Label19.Text = "Número de autorización:"
    '
    'msk_compteretnumero
    '
    Me.msk_compteretnumero.Location = New System.Drawing.Point(132, 3)
    Me.msk_compteretnumero.Mask = "000-000-0000000"
    Me.msk_compteretnumero.Name = "msk_compteretnumero"
    Me.msk_compteretnumero.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
    Me.msk_compteretnumero.Size = New System.Drawing.Size(137, 20)
    Me.msk_compteretnumero.TabIndex = 1
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Location = New System.Drawing.Point(3, 5)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(120, 13)
    Me.Label18.TabIndex = 0
    Me.Label18.Text = "Comprobante retención:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(9, 3)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(81, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Base imponible:"
    '
    'txtbaseimponible
    '
    Me.txtbaseimponible.Location = New System.Drawing.Point(136, 3)
    Me.txtbaseimponible.Mensaje = ""
    Me.txtbaseimponible.Name = "txtbaseimponible"
    Me.txtbaseimponible.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtbaseimponible.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtbaseimponible.PromptText = ""
    Me.txtbaseimponible.Size = New System.Drawing.Size(91, 20)
    Me.txtbaseimponible.TabIndex = 1
    Me.txtbaseimponible.Text = "0,00"
    Me.txtbaseimponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtbaseimponible.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtbaseimponible.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtbaseimponible.Value = 0.0R
    '
    'txtporcret
    '
    Me.txtporcret.Location = New System.Drawing.Point(136, 28)
    Me.txtporcret.Mensaje = ""
    Me.txtporcret.Name = "txtporcret"
    Me.txtporcret.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtporcret.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtporcret.PromptText = ""
    Me.txtporcret.Size = New System.Drawing.Size(91, 20)
    Me.txtporcret.TabIndex = 3
    Me.txtporcret.Text = "0,00"
    Me.txtporcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtporcret.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtporcret.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtporcret.Value = 0.0R
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(233, 33)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(15, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "%"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(9, 30)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(80, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "% de retención:"
    '
    'pnlretencioniva
    '
    Me.pnlretencioniva.Controls.Add(Me.ComboBoxRetencionIVA)
    Me.pnlretencioniva.Controls.Add(Me.Label14)
    Me.pnlretencioniva.Controls.Add(Me.rdoivaservicios)
    Me.pnlretencioniva.Controls.Add(Me.rdoivabienes)
    Me.pnlretencioniva.Controls.Add(Me.Label13)
    Me.pnlretencioniva.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlretencioniva.Location = New System.Drawing.Point(0, 117)
    Me.pnlretencioniva.Name = "pnlretencioniva"
    Me.pnlretencioniva.Size = New System.Drawing.Size(565, 48)
    Me.pnlretencioniva.TabIndex = 2
    Me.pnlretencioniva.Visible = False
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(9, 25)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(80, 13)
    Me.Label14.TabIndex = 3
    Me.Label14.Text = "% de retención:"
    '
    'rdoivaservicios
    '
    Me.rdoivaservicios.AutoSize = True
    Me.rdoivaservicios.Location = New System.Drawing.Point(236, 3)
    Me.rdoivaservicios.Name = "rdoivaservicios"
    Me.rdoivaservicios.Size = New System.Drawing.Size(88, 17)
    Me.rdoivaservicios.TabIndex = 2
    Me.rdoivaservicios.Text = "IVA Servicios"
    Me.rdoivaservicios.UseVisualStyleBackColor = True
    '
    'rdoivabienes
    '
    Me.rdoivabienes.AutoSize = True
    Me.rdoivabienes.Checked = True
    Me.rdoivabienes.Location = New System.Drawing.Point(136, 3)
    Me.rdoivabienes.Name = "rdoivabienes"
    Me.rdoivabienes.Size = New System.Drawing.Size(77, 17)
    Me.rdoivabienes.TabIndex = 1
    Me.rdoivabienes.TabStop = True
    Me.rdoivabienes.Text = "IVA Bienes"
    Me.rdoivabienes.UseVisualStyleBackColor = True
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(9, 4)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(113, 13)
    Me.Label13.TabIndex = 0
    Me.Label13.Text = "Tipo de retención IVA:"
    '
    'pnlretencionfuente
    '
    Me.pnlretencionfuente.Controls.Add(Me.ComboBoxConceptosRetencion1)
    Me.pnlretencionfuente.Controls.Add(Me.Label11)
    Me.pnlretencionfuente.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlretencionfuente.Location = New System.Drawing.Point(0, 90)
    Me.pnlretencionfuente.Name = "pnlretencionfuente"
    Me.pnlretencionfuente.Size = New System.Drawing.Size(565, 27)
    Me.pnlretencionfuente.TabIndex = 1
    Me.pnlretencionfuente.Visible = False
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(9, 6)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(103, 13)
    Me.Label11.TabIndex = 0
    Me.Label11.Text = "Concepto retención:"
    '
    'pnlformapago
    '
    Me.pnlformapago.Controls.Add(Me.CtlBloqueo1)
    Me.pnlformapago.Controls.Add(Me.CtlBuscaEntidad21)
    Me.pnlformapago.Controls.Add(Me.dtfecha)
    Me.pnlformapago.Controls.Add(Me.ComboBoxTipoPago)
    Me.pnlformapago.Controls.Add(Me.Label8)
    Me.pnlformapago.Controls.Add(Me.Label5)
    Me.pnlformapago.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlformapago.Location = New System.Drawing.Point(0, 0)
    Me.pnlformapago.Name = "pnlformapago"
    Me.pnlformapago.Size = New System.Drawing.Size(565, 90)
    Me.pnlformapago.TabIndex = 0
    '
    'dtfecha
    '
    Me.dtfecha.Location = New System.Drawing.Point(136, 13)
    Me.dtfecha.Name = "dtfecha"
    Me.dtfecha.Size = New System.Drawing.Size(215, 20)
    Me.dtfecha.TabIndex = 1
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(9, 16)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(40, 13)
    Me.Label8.TabIndex = 0
    Me.Label8.Text = "Fecha:"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(9, 38)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(81, 13)
    Me.Label5.TabIndex = 2
    Me.Label5.Text = "Forma de pago:"
    '
    'ComboBoxTarjetaCredito
    '
    Me.ComboBoxTarjetaCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTarjetaCredito.Location = New System.Drawing.Point(136, 3)
    Me.ComboBoxTarjetaCredito.Name = "ComboBoxTarjetaCredito"
    Me.ComboBoxTarjetaCredito.OperadorDatos = Nothing
    Me.ComboBoxTarjetaCredito.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTarjetaCredito.ParametroDet = Nothing
    Me.ComboBoxTarjetaCredito.PuedeActualizar = True
    Me.ComboBoxTarjetaCredito.PuedeEliminar = True
    Me.ComboBoxTarjetaCredito.PuedeModificar = True
    Me.ComboBoxTarjetaCredito.PuedeNuevo = True
    Me.ComboBoxTarjetaCredito.Size = New System.Drawing.Size(215, 21)
    Me.ComboBoxTarjetaCredito.TabIndex = 1
    '
    'CtlCuentaBancaria1
    '
    Me.CtlCuentaBancaria1.CuentaBancaria = Nothing
    Me.CtlCuentaBancaria1.Location = New System.Drawing.Point(136, 1)
    Me.CtlCuentaBancaria1.Name = "CtlCuentaBancaria1"
    Me.CtlCuentaBancaria1.Size = New System.Drawing.Size(314, 54)
    Me.CtlCuentaBancaria1.TabIndex = 0
    '
    'ComboBoxBanco
    '
    Me.ComboBoxBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxBanco.Location = New System.Drawing.Point(136, 3)
    Me.ComboBoxBanco.Name = "ComboBoxBanco"
    Me.ComboBoxBanco.OperadorDatos = Nothing
    Me.ComboBoxBanco.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxBanco.ParametroDet = Nothing
    Me.ComboBoxBanco.PuedeActualizar = True
    Me.ComboBoxBanco.PuedeEliminar = True
    Me.ComboBoxBanco.PuedeModificar = True
    Me.ComboBoxBanco.PuedeNuevo = True
    Me.ComboBoxBanco.Size = New System.Drawing.Size(215, 21)
    Me.ComboBoxBanco.TabIndex = 1
    '
    'ComboBoxRetencionIVA
    '
    Me.ComboBoxRetencionIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxRetencionIVA.FormattingEnabled = True
    Me.ComboBoxRetencionIVA.Location = New System.Drawing.Point(136, 22)
    Me.ComboBoxRetencionIVA.Name = "ComboBoxRetencionIVA"
    Me.ComboBoxRetencionIVA.OperadorDatos = Nothing
    Me.ComboBoxRetencionIVA.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxRetencionIVA.ParametroDet = Nothing
    Me.ComboBoxRetencionIVA.PuedeActualizar = True
    Me.ComboBoxRetencionIVA.PuedeEliminar = True
    Me.ComboBoxRetencionIVA.PuedeModificar = True
    Me.ComboBoxRetencionIVA.PuedeNuevo = True
    Me.ComboBoxRetencionIVA.Size = New System.Drawing.Size(215, 21)
    Me.ComboBoxRetencionIVA.TabIndex = 4
    '
    'ComboBoxConceptosRetencion1
    '
    Me.ComboBoxConceptosRetencion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxConceptosRetencion1.FormattingEnabled = True
    Me.ComboBoxConceptosRetencion1.Location = New System.Drawing.Point(136, 3)
    Me.ComboBoxConceptosRetencion1.Name = "ComboBoxConceptosRetencion1"
    Me.ComboBoxConceptosRetencion1.OperadorDatos = Nothing
    Me.ComboBoxConceptosRetencion1.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxConceptosRetencion1.ParametroDet = Nothing
    Me.ComboBoxConceptosRetencion1.PuedeActualizar = True
    Me.ComboBoxConceptosRetencion1.PuedeEliminar = True
    Me.ComboBoxConceptosRetencion1.PuedeModificar = True
    Me.ComboBoxConceptosRetencion1.PuedeNuevo = True
    Me.ComboBoxConceptosRetencion1.Size = New System.Drawing.Size(417, 21)
    Me.ComboBoxConceptosRetencion1.TabIndex = 1
    '
    'CtlBloqueo1
    '
    Me.CtlBloqueo1.Location = New System.Drawing.Point(503, 3)
    Me.CtlBloqueo1.MaximumSize = New System.Drawing.Size(50, 50)
    Me.CtlBloqueo1.MinimumSize = New System.Drawing.Size(50, 50)
    Me.CtlBloqueo1.Name = "CtlBloqueo1"
    Me.CtlBloqueo1.Restriccion = Nothing
    Me.CtlBloqueo1.Size = New System.Drawing.Size(50, 50)
    Me.CtlBloqueo1.TabIndex = 5
    Me.CtlBloqueo1.TabStop = False
    '
    'CtlBuscaEntidad21
    '
    Me.CtlBuscaEntidad21.Enabled = False
    Me.CtlBuscaEntidad21.Entidad = Nothing
    Me.CtlBuscaEntidad21.EntidadJuridica = Nothing
    Me.CtlBuscaEntidad21.EntidadNatural = Nothing
    Me.CtlBuscaEntidad21.EntidadText = "Persona"
    Me.CtlBuscaEntidad21.Location = New System.Drawing.Point(12, 64)
    Me.CtlBuscaEntidad21.Name = "CtlBuscaEntidad21"
    Me.CtlBuscaEntidad21.OperadorDatos = Nothing
    Me.CtlBuscaEntidad21.Size = New System.Drawing.Size(541, 20)
    Me.CtlBuscaEntidad21.TabIndex = 4
    Me.CtlBuscaEntidad21.TipoEntidad = Incautacion.Modulo.CtlBuscaEntidad2.EnumTipoEntidad.Persona
    '
    'ComboBoxTipoPago
    '
    Me.ComboBoxTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoPago.Location = New System.Drawing.Point(136, 38)
    Me.ComboBoxTipoPago.Name = "ComboBoxTipoPago"
    Me.ComboBoxTipoPago.OperadorDatos = Nothing
    Me.ComboBoxTipoPago.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipoPago.ParametroDet = Nothing
    Me.ComboBoxTipoPago.PuedeActualizar = True
    Me.ComboBoxTipoPago.PuedeEliminar = True
    Me.ComboBoxTipoPago.PuedeModificar = True
    Me.ComboBoxTipoPago.PuedeNuevo = True
    Me.ComboBoxTipoPago.Size = New System.Drawing.Size(215, 21)
    Me.ComboBoxTipoPago.TabIndex = 3
    '
    'FrmMantenimientoPagosDet
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(565, 534)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoPagosDet"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.pnlcuentacontable.ResumeLayout(False)
    Me.pnlcuentacontable.PerformLayout()
    Me.pnlvalor.ResumeLayout(False)
    Me.pnlvalor.PerformLayout()
    Me.pnltarjeta.ResumeLayout(False)
    Me.pnltarjeta.PerformLayout()
    Me.pnlcheque.ResumeLayout(False)
    Me.pnlcheque.PerformLayout()
    Me.pnlcuentabancaria.ResumeLayout(False)
    Me.pnlcuentabancaria.PerformLayout()
    Me.pnlbanco.ResumeLayout(False)
    Me.pnlbanco.PerformLayout()
    Me.pnlretencion.ResumeLayout(False)
    Me.pnlretencion.PerformLayout()
    Me.pnlcompteret.ResumeLayout(False)
    Me.pnlcompteret.PerformLayout()
    Me.pnlretencioniva.ResumeLayout(False)
    Me.pnlretencioniva.PerformLayout()
    Me.pnlretencionfuente.ResumeLayout(False)
    Me.pnlretencionfuente.PerformLayout()
    Me.pnlformapago.ResumeLayout(False)
    Me.pnlformapago.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents pnlformapago As System.Windows.Forms.Panel
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents pnlvalor As System.Windows.Forms.Panel
  Friend WithEvents pnlretencion As System.Windows.Forms.Panel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtporcret As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtvalor As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents ComboBoxTipoPago As ComboBoxParametroDet
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtbaseimponible As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents pnlcheque As System.Windows.Forms.Panel
  Friend WithEvents dtfechacheque As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents ComboBoxBanco As ComboBoxParametroDet
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents dtfecha As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents txtnumcheque As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents pnltarjeta As System.Windows.Forms.Panel
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxTarjetaCredito As ComboBoxParametroDet
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents txtvoucher As Infoware.Controles.Base.TextBoxStd
  'Friend WithEvents ComboBoxConceptosRetencion1 As WWTS.SRI.Controles.ComboBoxConceptosRetencion
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents pnlretencionfuente As System.Windows.Forms.Panel
  Friend WithEvents pnlretencioniva As System.Windows.Forms.Panel
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents rdoivaservicios As System.Windows.Forms.RadioButton
  Friend WithEvents rdoivabienes As System.Windows.Forms.RadioButton
  Friend WithEvents Label13 As System.Windows.Forms.Label
  'Friend WithEvents ComboBoxRetencionIVABienes As WWTS.SRI.Controles.ComboBoxRetencionIVABienes
  Friend WithEvents pnlcuentabancaria As System.Windows.Forms.Panel
  Friend WithEvents CtlCuentaBancaria1 As CtlCuentaBancaria
  Friend WithEvents pnlbanco As System.Windows.Forms.Panel
  Friend WithEvents txtobservacion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents pnlcompteret As System.Windows.Forms.Panel
  Friend WithEvents msk_compteretnumero As Infoware.Controles.Base.MaskedTextBoxStd
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents msk_autorizacion As Infoware.Controles.Base.MaskedTextBoxStd
  Friend WithEvents Label19 As System.Windows.Forms.Label
  'Friend WithEvents ComboBoxRetencionIVAServ As WWTS.SRI.Controles.ComboBoxRetencionIVAServ
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents pnlcuentacontable As System.Windows.Forms.Panel
  'Friend WithEvents CtlBuscaCtaContable1 As CtlBuscaCtaContable
  'Friend WithEvents ComboboxSubCuentaContable1 As ComboBoxParametroDet
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxConceptosRetencion1 As Incautacion.Modulo.ComboBoxParametroDet
  Friend WithEvents ComboBoxRetencionIVA As Incautacion.Modulo.ComboBoxParametroDet
  Friend WithEvents CtlBuscaEntidad21 As Incautacion.Modulo.CtlBuscaEntidad2
  Friend WithEvents CtlBloqueo1 As Incautacion.Modulo.CtlBloqueo

End Class
