<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlIncautacion
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
    Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.lbl_cod = New System.Windows.Forms.Label()
    Me.txt_codigo = New Infoware.Controles.Base.TextBoxStd()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dtpFecdesde = New Infoware.Controles.Base.DateTimePickerStd()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtobservacion = New Infoware.Controles.Base.TextBoxStd()
    Me.ComboBoxBodega1 = New Incautacion.Modulo.ComboBoxBodega()
    Me.CtlBuscaContribuyente1 = New Incautacion.Modulo.CtlBuscaContribuyente()
    Me.CtlBuscaContribuyente2 = New Incautacion.Modulo.CtlBuscaContribuyente()
    Me.CtlBuscaEmpleado1 = New Incautacion.Modulo.CtlBuscaEmpleado()
    Me.CtlBuscaEmpleado2 = New Incautacion.Modulo.CtlBuscaEmpleado()
    Me.CtlIncautacionDet1 = New Incautacion.Modulo.CtlIncautacionDet()
    Me.FlowLayoutPanel1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.FlowLayoutPanel2.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'FlowLayoutPanel1
    '
    Me.FlowLayoutPanel1.Controls.Add(Me.lbl_tipomov)
    Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
    Me.FlowLayoutPanel1.Location = New System.Drawing.Point(4, 4)
    Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
    Me.FlowLayoutPanel1.Size = New System.Drawing.Size(844, 391)
    Me.FlowLayoutPanel1.TabIndex = 0
    '
    'lbl_tipomov
    '
    Me.lbl_tipomov.AutoSize = True
    Me.lbl_tipomov.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbl_tipomov.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lbl_tipomov.Location = New System.Drawing.Point(3, 0)
    Me.lbl_tipomov.Name = "lbl_tipomov"
    Me.lbl_tipomov.Size = New System.Drawing.Size(133, 25)
    Me.lbl_tipomov.TabIndex = 18
    Me.lbl_tipomov.Text = "Incautacion"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Controls.Add(Me.FlowLayoutPanel2)
    Me.Panel1.Controls.Add(Me.CtlIncautacionDet1)
    Me.Panel1.Location = New System.Drawing.Point(3, 28)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(830, 356)
    Me.Panel1.TabIndex = 19
    '
    'FlowLayoutPanel2
    '
    Me.FlowLayoutPanel2.Controls.Add(Me.CtlBuscaContribuyente1)
    Me.FlowLayoutPanel2.Controls.Add(Me.CtlBuscaContribuyente2)
    Me.FlowLayoutPanel2.Controls.Add(Me.CtlBuscaEmpleado1)
    Me.FlowLayoutPanel2.Controls.Add(Me.CtlBuscaEmpleado2)
    Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 4)
    Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
    Me.FlowLayoutPanel2.Size = New System.Drawing.Size(790, 61)
    Me.FlowLayoutPanel2.TabIndex = 37
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.lbl_cod)
    Me.Panel2.Controls.Add(Me.txt_codigo)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Controls.Add(Me.ComboBoxBodega1)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.dtpFecdesde)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Controls.Add(Me.txtobservacion)
    Me.Panel2.Location = New System.Drawing.Point(3, 72)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(790, 67)
    Me.Panel2.TabIndex = 38
    '
    'lbl_cod
    '
    Me.lbl_cod.AutoSize = True
    Me.lbl_cod.Location = New System.Drawing.Point(3, 6)
    Me.lbl_cod.Name = "lbl_cod"
    Me.lbl_cod.Size = New System.Drawing.Size(76, 13)
    Me.lbl_cod.TabIndex = 54
    Me.lbl_cod.Text = "# Incautación:"
    '
    'txt_codigo
    '
    Me.txt_codigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_codigo.Location = New System.Drawing.Point(129, 3)
    Me.txt_codigo.Mensaje = ""
    Me.txt_codigo.Name = "txt_codigo"
    Me.txt_codigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_codigo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txt_codigo.PromptText = ""
    Me.txt_codigo.Size = New System.Drawing.Size(198, 20)
    Me.txt_codigo.TabIndex = 55
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(539, 6)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(47, 13)
    Me.Label1.TabIndex = 60
    Me.Label1.Text = "Bodega:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(339, 6)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(40, 13)
    Me.Label2.TabIndex = 58
    Me.Label2.Text = "Fecha:"
    '
    'dtpFecdesde
    '
    Me.dtpFecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecdesde.Location = New System.Drawing.Point(396, 3)
    Me.dtpFecdesde.Name = "dtpFecdesde"
    Me.dtpFecdesde.Size = New System.Drawing.Size(93, 20)
    Me.dtpFecdesde.TabIndex = 59
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(2, 28)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(81, 13)
    Me.Label3.TabIndex = 56
    Me.Label3.Text = "Observaciones:"
    '
    'txtobservacion
    '
    Me.txtobservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtobservacion.Location = New System.Drawing.Point(129, 28)
    Me.txtobservacion.Mensaje = ""
    Me.txtobservacion.Name = "txtobservacion"
    Me.txtobservacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtobservacion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtobservacion.PromptText = ""
    Me.txtobservacion.Size = New System.Drawing.Size(610, 20)
    Me.txtobservacion.TabIndex = 57
    '
    'ComboBoxBodega1
    '
    Me.ComboBoxBodega1.Bodega = Nothing
    Me.ComboBoxBodega1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxBodega1.FormattingEnabled = True
    Me.ComboBoxBodega1.Location = New System.Drawing.Point(620, 3)
    Me.ComboBoxBodega1.Name = "ComboBoxBodega1"
    Me.ComboBoxBodega1.PuedeActualizar = False
    Me.ComboBoxBodega1.PuedeEliminar = False
    Me.ComboBoxBodega1.PuedeModificar = False
    Me.ComboBoxBodega1.PuedeNuevo = False
    Me.ComboBoxBodega1.Size = New System.Drawing.Size(121, 21)
    Me.ComboBoxBodega1.Sucursal = Nothing
    Me.ComboBoxBodega1.TabIndex = 61
    '
    'CtlBuscaContribuyente1
    '
    Me.CtlBuscaContribuyente1.Contribuyente = Nothing
    Me.CtlBuscaContribuyente1.ContribuyenteText = "Contribuyente"
    Me.CtlBuscaContribuyente1.ItemText = "Contribuyente"
    Me.CtlBuscaContribuyente1.Location = New System.Drawing.Point(3, 3)
    Me.CtlBuscaContribuyente1.Name = "CtlBuscaContribuyente1"
    Me.CtlBuscaContribuyente1.Size = New System.Drawing.Size(365, 22)
    Me.CtlBuscaContribuyente1.TabIndex = 46
    Me.CtlBuscaContribuyente1.Ubicacion = Incautacion.Modulo.CtlBuscaContribuyente.EnumUbicacion.Normal
    '
    'CtlBuscaContribuyente2
    '
    Me.CtlBuscaContribuyente2.Contribuyente = Nothing
    Me.CtlBuscaContribuyente2.ContribuyenteText = "Tenedor"
    Me.CtlBuscaContribuyente2.ItemText = "Tenedor"
    Me.CtlBuscaContribuyente2.Location = New System.Drawing.Point(374, 3)
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
    Me.CtlBuscaEmpleado1.Location = New System.Drawing.Point(3, 31)
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
    Me.CtlBuscaEmpleado2.Location = New System.Drawing.Point(374, 31)
    Me.CtlBuscaEmpleado2.Name = "CtlBuscaEmpleado2"
    Me.CtlBuscaEmpleado2.Size = New System.Drawing.Size(365, 22)
    Me.CtlBuscaEmpleado2.TabIndex = 48
    Me.CtlBuscaEmpleado2.TipoEmpleado = Nothing
    Me.CtlBuscaEmpleado2.Ubicacion = Incautacion.Modulo.CtlBuscaEmpleado.EnumUbicacion.Normal
    '
    'CtlIncautacionDet1
    '
    Me.CtlIncautacionDet1.Location = New System.Drawing.Point(2, 145)
    Me.CtlIncautacionDet1.Name = "CtlIncautacionDet1"
    Me.CtlIncautacionDet1.Size = New System.Drawing.Size(819, 208)
    Me.CtlIncautacionDet1.TabIndex = 36
    '
    'CtlIncautacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.FlowLayoutPanel1)
    Me.Name = "CtlIncautacion"
    Me.Size = New System.Drawing.Size(858, 405)
    Me.FlowLayoutPanel1.ResumeLayout(False)
    Me.FlowLayoutPanel1.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    Me.FlowLayoutPanel2.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents lbl_tipomov As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents CtlIncautacionDet1 As Incautacion.Modulo.CtlIncautacionDet
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents lbl_cod As System.Windows.Forms.Label
  Friend WithEvents txt_codigo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxBodega1 As Incautacion.Modulo.ComboBoxBodega
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dtpFecdesde As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtobservacion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents CtlBuscaContribuyente1 As Incautacion.Modulo.CtlBuscaContribuyente
  Friend WithEvents CtlBuscaContribuyente2 As Incautacion.Modulo.CtlBuscaContribuyente
  Friend WithEvents CtlBuscaEmpleado2 As Incautacion.Modulo.CtlBuscaEmpleado
  Friend WithEvents CtlBuscaEmpleado1 As Incautacion.Modulo.CtlBuscaEmpleado

End Class
