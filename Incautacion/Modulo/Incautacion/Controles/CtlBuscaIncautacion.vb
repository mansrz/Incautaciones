Imports System.Windows.Forms.SendKeys
'Imports Infoware.Reglas.General

'Imports WWTS.Inventario.Reglas
Imports Infoware.Consola.Base
Imports Infoware.Datos
Imports Incautacion.Reglas

Public Class CtlBuscaIncautacion
    Public ReadOnly Property Sistema() As Sistema
        Get
            Return CType(Me.ParentForm, FrmFormaBase).Sistema
        End Get
    End Property

    Public Enum EnumUbicacion
        Normal = 0
        Abajo = 1
    End Enum
    Private mUbicacion As EnumUbicacion = EnumUbicacion.Normal
    Public Property Ubicacion() As EnumUbicacion
        Get
            Return mUbicacion
        End Get
        Set(ByVal value As EnumUbicacion)
            mUbicacion = value
            Select Case mUbicacion
                Case EnumUbicacion.Normal
                    Me.ComboBox1.Location = New Point(124, 0)
                    Me.ComboBox1.Size = New Size(Me.Width - 124, 23)
                Case EnumUbicacion.Abajo
                    Me.ComboBox1.Location = New Point(0, 24)
                    Me.ComboBox1.Size = New Size(Me.Width, 23)
            End Select
        End Set
    End Property
    Public Event CambioItem As EventHandler

    

    Private mOperadorDatos As OperadorDatos = Nothing
    Public WriteOnly Property OperadorDatos() As OperadorDatos
        Set(ByVal value As OperadorDatos)
            mOperadorDatos = value

            If value IsNot Nothing Then
                'llenar_datos()
            End If
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

    Private mSucursal As Sucursal = Nothing
    Public Property Sucursal() As Sucursal
        Get
            Return mSucursal
        End Get
        Set(ByVal value As Sucursal)
            mSucursal = value
            'If value IsNot Nothing Then
            '    llenar_datos()
            'End If
        End Set
    End Property

    Private mEstaCargando = False

    Sub llenar_datos()
        MsgBox("voy a llenar lista incautaciones")
        mIncautaciones = IncautacionList.ObtenerLista(mSucursal.Empresa, mContribuyente)
        MsgBox("llene lista incautaciones")
        Me.ComboBox1.DisplayMember = "Incaut_Numero"
        Me.ComboBox1.ValueMember = "Incaut_Codigo"


        mEstaCargando = True
        Me.ComboBox1.DataSource = mIncautaciones
        Me.ComboBox1.SelectedIndex = -1
        mEstaCargando = False
    End Sub

    Public Property IncautacionText() As String
        Get
            Return Me.btn_Incautacion.Text
        End Get
        Set(ByVal value As String)
            Me.btn_Incautacion.Text = value
        End Set
    End Property

    'Private mPardetTipoInventario As WWTSParametroDet = Nothing
    'Public Property PardetTipoInventario As WWTSParametroDet
    '    Get
    '        Return mPardetTipoInventario
    '    End Get
    '    Set(ByVal value As WWTSParametroDet)
    '        mPardetTipoInventario = value
    '    End Set
    'End Property

    Private mIncautaciones As IncautacionList = Nothing
    <System.ComponentModel.Browsable(False)> _
    Public Property Incautacion() As Reglas.Incautacion
        Get
            If Me.ComboBox1.SelectedIndex = -1 Then
                Return Nothing
            Else
                Return mIncautaciones(Me.ComboBox1.SelectedIndex)
            End If
        End Get
        Set(ByVal value As Reglas.Incautacion)
            If value Is Nothing Then
                'If Not Me.ComboBox1.SelectedIndex = -1 Then
                '    Me.ComboBox1.SelectedIndex = -1
                'End If
                If mIncautaciones IsNot Nothing AndAlso mIncautaciones.Count > 0 Then
                    Me.ComboBox1.SelectedIndex = 0
                    cambiar_item()
                End If
            Else
                Me.ComboBox1.SelectedValue = value.Incaut_Codigo
            End If
        End Set
    End Property

    Private Sub btn_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Incautacion.Click, BuscarToolStripMenuItem.Click, btn_Incautacion.Click
        abrir_consulta()
    End Sub

    Private Sub abrir_consulta(Optional ByVal filtro As String = "")
        Dim f As New FrmListaIncautacion(CType(Me.ParentForm, FrmFormaBase).Sistema, Enumerados.EnumOpciones.ListaIncautaciones, False, mContribuyente, mSucursal, True)
        f.Contribuyente = Contribuyente
        f.Incautacion = Incautacion
        f.Sucursal = Sucursal

        MessageBox.Show("sucursal en busca " + Sucursal.NombreCompleto)

        f.Filtro = filtro

        If f.ShowDialog() = DialogResult.OK Then
            llenar_datos()
            Incautacion = f.Incautacion
            RaiseEvent CambioItem(Me, Nothing)
        End If
        
    End Sub

    Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
        Incautacion = Nothing
        RaiseEvent CambioItem(Me, Nothing)
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.ComboBox1.SelectedIndex = -1 Then
                abrir_consulta(Me.ComboBox1.Text)
            End If
            Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Not mEstaCargando Then
            cambiar_item()
        End If
    End Sub

    Private Sub cambiar_item()
        If Me.ComboBox1.SelectedIndex >= 0 AndAlso mIncautaciones IsNot Nothing Then
            Incautacion = mIncautaciones(Me.ComboBox1.SelectedIndex)
            RaiseEvent CambioItem(Me, Nothing)
        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Abrir_Mantenimiento()
    End Sub

    Sub Abrir_Mantenimiento()
        Dim _nuevaIncaut As New Reglas.Incautacion(Sistema.OperadorDatos, True)

        _nuevaIncaut.Contribuyente = Contribuyente

        If Me.ComboBox1.SelectedIndex = -1 Then
            _nuevaIncaut.Incaut_Numero = Me.ComboBox1.Text
        End If

        Dim f As New FrmMantenimientoIncautacion(Sistema, Enumerados.EnumOpciones.ListaIncautaciones)
        f.Contribuyente = Contribuyente
        f.Incautacion = _nuevaIncaut
        f.Sucursal = Sucursal
        f.ShowDialog()

        If f.Incautacion IsNot Nothing AndAlso Not f.Incautacion.EsNuevo Then
            llenar_datos()
            Me.ComboBox1.SelectedValue = f.Incautacion.Incaut_Codigo
        End If

        f.Dispose()
    End Sub
End Class
