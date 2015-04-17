

Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports Infoware.Reglas.General
#Region "IncautacionDet"
Partial Public Class IncautacionDet
  Const _Procedimiento As String = "proc_IncautacionDet"



  Private mMovimientoInventario As MovimientoInventario = Nothing

  Private mContribuyente As Contribuyente = Nothing

  Private mPardetTipoIncautacionDetMov As WWTSParametroDet = Nothing

  Private mSucursal As Sucursal = Nothing

  Private mPardetTipoPago As WWTSParametroDet = Nothing

  Public Sub New(ByVal _Empresa As Empresa, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _Empresa.OperadorDatos
    Empres_Codigo = _Empresa.Empres_Codigo
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _Sucursal.OperadorDatos
    Sucursal = _Sucursal
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _IncautacionDet_Numero As Integer)
    Me.New(_Sucursal, False)
    IncautacionDet_Numero = _IncautacionDet_Numero
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto IncautacionDet")
    End If
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _PardetTipoMovinv As WWTSParametroDet, ByVal _Movinv_Secuencia As Integer, ByVal _estricto As Boolean)
    MyBase.New()
    OperadorDatos = _Sucursal.OperadorDatos
    Sucursal = _Sucursal
    Parame_Tipomovinv = _PardetTipoMovinv.Parame_Codigo
    Pardet_TipoMovinv = _PardetTipoMovinv.Pardet_Secuencia
    Movinv_Secuencia = _Movinv_Secuencia

    If Me.RecargarporMovimientoInventario() Then
    Else
      If _estricto Then
        Throw New System.Exception("No se puede cargar objeto IncautacionDet")
      End If
    End If
  End Sub


  Public ReadOnly Property Establecimiento() As String
    Get
      Return Left(IncautacionDet_Numero, 3)
    End Get
  End Property

  Public ReadOnly Property PuntoEmision() As String
    Get
      Return Me.IncautacionDet_Numero.Substring(4, 3)
    End Get
  End Property

  Public ReadOnly Property Secuencial() As String
    Get
      Return Me.IncautacionDet_Numero.Substring(8, 7)
    End Get
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


  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Empres_Codigo", Empres_Codigo)
    OperadorDatos.AgregarParametro("@Sucurs_Codigo", Sucurs_Codigo)
    OperadorDatos.AgregarParametro("@Parame_TipoIncautacionDetMov", Parame_TipoIncautacionDetMov)
    OperadorDatos.AgregarParametro("@Pardet_TipoIncautacionDetMov", Pardet_TipoIncautacionDetMov)
    OperadorDatos.AgregarParametro("@Entida_Contribuyente", Contribuyente.Entida_Codigo)
    OperadorDatos.AgregarParametro("@IncautacionDet_Numero", IncautacionDet_Numero)
    OperadorDatos.AgregarParametro("@Incaut_Secuencia", Incaut_Secuencia)
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

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Empres_Codigo = CType(Fila("Empres_Codigo"), Integer)
    Sucurs_Codigo = CType(Fila("Sucurs_Codigo"), Integer)
    Parame_TipoIncautacionDetMov = CType(Fila("Parame_TipoIncautacionDetMov"), Integer)
    Pardet_TipoIncautacionDetMov = CType(Fila("Pardet_TipoIncautacionDetMov"), Integer)
    Entida_Contribuyente = CType(Fila("Entida_Contribuyente"), Integer)
    IncautacionDet_Numero = CType(Fila("IncautacionDet_Numero"), String)
    Parame_Tipomovinv = CType(Fila("Parame_Tipomovinv"), Integer)
    Pardet_TipoMovinv = CType(Fila("Pardet_TipoMovinv"), Integer)
    Movinv_Secuencia = CType(Fila("Movinv_Secuencia"), Integer)
    Incaut_Secuencia = CType(Fila("Incaut_Secuncia"), Integer)
    Incaut_Responsable = CType(Fila("Incaut_Responsable"), String)
    Incaut_Fecha = CType(Fila("Incaut_Fecha"), Date)

    mContribuyente = Nothing

    mPardetTipoIncautacionDetMov = Nothing

  End Sub


  Public Overridable Function Guardar() As Boolean
    If Not EsNuevo And Not EsModificado Then
      Return True
    End If

    Dim Result As Integer = 0
    Dim bReturn As Boolean = True

    OperadorDatos.ComenzarTransaccion()

    bReturn = MovimientoInventario.Guardar

    If bReturn Then
      Empres_Codigo = MovimientoInventario.Empres_Bodega

      Sucurs_Codigo = MovimientoInventario.Sucurs_Bodega
      Parame_Tipomovinv = MovimientoInventario.Parame_Tipomovinv
      Pardet_TipoMovinv = MovimientoInventario.Pardet_Tipomovinv
      Movinv_Secuencia = MovimientoInventario.Movinv_Secuencia

      Dim sAccion As String = "M"
      If EsNuevo Then
        sAccion = "I"
      End If
      OperadorDatos.AgregarParametro("@accion", sAccion)
      OperadorDatos.AgregarParametro("@Empres_Codigo", Empres_Codigo)
      OperadorDatos.AgregarParametro("@Sucurs_Codigo", Sucurs_Codigo)
      OperadorDatos.AgregarParametro("@Parame_TipoIncautacionDetMov", Parame_TipoIncautacionDetMov)
      OperadorDatos.AgregarParametro("@Pardet_TipoIncautacionDetMov", Pardet_TipoIncautacionDetMov)
      OperadorDatos.AgregarParametro("@Entida_Contribuyente", Contribuyente.Entida_Codigo)
      OperadorDatos.AgregarParametro("@IncautacionDet_Numero", IncautacionDet_Numero)
      OperadorDatos.AgregarParametro("@Incaut_Secuencia", Incaut_Secuencia)
      OperadorDatos.AgregarParametro("@Parame_Tipomovinv", Parame_Tipomovinv)
      OperadorDatos.AgregarParametro("@Movinv_Secuencia", Movinv_Secuencia)

      OperadorDatos.AgregarParametro("@Pardet_TipoMovinv", Pardet_TipoMovinv)
      OperadorDatos.AgregarParametro("@Incaut_Fecha", Incaut_Fecha)
      OperadorDatos.AgregarParametro("@Incaut_Responsable", Incaut_Responsable)
      OperadorDatos.Procedimiento = _Procedimiento
      bReturn = OperadorDatos.Ejecutar(Result)
      OperadorDatos.LimpiarParametros()
      If bReturn Then
        If EsNuevo Then
          Me.RecargarporMovimientoInventario()
          'Incaut_Secuencia = Result
          ' Compra_Numero = Result

          'Dim _pago As New PagosDet(Me.MovimientoIfnventario, True)
          '_pago.Pardet_TipoMovPago = Enumerados.enumTipoMovPagos.Documento
          '_pago.Pagdet_Valor = -Me.MovimientoInventario.TotalGeneral
          '_pago.Pagdet_FechaPago = Me.MovimientoInventario.Movinv_Fecha
          'TODO
          'cambiar la fecha de pago según forma de pago
          'bReturn = _pago.Guardar()

        End If
        If Not OperadorDatos.EstaenTransaccion Then
          EsNuevo = False
          EsModificado = False
        End If
      End If
    End If

    If bReturn Then
      OperadorDatos.TerminarTransaccion()
      AceptarCambios()
    Else
      OperadorDatos.CancelarTransaccion()
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
    OperadorDatos.AgregarParametro("@Parame_TipoIncautacionDetMov", Parame_TipoIncautacionDetMov)
    OperadorDatos.AgregarParametro("@Pardet_TipoIncautacionDetMov", Pardet_TipoIncautacionDetMov)
    OperadorDatos.AgregarParametro("@Entida_Contribuyente", Contribuyente.Entida_Codigo)
    OperadorDatos.AgregarParametro("@IncautacionDet_Numero", IncautacionDet_Numero)
    OperadorDatos.AgregarParametro("@Incaut_Secuencia", Incaut_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function


  Public Overridable Function RecargarporMovimientoInventario() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "CM")
    OperadorDatos.AgregarParametro("@Empres_Codigo", Empres_Codigo)
    OperadorDatos.AgregarParametro("@Sucurs_Codigo", Sucurs_Codigo)
    OperadorDatos.AgregarParametro("@Parame_Tipomovinv", Parame_Tipomovinv)
    OperadorDatos.AgregarParametro("@Pardet_Tipomovinv", Pardet_TipoMovinv)
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



End Class

#End Region

#Region "IncautacionDetList"
Public Class IncautacionDetList
  Inherits System.ComponentModel.BindingList(Of IncautacionDet)

  Public Shared Function ObtenerLista(ByVal _Empresa As Empresa, ByVal _Desde As Date, ByVal _Hasta As Date) As IncautacionDetList
    Dim oResult As IncautacionDetList = New IncautacionDetList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Empresa.OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@Empres_Codigo", _Empresa.Empres_Codigo)
      .AgregarParametro("@fecdesde", _Desde.Date)
      .AgregarParametro("@fechasta", _Hasta.Date.AddDays(1))
      '.AgregarParametro("@Parame_TipoCompra", _PardetTipoCompra.Parame_Codigo)
      '.AgregarParametro("@Pardet_TipoCompra", _PardetTipoCompra.Pardet_Secuencia)
      .Procedimiento = "proc_IncautacionDet"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New IncautacionDet(_Empresa, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function


End Class
#End Region
