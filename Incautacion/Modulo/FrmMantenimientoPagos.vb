Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

'Imports WWTS.Inventario.Reglas

Public Class FrmMantenimientoPagos
  Private mDesdeContabilidad As Boolean = False
  Public Property DesdeContabilidad() As Boolean
    Get
      Return mDesdeContabilidad
    End Get
    Set(ByVal value As Boolean)
      mDesdeContabilidad = value
    End Set
  End Property

  Private mEntidad As Entidad = Nothing
  Public Property Entidad As Entidad
    Get
      Return mEntidad
    End Get
    Set(ByVal value As Entidad)
      mEntidad = value
      Llenar_datos()
    End Set
  End Property

  Private mTipoCuenta As Enumerados.enumTipoCuenta = Enumerados.enumTipoCuenta.cxc
  Public Property TipoCuenta As Enumerados.enumTipoCuenta
    Get
      Return mTipoCuenta
    End Get
    Set(ByVal value As Enumerados.enumTipoCuenta)
      mTipoCuenta = value
      Llenar_datos()
    End Set
  End Property

  Private mMovimientoInventario As MovimientoInventario
  Public Property MovimientoInventario() As MovimientoInventario
    Get
      Return mMovimientoInventario
    End Get
    Set(ByVal value As MovimientoInventario)
      mMovimientoInventario = value
      If value IsNot Nothing Then
        If mMovimientoInventario.Compra IsNot Nothing Then
          TipoCuenta = Enumerados.enumTipoCuenta.cxp
        End If
        If mMovimientoInventario.Venta IsNot Nothing Then
          TipoCuenta = Enumerados.enumTipoCuenta.cxc
        End If
        mSucursal = mMovimientoInventario.Sucursal
        Entidad = mMovimientoInventario.Entidad
        Llenar_datos()
      End If
    End Set
  End Property

  Public ReadOnly Property PagosDet() As PagosDet
    Get
      If Me.CtlPagosDet1.CurrentRow.Index >= 0 AndAlso mMovimientoInventario IsNot Nothing AndAlso mMovimientoInventario.Pagos.Count > 0 Then
        Return mMovimientoInventario.Pagos.Item(Me.CtlPagosDet1.CurrentRow.Index)
      Else
        Return Nothing
      End If
    End Get
  End Property

  Private Sub Llenar_datos()
    If Entidad Is Nothing OrElse mSucursal Is Nothing Then
      Exit Sub
    End If
    'Me.lbltotfactura.Text = mMovimientoInventario.TotalGeneral.ToString("c")
    If mMovimientoInventario Is Nothing Then
      Me.CtlPagosDet1.Entidad = Entidad
      Me.CtlPagosDet1.Sucursal = mSucursal
      Me.CtlPagosDet1.TipoCuenta = TipoCuenta
    Else
      Me.CtlPagosDet1.MovimientoInventario = mMovimientoInventario
    End If

    'Me.ComboBoxRegistroContable1.OperadorDatos = Sistema.OperadorDatos
    'Me.ComboBoxRegistroContable1.Llenar_datos()
    'Me.ComboBoxRegistroContable1.RegistroContable = mMovimientoInventario.RegistroContable

    'Me.CtlBuscaCtaContable1.OperadorDatos = Sistema.OperadorDatos
    'If mMovimientoInventario.Compra IsNot Nothing Then
    '  Me.CtlBuscaCtaContable1.Llenar_Datos("", New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoCtaCtble, Enumerados.enumTipoCuentaContable.CxP))
    'Else
    '  Me.CtlBuscaCtaContable1.Llenar_Datos("", New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoCtaCtble, Enumerados.enumTipoCuentaContable.CxC))
    'End If
    'Me.CtlBuscaCtaContable1.CuentaContable = mMovimientoInventario.CuentaContable

    'Me.ComboboxSubCuentaContable1.OperadorDatos = Sistema.OperadorDatos
    'Me.ComboboxSubCuentaContable1.Parametro = Enumerados.EnumParametros.SubCuenta
    'Me.ComboboxSubCuentaContable1.Llenar_Datos()
    'Me.ComboboxSubCuentaContable1.ParametroDet = mMovimientoInventario.SubCuentaContable
  End Sub

  Private Sub CtlPagosDet1_Cambio_MovimientoDets(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlPagosDet1.Cambio_MovimientoDets
    Actualizar_Saldos()
  End Sub

  Private Sub Actualizar_Saldos()
    Me.lbl_pagado.Text = Valorcuadrado.ToString("c")
    Me.lbl_pendiente.Text = Me.CtlPagosDet1.ValorDocumentos.ToString("c")
  End Sub

  Private Function Valorcuadrado() As Decimal
    Return Me.CtlPagosDet1.ValorCuadrado
  End Function

  Private Sub VueltoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VueltoToolStripMenuItem.Click, btnvuelto.Click
    If Valorcuadrado() <> 0 Then
      Dim _pago As PagosDet = MovimientoInventario.Pagos.AddNew()
      _pago.Pardet_TipoMovPago = Enumerados.enumTipoMovPagos.Efectivo
      _pago.Pagdet_Valor = -Valorcuadrado()
      Actualizar_Saldos()
    End If
  End Sub

  Private Sub GuardarYCerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarYCerrarToolStripMenuItem.Click, btnguardar.Click
    If Guardar() Then
      GenerarAsientoContable()
      Me.Close()
    End If
  End Sub

  Private Function Guardar() As Boolean
    Try
      'mMovimientoInventario.SubCuentaContable = ComboboxSubCuentaContable1.ParametroDet
      'mMovimientoInventario.RegistroContable = Me.ComboBoxRegistroContable1.RegistroContable
      'mMovimientoInventario.CuentaContable = Me.CtlBuscaCtaContable1.CuentaContable
      
      Return Me.CtlPagosDet1.GuardarPagos()
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      Return False
    End Try
  End Function

  Public Sub GenerarAsientoContable()
    Dim puedecont As Boolean = True

    If Not mDesdeContabilidad Then
      Try
        'If mMovimientoInventario.RegistroContable Is Nothing Then
        '  Throw New Exception("Debe seleccionar un registro contable para generar el asiento contable")
        'End If
        'If mMovimientoInventario.CuentaContable Is Nothing Then
        '  Throw New Exception("Debe seleccionar cuenta contable de provisión para generar el asiento contable")
        'End If
        'If mMovimientoInventario.SubCuentaContable Is Nothing Then
        '  Throw New Exception("Debe seleccionar una subcuenta de provisión para generar el asiento contable")
        'End If

        'Dim cont As Integer = 0
        'For Each _pago As PagosDet In mMovimientoInventario.Pagos
        '  If Not _pago.Pagdet_esContabilizado Then
        '    cont += 1
        '    If _pago.CuentaContable Is Nothing Then
        '      Throw New Exception("Existe un detalle de pago sin cuenta contable")
        '    End If
        '    If _pago.SubCuentaContable Is Nothing Then
        '      Throw New Exception("Existe un detalle de pago sin subcuenta contable")
        '    End If
        '  End If
        'Next
        'If cont = 0 Then
        '  puedecont = False
        'End If

      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        puedecont = False
      End Try

      'If puedecont Then
      '  Dim mmovcont As New MovimientoContable(mMovimientoInventario.Sucursal.Empresa, mMovimientoInventario.RegistroContable, True)
      '  mmovcont.PardetTipoCompte = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoCompteContabilidad, 1)
      '  'campo en movimientoinventario
      '  'mmovcont.MovCtb_Fecha=
      '  Dim mObservacion As String = String.Format("F./{0} de {1} {2}", mMovimientoInventario.CompraVentaNumero, mMovimientoInventario.Movinv_Fecha.ToShortDateString, mMovimientoInventario.ClienteProveedorString)

      '  mmovcont.MovCtb_Observacion = mObservacion

      '  Dim cuadre As Decimal = 0
      '  For Each _pago As PagosDet In mMovimientoInventario.Pagos
      '    If Not _pago.Pagdet_esContabilizado Then
      '      Dim mmovcontdet As New MovimientoContableDet(Sistema.OperadorDatos, True)
      '      mmovcont.MovCtb_Fecha = _pago.Pagdet_FechaPago
      '      mmovcontdet.Movimientocontable = mmovcont
      '      mmovcontdet.MoCtde_Valor = _pago.Pagdet_Valor * -1
      '      mmovcontdet.MoCtde_Detalle = mObservacion
      '      mmovcontdet.CuentaContable = _pago.CuentaContable
      '      mmovcontdet.SubCuentaContable = _pago.SubCuentaContable
      '      mmovcontdet.PagosDet = _pago

      '      If _pago.Pardet_TipoMovPagoEnum = Enumerados.enumTipoMovPagos.Cheque Then
      '        mmovcontdet.MovimientoBancario.Cuentabancaria = _pago.CuentaBancaria
      '        mmovcontdet.MovimientoBancario.MovBan_NumCheque = _pago.Pagdet_NumeroCheque
      '        mmovcontdet.MovimientoBancario.MovBan_FechaCheque = _pago.Pagdet_FechaCheque
      '        mmovcontdet.MovimientoBancario.EntidadBeneficiario = _pago.MovimientoInventario.ClienteProveedor
      '        mmovcontdet.MovimientoBancario.Pardet_TipoMovBanEnum = Enumerados.enumTipoMovimientoBancario.Cheque
      '      End If
      '      mmovcont.Detalles.Add(mmovcontdet)
      '      cuadre += _pago.Pagdet_Valor * -1
      '    End If
      '  Next

      '  If cuadre <> 0 Then
      '    Dim mmovcontdet As New MovimientoContableDet(Sistema.OperadorDatos, True)
      '    mmovcontdet.Movimientocontable = mmovcont
      '    mmovcontdet.MoCtde_Valor = -cuadre
      '    mmovcontdet.MoCtde_Detalle = mObservacion
      '    mmovcontdet.CuentaContable = mMovimientoInventario.CuentaContable
      '    mmovcontdet.SubCuentaContable = mMovimientoInventario.SubCuentaContable
      '    mmovcontdet.PagosDet = mMovimientoInventario.Pagos.Item(0)
      '    mmovcont.Detalles.Add(mmovcontdet)
      '  End If

      '  Dim f As New FrmMantenimientoMovimientoContable(Sistema, Enumerados.EnumOpciones.ListadoMovimientosContables, mMovimientoInventario.Sucursal, mMovimientoInventario.RegistroContable)
      '  f.MovimientoContable = mmovcont
      '  f.ShowDialog()
      'End If
    End If
  End Sub

#Region "New"
  Private mSucursal As Sucursal = Nothing

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Sucursal As Sucursal, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    mSucursal = _Sucursal
    ' Add any initialization after the InitializeComponent() call.
    FrmMantenimientoPagos_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _Sucursal As Sucursal, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _Sucursal, _OpcionNuevo)
  End Sub

  Private Sub FrmMantenimientoPagos_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.CtlPagosDet1.Sucursal = mSucursal
  End Sub
#End Region

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    Me.CtlPagosDet1.AgregarPago()
  End Sub
End Class