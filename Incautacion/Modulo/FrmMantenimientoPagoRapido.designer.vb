<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoPagoRapido
  Inherits Infoware.Consola.Base.FrmDialogoBase

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
    Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lbltotfactura = New System.Windows.Forms.Label()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.txtpagadoefectivo = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Panel4 = New System.Windows.Forms.Panel()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.lblvuelto = New System.Windows.Forms.Label()
    Me.FlowLayoutPanel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.Panel4.SuspendLayout()
    Me.SuspendLayout()
    '
    'FlowLayoutPanel1
    '
    Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
    Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
    Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
    Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
    Me.FlowLayoutPanel1.Size = New System.Drawing.Size(511, 254)
    Me.FlowLayoutPanel1.TabIndex = 0
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Controls.Add(Me.lbltotfactura)
    Me.Panel2.Location = New System.Drawing.Point(3, 3)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(508, 77)
    Me.Panel2.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(9, 30)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(247, 33)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Total de la deuda:"
    '
    'lbltotfactura
    '
    Me.lbltotfactura.BackColor = System.Drawing.Color.Black
    Me.lbltotfactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbltotfactura.ForeColor = System.Drawing.Color.Lime
    Me.lbltotfactura.Location = New System.Drawing.Point(266, 13)
    Me.lbltotfactura.Name = "lbltotfactura"
    Me.lbltotfactura.Size = New System.Drawing.Size(230, 64)
    Me.lbltotfactura.TabIndex = 1
    Me.lbltotfactura.Text = "$0,00"
    Me.lbltotfactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.txtpagadoefectivo)
    Me.Panel3.Controls.Add(Me.Label2)
    Me.Panel3.Location = New System.Drawing.Point(3, 86)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(508, 77)
    Me.Panel3.TabIndex = 1
    '
    'txtpagadoefectivo
    '
    Me.txtpagadoefectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
    Me.txtpagadoefectivo.Location = New System.Drawing.Point(264, 10)
    Me.txtpagadoefectivo.Mensaje = ""
    Me.txtpagadoefectivo.Name = "txtpagadoefectivo"
    Me.txtpagadoefectivo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtpagadoefectivo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtpagadoefectivo.PromptText = ""
    Me.txtpagadoefectivo.Size = New System.Drawing.Size(232, 62)
    Me.txtpagadoefectivo.TabIndex = 1
    Me.txtpagadoefectivo.Text = "0,00"
    Me.txtpagadoefectivo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtpagadoefectivo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtpagadoefectivo.Value = 0.0R
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(9, 30)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(202, 33)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Valor recibido:"
    '
    'Panel4
    '
    Me.Panel4.Controls.Add(Me.Label3)
    Me.Panel4.Controls.Add(Me.lblvuelto)
    Me.Panel4.Location = New System.Drawing.Point(3, 169)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(508, 77)
    Me.Panel4.TabIndex = 2
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(9, 30)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(105, 33)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Vuelto:"
    '
    'lblvuelto
    '
    Me.lblvuelto.BackColor = System.Drawing.Color.Black
    Me.lblvuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblvuelto.ForeColor = System.Drawing.Color.Lime
    Me.lblvuelto.Location = New System.Drawing.Point(266, 13)
    Me.lblvuelto.Name = "lblvuelto"
    Me.lblvuelto.Size = New System.Drawing.Size(230, 64)
    Me.lblvuelto.TabIndex = 1
    Me.lblvuelto.Text = "$0,00"
    Me.lblvuelto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'FrmMantenimientoPagoRapido
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(511, 291)
    Me.Controls.Add(Me.FlowLayoutPanel1)
    Me.Name = "FrmMantenimientoPagoRapido"
    Me.Text = "Pago rápido"
    Me.Controls.SetChildIndex(Me.FlowLayoutPanel1, 0)
    Me.FlowLayoutPanel1.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.Panel4.ResumeLayout(False)
    Me.Panel4.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lbltotfactura As System.Windows.Forms.Label
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents txtpagadoefectivo As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Panel4 As System.Windows.Forms.Panel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents lblvuelto As System.Windows.Forms.Label
End Class
