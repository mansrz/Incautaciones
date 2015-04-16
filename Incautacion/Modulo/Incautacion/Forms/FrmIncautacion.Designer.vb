<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIncautacion
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.CtlIncautacion1 = New Incautacion.Modulo.CtlIncautacion()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'CtlIncautacion1
    '
    Me.CtlIncautacion1.Location = New System.Drawing.Point(0, 53)
    Me.CtlIncautacion1.Name = "CtlIncautacion1"
    Me.CtlIncautacion1.Size = New System.Drawing.Size(858, 407)
    Me.CtlIncautacion1.TabIndex = 4
    '
    'FrmIncautacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(831, 472)
    Me.Controls.Add(Me.CtlIncautacion1)
    Me.Name = "FrmIncautacion"
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Text = "FrmIncautacion"
    Me.Controls.SetChildIndex(Me.CtlIncautacion1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CtlIncautacion1 As Incautacion.Modulo.CtlIncautacion
End Class
