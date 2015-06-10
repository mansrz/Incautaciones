<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoMovimientoInventario
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoMovimientoInventario))
    Me.pnlcuerpo = New System.Windows.Forms.Panel()
    Me.CtlBloqueo1 = New Incautacion.Modulo.CtlBloqueo()
    Me.CtlMovimientoInventario1 = New Incautacion.Modulo.CtlMovimientoInventario()
    Me.HeaderStrip1 = New Infoware.Docking.HeaderStrip()
    Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripMovimiento = New System.Windows.Forms.ToolStrip()
        Me.btnexportar = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.comboTipoMovimiento = New System.Windows.Forms.ToolStripComboBox()
    Me.comboTipoCompraVenta = New System.Windows.Forms.ToolStripComboBox()
    Me.SepPagos = New System.Windows.Forms.ToolStripSeparator()
    Me.btnpagos = New System.Windows.Forms.ToolStripButton()
    Me.btnimprbarcode = New System.Windows.Forms.ToolStripButton()
    Me.btnformatobarcode = New System.Windows.Forms.ToolStripButton()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.ToolStripMovimiento.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.CtlBloqueo1)
    Me.pnlcuerpo.Controls.Add(Me.CtlMovimientoInventario1)
    Me.pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 74)
    Me.pnlcuerpo.Name = "pnlcuerpo"
    Me.pnlcuerpo.Size = New System.Drawing.Size(1008, 618)
    Me.pnlcuerpo.TabIndex = 0
    '
    'CtlBloqueo1
    '
    Me.CtlBloqueo1.Location = New System.Drawing.Point(0, 25)
    Me.CtlBloqueo1.MaximumSize = New System.Drawing.Size(50, 50)
    Me.CtlBloqueo1.MinimumSize = New System.Drawing.Size(50, 50)
    Me.CtlBloqueo1.Name = "CtlBloqueo1"
    Me.CtlBloqueo1.Restriccion = Nothing
    Me.CtlBloqueo1.Size = New System.Drawing.Size(50, 50)
    Me.CtlBloqueo1.TabIndex = 2
    '
    'CtlMovimientoInventario1
    '
    Me.CtlMovimientoInventario1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlMovimientoInventario1.Location = New System.Drawing.Point(0, 25)
    Me.CtlMovimientoInventario1.MovimientoInventario = Nothing
    Me.CtlMovimientoInventario1.Name = "CtlMovimientoInventario1"
    Me.CtlMovimientoInventario1.PardetTipoInventario = Nothing
    Me.CtlMovimientoInventario1.PuedeCancelar = False
    Me.CtlMovimientoInventario1.Sistema = Nothing
    Me.CtlMovimientoInventario1.Size = New System.Drawing.Size(1008, 593)
    Me.CtlMovimientoInventario1.Sucursal = Nothing
    Me.CtlMovimientoInventario1.TabIndex = 1
    Me.CtlMovimientoInventario1.VerConfidencial = False
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.White
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
    Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Size = New System.Drawing.Size(1008, 25)
    Me.HeaderStrip1.TabIndex = 0
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel2
    '
    Me.ToolStripLabel2.Name = "ToolStripLabel2"
    Me.ToolStripLabel2.Size = New System.Drawing.Size(200, 22)
    Me.ToolStripLabel2.Text = "Movimiento de inventario"
    '
    'ToolStripMovimiento
    '
        Me.ToolStripMovimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.comboTipoMovimiento, Me.btnimprbarcode, Me.comboTipoCompraVenta, Me.SepPagos, Me.btnpagos, Me.btnformatobarcode, Me.btnexportar})
    Me.ToolStripMovimiento.Location = New System.Drawing.Point(0, 49)
    Me.ToolStripMovimiento.Name = "ToolStripMovimiento"
    Me.ToolStripMovimiento.Size = New System.Drawing.Size(1008, 25)
    Me.ToolStripMovimiento.TabIndex = 4
    Me.ToolStripMovimiento.Text = "ToolStrip2"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripSeparator1.MergeIndex = 10
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'comboTipoMovimiento
    '
    Me.comboTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.comboTipoMovimiento.IntegralHeight = False
    Me.comboTipoMovimiento.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.comboTipoMovimiento.MergeIndex = 11
    Me.comboTipoMovimiento.Name = "comboTipoMovimiento"
    Me.comboTipoMovimiento.Size = New System.Drawing.Size(150, 25)
    '
    'comboTipoCompraVenta
    '
    Me.comboTipoCompraVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.comboTipoCompraVenta.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.comboTipoCompraVenta.MergeIndex = 12
    Me.comboTipoCompraVenta.Name = "comboTipoCompraVenta"
    Me.comboTipoCompraVenta.Size = New System.Drawing.Size(150, 25)
    Me.comboTipoCompraVenta.Visible = False
    '
    'SepPagos
    '
    Me.SepPagos.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.SepPagos.MergeIndex = 13
    Me.SepPagos.Name = "SepPagos"
    Me.SepPagos.Size = New System.Drawing.Size(6, 25)
    Me.SepPagos.Visible = False
    '
    'btnpagos
    '
    Me.btnpagos.Image = CType(resources.GetObject("btnpagos.Image"), System.Drawing.Image)
    Me.btnpagos.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnpagos.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnpagos.MergeIndex = 14
    Me.btnpagos.Name = "btnpagos"
    Me.btnpagos.Size = New System.Drawing.Size(113, 22)
    Me.btnpagos.Text = "Provisión/Pagos"
    Me.btnpagos.Visible = False
    '
    'btnimprbarcode
    '
    Me.btnimprbarcode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnimprbarcode.Image = CType(resources.GetObject("btnimprbarcode.Image"), System.Drawing.Image)
    Me.btnimprbarcode.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnimprbarcode.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnimprbarcode.MergeIndex = 15
    Me.btnimprbarcode.Name = "btnimprbarcode"
    Me.btnimprbarcode.Size = New System.Drawing.Size(23, 22)
    Me.btnimprbarcode.Text = "Imprimir códigos de barra"
    '
    'btnformatobarcode
    '
    Me.btnformatobarcode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnformatobarcode.Image = CType(resources.GetObject("btnformatobarcode.Image"), System.Drawing.Image)
    Me.btnformatobarcode.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnformatobarcode.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnformatobarcode.MergeIndex = 16
    Me.btnformatobarcode.Name = "btnformatobarcode"
    Me.btnformatobarcode.Size = New System.Drawing.Size(23, 22)
    Me.btnformatobarcode.Text = "Modificar formato códigos de barra"
        '
        'btnexportar
        '
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(70, 22)
        Me.btnexportar.Text = "Exportar"
        Me.btnexportar.Visible = False

        '
    'FrmMantenimientoMovimientoInventario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(1008, 692)
    Me.Controls.Add(Me.pnlcuerpo)
    Me.Controls.Add(Me.ToolStripMovimiento)
    Me.Name = "FrmMantenimientoMovimientoInventario"
    Me.PuedeAnular = True
    Me.PuedeFormato = True
    Me.PuedeGuardar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeImprimir = True
    Me.PuedeMover = True
    Me.PuedeNuevo = True
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Controls.SetChildIndex(Me.ToolStripMovimiento, 0)
    Me.Controls.SetChildIndex(Me.pnlcuerpo, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.ToolStripMovimiento.ResumeLayout(False)
    Me.ToolStripMovimiento.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents pnlcuerpo As System.Windows.Forms.Panel
  Friend WithEvents ToolStripMovimiento As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents comboTipoMovimiento As System.Windows.Forms.ToolStripComboBox
  Friend WithEvents comboTipoCompraVenta As System.Windows.Forms.ToolStripComboBox
  Friend WithEvents HeaderStrip1 As Infoware.Docking.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  'Friend WithEvents ComboBoxIVA1 As WWTS.SRI.Controles.ComboBoxIVA
  'Friend WithEvents ComboBoxCreditoTributario1 As WWTS.SRI.Controles.ComboBoxCreditoTributario
  'Friend WithEvents ComboBoxTipoComprobante1 As WWTS.SRI.Controles.ComboBoxTipoComprobante
  Friend WithEvents SepPagos As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnpagos As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnimprbarcode As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnformatobarcode As System.Windows.Forms.ToolStripButton
  Friend WithEvents CtlMovimientoInventario1 As Incautacion.Modulo.CtlMovimientoInventario
  Friend WithEvents CtlBloqueo1 As Incautacion.Modulo.CtlBloqueo
    Friend WithEvents btnexportar As System.Windows.Forms.ToolStripButton
End Class
