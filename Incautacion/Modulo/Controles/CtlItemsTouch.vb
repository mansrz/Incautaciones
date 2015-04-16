Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Incautacion.Reglas

'Imports WWTS.Inventario.Reglas

Public Class CtlItemsTouch
  Private mOperadorDatos As OperadorDatos = Nothing
  Public Property OperadorDatos() As OperadorDatos
    Get
      Return mOperadorDatos
    End Get
    Set(ByVal value As OperadorDatos)
      mOperadorDatos = value
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
        mPagina = 1
        Me.lbl_grupo.Text = mGrupo.Pardet_Descripcion
        mItems = ItemList.ObtenerLista(mOperadorDatos, mGrupo, mTipoInventario)
        Llenar_datos()
      End If
    End Set
  End Property

  Private mSoloUno As Boolean = False
  Public Property SoloUno() As Boolean
    Get
      Return mSoloUno
    End Get
    Set(ByVal value As Boolean)
      mSoloUno = value
      Me.pnlcantidad.Visible = Not mSoloUno
    End Set
  End Property

  Private mTipoInventario As WWTSParametroDet = Nothing
  Public Property TipoInventario() As WWTSParametroDet
    Get
      Return mTipoInventario
    End Get
    Set(ByVal value As WWTSParametroDet)
      mTipoInventario = value
      If mOperadorDatos IsNot Nothing Then
        mItems = ItemList.ObtenerLista(mOperadorDatos, mGrupo, mTipoInventario)
        Llenar_datos()
      End If
    End Set
  End Property

  Private mItem As Item = Nothing
  Public Property Item() As Item
    Get
      Return mItem
    End Get
    Set(ByVal value As Item)
      mItem = value
      If value IsNot Nothing Then
        Dim t As Integer = 1
        For Each _item As Item In mItems
          If _item.Item_Codigo = mItem.Item_Codigo Then
            Exit For
          End If
          t += 1
        Next
        mPagina = Math.Floor((t - 1) / 20) + 1
        Llenar_datos()
      End If
    End Set
  End Property

  Private mOpciones As New List(Of Button)
  Private mItems As ItemList
  Private mPagina As Integer = 1

  Public Delegate Function DelegateSegundaLinea(ByVal _Item As Item) As String
  Private mSegundaLinea As DelegateSegundaLinea
  Public Property SegundaLinea() As DelegateSegundaLinea
    Get
      Return mSegundaLinea
    End Get
    Set(ByVal value As DelegateSegundaLinea)
      mSegundaLinea = value
    End Set
  End Property

  Public Sub Llenar_datos()
    If mItems Is Nothing Then
      Exit Sub
    End If
    mOpciones.Clear()
    mOpciones.Add(Me.Button1)
    mOpciones.Add(Me.Button2)
    mOpciones.Add(Me.Button3)
    mOpciones.Add(Me.Button4)
    mOpciones.Add(Me.Button5)
    mOpciones.Add(Me.Button6)
    mOpciones.Add(Me.Button7)
    mOpciones.Add(Me.Button8)
    mOpciones.Add(Me.Button9)
    mOpciones.Add(Me.Button10)
    mOpciones.Add(Me.Button11)
    mOpciones.Add(Me.Button12)
    mOpciones.Add(Me.Button13)
    mOpciones.Add(Me.Button14)
    mOpciones.Add(Me.Button15)
    mOpciones.Add(Me.Button16)
    mOpciones.Add(Me.Button17)
    mOpciones.Add(Me.Button18)
    mOpciones.Add(Me.Button19)
    mOpciones.Add(Me.Button20)

    Dim encontro As Boolean = False
    For t As Integer = 1 To 20
      Dim indice As Integer = (mPagina - 1) * 20 + t - 1
      With mOpciones(t - 1)
        If indice < mItems.Count Then
          .Visible = True
          .Text = mItems(indice).Item_Descripcion
          If SegundaLinea IsNot Nothing Then
            .Text = .Text & " " & SegundaLinea(mItems(indice))
          End If
          .Image = mItems(indice).Item_Imagen(IIf(.Height < .Width, .Height, .Width))
          .Tag = mItems(indice)
          .BackColor = Color.Transparent

          If mItem IsNot Nothing AndAlso mItems(indice).Item_Codigo = mItem.Item_Codigo Then
            encontro = True
            .BackColor = Color.Turquoise
          End If
        Else
          .Visible = False
        End If
      End With
    Next

    Me.picanterior.Visible = mPagina > 1
    Me.picsiguiente.Visible = mItems.Count > (mPagina) * 20
    'If mOpciones(0).Visible Then
    '  mOpciones(0).Checked = True
    'End If

    If mOpciones(0).Visible AndAlso Not encontro Then
      'mOpciones(0).BackColor = Color.Turquoise
      mItem = Me.Button1.Tag
    End If
  End Sub

  Private Sub CtlItemsTouch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.picanterior.Image = My.Resources.arrowfirst
    Me.picsiguiente.Image = My.Resources.arrowlast
    Me.picmas.Image = My.Resources.insert16.ToBitmap
    Me.picmenos.Image = My.Resources.delete16.ToBitmap
  End Sub

  Private Sub picsiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picsiguiente.Click
    If mPagina < mItems.Count / 20 Then
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

  Private Sub CtlItemsTouch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    Llenar_datos()
  End Sub

  Public Event CambioItem As EventHandler
  Private Sub ClicenOpcion(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click
    Dim boton As Button = CType(sender, Button)
    mItem = boton.Tag
    My.Computer.Audio.Play(My.Resources.start, AudioPlayMode.WaitToComplete)
    'Cantidad = 1

    Dim PardetUnidadMedidas As WWTSParametroDetList = Nothing
    If mItem.Item_Combo Then
      Cantidad = 1
      PardetUnidadMedidas = New WWTSParametroDetList
      PardetUnidadMedidas.Add(mItem.PardetUnidadMedida)
    Else
      PardetUnidadMedidas = WWTSParametroDetList.ObtenerLista(mOperadorDatos, Enumerados.EnumParametros.UnidadMedida, ParametroDetList.enumTipoObjeto.UnidadMedida, mItem.PardetUnidadMedida)
    End If

    If Not mSoloUno AndAlso PardetUnidadMedidas.Count > 1 Then
      Me.ContextMenuStrip1.Items.Clear()
      For Each _pardetunidmed As WWTSParametroDet In PardetUnidadMedidas
        Dim menu As New ToolStripMenuItem
        menu.Text = _pardetunidmed.Pardet_Descripcion
        menu.Tag = _pardetunidmed
        Me.ContextMenuStrip1.Items.Add(menu)
        AddHandler menu.Click, AddressOf SeleccionarMenu
      Next
      Me.ContextMenuStrip1.Show(boton, boton.Width / 2, boton.Height / 2)
    Else
      mPardetUnidadMedida = mItem.PardetUnidadMedida
      RaiseEvent CambioItem(Me, Nothing)
    End If
    'Cantidad = 1
  End Sub

  Private Sub SeleccionarMenu(ByVal sender As Object, ByVal e As EventArgs)
    mPardetUnidadMedida = CType(sender, ToolStripMenuItem).Tag
    RaiseEvent CambioItem(Me, Nothing)
    Cantidad = 1
  End Sub

  Private mPardetUnidadMedida As WWTSParametroDet = Nothing
  Public ReadOnly Property PardetUnidadMedida() As WWTSParametroDet
    Get
      Return mPardetUnidadMedida
    End Get
  End Property

  Private mCantidad As Integer = 1
  Public Property Cantidad() As Integer
    Get
      Return mCantidad
    End Get
    Set(ByVal value As Integer)
      mCantidad = value
      Me.lblcantidad.Text = mCantidad
    End Set
  End Property

  Private Sub picmas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picmas.Click
    Cantidad += 1
  End Sub

  Private Sub picmenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picmenos.Click
    If Cantidad > 1 Then
      Cantidad -= 1
    End If
  End Sub

  Private Sub lblcantidad_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblcantidad.DoubleClick
    Cantidad = 1
  End Sub
End Class
