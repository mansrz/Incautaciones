Imports Infoware.Consola.Base
Imports Infoware.Datos
Imports Infoware.Reglas.General

Public Class FrmDesbloquear
  Private mUsuarioIngresado As Usuario = Nothing
  Public ReadOnly Property UsuarioIngresado As Usuario
    Get
      Return mUsuarioIngresado
    End Get
  End Property

  Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
    Try
      Dim mUsuario As New Usuario(mRestriccion.OperadorDatos, Me.txtnombreusuario.Text)
      If Not mUsuario.VerificarPassword(Me.txtcontrasena.Text) Then
        Throw New Exception("Error al autenticarse" & Environment.NewLine & "Posibles causas:" & Environment.NewLine & "Revise que tenga acceso al servidor, que el servidor de datos este activo " & Environment.NewLine & "y además que el usuario y la clave sean correctas")
      End If

      Dim _restric As Restriccion = mUsuario.Restricciones.Buscar(mRestriccion.Pardet_Opciones)
      If _restric IsNot Nothing AndAlso _restric.Restri_VerConfidencial Then
        mUsuarioIngresado = mUsuario
        Me.DialogResult = Windows.Forms.DialogResult.OK
      Else
        Throw New Exception("El usuario ingresado no tiene los permisos adecuados")
      End If

      'Me.ColorFadeBusyBar1.Stop()
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
    End Try
  End Sub

  Private mRestriccion As Restriccion
  Public Sub New(ByVal _Restriccion As Restriccion)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    mRestriccion = _Restriccion
  End Sub
End Class