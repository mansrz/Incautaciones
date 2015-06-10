Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas
Imports Microsoft.Office.Interop

Public Class FrmMantenimientoMovimientoInventario
#Region "IOpcion"
    Private tiposmovs As WWTSParametroDetList
    Private tipocompraventas As WWTSParametroDetList
#End Region

#Region "Parametros"
    Public Property MovimientoInventarios() As BindingSource
        Get
            Return MyBase.BindingSource1
        End Get
        Set(ByVal value As BindingSource)
            MyBase.BindingSource1 = value
            mEstaCambiando = False
            llenar_datos()
        End Set
    End Property

    Private mMovimientoInventario As MovimientoInventario = Nothing
    Public Property MovimientoInventario() As MovimientoInventario
        Get
            Return mMovimientoInventario
        End Get
        Set(ByVal value As MovimientoInventario)
            mMovimientoInventario = value
            If value IsNot Nothing Then
                mEstaCambiando = True
                Dim _MovimientoInventarios As New MovimientoInventarioList
                _MovimientoInventarios.Add(mMovimientoInventario)
                MyBase.BindingSource1.DataSource = GetType(MovimientoInventario)
                mEstaCambiando = False
                MyBase.BindingSource1.DataSource = _MovimientoInventarios
            End If
        End Set
    End Property

    Private ReadOnly Property TipoMovimiento As WWTSParametroDet
        Get
            Return tiposmovs(Me.comboTipoMovimiento.SelectedIndex)
        End Get
    End Property

    Private ReadOnly Property TipoMovimientoEnum As Enumerados.enumTipoMovInv
        Get
            Return CType(tiposmovs(Me.comboTipoMovimiento.SelectedIndex).Pardet_Secuencia, Enumerados.enumTipoMovInv)
        End Get
    End Property
#End Region

#Region "Cerrar y Cancelar"
    Private Sub FrmMantenimientoMovimientoInventario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Cancelar_Nuevo()
    End Sub
    Private Function Cancelar_Nuevo() As Boolean
        Dim _esnuevo As Boolean = mMovimientoInventario.EsNuevo
        If _esnuevo AndAlso MovimientoInventarios.Current IsNot Nothing Then
            MovimientoInventarios.RemoveCurrent()
        End If
        Return _esnuevo
    End Function
#End Region

#Region "MovimientoInventarios eventos"
    Private Sub FrmMantenimientoMovimientoInventario_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
        Dim _MovimientoInventario As MovimientoInventario = New MovimientoInventario(mSucursal, Enumerados.enumTipoMovInv.InvInicial, True)
        e.NewObject = _MovimientoInventario
    End Sub

    Private Sub FrmMantenimientoMovimientoInventario_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
        llenar_datos()
    End Sub
#End Region

#Region "Guardar y Eliminar"
    Private Sub FrmMantenimientoMovimientoInventario_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
        e.Cancel = Not Guardar_datos()
    End Sub

    Private Function Guardar_datos() As Boolean
        CtlMovimientoInventario1.mapear_datos()
        Return CtlMovimientoInventario1.Guardar(Me.CtlBloqueo1.Bloqueado)
    End Function

    Private Sub FrmMantenimientoMovimientoInventario_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
        If mMovimientoInventario.Eliminar() AndAlso MovimientoInventarios.Current IsNot Nothing Then
            MovimientoInventarios.RemoveCurrent()
            Me.Close()
        Else
            MovimientoInventarios.CancelEdit()
            MsgBox("No se puede eliminar MovimientoInventario" & Environment.NewLine & mSucursal.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        End If
    End Sub
#End Region

#Region "Mover"
    Private Sub FrmMantenimientoMovimientoInventario_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoMovimientoInventario_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoMovimientoInventario_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoMovimientoInventario_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
        e.Cancel = Cancelar_Nuevo()
    End Sub
#End Region

#Region "movimiento"
    Private mEstaCambiando As Boolean = True
    Private Sub llenar_datos()
        If mSucursal Is Nothing OrElse MovimientoInventarios Is Nothing OrElse MovimientoInventarios.Current Is Nothing Then
            Exit Sub
        End If
        Me.btnexportar.Visible = True
        If mEstaCambiando Then
            Exit Sub
        End If
        mEstaCambiando = True
        mMovimientoInventario = MovimientoInventarios.Current
        ValidarRegistro()
        Me.comboTipoMovimiento.ComboBox.SelectedValue = CInt(mMovimientoInventario.Pardet_Tipomovinv)
        comboTipoMovimiento_SelectedIndexChanged(Me, Nothing)
        Me.CtlMovimientoInventario1.MovimientoInventario = mMovimientoInventario
        mEstaCambiando = False
        Me.CtlBloqueo1.Restriccion = Restriccion

        Me.comboTipoMovimiento.Enabled = mMovimientoInventario.EsNuevo
        Me.comboTipoCompraVenta.Enabled = mMovimientoInventario.EsNuevo
    End Sub

    Private _tipocompraventa As ParametroDet = Nothing
    Private Sub comboTipoCompraVenta_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboTipoCompraVenta.SelectedIndexChanged
        If Me.comboTipoCompraVenta.Visible Then
            Select Case TipoMovimientoEnum
                Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.DevCompra, Enumerados.enumTipoMovInv.Venta, Enumerados.enumTipoMovInv.DevVenta
                    _tipocompraventa = tipocompraventas(Me.comboTipoCompraVenta.SelectedIndex)
            End Select
        End If
    End Sub

    Private Sub comboTipoMovimiento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboTipoMovimiento.SelectedIndexChanged
        If Not mEstaCambiando Then
            mEstaCambiando = True
            MyBase.BindingSource1.DataSource = Nothing
            MovimientoInventario = New MovimientoInventario(mSucursal, TipoMovimientoEnum, True)
            'llenar_datos()
            Exit Sub
        End If

        Me.SepPagos.Visible = False
        Me.btnpagos.Visible = False

        Me.comboTipoCompraVenta.Visible = False
        Select Case TipoMovimientoEnum
            Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.Venta, Enumerados.enumTipoMovInv.DevCompra, Enumerados.enumTipoMovInv.DevVenta
                Me.comboTipoCompraVenta.Visible = True
                Me.SepPagos.Visible = True
                Me.btnpagos.Visible = True
            Case Enumerados.enumTipoMovInv.OrdenProduccion, Enumerados.enumTipoMovInv.OrdenDesensamble
        End Select

        Select Case TipoMovimientoEnum
            Case Enumerados.enumTipoMovInv.Compra, Enumerados.enumTipoMovInv.DevCompra
                Me.comboTipoCompraVenta.ComboBox.ValueMember = "Pardet_Secuencia"
                Me.comboTipoCompraVenta.ComboBox.DisplayMember = "Pardet_Descripcion"
                tipocompraventas = WWTSParametroDetList.ObtenerLista(mSucursal.OperadorDatos, Enumerados.EnumParametros.TipoCompra)
                Me.comboTipoCompraVenta.ComboBox.DataSource = tipocompraventas
                Me.comboTipoMovimiento.ComboBox.SelectedValue = CInt(TipoMovimientoEnum)
            Case Enumerados.enumTipoMovInv.Venta, Enumerados.enumTipoMovInv.DevVenta
                Me.comboTipoCompraVenta.ComboBox.ValueMember = "Pardet_Secuencia"
                Me.comboTipoCompraVenta.ComboBox.DisplayMember = "Pardet_Descripcion"
                tipocompraventas = WWTSParametroDetList.ObtenerLista(mSucursal.OperadorDatos, Enumerados.EnumParametros.TipoVenta)
                Me.comboTipoCompraVenta.ComboBox.DataSource = tipocompraventas
                Me.comboTipoMovimiento.ComboBox.SelectedValue = CInt(TipoMovimientoEnum)
        End Select

    End Sub
#End Region

#Region "Actualizar"
    Private Sub Actualizar_datos(ByVal sender As Object, ByVal e As System.EventArgs)
        ' ComboBoxIVA1.CambioItem,
        Me.CtlMovimientoInventario1.mapear_datos()
    End Sub
#End Region

#Region "Formato"
    Private Sub FrmMantenimientoMovimientoInventario_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
        'Dim f As New Infoware.Reportes.FrmReportSimple
        'f.ArchivoReporte = ArchivoFormato()
        'f.Cabecera = mMovimientoInventario
        'f.Detalles = mMovimientoInventario.Detalles
        'f.VistaPrevia()
        Me.CtlMovimientoInventario1.Imprimir()
    End Sub

    Private Sub FrmMantenimientoMovimientoInventario_ModificarFormato(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ModificarFormato
        'Dim f As New Infoware.Reportes.FrmReportSimple
        'f.ArchivoReporte = ArchivoFormato()
        'f.Cabecera = mMovimientoInventario
        'f.Detalles = mMovimientoInventario.Detalles
        'f.ShowDialog()
        Me.CtlMovimientoInventario1.ModificarFormato()
    End Sub

    'Private Function ArchivoFormato() As String
    '  Dim archivo As String
    '  If TipoMovimientoEnum = Enumerados.enumTipoMovInv.Compra Then
    '    Dim _enumtipocmp As Enumerados.enumTipoCompra
    '    _enumtipocmp = CType(tipocompraventas(Me.comboTipoCompraVenta.SelectedIndex).Pardet_Secuencia, Enumerados.enumTipoCompra)

    '    archivo = Me.Sistema.DirectorioRaiz & "\Formatos\" & _enumtipocmp.ToString.Trim & ".rps"

    '  ElseIf TipoMovimientoEnum = Enumerados.enumTipoMovInv.Venta Then
    '    Dim _enumtipovta As Enumerados.enumTipoVenta
    '    _enumtipovta = CType(tipocompraventas(Me.comboTipoCompraVenta.SelectedIndex).Pardet_Secuencia, Enumerados.enumTipoVenta)

    '    archivo = Me.Sistema.DirectorioRaiz & "\Formatos\" & _enumtipovta.ToString.Trim & ".rps"
    '  Else
    '    archivo = Me.Sistema.DirectorioRaiz & "\Formatos\" & TipoMovimientoEnum.ToString.Trim & ".rps"
    '  End If
    '  Return archivo
    'End Function
#End Region

#Region "New"
    Private mSucursal As Sucursal = Nothing
    'Private mRegistroContable As RegistroContable = Nothing

    Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Sucursal As Sucursal, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
        'ByVal _RegistroContable As RegistroContable,
        MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        mSucursal = _Sucursal
        'mRegistroContable = _RegistroContable
        ' Add any initialization after the InitializeComponent() call.
        FrmMantenimientoItem_Inicializar(Me, Nothing)
    End Sub

    Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _Sucursal As Sucursal, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoClientes)
        'ByVal _RegistroContable As RegistroContable,
        Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _Sucursal, _OpcionNuevo) ', _RegistroContable
    End Sub

    Private Sub FrmMantenimientoItem_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
        ToolStripManager.Merge(Me.ToolStripMovimiento, Me.ToolStrip1)
        Me.ToolStripMovimiento.Visible = False

        MyBase.Tabla = "Movimiento inventario"
        Me.comboTipoMovimiento.ComboBox.ValueMember = "Pardet_Secuencia"
        Me.comboTipoMovimiento.ComboBox.DisplayMember = "Pardet_Descripcion"
        tiposmovs = WWTSParametroDetList.ObtenerLista(mSucursal.OperadorDatos, Enumerados.EnumParametros.TipoMovInventario)
        Me.comboTipoMovimiento.ComboBox.DataSource = tiposmovs

        Me.CtlMovimientoInventario1.Sistema = Sistema
        Me.CtlMovimientoInventario1.VerConfidencial = Restriccion.Restri_VerConfidencial
        Me.CtlMovimientoInventario1.Sucursal = mSucursal
        'Me.ComboBoxCreditoTributario1.Llenar_datos()
    End Sub
#End Region

    Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.BindingSource1 = Nothing
    End Sub

    Private Sub btnpagos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnpagos.Click
        If mMovimientoInventario.EsNuevo Then
            If MsgBox("Para continuar necesita guardar la transacción. ¿Está seguro que desea continuar?", MsgBoxStyle.YesNo, "Pregunta") = vbYes AndAlso Guardar_datos() Then
                Me.Close()
            End If
        End If
        mostrar_pagos()
    End Sub

    Private Sub mostrar_pagos()
        Dim f As New FrmMantenimientoPagos(Sistema, Enumerados.EnumOpciones.Cuentas, mSucursal)
        f.MovimientoInventario = mMovimientoInventario
        f.ShowDialog()
        Dim pagos As PagosDetList = mMovimientoInventario.Pagos(True)
    End Sub

    Public Property PuedeExportar As Boolean
        Get
            Return Me.btnexportar.Visible
        End Get
        Set(value As Boolean)
            Me.btnexportar.Visible = value
            'Me.MenuStrip1.Visible = value
        End Set
    End Property

    Public Event Exportar As EventHandler

    Private Sub btnexportar_Click(sender As System.Object, e As System.EventArgs) Handles btnexportar.Click
        'RaiseEvent Exportar(Me, Nothing
        Dim dgItems As DataGridViewAutoDiscover
        dgItems = CType(Me.CtlMovimientoInventario1.DataGridViewDetalles.CtlMovimientoInventarioDet2, DataGridViewAutoDiscover)

        dgItems.Excel(DataGridViewAutoDiscover.EnumSalida.Excel)

    End Sub


    'Private Sub FrmMantenimientoMovimientoInventario_Exportar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Exportar
    '    'exportar
    '    Try
    '        Dim excelApp As New Excel.Application
    '        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
    '        Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
    '        excelApp.Visible = False

    '        With excelWorksheet
    '            .Range("A1").Value = "Item"
    '            .Columns("A:A").ColumnWidth = 30
    '            .Columns("A:A").NumberFormat = "@"

    '            .Range("B1").Value = "Cantidad"
    '            .Columns("B:B").ColumnWidth = 80
    '            .Columns("B:B").NumberFormat = "@"

    '            .Range("C1").Value = "Unidad de medida"
    '            .Columns("C:C").ColumnWidth = 80
    '            .Columns("C:C").NumberFormat = "@"

    '            .Range("D1").Value = "Descripción"
    '            .Columns("D:D").ColumnWidth = 80
    '            .Columns("D:D").NumberFormat = "@"

    '            .Range("E1").Value = "Marca"
    '            .Columns("E:E").ColumnWidth = 80
    '            .Columns("E:E").NumberFormat = "@"

    '            .Range("F1").Value = "Modelo"
    '            .Columns("F:F").ColumnWidth = 30
    '            .Columns("F:F").NumberFormat = "@"

    '            .Range("G1").Value = "Serie"
    '            .Columns("G:G").ColumnWidth = 80
    '            .Columns("G:G").NumberFormat = "@"

    '            .Range("H1").Value = "Estado"
    '            .Columns("H:H").ColumnWidth = 80
    '            .Columns("H:H").NumberFormat = "@"

    '            .Range("I1").Value = "Valor Unitario"
    '            .Columns("I:I").ColumnWidth = 80
    '            .Columns("I:I").NumberFormat = "@"

    '            .Range("J1").Value = "Valor Total"
    '            .Columns("J:J").ColumnWidth = 80
    '            .Columns("J:J").NumberFormat = "@"

    '            .Range("K1").Value = "Características"
    '            .Columns("K:K").ColumnWidth = 80
    '            .Columns("K:K").NumberFormat = "@"

    '            'Dim _MovimientoInventarios As New MovimientoInventarioList
    '            '_MovimientoInventarios.Add(mMovimientoInventario)
    '            'MyBase.BindingSource1.DataSource = GetType(MovimientoInventario)

    '            Dim t As Integer = 0
    '            For Each _detalle As MovimientoInventarioDet In MovimientoInventario.Detalles
    '                .Cells(t, 1).Value = _detalle.ItemSecuencia
    '                .Cells(t, 2).Value = _detalle.Moinde_Cantidad
    '                .Cells(t, 3).Value = _detalle.PardetUnidadMedidaString
    '                .Cells(t, 4).Value = _detalle.ItemDescripcion
    '                .Cells(t, 5).Value = _detalle.ItemMarca
    '                .Cells(t, 6).Value = _detalle.ItemModelo
    '                .Cells(t, 7).Value = _detalle.ItemSerie
    '                .Cells(t, 8).Value = _detalle.ItemEstado
    '                .Cells(t, 9).Value = _detalle.Moinde_Valor
    '                .Cells(t, 10).Value = _detalle.Total
    '                .Cells(t, 11).Value = _detalle.ItemCaracteristicas
    '            Next

    '            .Columns("A:K").EntireColumn.AutoFit()
    '        End With
    '        excelApp.Visible = True
    '        'excelWorksheet.PrintPreview()
    '        'excelApp.Quit()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub


    Private Sub btnimprbarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprbarcode.Click
        Dim f As New Infoware.Reportes.FrmReportSimple
        f.ArchivoReporte = Me.Sistema.DirectorioRaiz & "\Formatos\barcode.rps"
        f.Cabecera = mMovimientoInventario
        f.Detalles = mMovimientoInventario.DetalleSerie
        f.VistaPrevia()
    End Sub

    Private Sub btnformatobarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnformatobarcode.Click
        Dim f As New Infoware.Reportes.FrmReportSimple
        f.ArchivoReporte = Me.Sistema.DirectorioRaiz & "\Formatos\barcode.rps"
        f.Cabecera = mMovimientoInventario
        f.Detalles = mMovimientoInventario.DetalleSerie
        f.ShowDialog()
    End Sub

End Class
