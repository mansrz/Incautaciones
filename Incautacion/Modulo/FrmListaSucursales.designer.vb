<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaSucursales
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
    Me.BarraEmpresa1 = New BarraEmpresa
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 74)
    Me.pnlcuerpo.Size = New System.Drawing.Size(692, 392)
    '
    'Panel1
    '
    Me.Panel1.Size = New System.Drawing.Size(692, 51)
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
    Me.BarraEmpresa1.Size = New System.Drawing.Size(692, 25)
    Me.BarraEmpresa1.Sucursal = Nothing
    Me.BarraEmpresa1.SucursalVisible = False
    Me.BarraEmpresa1.TabIndex = 3
    Me.BarraEmpresa1.Text = "BarraEmpresa1"
    '
    'FrmListaSucursales
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(692, 466)
    Me.Controls.Add(Me.BarraEmpresa1)
    Me.Name = "FrmListaSucursales"
    Me.PuedeEliminar = True
    Me.PuedeImprimir = True
    Me.PuedeNuevo = True
    Me.PuedeRefrescar = True
    Me.Controls.SetChildIndex(Me.BarraEmpresa1, 0)
    Me.Controls.SetChildIndex(Me.pnlcuerpo, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents BarraEmpresa1 As BarraEmpresa

End Class
