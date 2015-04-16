Imports Infoware.Datos
Imports Infoware.Reglas.General
'Imports WWTS.Inventario.Reglas

Imports Incautacion.Reglas

Public Class CtlGruposTouch
  Private mOperadorDatos As OperadorDatos = Nothing
  Public Property OperadorDatos() As OperadorDatos
    Get
      Return mOperadorDatos
    End Get
    Set(ByVal value As OperadorDatos)
      mOperadorDatos = value
      If value IsNot Nothing Then
        mGrupos = ItemList.ObtenerListaGruposxTipoInventario(mOperadorDatos, mTipoInventario)
        Llenar_datos()
      End If
    End Set
  End Property

  Private mTipoInventario As WWTSParametroDet = Nothing
  Public Property TipoInventario() As WWTSParametroDet
    Get
      Return mTipoInventario
    End Get
    Set(ByVal value As WWTSParametroDet)
      mTipoInventario = value
      If value IsNot Nothing Then
        mGrupos = ItemList.ObtenerListaGruposxTipoInventario(mOperadorDatos, mTipoInventario)
        Llenar_datos()
      End If
    End Set
  End Property

  Private mGrupo As WWTSParametroDet = Nothing
  Public Property Grupo() As WWTSParametroDet
    Get
      Return mGrupo
    End Get
    Set(ByVal value As WWTSParametroDet)
      mGrupo = value
      If value IsNot Nothing Then
        Dim t As Integer = 1
        For Each _grupo As WWTSParametroDet In mGrupos
          If _grupo.Pardet_Secuencia = mGrupo.Pardet_Secuencia Then
            Exit For
          End If
          t += 1
        Next
        mPagina = Math.Floor((t - 1) / 12) + 1
        Llenar_datos()
      End If
    End Set
  End Property

  Private mOpciones As New List(Of RadioButton)
  Private mGrupos As WWTSParametroDetList
  Private mPagina As Integer = 1

  Public Sub Llenar_datos()
    If mGrupos Is Nothing Then
      Exit Sub
    End If
    mOpciones.Clear()
    mOpciones.Add(Me.RadioButton1)
    mOpciones.Add(Me.RadioButton2)
    mOpciones.Add(Me.RadioButton3)
    mOpciones.Add(Me.RadioButton4)
    mOpciones.Add(Me.RadioButton5)
    mOpciones.Add(Me.RadioButton6)
    mOpciones.Add(Me.RadioButton7)
    mOpciones.Add(Me.RadioButton8)
    mOpciones.Add(Me.RadioButton9)
    mOpciones.Add(Me.RadioButton10)
    mOpciones.Add(Me.RadioButton11)
    mOpciones.Add(Me.RadioButton12)

    Dim encontro As Boolean = False
    For t As Integer = 1 To 12
      Dim indice As Integer = (mPagina - 1) * 12 + t - 1
      With mOpciones(t - 1)
        If indice < mGrupos.Count Then
          .Visible = True
          .Text = mGrupos(indice).Pardet_Descripcion
          .Image = mGrupos(indice).Pardet_Imagen(IIf(.Height < .Width, .Height, .Width))
          .Tag = mGrupos(indice)

          If mGrupo IsNot Nothing AndAlso mGrupos(indice).Pardet_Secuencia = mGrupo.Pardet_Secuencia Then
            encontro = True
            .Checked = True
          End If
        Else
          .Visible = False
        End If
      End With
    Next
    Me.picanterior.Visible = mPagina > 1
    Me.picsiguiente.Visible = mGrupos.Count > (mPagina) * 12

    If mOpciones(0).Visible AndAlso Not encontro Then
      mOpciones(0).Checked = True
      mGrupo = Me.RadioButton1.Tag
      RaiseEvent CambioGrupo(Me, Nothing)
    End If
  End Sub

  Private Sub CtlGrupos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.picanterior.Image = My.Resources.arrowfirst
    Me.picsiguiente.Image = My.Resources.arrowlast
  End Sub

  Private Sub picsiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picsiguiente.Click
    If mPagina < mGrupos.Count / 12 Then
      mPagina += 1
      Llenar_datos()
    End If
  End Sub

  Private Sub picanterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picanterior.Click
    If mPagina > 1 Then
      mPagina -= 1
      Llenar_datos()
    End If
  End Sub

  Private Sub CtlGrupos_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    Llenar_datos()
  End Sub

  Public Event CambioGrupo As EventHandler
  Private Sub ClicenOpcion(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged, RadioButton7.CheckedChanged, RadioButton8.CheckedChanged, RadioButton9.CheckedChanged, RadioButton10.CheckedChanged, RadioButton11.CheckedChanged, RadioButton12.CheckedChanged
    mGrupo = CType(sender, RadioButton).Tag
    My.Computer.Audio.Play(My.Resources.Elemento_emergente_bloqueado_de_Windows_Xp, AudioPlayMode.WaitToComplete)

    RaiseEvent CambioGrupo(Me, Nothing)
  End Sub
End Class
