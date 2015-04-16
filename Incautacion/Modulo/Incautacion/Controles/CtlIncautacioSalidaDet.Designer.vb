<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlIncautacioSalidaDet
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.GridComboBox1 = New Incautacion.Modulo.GridComboBox()
    Me.SuspendLayout()
    '
    'GridComboBox1
    '
    Me.GridComboBox1.Location = New System.Drawing.Point(-10, 0)
    Me.GridComboBox1.Name = "GridComboBox1"
    Me.GridComboBox1.Size = New System.Drawing.Size(821, 242)
    Me.GridComboBox1.TabIndex = 0
    '
    'CtlIncautacioSalidaDet
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.GridComboBox1)
    Me.Name = "CtlIncautacioSalidaDet"
    Me.Size = New System.Drawing.Size(814, 248)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GridComboBox1 As Incautacion.Modulo.GridComboBox

End Class
