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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.tbdatos = New System.Windows.Forms.TabPage()
        Me.CtlMovimientoInventarioDet2 = New Incautacion.Modulo.CtlMovimientoInventarioDet()
        Me.CtlMantenimientoMovimientoInventarioDet1 = New Incautacion.Modulo.CtlMantenimientoMovimientoInventarioDet()
    Me.tbTouch = New System.Windows.Forms.TabPage()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.CtlGruposTouch1 = New Incautacion.Modulo.CtlGruposTouch()
        Me.CtlItemsTouch1 = New Incautacion.Modulo.CtlItemsTouch()
    Me.TabControl1.SuspendLayout()
    Me.tbdatos.SuspendLayout()
    CType(Me.CtlMovimientoInventarioDet2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tbTouch.SuspendLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.tbdatos)
    Me.TabControl1.Controls.Add(Me.tbTouch)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.ItemSize = New System.Drawing.Size(150, 20)
    Me.TabControl1.Location = New System.Drawing.Point(0, 0)
    Me.TabControl1.Multiline = True
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(650, 353)
    Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
    Me.TabControl1.TabIndex = 0
    Me.TabControl1.TabStop = False
    '
    'tbdatos
    '
    Me.tbdatos.Controls.Add(Me.CtlMovimientoInventarioDet2)
    Me.tbdatos.Controls.Add(Me.CtlMantenimientoMovimientoInventarioDet1)
    Me.tbdatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.tbdatos.Location = New System.Drawing.Point(4, 24)
    Me.tbdatos.Name = "tbdatos"
    Me.tbdatos.Padding = New System.Windows.Forms.Padding(3)
    Me.tbdatos.Size = New System.Drawing.Size(642, 325)
    Me.tbdatos.TabIndex = 0
    Me.tbdatos.Text = "Datos"
    Me.tbdatos.UseVisualStyleBackColor = True
    '
    'CtlMovimientoInventarioDet2
    '
    Me.CtlMovimientoInventarioDet2.AllowUserToAddRows = False
    Me.CtlMovimientoInventarioDet2.AllowUserToDeleteRows = False
    Me.CtlMovimientoInventarioDet2.AutoGenerateColumns = False
    Me.CtlMovimientoInventarioDet2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.CtlMovimientoInventarioDet2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlMovimientoInventarioDet2.FactorTamanio = New Decimal(New Integer() {1, 0, 0, 0})
    Me.CtlMovimientoInventarioDet2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CtlMovimientoInventarioDet2.Location = New System.Drawing.Point(3, 117)
    Me.CtlMovimientoInventarioDet2.MovimientoInventario = Nothing
    Me.CtlMovimientoInventarioDet2.Name = "CtlMovimientoInventarioDet2"
    Me.CtlMovimientoInventarioDet2.PardetTipoPago = Nothing
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.CtlMovimientoInventarioDet2.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.CtlMovimientoInventarioDet2.Size = New System.Drawing.Size(636, 205)
    Me.CtlMovimientoInventarioDet2.TabIndex = 1
    Me.CtlMovimientoInventarioDet2.TabStop = False
    Me.CtlMovimientoInventarioDet2.Venta = Nothing
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
    Me.CtlMantenimientoMovimientoInventarioDet1.Size = New System.Drawing.Size(636, 114)
    Me.CtlMantenimientoMovimientoInventarioDet1.TabIndex = 0
    '
    'tbTouch
    '
    Me.tbTouch.Controls.Add(Me.SplitContainer1)
    Me.tbTouch.Location = New System.Drawing.Point(4, 24)
    Me.tbTouch.Name = "tbTouch"
    Me.tbTouch.Padding = New System.Windows.Forms.Padding(3)
    Me.tbTouch.Size = New System.Drawing.Size(642, 325)
    Me.tbTouch.TabIndex = 1
    Me.tbTouch.Text = "Productos"
    Me.tbTouch.UseVisualStyleBackColor = True
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
    Me.SplitContainer1.Name = "SplitContainer1"
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.CtlGruposTouch1)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.CtlItemsTouch1)
    Me.SplitContainer1.Size = New System.Drawing.Size(636, 319)
    Me.SplitContainer1.SplitterDistance = 280
    Me.SplitContainer1.TabIndex = 0
    Me.SplitContainer1.TabStop = False
    '
    'CtlGruposTouch1
    '
    Me.CtlGruposTouch1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlGruposTouch1.Grupo = Nothing
    Me.CtlGruposTouch1.Location = New System.Drawing.Point(0, 0)
    Me.CtlGruposTouch1.Name = "CtlGruposTouch1"
    Me.CtlGruposTouch1.OperadorDatos = Nothing
    Me.CtlGruposTouch1.Size = New System.Drawing.Size(280, 319)
    Me.CtlGruposTouch1.TabIndex = 0
    Me.CtlGruposTouch1.TabStop = False
    Me.CtlGruposTouch1.TipoInventario = Nothing
    '
    'CtlItemsTouch1
    '
    Me.CtlItemsTouch1.Cantidad = 1
    Me.CtlItemsTouch1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlItemsTouch1.Grupo = Nothing
    Me.CtlItemsTouch1.Item = Nothing
    Me.CtlItemsTouch1.Location = New System.Drawing.Point(0, 0)
    Me.CtlItemsTouch1.Name = "CtlItemsTouch1"
    Me.CtlItemsTouch1.OperadorDatos = Nothing
    Me.CtlItemsTouch1.SegundaLinea = Nothing
    Me.CtlItemsTouch1.Size = New System.Drawing.Size(352, 319)
    Me.CtlItemsTouch1.SoloUno = False
    Me.CtlItemsTouch1.TabIndex = 0
    Me.CtlItemsTouch1.TabStop = False
    Me.CtlItemsTouch1.TipoInventario = Nothing
    '
    'CtlMovimientoInventarioDet1
    '
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
    Me.Controls.Add(Me.TabControl1)
    Me.Name = "CtlMovimientoInventarioDet1"
    Me.Size = New System.Drawing.Size(650, 353)
    Me.TabControl1.ResumeLayout(False)
    Me.tbdatos.ResumeLayout(False)
    CType(Me.CtlMovimientoInventarioDet2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tbTouch.ResumeLayout(False)
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents tbdatos As System.Windows.Forms.TabPage
  Friend WithEvents tbTouch As System.Windows.Forms.TabPage
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
  Friend WithEvents CtlGruposTouch1 As CtlGruposTouch
  Friend WithEvents CtlItemsTouch1 As CtlItemsTouch
  Public WithEvents CtlMovimientoInventarioDet2 As CtlMovimientoInventarioDet
  Friend WithEvents CtlMantenimientoMovimientoInventarioDet1 As CtlMantenimientoMovimientoInventarioDet

End Class
