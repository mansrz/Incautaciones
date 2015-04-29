<<<<<<< HEAD
﻿Option Strict Off
Option Explicit On

'IncSal_Codigo	int	Unchecked
'Empres_Codigo	int	Unchecked
'IncSal_Secuencia	int	Unchecked
'IncRes_Codigo	int	Unchecked
'Emplea_Administrativo	int	Unchecked
'IncSal_TenedorNombre	nvarchar(250)	Unchecked
'IncSal_TenedorCI	nchar(10)	Unchecked
'IncSal_FechaEntrega	date	Unchecked
'IncSal_NumeroLiquidacion	nvarchar(50)	Unchecked
'IncSal_FechaRegistro	datetime	Unchecked

=======
﻿
Option Strict Off
Option Explicit On

>>>>>>> origin/master
Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports Infoware.Reglas
<<<<<<< HEAD
Imports Infoware.Reglas.General

#Region "Incautacion Salida"

Public Class IncautacionSalida
  Inherits _Database

  Private mIncSal_Codigo As Integer = 0

  Private mEmpresa_Codigo As Integer = 0

  Private mIncSal_Secuencia As Integer = 0

  Private mIncRes_Codigo As Integer = 0

  Private mEmplea_Administrativo As Integer = 0

  Private mIncSal_TenedorNombre As String = String.Empty

  Private mIncSal_TenedorCI As String = String.Empty

  Private mIncSal_NumeroLiquidacion As String = String.Empty

  Private mIncSal_FechaEntrega As Date = Date.Now

  Private mIncSal_FechaRegistro As Date = Date.Now

  Public Sub New()
    MyBase.New()
  End Sub

  <XmlAttribute()> _
  Public Overridable Property IncSal_Codigo() As Integer
    Get
      Return Me.mIncSal_Codigo
    End Get
    Set(ByVal value As Integer)
      Me.mIncSal_Codigo = value
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

  <XmlAttribute()> _
  Public Overridable Property IncSal_Secuencia() As Integer
    Get
      Return Me.mIncSal_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mIncSal_Secuencia = value
      EsModificado = True
    End Set
  End Property

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
  Public Overridable Property Emplea_Administrativo() As Integer
    Get
      Return Me.mEmplea_Administrativo
    End Get
    Set(ByVal value As Integer)
      Me.mEmplea_Administrativo = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property IncSal_TenedorNombre() As String
    Get
      Return Me.mIncSal_TenedorNombre
    End Get
    Set(ByVal value As String)
      Me.mIncSal_TenedorNombre = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property IncSal_TenedorCI() As String
    Get
      Return Me.mIncSal_TenedorCI
    End Get
    Set(ByVal value As String)
      Me.mIncSal_TenedorCI = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property IncSal_NumeroLiquidacion() As String
    Get
      Return Me.mIncSal_NumeroLiquidacion
    End Get
    Set(ByVal value As String)
      Me.mIncSal_NumeroLiquidacion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property IncSal_FechaEntrega() As Date
    Get
      Return Me.mIncSal_FechaEntrega
    End Get
    Set(ByVal value As Date)
      Me.mIncSal_FechaEntrega = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property IncSal_FechaRegistro() As Date
    Get
      Return Me.mIncSal_FechaRegistro
    End Get
    Set(ByVal value As Date)
      Me.mIncSal_FechaRegistro = value
      EsModificado = True
    End Set
  End Property

End Class
#End Region
=======

#Region "IncautacionSalida"
Partial Public Class IncautacionSalida

End Class
#End Region

>>>>>>> origin/master
