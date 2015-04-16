<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaMovimientosInventarios
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaMovimientosInventarios))
    Me.dtfechasta = New System.Windows.Forms.DateTimePicker()
    Me.dtfecdesde = New System.Windows.Forms.DateTimePicker()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.pnl_tipocompraventa = New System.Windows.Forms.Panel()
    Me.ComboBoxTipoCompraVenta = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.lbl_tipocompraventa = New System.Windows.Forms.Label()
    Me.ComboBoxTipoMovimiento = New Incautacion.Modulo.ComboBoxParametroDet()
    Me.chksolopendientes = New Infoware.Controles.Base.CheckBoxStd()
    Me.TskRangoFecha = New Infoware.Controles.Base.TaskBoxStd()
    Me.TskTipomovimiento = New Infoware.Controles.Base.TaskBoxStd()
    Me.tsk_venta = New Infoware.Controles.Base.TaskBoxStd()
    Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnmayorizar = New System.Windows.Forms.ToolStripButton()
    Me.btndemayorizar = New System.Windows.Forms.ToolStripButton()
    Me.BarraEmpresa1 = New Incautacion.Modulo.BarraEmpresa()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.pnl_tipocompraventa.SuspendLayout()
    Me.TskRangoFecha.SuspendLayout()
    Me.TskTipomovimiento.SuspendLayout()
    Me.tsk_venta.SuspendLayout()
    Me.ToolStrip2.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Size = New System.Drawing.Size(692, 417)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.tsk_venta)
    Me.Panel1.Controls.Add(Me.TskTipomovimiento)
    Me.Panel1.Controls.Add(Me.TskRangoFecha)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel1.Size = New System.Drawing.Size(196, 392)
    Me.Panel1.Visible = True
    '
    'dtfechasta
    '
    Me.dtfechasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechasta.Location = New System.Drawing.Point(42, 58)
    Me.dtfechasta.Name = "dtfechasta"
    Me.dtfechasta.Size = New System.Drawing.Size(110, 20)
    Me.dtfechasta.TabIndex = 3
    '
    'dtfecdesde
    '
    Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecdesde.Location = New System.Drawing.Point(42, 33)
    Me.dtfecdesde.Name = "dtfecdesde"
    Me.dtfecdesde.Size = New System.Drawing.Size(110, 20)
    Me.dtfecdesde.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(7, 62)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(13, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "a"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(7, 36)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(19, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "de"
    '
    'Label3
    '
    Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label3.Location = New System.Drawing.Point(4, 32)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(178, 17)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Tipo de movimiento"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'pnl_tipocompraventa
    '
    Me.pnl_tipocompraventa.Controls.Add(Me.ComboBoxTipoCompraVenta)
    Me.pnl_tipocompraventa.Controls.Add(Me.lbl_tipocompraventa)
    Me.pnl_tipocompraventa.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnl_tipocompraventa.Location = New System.Drawing.Point(4, 70)
    Me.pnl_tipocompraventa.Name = "pnl_tipocompraventa"
    Me.pnl_tipocompraventa.Size = New System.Drawing.Size(178, 41)
    Me.pnl_tipocompraventa.TabIndex = 1
    Me.pnl_tipocompraventa.Visible = False
    '
    'ComboBoxTipoCompraVenta
    '
    Me.ComboBoxTipoCompraVenta.Dock = System.Windows.Forms.DockStyle.Top
    Me.ComboBoxTipoCompraVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoCompraVenta.Location = New System.Drawing.Point(0, 17)
    Me.ComboBoxTipoCompraVenta.Name = "ComboBoxTipoCompraVenta"
    Me.ComboBoxTipoCompraVenta.OperadorDatos = Nothing
    Me.ComboBoxTipoCompraVenta.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipoCompraVenta.ParametroDet = Nothing
    Me.ComboBoxTipoCompraVenta.PuedeActualizar = True
    Me.ComboBoxTipoCompraVenta.PuedeEliminar = True
    Me.ComboBoxTipoCompraVenta.PuedeModificar = True
    Me.ComboBoxTipoCompraVenta.PuedeNuevo = True
    Me.ComboBoxTipoCompraVenta.Size = New System.Drawing.Size(178, 21)
    Me.ComboBoxTipoCompraVenta.TabIndex = 1
    '
    'lbl_tipocompraventa
    '
    Me.lbl_tipocompraventa.Dock = System.Windows.Forms.DockStyle.Top
    Me.lbl_tipocompraventa.Location = New System.Drawing.Point(0, 0)
    Me.lbl_tipocompraventa.Name = "lbl_tipocompraventa"
    Me.lbl_tipocompraventa.Size = New System.Drawing.Size(178, 17)
    Me.lbl_tipocompraventa.TabIndex = 0
    Me.lbl_tipocompraventa.Text = "Tipo de compra"
    Me.lbl_tipocompraventa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ComboBoxTipoMovimiento
    '
    Me.ComboBoxTipoMovimiento.Dock = System.Windows.Forms.DockStyle.Top
    Me.ComboBoxTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoMovimiento.Location = New System.Drawing.Point(4, 49)
    Me.ComboBoxTipoMovimiento.Name = "ComboBoxTipoMovimiento"
    Me.ComboBoxTipoMovimiento.OperadorDatos = Nothing
    Me.ComboBoxTipoMovimiento.Parametro = Incautacion.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipoMovimiento.ParametroDet = Nothing
    Me.ComboBoxTipoMovimiento.PuedeActualizar = True
    Me.ComboBoxTipoMovimiento.PuedeEliminar = True
    Me.ComboBoxTipoMovimiento.PuedeModificar = True
    Me.ComboBoxTipoMovimiento.PuedeNuevo = True
    Me.ComboBoxTipoMovimiento.Size = New System.Drawing.Size(178, 21)
    Me.ComboBoxTipoMovimiento.TabIndex = 1
    '
    'chksolopendientes
    '
    Me.chksolopendientes.AutoSize = True
    Me.chksolopendientes.Dock = System.Windows.Forms.DockStyle.Top
    Me.chksolopendientes.Location = New System.Drawing.Point(4, 111)
    Me.chksolopendientes.Name = "chksolopendientes"
    Me.chksolopendientes.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
    Me.chksolopendientes.Size = New System.Drawing.Size(178, 17)
    Me.chksolopendientes.TabIndex = 2
    Me.chksolopendientes.Text = "Sólo documentos pendientes"
    Me.chksolopendientes.UseVisualStyleBackColor = True
    Me.chksolopendientes.Visible = False
    '
    'TskRangoFecha
    '
    Me.TskRangoFecha.BackColor = System.Drawing.Color.Transparent
    Me.TskRangoFecha.Controls.Add(Me.Label1)
    Me.TskRangoFecha.Controls.Add(Me.dtfechasta)
    Me.TskRangoFecha.Controls.Add(Me.Label2)
    Me.TskRangoFecha.Controls.Add(Me.dtfecdesde)
    Me.TskRangoFecha.Dock = System.Windows.Forms.DockStyle.Top
    Me.TskRangoFecha.HeaderText = "Rango de fecha"
    Me.TskRangoFecha.IsModoMini = True
    Me.TskRangoFecha.Location = New System.Drawing.Point(5, 4)
    Me.TskRangoFecha.Name = "TskRangoFecha"
    Me.TskRangoFecha.Padding = New System.Windows.Forms.Padding(4, 28, 4, 3)
    Me.TskRangoFecha.Size = New System.Drawing.Size(186, 83)
    Me.TskRangoFecha.TabIndex = 0
    '
    'TskTipomovimiento
    '
    Me.TskTipomovimiento.BackColor = System.Drawing.Color.Transparent
    Me.TskTipomovimiento.Controls.Add(Me.chksolopendientes)
    Me.TskTipomovimiento.Controls.Add(Me.pnl_tipocompraventa)
    Me.TskTipomovimiento.Controls.Add(Me.ComboBoxTipoMovimiento)
    Me.TskTipomovimiento.Controls.Add(Me.Label3)
    Me.TskTipomovimiento.Dock = System.Windows.Forms.DockStyle.Top
    Me.TskTipomovimiento.HeaderText = "Tipo de movimiento"
    Me.TskTipomovimiento.IsModoMini = True
    Me.TskTipomovimiento.Location = New System.Drawing.Point(5, 87)
    Me.TskTipomovimiento.Name = "TskTipomovimiento"
    Me.TskTipomovimiento.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.TskTipomovimiento.Size = New System.Drawing.Size(186, 132)
    Me.TskTipomovimiento.TabIndex = 1
    '
    'tsk_venta
    '
    Me.tsk_venta.BackColor = System.Drawing.Color.Transparent
    Me.tsk_venta.Controls.Add(Me.LinkLabel1)
    Me.tsk_venta.Dock = System.Windows.Forms.DockStyle.Top
    Me.tsk_venta.HeaderText = "Venta"
    Me.tsk_venta.IsModoMini = True
    Me.tsk_venta.Location = New System.Drawing.Point(5, 219)
    Me.tsk_venta.Name = "tsk_venta"
    Me.tsk_venta.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.tsk_venta.Size = New System.Drawing.Size(186, 63)
    Me.tsk_venta.TabIndex = 2
    Me.tsk_venta.Visible = False
    '
    'LinkLabel1
    '
    Me.LinkLabel1.AutoSize = True
    Me.LinkLabel1.Location = New System.Drawing.Point(7, 41)
    Me.LinkLabel1.Name = "LinkLabel1"
    Me.LinkLabel1.Size = New System.Drawing.Size(134, 13)
    Me.LinkLabel1.TabIndex = 0
    Me.LinkLabel1.TabStop = True
    Me.LinkLabel1.Text = "Cambiar número de factura"
    '
    'ToolStrip2
    '
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnmayorizar, Me.btndemayorizar})
    Me.ToolStrip2.Location = New System.Drawing.Point(0, 49)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(692, 25)
    Me.ToolStrip2.TabIndex = 6
    Me.ToolStrip2.Text = "ToolStrip2"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripSeparator1.MergeIndex = 1
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnmayorizar
    '
    Me.btnmayorizar.Image = CType(resources.GetObject("btnmayorizar.Image"), System.Drawing.Image)
    Me.btnmayorizar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnmayorizar.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnmayorizar.MergeIndex = 10
    Me.btnmayorizar.Name = "btnmayorizar"
    Me.btnmayorizar.Size = New System.Drawing.Size(70, 22)
    Me.btnmayorizar.Text = "Aprobar"
    '
    'btndemayorizar
    '
    Me.btndemayorizar.Image = CType(resources.GetObject("btndemayorizar.Image"), System.Drawing.Image)
    Me.btndemayorizar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btndemayorizar.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btndemayorizar.MergeIndex = 11
    Me.btndemayorizar.Name = "btndemayorizar"
    Me.btndemayorizar.Size = New System.Drawing.Size(87, 22)
    Me.btndemayorizar.Text = "Desaprobar"
    '
    'BarraEmpresa1
    '
    Me.BarraEmpresa1.Empresa = Nothing
    Me.BarraEmpresa1.EmpresaVisible = True
    Me.BarraEmpresa1.Location = New System.Drawing.Point(0, 74)
    Me.BarraEmpresa1.Name = "BarraEmpresa1"
    Me.BarraEmpresa1.Sistema = Nothing
    Me.BarraEmpresa1.Size = New System.Drawing.Size(692, 25)
    Me.BarraEmpresa1.Sucursal = Nothing
    Me.BarraEmpresa1.SucursalVisible = True
    Me.BarraEmpresa1.TabIndex = 7
    Me.BarraEmpresa1.Text = "BarraEmpresa1"
    '
    'FrmListaMovimientosInventarios
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(692, 466)
    Me.Controls.Add(Me.BarraEmpresa1)
    Me.Controls.Add(Me.ToolStrip2)
    Me.Name = "FrmListaMovimientosInventarios"
    Me.PuedeEliminar = True
    Me.PuedeImprimir = True
    Me.PuedeNuevo = True
    Me.PuedeRefrescar = True
    Me.Controls.SetChildIndex(Me.pnlcuerpo, 0)
    Me.Controls.SetChildIndex(Me.ToolStrip2, 0)
    Me.Controls.SetChildIndex(Me.BarraEmpresa1, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.pnl_tipocompraventa.ResumeLayout(False)
    Me.TskRangoFecha.ResumeLayout(False)
    Me.TskRangoFecha.PerformLayout()
    Me.TskTipomovimiento.ResumeLayout(False)
    Me.TskTipomovimiento.PerformLayout()
    Me.tsk_venta.ResumeLayout(False)
    Me.tsk_venta.PerformLayout()
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxTipoMovimiento As ComboBoxParametroDet
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents pnl_tipocompraventa As System.Windows.Forms.Panel
  Friend WithEvents lbl_tipocompraventa As System.Windows.Forms.Label
  Friend WithEvents ComboBoxTipoCompraVenta As ComboBoxParametroDet
  Friend WithEvents chksolopendientes As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents TskTipomovimiento As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents TskRangoFecha As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents tsk_venta As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnmayorizar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btndemayorizar As System.Windows.Forms.ToolStripButton
  Friend WithEvents BarraEmpresa1 As BarraEmpresa

End Class
