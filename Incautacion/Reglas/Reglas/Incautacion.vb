'Incaut_Codigo
'Empres_Codigo
'Incaut_Numero
'Entida_Contribuyente
'Incaut_TenedorNombre
'Incaut_TenedorCI
'Emplea_Fedatario
'Emplea_Administrativo
'Incaut_Fecha
'Incaut_Observaciones
'Incaut_FechaIngreso


Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports Infoware.Reglas.General
#Region "Incautacion"
Partial Public Class Incautacion
  Const _Procedimiento As String = "proc_Incautacion"

  Private mContribuyente As Contribuyente = Nothing

  Private mAdministrativo As Empleado = Nothing

  Private mFedatario As Empleado = Nothing

  Public Sub New(ByVal _Empresa As Empresa, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _Empresa.OperadorDatos
    Empres_Codigo = _Empresa.Empres_Codigo
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _Sucursal.OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _Incautacion_Codigo As Integer)
    Me.New(_Sucursal, False)
    Incaut_Codigo = _Incautacion_Codigo
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto Incautacion")
    End If
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _PardetTipoMovinv As WWTSParametroDet, ByVal _Movinv_Secuencia As Integer, ByVal _estricto As Boolean)
    MyBase.New()
    OperadorDatos = _Sucursal.OperadorDatos
<<<<<<< HEAD
   
=======
    Sucursal = _Sucursal

>>>>>>> origin/master

    If Me.Recargar Then
    Else
      If _estricto Then
        Throw New System.Exception("No se puede cargar objeto Incautacion")
      End If
    End If
  End Sub



<<<<<<< HEAD
=======
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

>>>>>>> origin/master
  

  'Proveedor
  Public Overridable Property Contribuyente() As Contribuyente
    Get
      If Me.mContribuyente Is Nothing AndAlso Entida_Contribuyente > 0 Then
        Me.mContribuyente = New Contribuyente(OperadorDatos, Entida_Contribuyente)
      End If
      Return Me.mContribuyente
    End Get
    Set(ByVal value As Contribuyente)
      Me.mContribuyente = value
      Entida_Contribuyente = value.Entida_Codigo
    End Set
  End Property

  Public Overridable Property Administrativo() As Empleado
    Get
      If Me.mAdministrativo Is Nothing AndAlso Emplea_Administrativo > 0 Then
        Me.mAdministrativo = New Empleado(OperadorDatos, Emplea_Administrativo)
      End If
      Return Me.mAdministrativo
    End Get
    Set(ByVal value As Empleado)
      Me.mAdministrativo = value
      Emplea_Administrativo = value.Entida_Codigo
    End Set
  End Property


  Public Overridable Property Fedatario() As Empleado
    Get
      If Me.mFedatario Is Nothing AndAlso Emplea_Fedatario > 0 Then
        Me.mFedatario = New Empleado(OperadorDatos, Emplea_Fedatario)
      End If
      Return Me.mFedatario
    End Get
    Set(ByVal value As Empleado)
      Me.mFedatario = value
      Emplea_Fedatario = value.Entida_Codigo
    End Set
  End Property


  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Incaut_Codigo", Incaut_Codigo)
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
    Entida_Contribuyente = CType(Fila("Entida_Contribuyente"), Integer)
<<<<<<< HEAD
    Incaut_Numero = CType(Fila("Incautacion_Numero"), String)
    Incaut_Codigo = CType(Fila("Incaut_Codigo"), Integer)
=======
    Incautacion_Numero = CType(Fila("Incautacion_Numero"), String)
    Incaut_Secuencia = CType(Fila("Incaut_Secuncia"), Integer)
    Incaut_Responsable = CType(Fila("Incaut_Responsable"), String)
>>>>>>> origin/master
    Incaut_Fecha = CType(Fila("Incaut_Fecha"), Date)
    Incaut_TenedorNombre = CType(Fila("Incaut_TenedorNombre"), String)
    Incaut_TenedorCI = CType(Fila("Incaut_TenedorCI"), String)
    Emplea_Fedatario = CType(Fila("Emplea_Fedatario"), Integer)
    Emplea_Administrativo = CType(Fila("Emplea_Administrativo"), Integer)
    Incaut_Observaciones = CType(Fila("Incaut_Observaciones"), String)
    Incaut_FechaIngreso = CType(Fila("Incaut_FechaIngreso"), Date)




    mContribuyente = Nothing

  End Sub


  Public Overridable Function Guardar() As Boolean
    If Not EsNuevo And Not EsModificado Then
      Return True
    End If

    Dim Result As Integer = 0
    Dim bReturn As Boolean = True

    OperadorDatos.ComenzarTransaccion()

<<<<<<< HEAD
    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If
    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Empres_Codigo", Empres_Codigo)
    OperadorDatos.AgregarParametro("@Entida_Contribuyente", Contribuyente.Entida_Codigo)
    OperadorDatos.AgregarParametro("@Incautacion_Numero", Incaut_Numero)
    OperadorDatos.AgregarParametro("@Incaut_Codigo", Incaut_Codigo)
    OperadorDatos.AgregarParametro("@Incaut_Fecha", Incaut_Fecha)
    OperadorDatos.AgregarParametro("@Incaut_TenedorNombre", Incaut_TenedorNombre)
    OperadorDatos.AgregarParametro("@Incaut_TenedorCI", Incaut_TenedorCI)
    OperadorDatos.AgregarParametro("@Emplea_Fedatario", Emplea_Fedatario)
    OperadorDatos.AgregarParametro("@Emplea_Administrativo", Emplea_Administrativo)
    OperadorDatos.AgregarParametro("@Incaut_FechaIngreso", Incaut_FechaIngreso)
    OperadorDatos.AgregarParametro("@Incaut_Observaciones", Incaut_Observaciones)

    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        Me.Recargar()
        'Me.RecargarporMovimientoInventario()
        'Incaut_Secuencia = Result
        ' Compra_Numero = Result

        'Dim _pago As New PagosDet(Me.MovimientoIfnventario, True)
        '_pago.Pardet_TipoMovPago = Enumerados.enumTipoMovPagos.Documento
        '_pago.Pagdet_Valor = -Me.MovimientoInventario.TotalGeneral
        '_pago.Pagdet_FechaPago = Me.MovimientoInventario.Movinv_Fecha
        'TODO
        'cambiar la fecha de pago según forma de pago
        'bReturn = _pago.Guardar()
=======


    If bReturn Then
    
      Dim sAccion As String = "M"
      If EsNuevo Then
        sAccion = "I"
      End If
      OperadorDatos.AgregarParametro("@accion", sAccion)
      OperadorDatos.AgregarParametro("@Empres_Codigo", Empres_Codigo)
      OperadorDatos.AgregarParametro("@Sucurs_Codigo", Sucurs_Codigo)
      OperadorDatos.AgregarParametro("@Parame_TipoIncautacionMov", Parame_TipoIncautacionMov)
      OperadorDatos.AgregarParametro("@Pardet_TipoIncautacionMov", Pardet_TipoIncautacionMov)
      OperadorDatos.AgregarParametro("@Entida_Contribuyente", Contribuyente.Entida_Codigo)
      OperadorDatos.AgregarParametro("@Incautacion_Numero", Incautacion_Numero)
      OperadorDatos.AgregarParametro("@Incaut_Secuencia", Incaut_Secuencia)
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
>>>>>>> origin/master

      End If
      If Not OperadorDatos.EstaenTransaccion Then
        EsNuevo = False
        EsModificado = False
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

    'mMovimientoInventario.AceptarCambios()
  End Sub

  Public Overridable Function Eliminar() As Boolean
    If EsNuevo Then
      Return True
    End If

    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")

    OperadorDatos.AgregarParametro("@Incaut_Secuencia", Incaut_Codigo)
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
<<<<<<< HEAD
=======
    OperadorDatos.AgregarParametro("@Sucurs_Codigo", Sucurs_Codigo)
>>>>>>> origin/master
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

#Region "IncautacionList"
Public Class IncautacionList
    Inherits System.ComponentModel.BindingList(Of Incautacion)

    Public Shared Function ObtenerLista(ByVal _Empresa As Empresa, ByVal _Desde As Date, ByVal _Hasta As Date) As IncautacionList
        Dim oResult As IncautacionList = New IncautacionList
        Dim bReturn As Boolean
        Dim ds As DataTable = Nothing
        With _Empresa.OperadorDatos
            .AgregarParametro("@Accion", "F")
            .AgregarParametro("@Empres_Codigo", _Empresa.Empres_Codigo)
            .AgregarParametro("@fecdesde", _Desde.Date)
            .AgregarParametro("@fechasta", _Hasta.Date.AddDays(1))
            '.AgregarParametro("@Parame_TipoCompra", _PardetTipoCompra.Parame_Codigo)
            '.AgregarParametro("@Pardet_TipoCompra", _PardetTipoCompra.Pardet_Secuencia)
            .Procedimiento = "proc_Incautacion"
            bReturn = .Ejecutar(ds)
            .LimpiarParametros()
        End With
        If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
            For Each _dr As DataRow In ds.Rows
                Dim _fila As New Incautacion(_Empresa, False)
                _fila.MapearDataRowaObjeto(_dr)
                oResult.Add(_fila)
            Next
        End If
        Return oResult
    End Function


End Class
#End Region
