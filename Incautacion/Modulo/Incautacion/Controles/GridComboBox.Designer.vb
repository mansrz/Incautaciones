<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridComboBox
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
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
    Me.Column3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
    Me.Column4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
    Me.M = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.e = New System.Windows.Forms.DataGridViewComboBoxColumn()
    Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'DataGridView1
    '
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Cantidad, Me.Column2, Me.Column3, Me.Column4, Me.M, Me.Column5, Me.e, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
    Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.Size = New System.Drawing.Size(813, 212)
    Me.DataGridView1.TabIndex = 0
    '
    'Column1
    '
    Me.Column1.HeaderText = "Item"
    Me.Column1.MinimumWidth = 2
    Me.Column1.Name = "Column1"
    Me.Column1.Width = 40
    '
    'Cantidad
    '
    Me.Cantidad.HeaderText = "Cantidad"
    Me.Cantidad.Name = "Cantidad"
    Me.Cantidad.Width = 50
    '
    'Column2
    '
    Me.Column2.HeaderText = "Medida"
    Me.Column2.Name = "Column2"
    Me.Column2.Width = 60
    '
    'Column3
    '
    Me.Column3.HeaderText = "Descripcion"
    Me.Column3.Name = "Column3"
    Me.Column3.Width = 80
    '
    'Column4
    '
    Me.Column4.HeaderText = "Marca"
    Me.Column4.Name = "Column4"
    Me.Column4.Width = 80
    '
    'M
    '
    Me.M.HeaderText = "Modelo"
    Me.M.Name = "M"
    Me.M.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.M.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.M.Width = 80
    '
    'Column5
    '
    Me.Column5.HeaderText = "Serie"
    Me.Column5.Name = "Column5"
    Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.Column5.Width = 80
    '
    'e
    '
    Me.e.HeaderText = "Estado"
    Me.e.Name = "e"
    Me.e.Width = 60
    '
    'Column6
    '
    Me.Column6.HeaderText = "Valor Unitario"
    Me.Column6.Name = "Column6"
    Me.Column6.Width = 40
    '
    'Column7
    '
    Me.Column7.HeaderText = "Valor Total"
    Me.Column7.Name = "Column7"
    Me.Column7.Width = 40
    '
    'Column8
    '
    Me.Column8.HeaderText = "Caracteristicas"
    Me.Column8.Name = "Column8"
    '
    'Column9
    '
    Me.Column9.HeaderText = "Ubicacion"
    Me.Column9.Name = "Column9"
    Me.Column9.Width = 60
    '
    'GridComboBox
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.DataGridView1)
    Me.Name = "GridComboBox"
    Me.Size = New System.Drawing.Size(843, 242)
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
  Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column2 As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents Column3 As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents Column4 As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents M As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents e As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
