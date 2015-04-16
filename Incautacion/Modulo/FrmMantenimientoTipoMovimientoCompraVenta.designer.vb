<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoTipoMovimientoCompraVenta
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

  'Form overrides dispose to clean up the component list.
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
    Me.Label1 = New System.Windows.Forms.Label
    Me.cbotipomovimiento = New ComboBoxParametroDet
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtnumero = New Infoware.Controles.Base.TextBoxCalculator
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 64)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(99, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Tipo de movimiento"
    '
    'cbotipomovimiento
    '
    Me.cbotipomovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipomovimiento.Location = New System.Drawing.Point(146, 61)
    Me.cbotipomovimiento.Name = "cbotipomovimiento"
    Me.cbotipomovimiento.OperadorDatos = Nothing
    Me.cbotipomovimiento.Parametro = Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbotipomovimiento.ParametroDet = Nothing
    Me.cbotipomovimiento.PuedeActualizar = True
    Me.cbotipomovimiento.PuedeEliminar = True
    Me.cbotipomovimiento.PuedeModificar = True
    Me.cbotipomovimiento.PuedeNuevo = True
    Me.cbotipomovimiento.Size = New System.Drawing.Size(230, 21)
    Me.cbotipomovimiento.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 91)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(77, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Ultimo número:"
    '
    'txtnumero
    '
    Me.txtnumero.Location = New System.Drawing.Point(146, 88)
    Me.txtnumero.Mensaje = ""
    Me.txtnumero.Name = "txtnumero"
    Me.txtnumero.Size = New System.Drawing.Size(100, 20)
    Me.txtnumero.TabIndex = 3
    Me.txtnumero.Text = "0"
    Me.txtnumero.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtnumero.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtnumero.Value = 0
    '
    'FrmMantenimientoTipoMovimientoCompraVenta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(390, 151)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cbotipomovimiento)
    Me.Controls.Add(Me.txtnumero)
    Me.Controls.Add(Me.Label3)
    Me.Name = "FrmMantenimientoTipoMovimientoCompraVenta"
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Text = "Tipo de movimiento"
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.txtnumero, 0)
    Me.Controls.SetChildIndex(Me.cbotipomovimiento, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cbotipomovimiento As ComboBoxParametroDet
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtnumero As Infoware.Controles.Base.TextBoxCalculator

End Class
