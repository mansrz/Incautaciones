Imports Infoware.Reglas.General
Imports Infoware.Consola.Base 
Imports Incautacion.Reglas

Public Class FrmMantenimientoPagoRapido
  Private mMovimientoInventario As MovimientoInventario = Nothing
  Public Property MovimientoInventario() As MovimientoInventario
    Get
      Return mMovimientoInventario
    End Get
    Set(ByVal value As MovimientoInventario)
      mMovimientoInventario = value
      If value IsNot Nothing Then
        'Me.CtlPagosDet1.Sistema = Sistema
        llenar_datos()
      End If
    End Set
  End Property

  Sub llenar_datos()
    Me.lbltotfactura.Text = mMovimientoInventario.TotalGeneral.ToString("c")

  End Sub

  Private Function Valorcuadrado() As Decimal
    Dim total As Decimal = 0
    For Each _pago As PagosDet In MovimientoInventario.Pagos
      total += _pago.Pagdet_Valor
    Next
    Return total
  End Function

  Private Sub FrmMantenimientoPagoRapido_AntesAceptar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.AntesAceptar
    If mMovimientoInventario.TotalGeneral > 0 And Me.txtpagadoefectivo.Value < mMovimientoInventario.TotalGeneral Then
      MsgBox("La factura no puede quedar impaga", vbInformation, "Información")
      e.Cancel = True
    End If

    Dim _pago As PagosDet = MovimientoInventario.Pagos.AddNew()
    _pago.Pardet_TipoMovPago = Enumerados.enumTipoMovPagos.Efectivo
    _pago.Pagdet_Valor = -txtpagadoefectivo.Value

    _pago = MovimientoInventario.Pagos.AddNew()
    _pago.Pardet_TipoMovPago = Enumerados.enumTipoMovPagos.Efectivo
    _pago.Pagdet_Valor = -(mMovimientoInventario.TotalGeneral - txtpagadoefectivo.Value)

    Try
      mMovimientoInventario.GuardarPagos()

    Catch ex As Exception
      MsgBox("Error al guardar pagos " + ex.Message, vbCritical, "Error")
      e.Cancel = True
    End Try

  End Sub

  Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpagadoefectivo.TextChanged
    If mMovimientoInventario Is Nothing Then
      Exit Sub
    End If
    Me.lblvuelto.Text = (mMovimientoInventario.TotalGeneral - txtpagadoefectivo.Value).ToString("c")
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub
#End Region

End Class