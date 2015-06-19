Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

'Imports WWTS.Inventario.Reglas

Public Class FrmListaTipoMovimientoInventarios
  Public Property Sucursal() As Sucursal
    Get
      Return mSucursal
    End Get
    Set(ByVal value As Sucursal)
      mSucursal = value
      Llenar_datos()
    End Set
  End Property

  Private mTipoMovimientoInventario As TipoMovimientoInventario = Nothing
    Public Property TipoMovimientoInventario() As TipoMovimientoInventario

        Get
            If ListBindingSource.Current Is Nothing Then
                Return Nothing
            Else
                Return ListBindingSource.Current
            End If
        End Get
        Set(ByVal value As TipoMovimientoInventario)
            If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
                Dim t As Integer = 0
                For Each _TipoMovimientoInventario As TipoMovimientoInventario In Me.ListBindingSource.DataSource
                    'MessageBox.Show("tipo movimiento en lista de tipo mov inventario" + _TipoMovimientoInventario.Pardet_Tipomovinv.ToString)
                    If _TipoMovimientoInventario.Empres_Codigo = value.Empres_Codigo And _TipoMovimientoInventario.Sucurs_Codigo = value.Sucurs_Codigo And _TipoMovimientoInventario.Pardet_Tipomovinv = value.Pardet_Tipomovinv Then
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

    Dim f As New FrmMantenimientoTipoMovimientoInventario(Sistema, Restriccion, Enumerados.EnumOpciones.ListadoItems)
    f.Sucursal = mSucursal
    f.TipoMovimientoInventarios = ListBindingSource
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
    If mTipoMovimientoInventarios Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mTipoMovimientoInventario As TipoMovimientoInventario
    mTipoMovimientoInventario = ListBindingSource.Current
    If mTipoMovimientoInventario.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar TipoMovimientoInventario" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub FrmListaSecuencias_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mTipoMovimientoInventarios As TipoMovimientoInventarioList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Tipo de Movimientos de Inventario"
    MyBase.AgregarLeyenda = "Agregar un nuevo Tipo de Movimiento de Inventario"

    'Me.DataGridView1.Columns.Clear()

    'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "PardetTipoMovInvString"
    'DataGridViewTextBoxColumn1.HeaderText = "Tipo de movimiento"
    'DataGridViewTextBoxColumn1.Width = 150
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'Dim estilonum0 As New DataGridViewCellStyle()
    'estilonum0.Format = "N0"

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Tipmov_Secuencia"
    'DataGridViewTextBoxColumn1.HeaderText = "Secuencia"
    'DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum0
    'DataGridViewTextBoxColumn1.Width = 100
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "Tipmov_Seguirsecuencia"
    'DataGridViewTextBoxColumn0.HeaderText = "Activo"
    'DataGridViewTextBoxColumn0.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    Me.ListBindingSource.DataSource = GetType(TipoMovimientoInventario)
    mTipoMovimientoInventarios = TipoMovimientoInventarioList.ObtenerLista(mSucursal)
    Dim mitemssort As New Infoware.Reglas.SortedView(mTipoMovimientoInventarios)
    ListBindingSource.DataSource = mitemssort
    Me.DataGridView1.AutoDiscover()
  End Sub

  Private Sub mTipoMovimientoInventarios_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mTipoMovimientoInventarios.AddingNew
    Dim _TipoMovimientoInventario As TipoMovimientoInventario = New TipoMovimientoInventario(mSucursal, True)
    e.NewObject = _TipoMovimientoInventario
  End Sub
#End Region

#Region "New"
  Private mSucursal As Sucursal

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
    Llenar_datos()
  End Sub
#End Region

  Private Sub BarraEmpresa1_CambioDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraEmpresa1.CambioDatos
    Me.Sucursal = Me.BarraEmpresa1.Sucursal
  End Sub
End Class
