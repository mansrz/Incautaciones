<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlMovimientoInventarioDet1
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
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.tbdatos = New System.Windows.Forms.TabPage()
    Me.GridComboBox1 = New Incautacion.Modulo.GridComboBox()
    Me.CtlMantenimientoMovimientoInventarioDet1 = New Incautacion.Modulo.CtlMantenimientoMovimientoInventarioDet()
    Me.TabControl1.SuspendLayout()
    Me.tbdatos.SuspendLayout()
    Me.SuspendLayout()
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.tbdatos)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.ItemSize = New System.Drawing.Size(250, 20)
    Me.TabControl1.Location = New System.Drawing.Point(0, 0)
    Me.TabControl1.Multiline = True
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1048, 353)
    Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
    Me.TabControl1.TabIndex = 1
    Me.TabControl1.TabStop = False
    '
    'tbdatos
    '
    Me.tbdatos.Controls.Add(Me.GridComboBox1)
    Me.tbdatos.Controls.Add(Me.CtlMantenimientoMovimientoInventarioDet1)
    Me.tbdatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.tbdatos.Location = New System.Drawing.Point(4, 24)
    Me.tbdatos.Name = "tbdatos"
    Me.tbdatos.Padding = New System.Windows.Forms.Padding(3)
    Me.tbdatos.Size = New System.Drawing.Size(1040, 325)
    Me.tbdatos.TabIndex = 0
    Me.tbdatos.Text = "Datos"
    Me.tbdatos.UseVisualStyleBackColor = True
    '
    'GridComboBox1
    '
    Me.GridComboBox1.Location = New System.Drawing.Point(-2, 154)
    Me.GridComboBox1.Name = "GridComboBox1"
    Me.GridComboBox1.Size = New System.Drawing.Size(948, 155)
    Me.GridComboBox1.TabIndex = 1
    '
    'CtlMantenimientoMovimientoInventarioDet1
    '
    Me.CtlMantenimientoMovimientoInventarioDet1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlMantenimientoMovimientoInventarioDet1.enumTipoMovInv = Incautacion.Reglas.Enumerados.enumTipoMovInv.InvInicial
    Me.CtlMantenimientoMovimientoInventarioDet1.Location = New System.Drawing.Point(3, 3)
    Me.CtlMantenimientoMovimientoInventarioDet1.Margin = New System.Windows.Forms.Padding(6)
    Me.CtlMantenimientoMovimientoInventarioDet1.MovimientoInventarioDet = Nothing
    Me.CtlMantenimientoMovimientoInventarioDet1.Name = "CtlMantenimientoMovimientoInventarioDet1"
    Me.CtlMantenimientoMovimientoInventarioDet1.PardetTipoInventario = Nothing
    Me.CtlMantenimientoMovimientoInventarioDet1.PardetTipoPrecio = Nothing
    Me.CtlMantenimientoMovimientoInventarioDet1.Size = New System.Drawing.Size(1034, 152)
    Me.CtlMantenimientoMovimientoInventarioDet1.TabIndex = 0
    Me.CtlMantenimientoMovimientoInventarioDet1.VerConfidencial = False
    '
    'CtlMovimientoInventarioDet1
    '
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
    Me.Controls.Add(Me.TabControl1)
    Me.Name = "CtlMovimientoInventarioDet1"
    Me.Size = New System.Drawing.Size(1048, 353)
    Me.TabControl1.ResumeLayout(False)
    Me.tbdatos.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents tbdatos As System.Windows.Forms.TabPage
  Friend WithEvents GridComboBox1 As Incautacion.Modulo.GridComboBox
  Friend WithEvents CtlMantenimientoMovimientoInventarioDet1 As Incautacion.Modulo.CtlMantenimientoMovimientoInventarioDet

End Class
