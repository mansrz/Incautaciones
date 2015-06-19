<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoIncautacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoIncautacion))
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsResoluciones = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.tbIncautacion = New System.Windows.Forms.TabControl()
        Me.tpDatos = New System.Windows.Forms.TabPage()
        Me.txtObservacion = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCedula = New Infoware.Controles.Base.TextBoxStd()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTenedorNombre = New Infoware.Controles.Base.TextBoxStd()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha = New Infoware.Controles.Base.DateTimePickerStd()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumero = New Infoware.Controles.Base.TextBoxStd()
        Me.tpResolucion = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgResoluciones = New Infoware.Consola.Base.DataGridViewAutoDiscover()
        Me.DataGridViewTextBoxColumn94 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnnuevaResol = New System.Windows.Forms.ToolStripButton()
        Me.btnmodiResol = New System.Windows.Forms.ToolStripButton()
        Me.btnelimResol = New System.Windows.Forms.ToolStripButton()
        Me.CtlBuscaFedatario = New Incautacion.Modulo.CtlBuscaEmpleado()
        Me.CtlBuscaAdministrativo = New Incautacion.Modulo.CtlBuscaEmpleado()
        Me.CtlBuscaContribuyente1 = New Incautacion.Modulo.CtlBuscaContribuyente()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsResoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbIncautacion.SuspendLayout()
        Me.tpDatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpResolucion.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgResoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
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
        'tbIncautacion
        '
        Me.tbIncautacion.Controls.Add(Me.tpDatos)
        Me.tbIncautacion.Controls.Add(Me.tpResolucion)
        Me.tbIncautacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbIncautacion.Location = New System.Drawing.Point(0, 49)
        Me.tbIncautacion.Name = "tbIncautacion"
        Me.tbIncautacion.SelectedIndex = 0
        Me.tbIncautacion.Size = New System.Drawing.Size(346, 375)
        Me.tbIncautacion.TabIndex = 58
        '
        'tpDatos
        '
        Me.tpDatos.Controls.Add(Me.txtObservacion)
        Me.tpDatos.Controls.Add(Me.Label4)
        Me.tpDatos.Controls.Add(Me.GroupBox2)
        Me.tpDatos.Controls.Add(Me.GroupBox1)
        Me.tpDatos.Controls.Add(Me.dtpFecha)
        Me.tpDatos.Controls.Add(Me.Label1)
        Me.tpDatos.Controls.Add(Me.Label2)
        Me.tpDatos.Controls.Add(Me.txtNumero)
        Me.tpDatos.Controls.Add(Me.CtlBuscaContribuyente1)
        Me.tpDatos.Location = New System.Drawing.Point(4, 22)
        Me.tpDatos.Name = "tpDatos"
        Me.tpDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDatos.Size = New System.Drawing.Size(338, 349)
        Me.tpDatos.TabIndex = 0
        Me.tpDatos.Text = "Datos"
        Me.tpDatos.UseVisualStyleBackColor = True
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(9, 274)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(313, 62)
        Me.txtObservacion.TabIndex = 67
        Me.txtObservacion.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Observación:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CtlBuscaFedatario)
        Me.GroupBox2.Controls.Add(Me.CtlBuscaAdministrativo)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 73)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Funcionarios participantes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTenedorNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 75)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tenedor"
        '
        'txtCedula
        '
        Me.txtCedula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCedula.Location = New System.Drawing.Point(129, 47)
        Me.txtCedula.Mensaje = ""
        Me.txtCedula.Multiline = True
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtCedula.PromptText = ""
        Me.txtCedula.Size = New System.Drawing.Size(181, 22)
        Me.txtCedula.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Cedula:"
        '
        'txtTenedorNombre
        '
        Me.txtTenedorNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenedorNombre.Location = New System.Drawing.Point(129, 19)
        Me.txtTenedorNombre.Mensaje = ""
        Me.txtTenedorNombre.Multiline = True
        Me.txtTenedorNombre.Name = "txtTenedorNombre"
        Me.txtTenedorNombre.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenedorNombre.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtTenedorNombre.PromptText = ""
        Me.txtTenedorNombre.Size = New System.Drawing.Size(181, 22)
        Me.txtTenedorNombre.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Nombre:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(133, 62)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(189, 20)
        Me.dtpFecha.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "No. Incautación:"
        '
        'txtNumero
        '
        Me.txtNumero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumero.Location = New System.Drawing.Point(133, 34)
        Me.txtNumero.Mensaje = ""
        Me.txtNumero.Multiline = True
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtNumero.PromptText = ""
        Me.txtNumero.Size = New System.Drawing.Size(191, 22)
        Me.txtNumero.TabIndex = 60
        '
        'tpResolucion
        '
        Me.tpResolucion.Controls.Add(Me.GroupBox5)
        Me.tpResolucion.Location = New System.Drawing.Point(4, 22)
        Me.tpResolucion.Name = "tpResolucion"
        Me.tpResolucion.Padding = New System.Windows.Forms.Padding(3)
        Me.tpResolucion.Size = New System.Drawing.Size(338, 349)
        Me.tpResolucion.TabIndex = 1
        Me.tpResolucion.Text = "Resoluciones"
        Me.tpResolucion.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgResoluciones)
        Me.GroupBox5.Controls.Add(Me.ToolStrip2)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(332, 343)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Resoluciones"
        '
        'dgResoluciones
        '
        Me.dgResoluciones.AgruparRepetidos = False
        Me.dgResoluciones.AllowUserToAddRows = False
        Me.dgResoluciones.AllowUserToDeleteRows = False
        Me.dgResoluciones.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgResoluciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgResoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResoluciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn31})
        Me.dgResoluciones.DataSource = Me.bsResoluciones
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgResoluciones.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgResoluciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgResoluciones.Location = New System.Drawing.Point(3, 41)
        Me.dgResoluciones.Name = "dgResoluciones"
        Me.dgResoluciones.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgResoluciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgResoluciones.Size = New System.Drawing.Size(326, 299)
        Me.dgResoluciones.TabIndex = 0
        '
        'DataGridViewTextBoxColumn94
        '
        Me.DataGridViewTextBoxColumn94.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn94.Name = "DataGridViewTextBoxColumn94"
        Me.DataGridViewTextBoxColumn94.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnuevaResol, Me.btnmodiResol, Me.btnelimResol})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(326, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnnuevaResol
        '
        Me.btnnuevaResol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnnuevaResol.Image = CType(resources.GetObject("btnnuevaResol.Image"), System.Drawing.Image)
        Me.btnnuevaResol.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnuevaResol.Name = "btnnuevaResol"
        Me.btnnuevaResol.Size = New System.Drawing.Size(23, 22)
        Me.btnnuevaResol.Text = "Nueva resolución"
        '
        'btnmodiResol
        '
        Me.btnmodiResol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnmodiResol.Image = CType(resources.GetObject("btnmodiResol.Image"), System.Drawing.Image)
        Me.btnmodiResol.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnmodiResol.Name = "btnmodiResol"
        Me.btnmodiResol.Size = New System.Drawing.Size(23, 22)
        Me.btnmodiResol.Text = "Modificar resolución"
        '
        'btnelimResol
        '
        Me.btnelimResol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnelimResol.Image = CType(resources.GetObject("btnelimResol.Image"), System.Drawing.Image)
        Me.btnelimResol.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnelimResol.Name = "btnelimResol"
        Me.btnelimResol.Size = New System.Drawing.Size(23, 22)
        Me.btnelimResol.Text = "Eliminar resolución"
        '
        'CtlBuscaFedatario
        '
        Me.CtlBuscaFedatario.Empleado = Nothing
        Me.CtlBuscaFedatario.EmpleadoText = "Fedatario"
        Me.CtlBuscaFedatario.ItemText = "Fedatario"
        Me.CtlBuscaFedatario.Location = New System.Drawing.Point(6, 19)
        Me.CtlBuscaFedatario.Name = "CtlBuscaFedatario"
        Me.CtlBuscaFedatario.Size = New System.Drawing.Size(304, 22)
        Me.CtlBuscaFedatario.TabIndex = 47
        Me.CtlBuscaFedatario.TipoEmpleado = Nothing
        Me.CtlBuscaFedatario.Ubicacion = Modulo.CtlBuscaEmpleado.EnumUbicacion.Normal
        '
        'CtlBuscaAdministrativo
        '
        Me.CtlBuscaAdministrativo.Empleado = Nothing
        Me.CtlBuscaAdministrativo.EmpleadoText = "Administrativo"
        Me.CtlBuscaAdministrativo.ItemText = "Administrativo"
        Me.CtlBuscaAdministrativo.Location = New System.Drawing.Point(6, 47)
        Me.CtlBuscaAdministrativo.Name = "CtlBuscaAdministrativo"
        Me.CtlBuscaAdministrativo.Size = New System.Drawing.Size(304, 22)
        Me.CtlBuscaAdministrativo.TabIndex = 48
        Me.CtlBuscaAdministrativo.TipoEmpleado = Nothing
        Me.CtlBuscaAdministrativo.Ubicacion = Modulo.CtlBuscaEmpleado.EnumUbicacion.Normal
        '
        'CtlBuscaContribuyente1
        '
        Me.CtlBuscaContribuyente1.Contribuyente = Nothing
        Me.CtlBuscaContribuyente1.ContribuyenteText = "Contribuyente"
        Me.CtlBuscaContribuyente1.ItemText = "Contribuyente"
        Me.CtlBuscaContribuyente1.Location = New System.Drawing.Point(8, 6)
        Me.CtlBuscaContribuyente1.Name = "CtlBuscaContribuyente1"
        Me.CtlBuscaContribuyente1.Size = New System.Drawing.Size(316, 22)
        Me.CtlBuscaContribuyente1.TabIndex = 58
        Me.CtlBuscaContribuyente1.Ubicacion = Modulo.CtlBuscaContribuyente.EnumUbicacion.Normal
        '
        'FrmMantenimientoIncautacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(346, 424)
        Me.Controls.Add(Me.tbIncautacion)
        Me.Name = "FrmMantenimientoIncautacion"
        Me.PuedeGuardar = True
        Me.PuedeGuardarcerrar = True
        Me.PuedeGuardarnuevo = True
        Me.Text = "Incautación"
        Me.Controls.SetChildIndex(Me.tbIncautacion, 0)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsResoluciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbIncautacion.ResumeLayout(False)
        Me.tpDatos.ResumeLayout(False)
        Me.tpDatos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpResolucion.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgResoluciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsResoluciones As System.Windows.Forms.BindingSource
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
    Friend WithEvents tbIncautacion As System.Windows.Forms.TabControl
    Friend WithEvents tpDatos As System.Windows.Forms.TabPage
    Friend WithEvents txtObservacion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CtlBuscaFedatario As Incautacion.Modulo.CtlBuscaEmpleado
    Friend WithEvents CtlBuscaAdministrativo As Incautacion.Modulo.CtlBuscaEmpleado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTenedorNombre As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As Infoware.Controles.Base.DateTimePickerStd
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents tpResolucion As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dgResoluciones As Infoware.Consola.Base.DataGridViewAutoDiscover
    Friend WithEvents DataGridViewTextBoxColumn94 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnnuevaResol As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnmodiResol As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnelimResol As System.Windows.Forms.ToolStripButton
    Friend WithEvents CtlBuscaContribuyente1 As Incautacion.Modulo.CtlBuscaContribuyente
    Friend WithEvents txtCedula As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
