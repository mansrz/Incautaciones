Imports Infoware.Reglas.General 
Imports Incautacion.Reglas

'Imports WWTS.Inventario.Reglas

Public Class FrmBuscaMovimientoInventario
  Private mSucursal As Sucursal
  Public Property Sucursal() As Sucursal
    Get
      Return mSucursal
    End Get
    Set(ByVal value As Sucursal)
      mSucursal = value

      If value IsNot Nothing Then
        Me.ComboBoxTipoInventario1.OperadorDatos = mSucursal.OperadorDatos
        Me.ComboBoxTipoInventario1.Parametro = Enumerados.EnumParametros.TipoMovInventario
        Me.ComboBoxTipoInventario1.Llenar_Datos()

        Me.ComboBoxTipoCompraVenta.OperadorDatos = mSucursal.OperadorDatos
      End If
    End Set
  End Property

  Private mTipoMovInventario As Enumerados.enumTipoMovInv
  Public Property TipoMovInventario() As Enumerados.enumTipoMovInv
    Get
      Return mTipoMovInventario
    End Get
    Set(ByVal value As Enumerados.enumTipoMovInv)
      mTipoMovInventario = value
      If mSucursal IsNot Nothing Then
        Me.ComboBoxTipoInventario1.ParametroDet = New WWTSParametroDet(mSucursal.OperadorDatos, CInt(Enumerados.EnumParametros.TipoMovInventario), CInt(value))
        Me.ComboBoxTipoInventario1.Enabled = False
      End If
    End Set
  End Property

  Private Sub ComboBoxTipoInventario1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxTipoInventario1.CambioItem
    Me.pnltipocompraventa.Visible = False
    Select Case CType(Me.ComboBoxTipoInventario1.ParametroDet.Pardet_Secuencia, Enumerados.enumTipoMovInv)
      Case Enumerados.enumTipoMovInv.Compra
        Me.pnltipocompraventa.Visible = True
        Me.ComboBoxTipoCompraVenta.Parametro = Enumerados.EnumParametros.TipoCompra
        Me.ComboBoxTipoCompraVenta.Llenar_Datos()
      Case Enumerados.enumTipoMovInv.Venta
        Me.pnltipocompraventa.Visible = True
        Me.ComboBoxTipoCompraVenta.Parametro = Enumerados.EnumParametros.TipoVenta
        Me.ComboBoxTipoCompraVenta.Llenar_Datos()
    End Select
  End Sub

  Public ReadOnly Property MovimientoInventario() As MovimientoInventario
    Get
      Try
        Select Case CType(Me.ComboBoxTipoInventario1.ParametroDet.Pardet_Secuencia, Enumerados.enumTipoMovInv)
          Case Enumerados.enumTipoMovInv.Compra
            Dim compra As New Compra(mSucursal, CType(Me.ComboBoxTipoCompraVenta.ParametroDet.Pardet_Secuencia, Enumerados.enumTipoCompra), CInt(Me.txtnumero.Value))
            Return compra.MovimientoInventario
          Case Enumerados.enumTipoMovInv.Venta
            Dim venta As New Venta(mSucursal, CType(Me.ComboBoxTipoCompraVenta.ParametroDet.Pardet_Secuencia, Enumerados.enumTipoVenta), CInt(Me.txtnumero.Value))
            Return venta.MovimientoInventario
          Case Else
            Dim movinv As New MovimientoInventario(mSucursal, CType(Me.ComboBoxTipoInventario1.ParametroDet.Pardet_Secuencia, Enumerados.enumTipoMovInv), CInt(Me.txtnumero.Value))
            Return movinv
        End Select
      Catch ex As Exception
        Return Nothing
      End Try
    End Get
  End Property

  Public ReadOnly Property Venta() As Venta
    Get
      Try
        Select Case CType(Me.ComboBoxTipoInventario1.ParametroDet.Pardet_Secuencia, Enumerados.enumTipoMovInv)
          Case Enumerados.enumTipoMovInv.Venta
            Dim _venta As New Venta(mSucursal, CType(Me.ComboBoxTipoCompraVenta.ParametroDet.Pardet_Secuencia, Enumerados.enumTipoVenta), CInt(Me.txtnumero.Value))
            Return _venta
          Case Else
            Return Nothing
        End Select
      Catch ex As Exception
        Return Nothing
      End Try
    End Get
  End Property

  Public ReadOnly Property Compra() As Compra
    Get
      Try
        Select Case CType(Me.ComboBoxTipoInventario1.ParametroDet.Pardet_Secuencia, Enumerados.enumTipoMovInv)
          Case Enumerados.enumTipoMovInv.Compra
            Dim _compra As New Compra(mSucursal, CType(Me.ComboBoxTipoCompraVenta.ParametroDet.Pardet_Secuencia, Enumerados.enumTipoCompra), CInt(Me.txtnumero.Value))
            Return _compra
          Case Else
            Return Nothing
        End Select
      Catch ex As Exception
        Return Nothing
      End Try
    End Get
  End Property
End Class