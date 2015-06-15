Imports Infoware.Datos
Imports Incautacion.Reglas
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class clsReporteMovimientoInventarioIncautacion
    Public Shared Function RetornarReporteMovimientoInventarioIncautacionDS(_MovimientoInventario As MovimientoInventario) As dsMovimientoInventarioIncautacion
        Dim bReturn As Boolean
        Dim ds As New dsMovimientoInventarioIncautacion
        With _MovimientoInventario.OperadorDatos
            .AgregarParametro("@accion", "rmii")
            .AgregarParametro("@Incaut_Codigo", _MovimientoInventario.Incaut_Codigo)
            .Comando.CommandText = "proc_MovimientoInventario"

            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter(.Comando)
            Try
                DataAdapter.Fill(ds, "vw_MovimientoInventarioIncautacion")
            Catch ex As Exception
                bReturn = False
            End Try

            .LimpiarParametros()
        End With
        Return ds
    End Function

End Class
