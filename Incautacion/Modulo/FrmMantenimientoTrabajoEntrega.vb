Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

'Imports WWTS.Inventario.Reglas

Public Class FrmMantenimientoTrabajoEntrega
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

          Dim _Usuario As New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)

          mmovimientoinventario.Venta.Empleado = _Usuario.Empleado
          mTrabajoxMovimientoInventarioProforma = New TrabajoxMovimientoInventario(mTrabajo, True)
          mTrabajoxMovimientoInventarioProforma.MovimientoInventario = mmovimientoinventario
        Else
          mTrabajoxMovimientoInventarioProforma = mTrabajoxMovimientoInventarios(0)
        End If
      End If
      Return mTrabajoxMovimientoInventarioProforma
    End Get
  End Property

  Private mTrabajoxMovimientoInventarioVenta As TrabajoxMovimientoInventario = Nothing
  Public ReadOnly Property TrabajoxMovimientoInventarioVenta As TrabajoxMovimientoInventario
    Get
      If mTrabajoxMovimientoInventarioVenta Is Nothing AndAlso mTrabajo IsNot Nothing Then
        Dim mTrabajoxMovimientoInventarios As TrabajoxMovimientoInventarioList
        mTrabajoxMovimientoInventarios = mTrabajo.Facturas

        If mTrabajoxMovimientoInventarios Is Nothing OrElse mTrabajoxMovimientoInventarios.Count = 0 Then
          Dim mmovimientoinventario As MovimientoInventario
          mmovimientoinventario = New MovimientoInventario(mSucursal, Enumerados.enumTipoMovInv.Venta, True)
          mmovimientoinventario.Venta.Pardet_TipoVentaEnum = Enumerados.enumTipoVenta.Factura
          mmovimientoinventario.Venta.Cliente = mTrabajo.Cliente

          Dim _Usuario As New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)

          mmovimientoinventario.Venta.Empleado = _Usuario.Empleado

          mTrabajoxMovimientoInventarioProforma = Nothing
          If TrabajoxMovimientoInventarioProforma IsNot Nothing Then
            mmovimientoinventario.Detalles.Clear()
            For Each _movdet As MovimientoInventarioDet In TrabajoxMovimientoInventarioProforma.MovimientoInventario.Detalles
              _movdet.EsNuevo = True
              _movdet.MovimientoInventario = mmovimientoinventario
              ' _movdet.Bloqueado=True
              mmovimientoinventario.Detalles.Add(_movdet)
            Next
          End If

          mTrabajoxMovimientoInventarioVenta = New TrabajoxMovimientoInventario(mTrabajo, True)
          mTrabajoxMovimientoInventarioVenta.MovimientoInventario = mmovimientoinventario
        Else
          mTrabajoxMovimientoInventarioVenta = mTrabajoxMovimientoInventarios(0)
        End If
      End If
      Return mTrabajoxMovimientoInventarioVenta
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
        If Not mTrabajo.UltimoTrabajoLog.Pardet_AccionTrabajo = Enumerados.enumEstadoSobre.TomadoCierre Then
          Dim _trabajolog As New TrabajoLog(mTrabajo, True)
          _trabajolog.PardetAccionTrabajo = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoSobre, Enumerados.enumEstadoSobre.TomadoCierre)

          _trabajolog.Empleado = _Usuario.Empleado
          _trabajolog.Guardar()
        End If

        Me.CtlMovimientoInventario1.PardetTipoInventario = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoInventario, Enumerados.EnumTipoInventario.Facturable)
        Me.CtlMovimientoInventario1.Sistema = Sistema
        Me.CtlMovimientoInventario1.VerConfidencial = False
        Me.CtlMovimientoInventario1.Sucursal = mSucursal
        Me.CtlMovimientoInventario1.MovimientoInventario = TrabajoxMovimientoInventarioVenta.MovimientoInventario
      End If
      'Me.txtnumerosobre.Value = mTrabajo.Trabaj_Secuencia
      'Me.CtlBuscaCliente1.Cliente = mTrabajo.Cliente
      'Me.cboTipoTrabajo.ParametroDet = mTrabajo.PardetTipoTrabajo
      'Me.txtobservacion.Text = mTrabajo.Trabaj_Observacion
      Me.CtlTrabajoLog1.Trabajo = mTrabajo
      Me.CtlBloqueo1.Restriccion = Restriccion

      Dim mTrabajoxMovimientoInventarios As TrabajoxMovimientoInventarioList
      mTrabajoxMovimientoInventarios = mTrabajo.OrdenesProduccion

      Me.TabControlMovimientos.TabPages.Clear()

      For Each _trabajoxmovimientoinventario As TrabajoxMovimientoInventario In mTrabajoxMovimientoInventarios
        AgregarPagina(_trabajoxmovimientoinventario)
      Next
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
    _ctlmovinv.PuedeCancelar = False
    'AddHandler _ctlmovinv.Cancelar, AddressOf CancelarPagina
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoTrabajoEntrega_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
  Private Sub FrmMantenimientoTrabajoEntrega_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Trabajo As Trabajo = New Trabajo(mSucursal, True)
    e.NewObject = _Trabajo
  End Sub

  Private Sub FrmMantenimientoTrabajoEntrega_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoTrabajoEntrega_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    Dim _Deudas As PagosDetList = PagosDetList.ObtenerListaPendientes(mSucursal, Trabajo.Cliente.Entidad, Enumerados.enumTipoCuenta.cxc)
    Dim _valordeuda As Decimal = 0
    For Each _deuda As PagosDet In _Deudas
      _valordeuda += _deuda.Pendiente
    Next

    If _valordeuda > 0 Then
      If MsgBox("El cliente tiene un saldo deudor, ¿Desea imprimir el estado de cuenta del cliente?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
        Do While True
          ImprimirEstadoCuentaCliente()
          If MsgBox("¿El estado de cuenta fue impreso correctamente?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
            Exit Do
          End If
        Loop
      Else
        e.Cancel = True
        Exit Sub
      End If
    End If
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Function Guardar_datos() As Boolean
    Try
      Me.CtlMovimientoInventario1.mapear_datos()

      Dim _Usuario As New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)

      TrabajoxMovimientoInventarioVenta.Trabajo = mTrabajo
      TrabajoxMovimientoInventarioVenta.MovimientoInventario = Me.CtlMovimientoInventario1.MovimientoInventario

      Dim _esnuevo As Boolean = mTrabajo.EsNuevo
      If mTrabajoxMovimientoInventarioVenta.Guardar(Me.CtlBloqueo1.Bloqueado) Then
        Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mTrabajo.Descripcion)

        Dim _trabajolog As New TrabajoLog(mTrabajo, True)
        _trabajolog.PardetAccionTrabajo = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoSobre, Enumerados.enumEstadoSobre.LiberadoEntrega)

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

  Private Sub FrmMantenimientoTrabajoEntrega_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
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
  Private Sub FrmMantenimientoTrabajoEntrega_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTrabajoEntrega_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTrabajoEntrega_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTrabajoEntrega_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
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

  Private Sub CtlBloqueo1_Desbloquear(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtlBloqueo1.Desbloquear
    Me.CtlMovimientoInventario1.VerConfidencial = Not Me.CtlBloqueo1.Bloqueado
  End Sub

  Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
    If Guardar_datos() Then
      Me.CtlMovimientoInventario1.Imprimir()
    End If
  End Sub

  Private Sub btnformato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnformato.Click
    If Guardar_datos() Then
      Me.CtlMovimientoInventario1.ModificarFormato()
    End If
  End Sub

  Private Sub btnpagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpagos.Click
    If Not TrabajoxMovimientoInventarioVenta.EsNuevo OrElse (MsgBox("Antes de continuar se debe guardar la factura, ¿Desea continuar?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes AndAlso Guardar_datos()) Then
      Dim f As New FrmMantenimientoPagos(Sistema, Enumerados.EnumOpciones.Cuentas, mSucursal)
      f.MovimientoInventario = Me.CtlMovimientoInventario1.MovimientoInventario
      f.ShowDialog()
    End If
  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    If mTrabajo.EsNuevo Then
      Me.Close()
      Exit Sub
    End If

    Dim _trabajolog As New TrabajoLog(mTrabajo, True)
    _trabajolog.PardetAccionTrabajo = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoSobre, Enumerados.enumEstadoSobre.RechazadoEntrega)

    Dim _Usuario As New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)
    _trabajolog.Empleado = _Usuario.Empleado
    If _trabajolog.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, Enumerados.enumTipoAccion.Modificacion, "Devolvió trabajo a Facturación")
      Me.Close()
    End If
  End Sub

  Private Sub CtlBloqueo1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtlBloqueo1.Load

  End Sub

  Private Sub btnimprEstadoCta_Click(sender As System.Object, e As System.EventArgs)

  End Sub

  Private Sub btnestadocuenta_ButtonClick(sender As System.Object, e As System.EventArgs) Handles btnestadocuenta.ButtonClick
    Me.CtlMovimientoInventario1.mapear_datos()
    If Me.CtlMovimientoInventario1.MovimientoInventario.ClienteProveedor Is Nothing Then
      Exit Sub
    End If
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.AnalisisCartera)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "rep_Estado_de_cuenta_cliente")
    f.Valores = New Object() {mSucursal.Empres_Codigo, mSucursal.Sucurs_Codigo, Me.CtlMovimientoInventario1.MovimientoInventario.ClienteProveedor.Entida_Codigo}
    'f.objAbrirElemento = New Infoware.Reporteador.FrmLista.AbrirElemento(AddressOf AbrirElemento)
    f.ShowDialog()
  End Sub

  Private Sub ImprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
    imprimirEstadoCuentaCliente()
    MsgBox("Impresión enviada, por favor verifique que se haya realizado correctamente", MsgBoxStyle.Information, "Información")
  End Sub

  Private Sub ImprimirEstadoCuentaCliente()
    Dim _Deudas As PagosDetList = PagosDetList.ObtenerListaPendientes(mSucursal, Trabajo.Cliente.Entidad, Enumerados.enumTipoCuenta.cxc)
    Dim _totaldeudas As Decimal = 0
    For Each _deuda As PagosDet In _Deudas
      _totaldeudas += _deuda.Pendiente
    Next
    Trabajo.Cliente.TotalDeudas = _totaldeudas

    Dim f As New Infoware.Reportes.FrmReportSimple
    f.ArchivoReporte = ArchivoFormato()
    f.Cabecera = Trabajo.Cliente
    f.Detalles = _Deudas
    f.Imprimir()
  End Sub

  Private Sub ModificarFormatoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarFormatoToolStripMenuItem.Click
    Dim _Deudas As PagosDetList = PagosDetList.ObtenerListaPendientes(mSucursal, Trabajo.Cliente.Entidad, Enumerados.enumTipoCuenta.cxc)
    Dim _totaldeudas As Decimal = 0
    For Each _deuda As PagosDet In _Deudas
      _totaldeudas += _deuda.Pendiente
    Next
    Trabajo.Cliente.TotalDeudas = _totaldeudas

    Dim f As New Infoware.Reportes.FrmReportSimple
    f.ArchivoReporte = ArchivoFormato()
    f.Cabecera = Trabajo.Cliente
    f.Detalles = _Deudas
    f.ShowDialog()
  End Sub

  Private Function ArchivoFormato() As String
    Return Me.Sistema.DirectorioRaiz & "\Formatos\EstadoCuentaCliente.rps"
  End Function
End Class
