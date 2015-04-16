<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlIncautacionDet
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
    Me.pnlaccion = New System.Windows.Forms.Panel()
    Me.btnquitar = New System.Windows.Forms.Button()
    Me.btnagregar = New System.Windows.Forms.Button()
    Me.GridComboBox1 = New Incautacion.Modulo.GridComboBox()
    Me.pnlaccion.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlaccion
    '
    Me.pnlaccion.Controls.Add(Me.btnquitar)
    Me.pnlaccion.Controls.Add(Me.btnagregar)
    Me.pnlaccion.Location = New System.Drawing.Point(649, 6)
    Me.pnlaccion.Name = "pnlaccion"
    Me.pnlaccion.Size = New System.Drawing.Size(156, 25)
    Me.pnlaccion.TabIndex = 6
    '
    'btnquitar
    '
    Me.btnquitar.Location = New System.Drawing.Point(81, -1)
    Me.btnquitar.Name = "btnquitar"
    Me.btnquitar.Size = New System.Drawing.Size(75, 23)
    Me.btnquitar.TabIndex = 1
    Me.btnquitar.Text = "Quitar"
    Me.btnquitar.UseVisualStyleBackColor = True
    '
    'btnagregar
    '
    Me.btnagregar.Location = New System.Drawing.Point(0, -1)
    Me.btnagregar.Name = "btnagregar"
    Me.btnagregar.Size = New System.Drawing.Size(75, 23)
    Me.btnagregar.TabIndex = 0
    Me.btnagregar.Text = "Agregar"
    Me.btnagregar.UseVisualStyleBackColor = True
    '
    'GridComboBox1
    '
    Me.GridComboBox1.Location = New System.Drawing.Point(-10, 27)
    Me.GridComboBox1.Name = "GridComboBox1"
    Me.GridComboBox1.Size = New System.Drawing.Size(842, 242)
    Me.GridComboBox1.TabIndex = 0
    '
    'CtlIncautacionDet
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.pnlaccion)
    Me.Controls.Add(Me.GridComboBox1)
    Me.Name = "CtlIncautacionDet"
    Me.Size = New System.Drawing.Size(821, 277)
    Me.pnlaccion.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GridComboBox1 As Incautacion.Modulo.GridComboBox
  Friend WithEvents pnlaccion As System.Windows.Forms.Panel
  Friend WithEvents btnquitar As System.Windows.Forms.Button
  Friend WithEvents btnagregar As System.Windows.Forms.Button

End Class
