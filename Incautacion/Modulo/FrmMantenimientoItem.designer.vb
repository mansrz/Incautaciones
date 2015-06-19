<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoItem
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoItem))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.grpexistencias = New System.Windows.Forms.GroupBox()
        Me.DGExistencias = New System.Windows.Forms.DataGridView()
        Me.BindingSourceExistencias = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CtlBuscaContribuyente1 = New Incautacion.Modulo.CtlBuscaContribuyente()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSerie = New Infoware.Controles.Base.TextBoxStd()
        Me.CtlBuscaIncautacion1 = New Incautacion.Modulo.CtlBuscaIncautacion()
        Me.cboTipo = New Incautacion.Modulo.ComboBoxParametroDet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblcodigoauxiliar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtItemSencuencia = New Infoware.Controles.Base.TextBoxCalculator()
        Me.cboEstadoItem = New Incautacion.Modulo.ComboBoxParametroDet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxMarca1 = New Incautacion.Modulo.ComboBoxParametroDet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxUnidadMedida1 = New Incautacion.Modulo.ComboBoxParametroDet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtModelo = New Infoware.Controles.Base.TextBoxStd()
        Me.txtubicacion = New Infoware.Controles.Base.TextBoxStd()
        Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgPrecios = New Infoware.Consola.Base.DataGridViewAutoDiscover()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.btnnuevoPrecio = New System.Windows.Forms.ToolStripButton()
        Me.btnmodiPrecio = New System.Windows.Forms.ToolStripButton()
        Me.btnelimPrecio = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSPreciosxcantidad = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnReporte = New System.Windows.Forms.ToolStripDropDownButton()
        Me.KardexIndividualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComponentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsPrecios = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.grpexistencias.SuspendLayout()
        CType(Me.DGExistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceExistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.BSPreciosxcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.bsPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 625)
        Me.Panel1.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(492, 625)
        Me.TabControl1.TabIndex = 2
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(484, 599)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detalles"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.grpexistencias)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 314)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(478, 282)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'grpexistencias
        '
        Me.grpexistencias.Controls.Add(Me.DGExistencias)
        Me.grpexistencias.Location = New System.Drawing.Point(3, 3)
        Me.grpexistencias.Name = "grpexistencias"
        Me.grpexistencias.Size = New System.Drawing.Size(461, 33)
        Me.grpexistencias.TabIndex = 0
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGExistencias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGExistencias.DataSource = Me.BindingSourceExistencias
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGExistencias.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGExistencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGExistencias.Location = New System.Drawing.Point(3, 16)
        Me.DGExistencias.MultiSelect = False
        Me.DGExistencias.Name = "DGExistencias"
        Me.DGExistencias.RowTemplate.Height = 25
        Me.DGExistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGExistencias.Size = New System.Drawing.Size(455, 14)
        Me.DGExistencias.StandardTab = True
        Me.DGExistencias.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CtlBuscaContribuyente1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtSerie)
        Me.Panel2.Controls.Add(Me.CtlBuscaIncautacion1)
        Me.Panel2.Controls.Add(Me.cboTipo)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblcodigoauxiliar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtItemSencuencia)
        Me.Panel2.Controls.Add(Me.cboEstadoItem)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.ComboBoxMarca1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ComboBoxUnidadMedida1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtModelo)
        Me.Panel2.Controls.Add(Me.txtubicacion)
        Me.Panel2.Controls.Add(Me.txtdescripcion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(478, 311)
        Me.Panel2.TabIndex = 0
        '
        'CtlBuscaContribuyente1
        '
        Me.CtlBuscaContribuyente1.Contribuyente = Nothing
        Me.CtlBuscaContribuyente1.ContribuyenteText = "Contribuyente"
        Me.CtlBuscaContribuyente1.ItemText = "Contribuyente"
        Me.CtlBuscaContribuyente1.Location = New System.Drawing.Point(15, 7)
        Me.CtlBuscaContribuyente1.Name = "CtlBuscaContribuyente1"
        Me.CtlBuscaContribuyente1.Size = New System.Drawing.Size(314, 22)
        Me.CtlBuscaContribuyente1.TabIndex = 31
        Me.CtlBuscaContribuyente1.Ubicacion = Modulo.CtlBuscaContribuyente.EnumUbicacion.Normal
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Serie:"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(139, 197)
        Me.txtSerie.Mensaje = ""
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtSerie.PromptText = ""
        Me.txtSerie.Size = New System.Drawing.Size(159, 20)
        Me.txtSerie.TabIndex = 30
        '
        'CtlBuscaIncautacion1
        '
        Me.CtlBuscaIncautacion1.Contribuyente = Nothing
        Me.CtlBuscaIncautacion1.Incautacion = Nothing
        Me.CtlBuscaIncautacion1.IncautacionText = "Incautacion"
        Me.CtlBuscaIncautacion1.Location = New System.Drawing.Point(15, 35)
        Me.CtlBuscaIncautacion1.Name = "CtlBuscaIncautacion1"
        Me.CtlBuscaIncautacion1.Size = New System.Drawing.Size(314, 22)
        Me.CtlBuscaIncautacion1.Sucursal = Nothing
        Me.CtlBuscaIncautacion1.TabIndex = 28
        Me.CtlBuscaIncautacion1.Ubicacion = Modulo.CtlBuscaIncautacion.EnumUbicacion.Normal
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(139, 89)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.OperadorDatos = Nothing
        Me.cboTipo.Parametro = Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cboTipo.ParametroDet = Nothing
        Me.cboTipo.PuedeActualizar = True
        Me.cboTipo.PuedeEliminar = True
        Me.cboTipo.PuedeModificar = True
        Me.cboTipo.PuedeNuevo = True
        Me.cboTipo.Size = New System.Drawing.Size(159, 21)
        Me.cboTipo.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Descripción:"
        '
        'lblcodigoauxiliar
        '
        Me.lblcodigoauxiliar.AutoSize = True
        Me.lblcodigoauxiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigoauxiliar.Location = New System.Drawing.Point(338, 267)
        Me.lblcodigoauxiliar.Name = "lblcodigoauxiliar"
        Me.lblcodigoauxiliar.Size = New System.Drawing.Size(0, 24)
        Me.lblcodigoauxiliar.TabIndex = 25
        Me.lblcodigoauxiliar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número Item:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Características:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Modelo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Observación:"
        '
        'txtItemSencuencia
        '
        Me.txtItemSencuencia.Location = New System.Drawing.Point(139, 63)
        Me.txtItemSencuencia.Mensaje = ""
        Me.txtItemSencuencia.Name = "txtItemSencuencia"
        Me.txtItemSencuencia.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemSencuencia.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtItemSencuencia.PromptText = ""
        Me.txtItemSencuencia.Size = New System.Drawing.Size(81, 20)
        Me.txtItemSencuencia.TabIndex = 1
        Me.txtItemSencuencia.Text = "0"
        Me.txtItemSencuencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtItemSencuencia.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
        Me.txtItemSencuencia.Value = 0.0R
        '
        'cboEstadoItem
        '
        Me.cboEstadoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstadoItem.FormattingEnabled = True
        Me.cboEstadoItem.Location = New System.Drawing.Point(139, 222)
        Me.cboEstadoItem.Name = "cboEstadoItem"
        Me.cboEstadoItem.OperadorDatos = Nothing
        Me.cboEstadoItem.Parametro = Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cboEstadoItem.ParametroDet = Nothing
        Me.cboEstadoItem.PuedeActualizar = True
        Me.cboEstadoItem.PuedeEliminar = True
        Me.cboEstadoItem.PuedeModificar = True
        Me.cboEstadoItem.PuedeNuevo = True
        Me.cboEstadoItem.Size = New System.Drawing.Size(159, 21)
        Me.cboEstadoItem.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Unidad de medida:"
        '
        'ComboBoxMarca1
        '
        Me.ComboBoxMarca1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMarca1.FormattingEnabled = True
        Me.ComboBoxMarca1.Location = New System.Drawing.Point(139, 144)
        Me.ComboBoxMarca1.Name = "ComboBoxMarca1"
        Me.ComboBoxMarca1.OperadorDatos = Nothing
        Me.ComboBoxMarca1.Parametro = Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.ComboBoxMarca1.ParametroDet = Nothing
        Me.ComboBoxMarca1.PuedeActualizar = True
        Me.ComboBoxMarca1.PuedeEliminar = True
        Me.ComboBoxMarca1.PuedeModificar = True
        Me.ComboBoxMarca1.PuedeNuevo = True
        Me.ComboBoxMarca1.Size = New System.Drawing.Size(159, 21)
        Me.ComboBoxMarca1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Marca:"
        '
        'ComboBoxUnidadMedida1
        '
        Me.ComboBoxUnidadMedida1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUnidadMedida1.FormattingEnabled = True
        Me.ComboBoxUnidadMedida1.Location = New System.Drawing.Point(139, 275)
        Me.ComboBoxUnidadMedida1.Name = "ComboBoxUnidadMedida1"
        Me.ComboBoxUnidadMedida1.OperadorDatos = Nothing
        Me.ComboBoxUnidadMedida1.Parametro = Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.ComboBoxUnidadMedida1.ParametroDet = Nothing
        Me.ComboBoxUnidadMedida1.PuedeActualizar = True
        Me.ComboBoxUnidadMedida1.PuedeEliminar = True
        Me.ComboBoxUnidadMedida1.PuedeModificar = True
        Me.ComboBoxUnidadMedida1.PuedeNuevo = True
        Me.ComboBoxUnidadMedida1.Size = New System.Drawing.Size(159, 21)
        Me.ComboBoxUnidadMedida1.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Estado:"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(139, 171)
        Me.txtModelo.Mensaje = ""
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtModelo.PromptText = ""
        Me.txtModelo.Size = New System.Drawing.Size(159, 20)
        Me.txtModelo.TabIndex = 20
        '
        'txtubicacion
        '
        Me.txtubicacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtubicacion.Location = New System.Drawing.Point(139, 249)
        Me.txtubicacion.Mensaje = ""
        Me.txtubicacion.Name = "txtubicacion"
        Me.txtubicacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtubicacion.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtubicacion.PromptText = ""
        Me.txtubicacion.Size = New System.Drawing.Size(322, 20)
        Me.txtubicacion.TabIndex = 16
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdescripcion.Location = New System.Drawing.Point(139, 116)
        Me.txtdescripcion.Mensaje = ""
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtdescripcion.PromptText = ""
        Me.txtdescripcion.Size = New System.Drawing.Size(322, 22)
        Me.txtdescripcion.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(484, 599)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Precios"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgPrecios)
        Me.GroupBox5.Controls.Add(Me.ToolStrip3)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(478, 593)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Precios"
        '
        'dgPrecios
        '
        Me.dgPrecios.AgruparRepetidos = False
        Me.dgPrecios.AllowUserToAddRows = False
        Me.dgPrecios.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPrecios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPrecios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn31})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPrecios.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgPrecios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPrecios.Location = New System.Drawing.Point(3, 41)
        Me.dgPrecios.Name = "dgPrecios"
        Me.dgPrecios.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPrecios.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgPrecios.Size = New System.Drawing.Size(472, 549)
        Me.dgPrecios.TabIndex = 2
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnuevoPrecio, Me.btnmodiPrecio, Me.btnelimPrecio})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(472, 25)
        Me.ToolStrip3.TabIndex = 1
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'btnnuevoPrecio
        '
        Me.btnnuevoPrecio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnnuevoPrecio.Image = CType(resources.GetObject("btnnuevoPrecio.Image"), System.Drawing.Image)
        Me.btnnuevoPrecio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnuevoPrecio.Name = "btnnuevoPrecio"
        Me.btnnuevoPrecio.Size = New System.Drawing.Size(23, 22)
        Me.btnnuevoPrecio.Text = "Nuevo precio"
        '
        'btnmodiPrecio
        '
        Me.btnmodiPrecio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnmodiPrecio.Enabled = False
        Me.btnmodiPrecio.Image = CType(resources.GetObject("btnmodiPrecio.Image"), System.Drawing.Image)
        Me.btnmodiPrecio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnmodiPrecio.Name = "btnmodiPrecio"
        Me.btnmodiPrecio.Size = New System.Drawing.Size(23, 22)
        Me.btnmodiPrecio.Text = "Modificar resolución"
        '
        'btnelimPrecio
        '
        Me.btnelimPrecio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnelimPrecio.Enabled = False
        Me.btnelimPrecio.Image = CType(resources.GetObject("btnelimPrecio.Image"), System.Drawing.Image)
        Me.btnelimPrecio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnelimPrecio.Name = "btnelimPrecio"
        Me.btnelimPrecio.Size = New System.Drawing.Size(23, 22)
        Me.btnelimPrecio.Text = "Eliminar resolución"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReporte})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 49)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(492, 25)
        Me.ToolStrip2.TabIndex = 5
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnReporte
        '
        Me.btnReporte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KardexIndividualToolStripMenuItem, Me.ComponentesToolStripMenuItem})
        Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
        Me.btnReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReporte.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.btnReporte.MergeIndex = 5
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(82, 22)
        Me.btnReporte.Text = "Reportes"
        '
        'KardexIndividualToolStripMenuItem
        '
        Me.KardexIndividualToolStripMenuItem.Name = "KardexIndividualToolStripMenuItem"
        Me.KardexIndividualToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.KardexIndividualToolStripMenuItem.Text = "Kardex Individual"
        '
        'ComponentesToolStripMenuItem
        '
        Me.ComponentesToolStripMenuItem.Name = "ComponentesToolStripMenuItem"
        Me.ComponentesToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ComponentesToolStripMenuItem.Text = "Componentes ensamblados"
        '
        'FrmMantenimientoItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(492, 699)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "FrmMantenimientoItem"
        Me.PuedeGuardar = True
        Me.PuedeGuardarcerrar = True
        Me.PuedeGuardarnuevo = True
        Me.PuedeMover = True
        Me.Text = "Item"
        Me.Controls.SetChildIndex(Me.ToolStrip2, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.grpexistencias.ResumeLayout(False)
        CType(Me.DGExistencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceExistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.BSPreciosxcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.bsPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtItemSencuencia As Infoware.Controles.Base.TextBoxCalculator
    Friend WithEvents cboEstadoItem As ComboBoxParametroDet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMarca1 As ComboBoxParametroDet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxUnidadMedida1 As ComboBoxParametroDet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtubicacion As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents grpexistencias As System.Windows.Forms.GroupBox
    Friend WithEvents BindingSourceExistencias As System.Windows.Forms.BindingSource
    Private WithEvents DGExistencias As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtModelo As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents lblcodigoauxiliar As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnReporte As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents KardexIndividualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComponentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BSPreciosxcantidad As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnnuevoPrecio As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnmodiPrecio As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnelimPrecio As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents CtlBuscaIncautacion1 As Incautacion.Modulo.CtlBuscaIncautacion
    Friend WithEvents cboTipo As Incautacion.Modulo.ComboBoxParametroDet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CtlBuscaContribuyente1 As Incautacion.Modulo.CtlBuscaContribuyente
    Friend WithEvents dgPrecios As Infoware.Consola.Base.DataGridViewAutoDiscover
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsPrecios As System.Windows.Forms.BindingSource

End Class
