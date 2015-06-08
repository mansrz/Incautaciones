Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmListaIncautacion
    Private mSucursal As Sucursal = Nothing
    Public Property Sucursal() As Sucursal
        Get
            Return mSucursal
        End Get
        Set(ByVal value As Sucursal)
            mSucursal = value
            'Llenar_datos()
        End Set
    End Property

    Private mContribuyente As Contribuyente = Nothing
    Public Property Contribuyente As Contribuyente
        Get
            Return mContribuyente
        End Get
        Set(value As Contribuyente)
            mContribuyente = value
        End Set
    End Property

    Private mIncautacion As Reglas.Incautacion = Nothing
    Public Property Incautacion() As Reglas.Incautacion
        Get
            If ListBindingSource.Current Is Nothing Then
                Return Nothing
            Else
                Return ListBindingSource.Current
            End If
        End Get
        Set(value As Reglas.Incautacion)
            If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
                Dim t As Integer = 0
                For Each _Incautacion As Reglas.Incautacion In Me.ListBindingSource.DataSource
                    If _Incautacion.Incaut_Codigo = value.Incaut_Codigo Then
                        ListBindingSource.Position = t
                    End If
                    t += 1
                Next
            End If
        End Set
    End Property

    Public Property Filtro() As String
        Get
            Return MyBase.combobuscar.Text
        End Get
        Set(ByVal value As String)
            MyBase.combobuscar.Text = value
            MyBase.Hacer_busqueda()
        End Set
    End Property


#Region "Eventos"
    Private Sub FrmListaIncautacion_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
        Abrir_Mantenimiento()
    End Sub

    Private Sub FrmListaIncautacion_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub FrmListaIncautacion_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
        Me.ListBindingSource.AddNew()
        Abrir_Mantenimiento()
    End Sub

    Sub Abrir_Mantenimiento()
        If ListBindingSource.Current Is Nothing Then
            Exit Sub
        End If

        Dim f As New FrmMantenimientoIncautacion(Sistema, Restriccion)
        f.Incautaciones = ListBindingSource
        f.Contribuyente = mContribuyente
        f.Sucursal = Me.Sucursal
        f.Incautacion = ListBindingSource.Current

        f.ShowDialog()
        If ListBindingSource.Count <= 1 Then
            RefrescarLista()
        End If
        f.Dispose()

        Dim _esnuevo As Boolean = CType(ListBindingSource.Current, Reglas.Incautacion).EsNuevo
        If _esnuevo AndAlso ListBindingSource.Current IsNot Nothing Then
            ListBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub FrmListaIncautaciones_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
        Llenar_datos(Me.combobuscar.Text)
    End Sub

    Private Sub FrmListaIncautaciones_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
        Llenar_datos()
    End Sub

    Private Sub FrmListaIncautaciones_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
        If mIncautaciones Is Nothing OrElse ListBindingSource.Current Is Nothing Then
            Exit Sub
        End If
        Dim mIncautacion As Reglas.Incautacion
        mIncautacion = ListBindingSource.Current
        If mIncautacion.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
            ListBindingSource.RemoveCurrent()
        Else
            MsgBox("No se puede eliminar la Incautacion" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Private Sub FrmListaContribuyentes_Exportar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Exportar
    '  'exportar
    '  Try
    '    Dim excelApp As New Excel.Application
    '    Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
    '    Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
    '    excelApp.Visible = False
    '    With excelWorksheet
    '      .Range("A1").Value = "Nombre de Contribuyente"
    '      .Columns("A:A").ColumnWidth = 80
    '      .Columns("A:A").NumberFormat = "@"

    '      .Range("B1").Value = "Direcciones"
    '      .Columns("B:B").ColumnWidth = 80
    '      .Columns("B:B").NumberFormat = "@"

    '      .Range("C1").Value = "Teléfonos"
    '      .Columns("C:C").ColumnWidth = 80
    '      .Columns("C:C").NumberFormat = "@"

    '      .Range("D1").Value = "Emails"
    '      .Columns("D:D").ColumnWidth = 80
    '      .Columns("D:D").NumberFormat = "@"

    '      .Range("E1").Value = "Identificaciones"
    '      .Columns("E:E").ColumnWidth = 80
    '      .Columns("E:E").NumberFormat = "@"

    '      Dim t As Integer = 0
    '      For Each _Contribuyente As Contribuyente In mContribuyentes
    '        .Cells(t, 1).Value = _Contribuyente.NombreCompleto
    '        .Cells(t, 2).Value = _Contribuyente.DireccionesString
    '        .Cells(t, 3).Value = _Contribuyente.TelefonosString
    '        .Cells(t, 4).Value = _Contribuyente.EmailsString
    '        .Cells(t, 5).Value = _Contribuyente.TelefonosString
    '      Next

    '      .Columns("A:E").EntireColumn.AutoFit()
    '    End With
    '    excelApp.Visible = True
    '    excelWorksheet.PrintPreview()
    '    'excelApp.Quit()
    '  Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '  End Try
    'End Sub

    Private Sub FrmListaContribuyentes_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
        'imprimir
    End Sub
#End Region

#Region "Llenardatos"
    Private WithEvents mIncautaciones As IncautacionList = Nothing

    Sub Llenar_datos(Optional ByVal _filtro As String = "")
        MyBase.Titulo = "Incautaciones"
        MyBase.AgregarLeyenda = "Agregar una nueva Incautacion"

        If mContribuyente Is Nothing Then
            Exit Sub
        End If

        If mSucursal Is Nothing Then
            Exit Sub
        End If

        'Me.DataGridView1.Columns.Clear()

        'Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
        'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        'DataGridViewTextBoxColumn0.DataPropertyName = "Provee_Visible"
        'DataGridViewTextBoxColumn0.HeaderText = "Activo"
        'DataGridViewTextBoxColumn0.Width = 50
        'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

        'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        'DataGridViewTextBoxColumn1.DataPropertyName = "NombreCompleto"
        'DataGridViewTextBoxColumn1.HeaderText = "Nombre de Contribuyente"
        'DataGridViewTextBoxColumn1.Width = 250
        'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        'DataGridViewTextBoxColumn1.DataPropertyName = "DireccionesString"
        'DataGridViewTextBoxColumn1.HeaderText = "Dirección"
        'DataGridViewTextBoxColumn1.Width = 250
        'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        'DataGridViewTextBoxColumn1.DataPropertyName = "TelefonosString"
        'DataGridViewTextBoxColumn1.HeaderText = "Teléfono"
        'DataGridViewTextBoxColumn1.Width = 250
        'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

        Me.ListBindingSource.DataSource = GetType(Incautacion.Reglas.Incautacion)
        mIncautaciones = IncautacionList.ObtenerLista(Sucursal.Empresa, Contribuyente, _filtro)
        Dim mitemssort As New Infoware.Reglas.SortedView(mIncautaciones)
        ListBindingSource.DataSource = mitemssort
        Me.DataGridView1.AutoDiscover()
    End Sub

    Private Sub mContribuyentes_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mIncautaciones.AddingNew
        Dim _Incautacion As Reglas.Incautacion = New Reglas.Incautacion(Sistema.OperadorDatos, True)
        e.NewObject = _Incautacion
    End Sub
#End Region


#Region "New"
    Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, ByVal _Contribuyente As Contribuyente, ByVal _Sucursal As Sucursal, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListaIncautaciones)
        MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        EsBusqueda = _busqueda

        mSucursal = _Sucursal
        mContribuyente = Contribuyente

        ' Add any initialization after the InitializeComponent() call.
        'AddHandler Me.DataGridView1.CellMouseMove, AddressOf Me.DataGridView1_CellMouseMove
        FrmListaIncautaciones_Inicializar(Me, Nothing)
    End Sub

    Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, ByVal _Contribuyente As Contribuyente, ByVal _Sucursal As Sucursal, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListaIncautaciones)
        Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _Contribuyente, _Sucursal, _OpcionNuevo)
    End Sub

    Private Sub FrmListaIncautaciones_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
        Llenar_datos()
    End Sub
#End Region

    'Private Sub DataGridView1_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
    '    If DesignMode Then
    '        Exit Sub
    '    End If
    '    If e.ColumnIndex = -1 Or e.ColumnIndex <> 0 Or e.RowIndex = -1 Then
    '        Me.btnmostrar.Visible = False
    '        Me.ToolTipImage1.Hide(Me.btnmostrar)
    '        Exit Sub
    '    End If
    '    Me.btnmostrar.Visible = True
    '    Dim rec As Rectangle = Me.DataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
    '    Me.btnmostrar.Location = New Point(e.Location.X + rec.X + Me.DataGridView1.Location.X, e.Location.Y + rec.Y + DataGridView1.Location.Y)

    '    Dim _Contribuyente As Contribuyente
    '    '_item = mItems(e.RowIndex)
    '    _Contribuyente = CType(Me.DataGridView1.DataSource.datasource, Infoware.Reglas.SortedView)(e.RowIndex)
    '    Me.ToolTipImage1.SetToolTipImageTitle(Me.btnmostrar, "Contribuyente")
    '    Me.ToolTipImage1.SetToolTipImageImage(Me.btnmostrar, _Contribuyente.Entidad.Entida_Imagen(100))
    '    Me.ToolTipImage1.SetToolTipImageText(Me.btnmostrar, _Contribuyente.NombreCompleto)
    '    'Me.ToolTipImage1.SetToolTipImageIcon(Me.btnmostrar, _item.PardetGrupo.Pardet_Imagen(25))
    '    Me.ToolTipImage1.Show("Descripción", Me.btnmostrar)
    'End Sub
End Class
