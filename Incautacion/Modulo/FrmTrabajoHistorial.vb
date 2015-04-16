Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports Incautacion.Reglas

Public Class FrmTrabajoHistorial
  Public Property Trabajo As Trabajo
    Get
      Return Me.CtlTrabajoLog1.Trabajo
    End Get
    Set(ByVal value As Trabajo)
      Me.CtlTrabajoLog1.Trabajo = value
    End Set
  End Property

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Usuarios)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Forma_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.Usuarios)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Historial"
  End Sub
End Class