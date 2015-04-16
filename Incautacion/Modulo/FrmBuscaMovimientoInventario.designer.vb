<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscaMovimientoInventario
    Inherits System.Windows.Forms.Form

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
    Me.Label3 = New System.Windows.Forms.Label
    Me.ComboBoxTipoInventario1 = New ComboBoxParametroDet
    Me.ComboBoxTipoCompraVenta = New ComboBoxParametroDet
    Me.txtnumero = New Infoware.Controles.Base.TextBoxCalculator
    Me.pnltipomovimiento = New System.Windows.Forms.Panel
    Me.pnltipocompraventa = New System.Windows.Forms.Panel
    Me.pnlnumero = New System.Windows.Forms.Panel
    Me.btnaceptar = New System.Windows.Forms.Button
    Me.btncancelar = New System.Windows.Forms.Button
    Me.pnltipomovimiento.SuspendLayout()
    Me.pnltipocompraventa.SuspendLayout()
    Me.pnlnumero.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 12)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(105, 15)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Tipo de movimiento:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 3)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(115, 15)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Tipo de compra/venta:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 5)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(48, 15)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Número:"
    '
    'ComboBoxTipoInventario1
    '
    Me.ComboBoxTipoInventario1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoInventario1.FormattingEnabled = True
    Me.ComboBoxTipoInventario1.Location = New System.Drawing.Point(137, 12)
    Me.ComboBoxTipoInventario1.Name = "ComboBoxTipoInventario1"
    Me.ComboBoxTipoInventario1.OperadorDatos = Nothing
    Me.ComboBoxTipoInventario1.Parametro = Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipoInventario1.ParametroDet = Nothing
    Me.ComboBoxTipoInventario1.PuedeActualizar = True
    Me.ComboBoxTipoInventario1.PuedeEliminar = True
    Me.ComboBoxTipoInventario1.PuedeModificar = True
    Me.ComboBoxTipoInventario1.PuedeNuevo = True
    Me.ComboBoxTipoInventario1.Size = New System.Drawing.Size(156, 23)
    Me.ComboBoxTipoInventario1.TabIndex = 1
    '
    'ComboBoxTipoCompraVenta
    '
    Me.ComboBoxTipoCompraVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoCompraVenta.FormattingEnabled = True
    Me.ComboBoxTipoCompraVenta.Location = New System.Drawing.Point(137, 3)
    Me.ComboBoxTipoCompraVenta.Name = "ComboBoxTipoCompraVenta"
    Me.ComboBoxTipoCompraVenta.OperadorDatos = Nothing
    Me.ComboBoxTipoCompraVenta.Parametro = Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipoCompraVenta.ParametroDet = Nothing
    Me.ComboBoxTipoCompraVenta.PuedeActualizar = True
    Me.ComboBoxTipoCompraVenta.PuedeEliminar = True
    Me.ComboBoxTipoCompraVenta.PuedeModificar = True
    Me.ComboBoxTipoCompraVenta.PuedeNuevo = True
    Me.ComboBoxTipoCompraVenta.Size = New System.Drawing.Size(156, 23)
    Me.ComboBoxTipoCompraVenta.TabIndex = 1
    '
    'txtnumero
    '
    Me.txtnumero.Location = New System.Drawing.Point(137, 2)
    Me.txtnumero.Name = "txtnumero"
    Me.txtnumero.Size = New System.Drawing.Size(100, 23)
    Me.txtnumero.TabIndex = 1
    Me.txtnumero.Text = "0"
    Me.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtnumero.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtnumero.Value = 0
    '
    'pnltipomovimiento
    '
    Me.pnltipomovimiento.Controls.Add(Me.ComboBoxTipoInventario1)
    Me.pnltipomovimiento.Controls.Add(Me.Label1)
    Me.pnltipomovimiento.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnltipomovimiento.Location = New System.Drawing.Point(0, 0)
    Me.pnltipomovimiento.Name = "pnltipomovimiento"
    Me.pnltipomovimiento.Size = New System.Drawing.Size(305, 38)
    Me.pnltipomovimiento.TabIndex = 0
    '
    'pnltipocompraventa
    '
    Me.pnltipocompraventa.Controls.Add(Me.Label2)
    Me.pnltipocompraventa.Controls.Add(Me.ComboBoxTipoCompraVenta)
    Me.pnltipocompraventa.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnltipocompraventa.Location = New System.Drawing.Point(0, 38)
    Me.pnltipocompraventa.Name = "pnltipocompraventa"
    Me.pnltipocompraventa.Size = New System.Drawing.Size(305, 30)
    Me.pnltipocompraventa.TabIndex = 1
    Me.pnltipocompraventa.Visible = False
    '
    'pnlnumero
    '
    Me.pnlnumero.Controls.Add(Me.Label3)
    Me.pnlnumero.Controls.Add(Me.txtnumero)
    Me.pnlnumero.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlnumero.Location = New System.Drawing.Point(0, 68)
    Me.pnlnumero.Name = "pnlnumero"
    Me.pnlnumero.Size = New System.Drawing.Size(305, 30)
    Me.pnlnumero.TabIndex = 2
    '
    'btnaceptar
    '
    Me.btnaceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnaceptar.Location = New System.Drawing.Point(137, 106)
    Me.btnaceptar.Name = "btnaceptar"
    Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
    Me.btnaceptar.TabIndex = 3
    Me.btnaceptar.Text = "&Aceptar"
    Me.btnaceptar.UseVisualStyleBackColor = True
    '
    'btncancelar
    '
    Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btncancelar.Location = New System.Drawing.Point(218, 106)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(75, 23)
    Me.btncancelar.TabIndex = 4
    Me.btncancelar.Text = "Cancelar"
    Me.btncancelar.UseVisualStyleBackColor = True
    '
    'FrmBuscaMovimientoInventario
    '
    Me.AcceptButton = Me.btnaceptar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btncancelar
    Me.ClientSize = New System.Drawing.Size(305, 141)
    Me.Controls.Add(Me.btncancelar)
    Me.Controls.Add(Me.btnaceptar)
    Me.Controls.Add(Me.pnlnumero)
    Me.Controls.Add(Me.pnltipocompraventa)
    Me.Controls.Add(Me.pnltipomovimiento)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FrmBuscaMovimientoInventario"
    Me.Text = "Búsqueda de movimiento"
    Me.pnltipomovimiento.ResumeLayout(False)
    Me.pnltipomovimiento.PerformLayout()
    Me.pnltipocompraventa.ResumeLayout(False)
    Me.pnltipocompraventa.PerformLayout()
    Me.pnlnumero.ResumeLayout(False)
    Me.pnlnumero.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxTipoInventario1 As ComboBoxParametroDet
  Friend WithEvents ComboBoxTipoCompraVenta As ComboBoxParametroDet
  Friend WithEvents txtnumero As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents pnltipomovimiento As System.Windows.Forms.Panel
  Friend WithEvents pnltipocompraventa As System.Windows.Forms.Panel
  Friend WithEvents pnlnumero As System.Windows.Forms.Panel
  Friend WithEvents btnaceptar As System.Windows.Forms.Button
  Friend WithEvents btncancelar As System.Windows.Forms.Button
End Class
