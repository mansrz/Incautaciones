<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoMovimientoInventarioDet
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoMovimientoInventarioDet))
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.pnlserie = New System.Windows.Forms.Panel()
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
    Me.btnnuevoserie = New System.Windows.Forms.ToolStripButton()
    Me.btneliserie = New System.Windows.Forms.ToolStripButton()
    Me.DGSeries = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BSSeries = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.pnldescto = New System.Windows.Forms.Panel()
    Me.chkaplicaiva = New Infoware.Controles.Base.CheckBoxStd()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtdescto = New Infoware.Controles.Base.TextBoxCalculator()
    Me.pnlvalor = New System.Windows.Forms.Panel()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtvalor = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.txtobservacion = New Infoware.Controles.Base.TextBoxStd()
    Me.ComboBoxUnidadMedida = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.CtlBuscaItem1 = New Incautacion.Modulo.CtlBuscaItem()
    Me.txtcantidad = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BindingSourceExistencias = New System.Windows.Forms.BindingSource(Me.components)
    Me.grpexistencias = New System.Windows.Forms.GroupBox()
    Me.DGExistencias = New System.Windows.Forms.DataGridView()
    Me.Panel3 = New System.Windows.Forms.Panel()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.pnlserie.SuspendLayout()
    Me.ToolStrip2.SuspendLayout()
    CType(Me.DGSeries, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSSeries, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnldescto.SuspendLayout()
    Me.pnlvalor.SuspendLayout()
    Me.Panel2.SuspendLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BindingSourceExistencias, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpexistencias.SuspendLayout()
    CType(Me.DGExistencias, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.pnlserie)
    Me.Panel1.Controls.Add(Me.pnldescto)
    Me.Panel1.Controls.Add(Me.pnlvalor)
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(384, 318)
    Me.Panel1.TabIndex = 0
    '
    'pnlserie
    '
    Me.pnlserie.Controls.Add(Me.ToolStrip2)
    Me.pnlserie.Controls.Add(Me.DGSeries)
    Me.pnlserie.Controls.Add(Me.Label6)
    Me.pnlserie.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlserie.Location = New System.Drawing.Point(0, 141)
    Me.pnlserie.Name = "pnlserie"
    Me.pnlserie.Size = New System.Drawing.Size(384, 177)
    Me.pnlserie.TabIndex = 3
    Me.pnlserie.Visible = False
    '
    'ToolStrip2
    '
    Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnuevoserie, Me.btneliserie})
    Me.ToolStrip2.Location = New System.Drawing.Point(139, 3)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(58, 25)
    Me.ToolStrip2.TabIndex = 1
    Me.ToolStrip2.Text = "ToolStrip2"
    '
    'btnnuevoserie
    '
    Me.btnnuevoserie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnnuevoserie.Image = CType(resources.GetObject("btnnuevoserie.Image"), System.Drawing.Image)
    Me.btnnuevoserie.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnnuevoserie.Name = "btnnuevoserie"
    Me.btnnuevoserie.Size = New System.Drawing.Size(23, 22)
    Me.btnnuevoserie.Text = "ToolStripButton1"
    '
    'btneliserie
    '
    Me.btneliserie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btneliserie.Image = CType(resources.GetObject("btneliserie.Image"), System.Drawing.Image)
    Me.btneliserie.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btneliserie.Name = "btneliserie"
    Me.btneliserie.Size = New System.Drawing.Size(23, 22)
    Me.btneliserie.Text = "ToolStripButton2"
    '
    'DGSeries
    '
    Me.DGSeries.AgruparRepetidos = False
    Me.DGSeries.AllowUserToAddRows = False
    Me.DGSeries.AllowUserToDeleteRows = False
    Me.DGSeries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.DGSeries.AutoGenerateColumns = False
    Me.DGSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DGSeries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7})
    Me.DGSeries.DataSource = Me.BSSeries
    Me.DGSeries.Location = New System.Drawing.Point(139, 31)
    Me.DGSeries.Name = "DGSeries"
    Me.DGSeries.Size = New System.Drawing.Size(233, 134)
    Me.DGSeries.TabIndex = 0
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(12, 9)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(97, 13)
    Me.Label6.TabIndex = 0
    Me.Label6.Text = "Series individuales:"
    '
    'pnldescto
    '
    Me.pnldescto.Controls.Add(Me.chkaplicaiva)
    Me.pnldescto.Controls.Add(Me.Label3)
    Me.pnldescto.Controls.Add(Me.Label2)
    Me.pnldescto.Controls.Add(Me.txtdescto)
    Me.pnldescto.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldescto.Location = New System.Drawing.Point(0, 116)
    Me.pnldescto.Name = "pnldescto"
    Me.pnldescto.Size = New System.Drawing.Size(384, 25)
    Me.pnldescto.TabIndex = 2
    '
    'chkaplicaiva
    '
    Me.chkaplicaiva.AutoSize = True
    Me.chkaplicaiva.Location = New System.Drawing.Point(271, 4)
    Me.chkaplicaiva.Name = "chkaplicaiva"
    Me.chkaplicaiva.Size = New System.Drawing.Size(75, 17)
    Me.chkaplicaiva.TabIndex = 3
    Me.chkaplicaiva.Text = "Aplica IVA"
    Me.chkaplicaiva.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(233, 5)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(15, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "%"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 5)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(62, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Descuento:"
    '
    'txtdescto
    '
    Me.txtdescto.Location = New System.Drawing.Point(139, 2)
    Me.txtdescto.Mensaje = ""
    Me.txtdescto.Name = "txtdescto"
    Me.txtdescto.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdescto.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdescto.PromptText = ""
    Me.txtdescto.Size = New System.Drawing.Size(88, 20)
    Me.txtdescto.TabIndex = 1
    Me.txtdescto.Text = "0,00"
    Me.txtdescto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtdescto.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtdescto.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtdescto.Value = 0.0R
    '
    'pnlvalor
    '
    Me.pnlvalor.Controls.Add(Me.Label4)
    Me.pnlvalor.Controls.Add(Me.txtvalor)
    Me.pnlvalor.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlvalor.Location = New System.Drawing.Point(0, 91)
    Me.pnlvalor.Name = "pnlvalor"
    Me.pnlvalor.Size = New System.Drawing.Size(384, 25)
    Me.pnlvalor.TabIndex = 1
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 3)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(34, 13)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "Valor:"
    '
    'txtvalor
    '
    Me.txtvalor.Location = New System.Drawing.Point(139, 1)
    Me.txtvalor.Mensaje = ""
    Me.txtvalor.Name = "txtvalor"
    Me.txtvalor.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvalor.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvalor.PromptText = ""
    Me.txtvalor.Size = New System.Drawing.Size(88, 20)
    Me.txtvalor.TabIndex = 1
    Me.txtvalor.Text = "0,00"
    Me.txtvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtvalor.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvalor.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtvalor.Value = 0.0R
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.txtobservacion)
    Me.Panel2.Controls.Add(Me.ComboBoxUnidadMedida)
    Me.Panel2.Controls.Add(Me.CtlBuscaItem1)
    Me.Panel2.Controls.Add(Me.txtcantidad)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Controls.Add(Me.Label5)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(384, 91)
    Me.Panel2.TabIndex = 0
    '
    'txtobservacion
    '
    Me.txtobservacion.Location = New System.Drawing.Point(139, 39)
    Me.txtobservacion.Mensaje = ""
    Me.txtobservacion.Name = "txtobservacion"
    Me.txtobservacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtobservacion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtobservacion.PromptText = ""
    Me.txtobservacion.Size = New System.Drawing.Size(233, 20)
    Me.txtobservacion.TabIndex = 4
    Me.txtobservacion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'ComboBoxUnidadMedida
    '
    Me.ComboBoxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxUnidadMedida.FormattingEnabled = True
    Me.ComboBoxUnidadMedida.Location = New System.Drawing.Point(233, 64)
    Me.ComboBoxUnidadMedida.Name = "ComboBoxUnidadMedida"
    Me.ComboBoxUnidadMedida.OperadorDatos = Nothing
    Me.ComboBoxUnidadMedida.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxUnidadMedida.ParametroDet = Nothing
    Me.ComboBoxUnidadMedida.PuedeActualizar = True
    Me.ComboBoxUnidadMedida.PuedeEliminar = True
    Me.ComboBoxUnidadMedida.PuedeModificar = True
    Me.ComboBoxUnidadMedida.PuedeNuevo = True
    Me.ComboBoxUnidadMedida.Size = New System.Drawing.Size(139, 21)
    Me.ComboBoxUnidadMedida.TabIndex = 7
    '
    'CtlBuscaItem1
    '
    Me.CtlBuscaItem1.Item = Nothing
    Me.CtlBuscaItem1.ItemText = "Item"
    Me.CtlBuscaItem1.Location = New System.Drawing.Point(15, 11)
    Me.CtlBuscaItem1.Name = "CtlBuscaItem1"
    Me.CtlBuscaItem1.PardetTipoInventario = Nothing
    Me.CtlBuscaItem1.Size = New System.Drawing.Size(357, 22)
    Me.CtlBuscaItem1.TabIndex = 0
    Me.CtlBuscaItem1.Ubicacion = Incautacion.Modulo.CtlBuscaItem.EnumUbicacion.Normal
    '
    'txtcantidad
    '
    Me.txtcantidad.Location = New System.Drawing.Point(139, 65)
    Me.txtcantidad.Mensaje = ""
    Me.txtcantidad.Name = "txtcantidad"
    Me.txtcantidad.NumeroDecimales = 5
    Me.txtcantidad.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcantidad.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcantidad.PromptText = ""
    Me.txtcantidad.Size = New System.Drawing.Size(88, 20)
    Me.txtcantidad.TabIndex = 6
    Me.txtcantidad.Text = "0,00"
    Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtcantidad.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtcantidad.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtcantidad.Value = 0.0R
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 42)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(70, 13)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Observación:"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(12, 68)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(52, 13)
    Me.Label5.TabIndex = 5
    Me.Label5.Text = "Cantidad:"
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    '
    'PictureBox1
    '
    Me.PictureBox1.Location = New System.Drawing.Point(6, 8)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(115, 126)
    Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.PictureBox1.TabIndex = 5
    Me.PictureBox1.TabStop = False
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
    'grpexistencias
    '
    Me.grpexistencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.grpexistencias.Controls.Add(Me.DGExistencias)
    Me.grpexistencias.Location = New System.Drawing.Point(6, 144)
    Me.grpexistencias.Name = "grpexistencias"
    Me.grpexistencias.Size = New System.Drawing.Size(306, 162)
    Me.grpexistencias.TabIndex = 8
    Me.grpexistencias.TabStop = False
    Me.grpexistencias.Text = "Existencias"
    '
    'DGExistencias
    '
    Me.DGExistencias.AllowUserToAddRows = False
    Me.DGExistencias.AllowUserToDeleteRows = False
    Me.DGExistencias.AutoGenerateColumns = False
    Me.DGExistencias.BackgroundColor = System.Drawing.SystemColors.Window
    Me.DGExistencias.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.DGExistencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
    Me.DGExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DGExistencias.DataSource = Me.BindingSourceExistencias
    Me.DGExistencias.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DGExistencias.Location = New System.Drawing.Point(3, 16)
    Me.DGExistencias.MultiSelect = False
    Me.DGExistencias.Name = "DGExistencias"
    Me.DGExistencias.RowTemplate.Height = 25
    Me.DGExistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.DGExistencias.Size = New System.Drawing.Size(300, 143)
    Me.DGExistencias.StandardTab = True
    Me.DGExistencias.TabIndex = 0
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.grpexistencias)
    Me.Panel3.Controls.Add(Me.PictureBox1)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
    Me.Panel3.Location = New System.Drawing.Point(384, 49)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(324, 318)
    Me.Panel3.TabIndex = 4
    '
    'FrmMantenimientoMovimientoInventarioDet
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(708, 367)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.Panel3)
    Me.MinimumSize = New System.Drawing.Size(716, 401)
    Me.Name = "FrmMantenimientoMovimientoInventarioDet"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Controls.SetChildIndex(Me.Panel3, 0)
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.pnlserie.ResumeLayout(False)
    Me.pnlserie.PerformLayout()
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    CType(Me.DGSeries, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSSeries, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnldescto.ResumeLayout(False)
    Me.pnldescto.PerformLayout()
    Me.pnlvalor.ResumeLayout(False)
    Me.pnlvalor.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BindingSourceExistencias, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpexistencias.ResumeLayout(False)
    CType(Me.DGExistencias, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents txtcantidad As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents CtlBuscaItem1 As CtlBuscaItem
  Friend WithEvents pnlvalor As System.Windows.Forms.Panel
  Friend WithEvents ComboBoxUnidadMedida As ComboBoxParametroDet
  Friend WithEvents pnldescto As System.Windows.Forms.Panel
  Friend WithEvents chkaplicaiva As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtdescto As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtvalor As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents txtobservacion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents pnlserie As System.Windows.Forms.Panel
  Friend WithEvents DGSeries As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents BSSeries As System.Windows.Forms.BindingSource
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnnuevoserie As System.Windows.Forms.ToolStripButton
  Friend WithEvents btneliserie As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents BindingSourceExistencias As System.Windows.Forms.BindingSource
  Friend WithEvents grpexistencias As System.Windows.Forms.GroupBox
  Private WithEvents DGExistencias As System.Windows.Forms.DataGridView
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
