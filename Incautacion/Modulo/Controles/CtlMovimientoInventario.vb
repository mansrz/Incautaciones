Imports Incautacion.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base

Public Class CtlMovimientoInventario
#Region "Propiedades"
  Private mSistema As Sistema = Nothing
  Public Property Sistema As Sistema
    Get
      Return mSistema
    End Get
    Set(ByVal value As Sistema)
      mSistema = value
    End Set
  End Property

  Private mVerConfidencial As Boolean = False
  Public Property VerConfidencial As Boolean
    Get
      Return mVerConfidencial
    End Get
    Set(ByVal value As Boolean)
      mVerConfidencial = value
      Me.DataGridViewDetalles.VerConfidencial = mVerConfidencial
      Me.ComboBoxTipoPrecio.Enabled = mVerConfidencial
      Me.txtdsctoglobal.Enabled = mVerConfidencial
      Me.CtlBuscaEmpleado1.Enabled = mVerConfidencial
    End Set
  End Property

  Private mSucursal As Sucursal = Nothing
  Public Property Sucursal As Sucursal
    Get
      Return mSucursal
    End Get
    Set(ByVal value As Sucursal)
      mSucursal = value
      If value IsNot Nothing Then
        Me.ComboBoxBodega1.Sucursal = mSucursal
        Me.ComboBoxBodega1.Llenar_datos()

        Me.ComboBoxSucursal1.Empresa = mSucursal.Empresa
        Me.ComboBoxSucursal1.Sucursal = mSucursal
        Me.ComboBoxSucursal1.Llenar_datos()

        Me.ComboBoxBodega2.Sucursal = mSucursal
        Me.ComboBoxBodega2.Llenar_datos()

        Me.CtlBuscaCliente1.OperadorDatos = mSucursal.OperadorDatos
        Me.CtlBuscaProveedor1.OperadorDatos = mSucursal.OperadorDatos
                Me.CtlBuscaEmpleado1.OperadorDatos = mSucursal.OperadorDatos
                Me.CtlBuscaContribuyente1.OperadorDatos = mSucursal.OperadorDatos
                Me.CtlBuscaIncautacion1.OperadorDatos = mSucursal.OperadorDatos

        Me.ComboBoxFormaPago.OperadorDatos = mSucursal.OperadorDatos
        Me.ComboBoxFormaPago.Parametro = Enumerados.EnumParametros.TipoFormaPago
        Me.ComboBoxFormaPago.Llenar_Datos()

        Me.ComboBoxTipoPrecio.OperadorDatos = mSucursal.OperadorDatos
        Me.ComboBoxTipoPrecio.Parametro = Enumerados.EnumParametros.TipoPrecio
        Me.ComboBoxTipoPrecio.Llenar_Datos()

                'Me.CtlBuscaActivo.Sucursal = mSucursal
                'Me.CtlBuscaActivo.PardetTipoInventario = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoInventario, Enumerados.EnumTipoInventario.ActivoFijo)
                'Me.CtlBuscaActivo.llenar_datos()
      End If
    End Set
  End Property

  Private mMovimientoInventario As MovimientoInventario = Nothing
  Public Property MovimientoInventario As MovimientoInventario
    Get
      Return mMovimientoInventario
    End Get
    Set(ByVal value As MovimientoInventario)
      mMovimientoInventario = value
      If value IsNot Nothing Then
        llenar_datos()
      End If
    End Set
  End Property

  Private mPardetTipoInventario As WWTSParametroDet = Nothing
  Public Property PardetTipoInventario As WWTSParametroDet
    Get
      Return mPardetTipoInventario
    End Get
    Set(ByVal value As WWTSParametroDet)
      mPardetTipoInventario = value
      Me.DataGridViewDetalles.PardetTipoInventario = value
    End Set
  End Property

  'Private mTipoMovimiento As WWTSParametroDet = Nothing
  'Public Property TipoMovimiento As WWTSParametroDet
  '  Get
  '    Return mTipoMovimiento
  '  End Get
  '  Set(ByVal value As WWTSParametroDet)
  '    mTipoMovimiento = value
  '    If value IsNot Nothing Then
  '      cambiar_tipomovimiento()
  '    End If
  '  End Set
  'End Property
  Public ReadOnly Property TipoMovimiento As WWTSParametroDet
    Get
      Return mMovimientoInventario.PardetTipoMovInv
    End Get
  End Property

  Private ReadOnly Property TipoMovimientoEnum As Enumerados.enumTipoMovInv
    Get
      Return mMovimientoInventario.Pardet_TipomovinvEnum
    End Get
  End Property

  Public Property PuedeCancelar As Boolean
    Get
      Return Me.barracancelar.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.barracancelar.Visible = value
    End Set
    End Property

    
#End Region

#Region "Compra Venta"
  'Private mTipoMovimientoCompraVenta As WWTSParametroDet = Nothing
  Public ReadOnly Property TipoMovimientoCompraVenta As WWTSParametroDet
    Get
      Select Case TipoMovimientoEnum
        Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.DevCompra
          Return mMovimientoInventario.Compra.PardetTipoCompra
        Case Enumerados.enumTipoMovInv.Venta, Enumerados.enumTipoMovInv.DevVenta
          Return mMovimientoInventario.Venta.PardetTipoVenta
      End Select
      Return Nothing
    End Get
  End Property
#End Region

#Region "Movimientos"
    Sub cambiar_tipomovimiento()

        Me.lbl_tipomov.Text = TipoMovimiento.Pardet_Descripcion
        If TipoMovimientoCompraVenta IsNot Nothing Then
            Me.lbl_tipomov.Text += " - " + TipoMovimientoCompraVenta.Pardet_Descripcion
        End If

        Me.pnlbodegadstno.Visible = TipoMovimientoEnum = Enumerados.enumTipoMovInv.Transferencia
        'Me.pnlclienteproveedor.Visible = _enumtipomov = Enumerados.enumTipoMovInv.Venta Or _enumtipomov = Enumerados.enumTipoMovInv.Compra
        Me.pnldetalles.Visible = True
        'Me.SepPagos.Visible = False
        'Me.btnpagos.Visible = False
        Me.pnltipocompte.Visible = False
        Me.pnlbodega.Visible = True
        'Me.pnlIncautacion.Visible = False
        'Me.comboTipoCompraVenta.Visible = False
        Me.pnlclienteproveedor.Visible = False
        Me.pnlIncautacion.Visible = True


        Me.pnlnumerocompra.Visible = False
        Me.pnldatosventa.Visible = False

        Select Case TipoMovimientoEnum
            Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.DevCompra
                Me.pnlclienteproveedor.Text = "Proveedor"
                Me.CtlBuscaCliente1.Visible = False
                Me.CtlBuscaProveedor1.Visible = True
                Me.CtlBuscaEmpleado1.Visible = False
                Me.CtlBuscaContribuyente1.Visible = False
                'Me.comboTipoCompraVenta.ComboBox.ValueMember = "Pardet_Secuencia"
                'Me.comboTipoCompraVenta.ComboBox.DisplayMember = "Pardet_Descripcion"
                'tipocompraventas = ParametroDetList.ObtenerLista(mSucursal.OperadorDatos, Enumerados.EnumParametros.TipoCompra)
                'Me.comboTipoCompraVenta.ComboBox.DataSource = tipocompraventas
                'Me.comboTipoMovimiento.ComboBox.SelectedValue = CInt(_enumtipomov)
                Me.pnldatosventa.Visible = True
                Me.pnlnumerocompra.Visible = True
                'llenar_creditotributario()

            Case Enumerados.enumTipoMovInv.Venta, Enumerados.enumTipoMovInv.DevVenta
                Me.pnlclienteproveedor.Text = "Cliente"
                Me.CtlBuscaCliente1.Visible = True
                Me.CtlBuscaProveedor1.Visible = False
                Me.CtlBuscaEmpleado1.Visible = True

                'Me.comboTipoCompraVenta.ComboBox.ValueMember = "Pardet_Secuencia"
                'Me.comboTipoCompraVenta.ComboBox.DisplayMember = "Pardet_Descripcion"
                'tipocompraventas = ParametroDetList.ObtenerLista(mSucursal.OperadorDatos, Enumerados.EnumParametros.TipoVenta)
                'Me.comboTipoCompraVenta.ComboBox.DataSource = tipocompraventas
                'Me.comboTipoMovimiento.ComboBox.SelectedValue = CInt(_enumtipomov)
                Me.pnldatosventa.Visible = True
                ''Me.pnlnumerocompra.Visible = False
                'llenar_creditotributario()
            Case Enumerados.enumTipoMovInv.Incautacion, Enumerados.enumTipoMovInv.IncautSalida
                Me.pnlclienteproveedor.Text = "Contribuyente"
                Me.CtlBuscaCliente1.Visible = False
                Me.CtlBuscaProveedor1.Visible = False
                Me.CtlBuscaEmpleado1.Visible = False
                Me.CtlBuscaContribuyente1.Visible = True
                Me.pnlformapago.Visible = False
                'Me.pnlIncautacion.Visible = True


        End Select

        If mMovimientoInventario Is Nothing Then
            Exit Sub
        End If
        mMovimientoInventario.Pardet_Tipomovinv = TipoMovimientoEnum
        'mMovimientoInventario.Detalles = Nothing
        Me.DataGridViewDetalles.MovimientoInventario = mMovimientoInventario
        Me.DataGridViewDetalles.PardetTipoPago = Me.ComboBoxFormaPago.ParametroDet
        Me.DataGridViewDetalles.PardetTipoPrecio = Me.ComboBoxTipoPrecio.ParametroDet
        tamano()

        Llenar_detalles()

        'Me.pnldetalles.Height = Me.FlowLayoutPanel1.Height - Me.pnldetalles.Location.Y - Me.pnltotalcompleto.Height - 5
    End Sub

    Public Function Guardar(ByVal _VerificarSaldo As Boolean) As Boolean
        If Me.CtlBuscaIncautacion1.Incautacion Is Nothing Then
            MessageBox.Show("Debe seleccionar una Incautación")
            'Throw New Exception("No ha seleccionado una incautación")
            Return False
        End If

        If ComboBoxBodega1.Bodega Is Nothing Then
            'Throw New Exception("Debe especificar una bodega")
            MessageBox.Show("Debe seleccionar una Bodega")
            Return False
        End If


        Try


            mapear_datos()

            Dim _puedegrabar As Boolean = True
            'If Not mMovimientoInventario.EsNuevo Then
            '  If MsgBox("¿Desea crear un movimiento nuevo a partir del actual, anulando el movimiento actual?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
            '    _puedegrabar = False
            '  End If
            'End If
            Me.DataGridViewDetalles.CtlMantenimientoMovimientoInventarioDet1.ValidarRegistros()
            If _puedegrabar Then

                Select Case TipoMovimientoEnum
                    Case Enumerados.enumTipoMovInv.Venta, Enumerados.enumTipoMovInv.DevVenta
                        'mapear_venta()
                        If Not mVenta.Guardar(_VerificarSaldo) Then
                            Throw New Exception(mVenta.OperadorDatos.MsgError)
                        End If
                        MsgBox(String.Format("Movimiento guardado {0} {1}" & vbNewLine & "{2} {3}", mVenta.MovimientoInventario.PardetTipoMovInv.Pardet_Descripcion, mVenta.MovimientoInventario.Movinv_Secuencia, mVenta.PardetTipoVenta.Pardet_Descripcion, mVenta.Venta_Numero))
                    Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.DevCompra
                        'mapear_compra()
                        If Not mCompra.Guardar Then
                            Throw New Exception(mCompra.OperadorDatos.MsgError)
                        End If
                        MsgBox(String.Format("Movimiento guardado {0} {1}" & vbNewLine & "{2} {3}", mCompra.MovimientoInventario.PardetTipoMovInv.Pardet_Descripcion, mCompra.MovimientoInventario.Movinv_Secuencia, mCompra.PardetTipoCompra.Pardet_Descripcion, mCompra.Compra_Numero))
                        'Case Enumerados.enumTipoMovInv.Incautacion, Enumerados.enumTipoMovInv.IncautSalida
                        'mapear_compra()

                        'If Not mIncautacion.Guardar Then
                        '    Throw New Exception(mIncautacion.OperadorDatos.MsgError)
                        'End If
                        'MsgBox("Incautación guardada")
                        'LLamar reporte 
                    Case Else
                        Dim _esnuevo As Boolean = mMovimientoInventario.EsNuevo
                        If Not mMovimientoInventario.Guardar() Then
                            Throw New Exception(mMovimientoInventario.OperadorDatos.MsgError)
                        Else
                            Auditoria.Registrar_Auditoria(CType(Me.ParentForm, Infoware.Consola.Base.FrmFormaBase).Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mMovimientoInventario.Movinv_Observaciones)

                        End If
                        MsgBox(String.Format("Movimiento guardado {0} {1}", mMovimientoInventario.PardetTipoMovInv.Pardet_Descripcion, mMovimientoInventario.Movinv_Secuencia))
                End Select
            Else
                Throw New Exception()
            End If

            Me.txtnumero.Value = mMovimientoInventario.Movinv_Secuencia

            'Me.btnpagos.Enabled = Not mMovimientoInventario.EsNuevo
            llenar_datos()

            Return True
        Catch ex As Exception
            MsgBox("No se puede guardar MovimientoInventario" & Environment.NewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private mestallenando As Boolean = False

    Private Sub llenar_datos()
        If mSucursal Is Nothing OrElse MovimientoInventario Is Nothing Then
            Exit Sub
        End If

        cambiar_tipomovimiento()
        mestallenando = True
        barracancelar.Enabled = mMovimientoInventario.EsNuevo
        Me.dtpFecdesde.Value = mMovimientoInventario.Movinv_Fecha
        Me.txtnumero.Value = mMovimientoInventario.Movinv_Secuencia
        Me.txtobservacion.Text = mMovimientoInventario.Movinv_Observaciones
        'Me.comboTipoMovimiento.ComboBox.SelectedValue = CInt(mMovimientoInventario.Pardet_Tipomovinv)
        Me.ComboBoxBodega1.Bodega = mMovimientoInventario.Bodega
        Me.ComboBoxBodega2.Bodega = mMovimientoInventario.BodegaDsno
        Me.txtdsctoglobal.Value = Me.mMovimientoInventario.Movinv_Descto

        Me.CtlBuscaIncautacion1.Incautacion = mMovimientoInventario.Incautacion

        Me.dtpFecdesde.Enabled = mVerConfidencial
        Me.txtnumero.Enabled = mVerConfidencial

        If mMovimientoInventario.EsNuevo Then
            mMovimientoInventario.Movinv_porcIVA = New WWTSParametroDet(Sistema.OperadorDatos, 465, 1).Pardet_DatoDec1
        End If

        txtporciva.Value = mMovimientoInventario.Movinv_porcIVA
        Llenar_detalles()
        mestallenando = False

        If mMovimientoInventario.Venta IsNot Nothing Then
            Me.CtlBuscaCliente1.Cliente = mMovimientoInventario.Venta.Cliente

            If mMovimientoInventario.Venta.Cliente IsNot Nothing Then
                With mMovimientoInventario.Venta.Cliente
                    'If .Entidad.Entidadjuridica IsNot Nothing Then
                    '  'Me.txt_otrosdatos.Text = String.Format("Contacto: {0}", .Entidad.Entidadjuridica.ContactoString)
                    'End If
                    'Me.txt_otrosdatos.Text = String.Format("{0}{1}Teléfono:{2}", Me.txt_otrosdatos.Text, vbCrLf, .TelefonosString)

                    Me.CtlDireccion1.Entidad = .Entidad
                    Me.CtlBuscaEmpleado1.Empleado = .Empleado
                End With
            End If

            Me.CtlBuscaEmpleado1.Empleado = mMovimientoInventario.Venta.Empleado
            Me.ComboBoxFormaPago.ParametroDet = mMovimientoInventario.Venta.PardetTipoPago
            Me.ComboBoxTipoPrecio.ParametroDet = mMovimientoInventario.Venta.PardetTipoPrecio
            Me.txtfactura.Value = mMovimientoInventario.Venta.Venta_Numero

            'llenar_creditotributario()
            'Me.ComboBoxTipoComprobante1.SelectedValue = mMovimientoInventario.Venta.SRI_tipocomprobante
        End If

        If mMovimientoInventario.Compra IsNot Nothing Then
            'Me.comboTipoMovimiento.ComboBox.SelectedValue = CInt(mMovimientoInventario.Pardet_Tipomovinv)
            'Me.comboTipoCompraVenta.ComboBox.SelectedValue = CInt(mMovimientoInventario.Compra.Pardet_TipoCompra)
            Me.CtlBuscaProveedor1.Proveedor = mMovimientoInventario.Compra.Proveedor
            Me.msk_compranumero.Text = mMovimientoInventario.Compra.Compra_Numero
            Me.msk_autorizacion.Text = mMovimientoInventario.Compra.Compra_Autorizacion
            Me.msk_fechacaducidad.Text = mMovimientoInventario.Compra.Compra_Caducidad

            If mMovimientoInventario.Venta IsNot Nothing Then
                With mMovimientoInventario.Compra.Proveedor
                    'If .Entidad.Entidadjuridica IsNot Nothing Then
                    '  'Me.txt_otrosdatos.Text = String.Format("Contacto: {0}", .Entidad.Entidadjuridica.ContactoString)
                    'End If
                    ''Me.txt_otrosdatos.Text = String.Format("{0}{1}Teléfono:{2}", Me.txt_otrosdatos.Text, vbCrLf, .TelefonosString)

                    Me.CtlDireccion1.Entidad = .Entidad
                End With
            End If

            Me.ComboBoxFormaPago.ParametroDet = mMovimientoInventario.Compra.PardetTipoPago
            'Me.ComboBoxTipoComprobante1.SelectedValue = mMovimientoInventario.Compra.SRI_tipocomprobante
            'Me.ComboBoxCreditoTributario1.SelectedValue = mMovimientoInventario.Compra.SRI_creditotributario
        End If
        If mMovimientoInventario.Incautacion IsNot Nothing Then
            Me.CtlBuscaContribuyente1.Contribuyente = Me.mMovimientoInventario.Incautacion.Contribuyente
            Me.CtlBuscaIncautacion1.Incautacion = Me.mMovimientoInventario.Incautacion
        End If

        'Me.comboTipoMovimiento.Enabled = mMovimientoInventario.EsNuevo
        'Me.comboTipoCompraVenta.Enabled = mMovimientoInventario.EsNuevo
        'Me.btnpagos.Enabled = Not mMovimientoInventario.EsNuevo
        'Me.CtlBuscaActivo.Item = mMovimientoInventario.Item
        'mapear_datos()

        'Me.comboTipoMovimiento.Enabled = mMovimientoInventario.EsNuevo
        'Me.comboTipoCompraVenta.Enabled = mMovimientoInventario.EsNuevo
        Me.pnlcodigo.Enabled = mMovimientoInventario.EsNuevo
        Me.pnldatosventa.Enabled = mMovimientoInventario.EsNuevo
        Me.pnlbodega.Enabled = mMovimientoInventario.EsNuevo
        Me.pnlIncautacion.Enabled = mMovimientoInventario.EsNuevo
        Me.pnlclienteproveedor.Enabled = mMovimientoInventario.EsNuevo
        Me.pnltotalcompleto.Enabled = mMovimientoInventario.EsNuevo
        Me.pnltotalsimple.Enabled = mMovimientoInventario.EsNuevo
    End Sub

    Public Sub mapear_datos()
        If mestallenando Then
            Exit Sub
        End If


        If mMovimientoInventario IsNot Nothing Then
            mestallenando = True
            'Dim _indice As Integer = 12  'TODO OJO CAMBIAR OJO Me.ComboBoxIVA1.SelectedIndex
            'Me.ComboBoxIVA1.Llenar_datos(Me.dtpFecdesde.Value)
            'If _indice >= 0 Then
            '  Me.ComboBoxIVA1.SelectedIndex = _indice
            'End If

            Try
                If Me.ComboBoxBodega1.Bodega Is Nothing AndAlso Me.ComboBoxBodega1.Items.Count > 0 Then
                    Me.ComboBoxBodega1.SelectedIndex = 0
                End If
            Catch ex As Exception

            End Try

            'If Me.ComboBoxIVA1.SelectedIndex = -1 AndAlso Me.ComboBoxIVA1.Items.Count > 0 Then
            '  Me.ComboBoxIVA1.SelectedIndex = 0
            'End If
            mMovimientoInventario.Movinv_Fecha = Me.dtpFecdesde.Value
            
            mMovimientoInventario.Bodega = Me.ComboBoxBodega1.Bodega
            'mMovimientoInventario.SRI_iva = Me.ComboBoxIVA1.SelectedValue
            mMovimientoInventario.Movinv_porcIVA = Me.txtporciva.Value
            mMovimientoInventario.Movinv_Descto = Me.txtdsctoglobal.Value
            mMovimientoInventario.Pardet_Tipomovinv = TipoMovimientoEnum
            mMovimientoInventario.BodegaDsno = Me.ComboBoxBodega2.Bodega
            mMovimientoInventario.Movinv_Observaciones = Me.txtobservacion.Text

            mMovimientoInventario.Incautacion = Me.CtlBuscaIncautacion1.Incautacion


            Me.DataGridViewDetalles.PardetTipoPago = Me.ComboBoxFormaPago.ParametroDet
            Me.DataGridViewDetalles.PardetTipoPrecio = Me.ComboBoxTipoPrecio.ParametroDet

            If TipoMovimientoEnum = Enumerados.enumTipoMovInv.OrdenProduccion Or TipoMovimientoEnum = Enumerados.enumTipoMovInv.OrdenDesensamble Or TipoMovimientoEnum = Enumerados.enumTipoMovInv.DesperdicioOP Then
                'mMovimientoInventario.Item = Me.CtlBuscaActivo.Item
                If mMovimientoInventario.Item Is Nothing Then
                    Throw New Exception("Debe especificar un activo")
                End If
            Else
                mMovimientoInventario.Item = Nothing
            End If
            mostrar_totales()
            mestallenando = False

            Select Case TipoMovimientoEnum
                Case Enumerados.enumTipoMovInv.Venta, Enumerados.enumTipoMovInv.DevVenta
                    mapear_venta()
                Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.DevCompra
                    mapear_compra()
                Case Enumerados.enumTipoMovInv.Incautacion, Enumerados.enumTipoMovInv.IncautSalida
                    'For Each _movinvdet As MovimientoInventarioDet In mMovimientoInventario.Detalles
                    '    MessageBox.Show("item codigo " + _movinvdet.Item_Codigo.ToString + " item string " + _movinvdet.ItemString)
                    '    MessageBox.Show("item codigo " + _movinvdet.Item.Item_Codigo.ToString + "item descr " + _movinvdet.Item.Item_Descripcion + "item marca " + _movinvdet.Item.MarcaString)
                    'Next
                    mMovimientoInventario.Incaut_Codigo = CtlBuscaIncautacion1.Incautacion.Incaut_Codigo
                    'mapear_Incautacion()
            End Select
        End If

        MessageBox.Show("termine de mapear para CtlMovimiento Inv")

    End Sub

#End Region

#Region "Venta"
  Private mVenta As Venta = Nothing

  Public Sub mapear_venta()
    Dim _enumtipovta As Enumerados.enumTipoVenta
    '_enumtipovta = CType(tipocompraventas(Me.comboTipoCompraVenta.SelectedIndex).Pardet_Secuencia, Enumerados.enumTipoVenta)

    If mMovimientoInventario.Venta Is Nothing Then
      mVenta = New Venta(mSucursal, _enumtipovta, True)
      mVenta.MovimientoInventario = mMovimientoInventario
      mMovimientoInventario.Venta = mVenta
    Else
      mVenta = mMovimientoInventario.Venta
    End If
    mVenta.MovimientoInventario = mMovimientoInventario
    mVenta.Cliente = Me.CtlBuscaCliente1.Cliente
    mVenta.Empleado = Me.CtlBuscaEmpleado1.Empleado
    mVenta.PardetTipoPago = Me.ComboBoxFormaPago.ParametroDet
    mVenta.PardetTipoPrecio = Me.ComboBoxTipoPrecio.ParametroDet
    'mVenta.SRI_tipocomprobante = Me.ComboBoxTipoComprobante1.tipo_comprobante.codigo
    'mVenta.SRI_secuencialtransaccion = Me.ComboBoxTipoComprobante1.tipo_comprobante.secuencial_transaciones.RetornarCodigo(mVenta.Cliente.Entidad.SRICodigo_Identificacion)
    mVenta.Venta_Numero = Me.txtfactura.Value
    'me.ComboBoxCreditoTributario1.credito_tributario.tipos_comprobantes(0
  End Sub

  Private Sub CtlBuscaCliente1_CambioCliente(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaCliente1.CambioItem
    If Me.CtlBuscaCliente1.Cliente Is Nothing Then
      Exit Sub
    End If
    With Me.CtlBuscaCliente1.Cliente
      If .Entidad.Entidadjuridica IsNot Nothing Then
        'Me.txt_otrosdatos.Text = String.Format("Contacto: {0}", .Entidad.Entidadjuridica.ContactoString)
      End If
      'Me.txt_otrosdatos.Text = String.Format("{0}{1}Teléfono:{2}", Me.txt_otrosdatos.Text, vbCrLf, .TelefonosString)

      Me.CtlDireccion1.Entidad = .Entidad
      Me.CtlBuscaEmpleado1.Empleado = .Empleado

      BuscarTipoPrecio()
    End With
  End Sub

  Private Sub BuscarTipoPrecio()
    If Me.CtlBuscaCliente1.Cliente Is Nothing Then
      Exit Sub
    End If
    With Me.CtlBuscaCliente1.Cliente
      If .PardetTipoPrecio IsNot Nothing Then
        Me.ComboBoxTipoPrecio.ParametroDet = .PardetTipoPrecio
      Else
        If Me.ComboBoxFormaPago.ParametroDet IsNot Nothing Then
          Try
            Dim _tpxfp As TipoPagoxTipoPrecio
            _tpxfp = New TipoPagoxTipoPrecio(mSucursal, Me.ComboBoxFormaPago.ParametroDet)
            Me.ComboBoxTipoPrecio.ParametroDet = _tpxfp.PardetTipoPrecio
          Catch ex As Exception
          End Try
        End If
      End If
    End With
  End Sub
#End Region

#Region "Compra"
  Private mCompra As Compra = Nothing

  Public Sub mapear_compra()
    Dim _enumtipocmp As Enumerados.enumTipoCompra
    '_enumtipocmp = CType(tipocompraventas(Me.comboTipoCompraVenta.SelectedIndex).Pardet_Secuencia, Enumerados.enumTipoCompra)

    If mMovimientoInventario.Compra Is Nothing Then
      mCompra = New Compra(mSucursal, _enumtipocmp, True)
      mCompra.MovimientoInventario = mMovimientoInventario
      mMovimientoInventario.Compra = mCompra
    Else
      mCompra = mMovimientoInventario.Compra
    End If
    mCompra.MovimientoInventario = mMovimientoInventario
    mCompra.Proveedor = Me.CtlBuscaProveedor1.Proveedor
    mCompra.PardetTipoPago = Me.ComboBoxFormaPago.ParametroDet
    mCompra.Compra_Numero = Me.msk_compranumero.Text
    mCompra.Compra_Autorizacion = Me.msk_autorizacion.Text
    'If ComboBoxTipoComprobante1.tipo_comprobante Is Nothing Then
    '  Throw New Exception("Debe seleccionar un tipo de comprobante de compra, verifique que el proveedor tenga asignado un RUC válido")
    'End If
    'mCompra.SRI_tipocomprobante = Me.ComboBoxTipoComprobante1.tipo_comprobante.codigo
    'mCompra.SRI_creditotributario = Me.ComboBoxCreditoTributario1.credito_tributario.codigo
    mCompra.Compra_Caducidad = Me.msk_fechacaducidad.Text
    'mCompra.SRI_secuencialtransaccion = Me.ComboBoxTipoComprobante1.tipo_comprobante.secuencial_transaciones.RetornarCodigo(mCompra.Proveedor.Entidad.SRICodigo_Identificacion)
  End Sub

  Private Sub CtlBuscaProveedor1_CambioProveedor(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaProveedor1.CambioItem
    If Me.CtlBuscaProveedor1.Proveedor Is Nothing Then
      Exit Sub
    End If
    With Me.CtlBuscaProveedor1.Proveedor
      If .Entidad.Entidadjuridica IsNot Nothing Then
        'Me.txt_otrosdatos.Text = String.Format("Contacto: {0}", .Entidad.Entidadjuridica.ContactoString)
      End If
      'Me.txt_otrosdatos.Text = String.Format("{0}{1}Teléfono:{2}", Me.txt_otrosdatos.Text, vbCrLf, .TelefonosString)

      Me.CtlDireccion1.Entidad = .Entidad
    End With
  End Sub
#End Region

#Region "Incautacion"
  Private mIncautacion As Reglas.Incautacion = Nothing

  Public Sub mapear_Incautacion()
    '  Dim _enumtipocmp As Enumerados.enumTipoIncautacion
    '_enumtipocmp = CType(tipoIncautacionventas(Me.comboTipoIncautacionVenta.SelectedIndex).Pardet_Secuencia, Enumerados.enumTipoIncautacion)

    If mMovimientoInventario.Incautacion Is Nothing Then
            mIncautacion = New Reglas.Incautacion(mSucursal.OperadorDatos, True)
      mMovimientoInventario.Incautacion = mIncautacion
    Else
      mIncautacion = mMovimientoInventario.Incautacion
    End If
    mIncautacion.Contribuyente = Me.CtlBuscaContribuyente1.Contribuyente
  

    'If ComboBoxTipoComprobante1.tipo_comprobante Is Nothing Then
    '  Throw New Exception("Debe seleccionar un tipo de comprobante de Incautacion, verifique que el Contribuyente tenga asignado un RUC válido")
    'End If
    'mIncautacion.SRI_tipocomprobante = Me.ComboBoxTipoComprobante1.tipo_comprobante.codigo
    'mIncautacion.SRI_creditotributario = Me.ComboBoxCreditoTributario1.credito_tributario.codigo

    'mIncautacion.SRI_secuencialtransaccion = Me.ComboBoxTipoComprobante1.tipo_comprobante.secuencial_transaciones.RetornarCodigo(mIncautacion.Contribuyente.Entidad.SRICodigo_Identificacion)
  End Sub

    Private Sub CtlBuscaContribuyente1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaContribuyente1.CambioItem
        'If Me.CtlBuscaContribuyente1.Contribuyente Is Nothing Then
        '    Exit Sub
        'End If
        'With Me.CtlBuscaContribuyente1.Contribuyente
        '    If .Entidad.Entidadjuridica IsNot Nothing Then
        '        'Me.txt_otrosdatos.Text = String.Format("Contacto: {0}", .Entidad.Entidadjuridica.ContactoString)
        '    End If
        '    'Me.txt_otrosdatos.Text = String.Format("{0}{1}Teléfono:{2}", Me.txt_otrosdatos.Text, vbCrLf, .TelefonosString)

        '    Me.CtlDireccion1.Entidad = .Entidad
        'End With

        Me.CtlBuscaIncautacion1.Contribuyente = Me.CtlBuscaContribuyente1.Contribuyente
        Me.CtlBuscaIncautacion1.Sucursal = Me.Sucursal
        MessageBox.Show("sucursal cargada en buscaIncaut" + Me.Sucursal.Empresa.NombreCompleto)
        Me.CtlBuscaIncautacion1.llenar_datos()

    End Sub

#End Region

#Region "Detalles de factura"

    Sub Llenar_detalles()
        Me.DataGridViewDetalles.MovimientoInventario = mMovimientoInventario

        Me.pnltotalcompleto.Visible = False
        Me.pnltotalsimple.Visible = False
        txttotalgeneralsimple.ReadOnly = True
        Select Case TipoMovimientoEnum
            Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.Venta, Enumerados.enumTipoMovInv.DevCompra, Enumerados.enumTipoMovInv.DevVenta
                Me.pnltotalcompleto.Visible = True
            Case Enumerados.enumTipoMovInv.InvInicial
                Me.pnltotalsimple.Visible = True
            Case Enumerados.enumTipoMovInv.Cxc, Enumerados.enumTipoMovInv.Cxp
                Me.pnltotalsimple.Visible = True
                txttotalgeneralsimple.ReadOnly = False
            Case Enumerados.enumTipoMovInv.IncautSalida, Enumerados.enumTipoMovInv.Incautacion
                Me.pnlformapago.Visible = False
        End Select
    End Sub

    Private Sub txtdsctoglobal_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtdsctoglobal.Validating
        mostrar_totales()
    End Sub

    Private Sub DataGridViewDetalles_Cambio_MovimientoDets(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewDetalles.Cambio_MovimientoDets
        mostrar_totales()
    End Sub

    Private Sub mostrar_totales()
        If mMovimientoInventario Is Nothing Then
            Me.txtsubtotal.Value = 0
            Me.txttotalgeneralsimple.Value = 0
            Me.txtbase0.Value = 0
            Me.txtbasegravada.Value = 0
            Me.txtiva.Value = 0
            Me.txttotalgeneral.Value = 0
        Else
            Me.mMovimientoInventario.Movinv_Descto = Me.txtdsctoglobal.Value
            Me.txtsubtotal.Value = mMovimientoInventario.BaseImponibleRetFte
            Me.txttotalgeneralsimple.Value = mMovimientoInventario.BaseImponibleRetFte
            Me.txtbase0.Value = mMovimientoInventario.Base0
            Me.txtbasegravada.Value = mMovimientoInventario.BaseGravadaIVA
            Me.txtiva.Value = mMovimientoInventario.TotalIva
            Me.txttotalgeneral.Value = mMovimientoInventario.TotalGeneral
        End If
    End Sub

    '  Private Sub ComboBoxCreditoTributario1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBuscaCliente1.CambioItem, CtlBuscaProveedor1.CambioItem
    '    'ComboBoxCreditoTributario1.CambioItem,
    '    llenar_creditotributario()
    '    If sender Is Me.CtlBuscaProveedor1 Then
    '      Try
    '        Me.msk_autorizacion.Text = Me.CtlBuscaProveedor1.Proveedor.Entidad.Entida_AutorizacionFactura
    '        Me.msk_fechacaducidad.Text = Me.CtlBuscaProveedor1.Proveedor.Entidad.Entida_CaducidadFactura
    '      Catch ex As Exception

    '      End Try
    '    End If
    '  End Sub

    '  Sub llenar_creditotributario()
    '    'If tipocompraventas Is Nothing Then
    '    '  comboTipoMovimiento_SelectedIndexChanged(Me, Nothing)
    '    'End If
    '    'Me.ComboBoxTipoComprobante1.credito_tributario = Me.ComboBoxCreditoTributario1.credito_tributario
    '    Select Case _enumtipomov
    '      Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.DevCompra
    '        If Me.CtlBuscaProveedor1.Proveedor Is Nothing Then
    '          Exit Sub
    '        End If
    '        If CType(tipocompraventas(IIf(Me.comboTipoCompraVenta.SelectedIndex = -1, 0, Me.comboTipoCompraVenta.SelectedIndex)).Pardet_Secuencia, Enumerados.enumTipoCompra) = Enumerados.enumTipoCompra.Importacion Then
    '          'Me.ComboBoxTipoComprobante1.Llenar_datos(Me.CtlBuscaProveedor1.Proveedor.Entidad.SRICodigo_Identificacion, Me.dtpFecdesde.Value, credito_tributario.EnumTipoTransaccion.Importacion)
    '        Else
    '          'Me.ComboBoxTipoComprobante1.Llenar_datos(Me.CtlBuscaProveedor1.Proveedor.Entidad.SRICodigo_Identificacion, Me.dtpFecdesde.Value, credito_tributario.EnumTipoTransaccion.Compra)
    '        End If
    '      Case Enumerados.enumTipoMovInv.Venta, Enumerados.enumTipoMovInv.DevVenta
    '        If Me.CtlBuscaCliente1.Cliente Is Nothing Then
    '          Exit Sub
    '        End If
    '        'Me.ComboBoxTipoComprobante1.Llenar_datos(Me.CtlBuscaCliente1.Cliente.Entidad.SRICodigo_Identificacion, Me.dtpFecdesde.Value, credito_tributario.EnumTipoTransaccion.Venta)
    '    End Select
    '  End Sub
#End Region

#Region "Busqueda"
  Private Sub txtnumero_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnumero.Validating
    If Me.txtnumero.Value = 0 Then
      Exit Sub
    End If
    Dim _mov As MovimientoInventario
    Try
      _mov = New MovimientoInventario(mSucursal, TipoMovimientoEnum, CInt(Me.txtnumero.Value))
      MovimientoInventario = _mov
      If _mov.Movinv_esAnulada Then
        Me.BackgroundImage = My.Resources.ANULADA
      Else
        Me.BackgroundImage = Nothing
      End If
    Catch ex As Exception
      MsgBox("No se encontró el movimiento de inventario", MsgBoxStyle.Information, "Información")
    End Try
  End Sub
#End Region

#Region "Tamaño"
  Private Sub CtlMovimientoInventario_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    tamano()
  End Sub

  Private Sub CtlMovimientoInventario_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    tamano()
  End Sub

  Sub tamano()
    Me.pnldetalles.Height = Me.FlowLayoutPanel1.Height - Me.pnldetalles.Location.Y - IIf(Me.pnltotalcompleto.Visible, Me.pnltotalcompleto.Height, 0) - IIf(Me.pnltotalsimple.Visible, Me.pnltotalcompleto.Height, 0) - 5
  End Sub
#End Region

#Region "Cancelar"
  Public Event Cancelar As EventHandler
  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    RaiseEvent Cancelar(Me, Nothing)
  End Sub

  Private Sub ComboBoxTipoPrecio_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxTipoPrecio.CambioItem
    Me.DataGridViewDetalles.PardetTipoPrecio = Me.ComboBoxTipoPrecio.ParametroDet
  End Sub
#End Region


#Region "Formato"
  Public Sub Imprimir()
    If mMovimientoInventario.EsNuevo Then
      Exit Sub
    End If
    If mMovimientoInventario.Pardet_TipomovinvEnum = Enumerados.enumTipoMovInv.Incautacion Then
      Dim f As New FrmIncautacionIngreso(Sistema, Enumerados.EnumOpciones.MovimientoInventario)
      f.Incautacion = MovimientoInventario.Incautacion
      f.ShowDialog()
    Else
      Dim f As New Infoware.Reportes.FrmReportSimple
      f.ArchivoReporte = ArchivoFormato()
      f.Cabecera = mMovimientoInventario
      f.Detalles = mMovimientoInventario.Detalles
      f.Imprimir()
      MsgBox("Impresión enviada, por favor verifique que se haya realizado correctamente", MsgBoxStyle.Information, "Información")
    End If
  End Sub

  Public Sub ModificarFormato()
    If mMovimientoInventario.EsNuevo Then
      Exit Sub
    End If
    Dim f As New Infoware.Reportes.FrmReportSimple
    f.ArchivoReporte = ArchivoFormato()
    f.Cabecera = mMovimientoInventario
    f.Detalles = mMovimientoInventario.Detalles
    f.ShowDialog()
  End Sub

  Private Function ArchivoFormato() As String
    Dim archivo As String
    If TipoMovimientoEnum = Enumerados.enumTipoMovInv.Compra Then
      archivo = Me.Sistema.DirectorioRaiz & "\Formatos\" & mCompra.PardetTipoCompra.Pardet_DatoStr1.Trim & ".rps"

    ElseIf TipoMovimientoEnum = Enumerados.enumTipoMovInv.Venta Then
      archivo = Me.Sistema.DirectorioRaiz & "\Formatos\" & mVenta.PardetTipoVenta.Pardet_DatoStr1.Trim & ".rps"
    Else
      archivo = Me.Sistema.DirectorioRaiz & "\Formatos\" & mMovimientoInventario.PardetTipoMovInv.Pardet_DatoStr1.Trim & ".rps"
    End If
    Return archivo
  End Function
#End Region

    Private Sub DataGridViewDetalles_Load(sender As System.Object, e As System.EventArgs) Handles DataGridViewDetalles.Load

    End Sub

  Private Sub FlowLayoutPanel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles FlowLayoutPanel2.Paint

  End Sub

  Private Sub FlowLayoutPanel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles FlowLayoutPanel1.Paint

  End Sub
End Class
