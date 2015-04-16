Imports System.Windows.Forms.SendKeys

Imports Incautacion.Reglas

'Imports WWTS.Contabilidad.Reglas

Public Class CtlCuentaBancaria
  Public Event CambioCuentaBancaria As EventHandler

  Private mEmpresa As Empresa = Nothing
  Public WriteOnly Property Empresa() As Empresa
    Set(ByVal value As Empresa)
      mEmpresa = value

      If value IsNot Nothing Then
        Me.ComboBoxParametroDet1.Parametro = Enumerados.EnumParametros.Banco
        Me.ComboBoxParametroDet1.OperadorDatos = value.OperadorDatos
        Me.ComboBoxParametroDet1.Llenar_Datos()

        Me.ComboBoxCuentaBancaria.DisplayMember = "CtaBan_Numero"
        Me.ComboBoxCuentaBancaria.ValueMember = "CtaBan_Numero"
      End If
    End Set
  End Property

  Private mCuentaBancarias As CuentaBancariaList = Nothing
  Private mCuentaBancaria As CuentaBancaria = Nothing
  <System.ComponentModel.Browsable(False)> _
  Public Property CuentaBancaria() As CuentaBancaria
    Get
      If mCuentaBancarias Is Nothing OrElse mCuentaBancarias.Count = 0 OrElse Me.ComboBoxCuentaBancaria.SelectedIndex = -1 Then
        Return Nothing
      Else
        Return mCuentaBancarias(ComboBoxCuentaBancaria.SelectedIndex)
      End If
    End Get
    Set(ByVal value As CuentaBancaria)
      If value Is Nothing Then
        ComboBoxCuentaBancaria.SelectedIndex = -1
      Else
        Me.ComboBoxParametroDet1.ParametroDet = value.PardetBanco
        ComboBoxCuentaBancaria.SelectedValue = value.CtaBan_Numero
      End If
    End Set
  End Property

  Sub llenar_datos()
    If Me.ComboBoxParametroDet1.ParametroDet Is Nothing OrElse mEmpresa Is Nothing Then
      Exit Sub
    End If
    mCuentaBancarias = CuentaBancariaList.ObtenerLista(mEmpresa, Me.ComboBoxParametroDet1.ParametroDet)
    Me.ComboBoxCuentaBancaria.DataSource = mCuentaBancarias
  End Sub

  Private Sub ComboBoxCuentaBancaria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxCuentaBancaria.KeyPress
    If e.KeyChar = vbCr AndAlso mCuentaBancaria IsNot Nothing Then
      Send("{TAB}")
      e.Handled = True
    Else
      MyBase.OnKeyPress(e)
    End If
  End Sub

  Private Sub ComboBoxCuentaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxCuentaBancaria.SelectedIndexChanged
    If Me.ComboBoxCuentaBancaria.SelectedIndex >= 0 AndAlso mCuentaBancarias IsNot Nothing Then
      RaiseEvent CambioCuentaBancaria(Me, Nothing)
    End If
  End Sub

  Private Sub ComboBoxParametroDet1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxParametroDet1.CambioItem
    llenar_datos()
  End Sub
End Class
