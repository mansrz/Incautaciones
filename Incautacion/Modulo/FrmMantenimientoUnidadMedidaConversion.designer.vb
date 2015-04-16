<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoUnidadMedidaConversion
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
    Me.Label2 = New System.Windows.Forms.Label
    Me.ComboBoxParametroDet1 = New ComboBoxParametroDet
    Me.ComboBoxParametroDet2 = New ComboBoxParametroDet
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtfactor = New Infoware.Controles.Base.TextBoxCalculator
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 64)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(113, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Unidad medida desde:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 93)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(110, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Unidad medida hasta:"
    '
    'ComboBoxParametroDet1
    '
    Me.ComboBoxParametroDet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDet1.Location = New System.Drawing.Point(146, 61)
    Me.ComboBoxParametroDet1.Name = "ComboBoxParametroDet1"
    Me.ComboBoxParametroDet1.OperadorDatos = Nothing
    Me.ComboBoxParametroDet1.Parametro = Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxParametroDet1.ParametroDet = Nothing
    Me.ComboBoxParametroDet1.PuedeActualizar = True
    Me.ComboBoxParametroDet1.PuedeEliminar = True
    Me.ComboBoxParametroDet1.PuedeModificar = True
    Me.ComboBoxParametroDet1.PuedeNuevo = True
    Me.ComboBoxParametroDet1.Size = New System.Drawing.Size(230, 21)
    Me.ComboBoxParametroDet1.TabIndex = 1
    '
    'ComboBoxParametroDet2
    '
    Me.ComboBoxParametroDet2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDet2.Location = New System.Drawing.Point(146, 88)
    Me.ComboBoxParametroDet2.Name = "ComboBoxParametroDet2"
    Me.ComboBoxParametroDet2.OperadorDatos = Nothing
    Me.ComboBoxParametroDet2.Parametro = Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxParametroDet2.ParametroDet = Nothing
    Me.ComboBoxParametroDet2.PuedeActualizar = True
    Me.ComboBoxParametroDet2.PuedeEliminar = True
    Me.ComboBoxParametroDet2.PuedeModificar = True
    Me.ComboBoxParametroDet2.PuedeNuevo = True
    Me.ComboBoxParametroDet2.Size = New System.Drawing.Size(230, 21)
    Me.ComboBoxParametroDet2.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 118)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(110, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Factor de conversión:"
    '
    'txtfactor
    '
    Me.txtfactor.Location = New System.Drawing.Point(146, 115)
    Me.txtfactor.Mensaje = ""
    Me.txtfactor.Name = "txtfactor"
    Me.txtfactor.NumeroDecimales = 6
    Me.txtfactor.Size = New System.Drawing.Size(100, 20)
    Me.txtfactor.TabIndex = 5
    Me.txtfactor.Text = "0,0000"
    Me.txtfactor.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtfactor.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtfactor.Value = 0
    '
    'FrmMantenimientoUnidadMedidaConversion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(390, 151)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.ComboBoxParametroDet1)
    Me.Controls.Add(Me.ComboBoxParametroDet2)
    Me.Controls.Add(Me.txtfactor)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label3)
    Me.Name = "FrmMantenimientoUnidadMedidaConversion"
    Me.PuedeGuardar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.txtfactor, 0)
    Me.Controls.SetChildIndex(Me.ComboBoxParametroDet2, 0)
    Me.Controls.SetChildIndex(Me.ComboBoxParametroDet1, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxParametroDet1 As ComboBoxParametroDet
  Friend WithEvents ComboBoxParametroDet2 As ComboBoxParametroDet
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtfactor As Infoware.Controles.Base.TextBoxCalculator

End Class
