'IncSal_Codigo	int	Unchecked
'Empres_Codigo	int	Unchecked
'IncSal_Secuencia	int	Unchecked
'IncRes_Codigo	int	Unchecked
'Emplea_Administrativo	int	Unchecked
'IncSal_TenedorNombre	nvarchar(250)	Unchecked
'IncSal_TenedorCI	nchar(10)	Unchecked
'IncSal_FechaEntrega	date	Unchecked
'IncSal_NumeroLiquidacion	nvarchar(50)	Unchecked
'IncSal_FechaRegistro	datetime	Unchecked



Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports Infoware.Reglas.General
#Region "IncautacionSalida "
Partial Public Class IncautacionSalida
  Const _Procedimiento As String = "proc_IncautacionSalida"

  Private mAdministrativo As Empleado = Nothing

  Public Sub New(ByVal _Empresa As Empresa, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _Empresa.OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _Sucursal.OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  
  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _PardetTipoMovinv As WWTSParametroDet, ByVal _Movinv_Secuencia As Integer, ByVal _estricto As Boolean)
    MyBase.New()
    OperadorDatos = _Sucursal.OperadorDatos


    If Me.Recargar Then
    Else
      If _estricto Then
        Throw New System.Exception("No se puede cargar objeto IncautacionSalida")
      End If
    End If
  End Sub





  'Proveedor
  Public Overridable Property EmpleaAdministrativo() As Empleado
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



  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@IncSal_Codigo", IncSal_Codigo)
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

    IncSal_Codigo = CType(Fila("IncSal"), Integer)
    Empresa_Codigo = CType(Fila("Empres_Codigo"), Integer)
    IncSal_Secuencia = CType(Fila("IncSal_Secuencia"), Integer)
    IncRes_Codigo = CType(Fila("IncRes_Codigo"), Integer)
    Emplea_Administrativo = CType(Fila("Emplea_Administrativo"), Integer)
    IncSal_TenedorNombre = CType(Fila("IncSal_TenedorNombre"), String)
    IncSal_TenedorCI = CType(Fila("IncSal_TenedorCI"), String)
    IncSal_FechaEntrega = CType(Fila("IncSal_FechaEntrega"), Date)
    IncSal_NumeroLiquidacion = CType(Fila("IncSal_NumeroLiquidacion"), String)
    IncSal_FechaRegistro = CType(Fila("IncSal_FechaRegistro"), Date)
    Emplea_Administrativo = CType(Fila("Emplea_Administrativo"), Integer)
    
    mAdministrativo = Nothing

  End Sub


  Public Overridable Function Guardar() As Boolean
    If Not EsNuevo And Not EsModificado Then
      Return True
    End If

    Dim Result As Integer = 0
    Dim bReturn As Boolean = True

    OperadorDatos.ComenzarTransaccion()

    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If
    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@IncSal_Codigo", IncSal_Codigo)
    OperadorDatos.AgregarParametro("@Empres_Codigo", Empresa_Codigo)
    OperadorDatos.AgregarParametro("@Emplea_Administrativo", Emplea_Administrativo)
    OperadorDatos.AgregarParametro("@IncSal_Secuencia", IncSal_Secuencia)
    OperadorDatos.AgregarParametro("@IncRes_Codigo", IncRes_Codigo)
    OperadorDatos.AgregarParametro("@IncSal_TenedorNombre", IncSal_TenedorNombre)
    OperadorDatos.AgregarParametro("@IncSal_TenedorCI", IncSal_TenedorCI)
    OperadorDatos.AgregarParametro("@IncSal_FechaEntrega", IncSal_FechaEntrega)
    OperadorDatos.AgregarParametro("@IncSal_NumeroLiquidacion", IncSal_NumeroLiquidacion)
    OperadorDatos.AgregarParametro("@Incaut_FechaRegistro", IncSal_FechaRegistro)


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

    OperadorDatos.AgregarParametro("@IncSal_Codigo", IncSal_Codigo
                                   )
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function


  Public Overridable Function RecargarporMovimientoInventario() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "CM")
    OperadorDatos.AgregarParametro("@IncSal_Codigo", IncSal_Codigo)
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

#Region "IncautacionSalidaList"
Public Class IncautacionSalidaList
  Inherits System.ComponentModel.BindingList(Of IncautacionSalida)

  Public Shared Function ObtenerLista(ByVal _Empresa As Empresa, ByVal _Desde As Date, ByVal _Hasta As Date) As IncautacionSalidaList
    Dim oResult As IncautacionSalidaList = New IncautacionSalidaList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Empresa.OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@Empres_Codigo", _Empresa.Empres_Codigo)
      .AgregarParametro("@fecdesde", _Desde.Date)
      .AgregarParametro("@fechasta", _Hasta.Date.AddDays(1))
      '.AgregarParametro("@Parame_TipoCompra", _PardetTipoCompra.Parame_Codigo)
      '.AgregarParametro("@Pardet_TipoCompra", _PardetTipoCompra.Pardet_Secuencia)
      .Procedimiento = "proc_IncautacionSalida"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New IncautacionSalida(_Empresa, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function


End Class
#End Region
