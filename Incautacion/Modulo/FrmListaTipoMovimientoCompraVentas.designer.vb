<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaTipoMovimientoCompraVentas
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
    Me.Label1 = New System.Windows.Forms.Label
    Me.ComboBoxStd1 = New Infoware.Controles.Base.ComboBoxStd
    Me.BarraEmpresa1 = New BarraEmpresa
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 74)
    Me.pnlcuerpo.Size = New System.Drawing.Size(692, 392)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.ComboBoxStd1)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Size = New System.Drawing.Size(692, 51)
    Me.Panel1.Visible = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(99, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Tipo de movimiento"
    '
    'ComboBoxStd1
    '
    Me.ComboBoxStd1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxStd1.Items.AddRange(New Object() {"Compra", "Venta"})
    Me.ComboBoxStd1.Location = New System.Drawing.Point(131, 15)
    Me.ComboBoxStd1.Name = "ComboBoxStd1"
    Me.ComboBoxStd1.Size = New System.Drawing.Size(166, 21)
    Me.ComboBoxStd1.TabIndex = 3
    '
    'BarraEmpresa1
    '
    Me.BarraEmpresa1.Empresa = Nothing
    Me.BarraEmpresa1.EmpresaVisible = True
    Me.BarraEmpresa1.Location = New System.Drawing.Point(0, 0)
    Me.BarraEmpresa1.Name = "BarraEmpresa1"
    'Me.BarraEmpresa1.RegContableVisible = False
    'Me.BarraEmpresa1.RegistroContable = Nothing
    Me.BarraEmpresa1.Sistema = Nothing
    Me.BarraEmpresa1.Size = New System.Drawing.Size(692, 25)
    Me.BarraEmpresa1.Sucursal = Nothing
    Me.BarraEmpresa1.SucursalVisible = True
    Me.BarraEmpresa1.TabIndex = 3
    Me.BarraEmpresa1.Text = "BarraEmpresa1"
    '
    'FrmListaTipoMovimientoCompraVentas
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(692, 466)
    Me.Controls.Add(Me.BarraEmpresa1)
    Me.Name = "FrmListaTipoMovimientoCompraVentas"
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
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxStd1 As Infoware.Controles.Base.ComboBoxStd
  Friend WithEvents BarraEmpresa1 As BarraEmpresa

End Class
