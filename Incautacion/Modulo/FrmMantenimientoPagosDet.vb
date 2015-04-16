Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
'Imports WWTS.Inventario.Reglas
Imports System.Globalization.CultureInfo
Imports Incautacion.Reglas

Public Class FrmMantenimientoPagosDet
#Region "IOpcion"
  Private mMovimientoInventario As MovimientoInventario = Nothing
  Public WriteOnly Property MovimientoInventario() As MovimientoInventario
    Set(ByVal value As MovimientoInventario)
      mMovimientoInventario = value
      MyBase.Tabla = "Detalle de cuentas"

      If value IsNot Nothing Then
      End If
    End Set
  End Property
#End Region

#Region "Parametros"
  Public Property PagosDets() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mPagosDet As PagosDet = Nothing
  Public Property PagosDet() As PagosDet
    Get
      Return mPagosDet
    End Get
    Set(ByVal value As PagosDet)
      mPagosDet = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _PagosDets As New PagosDetList
        _PagosDets.Add(mPagosDet)
        MyBase.BindingSource1.DataSource = GetType(PagosDet)
        MyBase.BindingSource1.DataSource = _PagosDets
      End If
    End Set
  End Property

  Sub llenar_datos()
    mPagosDet = PagosDets.Current
    ValidarRegistro()
    Me.CtlBloqueo1.Restriccion = Restriccion
    Me.dtfecha.Enabled = Not Me.CtlBloqueo1.Bloqueado

    If mPagosDet IsNot Nothing Then
      Me.ComboBoxTipoPago.ParametroDet = mPagosDet.PardetTipoMovPago
      Me.dtfecha.Value = mPagosDet.Pagdet_FechaPago
      ComboBoxTipoPago_CambioItem(Me, Nothing)
      Me.CtlBuscaEntidad21.Entidad = mPagosDet.Entidad
      Me.CtlBuscaEntidad21.TabStop = False
      Select Case mPagosDet.Pardet_TipoMovPago
        Case Enumerados.enumTipoMovPagos.Retencionfuente
          Me.ComboBoxConceptosRetencion1.ParametroDet = mPagosDet.PardetConceptoRetencion
          Me.txtbaseimponible.Value = mPagosDet.Pagdet_BaseImponible
          Me.txtporcret.Value = mPagosDet.Pagdet_PorcAplicable
          Me.msk_compteretnumero.Text = mPagosDet.Pagdet_CompteRetencion
          If mPagosDet.EsNuevo Then
            Me.msk_autorizacion.Text = mPagosDet.MovimientoInventario.Sucursal.Entidadlugar.Entidad.Entida_AutorizacionRetencion
          Else
            Me.msk_autorizacion.Text = mPagosDet.Pagdet_Autorizacion
          End If
        Case Enumerados.enumTipoMovPagos.RetencionIVA
          Me.rdoivabienes.Checked = mPagosDet.Pagdet_esIVABienes
          Me.rdoivaservicios.Checked = Not mPagosDet.Pagdet_esIVABienes
          Me.ComboBoxRetencionIVA.ParametroDet = mPagosDet.PardetRetencionIVA
          Me.txtbaseimponible.Value = mPagosDet.Pagdet_BaseImponible
          Me.txtporcret.Value = mPagosDet.Pagdet_PorcAplicable
          Me.msk_compteretnumero.Text = mPagosDet.Pagdet_CompteRetencion
          If mPagosDet.EsNuevo Then
            Me.msk_autorizacion.Text = mPagosDet.MovimientoInventario.Sucursal.Entidadlugar.Entidad.Entida_AutorizacionRetencion
          Else
            Me.msk_autorizacion.Text = mPagosDet.Pagdet_Autorizacion
          End If
        Case Enumerados.enumTipoMovPagos.Cheque
          If mPagosDet.esCxC Then
            Me.ComboBoxBanco.ParametroDet = mPagosDet.PardetBanco
          Else
            Me.CtlCuentaBancaria1.CuentaBancaria = mPagosDet.CuentaBancaria
          End If
          Me.txtnumcheque.Value = mPagosDet.Pagdet_NumeroCheque
          Me.dtfechacheque.Value = mPagosDet.Pagdet_FechaCheque
        Case Enumerados.enumTipoMovPagos.Tarjetadecredito
          mPagosDet.PardetTarjetaCredito = Me.ComboBoxTarjetaCredito.ParametroDet
          mPagosDet.Pagdet_Voucher = Me.txtvoucher.Text
      End Select
      Me.txtobservacion.Text = mPagosDet.Pagdet_Observacion
      Me.txtvalor.Value = mPagosDet.Pagdet_Valor
      'Me.CtlBuscaCtaContable1.CuentaContable = mPagosDet.CuentaContable
      'Me.ComboboxSubCuentaContable1.ParametroDet = mPagosDet.SubCuentaContable
    End If
  End Sub

  Private Sub Cambio_TipoPago(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
    Me.ComboBoxConceptosRetencion1.Llenar_Datos()
  End Sub

  Private Sub ComboBoxTipoPago_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxTipoPago.CambioItem
    If mPagosDet Is Nothing Then
      Exit Sub
    End If
    MyBase.Tabla = "Detalle de cuentas - " & Me.ComboBoxTipoPago.ParametroDet.Pardet_Descripcion

    Me.pnlretencion.Visible = False
    Me.pnlretencionfuente.Visible = False
    Me.pnlretencioniva.Visible = False
    Me.pnlbanco.Visible = False
    Me.pnlcuentabancaria.Visible = False
    Me.pnlcheque.Visible = False
    Me.pnltarjeta.Visible = False
    pnlcompteret.Visible = False

    mPagosDet.PardetTipoMovPago = Me.ComboBoxTipoPago.ParametroDet

    Select Case mPagosDet.Pardet_TipoMovPago
      Case Enumerados.enumTipoMovPagos.Retencionfuente
        Me.pnlretencion.Visible = True
        Me.pnlretencionfuente.Visible = True
        If mPagosDet.MovimientoInventario IsNot Nothing Then
          Me.txtbaseimponible.Value = mPagosDet.MovimientoInventario.BaseImponibleRetFte
        End If
        pnlcompteret.Visible = mPagosDet.esCxP

        If mPagosDet.esCxP Then
          Me.msk_autorizacion.Text = mMovimientoInventario.Compra.Proveedor.Entidad.Entida_AutorizacionRetencion
        End If
        validar_baseimponible()
        'Me.CtlBuscaCtaContable1.Llenar_Datos("", New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoCtaCtble, Enumerados.enumTipoCuentaContable.RetFte))
      Case Enumerados.enumTipoMovPagos.RetencionIVA
        Me.pnlretencion.Visible = True
        Me.pnlretencioniva.Visible = True
        If mPagosDet.MovimientoInventario IsNot Nothing Then
          Me.txtbaseimponible.Value = mPagosDet.MovimientoInventario.TotalIva
        End If
        pnlcompteret.Visible = mPagosDet.esCxP
        actualizar_comboretiva()
        'Me.CtlBuscaCtaContable1.Llenar_Datos("", New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoCtaCtble, Enumerados.enumTipoCuentaContable.RetIVA))
      Case Enumerados.enumTipoMovPagos.Cheque
        Me.pnlcheque.Visible = True
        If mPagosDet.esCxP Then
          Me.pnlcuentabancaria.Visible = True
        Else
          Me.pnlbanco.Visible = True
        End If
        'Me.CtlBuscaCtaContable1.Llenar_Datos("", New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoCtaCtble, Enumerados.enumTipoCuentaContable.Bancos))
      Case Enumerados.enumTipoMovPagos.Tarjetadecredito
        Me.pnltarjeta.Visible = True
        'Me.CtlBuscaCtaContable1.Llenar_Datos()
      Case Else
        'Me.CtlBuscaCtaContable1.Llenar_Datos()
    End Select
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoPagosDet_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    If Not mRegistroAceptado Then
      PagosDets.RemoveCurrent()
    End If
    Return True
    'Dim _esnuevo As Boolean = mPagosDet.EsNuevo
    'If _esnuevo Then
    '  PagosDets.RemoveCurrent()
    'End If
    'Return _esnuevo
    Return False
  End Function
#End Region

#Region "MovimientosContables eventos"
  Private Sub FrmMantenimientoPagosDet_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _PagosDet As PagosDet = mMovimientoInventario.Pagos.AddNew
    e.NewObject = _PagosDet
  End Sub

  Private Sub FrmMantenimientoPagosDet_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoPagosDet_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    mPagosDet.Pagdet_FechaPago = Me.dtfecha.Value
    mPagosDet.PardetTipoMovPago = Me.ComboBoxTipoPago.ParametroDet
    mPagosDet.Entidad = Me.CtlBuscaEntidad21.Entidad
    Dim factor As Integer = 1

    Select Case mPagosDet.Pardet_TipoMovPago
      Case Enumerados.enumTipoMovPagos.Documento
        factor = -1
      Case Enumerados.enumTipoMovPagos.Retencionfuente
        mPagosDet.PardetConceptoRetencion = Me.ComboBoxConceptosRetencion1.ParametroDet
        mPagosDet.Pagdet_BaseImponible = Me.txtbaseimponible.Value
        mPagosDet.Pagdet_PorcAplicable = Me.txtporcret.Value
        mPagosDet.Pagdet_CompteRetencion = Me.msk_compteretnumero.Text
        mPagosDet.Pagdet_Autorizacion = Me.msk_autorizacion.Text

        If mPagosDet.esCxP Then
          mPagosDet.Pagdet_CompteRetencion = msk_compteretnumero.Text
          mPagosDet.Pagdet_Autorizacion = msk_autorizacion.Text
        End If
      Case Enumerados.enumTipoMovPagos.RetencionIVA
        mPagosDet.Pagdet_esIVABienes = Me.rdoivabienes.Checked
        mPagosDet.PardetRetencionIVA = Me.ComboBoxRetencionIVA.ParametroDet
        mPagosDet.Pagdet_BaseImponible = Me.txtbaseimponible.Value
        mPagosDet.Pagdet_PorcAplicable = Me.txtporcret.Value
        mPagosDet.Pagdet_CompteRetencion = Me.msk_compteretnumero.Text
        mPagosDet.Pagdet_Autorizacion = Me.msk_autorizacion.Text

        If mPagosDet.esCxP Then
          mPagosDet.Pagdet_CompteRetencion = msk_compteretnumero.Text
          mPagosDet.Pagdet_Autorizacion = msk_autorizacion.Text
        End If
      Case Enumerados.enumTipoMovPagos.Cheque
        If mPagosDet.esCxC Then
          mPagosDet.PardetBanco = Me.ComboBoxBanco.ParametroDet
        Else
          mPagosDet.CuentaBancaria = Me.CtlCuentaBancaria1.CuentaBancaria
        End If
        mPagosDet.Pagdet_NumeroCheque = Me.txtnumcheque.Value
        mPagosDet.Pagdet_FechaCheque = Me.dtfechacheque.Value
      Case Enumerados.enumTipoMovPagos.Tarjetadecredito
        mPagosDet.PardetTarjetaCredito = Me.ComboBoxTarjetaCredito.ParametroDet
        mPagosDet.Pagdet_Voucher = Me.txtvoucher.Text
    End Select

    mPagosDet.Pagdet_Observacion = Me.txtobservacion.Text
    mPagosDet.Pagdet_Valor = Math.Abs(Me.txtvalor.Value)
    'mPagosDet.CuentaContable = Me.CtlBuscaCtaContable1.CuentaContable
    'mPagosDet.SubCuentaContable = Me.ComboboxSubCuentaContable1.ParametroDet
  End Sub

  Private mRegistroAceptado As Boolean = False
  Public Property RegistroAceptado As Boolean
    Get
      Return mRegistroAceptado
    End Get
    Set(ByVal value As Boolean)
      mRegistroAceptado = value
    End Set
  End Property

  Private Function Guardar_datos() As Boolean
    PagosDets.EndEdit()

    If mPagosDet.MovimientoInventario IsNot Nothing Then
      mPagosDet.MovimientoInventario.Sucursal.Entidadlugar.Entidad.Entida_AutorizacionRetencion = Me.msk_autorizacion.Text
      mPagosDet.MovimientoInventario.Sucursal.Entidadlugar.Entidad.Guardar()
    End If

    Mapear_datos()
    mRegistroAceptado = True
    'If mPagosDet.Guardar() Then
    '  Return True
    'Else
    '  'MovimientosContables.CancelEdit()
    '  MsgBox("No se puede guardar Movimiento Contable" & Environment.NewLine & mMovimientoInventario.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    '  Return False
    'End If
    Return True
  End Function

  Private Sub FrmMantenimientoPagosDet_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mPagosDet.Eliminar() AndAlso PagosDets.Current IsNot Nothing Then
      PagosDets.RemoveCurrent()
      Me.Close()
    Else
      'MovimientosContables.CancelEdit()
      MsgBox("No se puede eliminar PagosDet" & Environment.NewLine & mMovimientoInventario.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoPagosDet_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPagosDet_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPagosDet_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPagosDet_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

  Private Sub ComboBoxConceptosRetencion1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxConceptosRetencion1.CambioItem
    If Me.ComboBoxConceptosRetencion1.ParametroDet Is Nothing Then
      Me.txtporcret.Value = 0
    Else
      If Me.ComboBoxConceptosRetencion1.ParametroDet.Pardet_DatoBit1 Then 'variable
        Me.txtporcret.Enabled = True
      Else
        Me.txtporcret.Enabled = False
        Me.txtporcret.Text = Me.ComboBoxConceptosRetencion1.ParametroDet.Pardet_DatoDec1
      End If
    End If
    validar_baseimponible()
  End Sub

  Sub validar_baseimponible()
    If mPagosDet Is Nothing Then
      Exit Sub
    End If
    Select Case mPagosDet.Pardet_TipoMovPago
      Case Enumerados.enumTipoMovPagos.Retencionfuente, Enumerados.enumTipoMovPagos.RetencionIVA
        Me.txtvalor.Value = Me.txtbaseimponible.Value * Me.txtporcret.Value / 100
    End Select
  End Sub

  Private Sub rdoivabienes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoivabienes.CheckedChanged
    actualizar_comboretiva()
    validar_baseimponible()
  End Sub

  Sub actualizar_comboretiva()
    If mPagosDet Is Nothing Then
      Exit Sub
    End If
    If Me.rdoivabienes.Checked Then
      Me.ComboBoxRetencionIVA.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, New WWTSParametroDet(Sistema.OperadorDatos, CInt(Enumerados.EnumParametros.TipoRetencionIVa), 1))
    Else
      Me.ComboBoxRetencionIVA.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, New WWTSParametroDet(Sistema.OperadorDatos, CInt(Enumerados.EnumParametros.TipoRetencionIVa), 2))
    End If
  End Sub

  Private Sub ComboBoxRetencionIVA_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxRetencionIVA.CambioItem
    If Not Me.ComboBoxRetencionIVA.Visible Then
      Exit Sub
    End If
    If Me.ComboBoxRetencionIVA.ParametroDet Is Nothing Then
      Me.txtporcret.Value = 0
    Else
      Me.txtporcret.Value = Me.ComboBoxRetencionIVA.ParametroDet.Pardet_DatoDec1
    End If

    validar_baseimponible()
  End Sub

  Private Sub txtporcret_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtporcret.Validated, txtbaseimponible.Validated
    validar_baseimponible()
  End Sub

#Region "New"
  Private mSucursal As Sucursal = Nothing

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Sucursal As Sucursal, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    mSucursal = _Sucursal
    ' Add any initialization after the InitializeComponent() call.
    FrmMantenimientoPagosDet_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _Sucursal As Sucursal, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _Sucursal, _OpcionNuevo)
  End Sub

  Private Sub FrmMantenimientoPagosDet_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    'Me.CtlBuscaCtaContable1.OperadorDatos = Sistema.OperadorDatos
    'Me.CtlBuscaCtaContable1.Llenar_Datos()
    'Me.ComboboxSubCuentaContable1.OperadorDatos = Sistema.OperadorDatos
    'Me.ComboboxSubCuentaContable1.Parametro = Enumerados.EnumParametros.SubCuenta
    'Me.ComboboxSubCuentaContable1.Llenar_Datos()

    Me.PuedeImprimir = True
    Me.PuedeFormato = True

    ComboBoxConceptosRetencion1.OperadorDatos = Sistema.OperadorDatos
    ComboBoxConceptosRetencion1.Parametro = Enumerados.EnumParametros.ConceptoRetencion
    'ComboBoxConceptosRetencion1.Llenar_Datos()

    ComboBoxRetencionIVA.OperadorDatos = Sistema.OperadorDatos
    ComboBoxRetencionIVA.Parametro = Enumerados.EnumParametros.RetencionIVA

    Me.CtlBuscaEntidad21.llenar_datos()

    Me.ComboBoxTipoPago.Parametro = Enumerados.EnumParametros.TipoMovPagos
    Me.ComboBoxTipoPago.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxTipoPago.Llenar_Datos()

    Me.ComboBoxBanco.Parametro = Enumerados.EnumParametros.Banco
    Me.ComboBoxBanco.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxBanco.Llenar_Datos()

    Me.CtlCuentaBancaria1.Empresa = mSucursal.Empresa
    Me.CtlCuentaBancaria1.llenar_datos()

    Me.ComboBoxTarjetaCredito.Parametro = Enumerados.EnumParametros.TarjetaCredito
    Me.ComboBoxTarjetaCredito.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxTarjetaCredito.Llenar_Datos()

    Me.ComboBoxConceptosRetencion1.Llenar_Datos()

  End Sub

#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub

  Private Sub CtlCuentaBancaria1_CambioCuentaBancaria(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlCuentaBancaria1.CambioCuentaBancaria
    If mPagosDet Is Nothing Then
      Exit Sub
    End If
    If mPagosDet.EsNuevo Then
      Me.txtnumcheque.Value = Me.CtlCuentaBancaria1.CuentaBancaria.SiguienteCheque
    End If
    'Me.CtlBuscaCtaContable1.CuentaContable = Me.CtlCuentaBancaria1.CuentaBancaria.CuentaContable
  End Sub

  Private Sub pnlcuentacontable_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlcuentacontable.Paint

  End Sub

  Private Sub CtlBloqueo1_Desbloquear(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBloqueo1.Desbloquear
    Me.dtfecha.Enabled = Not Me.CtlBloqueo1.Bloqueado
  End Sub

  Private Sub FrmMantenimientoPagosDet_Imprimir(sender As Object, e As System.EventArgs) Handles Me.Imprimir
    If PagosDet.EsNuevo AndAlso MsgBox("Antes de imprimir debe guardar el pago, ¿Desea guardar el pago ahora?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If Guardar_datos() And PagosDet.Guardar Then
      Dim f As New Infoware.Reportes.FrmReportSimple
      f.ArchivoReporte = ArchivoFormato()
      f.Cabecera = PagosDet
      f.Detalles = PagosDet.Asignaciones
      f.Imprimir()
    End If
  End Sub

  Private Sub FrmMantenimientoPagosDet_ModificarFormato(sender As Object, e As System.EventArgs) Handles Me.ModificarFormato
    If PagosDet.EsNuevo AndAlso MsgBox("Antes de imprimir debe guardar el pago, ¿Desea guardar el pago ahora?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    If Guardar_datos() And PagosDet.Guardar Then
      Dim f As New Infoware.Reportes.FrmReportSimple
      f.ArchivoReporte = ArchivoFormato()
      f.Cabecera = PagosDet
      f.Detalles = PagosDet.Asignaciones
      f.ShowDialog()
    End If
  End Sub

  Private Function ArchivoFormato() As String
    Return Me.Sistema.DirectorioRaiz & "\Formatos\CancelacionCliente.rps"
  End Function
End Class
