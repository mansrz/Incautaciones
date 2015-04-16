'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports Infoware.Reglas.General


#Region "Venta"
Public Class Venta

  Const _Procedimiento As String = "proc_Venta"

  Private mMovimientoInventario As MovimientoInventario = Nothing

  Private mCliente As Cliente = Nothing

  Private mTipomovimientocompraventa As TipoMovimientoCompraVenta = Nothing

  Private mEmpleado As Empleado = Nothing

  Private mSucursal As Sucursal = Nothing

  Private mPardetTipoVenta As WWTSParametroDet = Nothing

  Private mPardetTipoPago As WWTSParametroDet = Nothing

  Private mPardetTipoPrecio As WWTSParametroDet = Nothing

  Private mPardetTipoDireccion As WWTSParametroDet = Nothing

  Public Sub New(ByVal _Empresa As Empresa, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _Empresa.OperadorDatos
    Empres_Codigo = _Empresa.Empres_Codigo
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _Pardet_TipoVenta As Enumerados.enumTipoVenta, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _Sucursal.OperadorDatos
    Sucursal = _Sucursal
    Pardet_TipoVenta = _Pardet_TipoVenta
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _Pardet_TipoVenta As Enumerados.enumTipoVenta, ByVal _Venta_Numero As Integer)
    Me.New(_Sucursal, _Pardet_TipoVenta, False)
    Venta_Numero = _Venta_Numero
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto Venta")
    End If
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _PardetTipoMovinv As WWTSParametroDet, ByVal _Movinv_Secuencia As Integer, ByVal _estricto As Boolean)
    MyBase.New()
    OperadorDatos = _Sucursal.OperadorDatos
    Sucursal = _Sucursal
    Parame_Tipomovinv = _PardetTipoMovinv.Parame_Codigo
    Pardet_Tipomovinv = _PardetTipoMovinv.Pardet_Secuencia
    Movinv_Secuencia = _Movinv_Secuencia
    If Me.RecargarporMovimientoInventario Then
    Else
      If _estricto Then
        Throw New System.Exception("No se puede cargar objeto Venta")
      End If
    End If
  End Sub

  Public Overridable Shadows Property Pardet_TipoVentaEnum() As Enumerados.enumTipoVenta
    Get
      Return CType(Pardet_TipoVenta, Enumerados.enumTipoVenta)
    End Get
    Set(ByVal value As Enumerados.enumTipoVenta)
      Parame_TipoVenta = CInt(Enumerados.EnumParametros.TipoVenta)
      Pardet_TipoVenta = CInt(value)
    End Set
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetTipoVenta() As WWTSParametroDet
    Get
      If Me.mPardetTipoVenta Is Nothing AndAlso Pardet_TipoVenta > 0 Then
        Me.mPardetTipoVenta = New WWTSParametroDet(OperadorDatos, Parame_TipoVenta, Pardet_TipoVenta)
      End If
      Return Me.mPardetTipoVenta
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoVenta = value
      Parame_TipoVenta = value.Parame_Codigo
      Pardet_TipoVenta = value.Pardet_Secuencia
    End Set
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetTipoPago() As WWTSParametroDet
    Get
      If Me.mPardetTipoPago Is Nothing AndAlso Pardet_TipoPago > 0 Then
        Me.mPardetTipoPago = New WWTSParametroDet(OperadorDatos, Parame_TipoPago, Pardet_TipoPago)
      End If
      Return Me.mPardetTipoPago
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoPago = value
      Parame_TipoPago = value.Parame_Codigo
      Pardet_TipoPago = value.Pardet_Secuencia
    End Set
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetTipoPrecio() As WWTSParametroDet
    Get
      If Me.mPardetTipoPrecio Is Nothing AndAlso Pardet_TipoPrecio > 0 Then
        Me.mPardetTipoPrecio = New WWTSParametroDet(OperadorDatos, Parame_TipoPrecio, Pardet_TipoPrecio)
      End If
      Return Me.mPardetTipoPrecio
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoPrecio = value
      Parame_TipoPrecio = value.Parame_Codigo
      Pardet_TipoPrecio = value.Pardet_Secuencia
    End Set
  End Property

  'WWTSParametroDet
  Public Overridable Property PardetTipoDireccion() As WWTSParametroDet
    Get
      If Me.mPardetTipoDireccion Is Nothing AndAlso Pardet_Tipodireccion > 0 Then
        Me.mPardetTipoDireccion = New WWTSParametroDet(OperadorDatos, Parame_Tipodireccion, Pardet_Tipodireccion)
      End If
      Return Me.mPardetTipoDireccion
    End Get
    Set(ByVal value As WWTSParametroDet)
      Me.mPardetTipoDireccion = value
      Parame_Tipodireccion = value.Parame_Codigo
      Pardet_Tipodireccion = value.Pardet_Secuencia
    End Set
  End Property

  'Sucursal
  Public Overridable Property Sucursal() As Sucursal
    Get
      If Me.mSucursal Is Nothing AndAlso Sucurs_Codigo > 0 Then
        Me.mSucursal = New Sucursal(New Empresa(OperadorDatos, Empres_Codigo), Sucurs_Codigo)
      End If
      Return Me.mSucursal
    End Get
    Set(ByVal value As Sucursal)
      Me.mSucursal = value
      Empres_Codigo = value.Empres_Codigo
      Sucurs_Codigo = value.Sucurs_Codigo
    End Set
  End Property

  'MovimientoInventario
  Public Overridable Property MovimientoInventario() As MovimientoInventario
    Get
      If Me.mMovimientoInventario Is Nothing Then
        If Movinv_Secuencia > 0 Then
          Me.mMovimientoInventario = New MovimientoInventario(New Sucursal(New Empresa(OperadorDatos, Empres_Codigo), Sucurs_Codigo), Enumerados.enumTipoMovInv.Venta, Movinv_Secuencia)
        Else
          Me.mMovimientoInventario = New MovimientoInventario(New Sucursal(New Empresa(OperadorDatos, Empres_Codigo), Sucurs_Codigo), Enumerados.enumTipoMovInv.Venta, True)
        End If
        mMovimientoInventario.Venta = Me
      End If
      Return Me.mMovimientoInventario
    End Get
    Set(ByVal value As MovimientoInventario)
      Me.mMovimientoInventario = value
      Parame_Tipomovinv = value.Parame_Tipomovinv
      Pardet_Tipomovinv = value.Pardet_Tipomovinv
      Empres_Codigo = value.Empres_Bodega
      Sucurs_Codigo = value.Sucurs_Bodega
      Movinv_Secuencia = value.Movinv_Secuencia
    End Set
  End Property

  'Cliente
  Public Overridable Property Cliente() As Cliente
    Get
      If Me.mCliente Is Nothing AndAlso Entida_Cliente > 0 Then
        Me.mCliente = New Cliente(OperadorDatos, Entida_Cliente)
      End If
      Return Me.mCliente
    End Get
    Set(ByVal value As Cliente)
      If value Is Nothing Then
        Throw New Exception("Debe seleccionar un cliente")
      End If
      Me.mCliente = value
      Entida_Cliente = value.Entida_Codigo
    End Set
  End Property

  'Tipomovimientocompraventa
  Public Overridable Property Tipomovimientocompraventa() As TipoMovimientoCompraVenta
    Get
      If Me.mTipomovimientocompraventa Is Nothing Then
        Me.mTipomovimientocompraventa = New TipoMovimientoCompraVenta(OperadorDatos, Me.Parame_TipoVenta, Pardet_TipoVenta, Empres_Codigo, Sucurs_Codigo)
      End If
      Return Me.mTipomovimientocompraventa
    End Get
    Set(ByVal value As TipoMovimientoCompraVenta)
      Me.mTipomovimientocompraventa = value
      Parame_TipoVenta = value.Parame_TipoCompraVenta
      Pardet_TipoVenta = value.Pardet_TipoCompraVenta
      Empres_Codigo = value.Empres_Codigo
      Sucurs_Codigo = value.Sucurs_Codigo
    End Set
  End Property

  'Empleado
  Public Overridable Property Empleado() As Empleado
    Get
      If Me.mEmpleado Is Nothing AndAlso Entida_Vendedor > 0 Then
        Me.mEmpleado = New Empleado(OperadorDatos, Entida_Vendedor)
      End If
      Return Me.mEmpleado
    End Get
    Set(ByVal value As Empleado)
      If value Is Nothing Then
        Throw New Exception("Debe seleccionar un vendedor")
      End If
      Me.mEmpleado = value
      Entida_Vendedor = value.Entida_Codigo
    End Set
  End Property

  Public ReadOnly Property FechaVencimiento() As DateTime
    Get
      If PardetTipoPago Is Nothing OrElse MovimientoInventario Is Nothing Then
        Return Now.Date
      Else
        Return mMovimientoInventario.Movinv_Fecha.AddDays(mPardetTipoPago.Pardet_DatoInt1)
      End If
    End Get
  End Property

  Public ReadOnly Property DireccionString() As String
    Get
      Try
        Dim _direccion As New EntidadDireccion(OperadorDatos, Me.Entida_Cliente, PardetTipoDireccion)
        Return _direccion.Descripcion
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property

  Public ReadOnly Property TelefonoString() As String
    Get
      Try
        Return Cliente.Entidad.Telefono
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property

  Public ReadOnly Property CiudadString() As String
    Get
      Try
        Dim _direccion As New EntidadDireccion(OperadorDatos, Me.Entida_Cliente, PardetTipoDireccion)
        Return _direccion.PardetCiudad.Pardet_Descripcion
      Catch ex As Exception
        Return String.Empty
      End Try
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Empres_Codigo = CType(Fila("Empres_Codigo"), Integer)
    Sucurs_Codigo = CType(Fila("Sucurs_Codigo"), Integer)
    Parame_TipoVenta = CType(Fila("Parame_TipoVenta"), Integer)
    Pardet_TipoVenta = CType(Fila("Pardet_TipoVenta"), Integer)
    Venta_Numero = CType(Fila("Venta_Numero"), Integer)
    Parame_Tipomovinv = CType(Fila("Parame_Tipomovinv"), Integer)
    Pardet_Tipomovinv = CType(Fila("Pardet_Tipomovinv"), Integer)
    Movinv_Secuencia = CType(Fila("Movinv_Secuencia"), Integer)
    Entida_Cliente = CType(Fila("Entida_Cliente"), Integer)
    Entida_Vendedor = CType(Fila("Entida_Vendedor"), Integer)
    Parame_TipoPago = CType(Fila("Parame_TipoPago"), Integer)
    Pardet_TipoPago = CType(Fila("Pardet_TipoPago"), Integer)
    Parame_TipoPrecio = CType(Fila("Parame_TipoPrecio"), Integer)
    Pardet_TipoPrecio = CType(Fila("Pardet_TipoPrecio"), Integer)
    Parame_Tipodireccion = CType(Fila("Parame_TipoDireccion"), Integer)
    Pardet_Tipodireccion = CType(Fila("Pardet_TipoDireccion"), Integer)
    SRI_secuencialtransaccion = CStr(Fila("SRI_secuencialtransaccion"))
    SRI_tipocomprobante = CStr(Fila("SRI_tipocomprobante"))
    Venta_esConsumidorFinal = CBool(Fila("Venta_esConsumidorFinal"))
    mMovimientoInventario = Nothing
    mCliente = Nothing
    mTipomovimientocompraventa = Nothing
    mEmpleado = Nothing
    mSucursal = Nothing
    mPardetTipoVenta = Nothing
    mPardetTipoPago = Nothing
    mPardetTipoPrecio = Nothing
    mPardetTipoDireccion = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Empres_Codigo", Empres_Codigo)
    OperadorDatos.AgregarParametro("@Sucurs_Codigo", Sucurs_Codigo)
    OperadorDatos.AgregarParametro("@Parame_TipoVenta", Parame_TipoVenta)
    OperadorDatos.AgregarParametro("@Pardet_TipoVenta", Pardet_TipoVenta)
    OperadorDatos.AgregarParametro("@Venta_Numero", Venta_Numero)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    Try
      Me.MapearDataRowaObjeto(Result.Rows(0))
      EsNuevo = False
      EsModificado = False
    Catch ex As System.Exception
      bReturn = False
    End Try
    Return bReturn
  End Function

  Public Overridable Function RecargarporMovimientoInventario() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "CM")
    OperadorDatos.AgregarParametro("@Empres_Codigo", Empres_Codigo)
    OperadorDatos.AgregarParametro("@Sucurs_Codigo", Sucurs_Codigo)
    OperadorDatos.AgregarParametro("@Parame_Tipomovinv", Parame_Tipomovinv)
    OperadorDatos.AgregarParametro("@Pardet_Tipomovinv", Pardet_Tipomovinv)
    OperadorDatos.AgregarParametro("@Movinv_Secuencia", Movinv_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    Try
      Me.MapearDataRowaObjeto(Result.Rows(0))
      EsNuevo = False
      EsModificado = False
    Catch ex As System.Exception
      bReturn = False
    End Try
    Return bReturn
  End Function

  Public Overridable Function Guardar(ByVal _VerificarSaldo As Boolean) As Boolean
    If Not EsNuevo And Not EsModificado Then
      Return True
    End If

    Dim Result As Integer = 0
    Dim bReturn As Boolean = True

    Dim _comenzotransaccion As Boolean = False
    If Not OperadorDatos.EstaenTransaccion Then
      OperadorDatos.ComenzarTransaccion()
      _comenzotransaccion = True
    End If
    bReturn = MovimientoInventario.Guardar

    If bReturn Then
      Empres_Codigo = MovimientoInventario.Empres_Bodega
      Sucurs_Codigo = MovimientoInventario.Sucurs_Bodega
      Parame_Tipomovinv = MovimientoInventario.Parame_Tipomovinv
      Pardet_Tipomovinv = MovimientoInventario.Pardet_Tipomovinv
      Movinv_Secuencia = MovimientoInventario.Movinv_Secuencia
      Dim _fechapago As Date = MovimientoInventario.Movinv_Fecha
      Dim _valorfact As Decimal = MovimientoInventario.TotalGeneral

      Dim sAccion As String = "M"
      If EsNuevo Then
        sAccion = "I"
      End If
      OperadorDatos.AgregarParametro("@accion", sAccion)
      OperadorDatos.AgregarParametro("@Empres_Codigo", Empres_Codigo)
      OperadorDatos.AgregarParametro("@Sucurs_Codigo", Sucurs_Codigo)
      OperadorDatos.AgregarParametro("@Parame_TipoVenta", Parame_TipoVenta)
      OperadorDatos.AgregarParametro("@Pardet_TipoVenta", Pardet_TipoVenta)
      OperadorDatos.AgregarParametro("@Venta_Numero", Venta_Numero)
      OperadorDatos.AgregarParametro("@Parame_Tipomovinv", Parame_Tipomovinv)
      OperadorDatos.AgregarParametro("@Pardet_Tipomovinv", Pardet_Tipomovinv)
      OperadorDatos.AgregarParametro("@Movinv_Secuencia", Movinv_Secuencia)
      OperadorDatos.AgregarParametro("@Entida_Cliente", Entida_Cliente)
      OperadorDatos.AgregarParametro("@Entida_Vendedor", Entida_Vendedor)
      OperadorDatos.AgregarParametro("@Parame_TipoPago", Parame_TipoPago)
      OperadorDatos.AgregarParametro("@Pardet_TipoPago", Pardet_TipoPago)
      OperadorDatos.AgregarParametro("@Parame_TipoPrecio", Parame_TipoPrecio)
      OperadorDatos.AgregarParametro("@Pardet_TipoPrecio", Pardet_TipoPrecio)
      OperadorDatos.AgregarParametro("@SRI_secuencialtransaccion", SRI_secuencialtransaccion)
      OperadorDatos.AgregarParametro("@SRI_tipocomprobante", SRI_tipocomprobante)
      OperadorDatos.AgregarParametro("@Venta_esConsumidorFinal", Venta_esConsumidorFinal)
      OperadorDatos.AgregarParametro("@valorfactura", _valorfact)
      OperadorDatos.AgregarParametro("@fechapago", _fechapago)
      OperadorDatos.AgregarParametro("@Parame_Tipodireccion", Parame_Tipodireccion)
      OperadorDatos.AgregarParametro("@Pardet_Tipodireccion", Pardet_Tipodireccion)

      OperadorDatos.AgregarParametro("@VerificarSaldo", _VerificarSaldo)
      OperadorDatos.Procedimiento = _Procedimiento
      bReturn = OperadorDatos.Ejecutar(Result)
      OperadorDatos.LimpiarParametros()
      If bReturn Then
        If EsNuevo Then
          Venta_Numero = Result

          'Dim _pago As New PagosDet(Me.MovimientoInventario, True)
          '_pago.Pardet_TipoMovPago = Enumerados.enumTipoMovPagos.Documento
          '_pago.Pagdet_Valor = Me.MovimientoInventario.TotalGeneral
          '_pago.Pagdet_FechaPago = Me.MovimientoInventario.Movinv_Fecha
          ''TODO
          ''cambiar la fecha de pago seg�n forma de pago
          'bReturn = _pago.Guardar()
        End If
        If Not OperadorDatos.EstaenTransaccion Then
          EsNuevo = False
          EsModificado = False
        End If
      End If
    End If
    If _comenzotransaccion Then
      If bReturn Then
        OperadorDatos.TerminarTransaccion()
        AceptarCambios()
      Else
        OperadorDatos.CancelarTransaccion()
      End If
    End If
    Return bReturn
  End Function

  Public Overridable Sub AceptarCambios()
    EsNuevo = False
    EsModificado = False

    mMovimientoInventario.AceptarCambios()
  End Sub

  Public Overridable Function Eliminar() As Boolean
    If EsNuevo Then
      Return True
    End If
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Empres_Codigo", Empres_Codigo)
    OperadorDatos.AgregarParametro("@Sucurs_Codigo", Sucurs_Codigo)
    OperadorDatos.AgregarParametro("@Parame_TipoVenta", Parame_TipoVenta)
    OperadorDatos.AgregarParametro("@Pardet_TipoVenta", Pardet_TipoVenta)
    OperadorDatos.AgregarParametro("@Venta_Numero", Venta_Numero)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function
End Class
#End Region

#Region "VentaList"
Public Class VentaList
  Inherits System.ComponentModel.BindingList(Of Venta)

  Public Shared Function ObtenerLista(ByVal _Empresa As Empresa, ByVal _Desde As Date, ByVal _Hasta As Date) As VentaList
    Dim oResult As VentaList = New VentaList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Empresa.OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@Empres_Codigo", _Empresa.Empres_Codigo)
      .AgregarParametro("@fecdesde", _Desde.Date)
      .AgregarParametro("@fechasta", _Hasta.Date.AddDays(1))
      .Procedimiento = "proc_Venta"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Venta(_Empresa, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  Public Shared Function ObtenerLista(ByVal _Sucursal As Sucursal, ByVal _PardetTipoVenta As WWTSParametroDet) As VentaList
    Dim oResult As VentaList = New VentaList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Sucursal.OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@Empres_Codigo", _Sucursal.Empres_Codigo)
      .AgregarParametro("@Sucurs_Codigo", _Sucursal.Sucurs_Codigo)
      .AgregarParametro("@Parame_TipoVenta", _PardetTipoVenta.Parame_Codigo)
      .AgregarParametro("@Pardet_TipoVenta", _PardetTipoVenta.Pardet_Secuencia)
      .Procedimiento = "proc_Venta"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Venta(_Sucursal, CType(_PardetTipoVenta.Pardet_Secuencia, Enumerados.enumTipoVenta), False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region
