Imports Infoware.Consola.Base
Imports Infoware.Reglas.General

Public Class CtlBloqueo
  Private mRestriccion As Restriccion

  Public Property Restriccion As Restriccion
    Get
      Return mRestriccion
    End Get
    Set(ByVal value As Restriccion)
      mRestriccion = value
      If value IsNot Nothing Then
        mBloqueado = Not value.Restri_VerConfidencial
        dibujar()
      End If
    End Set
  End Property

  Private mUsuarioIngresado As Usuario = Nothing
  Public ReadOnly Property UsuarioIngresado As Usuario
    Get
      Return mUsuarioIngresado
    End Get
  End Property

  Sub dibujar()
    If mBloqueado Then
      Me.PictureBox1.Image = My.Resources.lockon.ToBitmap
    Else
      Me.PictureBox1.Image = My.Resources.lockoff.ToBitmap
    End If
  End Sub

  Private mBloqueado As Boolean = True
  Public ReadOnly Property Bloqueado As Boolean
    Get
      Return mBloqueado
    End Get
  End Property

  Public Event Desbloquear As EventHandler

  Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
    If Not Bloqueado Then
      Exit Sub
    End If
    Dim f As New FrmDesbloquear(mRestriccion)
    If f.ShowDialog = DialogResult.OK Then
      mBloqueado = False
      dibujar()
      mUsuarioIngresado = f.UsuarioIngresado
      RaiseEvent Desbloquear(Me, Nothing)
    End If
  End Sub

  Private Sub PictureBox1_LoadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles PictureBox1.LoadCompleted
    Me.TabStop = False
  End Sub
End Class
