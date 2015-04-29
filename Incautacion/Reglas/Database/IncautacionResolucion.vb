Option Strict Off
Option Explicit On

'IncRes_Codigo	int	Unchecked
'IncRes_Numero	nvarchar(50)	Unchecked
'IncRes_Fecha	date	Unchecked
'IncRes_FechaNotificacion	date	Unchecked
'Parame_TipoResolucion	int	Unchecked
'IncRes_FechaEntrega	nchar(10)	Checked
'IncRes_NumeroLiquidacion	nchar(10)	Checked
'Pardet_TipoResolucion	int	Unchecked

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports Infoware.Reglas
Imports Infoware.Reglas.General

#Region "Incautacion Resolucion"

Public Class IncautacionResolucion
  Inherits _Database

  Private mIncRes_Codigo As Integer = 0

  Private mIncRes_Numero As String = String.Empty

  Private mIncRes_Fecha As Date = Date.Now

  Private mEmpresa_Codigo As Integer = 0

  Private mIncRes_FechaNotificacion As Date = Date.Now

  Private mParame_TipoResolucion As Integer = 0

  Private mIncRes_FechaEntrega As Date = Date.Now

  Private mPardet_TipoResolucion As Integer = 0

  Private mIncres_NumeroLiquidacion As String = String.Empty

  Public Sub New()
    MyBase.New()
  End Sub

  <XmlAttribute()> _
  Public Overridable Property IncRes_Codigo() As Integer
    Get
      Return Me.mIncRes_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mIncRes_Codigo = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property IncRes_NumeroLiquidacion() As String
    Get
      Return Me.mIncres_NumeroLiquidacion
    End Get
    Set(ByVal value As String)
      Me.mIncres_NumeroLiquidacion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property IncRes_Numero() As String
    Get
      Return Me.mIncRes_Numero
    End Get
    Set(ByVal value As String)
      Me.mIncRes_Numero = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property IncRes_Fecha() As Date
    Get
      Return Me.mIncRes_Fecha
    End Get
    Set(ByVal value As Date)
      Me.mIncRes_Fecha = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property IncRes_FechaNotificacion() As Date
    Get
      Return Me.mIncRes_FechaNotificacion
    End Get
    Set(ByVal value As Date)
      Me.mIncRes_FechaNotificacion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_TipoResolucion() As Integer
    Get
      Return Me.mParame_TipoResolucion
    End Get
    Set(ByVal value As Integer)
      Me.mParame_TipoResolucion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property IncRes_FechaEntrega() As Date
    Get
      Return Me.mIncRes_FechaEntrega
    End Get
    Set(ByVal value As Date)
      Me.mIncRes_FechaEntrega = value
      EsModificado = True
    End Set
  End Property


  <XmlAttribute()> _
  Public Overridable Property Pardet_TipoResolucion() As Integer
    Get
      Return Me.mPardet_TipoResolucion
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_TipoResolucion = value
      EsModificado = True
    End Set
  End Property



  <XmlAttribute()> _
  Public Overridable Property Empresa_Codigo() As Integer
    Get
      Return Me.mEmpresa_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mEmpresa_Codigo = value
      EsModificado = True
    End Set
  End Property






End Class

#End Region

