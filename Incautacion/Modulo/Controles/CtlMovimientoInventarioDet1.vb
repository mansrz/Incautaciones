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
      'Me.CtlMovimientoInventarioDet2.FactorTamanio = value
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

        '  Me.CtlMovimientoInventarioDet2.MovimientoInventario = value.MovimientoInventario
        ' Me.CtlMovimientoInventarioDet2.PardetTipoPago = value.PardetTipoPago
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
        'Me.CtlMovimientoInventarioDet2.ReadOnly = Not value.EsNuevo
  
      End If
      'Me.CtlMovimientoInventarioDet2.MovimientoInventario = value
      '      Me.CtlMantenimientoMovimientoInventarioDet1.BindingSource1 =AcceptRejectRule Me.CtlMovimientoInventarioDet2.BindingSourceDetalles

      If value IsNot Nothing Then
    
        Llenar_detalles()
      End If
    End Set
  End Property

  Public ReadOnly Property MovimientoInventarioDet() As MovimientoInventarioDet
    Get
      ' Return Me.CtlMovimientoInventarioDet2.MovimientoInventarioDet
    End Get
  End Property

  Private mPardetTipoPago As ParametroDet
  Public Property PardetTipoPago() As ParametroDet
    Get
      Return mPardetTipoPago
    End Get
    Set(ByVal value As ParametroDet)
      mPardetTipoPago = value
      'Me.CtlMovimientoInventarioDet2.PardetTipoPago = value
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

  Private Sub CtlMovimientoInventarioDet2_Cambio_MovimientoDets(ByVal sender As Object, ByVal e As System.EventArgs)
    actualizar_totales()
  End Sub

  Public Event RowEnter As DataGridViewCellEventHandler

  Private Sub CtlMovimientoInventarioDet2_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    RaiseEvent RowEnter(sender, e)
  End Sub

  Private Sub CtlGruposTouch1_CambioGrupo(ByVal sender As Object, ByVal e As System.EventArgs)

  End Sub

  Private Sub CtlItemsTouch1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs)
    AgregarLinea()
    Dim mMovimientoInventarioDet As MovimientoInventarioDet = MovimientoInventarioDet
    'If mMovimientoInventarioDet Is Nothing OrElse mMovimientoInventarioDet.Item IsNot Nothing Then
    '  mMovimientoInventarioDet = Me.CtlMovimientoInventarioDet2.BindingSourceDetalles.AddNew
    'End If

    Dim _tipopagoxprecio As TipoPagoxTipoPrecio = Nothing
    If mPardetTipoPago IsNot Nothing Then
      _tipopagoxprecio = New TipoPagoxTipoPrecio(mMovimientoInventario.Sucursal, mPardetTipoPago)
    End If

   

    VerificarCombo()
    actualizar_totales()
    'Me.CtlMovimientoInventarioDet2.BindingSourceDetalles.MoveLast()

    AgregarLinea()
  End Sub

  Sub VerificarCombo()

  End Sub

  Sub AgregarLinea()
    If CType(Me.CtlMantenimientoMovimientoInventarioDet1.BindingSource1.Item(Me.CtlMantenimientoMovimientoInventarioDet1.BindingSource1.Count - 1), MovimientoInventarioDet).Item IsNot Nothing Then
      Me.CtlMantenimientoMovimientoInventarioDet1.BindingSource1.AddNew()
    Else
      Me.CtlMantenimientoMovimientoInventarioDet1.BindingSource1.MoveLast()
    End If

  End Sub

  Private Sub CtlMantenimientoMovimientoInventarioDet1_Actualizodatos(ByVal sender As Object, ByVal e As System.EventArgs)
    'Me.CtlMovimientoInventarioDet2.Invalidate()
    actualizar_totales()
  End Sub

  Private Sub CtlItemsTouch1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

  End Sub

  Private Sub CtlItemsTouch1_Load_1(sender As System.Object, e As System.EventArgs)

  End Sub

  Private Sub CtlGruposTouch1_Load(sender As System.Object, e As System.EventArgs)

  End Sub

  Private Sub TabControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

  End Sub
End Class
