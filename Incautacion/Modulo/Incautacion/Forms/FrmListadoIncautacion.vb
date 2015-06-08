Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmListadoIncautacion
    Private mContribuyente As Contribuyente = Nothing
    Public Property Contribuyente As Contribuyente
        Get
            Return mContribuyente
        End Get
        Set(value As Contribuyente)
            mContribuyente = value
        End Set
    End Property

    Private mIncautacion As Reglas.Incautacion = Nothing
    Public Property Incautacion() As Reglas.Incautacion
        Get
            If ListBindingSource.Current Is Nothing Then
                Return Nothing
            Else
                Return ListBindingSource.Current
            End If
        End Get
        Set(value As Reglas.Incautacion)
            If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
                Dim t As Integer = 0
                For Each _Incautacion As Reglas.Incautacion In Me.ListBindingSource.DataSource
                    If _Incautacion.Incaut_Codigo = value.Incaut_Codigo Then
                        ListBindingSource.Position = t
                    End If
                    t += 1
                Next
            End If
        End Set
    End Property

    Public Property Filtro() As String
        Get
            Return MyBase.combobuscar.Text
        End Get
        Set(ByVal value As String)
            MyBase.combobuscar.Text = value
            MyBase.Hacer_busqueda()
        End Set
    End Property


End Class