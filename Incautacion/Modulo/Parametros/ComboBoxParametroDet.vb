Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Controles.Base
Imports Incautacion.Reglas
Imports System.ComponentModel
Imports Infoware.Controles.General

<ToolboxItem(True)> _
Public Class ComboBoxParametroDet
  Inherits ComboBoxDB
  Implements IDatos

  Private mOp As OperadorDatos
  Public Property OperadorDatos() As Infoware.Datos.OperadorDatos Implements Infoware.Datos.IDatos.Op
    Get
      Return mOp
    End Get
    Set(ByVal value As Infoware.Datos.OperadorDatos)
      mOp = value
    End Set
  End Property

  Private mParametro As Enumerados.EnumParametros = Enumerados.EnumParametros.TipoEntidad
  Public Property Parametro() As Enumerados.EnumParametros
    Get
      Return mParametro
    End Get
    Set(ByVal value As Enumerados.EnumParametros)
      mParametro = value
    End Set
  End Property

  Public Property ParametroDet() As Incautacion.Reglas.WWTSParametroDet
    Get
      If mParametroDets Is Nothing OrElse MyBase.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mParametroDets(MyBase.SelectedIndex)
      End If
    End Get
    Set(ByVal value As Incautacion.Reglas.WWTSParametroDet)
      If value Is Nothing OrElse mParametroDets Is Nothing Then
        If MyBase.Items.Count > 0 Then
          MyBase.SelectedIndex = 0
        Else
          MyBase.SelectedIndex = -1
        End If
      Else
        MyBase.SelectedValue = value.Pardet_Secuencia
      End If
    End Set
  End Property

  Private mParametroDets As WWTSParametroDetList = Nothing
  Private menumtipoobjeto As Infoware.Reglas.General.ParametroDetList.enumTipoObjeto = WWTSParametroDetList.enumTipoObjeto.Nada
  Private mParametrodetRef As Incautacion.Reglas.WWTSParametroDet = Nothing

  Public Sub Llenar_Datos(Optional ByVal _enumtipoobjeto As Infoware.Reglas.General.ParametroDetList.enumTipoObjeto = WWTSParametroDetList.enumTipoObjeto.Nada, Optional ByVal _ParametrodetRef As Incautacion.Reglas.WWTSParametroDet = Nothing)
    If mOp Is Nothing OrElse Parametro = -1 Then
      Me.Items.Clear()
      Exit Sub
    End If

    menumtipoobjeto = _enumtipoobjeto
    mParametrodetRef = _ParametrodetRef
    mParametroDets = WWTSParametroDetList.ObtenerLista(mOp, mParametro, menumtipoobjeto, mParametrodetRef)

    MyBase.DisplayMember = "Pardet_Descripcion"
    MyBase.ValueMember = "Pardet_Secuencia"
    MyBase.DataSource = mParametroDets
  End Sub

  Private Sub ComboBoxParametroDet_ComandoActualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoActualizar
    Llenar_Datos(menumtipoobjeto, mParametrodetRef)
  End Sub

  Private Sub ComboBoxParametroDet_ComandoEliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoEliminar
    If Not ParametroDet.Parametro.Parame_esImagen And Not String.IsNullOrEmpty(ParametroDet.Parametro.Parame_LeyendaDatoImg1) Then
      Dim f As New FrmParametroDetFile
      f.ParametroDet = ParametroDet
      f.Direccion = IMantenimiento.Accion.Eliminacion
      If f.ShowDialog() = DialogResult.OK Then
        Llenar_Datos(menumtipoobjeto, mParametrodetRef)
      End If
    Else
      Dim f As New FrmParametroDet
      f.enumtipoobjeto = menumtipoobjeto
      f.ParametroDet = ParametroDet
      f.Direccion = IMantenimiento.Accion.Eliminacion
      If f.ShowDialog() = DialogResult.OK Then
        Llenar_Datos(menumtipoobjeto, mParametrodetRef)
      End If
    End If
  End Sub

  Private Sub ComboBoxParametroDet_ComandoModificar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoModificar
    If Not ParametroDet.Parametro.Parame_esImagen And Not String.IsNullOrEmpty(ParametroDet.Parametro.Parame_LeyendaDatoImg1) Then
      Dim f As New FrmParametroDetFile
      f.ParametroDet = ParametroDet
      f.Direccion = IMantenimiento.Accion.Modificacion
      If f.ShowDialog() = DialogResult.OK Then
        Llenar_Datos(menumtipoobjeto, mParametrodetRef)
      End If
    Else
      Dim f As New FrmParametroDet
      f.enumtipoobjeto = menumtipoobjeto
      f.ParametroDet = ParametroDet
      f.Direccion = IMantenimiento.Accion.Modificacion
      If f.ShowDialog() = DialogResult.OK Then
        Llenar_Datos(menumtipoobjeto, mParametrodetRef)
      End If
    End If
  End Sub

  Private Sub ComboBoxParametroDet_ComandoNuevo(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ComandoNuevo
    Dim _param As WWTSParametro
    _param = New WWTSParametro(OperadorDatos, Me.Parametro)

    If Not _param.Parame_esImagen And Not String.IsNullOrEmpty(_param.Parame_LeyendaDatoImg1) Then
      Dim f As New FrmParametroDetFile
      f.ParametroDet = New Incautacion.Reglas.WWTSParametroDet(mOp, Me.Parametro, True)
      f.Direccion = IMantenimiento.Accion.Ingreso
      If f.ShowDialog() = DialogResult.OK Then
        Llenar_Datos(menumtipoobjeto, mParametrodetRef)
      End If
    Else
      Dim f As New FrmParametroDet
      f.enumtipoobjeto = menumtipoobjeto
      f.ParametroDet = New Incautacion.Reglas.WWTSParametroDet(mOp, Me.Parametro, True)
      f.Direccion = IMantenimiento.Accion.Ingreso
      If f.ShowDialog() = DialogResult.OK Then
        Llenar_Datos(menumtipoobjeto, mParametrodetRef)
      End If
    End If
  End Sub

  Private Sub ComboBoxParametroDet_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
    PuedeNuevo = False
    PuedeModificar = False
    PuedeEliminar = False
    If mOp Is Nothing OrElse Me.SelectedIndex = -1 OrElse ParametroDet Is Nothing Then
      Exit Sub
    End If
    Dim _parametrodet As Incautacion.Reglas.WWTSParametroDet = ParametroDet
    Dim _parametro As Incautacion.Reglas.WWTSParametro = _parametrodet.Parametro

    If _parametro.Parame_Modificable Then
      PuedeNuevo = True
      If _parametrodet Is Nothing Then
        PuedeModificar = False
        PuedeEliminar = False
      Else
        PuedeModificar = _parametrodet.Pardet_Modificable
        PuedeEliminar = _parametrodet.Pardet_Modificable
      End If
    End If
  End Sub
End Class
