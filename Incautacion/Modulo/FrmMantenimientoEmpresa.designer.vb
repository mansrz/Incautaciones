<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoEmpresa
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
    Me.components = New System.ComponentModel.Container
    Me.ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.pnlcuerpo1 = New System.Windows.Forms.Panel
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.TabPage1 = New System.Windows.Forms.TabPage
    Me.TabPage2 = New System.Windows.Forms.TabPage
    Me.BarraEmpresa1 = New BarraEmpresa
    Me.CtlPersona1 = New CtlPersona
    Me.CtlBuscaEntidadContador = New CtlBuscaEntidad2
    Me.pnlcuerpo.SuspendLayout()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo1.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.pnlcuerpo1)
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 74)
    Me.pnlcuerpo.Size = New System.Drawing.Size(597, 397)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.pnlcuerpo1, 0)
    '
    'pnlcuerpo1
    '
    Me.pnlcuerpo1.Controls.Add(Me.TabControl1)
    Me.pnlcuerpo1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlcuerpo1.Enabled = False
    Me.pnlcuerpo1.Location = New System.Drawing.Point(0, 25)
    Me.pnlcuerpo1.Name = "pnlcuerpo1"
    Me.pnlcuerpo1.Padding = New System.Windows.Forms.Padding(5)
    Me.pnlcuerpo1.Size = New System.Drawing.Size(597, 372)
    Me.pnlcuerpo1.TabIndex = 0
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(5, 5)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(587, 362)
    Me.TabControl1.TabIndex = 3
    Me.TabControl1.TabStop = False
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.CtlPersona1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(579, 336)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Datos de la empresa"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.CtlBuscaEntidadContador)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Size = New System.Drawing.Size(579, 336)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Datos adicionales"
    Me.TabPage2.UseVisualStyleBackColor = True
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
    Me.BarraEmpresa1.Size = New System.Drawing.Size(597, 25)
    Me.BarraEmpresa1.Sucursal = Nothing
    Me.BarraEmpresa1.SucursalVisible = False
    Me.BarraEmpresa1.TabIndex = 3
    Me.BarraEmpresa1.Text = "BarraEmpresa1"
    '
    'CtlPersona1
    '
    Me.CtlPersona1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlPersona1.Entidad = Nothing
    Me.CtlPersona1.Location = New System.Drawing.Point(3, 3)
    Me.CtlPersona1.Name = "CtlPersona1"
    Me.CtlPersona1.PuedeElegirTipoEntidad = False
    Me.CtlPersona1.PuedeRegistrarPersonacomo = True
    Me.CtlPersona1.PuedeSRI = False
    Me.CtlPersona1.Size = New System.Drawing.Size(573, 330)
    Me.CtlPersona1.TabIndex = 2
    '
    'CtlBuscaEntidadContador
    '
    Me.CtlBuscaEntidadContador.Entidad = Nothing
    Me.CtlBuscaEntidadContador.EntidadJuridica = Nothing
    Me.CtlBuscaEntidadContador.EntidadNatural = Nothing
    Me.CtlBuscaEntidadContador.EntidadText = "Contador"
    Me.CtlBuscaEntidadContador.Location = New System.Drawing.Point(8, 10)
    Me.CtlBuscaEntidadContador.Name = "CtlBuscaEntidadContador"
    Me.CtlBuscaEntidadContador.OperadorDatos = Nothing
    Me.CtlBuscaEntidadContador.Size = New System.Drawing.Size(358, 25)
    Me.CtlBuscaEntidadContador.TabIndex = 0
    Me.CtlBuscaEntidadContador.TipoEntidad = CtlBuscaEntidad2.EnumTipoEntidad.EntidadNatural
    '
    'FrmMantenimientoEmpresa
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(597, 471)
    Me.Controls.Add(Me.BarraEmpresa1)
    Me.Name = "FrmMantenimientoEmpresa"
    Me.Text = "Empresa"
    Me.Controls.SetChildIndex(Me.BarraEmpresa1, 0)
    Me.Controls.SetChildIndex(Me.pnlcuerpo, 0)
    Me.pnlcuerpo.ResumeLayout(False)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo1.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ListBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents pnlcuerpo1 As System.Windows.Forms.Panel
  Friend WithEvents CtlPersona1 As CtlPersona
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents CtlBuscaEntidadContador As CtlBuscaEntidad2
  Friend WithEvents BarraEmpresa1 As BarraEmpresa
End Class
