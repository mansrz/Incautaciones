<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoSucursal
  Inherits Infoware.Consola.Base.FrmMantenimientoSimpleBase

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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.pnlcuerpo1 = New System.Windows.Forms.Panel()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.CtlEntidadLugar1 = New Incautacion.Modulo.CtlEntidadLugar()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.CtlBuscaCliente1 = New Incautacion.Modulo.CtlBuscaCliente()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.pnlcuerpo.SuspendLayout()
    Me.pnlcuerpo1.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.pnlcuerpo1)
    Me.pnlcuerpo.Size = New System.Drawing.Size(563, 381)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.pnlcuerpo1, 0)
    '
    'pnlcuerpo1
    '
    Me.pnlcuerpo1.Controls.Add(Me.TabControl1)
    Me.pnlcuerpo1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlcuerpo1.Location = New System.Drawing.Point(0, 25)
    Me.pnlcuerpo1.Name = "pnlcuerpo1"
    Me.pnlcuerpo1.Padding = New System.Windows.Forms.Padding(5)
    Me.pnlcuerpo1.Size = New System.Drawing.Size(563, 356)
    Me.pnlcuerpo1.TabIndex = 4
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(5, 5)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(553, 346)
    Me.TabControl1.TabIndex = 1
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.CtlEntidadLugar1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(545, 320)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Datos"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'CtlEntidadLugar1
    '
    Me.CtlEntidadLugar1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlEntidadLugar1.EntidadLugar = Nothing
    Me.CtlEntidadLugar1.Location = New System.Drawing.Point(3, 3)
    Me.CtlEntidadLugar1.Name = "CtlEntidadLugar1"
    Me.CtlEntidadLugar1.PuedeSRI = False
    Me.CtlEntidadLugar1.Size = New System.Drawing.Size(539, 314)
    Me.CtlEntidadLugar1.TabIndex = 0
    Me.CtlEntidadLugar1.TipoLugar = Incautacion.Reglas.Enumerados.EnumTipoLugar.Sucursal
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.CtlBuscaCliente1)
    Me.TabPage2.Controls.Add(Me.GroupBox1)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(574, 456)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Configuración"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'CtlBuscaCliente1
    '
    Me.CtlBuscaCliente1.Cliente = Nothing
    Me.CtlBuscaCliente1.ClienteText = "Cliente contado"
    Me.CtlBuscaCliente1.ItemText = "Cliente contado"
    Me.CtlBuscaCliente1.Location = New System.Drawing.Point(8, 6)
    Me.CtlBuscaCliente1.Name = "CtlBuscaCliente1"
    Me.CtlBuscaCliente1.Size = New System.Drawing.Size(314, 25)
    Me.CtlBuscaCliente1.TabIndex = 0
    Me.CtlBuscaCliente1.Ubicacion = Incautacion.Modulo.CtlBuscaCliente.EnumUbicacion.Normal
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.DataGridView1)
    Me.GroupBox1.Location = New System.Drawing.Point(8, 37)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(314, 151)
    Me.GroupBox1.TabIndex = 1
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Relación forma de pago con precio"
    '
    'DataGridView1
    '
    Me.DataGridView1.AllowUserToAddRows = False
    Me.DataGridView1.AllowUserToDeleteRows = False
    Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
    Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
    Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.RowTemplate.Height = 25
    Me.DataGridView1.Size = New System.Drawing.Size(308, 132)
    Me.DataGridView1.TabIndex = 0
    '
    'FrmMantenimientoSucursal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(563, 430)
    Me.Name = "FrmMantenimientoSucursal"
    Me.Text = "Zona"
    Me.pnlcuerpo.ResumeLayout(False)
    Me.pnlcuerpo1.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents pnlcuerpo1 As System.Windows.Forms.Panel
  Friend WithEvents CtlEntidadLugar1 As CtlEntidadLugar
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents CtlBuscaCliente1 As CtlBuscaCliente
  Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
