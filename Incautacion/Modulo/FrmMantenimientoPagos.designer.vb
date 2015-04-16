<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoPagos
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoPagos))
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.lbl_pagado = New System.Windows.Forms.Label()
    Me.lbl_pendiente = New System.Windows.Forms.Label()
    Me.CtlPagosDet1 = New Incautacion.Modulo.CtlPagosDet()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
    Me.btnvuelto = New System.Windows.Forms.ToolStripButton()
    Me.btnguardar = New System.Windows.Forms.ToolStripButton()
    Me.btnira = New System.Windows.Forms.ToolStripDropDownButton()
    Me.btnnuevo = New System.Windows.Forms.ToolStripButton()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.VueltoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.GuardarYCerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.CtlPagosDet1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip2.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.02838!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.58156!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.39716!))
    Me.TableLayoutPanel1.Controls.Add(Me.lbl_pagado, 2, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.lbl_pendiente, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.CtlPagosDet1, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 2)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 55)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.TableLayoutPanel1.RowCount = 4
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.09244!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.30252!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.69036!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(715, 386)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'lbl_pagado
    '
    Me.lbl_pagado.AutoSize = True
    Me.lbl_pagado.BackColor = System.Drawing.Color.Black
    Me.lbl_pagado.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lbl_pagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbl_pagado.ForeColor = System.Drawing.Color.Lime
    Me.lbl_pagado.Location = New System.Drawing.Point(399, 316)
    Me.lbl_pagado.Name = "lbl_pagado"
    Me.lbl_pagado.Size = New System.Drawing.Size(308, 45)
    Me.lbl_pagado.TabIndex = 4
    Me.lbl_pagado.Text = "$0,00"
    Me.lbl_pagado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lbl_pendiente
    '
    Me.lbl_pendiente.AutoSize = True
    Me.lbl_pendiente.BackColor = System.Drawing.Color.Black
    Me.TableLayoutPanel1.SetColumnSpan(Me.lbl_pendiente, 2)
    Me.lbl_pendiente.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lbl_pendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbl_pendiente.ForeColor = System.Drawing.Color.Lime
    Me.lbl_pendiente.Location = New System.Drawing.Point(8, 4)
    Me.lbl_pendiente.Name = "lbl_pendiente"
    Me.lbl_pendiente.Size = New System.Drawing.Size(385, 111)
    Me.lbl_pendiente.TabIndex = 0
    Me.lbl_pendiente.Text = "$0,00"
    Me.lbl_pendiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'CtlPagosDet1
    '
    Me.CtlPagosDet1.AllowUserToAddRows = False
    Me.CtlPagosDet1.AllowUserToDeleteRows = False
    Me.CtlPagosDet1.AutoGenerateColumns = False
    Me.CtlPagosDet1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.TableLayoutPanel1.SetColumnSpan(Me.CtlPagosDet1, 3)
    Me.CtlPagosDet1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlPagosDet1.Entidad = Nothing
    Me.CtlPagosDet1.FactorTamanio = New Decimal(New Integer() {1, 0, 0, 0})
    Me.CtlPagosDet1.Location = New System.Drawing.Point(8, 118)
    Me.CtlPagosDet1.MovimientoInventario = Nothing
    Me.CtlPagosDet1.Name = "CtlPagosDet1"
    Me.CtlPagosDet1.ReadOnly = True
    Me.CtlPagosDet1.RowTemplate.Height = 25
    Me.CtlPagosDet1.Size = New System.Drawing.Size(699, 195)
    Me.CtlPagosDet1.Sucursal = Nothing
    Me.CtlPagosDet1.TabIndex = 2
    Me.CtlPagosDet1.TipoCuenta = Incautacion.Reglas.Enumerados.enumTipoCuenta.cxc
    '
    'Label1
    '
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(128, 316)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(265, 45)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Saldo a conciliar:"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'ToolStrip2
    '
    Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnuevo, Me.btnvuelto, Me.btnguardar, Me.btnira})
    Me.ToolStrip2.Location = New System.Drawing.Point(0, 24)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(715, 31)
    Me.ToolStrip2.TabIndex = 6
    Me.ToolStrip2.Text = "ToolStrip2"
    '
    'btnvuelto
    '
    Me.btnvuelto.Image = CType(resources.GetObject("btnvuelto.Image"), System.Drawing.Image)
    Me.btnvuelto.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnvuelto.Name = "btnvuelto"
    Me.btnvuelto.Size = New System.Drawing.Size(100, 28)
    Me.btnvuelto.Text = "Vuelto <F2>"
    '
    'btnguardar
    '
    Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
    Me.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnguardar.Name = "btnguardar"
    Me.btnguardar.Size = New System.Drawing.Size(150, 28)
    Me.btnguardar.Text = "Guardar y cerrar <F5>"
    '
    'btnira
    '
    Me.btnira.Image = CType(resources.GetObject("btnira.Image"), System.Drawing.Image)
    Me.btnira.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnira.Name = "btnira"
    Me.btnira.Size = New System.Drawing.Size(60, 28)
    Me.btnira.Text = "ir a"
    '
    'btnnuevo
    '
    Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
    Me.btnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnnuevo.Name = "btnnuevo"
    Me.btnnuevo.Size = New System.Drawing.Size(107, 28)
    Me.btnnuevo.Text = "Agregar pago"
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagosToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(715, 24)
    Me.MenuStrip1.TabIndex = 7
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'PagosToolStripMenuItem
    '
    Me.PagosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VueltoToolStripMenuItem, Me.GuardarYCerrarToolStripMenuItem})
    Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
    Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
    Me.PagosToolStripMenuItem.Text = "&Cuentas"
    '
    'VueltoToolStripMenuItem
    '
    Me.VueltoToolStripMenuItem.Image = CType(resources.GetObject("VueltoToolStripMenuItem.Image"), System.Drawing.Image)
    Me.VueltoToolStripMenuItem.Name = "VueltoToolStripMenuItem"
    Me.VueltoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
    Me.VueltoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
    Me.VueltoToolStripMenuItem.Text = "&Vuelto"
    '
    'GuardarYCerrarToolStripMenuItem
    '
    Me.GuardarYCerrarToolStripMenuItem.Image = CType(resources.GetObject("GuardarYCerrarToolStripMenuItem.Image"), System.Drawing.Image)
    Me.GuardarYCerrarToolStripMenuItem.Name = "GuardarYCerrarToolStripMenuItem"
    Me.GuardarYCerrarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
    Me.GuardarYCerrarToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
    Me.GuardarYCerrarToolStripMenuItem.Text = "&Guardar y cerrar"
    '
    'FrmMantenimientoPagos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(715, 441)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.ToolStrip2)
    Me.Controls.Add(Me.MenuStrip1)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "FrmMantenimientoPagos"
    Me.Text = "Cuentas"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    CType(Me.CtlPagosDet1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents lbl_pendiente As System.Windows.Forms.Label
  Friend WithEvents lbl_pagado As System.Windows.Forms.Label
  Friend WithEvents CtlPagosDet1 As CtlPagosDet
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnguardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnvuelto As System.Windows.Forms.ToolStripButton
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents VueltoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents GuardarYCerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  'Friend WithEvents ComboboxSubCuentaContable1 As ComboBoxParametroDet
  'Friend WithEvents CtlBuscaCtaContable1 As CtlBuscaCtaContable
  'Friend WithEvents ComboBoxRegistroContable1 As ComboBoxRegistroContable
  Friend WithEvents btnira As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents btnnuevo As System.Windows.Forms.ToolStripButton
End Class
