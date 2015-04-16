<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnalisisCartera
  Inherits Infoware.Consola.Base.FrmReporteBase

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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dtfecdesde = New System.Windows.Forms.DateTimePicker()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtperiodo1 = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtperiodo2 = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtperiodo3 = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.rdocarteravcto = New System.Windows.Forms.RadioButton()
    Me.rdocarteravcda = New System.Windows.Forms.RadioButton()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.rdocxc = New System.Windows.Forms.RadioButton()
    Me.rdocxp = New System.Windows.Forms.RadioButton()
    Me.BarraEmpresa1 = New BarraEmpresa()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.SuspendLayout()
    Me.pnlcuerpo.Controls.SetChildIndex(Me.Panel1, 0)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Panel3)
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Controls.Add(Me.GroupBox1)
    Me.Panel1.Controls.Add(Me.dtfecdesde)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Size = New System.Drawing.Size(580, 162)
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 10)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(58, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Cortado al:"
    '
    'dtfecdesde
    '
    Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecdesde.Location = New System.Drawing.Point(87, 7)
    Me.dtfecdesde.Name = "dtfecdesde"
    Me.dtfecdesde.Size = New System.Drawing.Size(91, 20)
    Me.dtfecdesde.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(19, 16)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(52, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Periodo 1"
    '
    'txtperiodo1
    '
    Me.txtperiodo1.Location = New System.Drawing.Point(45, 38)
    Me.txtperiodo1.Mensaje = ""
    Me.txtperiodo1.Name = "txtperiodo1"
    Me.txtperiodo1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtperiodo1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtperiodo1.PromptText = ""
    Me.txtperiodo1.Size = New System.Drawing.Size(44, 20)
    Me.txtperiodo1.TabIndex = 2
    Me.txtperiodo1.Text = "30"
    Me.txtperiodo1.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtperiodo1.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtperiodo1.Value = 30.0R
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(19, 41)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(19, 13)
    Me.Label3.TabIndex = 1
    Me.Label3.Text = "0 -"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(113, 16)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(52, 13)
    Me.Label4.TabIndex = 3
    Me.Label4.Text = "Periodo 2"
    '
    'txtperiodo2
    '
    Me.txtperiodo2.Location = New System.Drawing.Point(154, 38)
    Me.txtperiodo2.Mensaje = ""
    Me.txtperiodo2.Name = "txtperiodo2"
    Me.txtperiodo2.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtperiodo2.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtperiodo2.PromptText = ""
    Me.txtperiodo2.Size = New System.Drawing.Size(44, 20)
    Me.txtperiodo2.TabIndex = 5
    Me.txtperiodo2.Text = "60"
    Me.txtperiodo2.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtperiodo2.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtperiodo2.Value = 60.0R
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(113, 41)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(35, 13)
    Me.Label5.TabIndex = 4
    Me.Label5.Text = "Hasta"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(220, 16)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(52, 13)
    Me.Label6.TabIndex = 6
    Me.Label6.Text = "Periodo 3"
    '
    'txtperiodo3
    '
    Me.txtperiodo3.Location = New System.Drawing.Point(261, 38)
    Me.txtperiodo3.Mensaje = ""
    Me.txtperiodo3.Name = "txtperiodo3"
    Me.txtperiodo3.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtperiodo3.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtperiodo3.PromptText = ""
    Me.txtperiodo3.Size = New System.Drawing.Size(44, 20)
    Me.txtperiodo3.TabIndex = 8
    Me.txtperiodo3.Text = "90"
    Me.txtperiodo3.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtperiodo3.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtperiodo3.Value = 90.0R
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(220, 41)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(35, 13)
    Me.Label7.TabIndex = 7
    Me.Label7.Text = "Hasta"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(326, 16)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(52, 13)
    Me.Label8.TabIndex = 9
    Me.Label8.Text = "Periodo 4"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(326, 41)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(64, 13)
    Me.Label9.TabIndex = 10
    Me.Label9.Text = "En adelante"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.Label9)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.Label7)
    Me.GroupBox1.Controls.Add(Me.Label6)
    Me.GroupBox1.Controls.Add(Me.Label5)
    Me.GroupBox1.Controls.Add(Me.Label8)
    Me.GroupBox1.Controls.Add(Me.txtperiodo3)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Controls.Add(Me.txtperiodo2)
    Me.GroupBox1.Controls.Add(Me.txtperiodo1)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(405, 65)
    Me.GroupBox1.TabIndex = 2
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Intervalor de días"
    '
    'rdocarteravcto
    '
    Me.rdocarteravcto.AutoSize = True
    Me.rdocarteravcto.Checked = True
    Me.rdocarteravcto.Location = New System.Drawing.Point(3, 3)
    Me.rdocarteravcto.Name = "rdocarteravcto"
    Me.rdocarteravcto.Size = New System.Drawing.Size(113, 17)
    Me.rdocarteravcto.TabIndex = 0
    Me.rdocarteravcto.TabStop = True
    Me.rdocarteravcto.Text = "Cartera por vencer"
    Me.rdocarteravcto.UseVisualStyleBackColor = True
    '
    'rdocarteravcda
    '
    Me.rdocarteravcda.AutoSize = True
    Me.rdocarteravcda.Location = New System.Drawing.Point(158, 3)
    Me.rdocarteravcda.Name = "rdocarteravcda"
    Me.rdocarteravcda.Size = New System.Drawing.Size(100, 17)
    Me.rdocarteravcda.TabIndex = 1
    Me.rdocarteravcda.Text = "Cartera vencida"
    Me.rdocarteravcda.UseVisualStyleBackColor = True
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.rdocarteravcto)
    Me.Panel2.Controls.Add(Me.rdocarteravcda)
    Me.Panel2.Location = New System.Drawing.Point(12, 102)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(333, 25)
    Me.Panel2.TabIndex = 3
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.rdocxc)
    Me.Panel3.Controls.Add(Me.rdocxp)
    Me.Panel3.Location = New System.Drawing.Point(12, 133)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(333, 25)
    Me.Panel3.TabIndex = 4
    '
    'rdocxc
    '
    Me.rdocxc.AutoSize = True
    Me.rdocxc.Checked = True
    Me.rdocxc.Location = New System.Drawing.Point(3, 3)
    Me.rdocxc.Name = "rdocxc"
    Me.rdocxc.Size = New System.Drawing.Size(115, 17)
    Me.rdocxc.TabIndex = 0
    Me.rdocxc.TabStop = True
    Me.rdocxc.Text = "Cuentas por cobrar"
    Me.rdocxc.UseVisualStyleBackColor = True
    '
    'rdocxp
    '
    Me.rdocxp.AutoSize = True
    Me.rdocxp.Location = New System.Drawing.Point(158, 3)
    Me.rdocxp.Name = "rdocxp"
    Me.rdocxp.Size = New System.Drawing.Size(112, 17)
    Me.rdocxp.TabIndex = 1
    Me.rdocxp.Text = "Cuentas por pagar"
    Me.rdocxp.UseVisualStyleBackColor = True
    '
    'BarraEmpresa1
    '
    Me.BarraEmpresa1.Empresa = Nothing
    Me.BarraEmpresa1.EmpresaVisible = True
    Me.BarraEmpresa1.Location = New System.Drawing.Point(0, 49)
    Me.BarraEmpresa1.Name = "BarraEmpresa1"
    'Me.BarraEmpresa1.RegContableVisible = False
    'Me.BarraEmpresa1.RegistroContable = Nothing
    Me.BarraEmpresa1.Sistema = Nothing
    Me.BarraEmpresa1.Size = New System.Drawing.Size(580, 25)
    Me.BarraEmpresa1.Sucursal = Nothing
    Me.BarraEmpresa1.SucursalVisible = False
    Me.BarraEmpresa1.TabIndex = 5
    Me.BarraEmpresa1.Text = "BarraEmpresa1"
    '
    'FrmAnalisisCartera
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(580, 382)
    Me.Controls.Add(Me.BarraEmpresa1)
    Me.Name = "FrmAnalisisCartera"
    Me.PuedeImprimir = True
    Me.Controls.SetChildIndex(Me.pnlcuerpo, 0)
    Me.Controls.SetChildIndex(Me.BarraEmpresa1, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtperiodo1 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtperiodo3 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtperiodo2 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents rdocxc As System.Windows.Forms.RadioButton
  Friend WithEvents rdocxp As System.Windows.Forms.RadioButton
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents rdocarteravcto As System.Windows.Forms.RadioButton
  Friend WithEvents rdocarteravcda As System.Windows.Forms.RadioButton
  Friend WithEvents BarraEmpresa1 As BarraEmpresa

End Class
