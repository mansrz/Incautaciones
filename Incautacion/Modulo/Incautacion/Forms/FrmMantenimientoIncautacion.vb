Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmMantenimientoIncautacion


    Private mContribuyente As Contribuyente = Nothing
    Public Property Contribuyente As Contribuyente
        Get
            Return mContribuyente
        End Get
        Set(value As Contribuyente)
            mContribuyente = value
        End Set
    End Property

#Region "IOpcion"
    Private mSucursal As Sucursal = Nothing
    Public Property Sucursal() As Sucursal
        Get
            Return mSucursal
        End Get
        Set(ByVal value As Sucursal)
            'MessageBox.Show("sucursal en mant incaut" + value.NombreCompleto)
            mSucursal = value
        End Set
    End Property
#End Region

#Region "Parametros"
    Public Property Incautaciones() As BindingSource
        Get
            Return MyBase.BindingSource1
        End Get
        Set(ByVal value As BindingSource)
            MyBase.BindingSource1 = value
            llenar_datos()
        End Set
    End Property

    Private mIncautacion As Reglas.Incautacion = Nothing
    Public Property Incautacion() As Reglas.Incautacion
        Get
            Return mIncautacion
        End Get
        Set(ByVal value As Reglas.Incautacion)
            mIncautacion = value
            llenar_datos()
            If MyBase.BindingSource1.DataSource Is Nothing Then
                Dim _incautaciones As New IncautacionList
                _incautaciones.Add(mIncautacion)
                MyBase.BindingSource1.DataSource = GetType(Reglas.Incautacion)
                MyBase.BindingSource1.DataSource = _incautaciones
                Me.Incautaciones = MyBase.BindingSource1
                llenar_datos()
            End If
        End Set
    End Property

    Sub llenar_datos()
        If Sistema.OperadorDatos Is Nothing Then
            Exit Sub
        End If

        If Contribuyente IsNot Nothing Then
            Me.CtlBuscaContribuyente1.Contribuyente = Me.Contribuyente
        End If

        If mIncautacion Is Nothing Then
            mIncautacion = Incautaciones.Current
        End If

        If mIncautacion Is Nothing Then
            Exit Sub
        End If

        If mSucursal Is Nothing Then
            Exit Sub
        End If

        Me.CtlBuscaContribuyente1.Contribuyente = mIncautacion.Contribuyente
        Me.CtlBuscaAdministrativo.Empleado = mIncautacion.Administrativo
        Me.CtlBuscaFedatario.Empleado = mIncautacion.Fedatario
        Me.txtNumero.Text = mIncautacion.Incaut_Numero
        Me.dtpFecha.Value = mIncautacion.Incaut_Fecha
        Me.txtObservacion.Text = mIncautacion.Incaut_Observaciones
        Me.txtTenedorNombre.Text = mIncautacion.Incaut_TenedorNombre
        Me.txtCedula.Text = mIncautacion.Incaut_TenedorCI
        'Me.CtlIdentificacion1.Identificacion.Identi_Numero = mIncautacion.Incaut_TenedorCI
        'mSucursal.Empres_Codigo = mIncautacion.Empres_Codigo

        'Me.CtlIdentificacion1.Entidad = mContribuyente.Entidad
        'Me.CtlIdentificacion1.TipoIdentificacion = Enumerados.enumTipoIdentificacion.Cedula

        'bsResoluciones.DataSource = GetType(IncautacionResolucionList)
        Me.bsResoluciones.DataSource = mIncautacion.IncautacionResoluciones
        'MessageBox.Show("resoluciones" + mIncautacion.IncautacionResoluciones.Count.ToString)
        Me.dgResoluciones.AutoDiscover()

    End Sub
#End Region

#Region "Cerrar y Cancelar"
    Private Sub FrmMantenimientoItem_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Cancelar_Nuevo()
    End Sub

    Private Function Cancelar_Nuevo() As Boolean
        Dim _esnuevo As Boolean = mIncautacion.EsNuevo
        If _esnuevo AndAlso Incautaciones.Current IsNot Nothing Then
            Incautaciones.RemoveCurrent()
        End If
        Return _esnuevo
    End Function
#End Region

#Region "Incautaciones eventos"
    Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
        Dim _Incautacion As Reglas.Incautacion = New Reglas.Incautacion(Sistema.OperadorDatos, True)
        e.NewObject = _Incautacion
    End Sub

    Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
        llenar_datos()
    End Sub
#End Region

#Region "Guardar y Eliminar"
    Private Sub FrmMantenimientoItem_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
        e.Cancel = Not Guardar_datos()
    End Sub

    Private Sub Mapear_datos()
        mIncautacion.Contribuyente = Me.CtlBuscaContribuyente1.Contribuyente
        mIncautacion.Administrativo = Me.CtlBuscaAdministrativo.Empleado
        mIncautacion.Fedatario = Me.CtlBuscaFedatario.Empleado
        mIncautacion.Incaut_Numero = Me.txtNumero.Text
        mIncautacion.Incaut_Observaciones = Me.txtObservacion.Text
        mIncautacion.Incaut_Fecha = Me.dtpFecha.Value
        mIncautacion.Incaut_TenedorNombre = Me.txtTenedorNombre.Text
        mIncautacion.Incaut_TenedorCI = Me.txtCedula.Text
        mIncautacion.Empres_Codigo = Sucursal.Empresa.Empres_Codigo
        'mIncautacion.Empres_Codigo = mSucursal.Empresa.Empres_Codigo
    End Sub

    Private Function Guardar_datos() As Boolean
        Try
            Mapear_datos()
            Dim _esnuevo As Boolean = mIncautacion.EsNuevo
            If Not mIncautacion.Guardar() Then
                Throw New Exception
            End If

            Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mIncautacion.Incaut_Numero)


            llenar_datos()
            Return True
        Catch ex As Exception
            MsgBox("No se puede guardar la incautacion" & Environment.NewLine & Sistema.OperadorDatos.MsgError & ". " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub FrmMantenimientoItem_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
        If mIncautacion.Eliminar() AndAlso Incautaciones.Current IsNot Nothing Then
            Incautaciones.RemoveCurrent()
            Me.Close()
        Else
            'MyBase.BindingSource1.CancelEdit()
            MsgBox("No se puede eliminar Item" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        End If
    End Sub
#End Region

#Region "Mover"
    Private Sub FrmMantenimientoItem_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoItem_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoItem_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoItem_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
        e.Cancel = Cancelar_Nuevo()
    End Sub
#End Region



#Region "New"
    'Private mSucursal As Sucursal

    Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListaIncautaciones)
        MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        FrmMantenimientoIncautacion_Inicializar(Me, Nothing)
    End Sub

    Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListaIncautaciones)
        Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
    End Sub

    Private Sub FrmMantenimientoIncautacion_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
        'ToolStripManager.Merge(Me.ToolStrip2, Me.ToolStrip1)
        'Me.ToolStrip2.Visible = False

        MyBase.Tabla = "Incautacion"

        Me.CtlBuscaContribuyente1.OperadorDatos = Sistema.OperadorDatos
        Me.CtlBuscaContribuyente1.Llenar_Datos()

        Me.CtlBuscaAdministrativo.OperadorDatos = Sistema.OperadorDatos
        Me.CtlBuscaAdministrativo.Llenar_Datos()

        Me.CtlBuscaFedatario.OperadorDatos = Sistema.OperadorDatos
        Me.CtlBuscaFedatario.Llenar_Datos()



        'Me.CtlIdentificacion1.Llenar_datos()

        
    End Sub

#End Region

    Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.BindingSource1 = Nothing
    End Sub

    'Private Sub AbrirElemento(ByVal _fila As DataRow)
    '    If CInt(_fila(0)) = 0 Then
    '        Exit Sub
    '    End If

    '    Dim _mov As MovimientoInventario
    '    _mov = New MovimientoInventario(mSucursal, CType(_fila(0), Enumerados.enumTipoMovInv), CInt(_fila(2)))
    '    Dim f As New FrmMantenimientoMovimientoInventario(Me.Sistema, Enumerados.EnumOpciones.MovimientoInventario, mSucursal, Nothing)
    '    f.MovimientoInventario = _mov
    '    'f.Restriccion = mRestricciones.Buscar(mOpcionActual)
    '    f.ShowDialog()
    '    f.Dispose()
    'End Sub


    'Private Sub KardexIndividualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.ReportesInventario)
    '    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "proc_Kardex_Individual")
    '    f.Valores = New Object() {Now.AddMonths(-1).Date, Now.Date, Item.Item_Codigo, mSucursal.Empres_Codigo, mSucursal.Sucurs_Codigo}
    '    f.objAbrirElemento = New Infoware.Reporteador.FrmLista.AbrirElemento(AddressOf AbrirElemento)
    '    f.ShowDialog()
    'End Sub

    'Private Sub ComponentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.ReportesInventario)
    '    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "proc_Componentes_Ensamblados")
    '    f.Valores = New Object() {Item.Item_Codigo, mSucursal.Empres_Codigo}
    '    f.objAbrirElemento = New Infoware.Reporteador.FrmLista.AbrirElemento(AddressOf AbrirElemento)
    '    f.ShowDialog()
    'End Sub



    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim _itemdetalle As New ItemDetalle(mItem, True)
        '_itemdetalle.Sucursal = mSucursal
        'CType(BSDetallesCombo.DataSource, ItemDetalleList).Add(_itemdetalle)
        'BSDetallesCombo.MoveLast()

        'Dim f As New FrmMantenimientoItemDetalle(Sistema, Enumerados.EnumOpciones.ListadoItems, mSucursal)
        'f.RegistroAceptado = False
        'f.Item = mItem
        'f.ItemDetalles = Me.BSDetallesCombo
        'f.ShowDialog()
        'If BSDetallesCombo.Count <= 1 Then
        '    Me.DGDetallesCombo.AutoDiscover()
        'End If
        'Me.DGDetallesCombo.Invalidate()
        'f.Dispose()
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim f As New FrmMantenimientoItemDetalle(Sistema, Enumerados.EnumOpciones.ListadoItems, mSucursal)
        'f.RegistroAceptado = True
        'f.Item = mItem
        'f.ItemDetalles = Me.BSDetallesCombo
        'f.ShowDialog()
        'If BSDetallesCombo.Count <= 1 Then
        '    Me.DGDetallesCombo.AutoDiscover()
        'End If
        'Me.DGDetallesCombo.Invalidate()
        'f.Dispose()
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If BSDetallesCombo.Current Is Nothing Then
        '    Exit Sub
        'End If
        'mItem.DetallesComboEliminados.Add(BSDetallesCombo.Current)
        'BSDetallesCombo.RemoveCurrent()
    End Sub

#Region "IncautacionResoluciones"

    Private Sub btnnuevaResol_Click(sender As System.Object, e As System.EventArgs) Handles btnnuevaResol.Click
        If mIncautacion.EsNuevo Then
            MessageBox.Show("Primero debe guardar la incautación.")
            Exit Sub
        End If

        bsResoluciones.AddNew()

        'Dim _IncautacionResolucion As New IncautacionResolucion(mIncautacion, True)
        ' ''_itemdetalle.Sucursal = mSucursal
        'CType(bsResoluciones.DataSource, IncautacionResolucionList).Add(_IncautacionResolucion)
        'bsResoluciones.MoveLast()

        Dim f As New FrmMantenimientoIncautacionResolucion(Sistema, Enumerados.EnumOpciones.Resolucion)
        'f.RegistroAceptado = False
        f.Incautacion = Incautacion
        'f.IncautacionResolucion = _IncautacionResolucion
        f.IncautacionResoluciones = Me.bsResoluciones
        f.ShowDialog()
        If bsResoluciones.Count >= 1 Then
            Me.dgResoluciones.AutoDiscover()
        End If
        Me.dgResoluciones.Invalidate()
        f.Dispose()

        'Me.bsResoluciones.AddNew()

        'Dim f As New FrmMantenimientoIncautacionResolucion(Sistema, Enumerados.EnumOpciones.Resolucion)
        'f.IncautacionResoluciones = Me.bsResoluciones
        'f.ShowDialog()
        'Me.dgResoluciones.AutoDiscover()
    End Sub

#End Region
    'Public Event Repetido As EventHandler

    'Private Sub CtlIdentificacion1_Repetido(ByVal sender As Object, ByVal e As System.EventArgs)  ', CtlIdentificacion2.Repetido, CtlIdentificacion3.Repetido, CtlIdentificacion4.Repetido, CtlIdentificacion5.Repetido
    '    Dim _ident As CtlIdentificacion
    '    _ident = CType(sender, CtlIdentificacion)
    '    If MsgBox(String.Format("La identificación {0} con número {1} ya está registrada a nombre de {2}. ¿Desea recargar la información de esa persona?", _ident.Identificacion.PardetTipoIdent.Pardet_Descripcion, _ident.Identificacion.Identi_Numero, _ident.EntidadRepetido.NombreCompleto), MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
    '        Contribuyente.Entidad = _ident.EntidadRepetido
    '        RaiseEvent Repetido(sender, e)
    '    End If
    'End Sub

    Private Sub Entdat_DescripcionTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedula.Validated
        If Not Me.txtCedula.Text.Trim = String.Empty Then
            Dim _ident As String = Me.txtCedula.Text.Trim
            If (_ident.Length = 10) Then
                Dim suma As Integer = 0
                Dim coeficientes As String
                Dim modulo As Integer
                Dim tiporuc As String

                tiporuc = "RUC/Cédula para personas naturales"
                coeficientes = "212121212"
                modulo = 10


                For t As Integer = 1 To coeficientes.Length
                    Dim res As Integer = 0
                    res = CInt(_ident.Substring(t - 1, 1)) * CInt(coeficientes.Substring(t - 1, 1))
                    If res > 9 Then
                        res = CInt(res.ToString.Substring(0, 1)) + CInt(res.ToString.Substring(1, 1))
                    End If
                    suma += res
                Next

                Dim verificador As Integer = 0
                Dim residuo As Integer = (suma - Math.Floor(suma / modulo) * modulo)
                If residuo = 0 Then
                    verificador = 0
                Else
                    verificador = 10 - residuo
                End If
                If Not CInt(_ident.Substring(coeficientes.Length, 1)) = verificador Then
                    MsgBox(String.Format("El {0} es inválido", tiporuc), MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("El número de identificación no tiene la longitud esperada", MsgBoxStyle.Critical, "Error")
            End If

        End If
    End Sub


End Class
