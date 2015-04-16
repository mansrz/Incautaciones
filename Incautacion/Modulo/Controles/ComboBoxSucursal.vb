Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Controles.Base
Imports System.ComponentModel
Imports Incautacion.Reglas

<ToolboxItem(True)> _
Public Class ComboBoxSucursal
  Inherits ComboBoxDB

  Private mEmpresa As Empresa = Nothing
  Public Property Empresa() As Empresa
    Get
      Return mEmpresa
    End Get
    Set(ByVal value As Empresa)
      mEmpresa = value
      Llenar_datos()
    End Set
  End Property

  Private mSucursales As SucursalList
  Public Property Sucursal() As Sucursal
    Get
      If mSucursales Is Nothing OrElse mSucursales.Count = 0 OrElse MyBase.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mSucursales(MyBase.SelectedIndex)
      End If
    End Get
    Set(ByVal value As Sucursal)
      If value Is Nothing Then
        Me.SelectedIndex = -1
      Else
        Me.SelectedValue = value.Sucurs_Codigo
      End If
    End Set
  End Property

  Public Sub New()
    MyBase.PuedeNuevo = False
    MyBase.PuedeModificar = False
    MyBase.PuedeEliminar = False
    MyBase.PuedeActualizar = False
  End Sub

  Public Sub Llenar_datos()
    If mEmpresa Is Nothing Then
      MyBase.DataSource = Nothing
    Else
      MyBase.DisplayMember = "NombreCompleto"
      MyBase.ValueMember = "Sucurs_Codigo"
      mSucursales = SucursalList.ObtenerLista(mEmpresa)
      MyBase.DataSource = mSucursales
    End If
  End Sub
End Class

