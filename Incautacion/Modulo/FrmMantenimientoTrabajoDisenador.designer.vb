<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoTrabajoDisenador
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoTrabajoDisenador))
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.CtlMovimientoInventario1 = New Incautacion.Modulo.CtlMovimientoInventario()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.lbltrabajo = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txttiempo = New Infoware.Controles.Base.TextBoxStd()
    Me.CtlBloqueo1 = New Incautacion.Modulo.CtlBloqueo()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.CtlTrabajoLog1 = New Incautacion.Modulo.CtlTrabajoLog()
    Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.btncancelar = New System.Windows.Forms.ToolStripButton()
    Me.btnimprimir = New System.Windows.Forms.ToolStripButton()
    Me.btnformato = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripMovimiento = New System.Windows.Forms.ToolStrip()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    CType(Me.CtlTrabajoLog1, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.TabPage1.Controls.Add(Me.CtlMovimientoInventario1)
    Me.TabPage1.Controls.Add(Me.Panel1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(815, 458)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Principal"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'CtlMovimientoInventario1
    '
    Me.CtlMovimientoInventario1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlMovimientoInventario1.Location = New System.Drawing.Point(3, 55)
    Me.CtlMovimientoInventario1.MovimientoInventario = Nothing
    Me.CtlMovimientoInventario1.Name = "CtlMovimientoInventario1"
    Me.CtlMovimientoInventario1.PardetTipoInventario = Nothing
    Me.CtlMovimientoInventario1.PuedeCancelar = False
    Me.CtlMovimientoInventario1.Sistema = Nothing
    Me.CtlMovimientoInventario1.Size = New System.Drawing.Size(809, 400)
    Me.CtlMovimientoInventario1.Sucursal = Nothing
    Me.CtlMovimientoInventario1.TabIndex = 5
    Me.CtlMovimientoInventario1.VerConfidencial = False
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.lbltrabajo)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.txttiempo)
    Me.Panel1.Controls.Add(Me.CtlBloqueo1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(3, 3)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(809, 52)
    Me.Panel1.TabIndex = 4
    '
    'lbltrabajo
    '
    Me.lbltrabajo.BackColor = System.Drawing.SystemColors.Info
    Me.lbltrabajo.Dock = System.Windows.Forms.DockStyle.Top
    Me.lbltrabajo.Location = New System.Drawing.Point(50, 0)
    Me.lbltrabajo.Name = "lbltrabajo"
    Me.lbltrabajo.Size = New System.Drawing.Size(759, 16)
    Me.lbltrabajo.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(56, 26)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(0, 13)
    Me.Label1.TabIndex = 1
    '
    'txttiempo
    '
    Me.txttiempo.Enabled = False
    Me.txttiempo.Location = New System.Drawing.Point(165, 23)
    Me.txttiempo.Mensaje = ""
    Me.txttiempo.Name = "txttiempo"
    Me.txttiempo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txttiempo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txttiempo.PromptText = ""
    Me.txttiempo.Size = New System.Drawing.Size(318, 20)
    Me.txttiempo.TabIndex = 2
    Me.txttiempo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'CtlBloqueo1
    '
    Me.CtlBloqueo1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlBloqueo1.Location = New System.Drawing.Point(0, 0)
    Me.CtlBloqueo1.MaximumSize = New System.Drawing.Size(50, 50)
    Me.CtlBloqueo1.MinimumSize = New System.Drawing.Size(50, 50)
    Me.CtlBloqueo1.Name = "CtlBloqueo1"
    Me.CtlBloqueo1.Restriccion = Nothing
    Me.CtlBloqueo1.Size = New System.Drawing.Size(50, 50)
    Me.CtlBloqueo1.TabIndex = 3
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
    Me.CtlTrabajoLog1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
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
    Me.CtlTrabajoLog1.Size = New System.Drawing.Size(186, 68)
    Me.CtlTrabajoLog1.TabIndex = 0
    Me.CtlTrabajoLog1.Trabajo = Nothing
    '
    'DataGridViewTextBoxColumn12
    '
    Me.DataGridViewTextBoxColumn12.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
    Me.DataGridViewTextBoxColumn12.ReadOnly = True
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
    Me.DataGridViewTextBoxColumn11.ReadOnly = True
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
    Me.DataGridViewTextBoxColumn10.ReadOnly = True
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    Me.DataGridViewTextBoxColumn9.ReadOnly = True
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    Me.DataGridViewTextBoxColumn8.ReadOnly = True
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    Me.DataGridViewTextBoxColumn7.ReadOnly = True
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    Me.DataGridViewTextBoxColumn6.ReadOnly = True
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
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
    'btncancelar
    '
    Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
    Me.btncancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btncancelar.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btncancelar.MergeIndex = 17
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(113, 22)
    Me.btncancelar.Text = "Devolver trabajo"
    '
    'btnimprimir
    '
    Me.btnimprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), System.Drawing.Image)
    Me.btnimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnimprimir.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnimprimir.MergeIndex = 15
    Me.btnimprimir.Name = "btnimprimir"
    Me.btnimprimir.Size = New System.Drawing.Size(23, 22)
    Me.btnimprimir.Text = "Imprimir"
    '
    'btnformato
    '
    Me.btnformato.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnformato.Image = CType(resources.GetObject("btnformato.Image"), System.Drawing.Image)
    Me.btnformato.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnformato.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnformato.MergeIndex = 14
    Me.btnformato.Name = "btnformato"
    Me.btnformato.Size = New System.Drawing.Size(23, 22)
    Me.btnformato.Text = "Modificar formato"
    '
    'ToolStripMovimiento
    '
    Me.ToolStripMovimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.btnformato, Me.btnimprimir, Me.ToolStripSeparator3, Me.btncancelar})
    Me.ToolStripMovimiento.Location = New System.Drawing.Point(0, 49)
    Me.ToolStripMovimiento.Name = "ToolStripMovimiento"
    Me.ToolStripMovimiento.Size = New System.Drawing.Size(823, 25)
    Me.ToolStripMovimiento.TabIndex = 5
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripSeparator2.MergeIndex = 13
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripSeparator3.MergeIndex = 16
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
    '
    'FrmMantenimientoTrabajoDisenador
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(823, 533)
    Me.Controls.Add(Me.ToolStripMovimiento)
    Me.Controls.Add(Me.TabControl1)
    Me.MainMenuStrip = Nothing
    Me.Name = "FrmMantenimientoTrabajoDisenador"
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Text = ""
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.Controls.SetChildIndex(Me.TabControl1, 0)
    Me.Controls.SetChildIndex(Me.ToolStripMovimiento, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.TabPage2.ResumeLayout(False)
    CType(Me.CtlTrabajoLog1, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents CtlMovimientoInventario1 As Incautacion.Modulo.CtlMovimientoInventario
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents CtlTrabajoLog1 As Incautacion.Modulo.CtlTrabajoLog
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnimprimir As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnformato As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btncancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents CtlBloqueo1 As Incautacion.Modulo.CtlBloqueo
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripMovimiento As System.Windows.Forms.ToolStrip
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
