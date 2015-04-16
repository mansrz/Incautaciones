Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

'Imports WWTS.Inventario.Reglas

Public Class FrmMantenimientoUnidadMedidaConversion
#Region "IOpcion"
  Private mOperadorDatos As OperadorDatos = Nothing
  Public Property OperadorDatos() As OperadorDatos
    Get
      Return mOperadorDatos
    End Get
    Set(ByVal value As OperadorDatos)
      mOperadorDatos = value
      MyBase.Tabla = "Unidad medida conversión"
      If value IsNot Nothing Then
        Me.ComboBoxParametroDet1.OperadorDatos = value
        Me.ComboBoxParametroDet1.Parametro = Enumerados.EnumParametros.UnidadMedida
        Me.ComboBoxParametroDet1.Llenar_Datos()

        Me.ComboBoxParametroDet2.OperadorDatos = value
        Me.ComboBoxParametroDet2.Parametro = Enumerados.EnumParametros.UnidadMedida
        Me.ComboBoxParametroDet2.Llenar_Datos()
      End If
    End Set
  End Property
#End Region

#Region "Parametros"
  Public Property UnidadMedidaConversiones() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mUnidadMedidaConversion As UnidadMedidaConversion = Nothing
  Public Property UnidadMedidaConversion() As UnidadMedidaConversion
    Get
      Return mUnidadMedidaConversion
    End Get
    Set(ByVal value As UnidadMedidaConversion)
      mUnidadMedidaConversion = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _UnidadMedidaConversiones As New UnidadMedidaConversionList
        _UnidadMedidaConversiones.Add(mUnidadMedidaConversion)
        MyBase.BindingSource1.DataSource = GetType(UnidadMedidaConversion)
        MyBase.BindingSource1.DataSource = _UnidadMedidaConversiones
      End If
    End Set
  End Property

  Sub llenar_datos()
    If mOperadorDatos Is Nothing Then
      Exit Sub
    End If

    mUnidadMedidaConversion = UnidadMedidaConversiones.Current
    ValidarRegistro()
    Me.ComboBoxParametroDet1.ParametroDet = mUnidadMedidaConversion.PardetUnidadMedidaFte
    Me.ComboBoxParametroDet2.ParametroDet = mUnidadMedidaConversion.PardetUnidadMedidaDsno
    Me.txtfactor.Value = mUnidadMedidaConversion.Unmeco_Factor
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoUnidadMedidaConversion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mUnidadMedidaConversion.EsNuevo
    If _esnuevo AndAlso UnidadMedidaConversiones.Current IsNot Nothing Then
      UnidadMedidaConversiones.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "UnidadMedidaConversiones eventos"
  Private Sub FrmMantenimientoUnidadMedidaConversion_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _UnidadMedidaConversion As UnidadMedidaConversion = New UnidadMedidaConversion(Me.ComboBoxParametroDet1.ParametroDet, True)
    e.NewObject = _UnidadMedidaConversion
  End Sub

  Private Sub FrmMantenimientoUnidadMedidaConversion_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoUnidadMedidaConversion_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    mUnidadMedidaConversion.PardetUnidadMedidaFte = Me.ComboBoxParametroDet1.ParametroDet
    mUnidadMedidaConversion.PardetUnidadMedidaDsno = Me.ComboBoxParametroDet2.ParametroDet
    mUnidadMedidaConversion.Unmeco_Factor = Me.txtfactor.Value
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_datos()

    Dim _esnuevo As Boolean = mUnidadMedidaConversion.EsNuevo
    If mUnidadMedidaConversion.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mUnidadMedidaConversion.Descripcion)

      Return True
    Else
      'UnidadMedidaConversiones.CancelEdit()
      MsgBox("No se puede guardar Unidad Medida Conversión" & Environment.NewLine & mOperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoUnidadMedidaConversion_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mUnidadMedidaConversion.Eliminar() AndAlso UnidadMedidaConversiones.Current IsNot Nothing Then
      UnidadMedidaConversiones.RemoveCurrent()
      Me.Close()
    Else
      'UnidadMedidaConversiones.CancelEdit()
      MsgBox("No se puede eliminar Unidad Medida Conversión" & Environment.NewLine & mOperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoUnidadMedidaConversion_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoUnidadMedidaConversion_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoUnidadMedidaConversion_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoUnidadMedidaConversion_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Forma_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _OpcionActual, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Forma_Inicializar(Me, Nothing)
  End Sub
#End Region

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.PuedeGuardarnuevo = False
    Me.PuedeGuardar = True
    Me.PuedeGuardarcerrar = True
    Me.PuedeNuevo = False
  End Sub

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub
End Class
