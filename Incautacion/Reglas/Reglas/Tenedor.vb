﻿
Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports Infoware.Reglas.General

#Region "Tenedor"
Public Class Tenedor

  Const _Procedimiento As String = "proc_Tenedor"

  Private mEntidad As Entidad = Nothing

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Entida_Codigo As Integer)
    Me.New(_OperadorDatos, False)
    Entida_Codigo = _Entida_Codigo
    If Not Me.Recargar() Then
      Throw New Exception(OperadorDatos.MsgError)
    End If
  End Sub

  'Entidad
  Public Overridable Property Entidad() As Entidad
    Get
      If Me.mEntidad Is Nothing Then
        Me.mEntidad = New Entidad(OperadorDatos, Entida_Codigo)
      End If
      Return Me.mEntidad
    End Get
    Set(ByVal value As Entidad)
      Me.mEntidad = value
      Entida_Codigo = Me.mEntidad.Entida_Codigo
    End Set
  End Property

  Private mNombreCompleto As String = ""

  <Infoware.Reportes.CampoReporteAtributo("Nombre de Cliente", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 250, True)> _
  Public ReadOnly Property NombreCompleto() As String
    Get
      If String.IsNullOrWhiteSpace(mNombreCompleto) Then
        If Entidad Is Nothing Then
          Return String.Empty
        Else
          Return mEntidad.NombreCompleto
        End If
      Else
        Return mNombreCompleto
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Dirección", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 250, True)> _
  Public ReadOnly Property DireccionesString() As String
    Get
      Return Entidad.DireccionesString
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Teléfono", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 250, True)> _
  Public ReadOnly Property TelefonosString() As String
    Get
      Return Entidad.TelefonosString
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("FechaHoy", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Fecha, 150, False)> _
  Public ReadOnly Property FechaHoy() As Date
    Get
      Return Now.Date
    End Get
  End Property

  Private mTotalDeudas As Decimal = 0
  <Infoware.Reportes.CampoReporteAtributo("TotalDeudas", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Decimales, 150, False)> _
  Public Property TotalDeudas() As Decimal
    Get
      Return mTotalDeudas
    End Get
    Set(value As Decimal)
      mTotalDeudas = value
    End Set
  End Property

  Public ReadOnly Property EmailsString() As String
    Get
      Return Entidad.EmailsString
    End Get
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Entida_Codigo = CType(Fila("Entida_Codigo"), Integer)
    Tened_Visible = CType(Fila("Tened_Visible"), Boolean)
    mEntidad = Nothing

  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As System.Data.DataTable = New System.Data.DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    Try
      Me.MapearDataRowaObjeto(Result.Rows(0))
      Me.EsNuevo = False
      Me.EsModificado = False
    Catch ex As Exception
      bReturn = False
    End Try
    Return bReturn
  End Function

  Public Overridable Function Guardar() As Boolean
    'If Not EsNuevo And Not EsModificado Then
    '  Return True
    'End If
    Dim Result As Integer = 0
    Dim bReturn As Boolean = True

    OperadorDatos.ComenzarTransaccion()
    If mEntidad.Pardet_Tipoentidad = Enumerados.EnumTipoEntidad.Natural Then
      mEntidad.Entidadnatural.Entidad = mEntidad
      bReturn = mEntidad.Entidadnatural.Guardar
      If bReturn Then
        mEntidad.Entida_Codigo = mEntidad.Entidadnatural.Entida_Codigo
      End If
    Else
      mEntidad.Entidadjuridica.Entidad = mEntidad
      bReturn = mEntidad.Entidadjuridica.Guardar
      If bReturn Then
        mEntidad.Entida_Codigo = mEntidad.Entidadjuridica.Entida_Codigo
      End If
    End If
    If bReturn Then
      Entida_Codigo = mEntidad.Entida_Codigo

      Dim sAccion As String = "M"
      If EsNuevo Then
        sAccion = "I"
      End If
      OperadorDatos.AgregarParametro("@accion", sAccion)
      OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
      OperadorDatos.AgregarParametro("@Tened_Visible", Tened_Visible)

      OperadorDatos.Procedimiento = _Procedimiento
      bReturn = OperadorDatos.Ejecutar(Result)
      OperadorDatos.LimpiarParametros()
      'If bReturn Then
      '  If Not OperadorDatos.EstaenTransaccion Then
      '    EsNuevo = False
      '    EsModificado = False
      '  End If
      'End If
    End If
    If bReturn Then
      OperadorDatos.TerminarTransaccion()
      AceptarCambios()
    Else
      OperadorDatos.CancelarTransaccion()
    End If
    Return bReturn
  End Function

  Public Overridable Sub AceptarCambios()
    EsNuevo = False
    EsModificado = False

    mEntidad.AceptarCambios()
  End Sub

  Public Overridable Function Eliminar() As Boolean
    If EsNuevo Then
      Return True
    End If
    Dim bReturn As Boolean = True

    OperadorDatos.ComenzarTransaccion()
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Entida_Codigo", Entida_Codigo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      bReturn = mEntidad.Eliminar
    End If
    If bReturn Then
      OperadorDatos.TerminarTransaccion()
    Else
      OperadorDatos.CancelarTransaccion()
    End If
    Return bReturn
  End Function

End Class
#End Region

#Region "ContribuyenteList"
Public Class TenedorList
  Inherits System.ComponentModel.BindingList(Of Tenedor)

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, Optional ByVal _filtro As String = "") As TenedorList
    Dim oResult As TenedorList = New TenedorList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Tenedor"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Tenedor(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class

#End Region
