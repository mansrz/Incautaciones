<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlCuentaBancaria
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.ComboBoxParametroDet1 = New ComboBoxParametroDet
    Me.ComboBoxCuentaBancaria = New System.Windows.Forms.ComboBox
    Me.SuspendLayout()
    '
    'ComboBoxParametroDet1
    '
    Me.ComboBoxParametroDet1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ComboBoxParametroDet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDet1.FormattingEnabled = True
    Me.ComboBoxParametroDet1.Location = New System.Drawing.Point(0, 3)
    Me.ComboBoxParametroDet1.Name = "ComboBoxParametroDet1"
    Me.ComboBoxParametroDet1.OperadorDatos = Nothing
    Me.ComboBoxParametroDet1.Parametro = Reglas.Enumerados.EnumParametros.Banco
    Me.ComboBoxParametroDet1.ParametroDet = Nothing
    Me.ComboBoxParametroDet1.PuedeActualizar = True
    Me.ComboBoxParametroDet1.PuedeEliminar = True
    Me.ComboBoxParametroDet1.PuedeModificar = True
    Me.ComboBoxParametroDet1.PuedeNuevo = True
    Me.ComboBoxParametroDet1.Size = New System.Drawing.Size(314, 23)
    Me.ComboBoxParametroDet1.TabIndex = 9
    '
    'ComboBoxCuentaBancaria
    '
    Me.ComboBoxCuentaBancaria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ComboBoxCuentaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxCuentaBancaria.FormattingEnabled = True
    Me.ComboBoxCuentaBancaria.Location = New System.Drawing.Point(0, 32)
    Me.ComboBoxCuentaBancaria.Name = "ComboBoxCuentaBancaria"
    Me.ComboBoxCuentaBancaria.Size = New System.Drawing.Size(314, 23)
    Me.ComboBoxCuentaBancaria.TabIndex = 11
    '
    'CtlCuentaBancaria
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.ComboBoxCuentaBancaria)
    Me.Controls.Add(Me.ComboBoxParametroDet1)
    Me.Name = "CtlCuentaBancaria"
    Me.Size = New System.Drawing.Size(314, 60)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents ComboBoxParametroDet1 As ComboBoxParametroDet
  Friend WithEvents ComboBoxCuentaBancaria As System.Windows.Forms.ComboBox

End Class
