﻿
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports Infoware.Reglas

#Region "ItemPrecioxCantidad"
Partial Public Class ItemPrecioxCantidad
  Inherits _Database

  Private mEmpres_Codigo As Integer = 0

  Private mSucurs_Codigo As Integer = 0

  Private mItem_Codigo As Integer = 0

  Private mItPrCa_Secuencia As Integer = 0

  Private mItPrCa_CantidadDesde As Decimal = 0

  Private mItPrCa_ValorUnitario As Decimal = 0

  Public Sub New()
    MyBase.New()
  End Sub

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
  Public Overridable Property ItPrCa_Secuencia() As Integer
    Get
      Return Me.mItPrCa_Secuencia
    End Get
    Set(ByVal value As Integer)
      Me.mItPrCa_Secuencia = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property ItPrCa_CantidadDesde() As Decimal
    Get
      Return Me.mItPrCa_CantidadDesde
    End Get
    Set(ByVal value As Decimal)
      Me.mItPrCa_CantidadDesde = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property ItPrCa_ValorUnitario() As Decimal
    Get
      Return Me.mItPrCa_ValorUnitario
    End Get
    Set(ByVal value As Decimal)
      Me.mItPrCa_ValorUnitario = value
      EsModificado = True
    End Set
  End Property
End Class
#End Region