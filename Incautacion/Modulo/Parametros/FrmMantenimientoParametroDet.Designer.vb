<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoParametroDet
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
    Me.components = New System.ComponentModel.Container
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.pnldatoimg = New System.Windows.Forms.Panel
    Me.PictureBox1 = New Infoware.Controles.Base.ImagenSQL
    Me.lbl_datoimg1 = New System.Windows.Forms.Label
    Me.pnldatoint = New System.Windows.Forms.Panel
    Me.txtdatoint1 = New Infoware.Controles.Base.TextBoxCalculator
    Me.lbl_datoint1 = New System.Windows.Forms.Label
    Me.pnldatostr3 = New System.Windows.Forms.Panel
    Me.txt_datostr3 = New Infoware.Controles.Base.TextBoxStd
    Me.lbl_datostr3 = New System.Windows.Forms.Label
    Me.pnldatostr2 = New System.Windows.Forms.Panel
    Me.txt_datostr2 = New Infoware.Controles.Base.TextBoxStd
    Me.lbl_datostr2 = New System.Windows.Forms.Label
    Me.pnldatostr1 = New System.Windows.Forms.Panel
    Me.txt_datostr1 = New Infoware.Controles.Base.TextBoxStd
    Me.lbl_datostr1 = New System.Windows.Forms.Label
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.TextBoxStd1 = New Infoware.Controles.Base.TextBoxStd
    Me.Label1 = New System.Windows.Forms.Label
    Me.pnldatoleyenda = New System.Windows.Forms.Panel
    Me.txt_datoleyenda = New Infoware.Controles.Base.TextBoxStd
    Me.lbl_datoleyenda = New System.Windows.Forms.Label
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.pnldatoimg.SuspendLayout()
    Me.pnldatoint.SuspendLayout()
    Me.pnldatostr3.SuspendLayout()
    Me.pnldatostr2.SuspendLayout()
    Me.pnldatostr1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.pnldatoleyenda.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.pnldatoleyenda)
    Me.Panel1.Controls.Add(Me.pnldatoimg)
    Me.Panel1.Controls.Add(Me.pnldatoint)
    Me.Panel1.Controls.Add(Me.pnldatostr3)
    Me.Panel1.Controls.Add(Me.pnldatostr2)
    Me.Panel1.Controls.Add(Me.pnldatostr1)
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(459, 394)
    Me.Panel1.TabIndex = 4
    '
    'pnldatoimg
    '
    Me.pnldatoimg.Controls.Add(Me.PictureBox1)
    Me.pnldatoimg.Controls.Add(Me.lbl_datoimg1)
    Me.pnldatoimg.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatoimg.Location = New System.Drawing.Point(0, 186)
    Me.pnldatoimg.Name = "pnldatoimg"
    Me.pnldatoimg.Size = New System.Drawing.Size(459, 118)
    Me.pnldatoimg.TabIndex = 7
    Me.pnldatoimg.Visible = False
    '
    'PictureBox1
    '
    Me.PictureBox1.ArchivoImagen = Nothing
    Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
    Me.PictureBox1.Imagen = Nothing
    Me.PictureBox1.Location = New System.Drawing.Point(139, 4)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Padding = New System.Windows.Forms.Padding(3)
    Me.PictureBox1.Size = New System.Drawing.Size(116, 105)
    Me.PictureBox1.TabIndex = 1
    Me.PictureBox1.TabStop = False
    '
    'lbl_datoimg1
    '
    Me.lbl_datoimg1.AutoSize = True
    Me.lbl_datoimg1.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datoimg1.Name = "lbl_datoimg1"
    Me.lbl_datoimg1.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datoimg1.TabIndex = 0
    Me.lbl_datoimg1.Text = "Descripción:"
    '
    'pnldatoint
    '
    Me.pnldatoint.Controls.Add(Me.txtdatoint1)
    Me.pnldatoint.Controls.Add(Me.lbl_datoint1)
    Me.pnldatoint.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatoint.Location = New System.Drawing.Point(0, 111)
    Me.pnldatoint.Name = "pnldatoint"
    Me.pnldatoint.Size = New System.Drawing.Size(459, 25)
    Me.pnldatoint.TabIndex = 4
    Me.pnldatoint.Visible = False
    '
    'txtdatoint1
    '
    Me.txtdatoint1.Location = New System.Drawing.Point(139, 3)
    Me.txtdatoint1.Mensaje = ""
    Me.txtdatoint1.Name = "txtdatoint1"
    Me.txtdatoint1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdatoint1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdatoint1.PromptText = ""
    Me.txtdatoint1.Size = New System.Drawing.Size(66, 20)
    Me.txtdatoint1.TabIndex = 1
    Me.txtdatoint1.Text = "0"
    Me.txtdatoint1.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtdatoint1.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtdatoint1.Value = 0
    '
    'lbl_datoint1
    '
    Me.lbl_datoint1.AutoSize = True
    Me.lbl_datoint1.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datoint1.Name = "lbl_datoint1"
    Me.lbl_datoint1.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datoint1.TabIndex = 0
    Me.lbl_datoint1.Text = "Descripción:"
    '
    'pnldatostr3
    '
    Me.pnldatostr3.Controls.Add(Me.txt_datostr3)
    Me.pnldatostr3.Controls.Add(Me.lbl_datostr3)
    Me.pnldatostr3.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatostr3.Location = New System.Drawing.Point(0, 86)
    Me.pnldatostr3.Name = "pnldatostr3"
    Me.pnldatostr3.Size = New System.Drawing.Size(459, 25)
    Me.pnldatostr3.TabIndex = 3
    Me.pnldatostr3.Visible = False
    '
    'txt_datostr3
    '
    Me.txt_datostr3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_datostr3.Location = New System.Drawing.Point(139, 3)
    Me.txt_datostr3.Mensaje = ""
    Me.txt_datostr3.Name = "txt_datostr3"
    Me.txt_datostr3.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_datostr3.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txt_datostr3.PromptText = ""
    Me.txt_datostr3.Size = New System.Drawing.Size(308, 20)
    Me.txt_datostr3.TabIndex = 1
    Me.txt_datostr3.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'lbl_datostr3
    '
    Me.lbl_datostr3.AutoSize = True
    Me.lbl_datostr3.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datostr3.Name = "lbl_datostr3"
    Me.lbl_datostr3.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datostr3.TabIndex = 0
    Me.lbl_datostr3.Text = "Descripción:"
    '
    'pnldatostr2
    '
    Me.pnldatostr2.Controls.Add(Me.txt_datostr2)
    Me.pnldatostr2.Controls.Add(Me.lbl_datostr2)
    Me.pnldatostr2.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatostr2.Location = New System.Drawing.Point(0, 61)
    Me.pnldatostr2.Name = "pnldatostr2"
    Me.pnldatostr2.Size = New System.Drawing.Size(459, 25)
    Me.pnldatostr2.TabIndex = 2
    Me.pnldatostr2.Visible = False
    '
    'txt_datostr2
    '
    Me.txt_datostr2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_datostr2.Location = New System.Drawing.Point(139, 3)
    Me.txt_datostr2.Mensaje = ""
    Me.txt_datostr2.Name = "txt_datostr2"
    Me.txt_datostr2.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_datostr2.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txt_datostr2.PromptText = ""
    Me.txt_datostr2.Size = New System.Drawing.Size(308, 20)
    Me.txt_datostr2.TabIndex = 1
    Me.txt_datostr2.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'lbl_datostr2
    '
    Me.lbl_datostr2.AutoSize = True
    Me.lbl_datostr2.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datostr2.Name = "lbl_datostr2"
    Me.lbl_datostr2.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datostr2.TabIndex = 0
    Me.lbl_datostr2.Text = "Descripción:"
    '
    'pnldatostr1
    '
    Me.pnldatostr1.Controls.Add(Me.txt_datostr1)
    Me.pnldatostr1.Controls.Add(Me.lbl_datostr1)
    Me.pnldatostr1.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatostr1.Location = New System.Drawing.Point(0, 36)
    Me.pnldatostr1.Name = "pnldatostr1"
    Me.pnldatostr1.Size = New System.Drawing.Size(459, 25)
    Me.pnldatostr1.TabIndex = 1
    Me.pnldatostr1.Visible = False
    '
    'txt_datostr1
    '
    Me.txt_datostr1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_datostr1.Location = New System.Drawing.Point(139, 3)
    Me.txt_datostr1.Mensaje = ""
    Me.txt_datostr1.Name = "txt_datostr1"
    Me.txt_datostr1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_datostr1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txt_datostr1.PromptText = ""
    Me.txt_datostr1.Size = New System.Drawing.Size(308, 20)
    Me.txt_datostr1.TabIndex = 1
    Me.txt_datostr1.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'lbl_datostr1
    '
    Me.lbl_datostr1.AutoSize = True
    Me.lbl_datostr1.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datostr1.Name = "lbl_datostr1"
    Me.lbl_datostr1.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datostr1.TabIndex = 0
    Me.lbl_datostr1.Text = "Descripción:"
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.TextBoxStd1)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(459, 36)
    Me.Panel2.TabIndex = 0
    '
    'TextBoxStd1
    '
    Me.TextBoxStd1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxStd1.Location = New System.Drawing.Point(139, 14)
    Me.TextBoxStd1.Mensaje = ""
    Me.TextBoxStd1.Name = "TextBoxStd1"
    Me.TextBoxStd1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxStd1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.TextBoxStd1.PromptText = ""
    Me.TextBoxStd1.Size = New System.Drawing.Size(308, 20)
    Me.TextBoxStd1.TabIndex = 1
    Me.TextBoxStd1.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 16)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(66, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Descripción:"
    '
    'pnldatoleyenda
    '
    Me.pnldatoleyenda.Controls.Add(Me.txt_datoleyenda)
    Me.pnldatoleyenda.Controls.Add(Me.lbl_datoleyenda)
    Me.pnldatoleyenda.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatoleyenda.Location = New System.Drawing.Point(0, 304)
    Me.pnldatoleyenda.Name = "pnldatoleyenda"
    Me.pnldatoleyenda.Size = New System.Drawing.Size(459, 78)
    Me.pnldatoleyenda.TabIndex = 8
    Me.pnldatoleyenda.Visible = False
    '
    'txt_datoleyenda
    '
    Me.txt_datoleyenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_datoleyenda.Location = New System.Drawing.Point(139, 3)
    Me.txt_datoleyenda.Mensaje = ""
    Me.txt_datoleyenda.Multiline = True
    Me.txt_datoleyenda.Name = "txt_datoleyenda"
    Me.txt_datoleyenda.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_datoleyenda.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txt_datoleyenda.PromptText = ""
    Me.txt_datoleyenda.Size = New System.Drawing.Size(308, 72)
    Me.txt_datoleyenda.TabIndex = 1
    Me.txt_datoleyenda.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'lbl_datoleyenda
    '
    Me.lbl_datoleyenda.AutoSize = True
    Me.lbl_datoleyenda.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datoleyenda.Name = "lbl_datoleyenda"
    Me.lbl_datoleyenda.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datoleyenda.TabIndex = 0
    Me.lbl_datoleyenda.Text = "Descripción:"
    '
    'FrmMantenimientoParametroDet
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(459, 443)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoParametroDet"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.pnldatoimg.ResumeLayout(False)
    Me.pnldatoimg.PerformLayout()
     Me.pnldatoint.ResumeLayout(False)
    Me.pnldatoint.PerformLayout()
    Me.pnldatostr3.ResumeLayout(False)
    Me.pnldatostr3.PerformLayout()
    Me.pnldatostr2.ResumeLayout(False)
    Me.pnldatostr2.PerformLayout()
    Me.pnldatostr1.ResumeLayout(False)
    Me.pnldatostr1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.pnldatoleyenda.ResumeLayout(False)
    Me.pnldatoleyenda.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents pnldatostr1 As System.Windows.Forms.Panel
  Friend WithEvents txt_datostr1 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents lbl_datostr1 As System.Windows.Forms.Label
  Friend WithEvents TextBoxStd1 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents pnldatoint As System.Windows.Forms.Panel
  Friend WithEvents txtdatoint1 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents lbl_datoint1 As System.Windows.Forms.Label
  Friend WithEvents pnldatostr2 As System.Windows.Forms.Panel
  Friend WithEvents txt_datostr2 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents lbl_datostr2 As System.Windows.Forms.Label
  Friend WithEvents pnldatostr3 As System.Windows.Forms.Panel
  Friend WithEvents txt_datostr3 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents lbl_datostr3 As System.Windows.Forms.Label
  Friend WithEvents pnldatoimg As System.Windows.Forms.Panel
  Friend WithEvents lbl_datoimg1 As System.Windows.Forms.Label
  Friend WithEvents PictureBox1 As Infoware.Controles.Base.ImagenSQL
  Friend WithEvents pnldatoleyenda As System.Windows.Forms.Panel
  Friend WithEvents txt_datoleyenda As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents lbl_datoleyenda As System.Windows.Forms.Label

End Class
