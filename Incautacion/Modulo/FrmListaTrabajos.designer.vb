<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaTrabajos
  Inherits Infoware.Consola.Base.FrmListaBase

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaTrabajos))
    Me.BarraEmpresa1 = New Incautacion.Modulo.BarraEmpresa()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnhistorial = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.lbl_totales = New System.Windows.Forms.ToolStripLabel()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.CheckBox1 = New System.Windows.Forms.CheckBox()
    Me.pnlrangofechas = New System.Windows.Forms.Panel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dtfecdesde = New System.Windows.Forms.DateTimePicker()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dtfechasta = New System.Windows.Forms.DateTimePicker()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.BarraEmpresa1.SuspendLayout()
    Me.pnlrangofechas.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 74)
    Me.pnlcuerpo.Size = New System.Drawing.Size(692, 392)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.pnlrangofechas)
    Me.Panel1.Controls.Add(Me.CheckBox1)
    Me.Panel1.Size = New System.Drawing.Size(692, 67)
    Me.Panel1.Visible = True
    '
    'BarraEmpresa1
    '
    Me.BarraEmpresa1.Empresa = Nothing
    Me.BarraEmpresa1.EmpresaVisible = True
    Me.BarraEmpresa1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnhistorial, Me.ToolStripSeparator2, Me.lbl_totales})
    Me.BarraEmpresa1.Location = New System.Drawing.Point(0, 49)
    Me.BarraEmpresa1.Name = "BarraEmpresa1"
    Me.BarraEmpresa1.Sistema = Nothing
    Me.BarraEmpresa1.Size = New System.Drawing.Size(692, 25)
    Me.BarraEmpresa1.Sucursal = Nothing
    Me.BarraEmpresa1.SucursalVisible = True
    Me.BarraEmpresa1.TabIndex = 3
    Me.BarraEmpresa1.Text = "BarraEmpresa1"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnhistorial
    '
    Me.btnhistorial.Image = CType(resources.GetObject("btnhistorial.Image"), System.Drawing.Image)
    Me.btnhistorial.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnhistorial.Name = "btnhistorial"
    Me.btnhistorial.Size = New System.Drawing.Size(71, 22)
    Me.btnhistorial.Text = "Historial"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'lbl_totales
    '
    Me.lbl_totales.Name = "lbl_totales"
    Me.lbl_totales.Size = New System.Drawing.Size(0, 22)
    '
    'Timer1
    '
    Me.Timer1.Enabled = True
    Me.Timer1.Interval = 5000
    '
    'CheckBox1
    '
    Me.CheckBox1.AutoSize = True
    Me.CheckBox1.Checked = True
    Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
    Me.CheckBox1.Location = New System.Drawing.Point(12, 7)
    Me.CheckBox1.Name = "CheckBox1"
    Me.CheckBox1.Size = New System.Drawing.Size(108, 17)
    Me.CheckBox1.TabIndex = 0
    Me.CheckBox1.Text = "Rango de fechas"
    Me.CheckBox1.UseVisualStyleBackColor = True
    '
    'pnlrangofechas
    '
    Me.pnlrangofechas.Controls.Add(Me.dtfechasta)
    Me.pnlrangofechas.Controls.Add(Me.Label2)
    Me.pnlrangofechas.Controls.Add(Me.dtfecdesde)
    Me.pnlrangofechas.Controls.Add(Me.Label1)
    Me.pnlrangofechas.Location = New System.Drawing.Point(12, 30)
    Me.pnlrangofechas.Name = "pnlrangofechas"
    Me.pnlrangofechas.Size = New System.Drawing.Size(457, 33)
    Me.pnlrangofechas.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(19, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(38, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Desde"
    '
    'dtfecdesde
    '
    Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecdesde.Location = New System.Drawing.Point(64, 6)
    Me.dtfecdesde.Name = "dtfecdesde"
    Me.dtfecdesde.Size = New System.Drawing.Size(113, 20)
    Me.dtfecdesde.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(194, 9)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(35, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Hasta"
    '
    'dtfechasta
    '
    Me.dtfechasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechasta.Location = New System.Drawing.Point(239, 6)
    Me.dtfechasta.Name = "dtfechasta"
    Me.dtfechasta.Size = New System.Drawing.Size(113, 20)
    Me.dtfechasta.TabIndex = 1
    '
    'FrmListaTrabajos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(692, 466)
    Me.Controls.Add(Me.BarraEmpresa1)
    Me.Name = "FrmListaTrabajos"
    Me.PuedeEliminar = True
    Me.PuedeImprimir = True
    Me.PuedeNuevo = True
    Me.PuedeRefrescar = True
    Me.Controls.SetChildIndex(Me.BarraEmpresa1, 0)
    Me.Controls.SetChildIndex(Me.pnlcuerpo, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.BarraEmpresa1.ResumeLayout(False)
    Me.BarraEmpresa1.PerformLayout()
    Me.pnlrangofechas.ResumeLayout(False)
    Me.pnlrangofechas.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents BarraEmpresa1 As BarraEmpresa
  Friend WithEvents Timer1 As System.Windows.Forms.Timer
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnhistorial As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents lbl_totales As System.Windows.Forms.ToolStripLabel
  Friend WithEvents pnlrangofechas As System.Windows.Forms.Panel
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
