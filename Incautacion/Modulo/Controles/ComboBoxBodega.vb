Imports Infoware.Datos
Imports Infoware.Controles.Base
Imports Infoware.Reglas.General
'Imports WWTS.Inventario.Reglas
Imports System.ComponentModel
Imports Incautacion.Reglas

<ToolboxItem(True)> _
Public Class ComboBoxBodega
  Inherits ComboBoxDB

  Private mSucursal As Sucursal = Nothing
  Public Property Sucursal() As Sucursal
    Get
      Return mSucursal
    End Get
    Set(ByVal value As Sucursal)
      mSucursal = value
    End Set
  End Property

  Private mBodegas As BodegaList
  Public Property Bodega() As Bodega
    Get
      If mBodegas Is Nothing OrElse mBodegas.Count = 0 OrElse MyBase.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mBodegas(MyBase.SelectedIndex)
      End If
    End Get
    Set(ByVal value As Bodega)
      If value Is Nothing Then
        Me.SelectedIndex = -1
      Else
        Me.SelectedValue = value.Bodega_Codigo
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
    MyBase.DisplayMember = "NombreCompleto"
    MyBase.ValueMember = "Bodega_Codigo"
    mBodegas = BodegaList.ObtenerLista(mSucursal)
    MyBase.DataSource = mBodegas
  End Sub
End Class

