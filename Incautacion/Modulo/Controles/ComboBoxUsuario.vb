Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Controles.Base
Imports Infoware.Reglas.General
Imports Incautacion.Reglas
Imports System.ComponentModel

<ToolboxItem(True)> _
Public Class ComboBoxUsuario
  Inherits ComboBoxDB

  Private mOperadorDatos As OperadorDatos = Nothing
  Public Property OperadorDatos() As OperadorDatos
    Get
      Return mOperadorDatos
    End Get
    Set(ByVal value As OperadorDatos)
      mOperadorDatos = value
      Llenar_datos()
    End Set
  End Property

  Private mUsuarios As UsuarioList
  Public Property Usuario() As Usuario
    Get
      If mUsuarios Is Nothing OrElse mUsuarios.Count = 0 OrElse MyBase.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mUsuarios(MyBase.SelectedIndex)
      End If
    End Get
    Set(ByVal value As Usuario)
      If value Is Nothing Then
        Me.SelectedIndex = -1
      Else
        Me.SelectedValue = value.Usuari_Codigo
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
    If mOperadorDatos Is Nothing Then
      MyBase.DataSource = Nothing
    Else
      MyBase.DisplayMember = "Descripcion"
      MyBase.ValueMember = "Usuari_Codigo"
      mUsuarios = UsuarioList.ObtenerLista(mOperadorDatos)
      MyBase.DataSource = mUsuarios
    End If
  End Sub
End Class

