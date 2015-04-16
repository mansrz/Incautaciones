Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports Incautacion.Reglas

'Imports WWTS.Inventario.Reglas

Public Class CtlMovimientoInventarioDet1
  Private mFactorTamanio As Decimal = 1
  Public Property FactorTamanio() As Decimal
    Get
      Return mFactorTamanio
    End Get
    Set(ByVal value As Decimal)
      mFactorTamanio = value
      Me.CtlMovimientoInventarioDet2.FactorTamanio = value
    End Set
  End Property

  Private mVerConfidencial As Boolean = False
  Public Property VerConfidencial As Boolean
    Get
      Return mVerConfidencial
    End Get
    Set(ByVal value As Boolean)
      mVerConfidencial = value
      Me.CtlMantenimientoMovimientoInventarioDet1.VerConfidencial = mVerConfidencial

    End Set
  End Property

  Private mPardetTipoInventario As WWTSParametroDet = Nothing
  Public Property PardetTipoInventario As WWTSParametroDet
    Get
      Return mPardetTipoInventario
    End Get
    Set(ByVal value As WWTSParametroDet)
      mPardetTipoInventario = value
      Me.CtlMantenimientoMovimientoInventarioDet1.PardetTipoInventario = value
    End Set
  End Property

  Private mVenta As Venta = Nothing
  Public Property Venta() As Venta
    Get
      Return mVenta
    End Get
    Set(ByVal value As Venta)
      mVenta = value
      If value IsNot Nothing Then
        MovimientoInventario = value.MovimientoInventario
        PardetTipoPago = value.PardetTipoPago

        Me.CtlMovimientoInventarioDet2.MovimientoInventario = value.MovimientoInventario
        Me.CtlMovimientoInventarioDet2.PardetTipoPago = value.PardetTipoPago
      End If
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
        Me.CtlMovimientoInventarioDet2.ReadOnly = Not value.EsNuevo
        Me.CtlGruposTouch1.Enabled = value.EsNuevo
        Me.CtlItemsTouch1.Enabled = value.EsNuevo
      End If
      Me.CtlMovimientoInventarioDet2.MovimientoInventario = value
      Me.CtlMantenimientoMovimientoInventarioDet1.BindingSource1 = Me.CtlMovimientoInventarioDet2.BindingSourceDetalles

      If value IsNot Nothing Then
        Me.CtlGruposTouch1.OperadorDatos = value.OperadorDatos
        Me.CtlItemsTouch1.OperadorDatos = value.OperadorDatos

        Me.CtlGruposTouch1.Llenar_datos()
        Llenar_detalles()
      End If
    End Set
  End Property

  Public ReadOnly Property MovimientoInventarioDet() As MovimientoInventarioDet
    Get
      Return Me.CtlMovimientoInventarioDet2.MovimientoInventarioDet
    End Get
  End Property

  Private mPardetTipoPago As ParametroDet
  Public Property PardetTipoPago() As ParametroDet
    Get
      Return mPardetTipoPago
    End Get
    Set(ByVal value As ParametroDet)
      mPardetTipoPago = value
      Me.CtlMovimientoInventarioDet2.PardetTipoPago = value
    End Set
  End Property

  Private mPardetTipoPrecio As ParametroDet
  Public Property PardetTipoPrecio As ParametroDet
    Get
      Return mPardetTipoPrecio
    End Get
    Set(ByVal value As ParametroDet)
      mPardetTipoPrecio = value
      Me.CtlMantenimientoMovimientoInventarioDet1.PardetTipoPrecio = value
    End Set
  End Property

#Region "Detalles de factura"
  Private Sub Llenar_detalles()
    actualizar_totales()
  End Sub

  Public Event Cambio_MovimientoDets As EventHandler
  Private Sub actualizar_totales()
    RaiseEvent Cambio_MovimientoDets(Me, Nothing)
  End Sub
#End Region

  Private Sub CtlMovimientoInventarioDet2_Cambio_MovimientoDets(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlMovimientoInventarioDet2.Cambio_MovimientoDets
    actualizar_totales()
  End Sub

  Public Event RowEnter As DataGridViewCellEventHandler

  Private Sub CtlMovimientoInventarioDet2_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CtlMovimientoInventarioDet2.RowEnter
    RaiseEvent RowEnter(sender, e)
  End Sub

  Private Sub CtlGruposTouch1_CambioGrupo(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlGruposTouch1.CambioGrupo
    Me.CtlItemsTouch1.Grupo = Me.CtlGruposTouch1.Grupo
  End Sub

  Private Sub CtlItemsTouch1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlItemsTouch1.CambioItem
    AgregarLinea()
    Dim mMovimientoInventarioDet As MovimientoInventarioDet = MovimientoInventarioDet
    'If mMovimientoInventarioDet Is Nothing OrElse mMovimientoInventarioDet.Item IsNot Nothing Then
    '  mMovimientoInventarioDet = Me.CtlMovimientoInventarioDet2.BindingSourceDetalles.AddNew
    'End If

    Dim _tipopagoxprecio As TipoPagoxTipoPrecio = Nothing
    If mPardetTipoPago IsNot Nothing Then
      _tipopagoxprecio = New TipoPagoxTipoPrecio(mMovimientoInventario.Sucursal, mPardetTipoPago)
    End If

    mMovimientoInventarioDet.Item = Me.CtlItemsTouch1.Item
    mMovimientoInventarioDet.Moinde_Descripcion = ""
    mMovimientoInventarioDet.Moinde_Cantidad = Me.CtlItemsTouch1.Cantidad
    mMovimientoInventarioDet.PardetUnidadMedida = Me.CtlItemsTouch1.PardetUnidadMedida

    Dim _unidadmedidaconversion As UnidadMedidaConversion
    _unidadmedidaconversion = New UnidadMedidaConversion(Me.CtlItemsTouch1.Item.PardetUnidadMedida, Me.CtlItemsTouch1.PardetUnidadMedida)

    mMovimientoInventarioDet.Moinde_Valor = Me.CtlItemsTouch1.Item.BuscarValor(MovimientoInventario.Pardet_Tipomovinv, MovimientoInventario.Sucursal, _tipopagoxprecio.PardetTipoPrecio, mMovimientoInventario.Movinv_porcIVA, mMovimientoInventario.Bodega, Me.CtlItemsTouch1.Cantidad) * (1 / _unidadmedidaconversion.Unmeco_Factor)

    mMovimientoInventarioDet.Moinde_Descto = 0
    mMovimientoInventarioDet.Moinde_Aplicaiva = Me.CtlItemsTouch1.Item.Item_Aplicaiva

    VerificarCombo()
    actualizar_totales()
    'Me.CtlMovimientoInventarioDet2.BindingSourceDetalles.MoveLast()

    AgregarLinea()
  End Sub

  Sub VerificarCombo()
    If Me.CtlItemsTouch1.Item.Item_Combo Then
      Dim posicionpadre As Integer = Me.CtlMantenimientoMovimientoInventarioDet1.BindingSource1.Position
      For Each _itemdetalle As ItemDetalle In Me.CtlItemsTouch1.Item.DetallesCombo(MovimientoInventarioDet.MovimientoInventario.Sucursal)
        Dim mmovdet As New MovimientoInventarioDet(MovimientoInventarioDet.MovimientoInventario, True)
        mmovdet.Item = _itemdetalle.ItemDetalle
        mmovdet.PardetUnidadMedida = _itemdetalle.PardetUnidadMedida
        mmovdet.Moinde_Cantidad = _itemdetalle.IteDet_Cantidad
        mmovdet.Moinde_Valor = _itemdetalle.IteDet_Valor
        mmovdet.Moinde_esDetalleCombo = True

        posicionpadre += 1
        Me.CtlMantenimientoMovimientoInventarioDet1.BindingSource1.Insert(posicionpadre, mmovdet)
      Next
      'RaiseEvent Actualizodatos(Me, Nothing)
    End If
  End Sub

  Sub AgregarLinea()
    If CType(Me.CtlMantenimientoMovimientoInventarioDet1.BindingSource1.Item(Me.CtlMantenimientoMovimientoInventarioDet1.BindingSource1.Count - 1), MovimientoInventarioDet).Item IsNot Nothing Then
      Me.CtlMantenimientoMovimientoInventarioDet1.BindingSource1.AddNew()
    Else
      Me.CtlMantenimientoMovimientoInventarioDet1.BindingSource1.MoveLast()
    End If

  End Sub

  Private Sub CtlMantenimientoMovimientoInventarioDet1_Actualizodatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlMantenimientoMovimientoInventarioDet1.Actualizodatos
    Me.CtlMovimientoInventarioDet2.Invalidate()
    actualizar_totales()
  End Sub

  Private Sub CtlItemsTouch1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlItemsTouch1.Load

  End Sub
End Class
