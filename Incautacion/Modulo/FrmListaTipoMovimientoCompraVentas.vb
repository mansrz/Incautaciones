Imports Infoware.Datos
Imports Infoware.Reglas.General
'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmListaTipoMovimientoCompraVentas
#Region "IOpcion"
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
#End Region

  Private mTipoMovimientoCompraVenta As TipoMovimientoCompraVenta = Nothing
  Public Property TipoMovimientoCompraVenta() As TipoMovimientoCompraVenta
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As TipoMovimientoCompraVenta)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _TipoMovimientoCompraVenta As TipoMovimientoCompraVenta In Me.ListBindingSource.DataSource
          If _TipoMovimientoCompraVenta.Empres_Codigo = value.Empres_Codigo And _TipoMovimientoCompraVenta.Sucurs_Codigo = value.Sucurs_Codigo And _TipoMovimientoCompraVenta.Pardet_TipoCompraVenta = value.Pardet_TipoCompraVenta Then
            ListBindingSource.Position = t
          End If
          t += 1
        Next
      End If
    End Set
  End Property

#Region "Eventos"
  Private Sub FrmListaSecuencias_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaSecuencias_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaSecuencias_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoTipoMovimientoCompraVenta(Sistema, Restriccion, Enumerados.EnumOpciones.ListadoItems)
    f.Sucursal = mSucursal
    f.TipoMovimientoCompraVentas = ListBindingSource
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
  End Sub

  Private Sub FrmListaSecuencias_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaSecuencias_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaSecuencias_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mTipoMovimientoCompraVentas Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mTipoMovimientoCompraVenta As TipoMovimientoCompraVenta
    mTipoMovimientoCompraVenta = ListBindingSource.Current
    If mTipoMovimientoCompraVenta.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar TipoMovimientoCompraVenta" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub FrmListaSecuencias_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mTipoMovimientoCompraVentas As TipoMovimientoCompraVentaList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    If mSucursal Is Nothing Then
      Exit Sub
    End If

    MyBase.Titulo = "Tipo de Movimiento de Compra/Venta"
    MyBase.AgregarLeyenda = "Agregar un nuevo TipoMovimientoCompraVenta"

    'Me.DataGridView1.Columns.Clear()

    'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "PardetTipoCompraVentaString"
    'DataGridViewTextBoxColumn1.HeaderText = "Tipo de movimiento"
    'DataGridViewTextBoxColumn1.Width = 150
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'Dim estilonum0 As New DataGridViewCellStyle()
    'estilonum0.Format = "N0"

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "TiMoCv_Secuencia"
    'DataGridViewTextBoxColumn1.HeaderText = "Secuencia"
    'DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum0
    'DataGridViewTextBoxColumn1.Width = 100
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.ListBindingSource.DataSource = GetType(TipoMovimientoCompraVenta)
    mTipoMovimientoCompraVentas = TipoMovimientoCompraVentaList.ObtenerLista(mSucursal, IIf(Me.ComboBoxStd1.SelectedIndex = 0, TipoMovimientoCompraVentaList.enumTipoMovimiento.Compra, TipoMovimientoCompraVentaList.enumTipoMovimiento.Venta))
    Dim mitemssort As New Infoware.Reglas.SortedView(mTipoMovimientoCompraVentas)
    ListBindingSource.DataSource = mitemssort
    Me.DataGridView1.AutoDiscover()
  End Sub

  'Private Sub mTipoMovimientoCompraVentas_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mTipoMovimientoCompraVentas.AddingNew
  '  Dim _TipoMovimientoCompraVenta As TipoMovimientoCompraVenta = New TipoMovimientoCompraVenta(mSucursal, True)
  '  e.NewObject = _TipoMovimientoCompraVenta
  'End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    EsBusqueda = _busqueda
    Me.PuedeNuevo = False
    ' Add any initialization after the InitializeComponent() call.
    FrmListaBodegas_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Usuarios)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _OpcionNuevo)
  End Sub

  Private Sub FrmListaBodegas_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.BarraEmpresa1.Sistema = Sistema
    Me.BarraEmpresa1.Llenar_datos()
    Me.Sucursal = Me.BarraEmpresa1.Sucursal

    Me.PuedeNuevo = False
    Me.ComboBoxStd1.SelectedIndex = 0
    Llenar_datos()
  End Sub
#End Region

  Private Sub BarraEmpresa1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraEmpresa1.CambioDatos
    Me.Sucursal = Me.BarraEmpresa1.Sucursal
  End Sub

  Private Sub ComboBoxStd1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxStd1.SelectedIndexChanged
    Llenar_datos()
  End Sub
End Class
