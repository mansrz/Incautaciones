<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlIncautacionSalida
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
    Me.components = New System.ComponentModel.Container()
    Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
    Me.lbl_tipomov = New System.Windows.Forms.Label()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.TextBoxStd2 = New Infoware.Controles.Base.TextBoxStd()
    Me.TextBoxStd1 = New Infoware.Controles.Base.TextBoxStd()
    Me.txt_codigo = New Infoware.Controles.Base.TextBoxStd()
    Me.DateTimePickerStd1 = New Infoware.Controles.Base.DateTimePickerStd()
    Me.dtpFecdesde = New Infoware.Controles.Base.DateTimePickerStd()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lbl_cod = New System.Windows.Forms.Label()
    Me.ComboBoxParametroDet1 = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
    Me.CtlBuscaContribuyente2 = New Incautacion.Modulo.CtlBuscaContribuyente()
    Me.CtlBuscaEmpleado1 = New Incautacion.Modulo.CtlBuscaEmpleado()
    Me.CtlBuscaEmpleado2 = New Incautacion.Modulo.CtlBuscaEmpleado()
    Me.CtlIncautacioSalidaDet1 = New Incautacion.Modulo.CtlIncautacioSalidaDet()
    Me.FlowLayoutPanel1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.FlowLayoutPanel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'FlowLayoutPanel1
    '
    Me.FlowLayoutPanel1.Controls.Add(Me.lbl_tipomov)
    Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
    Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 3)
    Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
    Me.FlowLayoutPanel1.Size = New System.Drawing.Size(844, 391)
    Me.FlowLayoutPanel1.TabIndex = 1
    '
    'lbl_tipomov
    '
    Me.lbl_tipomov.AutoSize = True
    Me.lbl_tipomov.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbl_tipomov.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lbl_tipomov.Location = New System.Drawing.Point(3, 0)
    Me.lbl_tipomov.Name = "lbl_tipomov"
    Me.lbl_tipomov.Size = New System.Drawing.Size(246, 25)
    Me.lbl_tipomov.TabIndex = 18
    Me.lbl_tipomov.Text = "Salida de incautación "
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.CtlIncautacioSalidaDet1)
    Me.Panel1.Controls.Add(Me.TextBoxStd2)
    Me.Panel1.Controls.Add(Me.TextBoxStd1)
    Me.Panel1.Controls.Add(Me.txt_codigo)
    Me.Panel1.Controls.Add(Me.DateTimePickerStd1)
    Me.Panel1.Controls.Add(Me.dtpFecdesde)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.Label5)
    Me.Panel1.Controls.Add(Me.Label4)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.lbl_cod)
    Me.Panel1.Controls.Add(Me.ComboBoxParametroDet1)
    Me.Panel1.Controls.Add(Me.FlowLayoutPanel2)
    Me.Panel1.Location = New System.Drawing.Point(3, 28)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(830, 356)
    Me.Panel1.TabIndex = 19
    '
    'TextBoxStd2
    '
    Me.TextBoxStd2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxStd2.Location = New System.Drawing.Point(659, 72)
    Me.TextBoxStd2.Mensaje = ""
    Me.TextBoxStd2.Name = "TextBoxStd2"
    Me.TextBoxStd2.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxStd2.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.TextBoxStd2.PromptText = ""
    Me.TextBoxStd2.Size = New System.Drawing.Size(121, 20)
    Me.TextBoxStd2.TabIndex = 62
    '
    'TextBoxStd1
    '
    Me.TextBoxStd1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxStd1.Location = New System.Drawing.Point(395, 72)
    Me.TextBoxStd1.Mensaje = ""
    Me.TextBoxStd1.Name = "TextBoxStd1"
    Me.TextBoxStd1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxStd1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.TextBoxStd1.PromptText = ""
    Me.TextBoxStd1.Size = New System.Drawing.Size(121, 20)
    Me.TextBoxStd1.TabIndex = 62
    '
    'txt_codigo
    '
    Me.txt_codigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_codigo.Location = New System.Drawing.Point(129, 99)
    Me.txt_codigo.Mensaje = ""
    Me.txt_codigo.Name = "txt_codigo"
    Me.txt_codigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_codigo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txt_codigo.PromptText = ""
    Me.txt_codigo.Size = New System.Drawing.Size(121, 20)
    Me.txt_codigo.TabIndex = 62
    '
    'DateTimePickerStd1
    '
    Me.DateTimePickerStd1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.DateTimePickerStd1.Location = New System.Drawing.Point(129, 126)
    Me.DateTimePickerStd1.Name = "DateTimePickerStd1"
    Me.DateTimePickerStd1.Size = New System.Drawing.Size(121, 20)
    Me.DateTimePickerStd1.TabIndex = 61
    '
    'dtpFecdesde
    '
    Me.dtpFecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecdesde.Location = New System.Drawing.Point(395, 99)
    Me.dtpFecdesde.Name = "dtpFecdesde"
    Me.dtpFecdesde.Size = New System.Drawing.Size(121, 20)
    Me.dtpFecdesde.TabIndex = 60
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(271, 102)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(95, 13)
    Me.Label3.TabIndex = 55
    Me.Label3.Text = "Fecha de Entrega:"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(538, 73)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(115, 13)
    Me.Label5.TabIndex = 55
    Me.Label5.Text = "Número de Liquidición:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(271, 73)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(87, 13)
    Me.Label4.TabIndex = 55
    Me.Label4.Text = "Acta de Entrega:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(3, 102)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(118, 13)
    Me.Label2.TabIndex = 55
    Me.Label2.Text = "Número de Resolución:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 129)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(111, 13)
    Me.Label1.TabIndex = 55
    Me.Label1.Text = "Fecha de Resolución:"
    '
    'lbl_cod
    '
    Me.lbl_cod.AutoSize = True
    Me.lbl_cod.Location = New System.Drawing.Point(3, 74)
    Me.lbl_cod.Name = "lbl_cod"
    Me.lbl_cod.Size = New System.Drawing.Size(102, 13)
    Me.lbl_cod.TabIndex = 55
    Me.lbl_cod.Text = "Tipo de Resolución:"
    '
    'ComboBoxParametroDet1
    '
    Me.ComboBoxParametroDet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDet1.FormattingEnabled = True
    Me.ComboBoxParametroDet1.Location = New System.Drawing.Point(129, 71)
    Me.ComboBoxParametroDet1.Name = "ComboBoxParametroDet1"
    Me.ComboBoxParametroDet1.OperadorDatos = Nothing
    Me.ComboBoxParametroDet1.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxParametroDet1.ParametroDet = Nothing
    Me.ComboBoxParametroDet1.PuedeActualizar = True
    Me.ComboBoxParametroDet1.PuedeEliminar = True
    Me.ComboBoxParametroDet1.PuedeModificar = True
    Me.ComboBoxParametroDet1.PuedeNuevo = True
    Me.ComboBoxParametroDet1.Size = New System.Drawing.Size(121, 21)
    Me.ComboBoxParametroDet1.TabIndex = 38
    '
    'FlowLayoutPanel2
    '
    Me.FlowLayoutPanel2.Controls.Add(Me.CtlBuscaContribuyente2)
    Me.FlowLayoutPanel2.Controls.Add(Me.CtlBuscaEmpleado1)
    Me.FlowLayoutPanel2.Controls.Add(Me.CtlBuscaEmpleado2)
    Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 4)
    Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
    Me.FlowLayoutPanel2.Size = New System.Drawing.Size(790, 61)
    Me.FlowLayoutPanel2.TabIndex = 37
    '
    'CtlBuscaContribuyente2
    '
    Me.CtlBuscaContribuyente2.Contribuyente = Nothing
    Me.CtlBuscaContribuyente2.ContribuyenteText = "Tenedor"
    Me.CtlBuscaContribuyente2.ItemText = "Tenedor"
    Me.CtlBuscaContribuyente2.Location = New System.Drawing.Point(3, 3)
    Me.CtlBuscaContribuyente2.Name = "CtlBuscaContribuyente2"
    Me.CtlBuscaContribuyente2.Size = New System.Drawing.Size(365, 22)
    Me.CtlBuscaContribuyente2.TabIndex = 49
    Me.CtlBuscaContribuyente2.Ubicacion = Incautacion.Modulo.CtlBuscaContribuyente.EnumUbicacion.Normal
    '
    'CtlBuscaEmpleado1
    '
    Me.CtlBuscaEmpleado1.Empleado = Nothing
    Me.CtlBuscaEmpleado1.EmpleadoText = "Administrativo"
    Me.CtlBuscaEmpleado1.ItemText = "Administrativo"
    Me.CtlBuscaEmpleado1.Location = New System.Drawing.Point(374, 3)
    Me.CtlBuscaEmpleado1.Name = "CtlBuscaEmpleado1"
    Me.CtlBuscaEmpleado1.Size = New System.Drawing.Size(365, 22)
    Me.CtlBuscaEmpleado1.TabIndex = 47
    Me.CtlBuscaEmpleado1.TipoEmpleado = Nothing
    Me.CtlBuscaEmpleado1.Ubicacion = Incautacion.Modulo.CtlBuscaEmpleado.EnumUbicacion.Normal
    '
    'CtlBuscaEmpleado2
    '
    Me.CtlBuscaEmpleado2.Empleado = Nothing
    Me.CtlBuscaEmpleado2.EmpleadoText = "Fedatario"
    Me.CtlBuscaEmpleado2.ItemText = "Fedatario"
    Me.CtlBuscaEmpleado2.Location = New System.Drawing.Point(3, 31)
    Me.CtlBuscaEmpleado2.Name = "CtlBuscaEmpleado2"
    Me.CtlBuscaEmpleado2.Size = New System.Drawing.Size(365, 22)
    Me.CtlBuscaEmpleado2.TabIndex = 48
    Me.CtlBuscaEmpleado2.TipoEmpleado = Nothing
    Me.CtlBuscaEmpleado2.Ubicacion = Incautacion.Modulo.CtlBuscaEmpleado.EnumUbicacion.Normal
    '
    'CtlIncautacioSalidaDet1
    '
    Me.CtlIncautacioSalidaDet1.Location = New System.Drawing.Point(3, 144)
    Me.CtlIncautacioSalidaDet1.Name = "CtlIncautacioSalidaDet1"
    Me.CtlIncautacioSalidaDet1.Size = New System.Drawing.Size(814, 248)
    Me.CtlIncautacioSalidaDet1.TabIndex = 63
    '
    'CtlIncautacionSalida
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.FlowLayoutPanel1)
    Me.Name = "CtlIncautacionSalida"
    Me.Size = New System.Drawing.Size(872, 412)
    Me.FlowLayoutPanel1.ResumeLayout(False)
    Me.FlowLayoutPanel1.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.FlowLayoutPanel2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents lbl_tipomov As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents ComboBoxParametroDet1 As Incautacion.Modulo.ComboBoxParametroDet
  Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents CtlBuscaContribuyente2 As Incautacion.Modulo.CtlBuscaContribuyente
  Friend WithEvents CtlBuscaEmpleado1 As Incautacion.Modulo.CtlBuscaEmpleado
  Friend WithEvents CtlBuscaEmpleado2 As Incautacion.Modulo.CtlBuscaEmpleado
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lbl_cod As System.Windows.Forms.Label
  Friend WithEvents DateTimePickerStd1 As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents dtpFecdesde As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents TextBoxStd2 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents TextBoxStd1 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txt_codigo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents CtlIncautacioSalidaDet1 As Incautacion.Modulo.CtlIncautacioSalidaDet

End Class
