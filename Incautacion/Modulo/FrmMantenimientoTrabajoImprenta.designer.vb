<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoTrabajoImprenta
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
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoTrabajoImprenta))
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.TabControlMovimientos = New System.Windows.Forms.TabControl()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.ComboBoxTipoMovimiento = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.CtlMovimientoInventarioDet1 = New Incautacion.Modulo.CtlMovimientoInventarioDet()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txttiempo = New Infoware.Controles.Base.TextBoxStd()
    Me.lbltrabajo = New System.Windows.Forms.Label()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.CtlTrabajoLog1 = New Incautacion.Modulo.CtlTrabajoLog()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BindingSourceMovimientos = New System.Windows.Forms.BindingSource(Me.components)
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.ToolStripMovimiento = New System.Windows.Forms.ToolStrip()
    Me.btncancelar = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    CType(Me.CtlMovimientoInventarioDet1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    CType(Me.CtlTrabajoLog1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BindingSourceMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStripMovimiento.SuspendLayout()
    Me.SuspendLayout()
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 49)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(823, 484)
    Me.TabControl1.TabIndex = 0
    Me.TabControl1.TabStop = False
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.GroupBox2)
    Me.TabPage1.Controls.Add(Me.GroupBox1)
    Me.TabPage1.Controls.Add(Me.Panel1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(815, 458)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Principal"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.TabControlMovimientos)
    Me.GroupBox2.Controls.Add(Me.Panel2)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox2.Location = New System.Drawing.Point(3, 174)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(809, 281)
    Me.GroupBox2.TabIndex = 8
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Movimientos"
    '
    'TabControlMovimientos
    '
    Me.TabControlMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControlMovimientos.Location = New System.Drawing.Point(3, 39)
    Me.TabControlMovimientos.Name = "TabControlMovimientos"
    Me.TabControlMovimientos.SelectedIndex = 0
    Me.TabControlMovimientos.Size = New System.Drawing.Size(803, 239)
    Me.TabControlMovimientos.TabIndex = 2
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.ComboBoxTipoMovimiento)
    Me.Panel2.Controls.Add(Me.LinkLabel1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(3, 16)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(803, 23)
    Me.Panel2.TabIndex = 3
    '
    'ComboBoxTipoMovimiento
    '
    Me.ComboBoxTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoMovimiento.FormattingEnabled = True
    Me.ComboBoxTipoMovimiento.Location = New System.Drawing.Point(3, 1)
    Me.ComboBoxTipoMovimiento.Name = "ComboBoxTipoMovimiento"
    Me.ComboBoxTipoMovimiento.OperadorDatos = Nothing
    Me.ComboBoxTipoMovimiento.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipoMovimiento.ParametroDet = Nothing
    Me.ComboBoxTipoMovimiento.PuedeActualizar = True
    Me.ComboBoxTipoMovimiento.PuedeEliminar = True
    Me.ComboBoxTipoMovimiento.PuedeModificar = True
    Me.ComboBoxTipoMovimiento.PuedeNuevo = True
    Me.ComboBoxTipoMovimiento.Size = New System.Drawing.Size(194, 21)
    Me.ComboBoxTipoMovimiento.TabIndex = 0
    '
    'LinkLabel1
    '
    Me.LinkLabel1.AutoSize = True
    Me.LinkLabel1.Location = New System.Drawing.Point(203, 4)
    Me.LinkLabel1.Name = "LinkLabel1"
    Me.LinkLabel1.Size = New System.Drawing.Size(100, 13)
    Me.LinkLabel1.TabIndex = 1
    Me.LinkLabel1.TabStop = True
    Me.LinkLabel1.Text = "Agregar movimiento"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.CtlMovimientoInventarioDet1)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBox1.Location = New System.Drawing.Point(3, 45)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(809, 129)
    Me.GroupBox1.TabIndex = 7
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Proforma"
    '
    'CtlMovimientoInventarioDet1
    '
    Me.CtlMovimientoInventarioDet1.AllowUserToAddRows = False
    Me.CtlMovimientoInventarioDet1.AllowUserToDeleteRows = False
    Me.CtlMovimientoInventarioDet1.AutoGenerateColumns = False
    Me.CtlMovimientoInventarioDet1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.CtlMovimientoInventarioDet1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlMovimientoInventarioDet1.FactorTamanio = New Decimal(New Integer() {1, 0, 0, 0})
    Me.CtlMovimientoInventarioDet1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CtlMovimientoInventarioDet1.Location = New System.Drawing.Point(3, 16)
    Me.CtlMovimientoInventarioDet1.MovimientoInventario = Nothing
    Me.CtlMovimientoInventarioDet1.Name = "CtlMovimientoInventarioDet1"
    Me.CtlMovimientoInventarioDet1.PardetTipoPago = Nothing
    Me.CtlMovimientoInventarioDet1.ReadOnly = True
    Me.CtlMovimientoInventarioDet1.Size = New System.Drawing.Size(803, 110)
    Me.CtlMovimientoInventarioDet1.TabIndex = 6
    Me.CtlMovimientoInventarioDet1.Venta = Nothing
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.txttiempo)
    Me.Panel1.Controls.Add(Me.lbltrabajo)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(3, 3)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(809, 42)
    Me.Panel1.TabIndex = 4
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 22)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(103, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Tiempo transcurrido:"
    '
    'txttiempo
    '
    Me.txttiempo.Enabled = False
    Me.txttiempo.Location = New System.Drawing.Point(114, 19)
    Me.txttiempo.Mensaje = ""
    Me.txttiempo.Name = "txttiempo"
    Me.txttiempo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txttiempo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txttiempo.PromptText = ""
    Me.txttiempo.Size = New System.Drawing.Size(318, 20)
    Me.txttiempo.TabIndex = 2
    Me.txttiempo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'lbltrabajo
    '
    Me.lbltrabajo.BackColor = System.Drawing.SystemColors.Info
    Me.lbltrabajo.Dock = System.Windows.Forms.DockStyle.Top
    Me.lbltrabajo.Location = New System.Drawing.Point(0, 0)
    Me.lbltrabajo.Name = "lbltrabajo"
    Me.lbltrabajo.Size = New System.Drawing.Size(809, 16)
    Me.lbltrabajo.TabIndex = 0
    Me.lbltrabajo.Text = "."
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.CtlTrabajoLog1)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(815, 458)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Historial"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'CtlTrabajoLog1
    '
    Me.CtlTrabajoLog1.AgruparRepetidos = False
    Me.CtlTrabajoLog1.AllowUserToAddRows = False
    Me.CtlTrabajoLog1.AllowUserToDeleteRows = False
    Me.CtlTrabajoLog1.AutoGenerateColumns = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.CtlTrabajoLog1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.CtlTrabajoLog1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.CtlTrabajoLog1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.CtlTrabajoLog1.DefaultCellStyle = DataGridViewCellStyle2
    Me.CtlTrabajoLog1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlTrabajoLog1.Location = New System.Drawing.Point(3, 3)
    Me.CtlTrabajoLog1.Name = "CtlTrabajoLog1"
    Me.CtlTrabajoLog1.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.CtlTrabajoLog1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.CtlTrabajoLog1.RowHeadersVisible = False
    Me.CtlTrabajoLog1.Size = New System.Drawing.Size(809, 452)
    Me.CtlTrabajoLog1.TabIndex = 0
    Me.CtlTrabajoLog1.Trabajo = Nothing
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    '
    'Timer1
    '
    Me.Timer1.Enabled = True
    Me.Timer1.Interval = 1500
    '
    'ToolStripMovimiento
    '
    Me.ToolStripMovimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btncancelar})
    Me.ToolStripMovimiento.Location = New System.Drawing.Point(0, 49)
    Me.ToolStripMovimiento.Name = "ToolStripMovimiento"
    Me.ToolStripMovimiento.Size = New System.Drawing.Size(823, 25)
    Me.ToolStripMovimiento.TabIndex = 7
    Me.ToolStripMovimiento.Text = "ToolStrip2"
    '
    'btncancelar
    '
    Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
    Me.btncancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btncancelar.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btncancelar.MergeIndex = 14
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(113, 22)
    Me.btncancelar.Text = "Devolver trabajo"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripSeparator1.MergeIndex = 13
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'FrmMantenimientoTrabajoImprenta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(823, 533)
    Me.Controls.Add(Me.ToolStripMovimiento)
    Me.Controls.Add(Me.TabControl1)
    Me.Name = "FrmMantenimientoTrabajoImprenta"
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Text = "Imprenta"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.Controls.SetChildIndex(Me.TabControl1, 0)
    Me.Controls.SetChildIndex(Me.ToolStripMovimiento, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    CType(Me.CtlMovimientoInventarioDet1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.TabPage2.ResumeLayout(False)
    CType(Me.CtlTrabajoLog1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BindingSourceMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStripMovimiento.ResumeLayout(False)
    Me.ToolStripMovimiento.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents lbltrabajo As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txttiempo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Timer1 As System.Windows.Forms.Timer
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents CtlMovimientoInventarioDet1 As Incautacion.Modulo.CtlMovimientoInventarioDet
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
  Friend WithEvents ComboBoxTipoMovimiento As Incautacion.Modulo.ComboBoxParametroDet
  Friend WithEvents BindingSourceMovimientos As System.Windows.Forms.BindingSource
  Friend WithEvents TabControlMovimientos As System.Windows.Forms.TabControl
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents CtlTrabajoLog1 As Incautacion.Modulo.CtlTrabajoLog
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripMovimiento As System.Windows.Forms.ToolStrip
  Friend WithEvents btncancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
