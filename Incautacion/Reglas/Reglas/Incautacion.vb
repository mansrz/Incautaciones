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
Public Class Incautacion
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

    Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
        MyBase.New()
        OperadorDatos = _OperadorDatos
        EsNuevo = _EsNuevo
    End Sub

    Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Incautacion_Codigo As Integer)
        Me.New(_OperadorDatos, False)
        Incaut_Codigo = _Incautacion_Codigo
        If Me.Recargar Then
        Else
            Throw New System.Exception("No se puede cargar objeto Incautacion")
        End If
    End Sub

    Public Sub New(ByVal _Sucursal As Sucursal, ByVal _PardetTipoMovinv As WWTSParametroDet, ByVal _Movinv_Secuencia As Integer, ByVal _estricto As Boolean)
        MyBase.New()
        OperadorDatos = _Sucursal.OperadorDatos


        If Me.Recargar Then
        Else
            If _estricto Then
                Throw New System.Exception("No se puede cargar objeto Incautacion")
            End If
        End If
    End Sub





    'Proveedor
    Public Overridable Property Contribuyente() As Contribuyente
        Get
            If Me.mContribuyente Is Nothing AndAlso Entida_Contribuyente > 0 Then
                Me.mContribuyente = New Contribuyente(OperadorDatos, Entida_Contribuyente)
                Me.mContribuyente.Recargar()
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

    'Public ReadOnly Property IncautacionResoluciones As IncautacionResolucionList
    '    Get
    '        If EsNuevo Then
    '            Return Nothing
    '        Else
    '            Return IncautacionResoluciones.ObtenerLista(Me)
    '        End If
    '    End Get
    'End Property

#Region "IncautacionResoluciones"
    Private WithEvents mIncautacionResoluciones As IncautacionResolucionList = Nothing
    Private mIncautacionResolucionesEli As IncautacionResolucionList = Nothing

    Public Property IncautacionResoluciones As IncautacionResolucionList
        Get
            If mIncautacionResoluciones Is Nothing Then
                If EsNuevo Then
                    mIncautacionResoluciones = New IncautacionResolucionList
                Else
                    mIncautacionResoluciones = IncautacionResolucionList.ObtenerLista(Me)
                End If
            End If
            Return mIncautacionResoluciones
        End Get
        Set(value As IncautacionResolucionList)
            mIncautacionResoluciones = value
        End Set
    End Property

    Public Property IncautacionResolucionesEli As IncautacionResolucionList
        Get
            If mIncautacionResolucionesEli Is Nothing Then
                mIncautacionResolucionesEli = New IncautacionResolucionList
            End If
            Return mIncautacionResolucionesEli
        End Get
        Set(value As IncautacionResolucionList)
            mIncautacionResolucionesEli = value
        End Set
    End Property

    Private Sub mIncautaionResoluciones_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs) Handles mIncautacionResoluciones.AddingNew
        Dim _caract = New IncautacionResolucion(OperadorDatos, Incaut_Codigo, True)
        _caract.Incautacion = Me
        e.NewObject = _caract
    End Sub
#End Region


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

        Incaut_Codigo = CType(Fila("Incaut_Codigo"), Integer)
        Incaut_Numero = CType(Fila("Incaut_Numero"), String)
        Entida_Contribuyente = CType(Fila("Entida_Contribuyente"), Integer)
        Incaut_TenedorNombre = CType(Fila("Incaut_TenedorNombre"), String)
        Incaut_TenedorCI = CType(Fila("Incaut_TenedorCI"), String)
        Emplea_Fedatario = CType(Fila("Emplea_Fedatario"), Integer)
        Emplea_Administrativo = CType(Fila("Emplea_Administrativo"), Integer)
        Incaut_Fecha = CType(Fila("Incaut_Fecha"), Date)
        Incaut_Observaciones = CType(Fila("Incaut_Observaciones"), String)
        Incaut_FechaIngreso = CType(Fila("Incaut_FechaIngreso"), Date)
        Empres_Codigo = CType(Fila("Empres_Codigo"), Integer)

        mContribuyente = New Contribuyente(OperadorDatos, Entida_Contribuyente)
        mContribuyente.Recargar()
        mIncautacionResoluciones = Nothing
        mIncautacionResolucionesEli = Nothing

    End Sub


    Public Overridable Function Guardar() As Boolean
        If Not EsNuevo And Not EsModificado Then
            Return True
        End If

        Dim Result As Integer = 0
        Dim bReturn As Boolean = True

        OperadorDatos.ComenzarTransaccion()

        Dim sAccion As String = "m"
        If EsNuevo Then
            sAccion = "i"
        End If
        OperadorDatos.AgregarParametro("@accion", sAccion)
        OperadorDatos.AgregarParametro("@Incaut_Codigo", Incaut_Codigo)
        OperadorDatos.AgregarParametro("@Incaut_Numero", Incaut_Numero)
        OperadorDatos.AgregarParametro("@Entida_Contribuyente", Contribuyente.Entida_Codigo)
        OperadorDatos.AgregarParametro("@Incaut_TenedorNombre", Incaut_TenedorNombre)
        OperadorDatos.AgregarParametro("@Incaut_TenedorCI", Incaut_TenedorCI)
        OperadorDatos.AgregarParametro("@Emplea_Fedatario", Emplea_Fedatario)
        OperadorDatos.AgregarParametro("@Emplea_Administrativo", Emplea_Administrativo)
        OperadorDatos.AgregarParametro("@Empres_Codigo", Empres_Codigo)
        OperadorDatos.AgregarParametro("@Incaut_Fecha", Incaut_Fecha)
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



    Public Shared Function ObtenerLista(ByVal _Empresa As Empresa, Optional ByVal _Contribuyente As Contribuyente = Nothing, Optional ByVal _filtro As String = "") As IncautacionList

        Dim oResult As IncautacionList = New IncautacionList
        Dim bReturn As Boolean
        Dim ds As DataTable = Nothing
        With _Contribuyente.OperadorDatos
            .AgregarParametro("@Accion", "F")
            If _Contribuyente IsNot Nothing Then
                .AgregarParametro("@Entida_Contribuyente", _Contribuyente.Entida_Codigo)
            End If
            .AgregarParametro("@Empres_Codigo", _Empresa.Empres_Codigo)
            .AgregarParametro("@filtro", _filtro)
            .Procedimiento = "proc_Incautacion"
            bReturn = .Ejecutar(ds)
            .LimpiarParametros()
        End With

        If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
            For Each _dr As DataRow In ds.Rows
                Dim _fila As New Incautacion(_Contribuyente.OperadorDatos, False)
                _fila.MapearDataRowaObjeto(_dr)
                oResult.Add(_fila)
            Next
        End If
        Return oResult
    End Function

    Public Shared Function ObtenerLista(ByVal _Contribuyente As Contribuyente, Optional ByVal _filtro As String = "") As IncautacionList
        Dim oResult As IncautacionList = New IncautacionList
        Dim bReturn As Boolean
        Dim ds As DataTable = Nothing
        With _Contribuyente.OperadorDatos
            .AgregarParametro("@Accion", "F")
            .AgregarParametro("@Entida_Contribuyente", _Contribuyente.Entida_Codigo)
            .AgregarParametro("@filtro", _filtro)
            .Procedimiento = "proc_Incautacion"
            bReturn = .Ejecutar(ds)
            .LimpiarParametros()
        End With
        If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
            For Each _dr As DataRow In ds.Rows
                Dim _fila As New Incautacion(_Contribuyente.OperadorDatos, False)
                _fila.MapearDataRowaObjeto(_dr)
                oResult.Add(_fila)
            Next
        End If
        Return oResult
    End Function


End Class
#End Region
