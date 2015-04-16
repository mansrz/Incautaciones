<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstadoCuenta
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
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.pnlproveedor = New System.Windows.Forms.Panel()
    Me.CtlBuscaProveedor1 = New CtlBuscaProveedor()
    Me.rdocxp = New System.Windows.Forms.RadioButton()
    Me.pnlcliente = New System.Windows.Forms.Panel()
    Me.CtlBuscaCliente1 = New CtlBuscaCliente()
    Me.rdocxc = New System.Windows.Forms.RadioButton()
    Me.chkelegirentidad = New Infoware.Controles.Base.CheckBoxStd()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dtfechasta = New System.Windows.Forms.DateTimePicker()
    Me.BarraEmpresa1 = New BarraEmpresa()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.pnlproveedor.SuspendLayout()
    Me.pnlcliente.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 74)
    Me.pnlcuerpo.Size = New System.Drawing.Size(773, 470)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.Panel1, 0)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.chkelegirentidad)
    Me.Panel1.Controls.Add(Me.Panel3)
    Me.Panel1.Controls.Add(Me.dtfechasta)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.dtfecdesde)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Size = New System.Drawing.Size(773, 139)
    Me.Panel1.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 10)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(41, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Desde:"
    '
    'dtfecdesde
    '
    Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecdesde.Location = New System.Drawing.Point(57, 7)
    Me.dtfecdesde.Name = "dtfecdesde"
    Me.dtfecdesde.Size = New System.Drawing.Size(91, 20)
    Me.dtfecdesde.TabIndex = 1
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.pnlproveedor)
    Me.Panel3.Controls.Add(Me.rdocxp)
    Me.Panel3.Controls.Add(Me.pnlcliente)
    Me.Panel3.Controls.Add(Me.rdocxc)
    Me.Panel3.Location = New System.Drawing.Point(15, 55)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(519, 81)
    Me.Panel3.TabIndex = 4
    '
    'pnlproveedor
    '
    Me.pnlproveedor.Controls.Add(Me.CtlBuscaProveedor1)
    Me.pnlproveedor.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlproveedor.Location = New System.Drawing.Point(0, 57)
    Me.pnlproveedor.Name = "pnlproveedor"
    Me.pnlproveedor.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
    Me.pnlproveedor.Size = New System.Drawing.Size(519, 23)
    Me.pnlproveedor.TabIndex = 3
    Me.pnlproveedor.Visible = False
    '
    'CtlBuscaProveedor1
    '
    Me.CtlBuscaProveedor1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlBuscaProveedor1.ItemText = "Proveedor"
    Me.CtlBuscaProveedor1.Location = New System.Drawing.Point(20, 0)
    Me.CtlBuscaProveedor1.Name = "CtlBuscaProveedor1"
    Me.CtlBuscaProveedor1.Proveedor = Nothing
    Me.CtlBuscaProveedor1.ProveedorText = "Proveedor"
    Me.CtlBuscaProveedor1.Size = New System.Drawing.Size(499, 22)
    Me.CtlBuscaProveedor1.TabIndex = 0
    Me.CtlBuscaProveedor1.Ubicacion = CtlBuscaProveedor.EnumUbicacion.Normal
    '
    'rdocxp
    '
    Me.rdocxp.AutoSize = True
    Me.rdocxp.Dock = System.Windows.Forms.DockStyle.Top
    Me.rdocxp.Location = New System.Drawing.Point(0, 40)
    Me.rdocxp.Name = "rdocxp"
    Me.rdocxp.Size = New System.Drawing.Size(519, 17)
    Me.rdocxp.TabIndex = 2
    Me.rdocxp.Text = "Cuentas por pagar"
    Me.rdocxp.UseVisualStyleBackColor = True
    '
    'pnlcliente
    '
    Me.pnlcliente.Controls.Add(Me.CtlBuscaCliente1)
    Me.pnlcliente.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlcliente.Location = New System.Drawing.Point(0, 17)
    Me.pnlcliente.Name = "pnlcliente"
    Me.pnlcliente.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
    Me.pnlcliente.Size = New System.Drawing.Size(519, 23)
    Me.pnlcliente.TabIndex = 1
    Me.pnlcliente.Visible = False
    '
    'CtlBuscaCliente1
    '
    Me.CtlBuscaCliente1.Cliente = Nothing
    Me.CtlBuscaCliente1.ClienteText = "Cliente"
    Me.CtlBuscaCliente1.Cursor = System.Windows.Forms.Cursors.Default
    Me.CtlBuscaCliente1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlBuscaCliente1.ItemText = "Cliente"
    Me.CtlBuscaCliente1.Location = New System.Drawing.Point(20, 0)
    Me.CtlBuscaCliente1.Name = "CtlBuscaCliente1"
    Me.CtlBuscaCliente1.Size = New System.Drawing.Size(499, 22)
    Me.CtlBuscaCliente1.TabIndex = 0
    Me.CtlBuscaCliente1.Ubicacion = CtlBuscaCliente.EnumUbicacion.Normal
    '
    'rdocxc
    '
    Me.rdocxc.AutoSize = True
    Me.rdocxc.Checked = True
    Me.rdocxc.Dock = System.Windows.Forms.DockStyle.Top
    Me.rdocxc.Location = New System.Drawing.Point(0, 0)
    Me.rdocxc.Name = "rdocxc"
    Me.rdocxc.Size = New System.Drawing.Size(519, 17)
    Me.rdocxc.TabIndex = 0
    Me.rdocxc.TabStop = True
    Me.rdocxc.Text = "Cuentas por cobrar"
    Me.rdocxc.UseVisualStyleBackColor = True
    '
    'chkelegirentidad
    '
    Me.chkelegirentidad.AutoSize = True
    Me.chkelegirentidad.Location = New System.Drawing.Point(15, 36)
    Me.chkelegirentidad.Name = "chkelegirentidad"
    Me.chkelegirentidad.Size = New System.Drawing.Size(171, 17)
    Me.chkelegirentidad.TabIndex = 4
    Me.chkelegirentidad.Text = "Seleccionar Cliente/Proveedor"
    Me.chkelegirentidad.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(194, 10)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(38, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Hasta:"
    '
    'dtfechasta
    '
    Me.dtfechasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechasta.Location = New System.Drawing.Point(237, 7)
    Me.dtfechasta.Name = "dtfechasta"
    Me.dtfechasta.Size = New System.Drawing.Size(91, 20)
    Me.dtfechasta.TabIndex = 3
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
    Me.BarraEmpresa1.Size = New System.Drawing.Size(773, 25)
    Me.BarraEmpresa1.Sucursal = Nothing
    Me.BarraEmpresa1.SucursalVisible = False
    Me.BarraEmpresa1.TabIndex = 4
    Me.BarraEmpresa1.Text = "BarraEmpresa1"
    '
    'FrmEstadoCuenta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(773, 544)
    Me.Controls.Add(Me.BarraEmpresa1)
    Me.Name = "FrmEstadoCuenta"
    Me.PuedeImprimir = True
    Me.Controls.SetChildIndex(Me.BarraEmpresa1, 0)
    Me.Controls.SetChildIndex(Me.pnlcuerpo, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.pnlproveedor.ResumeLayout(False)
    Me.pnlcliente.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents rdocxc As System.Windows.Forms.RadioButton
  Friend WithEvents rdocxp As System.Windows.Forms.RadioButton
  Friend WithEvents CtlBuscaCliente1 As CtlBuscaCliente
  Friend WithEvents CtlBuscaProveedor1 As CtlBuscaProveedor
  Friend WithEvents chkelegirentidad As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents pnlproveedor As System.Windows.Forms.Panel
  Friend WithEvents pnlcliente As System.Windows.Forms.Panel
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents BarraEmpresa1 As BarraEmpresa

End Class
