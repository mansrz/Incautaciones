<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoBodega
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
    Me.CtlEntidadLugar1 = New Incautacion.Modulo.CtlEntidadLugar()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.chkprincipal = New System.Windows.Forms.CheckBox()
    Me.Panel1 = New System.Windows.Forms.Panel()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'CtlEntidadLugar1
    '
    Me.CtlEntidadLugar1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlEntidadLugar1.EntidadLugar = Nothing
    Me.CtlEntidadLugar1.Location = New System.Drawing.Point(3, 3)
    Me.CtlEntidadLugar1.Name = "CtlEntidadLugar1"
    Me.CtlEntidadLugar1.PuedeSRI = False
    Me.CtlEntidadLugar1.Size = New System.Drawing.Size(628, 270)
    Me.CtlEntidadLugar1.TabIndex = 0
    Me.CtlEntidadLugar1.TipoLugar = Incautacion.Reglas.Enumerados.EnumTipoLugar.Sucursal
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 49)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(642, 328)
    Me.TabControl1.TabIndex = 0
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.CtlEntidadLugar1)
    Me.TabPage1.Controls.Add(Me.Panel1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(634, 302)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Principal"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'chkprincipal
    '
    Me.chkprincipal.AutoSize = True
    Me.chkprincipal.Location = New System.Drawing.Point(5, 3)
    Me.chkprincipal.Name = "chkprincipal"
    Me.chkprincipal.Size = New System.Drawing.Size(66, 17)
    Me.chkprincipal.TabIndex = 1
    Me.chkprincipal.Text = "Principal"
    Me.chkprincipal.UseVisualStyleBackColor = True
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.chkprincipal)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Panel1.Location = New System.Drawing.Point(3, 273)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(628, 26)
    Me.Panel1.TabIndex = 2
    '
    'FrmMantenimientoBodega
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(642, 377)
    Me.Controls.Add(Me.TabControl1)
    Me.Name = "FrmMantenimientoBodega"
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Controls.SetChildIndex(Me.TabControl1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CtlEntidadLugar1 As CtlEntidadLugar
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents chkprincipal As System.Windows.Forms.CheckBox
  Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
