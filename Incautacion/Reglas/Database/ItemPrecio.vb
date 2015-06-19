Option Strict Off
Option Explicit On

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports Infoware.Reglas
Imports Infoware.Reglas.General


#Region "ItemPrecio"
Partial Public Class ItemPrecio
    Inherits _Database

    Private mItem_Codigo As Integer = 0
    Private mItePre_Secuencia As Integer = 0
    Private mItePre_Valor As Decimal = 0
    Private mItePre_Activo As Boolean
    Private mItePre_Observacion As String = ""
    'Private mItePre_FechaRegistro As Date = Nothing

    Public Sub New()
        MyBase.New()
    End Sub

    <XmlAttribute()> _
    Public Overridable Property Item_Codigo() As Integer
        Get
            Return Me.mItem_Codigo
        End Get
        Set(ByVal value As Integer)
            Me.mItem_Codigo = value
            EsModificado = True
        End Set
    End Property

    <XmlAttribute()> _
    Public Overridable Property ItePre_Secuencia() As Integer
        Get
            Return Me.mItePre_Secuencia
        End Get
        Set(ByVal value As Integer)
            Me.mItePre_Secuencia = value
            EsModificado = True
        End Set
    End Property

    <XmlAttribute()> _
    <Infoware.Reportes.CampoReporteAtributo("Activo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Logico, 10, True)> _
    Public Overridable Property ItePre_Activo() As Boolean
        Get
            Return Me.mItePre_Activo
        End Get
        Set(ByVal value As Boolean)
            Me.mItePre_Activo = value
            EsModificado = True
        End Set
    End Property

    <XmlAttribute()> _
    <Infoware.Reportes.CampoReporteAtributo("Valor", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Decimales, 20, True)> _
    Public Overridable Property ItePre_Valor() As Decimal
        Get
            Return Me.mItePre_Valor
        End Get
        Set(ByVal value As Decimal)
            Me.mItePre_Valor = value
            EsModificado = True
        End Set
    End Property


    <XmlAttribute()> _
    <Infoware.Reportes.CampoReporteAtributo("Observación", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 20, True)> _
    Public Overridable Property ItePre_Observacion() As String
        Get
            Return Me.mItePre_Observacion
        End Get
        Set(ByVal value As String)
            Me.mItePre_Observacion = value
            EsModificado = True
        End Set
    End Property

    '<XmlAttribute()> _
    '<Infoware.Reportes.CampoReporteAtributo("Código", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 50, True)> _
    'Public Overridable Property Item_Codigo() As Integer
    '    Get
    '        Return Me.mItem_Codigo
    '    End Get
    '    Set(ByVal value As Integer)
    '        Me.mItem_Codigo = value
    '        EsModificado = True
    '    End Set
    'End Property

End Class
#End Region