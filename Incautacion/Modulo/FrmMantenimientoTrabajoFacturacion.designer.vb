<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoTrabajoFacturacion
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoTrabajoFacturacion))
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.CtlMovimientoInventario1 = New Incautacion.Modulo.CtlMovimientoInventario()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txttiempo = New Infoware.Controles.Base.TextBoxStd()
    Me.lbltrabajo = New System.Windows.Forms.Label()
    Me.CtlBloqueo1 = New Incautacion.Modulo.CtlBloqueo()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.TabControlMovimientos = New System.Windows.Forms.TabControl()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.CtlTrabajoLog1 = New Incautacion.Modulo.CtlTrabajoLog()
    Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
    Me.ToolStripMovimiento = New System.Windows.Forms.ToolStrip()
    Me.btnestadocuenta = New System.Windows.Forms.ToolStripButton()
    Me.btnpagos = New System.Windows.Forms.ToolStripButton()
    Me.btnimprimir = New System.Windows.Forms.ToolStripButton()
    Me.btnformato = New System.Windows.Forms.ToolStripButton()
    Me.btncancelar = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.TabPage3.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    CType(Me.CtlTrabajoLog1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStripMovimiento.SuspendLayout()
    Me.SuspendLayout()
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage3)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 74)
    Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1341, 582)
    Me.TabControl1.TabIndex = 0
    Me.TabControl1.TabStop = False
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.CtlMovimientoInventario1)
    Me.TabPage1.Controls.Add(Me.Panel1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
    Me.TabPage1.Size = New System.Drawing.Size(1333, 556)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Principal"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'CtlMovimientoInventario1
    '
    Me.CtlMovimientoInventario1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlMovimientoInventario1.Location = New System.Drawing.Point(4, 70)
    Me.CtlMovimientoInventario1.Margin = New System.Windows.Forms.Padding(5)
    Me.CtlMovimientoInventario1.MovimientoInventario = Nothing
    Me.CtlMovimientoInventario1.Name = "CtlMovimientoInventario1"
    Me.CtlMovimientoInventario1.PardetTipoInventario = Nothing
    Me.CtlMovimientoInventario1.PuedeCancelar = False
    Me.CtlMovimientoInventario1.Sistema = Nothing
    Me.CtlMovimientoInventario1.Size = New System.Drawing.Size(1325, 482)
    Me.CtlMovimientoInventario1.Sucursal = Nothing
    Me.CtlMovimientoInventario1.TabIndex = 5
    Me.CtlMovimientoInventario1.VerConfidencial = False
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.txttiempo)
    Me.Panel1.Controls.Add(Me.lbltrabajo)
    Me.Panel1.Controls.Add(Me.CtlBloqueo1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(4, 4)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(1325, 66)
    Me.Panel1.TabIndex = 4
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(75, 34)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(103, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Tiempo transcurrido:"
    '
    'txttiempo
    '
    Me.txttiempo.Enabled = False
    Me.txttiempo.Location = New System.Drawing.Point(220, 31)
    Me.txttiempo.Margin = New System.Windows.Forms.Padding(4)
    Me.txttiempo.Mensaje = ""
    Me.txttiempo.Name = "txttiempo"
    Me.txttiempo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txttiempo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txttiempo.PromptText = ""
    Me.txttiempo.Size = New System.Drawing.Size(423, 19)
    Me.txttiempo.TabIndex = 2
    '
    'lbltrabajo
    '
    Me.lbltrabajo.BackColor = System.Drawing.SystemColors.Info
    Me.lbltrabajo.Dock = System.Windows.Forms.DockStyle.Top
    Me.lbltrabajo.Location = New System.Drawing.Point(67, 0)
    Me.lbltrabajo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lbltrabajo.Name = "lbltrabajo"
    Me.lbltrabajo.Size = New System.Drawing.Size(1258, 20)
    Me.lbltrabajo.TabIndex = 0
    Me.lbltrabajo.Text = "."
    '
    'CtlBloqueo1
    '
    Me.CtlBloqueo1.Dock = System.Windows.Forms.DockStyle.Left
    Me.CtlBloqueo1.Location = New System.Drawing.Point(0, 0)
    Me.CtlBloqueo1.Margin = New System.Windows.Forms.Padding(5)
    Me.CtlBloqueo1.MaximumSize = New System.Drawing.Size(67, 62)
    Me.CtlBloqueo1.MinimumSize = New System.Drawing.Size(67, 62)
    Me.CtlBloqueo1.Name = "CtlBloqueo1"
    Me.CtlBloqueo1.Restriccion = Nothing
    Me.CtlBloqueo1.Size = New System.Drawing.Size(67, 62)
    Me.CtlBloqueo1.TabIndex = 3
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.TabControlMovimientos)
    Me.TabPage3.Location = New System.Drawing.Point(4, 22)
    Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
    Me.TabPage3.Size = New System.Drawing.Size(1333, 556)
    Me.TabPage3.TabIndex = 2
    Me.TabPage3.Text = "Producción"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'TabControlMovimientos
    '
    Me.TabControlMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControlMovimientos.Location = New System.Drawing.Point(4, 4)
    Me.TabControlMovimientos.Margin = New System.Windows.Forms.Padding(4)
    Me.TabControlMovimientos.Name = "TabControlMovimientos"
    Me.TabControlMovimientos.SelectedIndex = 0
    Me.TabControlMovimientos.Size = New System.Drawing.Size(1325, 548)
    Me.TabControlMovimientos.TabIndex = 3
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.CtlTrabajoLog1)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
    Me.TabPage2.Size = New System.Drawing.Size(1333, 556)
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
    Me.CtlTrabajoLog1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.CtlTrabajoLog1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
    Me.CtlTrabajoLog1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlTrabajoLog1.Location = New System.Drawing.Point(4, 4)
    Me.CtlTrabajoLog1.Margin = New System.Windows.Forms.Padding(4)
    Me.CtlTrabajoLog1.Name = "CtlTrabajoLog1"
    Me.CtlTrabajoLog1.ReadOnly = True
    Me.CtlTrabajoLog1.RowHeadersVisible = False
    Me.CtlTrabajoLog1.Size = New System.Drawing.Size(1325, 548)
    Me.CtlTrabajoLog1.TabIndex = 0
    Me.CtlTrabajoLog1.Trabajo = Nothing
    '
    'DataGridViewTextBoxColumn22
    '
    Me.DataGridViewTextBoxColumn22.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
    Me.DataGridViewTextBoxColumn22.ReadOnly = True
    '
    'DataGridViewTextBoxColumn21
    '
    Me.DataGridViewTextBoxColumn21.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
    Me.DataGridViewTextBoxColumn21.ReadOnly = True
    '
    'DataGridViewTextBoxColumn20
    '
    Me.DataGridViewTextBoxColumn20.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
    Me.DataGridViewTextBoxColumn20.ReadOnly = True
    '
    'DataGridViewTextBoxColumn19
    '
    Me.DataGridViewTextBoxColumn19.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
    Me.DataGridViewTextBoxColumn19.ReadOnly = True
    '
    'DataGridViewTextBoxColumn18
    '
    Me.DataGridViewTextBoxColumn18.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
    Me.DataGridViewTextBoxColumn18.ReadOnly = True
    '
    'DataGridViewTextBoxColumn17
    '
    Me.DataGridViewTextBoxColumn17.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
    Me.DataGridViewTextBoxColumn17.ReadOnly = True
    '
    'DataGridViewTextBoxColumn16
    '
    Me.DataGridViewTextBoxColumn16.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
    Me.DataGridViewTextBoxColumn16.ReadOnly = True
    '
    'DataGridViewTextBoxColumn15
    '
    Me.DataGridViewTextBoxColumn15.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
    Me.DataGridViewTextBoxColumn15.ReadOnly = True
    '
    'DataGridViewTextBoxColumn14
    '
    Me.DataGridViewTextBoxColumn14.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
    Me.DataGridViewTextBoxColumn14.ReadOnly = True
    '
    'DataGridViewTextBoxColumn13
    '
    Me.DataGridViewTextBoxColumn13.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
    Me.DataGridViewTextBoxColumn13.ReadOnly = True
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
    'ToolStripMovimiento
    '
    Me.ToolStripMovimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnestadocuenta, Me.btnpagos, Me.btnimprimir, Me.btnformato, Me.btncancelar, Me.ToolStripSeparator1})
    Me.ToolStripMovimiento.Location = New System.Drawing.Point(0, 49)
    Me.ToolStripMovimiento.Name = "ToolStripMovimiento"
    Me.ToolStripMovimiento.Size = New System.Drawing.Size(1341, 25)
    Me.ToolStripMovimiento.TabIndex = 6
    Me.ToolStripMovimiento.Text = "ToolStrip2"
    '
    'btnestadocuenta
    '
    Me.btnestadocuenta.Image = CType(resources.GetObject("btnestadocuenta.Image"), System.Drawing.Image)
    Me.btnestadocuenta.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnestadocuenta.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnestadocuenta.MergeIndex = 13
    Me.btnestadocuenta.Name = "btnestadocuenta"
    Me.btnestadocuenta.Size = New System.Drawing.Size(117, 22)
    Me.btnestadocuenta.Text = "Estado de cuenta"
    '
    'btnpagos
    '
    Me.btnpagos.Image = CType(resources.GetObject("btnpagos.Image"), System.Drawing.Image)
    Me.btnpagos.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnpagos.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnpagos.MergeIndex = 13
    Me.btnpagos.Name = "btnpagos"
    Me.btnpagos.Size = New System.Drawing.Size(108, 22)
    Me.btnpagos.Text = "Provisión/Pago"
    '
    'btnimprimir
    '
    Me.btnimprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), System.Drawing.Image)
    Me.btnimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnimprimir.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnimprimir.MergeIndex = 13
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
    Me.btnformato.MergeIndex = 13
    Me.btnformato.Name = "btnformato"
    Me.btnformato.Size = New System.Drawing.Size(23, 22)
    Me.btnformato.Text = "Modificar formato"
    '
    'btncancelar
    '
    Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
    Me.btncancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btncancelar.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btncancelar.MergeIndex = 13
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(113, 22)
    Me.btncancelar.Text = "Devolver trabajo"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripSeparator1.MergeIndex = 14
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'FrmMantenimientoTrabajoFacturacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(1341, 656)
    Me.Controls.Add(Me.TabControl1)
    Me.Controls.Add(Me.ToolStripMovimiento)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(5)
    Me.Name = "FrmMantenimientoTrabajoFacturacion"
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Text = "Facturación"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.Controls.SetChildIndex(Me.ToolStripMovimiento, 0)
    Me.Controls.SetChildIndex(Me.TabControl1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.TabPage3.ResumeLayout(False)
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
  Friend WithEvents CtlBloqueo1 As Incautacion.Modulo.CtlBloqueo
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripMovimiento As System.Windows.Forms.ToolStrip
  Friend WithEvents btnimprimir As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnformato As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnpagos As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnestadocuenta As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btncancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabControlMovimientos As System.Windows.Forms.TabControl
  Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
