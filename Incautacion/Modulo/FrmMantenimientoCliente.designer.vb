<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoCliente
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
    Me.CtlPersona1 = New Incautacion.Modulo.CtlPersona()
    Me.CtlBuscaEmpleado1 = New Incautacion.Modulo.CtlBuscaEmpleado()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.CtlBloqueo1 = New Incautacion.Modulo.CtlBloqueo()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.txtcupocreditomaximo = New Infoware.Controles.Base.TextBoxCalculator()
    Me.ComboBoxTipoPrecio = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.chk_tipoprecio = New Infoware.Controles.Base.CheckBoxStd()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'CtlPersona1
    '
    Me.CtlPersona1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlPersona1.Entidad = Nothing
    Me.CtlPersona1.Location = New System.Drawing.Point(3, 3)
    Me.CtlPersona1.Name = "CtlPersona1"
    Me.CtlPersona1.PuedeElegirTipoEntidad = False
    Me.CtlPersona1.PuedeRegistrarPersonacomo = False
    Me.CtlPersona1.PuedeSRI = True
    Me.CtlPersona1.Size = New System.Drawing.Size(636, 482)
    Me.CtlPersona1.TabIndex = 0
    '
    'CtlBuscaEmpleado1
    '
    Me.CtlBuscaEmpleado1.Empleado = Nothing
    Me.CtlBuscaEmpleado1.EmpleadoText = "Vendedor:"
    Me.CtlBuscaEmpleado1.ItemText = "Vendedor:"
    Me.CtlBuscaEmpleado1.Location = New System.Drawing.Point(0, 0)
    Me.CtlBuscaEmpleado1.Name = "CtlBuscaEmpleado1"
    Me.CtlBuscaEmpleado1.Size = New System.Drawing.Size(314, 25)
    Me.CtlBuscaEmpleado1.TabIndex = 0
    Me.CtlBuscaEmpleado1.TipoEmpleado = Nothing
    Me.CtlBuscaEmpleado1.Ubicacion = Incautacion.Modulo.CtlBuscaEmpleado.EnumUbicacion.Normal
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 49)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(650, 514)
    Me.TabControl1.TabIndex = 0
    Me.TabControl1.TabStop = False
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.CtlPersona1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(642, 488)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Datos principales"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.CtlBloqueo1)
    Me.TabPage2.Controls.Add(Me.Panel1)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(642, 488)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Adicionales"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'CtlBloqueo1
    '
    Me.CtlBloqueo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.CtlBloqueo1.Location = New System.Drawing.Point(584, 6)
    Me.CtlBloqueo1.MaximumSize = New System.Drawing.Size(50, 50)
    Me.CtlBloqueo1.MinimumSize = New System.Drawing.Size(50, 50)
    Me.CtlBloqueo1.Name = "CtlBloqueo1"
    Me.CtlBloqueo1.Restriccion = Nothing
    Me.CtlBloqueo1.Size = New System.Drawing.Size(50, 50)
    Me.CtlBloqueo1.TabIndex = 5
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.CtlBuscaEmpleado1)
    Me.Panel1.Controls.Add(Me.txtcupocreditomaximo)
    Me.Panel1.Controls.Add(Me.ComboBoxTipoPrecio)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.chk_tipoprecio)
    Me.Panel1.Location = New System.Drawing.Point(8, 6)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(413, 173)
    Me.Panel1.TabIndex = 5
    '
    'txtcupocreditomaximo
    '
    Me.txtcupocreditomaximo.Location = New System.Drawing.Point(123, 58)
    Me.txtcupocreditomaximo.Mensaje = ""
    Me.txtcupocreditomaximo.Name = "txtcupocreditomaximo"
    Me.txtcupocreditomaximo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcupocreditomaximo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcupocreditomaximo.PromptText = ""
    Me.txtcupocreditomaximo.Size = New System.Drawing.Size(91, 20)
    Me.txtcupocreditomaximo.TabIndex = 4
    Me.txtcupocreditomaximo.Text = "0,00"
    Me.txtcupocreditomaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtcupocreditomaximo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtcupocreditomaximo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtcupocreditomaximo.Value = 0.0R
    '
    'ComboBoxTipoPrecio
    '
    Me.ComboBoxTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoPrecio.Enabled = False
    Me.ComboBoxTipoPrecio.FormattingEnabled = True
    Me.ComboBoxTipoPrecio.Location = New System.Drawing.Point(123, 31)
    Me.ComboBoxTipoPrecio.Name = "ComboBoxTipoPrecio"
    Me.ComboBoxTipoPrecio.OperadorDatos = Nothing
    Me.ComboBoxTipoPrecio.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoPrecio
    Me.ComboBoxTipoPrecio.ParametroDet = Nothing
    Me.ComboBoxTipoPrecio.PuedeActualizar = True
    Me.ComboBoxTipoPrecio.PuedeEliminar = True
    Me.ComboBoxTipoPrecio.PuedeModificar = True
    Me.ComboBoxTipoPrecio.PuedeNuevo = True
    Me.ComboBoxTipoPrecio.Size = New System.Drawing.Size(191, 21)
    Me.ComboBoxTipoPrecio.TabIndex = 2
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(-3, 61)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(108, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Cupo crédito máximo:"
    '
    'chk_tipoprecio
    '
    Me.chk_tipoprecio.AutoSize = True
    Me.chk_tipoprecio.Location = New System.Drawing.Point(0, 33)
    Me.chk_tipoprecio.Name = "chk_tipoprecio"
    Me.chk_tipoprecio.Size = New System.Drawing.Size(119, 17)
    Me.chk_tipoprecio.TabIndex = 1
    Me.chk_tipoprecio.Text = "Facturar siempre de"
    Me.chk_tipoprecio.UseVisualStyleBackColor = True
    '
    'FrmMantenimientoCliente
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(650, 563)
    Me.Controls.Add(Me.TabControl1)
    Me.Name = "FrmMantenimientoCliente"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Controls.SetChildIndex(Me.TabControl1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CtlPersona1 As CtlPersona
  Friend WithEvents CtlBuscaEmpleado1 As CtlBuscaEmpleado
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents chk_tipoprecio As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents ComboBoxTipoPrecio As ComboBoxParametroDet
  Friend WithEvents txtcupocreditomaximo As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents CtlBloqueo1 As Incautacion.Modulo.CtlBloqueo
  Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
