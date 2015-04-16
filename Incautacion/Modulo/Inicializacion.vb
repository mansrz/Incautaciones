Imports System.Windows.Forms
Imports Infoware.Consola.Base
Imports Incautacion.Reglas
Imports System.IO

Public Class Inicializacion
  Implements Infoware.Consola.Base.IAplicacion

  Public Shared Sub main()
    'ejecutar ica
    Dim RutaICA As String = LeerClave()

    If Not My.Computer.FileSystem.FileExists(RutaICA) Then
      If MsgBox("No se pudo encontrar el Infoware.Consola.Administrator, ¿Desea encontrarlo usted mismo?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
        Dim ofd As New OpenFileDialog
        ofd.Filter = "ICA (Infoware.Consola.Administrativa.exe)|Infoware.Consola.Administrativa.exe|Todos los archivos (*.*)|*.*"

        If ofd.ShowDialog = DialogResult.OK Then
          RutaICA = ofd.FileName
          GuardarClave(RutaICA)
          My.Settings.Save()
        Else
          End
        End If
      Else
        MsgBox("Debe instalar el Infoware.Consola.Adminitrator antes de poder utilizar el sistema", MsgBoxStyle.Exclamation, "Información")
        End
      End If
    End If
    Dim mProcess As System.Diagnostics.Process
    mProcess = New System.Diagnostics.Process
    mProcess.StartInfo.FileName = RutaICA
    mProcess.StartInfo.Arguments = String.Format("""{0}""", System.Reflection.Assembly.GetExecutingAssembly.Location)
    'mProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
    mProcess.EnableRaisingEvents = False

    mProcess.Start()
    End
    'mProcess.WaitForExit()
    'Do
    '  If Not mProcess.HasExited Then
    '  End If
    'Loop While Not mProcess.WaitForExit(1000)
  End Sub

  Public Shared Sub GuardarClave(ByVal valor As String)
    Dim mDirectorioRaiz = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Integra2b")
    Dim mDirectorioConfig = System.IO.Path.Combine(mDirectorioRaiz, "Configuracion")

    My.Computer.FileSystem.CreateDirectory(mDirectorioRaiz)
    My.Computer.FileSystem.CreateDirectory(mDirectorioConfig)

    Dim configFile As String
    configFile = Path.Combine(mDirectorioConfig, "Link.config")

    My.Computer.FileSystem.WriteAllText(configFile, valor, False)
  End Sub

  Public Shared Function LeerClave() As String
    Dim mDirectorioRaiz = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Integra2b")
    Dim mDirectorioConfig = System.IO.Path.Combine(mDirectorioRaiz, "Configuracion")

    My.Computer.FileSystem.CreateDirectory(mDirectorioRaiz)
    My.Computer.FileSystem.CreateDirectory(mDirectorioConfig)

    Dim configFile As String
    configFile = Path.Combine(mDirectorioConfig, "Link.config")

    Dim result As String = ""
    Try
      result = My.Computer.FileSystem.ReadAllText(configFile)
    Catch ex As Exception

    End Try

    Return result
  End Function

  Public Function Validacion(ByVal _Usuario As Infoware.Reglas.General.Usuario) As Boolean Implements Infoware.Consola.Base.IAplicacion.Validacion
    Dim _parametrodet As New Infoware.Reglas.General.ParametroDet(_Usuario.OperadorDatos, 5, 1)
    If Not _parametrodet.Pardet_Descripcion = "Colorama" Then
      MsgBox("Base de datos no compatible con esta aplicación")
      Return False
    End If
    _parametrodet = New Infoware.Reglas.General.ParametroDet(_Usuario.OperadorDatos, 1, 1)
    If Not _parametrodet.Pardet_DatoStr1 >= "1.0" Then
      MsgBox("Versión de base de datos debe actualizarse")
      Return False
    End If
    Return True
  End Function

  Public Function CargarListaGrupoOpciones(ByVal _Sistema As Infoware.Consola.Base.Sistema) As System.Collections.Generic.List(Of Infoware.Consola.Base.GrupoOpcion) Implements Infoware.Consola.Base.IAplicacion.CargarListaGrupoOpciones
    Dim _grupos As New List(Of GrupoOpcion)

    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Empresa) Then
      _grupos.AddRange(New Loader().CargarModuloEmpresa(_Sistema))
    End If

    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Inventario) Then
      _grupos.AddRange(New Loader().CargarModuloInventario(_Sistema))
    End If

    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Cuentas) Then
      _grupos.AddRange(New Loader().CargarModuloCuentas(_Sistema))
    End If

    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Reporteador) Then
      _grupos.AddRange(New Loader().CargarModuloReporteador(_Sistema))
    End If

    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Seguridad) Then
      _grupos.AddRange(New Loader().CargarModuloSeguridad(_Sistema))
    End If

    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Configuracion) Then
      _grupos.AddRange(New Loader().CargarModuloConfiguracion(_Sistema))
    End If

    Return _grupos
  End Function
End Class
