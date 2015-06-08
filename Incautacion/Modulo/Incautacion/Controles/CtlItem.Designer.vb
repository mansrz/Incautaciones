<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlItem
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
        Me.ComboBoxParametroDet2 = New Incautacion.Modulo.ComboBoxParametroDet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkesregistroserie = New Infoware.Controles.Base.CheckBoxStd()
        Me.lblcodigoauxiliar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkestangible = New Infoware.Controles.Base.CheckBoxStd()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkesincluyeiva = New Infoware.Controles.Base.CheckBoxStd()
        Me.chkprecioxcantidad = New Infoware.Controles.Base.CheckBoxStd()
        Me.chkcombo = New Infoware.Controles.Base.CheckBoxStd()
        Me.chkaplicaiva = New Infoware.Controles.Base.CheckBoxStd()
        Me.txtcodigo = New Infoware.Controles.Base.TextBoxCalculator()
        Me.ComboBoxTipoInventario1 = New Incautacion.Modulo.ComboBoxParametroDet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxMarca1 = New Incautacion.Modulo.ComboBoxParametroDet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxUnidadMedida1 = New Incautacion.Modulo.ComboBoxParametroDet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcodigoauxiliar = New Infoware.Controles.Base.TextBoxStd()
        Me.txtubicacion = New Infoware.Controles.Base.TextBoxStd()
        Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
        Me.ComboBoxGrupo1 = New Incautacion.Modulo.ComboBoxParametroDetImagen()
        Me.SuspendLayout()
        '
        'ComboBoxParametroDet2
        '
        Me.ComboBoxParametroDet2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxParametroDet2.FormattingEnabled = True
        Me.ComboBoxParametroDet2.Location = New System.Drawing.Point(84, 30)
        Me.ComboBoxParametroDet2.Name = "ComboBoxParametroDet2"
        Me.ComboBoxParametroDet2.OperadorDatos = Nothing
        Me.ComboBoxParametroDet2.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.ComboBoxParametroDet2.ParametroDet = Nothing
        Me.ComboBoxParametroDet2.PuedeActualizar = True
        Me.ComboBoxParametroDet2.PuedeEliminar = True
        Me.ComboBoxParametroDet2.PuedeModificar = True
        Me.ComboBoxParametroDet2.PuedeNuevo = True
        Me.ComboBoxParametroDet2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxParametroDet2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'chkesregistroserie
        '
        Me.chkesregistroserie.AutoSize = True
        Me.chkesregistroserie.Location = New System.Drawing.Point(135, 138)
        Me.chkesregistroserie.Name = "chkesregistroserie"
        Me.chkesregistroserie.Size = New System.Drawing.Size(152, 17)
        Me.chkesregistroserie.TabIndex = 50
        Me.chkesregistroserie.Text = "Registro de serie individual"
        Me.chkesregistroserie.UseVisualStyleBackColor = True
        '
        'lblcodigoauxiliar
        '
        Me.lblcodigoauxiliar.AutoSize = True
        Me.lblcodigoauxiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigoauxiliar.Location = New System.Drawing.Point(334, 332)
        Me.lblcodigoauxiliar.Name = "lblcodigoauxiliar"
        Me.lblcodigoauxiliar.Size = New System.Drawing.Size(0, 24)
        Me.lblcodigoauxiliar.TabIndex = 49
        Me.lblcodigoauxiliar.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Código:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Grupo:"
        Me.Label5.Visible = False
        '
        'chkestangible
        '
        Me.chkestangible.AutoSize = True
        Me.chkestangible.Location = New System.Drawing.Point(278, 256)
        Me.chkestangible.Name = "chkestangible"
        Me.chkestangible.Size = New System.Drawing.Size(78, 17)
        Me.chkestangible.TabIndex = 41
        Me.chkestangible.Text = "Es tangible"
        Me.chkestangible.UseVisualStyleBackColor = True
        Me.chkestangible.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Código auxiliar:"
        Me.Label8.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Ubicación:"
        Me.Label6.Visible = False
        '
        'chkesincluyeiva
        '
        Me.chkesincluyeiva.AutoSize = True
        Me.chkesincluyeiva.Location = New System.Drawing.Point(363, 256)
        Me.chkesincluyeiva.Name = "chkesincluyeiva"
        Me.chkesincluyeiva.Size = New System.Drawing.Size(110, 17)
        Me.chkesincluyeiva.TabIndex = 42
        Me.chkesincluyeiva.Text = "Precio incluye Iva"
        Me.chkesincluyeiva.UseVisualStyleBackColor = True
        Me.chkesincluyeiva.Visible = False
        '
        'chkprecioxcantidad
        '
        Me.chkprecioxcantidad.AutoSize = True
        Me.chkprecioxcantidad.Location = New System.Drawing.Point(135, 279)
        Me.chkprecioxcantidad.Name = "chkprecioxcantidad"
        Me.chkprecioxcantidad.Size = New System.Drawing.Size(158, 17)
        Me.chkprecioxcantidad.TabIndex = 38
        Me.chkprecioxcantidad.Text = "Precio variable por cantidad"
        Me.chkprecioxcantidad.UseVisualStyleBackColor = True
        Me.chkprecioxcantidad.Visible = False
        '
        'chkcombo
        '
        Me.chkcombo.AutoSize = True
        Me.chkcombo.Location = New System.Drawing.Point(135, 256)
        Me.chkcombo.Name = "chkcombo"
        Me.chkcombo.Size = New System.Drawing.Size(59, 17)
        Me.chkcombo.TabIndex = 39
        Me.chkcombo.Text = "Combo"
        Me.chkcombo.UseVisualStyleBackColor = True
        Me.chkcombo.Visible = False
        '
        'chkaplicaiva
        '
        Me.chkaplicaiva.AutoSize = True
        Me.chkaplicaiva.Location = New System.Drawing.Point(199, 256)
        Me.chkaplicaiva.Name = "chkaplicaiva"
        Me.chkaplicaiva.Size = New System.Drawing.Size(73, 17)
        Me.chkaplicaiva.TabIndex = 40
        Me.chkaplicaiva.Text = "Aplica Iva"
        Me.chkaplicaiva.UseVisualStyleBackColor = True
        Me.chkaplicaiva.Visible = False
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(135, 71)
        Me.txtcodigo.Mensaje = ""
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtcodigo.PromptText = ""
        Me.txtcodigo.Size = New System.Drawing.Size(81, 20)
        Me.txtcodigo.TabIndex = 29
        Me.txtcodigo.Text = "0"
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtcodigo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
        Me.txtcodigo.Value = 0.0R
        '
        'ComboBoxTipoInventario1
        '
        Me.ComboBoxTipoInventario1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoInventario1.FormattingEnabled = True
        Me.ComboBoxTipoInventario1.Location = New System.Drawing.Point(135, 230)
        Me.ComboBoxTipoInventario1.Name = "ComboBoxTipoInventario1"
        Me.ComboBoxTipoInventario1.OperadorDatos = Nothing
        Me.ComboBoxTipoInventario1.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.ComboBoxTipoInventario1.ParametroDet = Nothing
        Me.ComboBoxTipoInventario1.PuedeActualizar = True
        Me.ComboBoxTipoInventario1.PuedeEliminar = True
        Me.ComboBoxTipoInventario1.PuedeModificar = True
        Me.ComboBoxTipoInventario1.PuedeNuevo = True
        Me.ComboBoxTipoInventario1.Size = New System.Drawing.Size(137, 21)
        Me.ComboBoxTipoInventario1.TabIndex = 37
        Me.ComboBoxTipoInventario1.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Unidad de medida:"
        Me.Label7.Visible = False
        '
        'ComboBoxMarca1
        '
        Me.ComboBoxMarca1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMarca1.FormattingEnabled = True
        Me.ComboBoxMarca1.Location = New System.Drawing.Point(135, 204)
        Me.ComboBoxMarca1.Name = "ComboBoxMarca1"
        Me.ComboBoxMarca1.OperadorDatos = Nothing
        Me.ComboBoxMarca1.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.ComboBoxMarca1.ParametroDet = Nothing
        Me.ComboBoxMarca1.PuedeActualizar = True
        Me.ComboBoxMarca1.PuedeEliminar = True
        Me.ComboBoxMarca1.PuedeModificar = True
        Me.ComboBoxMarca1.PuedeNuevo = True
        Me.ComboBoxMarca1.Size = New System.Drawing.Size(137, 21)
        Me.ComboBoxMarca1.TabIndex = 35
        Me.ComboBoxMarca1.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Marca:"
        Me.Label9.Visible = False
        '
        'ComboBoxUnidadMedida1
        '
        Me.ComboBoxUnidadMedida1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUnidadMedida1.FormattingEnabled = True
        Me.ComboBoxUnidadMedida1.Location = New System.Drawing.Point(135, 327)
        Me.ComboBoxUnidadMedida1.Name = "ComboBoxUnidadMedida1"
        Me.ComboBoxUnidadMedida1.OperadorDatos = Nothing
        Me.ComboBoxUnidadMedida1.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.ComboBoxUnidadMedida1.ParametroDet = Nothing
        Me.ComboBoxUnidadMedida1.PuedeActualizar = True
        Me.ComboBoxUnidadMedida1.PuedeEliminar = True
        Me.ComboBoxUnidadMedida1.PuedeModificar = True
        Me.ComboBoxUnidadMedida1.PuedeNuevo = True
        Me.ComboBoxUnidadMedida1.Size = New System.Drawing.Size(137, 21)
        Me.ComboBoxUnidadMedida1.TabIndex = 46
        Me.ComboBoxUnidadMedida1.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Tipo de inventario:"
        Me.Label10.Visible = False
        '
        'txtcodigoauxiliar
        '
        Me.txtcodigoauxiliar.Location = New System.Drawing.Point(135, 328)
        Me.txtcodigoauxiliar.Mensaje = ""
        Me.txtcodigoauxiliar.Name = "txtcodigoauxiliar"
        Me.txtcodigoauxiliar.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoauxiliar.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtcodigoauxiliar.PromptText = ""
        Me.txtcodigoauxiliar.Size = New System.Drawing.Size(161, 20)
        Me.txtcodigoauxiliar.TabIndex = 48
        Me.txtcodigoauxiliar.Visible = False
        '
        'txtubicacion
        '
        Me.txtubicacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtubicacion.Location = New System.Drawing.Point(135, 302)
        Me.txtubicacion.Mensaje = ""
        Me.txtubicacion.Name = "txtubicacion"
        Me.txtubicacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtubicacion.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtubicacion.PromptText = ""
        Me.txtubicacion.Size = New System.Drawing.Size(429, 20)
        Me.txtubicacion.TabIndex = 44
        Me.txtubicacion.Visible = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdescripcion.Location = New System.Drawing.Point(135, 102)
        Me.txtdescripcion.Mensaje = ""
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtdescripcion.PromptText = ""
        Me.txtdescripcion.Size = New System.Drawing.Size(314, 22)
        Me.txtdescripcion.TabIndex = 31
        '
        'ComboBoxGrupo1
        '
        Me.ComboBoxGrupo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.ComboBoxGrupo1.FormattingEnabled = True
        Me.ComboBoxGrupo1.ItemHeight = 32
        Me.ComboBoxGrupo1.Location = New System.Drawing.Point(135, 161)
        Me.ComboBoxGrupo1.Name = "ComboBoxGrupo1"
        Me.ComboBoxGrupo1.Op = Nothing
        Me.ComboBoxGrupo1.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.ComboBoxGrupo1.ParametroDet = Nothing
        Me.ComboBoxGrupo1.Size = New System.Drawing.Size(256, 38)
        Me.ComboBoxGrupo1.TabIndex = 33
        Me.ComboBoxGrupo1.Visible = False
        '
        'CtlItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkesregistroserie)
        Me.Controls.Add(Me.lblcodigoauxiliar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkestangible)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkesincluyeiva)
        Me.Controls.Add(Me.chkprecioxcantidad)
        Me.Controls.Add(Me.chkcombo)
        Me.Controls.Add(Me.chkaplicaiva)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.ComboBoxTipoInventario1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBoxMarca1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBoxUnidadMedida1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcodigoauxiliar)
        Me.Controls.Add(Me.txtubicacion)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.ComboBoxGrupo1)
        Me.Controls.Add(Me.ComboBoxParametroDet2)
        Me.Controls.Add(Me.Label2)
        Me.Name = "CtlItem"
        Me.Size = New System.Drawing.Size(665, 567)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxParametroDet2 As Incautacion.Modulo.ComboBoxParametroDet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkesregistroserie As Infoware.Controles.Base.CheckBoxStd
    Friend WithEvents lblcodigoauxiliar As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkestangible As Infoware.Controles.Base.CheckBoxStd
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkesincluyeiva As Infoware.Controles.Base.CheckBoxStd
    Friend WithEvents chkprecioxcantidad As Infoware.Controles.Base.CheckBoxStd
    Friend WithEvents chkcombo As Infoware.Controles.Base.CheckBoxStd
    Friend WithEvents chkaplicaiva As Infoware.Controles.Base.CheckBoxStd
    Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxCalculator
    Friend WithEvents ComboBoxTipoInventario1 As Incautacion.Modulo.ComboBoxParametroDet
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMarca1 As Incautacion.Modulo.ComboBoxParametroDet
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxUnidadMedida1 As Incautacion.Modulo.ComboBoxParametroDet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoauxiliar As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents txtubicacion As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents ComboBoxGrupo1 As Incautacion.Modulo.ComboBoxParametroDetImagen

End Class
