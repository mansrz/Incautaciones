Imports Infoware.Datos
Imports Infoware.Reglas.General
'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmListaTrabajos
  Private mSucursal As Sucursal = Nothing
  Public Property Sucursal() As Sucursal
    Get
      Return mSucursal
    End Get
    Set(ByVal value As Sucursal)
      mSucursal = value
      Llenar_datos()
    End Set
  End Property

  Enum enumTipoPresentacion
    AperturaCaso
    ProformarCaso
    Quirofano
    FacturarCaso
    CierreCaso
  End Enum

  Private mTipoPresentacion As enumTipoPresentacion = enumTipoPresentacion.AperturaCaso
  Public Property TipoPresentacion As enumTipoPresentacion
    Get
      Return mTipoPresentacion
    End Get
    Set(ByVal value As enumTipoPresentacion)
      mTipoPresentacion = value
    End Set
  End Property

  Private mTrabajo As Trabajo = Nothing
  Public Property Trabajo() As Trabajo
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As Trabajo)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _Trabajo As Trabajo In Me.ListBindingSource.DataSource
          If _Trabajo.Sucurs_Codigo = value.Sucurs_Codigo And _Trabajo.Trabaj_Secuencia = value.Trabaj_Secuencia Then
            ListBindingSource.Position = t
          End If
          t += 1
        Next
      End If
    End Set
  End Property

#Region "Eventos"
  Private Sub FrmListaTrabajos_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaTrabajos_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaTrabajos_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Me.Timer1.Enabled = False
    Select Case TipoPresentacion
      Case enumTipoPresentacion.AperturaCaso
        If Trabajo.UltimoTrabajoLog IsNot Nothing AndAlso Not (Trabajo.UltimoTrabajoLog.Pardet_AccionTrabajo = Enumerados.enumEstadoSobre.CasoAperturado OrElse Trabajo.UltimoTrabajoLog.Pardet_AccionTrabajo = Enumerados.enumEstadoSobre.RechazadoEditores) Then
          MsgBox("El Sobre no está disponible para el área de apertura", MsgBoxStyle.Information, "Información")
        Else
          Dim f As New FrmMantenimientoTrabajo(Sistema, Restriccion, mSucursal, Enumerados.EnumOpciones.AperturaSobre)
          'f.Sucursal = mSucursal
          f.Trabajos = ListBindingSource
          f.ShowDialog()
          If ListBindingSource.Count <= 1 Then
            RefrescarLista()
          End If
          f.Dispose()
        End If
      Case enumTipoPresentacion.ProformarCaso
        'verificar que venga desde apertura de sobre para pedir fotos bajadas
        'If Trabajo.UltimoTrabajoLog.Pardet_AccionTrabajo = Enumerados.enumEstadoSobre.SobreRegistrado Then

        'End If
        'While Trabajo.Trabaj_FotosBajadas <= 0
        '  Try
        '    Trabajo.Trabaj_FotosBajadas = CInt(InputBox("Ingrese fotos bajadas al computador", "Fotos bajadas", "0"))
        '  Catch ex As Exception
        '    Trabajo.Trabaj_FotosBajadas = 0
        '  End Try
        '  If Trabajo.Trabaj_FotosBajadas > 0 Then
        '    Dim _Usuario As New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)
        '    Trabajo.Guardar(_Usuario.Empleado, False)
        '  End If
        'End While

        Dim f As New FrmMantenimientoTrabajoDisenador(Sistema, Restriccion, mSucursal, Enumerados.EnumOpciones.ProcesarSobre)
        'f.Sucursal = mSucursal
        f.Trabajos = ListBindingSource
        f.ShowDialog()
        If ListBindingSource.Count <= 1 Then
          RefrescarLista()
        End If
        f.Dispose()
      Case enumTipoPresentacion.Quirofano
        Select Case Trabajo.UltimoTrabajoLog.Pardet_AccionTrabajo
          Case Enumerados.enumEstadoSobre.LiberadoEditores, Enumerados.enumEstadoSobre.TomadoQuirofano, Enumerados.enumEstadoSobre.RechazadoEntrega
            Dim f As New FrmMantenimientoTrabajoImprenta(Sistema, Restriccion, mSucursal, Enumerados.EnumOpciones.ImprimirSobre)
            'f.Sucursal = mSucursal
            f.Trabajos = ListBindingSource
            f.ShowDialog()
            If ListBindingSource.Count <= 1 Then
              RefrescarLista()
            End If
            f.Dispose()
          Case Else
            MsgBox("El Sobre no está disponible para el área de imprenta", MsgBoxStyle.Information, "Información")
        End Select
      Case enumTipoPresentacion.FacturarCaso
        Dim f As New FrmMantenimientoTrabajoFacturacion(Sistema, Restriccion, mSucursal, Enumerados.EnumOpciones.FacturacionSobre)
        'f.Sucursal = mSucursal
        f.Trabajos = ListBindingSource
        f.ShowDialog()
        If ListBindingSource.Count <= 1 Then
          RefrescarLista()
        End If
        f.Dispose()
      Case enumTipoPresentacion.CierreCaso
        Dim f As New FrmMantenimientoTrabajoEntrega(Sistema, Restriccion, mSucursal, Enumerados.EnumOpciones.EntregaSobre)
        'f.Sucursal = mSucursal
        f.Trabajos = ListBindingSource
        f.ShowDialog()
        If ListBindingSource.Count <= 1 Then
          RefrescarLista()
        End If
        f.Dispose()
    End Select
    Me.Timer1.Enabled = True
  End Sub

  Private Sub FrmListaTrabajos_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaTrabajos_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaTrabajos_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mTrabajos Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mTrabajo As Trabajo
    mTrabajo = ListBindingSource.Current
    If mTrabajo.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar Trabajo" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub FrmListaTrabajos_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mTrabajos As TrabajoList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    Select Case TipoPresentacion
      Case enumTipoPresentacion.AperturaCaso
        MyBase.Titulo = "Apertura Caso"
        MyBase.AgregarLeyenda = "Agregar un nuevo Caso"
      Case enumTipoPresentacion.ProformarCaso
        MyBase.Titulo = "Proformar Caso"
        MyBase.AgregarLeyenda = "Agregar un nuevo Caso"
      Case enumTipoPresentacion.Quirofano
        MyBase.Titulo = "Quirófano"
        MyBase.AgregarLeyenda = "Agregar un nuevo Caso"
      Case enumTipoPresentacion.FacturarCaso
        MyBase.Titulo = "Facturación"
        MyBase.AgregarLeyenda = "Agregar un nuevo Caso"
      Case enumTipoPresentacion.CierreCaso
        MyBase.Titulo = "Cerrar Caso"
        MyBase.AgregarLeyenda = "Agregar un nuevo Caso"
    End Select

    If mSucursal Is Nothing Then
      Exit Sub
    End If
    'Me.DataGridView1.Columns.Clear()

    'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Trabajo_Codigo"
    'DataGridViewTextBoxColumn1.HeaderText = "Código"
    'DataGridViewTextBoxColumn1.Width = 120
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "NombreCompleto"
    'DataGridViewTextBoxColumn1.HeaderText = "Nombre"
    'DataGridViewTextBoxColumn1.Width = 250
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "Trabajo_Visible"
    'DataGridViewTextBoxColumn0.HeaderText = "Visible"
    'DataGridViewTextBoxColumn0.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    Me.ListBindingSource.DataSource = GetType(Trabajo)

    Dim estadosobre As Enumerados.enumEstadoSobre
    Select Case TipoPresentacion
      Case enumTipoPresentacion.AperturaCaso
        estadosobre = Enumerados.enumEstadoSobre.CasoAperturado
      Case enumTipoPresentacion.ProformarCaso
        estadosobre = Enumerados.enumEstadoSobre.TomadoProforma
      Case enumTipoPresentacion.Quirofano
        estadosobre = Enumerados.enumEstadoSobre.TomadoQuirofano
      Case enumTipoPresentacion.FacturarCaso
        estadosobre = Enumerados.enumEstadoSobre.TomadoFacturacion
      Case enumTipoPresentacion.CierreCaso
        estadosobre = Enumerados.enumEstadoSobre.TomadoCierre
    End Select

    mTrabajos = TrabajoList.ObtenerLista(mSucursal, estadosobre, IIf(Me.CheckBox1.Checked, Me.dtfecdesde.Value, Nothing), IIf(Me.CheckBox1.Checked, Me.dtfechasta.Value, Nothing), _filtro)

    Dim totales As String = ""

    Select Case TipoPresentacion
      Case enumTipoPresentacion.AperturaCaso, enumTipoPresentacion.FacturarCaso, enumTipoPresentacion.CierreCaso
        Dim valor As Decimal = 0
        Dim abono As Decimal = 0
        Dim saldo As Decimal = 0
        For Each _trabajo As Trabajo In mTrabajos
          valor += _trabajo.Deuda
          abono += _trabajo.Pagado
          saldo += _trabajo.Saldo
        Next

        totales = String.Format("Valor: {0}, Abono: {1}, Saldo: {2}", valor.ToString("0.00"), abono.ToString("0.00"), saldo.ToString("0.00"))
    End Select

    Me.lbl_totales.Text = totales

    Dim mitemssort As New Infoware.Reglas.SortedView(mTrabajos)
    ListBindingSource.DataSource = mitemssort
    Me.DataGridView1.AutoDiscover()
  End Sub

  Private Sub mTrabajos_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mTrabajos.AddingNew
    Dim _Trabajo As Trabajo = New Trabajo(mSucursal, True)
    e.NewObject = _Trabajo
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _TipoPresentacion As enumTipoPresentacion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Usuarios)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    EsBusqueda = _busqueda
    TipoPresentacion = _TipoPresentacion
    ' Add any initialization after the InitializeComponent() call.
    FrmListaTrabajos_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _TipoPresentacion As enumTipoPresentacion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Usuarios)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _TipoPresentacion, _busqueda, _OpcionNuevo)
  End Sub

  Private Sub FrmListaTrabajos_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Select Case TipoPresentacion
      'enumTipoPresentacion.FacturarSobre
      Case enumTipoPresentacion.Quirofano, enumTipoPresentacion.ProformarCaso, enumTipoPresentacion.CierreCaso
        PuedeNuevo = False
    End Select
    Me.BarraEmpresa1.Sistema = Sistema
    Me.BarraEmpresa1.Llenar_datos()
    Me.Sucursal = Me.BarraEmpresa1.Sucursal
    Llenar_datos()
  End Sub
#End Region

  Private Sub BarraEmpresa1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraEmpresa1.CambioDatos
    Me.Sucursal = Me.BarraEmpresa1.Sucursal
  End Sub

  Private Sub FrmListaTrabajos_DespuesSeleccionarCampos(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DespuesSeleccionarCampos
    Dim DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "MinutosenEspera"
    'DataGridViewTextBoxColumn1.HeaderText = "Minutos en espera"
    'DataGridViewTextBoxColumn1.Width = 70
    'Me.DataGridView1.Columns.Insert(3, DataGridViewTextBoxColumn1)

    Select Case TipoPresentacion
      Case enumTipoPresentacion.ProformarCaso, enumTipoPresentacion.Quirofano
        Me.DataGridView1.Columns.RemoveAt(5)
        Me.DataGridView1.Columns.RemoveAt(5)
        Me.DataGridView1.Columns.RemoveAt(5)

    End Select

    Select Case TipoPresentacion
      Case enumTipoPresentacion.Quirofano, enumTipoPresentacion.FacturarCaso, enumTipoPresentacion.CierreCaso
        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "Items"
        DataGridViewTextBoxColumn1.HeaderText = "Resumen"
        DataGridViewTextBoxColumn1.Width = 100
        Me.DataGridView1.Columns.Add(DataGridViewTextBoxColumn1)
    End Select

    Select Case TipoPresentacion
      Case enumTipoPresentacion.ProformarCaso, enumTipoPresentacion.Quirofano
        DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewTextBoxColumn1.DataPropertyName = "EmpleadoUltimoLog"
        DataGridViewTextBoxColumn1.HeaderText = "Tomado por"
        DataGridViewTextBoxColumn1.Width = 150
        Me.DataGridView1.Columns.Add(DataGridViewTextBoxColumn1)
    End Select

    'Select Case TipoPresentacion
    '  Case enumTipoPresentacion.AperturaSobre
    '  Case enumTipoPresentacion.ProcesarSobre
    '    Dim DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    '    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    '    DataGridViewTextBoxColumn1.DataPropertyName = "MinutosenEspera"
    '    DataGridViewTextBoxColumn1.HeaderText = "Minutos en espera"
    '    DataGridViewTextBoxColumn1.Width = 100
    '    Me.DataGridView1.Columns.Insert(2, DataGridViewTextBoxColumn1)
    'End Select
  End Sub

  Private mContadorTimer As Integer = 0
  Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    mContadorTimer += 1
    If mContadorTimer > 10 Then
      Llenar_datos()
      mContadorTimer = 0
      Exit Sub
    End If
    'If TipoPresentacion = enumTipoPresentacion.ProcesarSobre Then
    Me.DataGridView1.Invalidate()
    'End If

  End Sub

  Private Sub btnhistorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhistorial.Click
    Dim f As New FrmTrabajoHistorial(Sistema, Restriccion)
    f.Trabajo = Trabajo
    f.ShowDialog()
  End Sub

  Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged, dtfecdesde.ValueChanged, dtfechasta.ValueChanged
    Llenar_datos()
  End Sub
End Class
