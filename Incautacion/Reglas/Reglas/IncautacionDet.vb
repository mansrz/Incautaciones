

Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports Infoware.Reglas.General
#Region "IncautacionDet"
Partial Public Class IncautacionDet
  Const _Procedimiento As String = "proc_IncautacionDet"



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

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _IncautacionDet_Numero As Integer)
    Me.New(_Sucursal, False)

    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto IncautacionDet")
    End If
  End Sub

  Public Sub New(ByVal _Sucursal As Sucursal, ByVal _PardetTipoMovinv As WWTSParametroDet, ByVal _Movinv_Secuencia As Integer, ByVal _estricto As Boolean)
    MyBase.New()
    OperadorDatos = _Sucursal.OperadorDatos
    

    'Recargar
  End Sub



  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
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
    ''  Empres_Codigo = CType(Fila("Empres_Codigo"), Integer)
    

  End Sub


  Public Overridable Function Guardar() As Boolean
    If Not EsNuevo And Not EsModificado Then
      Return True
    End If

    Dim Result As Integer = 0
    Dim bReturn As Boolean = True

    OperadorDatos.ComenzarTransaccion()

    
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


  End Sub

  Public Overridable Function Eliminar() As Boolean
    If EsNuevo Then
      Return True
    End If

    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Incaut_Secuencia", Incaut_Secuencia)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
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
