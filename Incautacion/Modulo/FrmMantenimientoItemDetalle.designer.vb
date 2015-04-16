<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoItemDetalle
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
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.ComboBoxUnidadMedida = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.txtvalor = New Infoware.Controles.Base.TextBoxCalculator()
    Me.CtlBuscaItem1 = New Incautacion.Modulo.CtlBuscaItem()
    Me.txtcantidad = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(399, 92)
    Me.Panel1.TabIndex = 0
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.Label4)
    Me.Panel2.Controls.Add(Me.ComboBoxUnidadMedida)
    Me.Panel2.Controls.Add(Me.txtvalor)
    Me.Panel2.Controls.Add(Me.CtlBuscaItem1)
    Me.Panel2.Controls.Add(Me.txtcantidad)
    Me.Panel2.Controls.Add(Me.Label5)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(399, 91)
    Me.Panel2.TabIndex = 0
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 67)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(34, 13)
    Me.Label4.TabIndex = 4
    Me.Label4.Text = "Valor:"
    '
    'ComboBoxUnidadMedida
    '
    Me.ComboBoxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxUnidadMedida.FormattingEnabled = True
    Me.ComboBoxUnidadMedida.Location = New System.Drawing.Point(233, 38)
    Me.ComboBoxUnidadMedida.Name = "ComboBoxUnidadMedida"
    Me.ComboBoxUnidadMedida.OperadorDatos = Nothing
    Me.ComboBoxUnidadMedida.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxUnidadMedida.ParametroDet = Nothing
    Me.ComboBoxUnidadMedida.PuedeActualizar = True
    Me.ComboBoxUnidadMedida.PuedeEliminar = True
    Me.ComboBoxUnidadMedida.PuedeModificar = True
    Me.ComboBoxUnidadMedida.PuedeNuevo = True
    Me.ComboBoxUnidadMedida.Size = New System.Drawing.Size(139, 21)
    Me.ComboBoxUnidadMedida.TabIndex = 3
    '
    'txtvalor
    '
    Me.txtvalor.Location = New System.Drawing.Point(139, 65)
    Me.txtvalor.Mensaje = ""
    Me.txtvalor.Name = "txtvalor"
    Me.txtvalor.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvalor.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvalor.PromptText = ""
    Me.txtvalor.Size = New System.Drawing.Size(88, 20)
    Me.txtvalor.TabIndex = 5
    Me.txtvalor.Text = "0,00"
    Me.txtvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtvalor.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvalor.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtvalor.Value = 0.0R
    '
    'CtlBuscaItem1
    '
    Me.CtlBuscaItem1.Item = Nothing
    Me.CtlBuscaItem1.ItemText = "Item"
    Me.CtlBuscaItem1.Location = New System.Drawing.Point(15, 11)
    Me.CtlBuscaItem1.Name = "CtlBuscaItem1"
    Me.CtlBuscaItem1.PardetTipoInventario = Nothing
    Me.CtlBuscaItem1.Size = New System.Drawing.Size(357, 22)
    Me.CtlBuscaItem1.TabIndex = 0
    Me.CtlBuscaItem1.Ubicacion = Incautacion.Modulo.CtlBuscaItem.EnumUbicacion.Normal
    '
    'txtcantidad
    '
    Me.txtcantidad.Location = New System.Drawing.Point(139, 39)
    Me.txtcantidad.Mensaje = ""
    Me.txtcantidad.Name = "txtcantidad"
    Me.txtcantidad.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcantidad.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcantidad.PromptText = ""
    Me.txtcantidad.Size = New System.Drawing.Size(88, 20)
    Me.txtcantidad.TabIndex = 2
    Me.txtcantidad.Text = "0,00"
    Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtcantidad.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtcantidad.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtcantidad.Value = 0.0R
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(12, 42)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(52, 13)
    Me.Label5.TabIndex = 1
    Me.Label5.Text = "Cantidad:"
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
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
    'FrmMantenimientoItemDetalle
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(399, 141)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoItemDetalle"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Text = "Detalle"
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents txtcantidad As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents CtlBuscaItem1 As CtlBuscaItem
  Friend WithEvents ComboBoxUnidadMedida As ComboBoxParametroDet
  Friend WithEvents txtvalor As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
