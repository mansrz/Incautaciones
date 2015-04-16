Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

'Imports WWTS.Inventario.Reglas

Public Class FrmMantenimientoTrabajoImprenta
  '#Region "IOpcion"
  '  Private mSucursal As Sucursal = Nothing
  '  Public Property Sucursal() As Sucursal
  '    Get
  '      Return mSucursal
  '    End Get
  '    Set(ByVal value As Sucursal)
  '      mSucursal = value
  '      MyBase.Tabla = "Trabajo"


  '      'Me.CtlBuscaCliente1.OperadorDatos = value.OperadorDatos
  '      'Me.CtlBuscaCliente1.Llenar_Datos()

  '      'Me.cboTipoTrabajo.OperadorDatos = value.OperadorDatos
  '      'Me.cboTipoTrabajo.Parametro = Enumerados.EnumParametros.TipotrabajoSobre
  '      'Me.cboTipoTrabajo.Llenar_Datos()
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

  Private mTrabajoxMovimientoInventarioProforma As TrabajoxMovimientoInventario = Nothing
  Public ReadOnly Property TrabajoxMovimientoInventarioProforma As TrabajoxMovimientoInventario
    Get
      If mTrabajoxMovimientoInventarioProforma Is Nothing AndAlso mTrabajo IsNot Nothing Then
        Dim mTrabajoxMovimientoInventarios As TrabajoxMovimientoInventarioList
        mTrabajoxMovimientoInventarios = mTrabajo.Proformas

        If mTrabajoxMovimientoInventarios Is Nothing OrElse mTrabajoxMovimientoInventarios.Count = 0 Then
          Dim mmovimientoinventario As MovimientoInventario
          mmovimientoinventario = New MovimientoInventario(mSucursal, Enumerados.enumTipoMovInv.Venta, True)
          mmovimientoinventario.Venta.Pardet_TipoVentaEnum = Enumerados.enumTipoVenta.Proforma
          mmovimientoinventario.Venta.Cliente = mTrabajo.Cliente
          mTrabajoxMovimientoInventarioProforma = New TrabajoxMovimientoInventario(mTrabajo, True)
          mTrabajoxMovimientoInventarioProforma.MovimientoInventario = mmovimientoinventario
        Else
          mTrabajoxMovimientoInventarioProforma = mTrabajoxMovimientoInventarios(0)
        End If
      End If
      Return mTrabajoxMovimientoInventarioProforma
    End Get
  End Property

  Sub llenar_datos()
    If Sistema Is Nothing Then
      Exit Sub
    End If

    mTrabajo = Trabajos.Current
    ValidarRegistro()
    If mTrabajo IsNot Nothing Then
      Dim _Usuario As New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)

      Me.lbltrabajo.Text = String.Format("# {0} - {1}, {2}  {3}", mTrabajo.Trabaj_Secuencia.ToString, mTrabajo.PardetTipoTrabajoString, mTrabajo.ClienteString, mTrabajo.Trabaj_Observacion)

      If mTrabajo.UltimoTrabajoLog IsNot Nothing Then
        'If mTrabajo.UltimoTrabajoLog.Pardet_AccionTrabajo = Enumerados.enumEstadoSobre.TomadoporEditores AndAlso Not mTrabajo.UltimoTrabajoLog.Entida_Empleado = _Usuario.Entida_Empleado Then
        '  MsgBox("El trabajo originalmente fue tomado por otro diseñador, no puede continuar", MsgBoxStyle.Critical, "Error")
        '  Me.TabControl1.Enabled = False
        'End If
        If Not mTrabajo.UltimoTrabajoLog.Pardet_AccionTrabajo = Enumerados.enumEstadoSobre.TomadoQuirofano Then
          Dim _trabajolog As New TrabajoLog(mTrabajo, True)
          _trabajolog.PardetAccionTrabajo = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoSobre, Enumerados.enumEstadoSobre.TomadoQuirofano)

          _trabajolog.Empleado = _Usuario.Empleado
          _trabajolog.Guardar()
        End If


        mTrabajoxMovimientoInventarioProforma = Nothing
        Me.CtlMovimientoInventarioDet1.MovimientoInventario = TrabajoxMovimientoInventarioProforma.MovimientoInventario

        Dim mTrabajoxMovimientoInventarios As TrabajoxMovimientoInventarioList
        mTrabajoxMovimientoInventarios = mTrabajo.OrdenesProduccion

        Me.TabControlMovimientos.TabPages.Clear()

        For Each _trabajoxmovimientoinventario As TrabajoxMovimientoInventario In mTrabajoxMovimientoInventarios
          AgregarPagina(_trabajoxmovimientoinventario)
        Next

        If mTrabajoxMovimientoInventarios.Count = 0 Then
          Dim mmovimientoinventario As MovimientoInventario
          mmovimientoinventario = New MovimientoInventario(mSucursal, Enumerados.enumTipoMovInv.OrdenProduccion, True)

          Dim mTrabajoxMovimientoInventario As New TrabajoxMovimientoInventario(mTrabajo, True)
          mTrabajoxMovimientoInventario.MovimientoInventario = mmovimientoinventario

          AgregarPagina(mTrabajoxMovimientoInventario)
        End If
        'Dim mmovimientoinventario As MovimientoInventario
        'mmovimientoinventario = New MovimientoInventario(mSucursal, Enumerados.enumTipoMovInv.OrdenProduccion, True)
        ''mmovimientoinventario.Venta.Pardet_TipoVentaEnum = Enumerados.enumTipoVenta.Proforma
        ''mmovimientoinventario.Venta.Cliente = mTrabajo.Cliente
        'Me.CtlMovimientoInventario1.MovimientoInventario = mmovimientoinventario
      End If
      'Me.txtnumerosobre.Value = mTrabajo.Trabaj_Secuencia
      'Me.CtlBuscaCliente1.Cliente = mTrabajo.Cliente
      'Me.cboTipoTrabajo.ParametroDet = mTrabajo.PardetTipoTrabajo
      'Me.txtobservacion.Text = mTrabajo.Trabaj_Observacion
      Me.CtlTrabajoLog1.Trabajo = mTrabajo
    End If
  End Sub

  Sub AgregarPagina(ByVal _TrabajoxMovimientoInventario As TrabajoxMovimientoInventario)
    Dim _tab As New TabPage
    Me.TabControlMovimientos.TabPages.Add(_tab)
    Dim _ctlmovinv As New CtlMovimientoInventario
    _ctlmovinv.Sistema = Sistema
    _ctlmovinv.VerConfidencial = Restriccion.Restri_VerConfidencial
    _ctlmovinv.Sucursal = mSucursal
    _ctlmovinv.PardetTipoInventario = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoInventario, Enumerados.EnumTipoInventario.Produccion)
    _ctlmovinv.MovimientoInventario = _TrabajoxMovimientoInventario.MovimientoInventario
    _tab.Controls.Add(_ctlmovinv)
    _ctlmovinv.Dock = DockStyle.Fill

    _tab.Text = String.Format("{0} - {1}", _TrabajoxMovimientoInventario.MovimientoInventario.PardetTipoMovInv.Pardet_DatoStr1, IIf(_TrabajoxMovimientoInventario.EsNuevo, "*", _TrabajoxMovimientoInventario.Movinv_Secuencia))

    _tab.Tag = _TrabajoxMovimientoInventario
    _ctlmovinv.PuedeCancelar = True
    AddHandler _ctlmovinv.Cancelar, AddressOf CancelarPagina
  End Sub

  Sub CancelarPagina(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Me.TabControlMovimientos.TabPages.Remove(CType(sender, CtlMovimientoInventario).Parent)
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoTrabajoImprenta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
  Private Sub FrmMantenimientoTrabajoImprenta_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Trabajo As Trabajo = New Trabajo(mSucursal, True)
    e.NewObject = _Trabajo
  End Sub

  Private Sub FrmMantenimientoTrabajoImprenta_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoTrabajoImprenta_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Function Guardar_datos() As Boolean
    Try
      Dim _Usuario As New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)

      Dim _esnuevo As Boolean = mTrabajo.EsNuevo
      If guardarpaginas() Then
        Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mTrabajo.Descripcion)

        Dim _trabajolog As New TrabajoLog(mTrabajo, True)
        _trabajolog.PardetAccionTrabajo = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoSobre, Enumerados.enumEstadoSobre.LiberadoImprenta)

        _trabajolog.Empleado = _Usuario.Empleado
        _trabajolog.Guardar()

        Return True
      Else
        Throw New Exception("No se puede guardar trabajo")
      End If
    Catch ex As Exception
      MsgBox(ex.Message & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End Try
  End Function

  Function guardarpaginas() As Boolean
    If Me.TabControlMovimientos.TabPages.Count = 0 Then
      Return True
    End If
    Dim result As Boolean = False
    Sistema.OperadorDatos.ComenzarTransaccion()
    For Each _page As TabPage In Me.TabControlMovimientos.TabPages
      Dim _TrabajoxMovimientoInventario As TrabajoxMovimientoInventario = CType(_page.Tag, TrabajoxMovimientoInventario)
      CType(_page.Controls(0), CtlMovimientoInventario).mapear_datos()
      _TrabajoxMovimientoInventario.MovimientoInventario = CType(_page.Controls(0), CtlMovimientoInventario).MovimientoInventario
      result = _TrabajoxMovimientoInventario.Guardar(True) 'todo
      If Not result Then
        Exit For
      End If
    Next
    If result Then
      Sistema.OperadorDatos.TerminarTransaccion()
      For Each _page As TabPage In Me.TabControlMovimientos.TabPages
        Dim _TrabajoxMovimientoInventario As TrabajoxMovimientoInventario = CType(_page.Tag, TrabajoxMovimientoInventario)
        _TrabajoxMovimientoInventario.AceptarCambios()
      Next
    Else
      Sistema.OperadorDatos.CancelarTransaccion()
    End If
    Return result
  End Function

  Private Sub FrmMantenimientoTrabajoImprenta_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
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
  Private Sub FrmMantenimientoTrabajoImprenta_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTrabajoImprenta_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTrabajoImprenta_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTrabajoImprenta_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
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

    ComboBoxTipoMovimiento.OperadorDatos = Sistema.OperadorDatos
    ComboBoxTipoMovimiento.Parametro = Enumerados.EnumParametros.TipoMovInventario
    ComboBoxTipoMovimiento.Llenar_Datos(ParametroDetList.enumTipoObjeto.Nada, New WWTSParametroDet(Sistema.OperadorDatos, 439, 2)) 'tipos de movimiento produccion

    ToolStripManager.Merge(Me.ToolStripMovimiento, Me.ToolStrip1)
    Me.ToolStripMovimiento.Visible = False

  End Sub

  Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    If mTrabajo Is Nothing Then
      Exit Sub
    End If
    Dim _txttiempo As String = ""
    Dim _tiempo As Integer = mTrabajo.MinutosenEspera
    If _tiempo >= 60 Then
      _txttiempo = String.Format("{0} horas", Math.Floor(_tiempo / 60))
      _tiempo -= Math.Floor(_tiempo / 60) * 60
    End If
    _txttiempo = String.Format("{0} {1} minutos", _txttiempo, _tiempo)
    Me.txttiempo.Text = _txttiempo
  End Sub

  Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    Dim mmovimientoinventario As MovimientoInventario
    mmovimientoinventario = New MovimientoInventario(mSucursal, CType(Me.ComboBoxTipoMovimiento.ParametroDet.Pardet_Secuencia, Enumerados.enumTipoMovInv), True)
    Dim mTrabajoxMovimientoInventario As New TrabajoxMovimientoInventario(mTrabajo, True)
    mTrabajoxMovimientoInventario.MovimientoInventario = mmovimientoinventario
    AgregarPagina(mTrabajoxMovimientoInventario)
  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    If mTrabajo.EsNuevo Then
      Me.Close()
      Exit Sub
    End If

    Dim _trabajolog As New TrabajoLog(mTrabajo, True)
    _trabajolog.PardetAccionTrabajo = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoSobre, Enumerados.enumEstadoSobre.RechazadoImprenta)

    Dim _Usuario As New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)
    _trabajolog.Empleado = _Usuario.Empleado
    If _trabajolog.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, "Devolvió trabajo a Diseñador")
      Me.Close()
    End If
  End Sub
End Class
