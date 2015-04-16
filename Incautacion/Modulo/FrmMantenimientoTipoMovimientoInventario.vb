Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General 
'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmMantenimientoTipoMovimientoInventario
#Region "IOpcion"
  Private mSucursal As Sucursal = Nothing
  Public Property Sucursal() As Sucursal
    Get
      Return mSucursal
    End Get
    Set(ByVal value As Sucursal)
      mSucursal = value
      MyBase.Tabla = "Secuenciales"
      If value IsNot Nothing Then
        Me.cbotipomovimiento.OperadorDatos = value.OperadorDatos
        Me.cbotipomovimiento.Parametro = Enumerados.EnumParametros.TipoMovInventario
        Me.cbotipomovimiento.Llenar_Datos()
      End If
    End Set
  End Property
#End Region

#Region "Parametros"
  Public Property TipoMovimientoInventarios() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mTipoMovimientoInventario As TipoMovimientoInventario = Nothing
  Public Property TipoMovimientoInventario() As TipoMovimientoInventario
    Get
      Return mTipoMovimientoInventario
    End Get
    Set(ByVal value As TipoMovimientoInventario)
      mTipoMovimientoInventario = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _TipoMovimientoInventarios As New TipoMovimientoInventarioList
        _TipoMovimientoInventarios.Add(mTipoMovimientoInventario)
        MyBase.BindingSource1.DataSource = GetType(TipoMovimientoInventario)
        MyBase.BindingSource1.DataSource = _TipoMovimientoInventarios
      End If
    End Set
  End Property

  Sub llenar_datos()
    If mSucursal Is Nothing Then
      Exit Sub
    End If

    mTipoMovimientoInventario = TipoMovimientoInventarios.Current
    ValidarRegistro()
    Me.cbotipomovimiento.ParametroDet = mTipoMovimientoInventario.PardetTipoMovInv
    Me.txtnumero.Value = mTipoMovimientoInventario.Tipmov_Secuencia
    Me.chkseguirsecuencia.Checked = mTipoMovimientoInventario.Tipmov_Seguirsecuencia
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoTipoMovimientoInventario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mTipoMovimientoInventario.EsNuevo
    If _esnuevo AndAlso TipoMovimientoInventarios.Current IsNot Nothing Then
      TipoMovimientoInventarios.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "TipoMovimientoInventarios eventos"
  Private Sub FrmMantenimientoTipoMovimientoInventario_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoTipoMovimientoInventario_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_datos()
    mTipoMovimientoInventario.PardetTipoMovInv = Me.cbotipomovimiento.ParametroDet
    mTipoMovimientoInventario.Tipmov_Secuencia = Me.txtnumero.Value
    mTipoMovimientoInventario.Tipmov_Seguirsecuencia = Me.chkseguirsecuencia.Checked
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_datos()

    Dim _esnuevo As Boolean = mTipoMovimientoInventario.EsNuevo
    If mTipoMovimientoInventario.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mTipoMovimientoInventario.PardetTipoMovInvString)

      Return True
    Else
      'TipoMovimientoInventarios.CancelEdit()
      MsgBox("No se puede guardar Tipo de movimiento" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoTipoMovimientoInventario_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mTipoMovimientoInventario.Eliminar() AndAlso TipoMovimientoInventarios.Current IsNot Nothing Then
      TipoMovimientoInventarios.RemoveCurrent()
      Me.Close()
    Else
      'TipoMovimientoInventarios.CancelEdit()
      MsgBox("No se puede eliminar Tipo de movimiento" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoTipoMovimientoInventario_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTipoMovimientoInventario_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTipoMovimientoInventario_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTipoMovimientoInventario_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.PuedeGuardarnuevo = False
    Me.PuedeGuardar = True
    Me.PuedeGuardarcerrar = True
    Me.PuedeNuevo = False
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _OpcionActual, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.PuedeGuardarnuevo = False
    Me.PuedeGuardar = True
    Me.PuedeGuardarcerrar = True
    Me.PuedeNuevo = False
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub
End Class
