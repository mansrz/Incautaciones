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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CtlMovimientoInventarioDet2 = New Incautacion.Modulo.CtlMovimientoInventarioDet()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtlMantenimientoMovimientoInventarioDet1 = New Incautacion.Modulo.CtlMantenimientoMovimientoInventarioDet()
        Me.Panel1.SuspendLayout()
        CType(Me.CtlMovimientoInventarioDet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CtlMovimientoInventarioDet2)
        Me.Panel1.Controls.Add(Me.CtlMantenimientoMovimientoInventarioDet1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 353)
        Me.Panel1.TabIndex = 0
        '
        'CtlMovimientoInventarioDet2
        '
        Me.CtlMovimientoInventarioDet2.AgruparRepetidos = False
        Me.CtlMovimientoInventarioDet2.AllowUserToAddRows = False
        Me.CtlMovimientoInventarioDet2.AllowUserToDeleteRows = False
        Me.CtlMovimientoInventarioDet2.AutoGenerateColumns = False
        Me.CtlMovimientoInventarioDet2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CtlMovimientoInventarioDet2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
        Me.CtlMovimientoInventarioDet2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlMovimientoInventarioDet2.FactorTamanio = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CtlMovimientoInventarioDet2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtlMovimientoInventarioDet2.Location = New System.Drawing.Point(0, 114)
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
        Me.CtlMovimientoInventarioDet2.Size = New System.Drawing.Size(650, 239)
        Me.CtlMovimientoInventarioDet2.TabIndex = 3
        Me.CtlMovimientoInventarioDet2.TabStop = False
        Me.CtlMovimientoInventarioDet2.Venta = Nothing
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'CtlMantenimientoMovimientoInventarioDet1
        '
        Me.CtlMantenimientoMovimientoInventarioDet1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlMantenimientoMovimientoInventarioDet1.enumTipoMovInv = Incautacion.Reglas.Enumerados.enumTipoMovInv.InvInicial
        Me.CtlMantenimientoMovimientoInventarioDet1.EsNuevo = False
        Me.CtlMantenimientoMovimientoInventarioDet1.Incautacion = Nothing
        Me.CtlMantenimientoMovimientoInventarioDet1.Item = Nothing
        Me.CtlMantenimientoMovimientoInventarioDet1.Location = New System.Drawing.Point(0, 0)
        Me.CtlMantenimientoMovimientoInventarioDet1.Margin = New System.Windows.Forms.Padding(6)
        Me.CtlMantenimientoMovimientoInventarioDet1.MovimientoInventarioDet = Nothing
        Me.CtlMantenimientoMovimientoInventarioDet1.Name = "CtlMantenimientoMovimientoInventarioDet1"
        Me.CtlMantenimientoMovimientoInventarioDet1.PardetTipoInventario = Nothing
        Me.CtlMantenimientoMovimientoInventarioDet1.PardetTipoPrecio = Nothing
        Me.CtlMantenimientoMovimientoInventarioDet1.Size = New System.Drawing.Size(650, 114)
        Me.CtlMantenimientoMovimientoInventarioDet1.TabIndex = 2
        Me.CtlMantenimientoMovimientoInventarioDet1.VerConfidencial = False
        '
        'CtlMovimientoInventarioDet1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CtlMovimientoInventarioDet1"
        Me.Size = New System.Drawing.Size(650, 353)
        Me.Panel1.ResumeLayout(False)
        CType(Me.CtlMovimientoInventarioDet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents CtlMovimientoInventarioDet2 As Incautacion.Modulo.CtlMovimientoInventarioDet
    Friend WithEvents CtlMantenimientoMovimientoInventarioDet1 As Incautacion.Modulo.CtlMantenimientoMovimientoInventarioDet
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
