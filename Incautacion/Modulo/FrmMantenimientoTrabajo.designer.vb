<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoTrabajo
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoTrabajo))
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.CtlBloqueo1 = New Incautacion.Modulo.CtlBloqueo()
    Me.lnkEstadoCuenta = New System.Windows.Forms.LinkLabel()
    Me.txtnumerosobre = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtobservacion = New Infoware.Controles.Base.TextBoxStd()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboTipoTrabajo = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.CtlBuscaCliente1 = New Incautacion.Modulo.CtlBuscaCliente()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.CtlTrabajoLog1 = New Incautacion.Modulo.CtlTrabajoLog()
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
    Me.ToolStripMovimiento = New System.Windows.Forms.ToolStrip()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnreenviar = New System.Windows.Forms.ToolStripButton()
    Me.btnFactura = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.btncancelar = New System.Windows.Forms.ToolStripButton()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
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
    Me.TabControl1.Location = New System.Drawing.Point(0, 86)
    Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(856, 378)
    Me.TabControl1.TabIndex = 0
    Me.TabControl1.TabStop = False
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.CtlBloqueo1)
    Me.TabPage1.Controls.Add(Me.lnkEstadoCuenta)
    Me.TabPage1.Controls.Add(Me.txtnumerosobre)
    Me.TabPage1.Controls.Add(Me.Label2)
    Me.TabPage1.Controls.Add(Me.txtobservacion)
    Me.TabPage1.Controls.Add(Me.Label4)
    Me.TabPage1.Controls.Add(Me.Label1)
    Me.TabPage1.Controls.Add(Me.cboTipoTrabajo)
    Me.TabPage1.Controls.Add(Me.CtlBuscaCliente1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 25)
    Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.TabPage1.Size = New System.Drawing.Size(848, 349)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Principal"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'CtlBloqueo1
    '
    Me.CtlBloqueo1.Location = New System.Drawing.Point(768, 300)
    Me.CtlBloqueo1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.CtlBloqueo1.MaximumSize = New System.Drawing.Size(67, 62)
    Me.CtlBloqueo1.MinimumSize = New System.Drawing.Size(67, 62)
    Me.CtlBloqueo1.Name = "CtlBloqueo1"
    Me.CtlBloqueo1.Restriccion = Nothing
    Me.CtlBloqueo1.Size = New System.Drawing.Size(67, 62)
    Me.CtlBloqueo1.TabIndex = 8
    '
    'lnkEstadoCuenta
    '
    Me.lnkEstadoCuenta.AutoSize = True
    Me.lnkEstadoCuenta.Location = New System.Drawing.Point(659, 55)
    Me.lnkEstadoCuenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lnkEstadoCuenta.Name = "lnkEstadoCuenta"
    Me.lnkEstadoCuenta.Size = New System.Drawing.Size(145, 17)
    Me.lnkEstadoCuenta.TabIndex = 7
    Me.lnkEstadoCuenta.TabStop = True
    Me.lnkEstadoCuenta.Text = "Ver Estado de cuenta"
    '
    'txtnumerosobre
    '
    Me.txtnumerosobre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtnumerosobre.BackColor = System.Drawing.SystemColors.Window
    Me.txtnumerosobre.Enabled = False
    Me.txtnumerosobre.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtnumerosobre.Location = New System.Drawing.Point(177, 18)
    Me.txtnumerosobre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.txtnumerosobre.Mensaje = ""
    Me.txtnumerosobre.Name = "txtnumerosobre"
    Me.txtnumerosobre.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtnumerosobre.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtnumerosobre.PromptText = ""
    Me.txtnumerosobre.Size = New System.Drawing.Size(97, 22)
    Me.txtnumerosobre.TabIndex = 1
    Me.txtnumerosobre.Text = "0"
    Me.txtnumerosobre.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtnumerosobre.Value = 0.0R
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 22)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(87, 17)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Trabajo No.:"
    '
    'txtobservacion
    '
    Me.txtobservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtobservacion.Location = New System.Drawing.Point(177, 118)
    Me.txtobservacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.txtobservacion.Mensaje = ""
    Me.txtobservacion.Multiline = True
    Me.txtobservacion.Name = "txtobservacion"
    Me.txtobservacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtobservacion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtobservacion.PromptText = ""
    Me.txtobservacion.Size = New System.Drawing.Size(657, 42)
    Me.txtobservacion.TabIndex = 6
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 122)
    Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(65, 17)
    Me.Label4.TabIndex = 5
    Me.Label4.Text = "Mensaje:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 89)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(108, 17)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Tipo de trabajo:"
    '
    'cboTipoTrabajo
    '
    Me.cboTipoTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoTrabajo.FormattingEnabled = True
    Me.cboTipoTrabajo.Location = New System.Drawing.Point(177, 85)
    Me.cboTipoTrabajo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.cboTipoTrabajo.Name = "cboTipoTrabajo"
    Me.cboTipoTrabajo.OperadorDatos = Nothing
    Me.cboTipoTrabajo.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboTipoTrabajo.ParametroDet = Nothing
    Me.cboTipoTrabajo.PuedeActualizar = True
    Me.cboTipoTrabajo.PuedeEliminar = True
    Me.cboTipoTrabajo.PuedeModificar = True
    Me.cboTipoTrabajo.PuedeNuevo = True
    Me.cboTipoTrabajo.Size = New System.Drawing.Size(264, 24)
    Me.cboTipoTrabajo.TabIndex = 4
    '
    'CtlBuscaCliente1
    '
    Me.CtlBuscaCliente1.Cliente = Nothing
    Me.CtlBuscaCliente1.ClienteText = "Cliente"
    Me.CtlBuscaCliente1.ItemText = "Cliente"
    Me.CtlBuscaCliente1.Location = New System.Drawing.Point(12, 50)
    Me.CtlBuscaCliente1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.CtlBuscaCliente1.Name = "CtlBuscaCliente1"
    Me.CtlBuscaCliente1.Size = New System.Drawing.Size(639, 27)
    Me.CtlBuscaCliente1.TabIndex = 2
    Me.CtlBuscaCliente1.Ubicacion = Incautacion.Modulo.CtlBuscaCliente.EnumUbicacion.Normal
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.CtlTrabajoLog1)
    Me.TabPage2.Location = New System.Drawing.Point(4, 25)
    Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.TabPage2.Size = New System.Drawing.Size(848, 344)
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
    Me.CtlTrabajoLog1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.CtlTrabajoLog1.DefaultCellStyle = DataGridViewCellStyle2
    Me.CtlTrabajoLog1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlTrabajoLog1.Location = New System.Drawing.Point(4, 4)
    Me.CtlTrabajoLog1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Me.CtlTrabajoLog1.Size = New System.Drawing.Size(840, 336)
    Me.CtlTrabajoLog1.TabIndex = 0
    Me.CtlTrabajoLog1.Trabajo = Nothing
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
    'ToolStripMovimiento
    '
    Me.ToolStripMovimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnreenviar, Me.btnFactura, Me.ToolStripSeparator2, Me.btncancelar})
    Me.ToolStripMovimiento.Location = New System.Drawing.Point(0, 59)
    Me.ToolStripMovimiento.Name = "ToolStripMovimiento"
    Me.ToolStripMovimiento.Size = New System.Drawing.Size(856, 27)
    Me.ToolStripMovimiento.TabIndex = 6
    Me.ToolStripMovimiento.Text = "ToolStrip2"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripSeparator1.MergeIndex = 13
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
    '
    'btnreenviar
    '
    Me.btnreenviar.Image = CType(resources.GetObject("btnreenviar.Image"), System.Drawing.Image)
    Me.btnreenviar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnreenviar.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnreenviar.MergeIndex = 14
    Me.btnreenviar.Name = "btnreenviar"
    Me.btnreenviar.Size = New System.Drawing.Size(138, 24)
    Me.btnreenviar.Text = "Reenviar trabajo"
    Me.btnreenviar.Visible = False
    '
    'btnFactura
    '
    Me.btnFactura.Image = CType(resources.GetObject("btnFactura.Image"), System.Drawing.Image)
    Me.btnFactura.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnFactura.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnFactura.MergeIndex = 15
    Me.btnFactura.Name = "btnFactura"
    Me.btnFactura.Size = New System.Drawing.Size(77, 24)
    Me.btnFactura.Text = "Factura"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripSeparator2.MergeIndex = 16
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
    '
    'btncancelar
    '
    Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
    Me.btncancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btncancelar.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btncancelar.MergeIndex = 17
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(132, 24)
    Me.btncancelar.Text = "Abortar trabajo"
    '
    'FrmMantenimientoTrabajo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.ClientSize = New System.Drawing.Size(856, 464)
    Me.Controls.Add(Me.TabControl1)
    Me.Controls.Add(Me.ToolStripMovimiento)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Name = "FrmMantenimientoTrabajo"
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Text = "Caso"
    Me.Controls.SetChildIndex(Me.ToolStripMovimiento, 0)
    Me.Controls.SetChildIndex(Me.TabControl1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage1.PerformLayout()
    Me.TabPage2.ResumeLayout(False)
    CType(Me.CtlTrabajoLog1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStripMovimiento.ResumeLayout(False)
    Me.ToolStripMovimiento.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboTipoTrabajo As Incautacion.Modulo.ComboBoxParametroDet
  Friend WithEvents CtlBuscaCliente1 As Incautacion.Modulo.CtlBuscaCliente
  Friend WithEvents txtobservacion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtnumerosobre As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lnkEstadoCuenta As System.Windows.Forms.LinkLabel
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents CtlTrabajoLog1 As Incautacion.Modulo.CtlTrabajoLog
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CtlBloqueo1 As Incautacion.Modulo.CtlBloqueo
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripMovimiento As System.Windows.Forms.ToolStrip
  Friend WithEvents btnFactura As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btncancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnreenviar As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
