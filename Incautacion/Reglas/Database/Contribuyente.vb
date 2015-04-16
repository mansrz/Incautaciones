
Option Strict Off
Option Explicit On

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports Infoware.Reglas


#Region "Contribuyente"
Partial Public Class Contribuyente
    Inherits _Database

   
    Private mEntida_Codigo As Integer = 0

    Private mContri_Visible As Boolean = True

    Public Sub New()
        MyBase.New()
    End Sub

    <XmlAttribute()> _
    Public Overridable Property Entida_Codigo() As Integer
        Get
            Return Me.mEntida_Codigo
        End Get
        Set(ByVal value As Integer)
            Me.mEntida_Codigo = value
            EsModificado = True
        End Set
    End Property

    
    <XmlAttribute()> _
    Public Overridable Property Contri_Visible() As Boolean
        Get
            Return Me.mContri_Visible
        End Get
        Set(ByVal value As Boolean)
            Me.mContri_Visible = value
            EsModificado = True
        End Set
    End Property

End Class

#End Region
