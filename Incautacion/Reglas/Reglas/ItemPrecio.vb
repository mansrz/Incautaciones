Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports Infoware.Reglas.General

Imports System.IO
Imports System.ComponentModel

#Region "ItemPrecio"

Public Class ItemPrecio
    Const _Procedimiento As String = "proc_ItemPrecio"

    Private mItem As Item = Nothing

    Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
        MyBase.New()
        OperadorDatos = _OperadorDatos
        EsNuevo = _EsNuevo
    End Sub

    Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Item_Codigo As Integer, ByVal _ItePre_Secuencia As Integer)
        Me.New(_OperadorDatos, False)
        Item_Codigo = _Item_Codigo
        ItePre_Secuencia = _ItePre_Secuencia
        If Not Me.Recargar Then
            Throw New Exception(OperadorDatos.MsgError)
        End If
    End Sub

    Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
        Item_Codigo = CType(Fila("Item_Codigo"), Integer)
        ItePre_Secuencia = CType(Fila("ItePre_Secuencia"), Integer)
        ItePre_Activo = CType(Fila("ItePre_Activo"), Boolean)
        ItePre_Valor = CType(Fila("ItePre_Valor"), Decimal)
        ItePre_Observacion = CType(Fila("ItePre_Observacion"), String)

        Try
            mItem = New Item(OperadorDatos, Item_Codigo)
            mItem.Recargar()
        Catch ex As Exception
            MsgBox("No se pudo recargar el item")
        End Try

    End Sub

    Public Overridable Function Recargar() As Boolean

        Dim Result As New DataTable
        Dim bReturn As Boolean = True
        OperadorDatos.AgregarParametro("@accion", "C")
        OperadorDatos.AgregarParametro("@Item_Codigo", Item_Codigo)
        OperadorDatos.AgregarParametro("@ItePre_Secuencia", ItePre_Secuencia)
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

    Public Overridable Function Guardar() As Boolean
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

        Dim sAccion As String = "M"
        If EsNuevo Then
            sAccion = "I"
        End If
        OperadorDatos.AgregarParametro("@accion", sAccion)
        OperadorDatos.AgregarParametro("@Item_Codigo", Item_Codigo)
        OperadorDatos.AgregarParametro("@ItePre_Secuencia", ItePre_Secuencia)
        OperadorDatos.AgregarParametro("@ItePre_Activo", ItePre_Activo)
        OperadorDatos.AgregarParametro("@ItePre_Valor", ItePre_Valor)
        OperadorDatos.AgregarParametro("@ItePre_Observacion", ItePre_Observacion)

        OperadorDatos.Procedimiento = _Procedimiento
        bReturn = OperadorDatos.Ejecutar(Result)
        OperadorDatos.LimpiarParametros()
        If bReturn Then
            If EsNuevo Then
                ItePre_Secuencia = Result
            End If

            If Not OperadorDatos.EstaenTransaccion Then
                AceptarCambios()
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
    End Sub


    Public Overridable Function Eliminar() As Boolean
        If EsNuevo Then
            Return True
        End If

        Dim bReturn As Boolean = True
        OperadorDatos.AgregarParametro("@accion", "E")
        OperadorDatos.AgregarParametro("@Item_Codigo", Item_Codigo)
        OperadorDatos.AgregarParametro("@ItePre_Secuencia", ItePre_Secuencia)
        OperadorDatos.Procedimiento = _Procedimiento
        bReturn = OperadorDatos.Ejecutar
        OperadorDatos.LimpiarParametros()
        Return bReturn
    End Function


End Class
#End Region


#Region "ItemPrecioList"
Public Class ItemPrecioList
    Inherits BindingList(Of ItemPrecio)

    Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, ByVal _Item As Item, Optional ByVal _filtro As String = "") As ItemPrecioList

        Dim oResult As ItemPrecioList = New ItemPrecioList
        Dim bReturn As Boolean
        Dim ds As New DataTable
        With _OperadorDatos
            .AgregarParametro("@Accion", "F")
            .AgregarParametro("@Item_Codigo", _Item.Item_Codigo)
            '.AgregarParametro("@filtro", _filtro)
            .Procedimiento = "proc_ItemPrecio"
            bReturn = .Ejecutar(ds)
            .LimpiarParametros()
        End With
        If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
            For Each _dr As DataRow In ds.Rows
                Dim _fila As New ItemPrecio(_OperadorDatos, False)
                _fila.MapearDataRowaObjeto(_dr)
                oResult.Add(_fila)
            Next
        End If
        Return oResult
    End Function


End Class
#End Region