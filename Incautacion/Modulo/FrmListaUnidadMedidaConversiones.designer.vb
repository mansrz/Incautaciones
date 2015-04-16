<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaUnidadMedidaConversiones
  Inherits Infoware.Consola.Base.FrmListaBase

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
    Me.ToolTipImage1 = New Infoware.Controles.Base.ToolTipImage
    Me.Label1 = New System.Windows.Forms.Label
    Me.ComboBoxParametroDet1 = New ComboBoxParametroDet
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Size = New System.Drawing.Size(692, 417)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.ComboBoxParametroDet1)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Size = New System.Drawing.Size(692, 36)
    Me.Panel1.Visible = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(13, 11)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(81, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Unidad medida:"
    '
    'ComboBoxParametroDet1
    '
    Me.ComboBoxParametroDet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDet1.Location = New System.Drawing.Point(99, 7)
    Me.ComboBoxParametroDet1.Name = "ComboBoxParametroDet1"
    Me.ComboBoxParametroDet1.OperadorDatos = Nothing
    Me.ComboBoxParametroDet1.Parametro = Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxParametroDet1.ParametroDet = Nothing
    Me.ComboBoxParametroDet1.PuedeActualizar = True
    Me.ComboBoxParametroDet1.PuedeEliminar = True
    Me.ComboBoxParametroDet1.PuedeModificar = True
    Me.ComboBoxParametroDet1.PuedeNuevo = True
    Me.ComboBoxParametroDet1.Size = New System.Drawing.Size(187, 21)
    Me.ComboBoxParametroDet1.TabIndex = 1
    '
    'FrmListaUnidadMedidaConversiones
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(692, 466)
    Me.Name = "FrmListaUnidadMedidaConversiones"
    Me.PuedeEliminar = True
    Me.PuedeImprimir = True
    Me.PuedeNuevo = True
    Me.PuedeRefrescar = True
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ToolTipImage1 As Infoware.Controles.Base.ToolTipImage
  Friend WithEvents ComboBoxParametroDet1 As ComboBoxParametroDet
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
