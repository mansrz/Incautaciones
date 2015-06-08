'IncRes_Codigo	int	Unchecked
'IncRes_Numero	nvarchar(50)	Unchecked
'IncRes_Fecha	date	Unchecked
'IncRes_FechaNotificacion	date	Unchecked
'Parame_TipoResolucion	int	Unchecked
'IncRes_FechaEntrega	nchar(10)	Checked
'IncRes_NumeroLiquidacion	nchar(10)	Checked
'Pardet_TipoResolucion	int	Unchecked


Option Strict Off
Option Explicit On

Imports Infoware.Datos
'Imports Infoware.Reglas.General

#Region "IncautacionResolucion"
Partial Public Class IncautacionResolucion
  Const _Procedimiento As String = "proc_IncautacionResolucion"

    Private mContribuyente As Contribuyente = Nothing

    Private mIncautacion As Incautacion = Nothing

  Private mPardetTipoResolucion As WWTSParametroDet = Nothing


    Public Sub New(ByVal _Incautacion As Reglas.Incautacion, ByVal _EsNuevo As Boolean)
        MyBase.New()
        OperadorDatos = _Incautacion.OperadorDatos
        mIncautacion = _Incautacion
        EsNuevo = _EsNuevo
    End Sub


    Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Incaut_Codigo As Integer, ByVal _IncRes_Codigo As Integer)
        'MyBase.New()
        OperadorDatos = _OperadorDatos
        Incaut_Codigo = _Incaut_Codigo
        IncRes_Codigo = _IncRes_Codigo
        If Me.Recargar Then

        Else
            Throw New System.Exception("No se puede cargar objeto IncautacionResolucion")
        End If
    End Sub

    'Incautacion
    Public Overridable Property Incautacion() As Incautacion
        Get
            If mIncautacion Is Nothing AndAlso Incaut_Codigo > 0 Then
                mIncautacion = New Incautacion(OperadorDatos, Incaut_Codigo)
            End If
            Return Me.mIncautacion
        End Get
        Set(value As Incautacion)
            Me.mIncautacion = value
            Incaut_Codigo = value.Incaut_Codigo
        End Set
    End Property


    Public Overridable Overloads Property PardetTipoResolucion() As WWTSParametroDet
        Get
            If Me.mPardetTipoResolucion Is Nothing AndAlso Pardet_TipoResolucion > 0 Then
                Me.mPardetTipoResolucion = New WWTSParametroDet(OperadorDatos, Parame_TipoResolucion, Pardet_TipoResolucion)
            End If
            Return Me.mPardetTipoResolucion
        End Get
        Set(ByVal value As WWTSParametroDet)
            Me.mPardetTipoResolucion = value
            Parame_TipoResolucion = value.Parame_Codigo
            Pardet_TipoResolucion = value.Pardet_Secuencia
        End Set
    End Property

    <Infoware.Reportes.CampoReporteAtributo("Número de Resolución", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 120, True)> _
    Public ReadOnly Property DescripcionString() As String
        Get
            Return IncRes_Numero
        End Get
    End Property

    <Infoware.Reportes.CampoReporteAtributo("Tipo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 120, True)> _
    Public ReadOnly Property TipoResolucionString() As String
        Get
            If PardetTipoResolucion Is Nothing Then
                Return String.Empty
            Else
                Return PardetTipoResolucion.Descripcion
            End If
        End Get
    End Property

    <Infoware.Reportes.CampoReporteAtributo("Fecha de Notificación", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 120, True)> _
    Public ReadOnly Property FechaNotificacionString() As String
        Get
            Return IncRes_FechaNotificacion.ToString
        End Get
    End Property

    <Infoware.Reportes.CampoReporteAtributo("Fecha de entrega", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 120, True)> _
    Public ReadOnly Property FechaEntregaString() As String
        Get
            If IncRes_FechaEntrega = DateTime.MinValue Then
                Return String.Empty
            Else
                Return IncRes_FechaEntrega.ToString
            End If
        End Get
    End Property


  Public Overridable Function Recargar() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@IncRes_Codigo", IncRes_Codigo)
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
    IncRes_Codigo = CType(Fila("IncRes_Codigo"), Integer)
        IncRes_Numero = CType(Fila("IncRes_Numero"), String)
    IncRes_Fecha = CType(Fila("IncRes_Fecha"), String)
        IncRes_FechaNotificacion = CType(Fila("IncRes_FechaNotificacion"), Date)
    Parame_TipoResolucion = CType(Fila("Parame_TipoResolucion"), Integer)
        IncRes_FechaEntrega = CType(Fila("IncRes_FechaEntrega"), Date)
    Pardet_TipoResolucion = CType(Fila("Pardet_TipoResolucion"), Integer)
    IncRes_Codigo = CType(Fila("IncRes_Codigo"), Integer)
        IncRes_NumeroLiquidacion = CType(Fila("Incres_NumeroLiquidacion"), String)
        Incaut_Codigo = CType(Fila("Incaut_Codigo"), Integer)
    
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
    OperadorDatos.AgregarParametro("@IncRes_Numero", IncRes_Numero)
    OperadorDatos.AgregarParametro("@IncRes_Codigo", IncRes_Codigo)
    OperadorDatos.AgregarParametro("@IncRes_Fecha", IncRes_Fecha)
    OperadorDatos.AgregarParametro("@IncRes_FechaNotificacion", IncRes_FechaNotificacion)
    OperadorDatos.AgregarParametro("@Parame_TipoResolucion", Parame_TipoResolucion)
    OperadorDatos.AgregarParametro("@Pardet_TipoResolucion", Pardet_TipoResolucion)
    OperadorDatos.AgregarParametro("@IncRes_NumeroLiquidacion", IncRes_NumeroLiquidacion)
        OperadorDatos.AgregarParametro("@IncRes_FechaEntrega", IncRes_FechaEntrega)
        OperadorDatos.AgregarParametro("@Incaut_Codigo", Incaut_Codigo)
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
    OperadorDatos.AgregarParametro("@IncRes_Codigo", IncRes_Codigo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function


  Public Overridable Function RecargarporMovimientoInventario() As Boolean
    Dim Result As New DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "CM")
    OperadorDatos.AgregarParametro("@IncRes_Codigo", IncRes_Codigo)
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


    Private mAceptado As Boolean = False
    Public Property Aceptado As Boolean
        Get
            Return mAceptado
        End Get
        Set(value As Boolean)
            mAceptado = value
        End Set
    End Property

End Class

#End Region

#Region "IncautacionResolucionList"
Public Class IncautacionResolucionList
  Inherits System.ComponentModel.BindingList(Of IncautacionResolucion)

    Public Shared Function ObtenerLista(ByVal _Incautacion As Incautacion) As IncautacionResolucionList
        Dim oResult As IncautacionResolucionList = New IncautacionResolucionList
        Dim bReturn As Boolean
        Dim ds As DataTable = Nothing
        With _Incautacion.OperadorDatos
            .AgregarParametro("@Accion", "F")
            .AgregarParametro("@Incaut_Codigo", _Incautacion.Incaut_Codigo)
            .Procedimiento = "proc_IncautacionResolucion"
            bReturn = .Ejecutar(ds)
            .LimpiarParametros()
        End With
        If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
            For Each _dr As DataRow In ds.Rows
                Dim _fila As New IncautacionResolucion(_Incautacion, False)
                _fila.MapearDataRowaObjeto(_dr)
                oResult.Add(_fila)
            Next
        End If
        Return oResult
    End Function


End Class
#End Region
