Imports System.Windows.Forms.SendKeys
Imports Infoware.Datos
Imports Infoware.Consola.Base

Imports Incautacion.Reglas

Public Class CtlBuscaContribuyente
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
                Llenar_Datos()
            End If
        End Set
    End Property

    Sub Llenar_Datos()
        Me.ComboBox1.DisplayMember = "NombreCompleto"
        Me.ComboBox1.ValueMember = "Entida_Codigo"
        mContribuyentes = ContribuyenteList.ObtenerLista(mOperadorDatos)
        Me.ComboBox1.DataSource = mContribuyentes
    End Sub

    Public Property ItemText() As String
        Get
            Return Me.btn_Item.Text
        End Get
        Set(ByVal value As String)
            Me.btn_Item.Text = value
        End Set
    End Property

    Private mContribuyentes As ContribuyenteList = Nothing
    <System.ComponentModel.Browsable(False)> _
    Public Property Contribuyente() As Contribuyente
        Get
            If Me.ComboBox1.SelectedIndex = -1 Then
                Return Nothing
            Else
                Return mContribuyentes(Me.ComboBox1.SelectedIndex)
            End If
        End Get
        Set(ByVal value As Contribuyente)
            If value Is Nothing Then
                If mContribuyentes IsNot Nothing AndAlso mContribuyentes.Count > 0 Then
                    Me.ComboBox1.SelectedIndex = 0
                    cambiar_item()
                End If
            Else
                Me.ComboBox1.SelectedValue = value.Entida_Codigo
            End If
        End Set
    End Property

    Private Sub btn_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Item.Click, BuscarToolStripMenuItem.Click
        abrir_consulta()
    End Sub

    Private Sub abrir_consulta(Optional ByVal filtro As String = "")

    Dim f As New FrmListaContribuyentes(Sistema, Enumerados.EnumOpciones.ListadoContribuyentes, True)
        f.Contribuyente = Contribuyente
        f.Filtro = filtro
        If f.ShowDialog() = DialogResult.OK Then
            Llenar_Datos()
            Contribuyente = f.Contribuyente
            RaiseEvent CambioItem(Me, Nothing)
        End If
    End Sub

    Public Property ContribuyenteText() As String
        Get
            Return Me.btn_Item.Text
        End Get
        Set(ByVal value As String)
            Me.btn_Item.Text = value
        End Set
    End Property

    Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
        Contribuyente = Nothing
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
        cambiar_item()
    End Sub

    Private Sub cambiar_item()
        If Me.ComboBox1.SelectedIndex >= 0 AndAlso mContribuyentes IsNot Nothing Then
            Contribuyente = mContribuyentes(Me.ComboBox1.SelectedIndex)
            RaiseEvent CambioItem(Me, Nothing)
        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Abrir_Mantenimiento()
    End Sub

    Sub Abrir_Mantenimiento()
        Dim f As New FrmMantenimientoContribuyente(Sistema, Enumerados.EnumOpciones.ListadoContribuyentes)
        f.Contribuyente = New Contribuyente(Sistema.OperadorDatos, True)
        f.ShowDialog()

        If f.Contribuyente IsNot Nothing AndAlso Not f.Contribuyente.EsNuevo Then
            Llenar_Datos()
            Me.ComboBox1.SelectedValue = f.Contribuyente.Entida_Codigo
        End If

        f.Dispose()
    End Sub
End Class
