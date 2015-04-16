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
    Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Medida = New System.Windows.Forms.DataGridViewComboBoxColumn()
    Me.Descripcion = New System.Windows.Forms.DataGridViewComboBoxColumn()
    Me.Marca = New System.Windows.Forms.DataGridViewComboBoxColumn()
    Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Estado = New System.Windows.Forms.DataGridViewComboBoxColumn()
    Me.ValorUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ValorTot = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Caract = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Ubica = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'DataGridView1
    '
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.Salida, Me.Cantidad, Me.Medida, Me.Descripcion, Me.Marca, Me.Modelo, Me.Serie, Me.Estado, Me.ValorUnit, Me.ValorTot, Me.Caract, Me.Ubica})
    Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.Size = New System.Drawing.Size(813, 212)
    Me.DataGridView1.TabIndex = 0
    '
    'Item
    '
    Me.Item.HeaderText = "Item"
    Me.Item.MinimumWidth = 2
    Me.Item.Name = "Item"
    Me.Item.Width = 40
    '
    'Salida
    '
    Me.Salida.HeaderText = "Egreso"
    Me.Salida.Name = "Salida"
    Me.Salida.Width = 50
    '
    'Cantidad
    '
    Me.Cantidad.HeaderText = "Cantidad"
    Me.Cantidad.Name = "Cantidad"
    Me.Cantidad.Width = 50
    '
    'Medida
    '
    Me.Medida.HeaderText = "Medida"
    Me.Medida.Name = "Medida"
    Me.Medida.Width = 60
    '
    'Descripcion
    '
    Me.Descripcion.HeaderText = "Descripcion"
    Me.Descripcion.Name = "Descripcion"
    Me.Descripcion.Width = 80
    '
    'Marca
    '
    Me.Marca.HeaderText = "Marca"
    Me.Marca.Name = "Marca"
    Me.Marca.Width = 80
    '
    'Modelo
    '
    Me.Modelo.HeaderText = "Modelo"
    Me.Modelo.Name = "Modelo"
    Me.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.Modelo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.Modelo.Width = 80
    '
    'Serie
    '
    Me.Serie.HeaderText = "Serie"
    Me.Serie.Name = "Serie"
    Me.Serie.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.Serie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.Serie.Width = 80
    '
    'Estado
    '
    Me.Estado.HeaderText = "Estado"
    Me.Estado.Name = "Estado"
    Me.Estado.Width = 60
    '
    'ValorUnit
    '
    Me.ValorUnit.HeaderText = "Valor Unitario"
    Me.ValorUnit.Name = "ValorUnit"
    Me.ValorUnit.Width = 40
    '
    'ValorTot
    '
    Me.ValorTot.HeaderText = "Valor Total"
    Me.ValorTot.Name = "ValorTot"
    Me.ValorTot.Width = 40
    '
    'Caract
    '
    Me.Caract.HeaderText = "Caracteristicas"
    Me.Caract.Name = "Caract"
    '
    'Ubica
    '
    Me.Ubica.HeaderText = "Ubicacion"
    Me.Ubica.Name = "Ubica"
    Me.Ubica.Width = 60
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
  Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Salida As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Medida As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents Marca As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Serie As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Estado As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents ValorUnit As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ValorTot As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Caract As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Ubica As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
