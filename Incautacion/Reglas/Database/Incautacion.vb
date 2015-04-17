﻿'           <Empres_Codigo, int,>
'           ,<Sucurs_Codigo, int,>
'           ,<Parame_TipoIncautacionMov, int,>
'           ,<Pardet_TipoIncautacionMov, int,>
'           ,<Entida_Contribuyente, int,>
'           ,<Incautacion_Numero, char(15),>
'           ,<Incaut_Secuncia, int,>
'           ,<Parame_Tipomovinv, int,>
'           ,<Pardet_TipoMovinv, int,>
'           ,<Movinv_Secuencia, int,>
'           ,<Incaut_Fecha, date,>
'           ,<Incaut_Responsable, nvarchar(50),>


Option Strict Off
Option Explicit On

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports Infoware.Reglas
Imports Infoware.Reglas.General

#Region "Incautacion"

Partial Public Class Incautacion
    Inherits _Database
    Private mEmpres_Codigo As Integer = 0

    Private mSucurs_Codigo As Integer = 0

    Private mParame_TipoIncautacionMov As Integer = 441

    Private mPardet_TipoIncautacionMov As Integer = 1

    Private mEntida_Contribuyente As Integer = 0

    Private mIncautacion_Numero As String = String.Empty

  Private mIncaut_Secuencia As Integer = 0

    Private mIncaut_Fecha As Date = Now.Date

  Private mIncaut_Responsable As String = String.Empty
  Private mEntida_Tenedor As Integer = 0
  Private mIncaut_Observacion As String = String.Empty

  Private mEmpleado_Fedatario As Integer = 0
  Private mEmpleado_Administrattivo

    Public Sub New()
        MyBase.New()
    End Sub



  <XmlAttribute()> _
  Public Overridable Property Incaut_Observacion() As String
    Get
      Return Me.mIncaut_Observacion
    End Get
    Set(ByVal value As String)
      Me.mIncaut_Observacion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Empleado_Administrativo() As Integer
    Get
      Return Me.mEmpleado_Administrattivo
    End Get
    Set(ByVal value As Integer)
      Me.mEmpleado_Administrattivo = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Empleado_Fedatario() As Integer
    Get
      Return Me.mEmpleado_Fedatario
    End Get
    Set(ByVal value As Integer)
      Me.mEmpleado_Fedatario = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Entida_Tenedor() As Integer
    Get
      Return Me.mEntida_Tenedor
    End Get
    Set(ByVal value As Integer)
      Me.mEntida_Tenedor = value
      EsModificado = True
    End Set
  End Property

    <XmlAttribute()> _
    Public Overridable Property Empres_Codigo() As Integer
        Get
            Return Me.mEmpres_Codigo
        End Get
        Set(ByVal value As Integer)
            Me.mEmpres_Codigo = value
            EsModificado = True
        End Set
    End Property

    <XmlAttribute()> _
    Public Overridable Property Sucurs_Codigo() As Integer
        Get
            Return Me.mSucurs_Codigo
        End Get
        Set(ByVal value As Integer)
            Me.mSucurs_Codigo = value
            EsModificado = True
        End Set
    End Property

    <XmlAttribute()> _
    Public Overridable Property Parame_TipoIncautacionMov() As Integer
        Get
            Return Me.mParame_TipoIncautacionMov
        End Get
        Set(ByVal value As Integer)
            Me.mParame_TipoIncautacionMov = value
            EsModificado = True
        End Set
    End Property

    <XmlAttribute()> _
    Public Overridable Property Pardet_TipoIncautacionMov() As Integer
        Get
            Return Me.mPardet_TipoIncautacionMov
        End Get
        Set(ByVal value As Integer)
            Me.mPardet_TipoIncautacionMov = value
            EsModificado = True
        End Set
    End Property

    <XmlAttribute()> _
    Public Overridable Property Entida_Contribuyente() As Integer
        Get
            Return Me.mEntida_Contribuyente
        End Get
        Set(ByVal value As Integer)
            Me.mEntida_Contribuyente = value
            EsModificado = True
        End Set
    End Property

    <XmlAttribute()> _
    Public Overridable Property Incautacion_Numero() As String
        Get
            Return Me.mIncautacion_Numero
        End Get
        Set(ByVal value As String)
            Me.mIncautacion_Numero = value
            EsModificado = True
        End Set
    End Property



  <XmlAttribute()> _
  Public Overridable Property Incaut_Secuencia() As Integer
    Get
      Return Me.mIncaut_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mIncaut_Secuencia = value
      EsModificado = True
    End Set
  End Property

    <XmlAttribute()> _
     <Infoware.Reportes.CampoReporteAtributo("Fecha", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Fecha, 85, True)> _
    Public Overridable Property Incaut_Fecha() As Date
        Get
            Return Me.mIncaut_Fecha
        End Get
        Set(ByVal value As Date)
            Me.mIncaut_Fecha = value
            EsModificado = True
        End Set
    End Property


    <XmlAttribute()> _
    Public Overridable Property Incaut_Responsable() As String
        Get
            Return Me.mIncaut_Responsable
        End Get
        Set(ByVal value As String)
            Me.mIncaut_Responsable = value
            EsModificado = True
        End Set
    End Property

End Class

#End Region
