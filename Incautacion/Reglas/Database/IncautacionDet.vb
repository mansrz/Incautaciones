'           <Empres_Codigo, int,>
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

#Region "IncautacionDet"

Partial Public Class IncautacionDet
  Inherits _Database

  Private mIncaut_Secuencia As Integer = 0
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

  Private mIncautDet_Secuencia As Integer = 0
  <XmlAttribute()> _
  Public Overridable Property IncautDet_Secuencia() As Integer
    Get
      Return Me.mIncautDet_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mIncautDet_Secuencia = value
      EsModificado = True
    End Set
  End Property

  Private mIncautDet_CantidadIngreso As Integer = 0
  <XmlAttribute()> _
  Public Overridable Property IncautDet_CantidadIngreso() As Integer
    Get
      Return Me.mIncautDet_CantidadIngreso
    End Get
    Set(ByVal value As Integer)
      Me.mIncautDet_CantidadIngreso = value
      EsModificado = True
    End Set
  End Property
  Private mIncautDet_CantidadEgreso As Integer = 0
  <XmlAttribute()> _
  Public Overridable Property IncautDet_CantidadEgreso() As Integer
    Get
      Return Me.mIncautDet_CantidadEgreso
    End Get
    Set(ByVal value As Integer)
      Me.mIncautDet_CantidadEgreso = value
      EsModificado = True
    End Set
  End Property
  Private mIncautDet_Modelo As String = String.Empty

  <XmlAttribute()> _
  Public Overridable Property IncautDet_Modelo() As String
    Get
      Return Me.mIncautDet_Modelo
    End Get
    Set(ByVal value As String)
      Me.mIncautDet_Modelo = value
      EsModificado = True
    End Set
  End Property

  Private mIncautDet_Serie As String = String.Empty

  <XmlAttribute()> _
  Public Overridable Property IncautDet_Serie() As String
    Get
      Return Me.mIncautDet_Serie
    End Get
    Set(ByVal value As String)
      Me.mIncautDet_Serie = value
      EsModificado = True
    End Set
  End Property

  Private mIncautDet_ValorUnit As Decimal = 0

  <XmlAttribute()> _
  Public Overridable Property IncautDet_ValorUnit() As Decimal
    Get
      Return Me.mIncautDet_ValorUnit
    End Get
    Set(ByVal value As Decimal)
      Me.mIncautDet_ValorUnit = value
      EsModificado = True
    End Set
  End Property

  Private mIncautDet_Caracteristicas As String = String.Empty
  <XmlAttribute()> _
  Public Overridable Property IncautDet_Caracteristicas() As String
    Get
      Return Me.mIncautDet_Caracteristicas
    End Get
    Set(ByVal value As String)
      Me.mIncautDet_Caracteristicas = value
      EsModificado = True
    End Set
  End Property

  Private mIncautDet_Observacion As String = String.Empty
  <XmlAttribute()> _
  Public Overridable Property IncautDet_Observacion() As String
    Get
      Return Me.mIncautDet_Observacion
    End Get
    Set(ByVal value As String)
      Me.mIncautDet_Observacion = value
      EsModificado = True
    End Set
  End Property
  Private mIncautDet_Ubicacion As String = String.Empty
  <XmlAttribute()> _
  Public Overridable Property IncautDet_Ubicacion() As String
    Get
      Return Me.mIncautDet_Ubicacion
    End Get
    Set(ByVal value As String)
      Me.mIncautDet_Ubicacion = value
      EsModificado = True
    End Set
  End Property
  Private mParame_UnidadMedida As Integer = 0
  <XmlAttribute()> _
  Public Overridable Property Parame_UnidadMedida() As Integer
    Get
      Return Me.mParame_UnidadMedida
    End Get
    Set(ByVal value As Integer)
      Me.mParame_UnidadMedida = value
      EsModificado = True
    End Set
  End Property

  Private mPardet_UnidadMedida As Integer = 0
  <XmlAttribute()> _
  Public Overridable Property Pardet_UnidadMedida() As Integer
    Get
      Return Me.mPardet_UnidadMedida
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_UnidadMedida = value
      EsModificado = True
    End Set
  End Property

  Private mParame_Descripcion As Integer = 0
  <XmlAttribute()> _
  Public Overridable Property Parame_Descripcio() As Integer
    Get
      Return Me.mParame_Descripcion
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Descripcion = value
      EsModificado = True
    End Set
  End Property

  Private mPardet_Descripcion As Integer = 0
  <XmlAttribute()> _
  Public Overridable Property Pardet_Descripcion() As Integer
    Get
      Return Me.mPardet_Descripcion
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Descripcion = value
      EsModificado = True
    End Set
  End Property

  Private mParame_Marca As Integer = 0
  <XmlAttribute()> _
  Public Overridable Property Parame_Marca() As Integer
    Get
      Return Me.mParame_Marca
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Marca = value
      EsModificado = True
    End Set
  End Property

  Private mPardet_Marca As Integer = 0
  <XmlAttribute()> _
  Public Overridable Property Pardet_Marca() As Integer
    Get
      Return Me.mPardet_Marca
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Marca = value
      EsModificado = True
    End Set
  End Property

  Private mParame_Estado As Integer = 0
  <XmlAttribute()> _
  Public Overridable Property Parame_Estado() As Integer
    Get
      Return Me.mParame_Estado
    End Get
    Set(ByVal value As Integer)
      Me.mParame_Estado = value
      EsModificado = True
    End Set
  End Property

  Private mPardet_Estado As Integer = 0
  <XmlAttribute()> _
  Public Overridable Property Pardet_Estado() As Integer
    Get
      Return Me.mPardet_Estado
    End Get
    Set(ByVal value As Integer)
      Me.mPardet_Estado = value
      EsModificado = True
    End Set
  End Property

  Private mBodega_codigo As Integer = 0
  <XmlAttribute()> _
  Public Overridable Property Bodega_codigo() As Integer
    Get
      Return Me.mBodega_codigo
    End Get
    Set(ByVal value As Integer)
      Me.mBodega_codigo = value
      EsModificado = True
    End Set
  End Property


  Public Sub New()
    MyBase.New()
  End Sub
  
End Class

#End Region
