Imports Incautacion.Reglas

Public Class CtlTrabajoLog
  Inherits Infoware.Consola.Base.DataGridViewAutoDiscover

  Private mTrabajo As Trabajo = Nothing
  Public Property Trabajo As Trabajo
    Get
      Return mTrabajo
    End Get
    Set(ByVal value As Trabajo)
      mTrabajo = value
      If value IsNot Nothing Then
        Llenar_detalles()
      End If
    End Set
  End Property

#Region "Detalles"
  Private Sub Llenar_detalles()
    Me.BindingSourceDetalles.DataSource = GetType(TrabajoLogList)
    BindingSourceDetalles.DataSource = mTrabajo.TrabajoLogs

    Me.AutoDiscover()
    'MyBase.Columns.Clear()

    'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "PardetModuloString"
    'DataGridViewTextBoxColumn1.HeaderText = "Módulo"
    'DataGridViewTextBoxColumn1.Width = 120
    'DataGridViewTextBoxColumn1.ReadOnly = True
    'MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "PardetOpcionString"
    'DataGridViewTextBoxColumn1.HeaderText = "Opción"
    'DataGridViewTextBoxColumn1.Width = 180
    'DataGridViewTextBoxColumn1.ReadOnly = True
    'MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "Restri_Lectura"
    'DataGridViewTextBoxColumn0.HeaderText = "Lectura"
    'DataGridViewTextBoxColumn0.Width = 65
    'MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "Restri_Ingreso"
    'DataGridViewTextBoxColumn0.HeaderText = "Ingreso"
    'DataGridViewTextBoxColumn0.Width = 65
    'MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "Restri_Modificacion"
    'DataGridViewTextBoxColumn0.HeaderText = "Modificación"
    'DataGridViewTextBoxColumn0.Width = 65
    'MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "Restri_Eliminacion"
    'DataGridViewTextBoxColumn0.HeaderText = "Eliminación"
    'DataGridViewTextBoxColumn0.Width = 65
    'MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "Restri_Impresion"
    'DataGridViewTextBoxColumn0.HeaderText = "Impresión"
    'DataGridViewTextBoxColumn0.Width = 65
    'MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "Restri_VerConfidencial"
    'DataGridViewTextBoxColumn0.HeaderText = "Confidencial"
    'DataGridViewTextBoxColumn0.Width = 65
    'MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'If mUsuario.Restricciones.Count = 0 Then
    '  BindingSourceDetalles.AddNew()
    'End If
    'actualizar_totales()
  End Sub
#End Region


  Private WithEvents BindingSourceDetalles As BindingSource

  Public Sub New()
    BindingSourceDetalles = New BindingSource
    MyBase.DataSource = BindingSourceDetalles
    MyBase.AutoGenerateColumns = False
    MyBase.AllowUserToAddRows = False
    MyBase.AllowUserToDeleteRows = False
    MyBase.ReadOnly = True

    'Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
    Me.RowHeadersVisible = False
  End Sub
End Class
