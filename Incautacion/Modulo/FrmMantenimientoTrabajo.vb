Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

'Imports WWTS.Inventario.Reglas

Public Class FrmMantenimientoTrabajo
  '#Region "IOpcion"
  '  Private mSucursal As Sucursal = Nothing
  '  Public Property Sucursal() As Sucursal
  '    Get
  '      Return mSucursal
  '    End Get
  '    Set(ByVal value As Sucursal)
  '      mSucursal = value

  '    End Set
  '  End Property
  '#End Region

#Region "Parametros"
  Public Property Trabajos() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mTrabajo As Trabajo = Nothing
  Public Property Trabajo() As Trabajo
    Get
      Return mTrabajo
    End Get
    Set(ByVal value As Trabajo)
      mTrabajo = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _Trabajos As New TrabajoList
        _Trabajos.Add(mTrabajo)
        MyBase.BindingSource1.DataSource = GetType(Trabajo)
        MyBase.BindingSource1.DataSource = _Trabajos
      End If
    End Set
  End Property

  Sub llenar_datos()
    If mSucursal Is Nothing Then
      Exit Sub
    End If

    mTrabajo = Trabajos.Current
    ValidarRegistro()
    If mTrabajo IsNot Nothing Then
      Me.txtnumerosobre.Value = mTrabajo.Trabaj_Secuencia
      Me.CtlBuscaCliente1.Cliente = mTrabajo.Cliente
      Me.cboTipoTrabajo.ParametroDet = mTrabajo.PardetTipoTrabajo
      Me.txtobservacion.Text = mTrabajo.Trabaj_Observacion

      Me.CtlTrabajoLog1.Trabajo = mTrabajo

      If Not Restriccion.Restri_VerConfidencial And Not mTrabajo.EsNuevo Then
        Me.CtlBuscaCliente1.Enabled = False
      End If

      btnreenviar.Visible = Not mTrabajo.EsNuevo
      Me.CtlBloqueo1.Restriccion = Restriccion
    End If
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoTrabajo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mTrabajo.EsNuevo
    If _esnuevo AndAlso Trabajos.Current IsNot Nothing Then
      Trabajos.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Trabajos eventos"
  Private Sub FrmMantenimientoTrabajo_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Trabajo As Trabajo = New Trabajo(mSucursal, True)
    e.NewObject = _Trabajo
  End Sub

  Private Sub FrmMantenimientoTrabajo_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoTrabajo_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Function Guardar_datos() As Boolean
    mTrabajo.Cliente = Me.CtlBuscaCliente1.Cliente
    mTrabajo.PardetTipoTrabajo = Me.cboTipoTrabajo.ParametroDet
    mTrabajo.Trabaj_Observacion = Me.txtobservacion.Text

    Dim _Usuario As New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)
    If _Usuario.Empleado Is Nothing Then
      MsgBox("No hay un empleado asociado a su usuario", vbCritical, "Error")
      Return False
    End If

    Dim _esnuevo As Boolean = mTrabajo.EsNuevo
    If mTrabajo.Guardar(_Usuario.Empleado, CtlBloqueo1.Bloqueado) Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mTrabajo.Descripcion)

      Return True
    Else
      'Trabajos.CancelEdit()
      MsgBox("No se puede guardar Trabajo" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoTrabajo_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mTrabajo.Eliminar() AndAlso Trabajos.Current IsNot Nothing Then
      Trabajos.RemoveCurrent()
      Me.Close()
    Else
      'Trabajos.CancelEdit()
      MsgBox("No se puede eliminar Trabajo" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoTrabajo_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTrabajo_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTrabajo_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTrabajo_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Private mSucursal As Sucursal = Nothing

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Sucursal As Sucursal, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    mSucursal = _Sucursal
    ' Add any initialization after the InitializeComponent() call.
    Forma_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _Sucursal As Sucursal, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
       Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _Sucursal, _OpcionNuevo)
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.PuedeGuardarnuevo = False
    Me.PuedeGuardar = True
    Me.PuedeGuardarcerrar = True
    Me.PuedeNuevo = False

    MyBase.Tabla = "Trabajo"
    Me.CtlBuscaCliente1.OperadorDatos = Sistema.OperadorDatos
    Me.CtlBuscaCliente1.Llenar_Datos()

    Me.cboTipoTrabajo.OperadorDatos = Sistema.OperadorDatos
    Me.cboTipoTrabajo.Parametro = Enumerados.EnumParametros.TipotrabajoSobre
    Me.cboTipoTrabajo.Llenar_Datos()

    ToolStripManager.Merge(Me.ToolStripMovimiento, Me.ToolStrip1)
    Me.ToolStripMovimiento.Visible = False
  End Sub

  Private Sub lnkEstadoCuenta_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkEstadoCuenta.LinkClicked
    If Me.CtlBuscaCliente1.Cliente Is Nothing Then
      Exit Sub
    End If
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.AnalisisCartera)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "rep_Estado_de_cuenta_cliente")
    f.Valores = New Object() {mSucursal.Empres_Codigo, mSucursal.Sucurs_Codigo, Me.CtlBuscaCliente1.Cliente.Entida_Codigo}
    'f.objAbrirElemento = New Infoware.Reporteador.FrmLista.AbrirElemento(AddressOf AbrirElemento)
    f.ShowDialog()
  End Sub

  Private Sub CtlBloqueo1_Desbloquear(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBloqueo1.Desbloquear
    Me.CtlBuscaCliente1.Enabled = Not Me.CtlBloqueo1.Bloqueado
  End Sub

  Private Sub CtlBloqueo1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlBloqueo1.Load

  End Sub

  Private Sub btnFactura_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFactura.Click
    If Me.CtlBuscaCliente1.Cliente Is Nothing Then
      Exit Sub
    End If

    If Trabajo.EsNuevo Then
      If MsgBox("¿Desea guardar el sobre primero?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
        If Not Guardar_datos() Then
          Exit Sub
        End If
      Else
        Exit Sub
      End If
    End If

    Dim f As New FrmMantenimientoTrabajoFacturacion(Sistema, Restriccion, mSucursal, Enumerados.EnumOpciones.AperturaSobre)
    f.Trabajos = Trabajos
    f.ShowDialog()
    f.Dispose()
  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    If mTrabajo.EsNuevo Then
      Me.Close()
      Exit Sub
    End If

    Dim _trabajolog As New TrabajoLog(mTrabajo, True)
    _trabajolog.PardetAccionTrabajo = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoSobre, Enumerados.enumEstadoSobre.SobreRechazado)

    Dim _Usuario As New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)
    _trabajolog.Empleado = _Usuario.Empleado
    If _trabajolog.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, "Canceló trabajo")
      Me.Close()
    End If
  End Sub

  Private Sub btnreenviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreenviar.Click
    If mTrabajo.EsNuevo Then
      Me.Close()
      Exit Sub
    End If

    Dim _trabajolog As New TrabajoLog(mTrabajo, True)
    _trabajolog.PardetAccionTrabajo = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoSobre, Enumerados.enumEstadoSobre.CasoAperturado)

    Dim _Usuario As New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)
    _trabajolog.Empleado = _Usuario.Empleado
    If _trabajolog.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, "Reenvió trabajo")
      Me.Close()
    End If
  End Sub
End Class
