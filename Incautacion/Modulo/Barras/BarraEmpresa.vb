Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class BarraEmpresa
  Inherits System.Windows.Forms.ToolStrip

#Region "New"
  Sub New()
    MyBase.New()

    'LblEmpresa = New System.Windows.Forms.ToolStripLabel
    cboempresa = New System.Windows.Forms.ToolStripComboBox
    'SepEmpresa = New System.Windows.Forms.ToolStripSeparator
    'LblSucursal = New System.Windows.Forms.ToolStripLabel
    cbosucursal = New System.Windows.Forms.ToolStripComboBox
    'SepSucursal = New System.Windows.Forms.ToolStripSeparator
    'LblRegContable = New System.Windows.Forms.ToolStripLabel
    'cboRegContable = New System.Windows.Forms.ToolStripComboBox
    'btnaddregcont = New System.Windows.Forms.ToolStripButton

    '
    'ToolStripLabel1
    '
    'Me.LblEmpresa.Name = "ToolStripLabel1"
    'Me.LblEmpresa.Size = New System.Drawing.Size(48, 22)
    'Me.LblEmpresa.Text = "Empresa"
    '
    'cboempresa
    '
    Me.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboempresa.Name = "cboempresa"
    Me.cboempresa.Size = New System.Drawing.Size(121, 25)
    Me.cboempresa.MergeAction = MergeAction.Insert
    Me.cboempresa.MergeIndex = 5

    Me.cbosucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbosucursal.Name = "cboSucursal"
    Me.cbosucursal.Size = New System.Drawing.Size(121, 25)
    Me.cbosucursal.MergeAction = MergeAction.Insert
    Me.cbosucursal.MergeIndex = 6

    'Me.cboRegContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    'Me.cboRegContable.Name = "cboregcont"
    'Me.cboRegContable.Size = New System.Drawing.Size(121, 25)
    'Me.cboRegContable.MergeAction = MergeAction.Insert
    'Me.cboRegContable.MergeIndex = 7
    '
    'btnaddregcont
    '
    'Me.btnaddregcont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    'Me.btnaddregcont.Image = My.Resources.Resources.insert16
    'Me.btnaddregcont.ImageTransparentColor = System.Drawing.Color.Magenta
    'Me.btnaddregcont.Name = "btnaddregcont"
    'Me.btnaddregcont.Size = New System.Drawing.Size(23, 22)
    'Me.btnaddregcont.Text = "ToolStripButton1"

    'Me.Items.AddRange(New System.Windows.Forms.ToolStripItem() {LblEmpresa, cboempresa, SepEmpresa, LblSucursal, cbosucursal, SepSucursal, LblRegContable, cboRegContable, btnaddregcont})
    Me.Items.AddRange(New System.Windows.Forms.ToolStripItem() {cboempresa, cbosucursal}) 'cboRegContable
  End Sub
#End Region

#Region "Componentes"
  'Friend WithEvents LblEmpresa As System.Windows.Forms.ToolStripLabel
  Friend WithEvents cboempresa As System.Windows.Forms.ToolStripComboBox
  'Friend WithEvents SepEmpresa As System.Windows.Forms.ToolStripSeparator
  'Friend WithEvents LblSucursal As System.Windows.Forms.ToolStripLabel
  Friend WithEvents cbosucursal As System.Windows.Forms.ToolStripComboBox
  'Friend WithEvents SepSucursal As System.Windows.Forms.ToolStripSeparator
  'Friend WithEvents LblRegContable As System.Windows.Forms.ToolStripLabel
  'Friend WithEvents cboRegContable As System.Windows.Forms.ToolStripComboBox
  'Friend WithEvents btnaddregcont As System.Windows.Forms.ToolStripButton
#End Region

  Private mSistema As Sistema
  Public Property Sistema() As Sistema
    Get
      Return mSistema
    End Get
    Set(ByVal value As Sistema)
      mSistema = value
      If value IsNot Nothing Then
        Llenar_datos()
      End If
    End Set
  End Property

#Region "Empresa"
  Private mEmpresas As EmpresaList = Nothing

  Public Property Empresa() As Empresa
    Get
      Try
        Return mEmpresas(Me.cboempresa.ComboBox.SelectedIndex)
      Catch ex As Exception
        Return Nothing
      End Try
    End Get
    Set(ByVal value As Empresa)
      Me.cboempresa.SelectedItem = value
    End Set
  End Property

  Private mEmpresaVisible As Boolean = True
  Public Property EmpresaVisible() As Boolean
    Get
      Return mEmpresaVisible
    End Get
    Set(ByVal value As Boolean)
      mEmpresaVisible = value
      SucursalVisible = value
      Me.cboempresa.Visible = mEmpresaVisible
    End Set
  End Property
#End Region

#Region "Sucursal"
  Private mSucursals As SucursalList = Nothing

  Public Property Sucursal() As Sucursal
    Get
      Try
        Return mSucursals(Me.cbosucursal.ComboBox.SelectedIndex)
      Catch ex As Exception
        Return Nothing
      End Try
    End Get
    Set(ByVal value As Sucursal)
      Me.cbosucursal.SelectedItem = value
    End Set
  End Property

  Private mSucursalVisible As Boolean = True
  Public Property SucursalVisible() As Boolean
    Get
      Return mSucursalVisible
    End Get
    Set(ByVal value As Boolean)
      mSucursalVisible = value
      If value Then
        mEmpresaVisible = value
      End If
      Me.cbosucursal.Visible = mSucursalVisible
    End Set
  End Property
#End Region

  '#Region "RegistroContable"
  '  Private mRegistroContables As RegistroContableList = Nothing

  '  Public Property RegistroContable() As RegistroContable
  '    Get
  '      Try
  '        Return mRegistroContables(Me.cboRegContable.ComboBox.SelectedIndex)
  '      Catch ex As Exception
  '        Return Nothing
  '      End Try
  '    End Get
  '    Set(ByVal value As RegistroContable)
  '      Me.cboRegContable.SelectedItem = value
  '    End Set
  '  End Property

  '  Private mRegContableVisible As Boolean = True
  '  Public Property RegContableVisible() As Boolean
  '    Get
  '      Return mRegContableVisible
  '    End Get
  '    Set(ByVal value As Boolean)
  '      mRegContableVisible = value
  '      Me.cboRegContable.Visible = mRegContableVisible
  '    End Set
  '  End Property
  '#End Region

  Private mEstaLlenando As Boolean = False
  Public Sub Llenar_datos()
    mEstaLlenando = True
    mEmpresas = EmpresaList.ObtenerLista(mSistema.OperadorDatos)
    Me.cboempresa.ComboBox.DisplayMember = "NombreCompleto"
    Me.cboempresa.ComboBox.ValueMember = "Empres_Codigo"
    Me.cboempresa.ComboBox.DataSource = mEmpresas

    'mRegistroContables = RegistroContableList.ObtenerLista(mSistema.OperadorDatos)
    'Me.cboRegContable.ComboBox.DisplayMember = "Descripcion"
    'Me.cboRegContable.ComboBox.ValueMember = "RegCtb_Secuencia"
    'Me.cboRegContable.ComboBox.DataSource = mRegistroContables

    Try
      Me.cboempresa.SelectedIndex = My.Settings.empresaactual
    Catch ex As Exception
    End Try

    Try
      Me.cbosucursal.SelectedIndex = My.Settings.sucursalactual
    Catch ex As Exception
    End Try

    'Try
    '  Me.cboRegContable.SelectedIndex = My.Settings.regcontableactual
    'Catch ex As Exception
    'End Try
    mEstaLlenando = False
  End Sub

  Public Event CambioDatos As EventHandler

  Private Sub cboempresa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboempresa.SelectedIndexChanged
    mSucursals = SucursalList.ObtenerLista(Empresa)
    Me.cbosucursal.ComboBox.DisplayMember = "NombreCompleto"
    Me.cbosucursal.ComboBox.ValueMember = "Sucurs_Codigo"
    Me.cbosucursal.ComboBox.DataSource = mSucursals

    GuardarCambios()
  End Sub

  Private Sub cbosucursal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbosucursal.SelectedIndexChanged ', cboRegContable.SelectedIndexChanged
    GuardarCambios()
  End Sub

  Sub GuardarCambios()
    If mEstaLlenando Then
      Exit Sub
    End If
    My.Settings.empresaactual = Me.cboempresa.SelectedIndex
    My.Settings.sucursalactual = Me.cbosucursal.SelectedIndex
    'My.Settings.regcontableactual = Me.cboRegContable.SelectedIndex
    My.Settings.Save()
    RaiseEvent CambioDatos(Me, Nothing)
  End Sub

  Private Sub cboempresa_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboempresa.VisibleChanged
    'Me.LblEmpresa.Visible = Me.cboempresa.Visible
    'Me.SepEmpresa.Visible = Me.cboempresa.Visible
  End Sub

  Private Sub cbosucursal_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbosucursal.VisibleChanged
    'Me.LblSucursal.Visible = Me.cbosucursal.Visible
    'Me.SepSucursal.Visible = Me.cbosucursal.Visible
  End Sub

  'Private Sub cboRegContable_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRegContable.VisibleChanged
  '  'Me.LblRegContable.Visible = Me.cboRegContable.Visible
  '  'Me.btnaddregcont.Visible = Me.cboRegContable.Visible
  'End Sub
End Class
