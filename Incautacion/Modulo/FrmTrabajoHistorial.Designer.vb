<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrabajoHistorial
  Inherits Infoware.Consola.Base.FrmMantenimientoSimpleBase

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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.CtlTrabajoLog1 = New Incautacion.Modulo.CtlTrabajoLog()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.pnlcuerpo.SuspendLayout()
    CType(Me.CtlTrabajoLog1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.CtlTrabajoLog1)
    Me.pnlcuerpo.Size = New System.Drawing.Size(571, 280)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.CtlTrabajoLog1, 0)
    '
    'CtlTrabajoLog1
    '
    Me.CtlTrabajoLog1.AgruparRepetidos = False
    Me.CtlTrabajoLog1.AllowUserToAddRows = False
    Me.CtlTrabajoLog1.AllowUserToDeleteRows = False
    Me.CtlTrabajoLog1.AutoGenerateColumns = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.CtlTrabajoLog1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.CtlTrabajoLog1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.CtlTrabajoLog1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.CtlTrabajoLog1.DefaultCellStyle = DataGridViewCellStyle2
    Me.CtlTrabajoLog1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlTrabajoLog1.Location = New System.Drawing.Point(0, 25)
    Me.CtlTrabajoLog1.Name = "CtlTrabajoLog1"
    Me.CtlTrabajoLog1.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.CtlTrabajoLog1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.CtlTrabajoLog1.RowHeadersVisible = False
    Me.CtlTrabajoLog1.Size = New System.Drawing.Size(571, 255)
    Me.CtlTrabajoLog1.TabIndex = 2
    Me.CtlTrabajoLog1.Trabajo = Nothing
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    '
    'FrmTrabajoHistorial
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(571, 329)
    Me.Name = "FrmTrabajoHistorial"
    Me.Text = "Historial"
    Me.pnlcuerpo.ResumeLayout(False)
    CType(Me.CtlTrabajoLog1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CtlTrabajoLog1 As Incautacion.Modulo.CtlTrabajoLog
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
