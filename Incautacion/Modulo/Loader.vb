Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports Incautacion.Reglas

Public Class Loader
#Region "Empresa"
  Function CargarModuloEmpresa(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
    Dim _grupos As New List(Of GrupoOpcion)
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Empresa) Then
      _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Empresa), CargarOpcionesEmpresa(_Sistema, False), CargarOpcionesEmpresa(_Sistema, True), CargarOpcionesEmpresaRep(_Sistema)))
    End If
    Return _grupos
  End Function

  Function CargarOpcionesEmpresa(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

    For Each _restriccion As Restriccion In _Sistema.Restricciones
      If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
        If _restriccion.Restri_Lectura Then
          Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
            Case Enumerados.EnumOpciones.Empresa
              If _restriccion.Restri_Ingreso Then
                                _opciones.Add(New Opcion(_restriccion, AddressOf CargarNuevaEmpresa, "Nueva Zona"))
              End If
            Case Enumerados.EnumOpciones.Empresa
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarEmpresa))
            Case Enumerados.EnumOpciones.Sucursal
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarListadoSucursales))
            Case Enumerados.EnumOpciones.ListadoClientes
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarListadoClientes))
            Case Enumerados.EnumOpciones.ListadoProveedores
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarListadoProveedores))
            Case Enumerados.EnumOpciones.ListadoContribuyentes
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarListadoContribuyentes))
            Case Enumerados.EnumOpciones.ListadoEmpleados
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarListadoEmpleados))
              'Case Enumerados.EnumOpciones.Venta
              '  _opciones.Add(New Opcion(_restriccion, AddressOf CargarVenta))
              'Case Enumerados.EnumOpciones.Pagos
              '  _opciones.Add(New Opcion(_restriccion, AddressOf CargarPagos))

          End Select
        End If
      End If
    Next
    Return _opciones
  End Function

    Function CargarOpcionesEmpresaRep(ByVal _Sistema As Sistema) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)
        '  For Each _restriccion As Restriccion In _Sistema.Restricciones
        '    If _restriccion.Restri_Lectura Then
        '      Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
        '        Case Enumerados.EnumOpciones.Reportes
        '          Dim _reportes As Infoware.Reporteador.ReporteList = Infoware.Reporteador.ReporteList.ObtenerLista(_Sistema.OperadorDatos, "REPC")

        '          For Each _reporte As Infoware.Reporteador.Reporte In _reportes
        '            _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporte, _reporte.NombreReporte, _reporte))
        '          Next

        '      End Select
        '    End If
        '  Next
        Return _opciones
    End Function

    Function CargarReporte(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New Infoware.Reporteador.FrmLista(_Sistema, _Restriccion)
        f.Reporte = _Opcion.Tag
        Return f
    End Function
    Function CargarEmpresa(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmMantenimientoEmpresa(_Sistema, _Restriccion, False)
        Return f
    End Function

    Function CargarNuevaEmpresa(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmMantenimientoEmpresa(_Sistema, _Restriccion, False)
        f.Empresa = New Empresa(_Sistema.OperadorDatos, True)
        Return f
    End Function

    Function CargarListadoSucursales(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaSucursales(_Sistema, _Restriccion, False, Nothing)
        Return f
    End Function

    Function CargarListadoClientes(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaClientes(_Sistema, _Restriccion, False)
        Return f
    End Function

    Function CargarListadoProveedores(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaProveedores(_Sistema, _Restriccion, False)
        Return f
    End Function

    Function CargarListadoContribuyentes(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaContribuyentes(_Sistema, _Restriccion, False)
        Return f
    End Function

    Function CargarListadoEmpleados(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaEmpleados(_Sistema, _Restriccion, False)
        Return f
    End Function

#End Region

#Region "Inventario"
    Function CargarModuloInventario(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
        Dim _grupos As New List(Of GrupoOpcion)
        If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Inventario) Then
            _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Inventario), CargarOpcionesInventario(_Sistema, False), CargarOpcionesInventario(_Sistema, True), CargarOpcionesInventarioFav(_Sistema)))
        End If
        Return _grupos
    End Function

    Function CargarOpcionesInventario(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)

        For Each _restriccion As Restriccion In _Sistema.Restricciones
            If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
                If _restriccion.Restri_Lectura Then
                    Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
                        Case Enumerados.EnumOpciones.AperturaSobre
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarAperturaCaso))
                        Case Enumerados.EnumOpciones.ProcesarSobre
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarProformarCaso))
                        Case Enumerados.EnumOpciones.ImprimirSobre
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarQuirofano))
                        Case Enumerados.EnumOpciones.FacturacionSobre
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarFacturarCaso))
                        Case Enumerados.EnumOpciones.EntregaSobre
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarCierreCaso))
                        Case Enumerados.EnumOpciones.ListaIncautaciones
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarListadoIncautaciones))
                        Case Enumerados.EnumOpciones.ListadoItems
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarListadoItems))
                        Case Enumerados.EnumOpciones.ListadoBodegas
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarListadoBodegas))
                        Case Enumerados.EnumOpciones.ListadoTiposPrecios
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarListadoTiposPrecios))
                        Case Enumerados.EnumOpciones.ListadoFormasPago
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarListadoFormasPago))
                        Case Enumerados.EnumOpciones.Secuenciales
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarSecuenciales))
                        Case Enumerados.EnumOpciones.SecuencialCompraVenta
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarSecuencialCompraVenta))
                        Case Enumerados.EnumOpciones.MovimientoInventario
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarMovimientoInventario))
                        Case Enumerados.EnumOpciones.UnidadMedidaConversion
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarUnidadMedidaConversion))
                        Case Enumerados.EnumOpciones.TPV
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarTPV))
                            'Case Enumerados.EnumOpciones.AsientosContablesInventario
                            '  _opciones.Add(New Opcion(_restriccion, AddressOf CargarAsientosContablesInventario))
                        Case Enumerados.EnumOpciones.ReportesInventario
                    End Select
                End If
            End If
        Next
        Return _opciones
    End Function

    Function CargarOpcionesInventarioFav(ByVal _Sistema As Sistema) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)

        For Each _restriccion As Restriccion In _Sistema.Restricciones
            If _restriccion.Restri_Lectura Then
                Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
                    Case Enumerados.EnumOpciones.ReportesInventario
                        Dim _reportes As Infoware.Reporteador.ReporteList = Infoware.Reporteador.ReporteList.ObtenerLista(_Sistema.OperadorDatos, "REPI")

                        For Each _reporte As Infoware.Reporteador.Reporte In _reportes
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporte, _reporte.NombreReporte, _reporte))
                        Next

                End Select
            End If
        Next
        Return _opciones
    End Function

    Function CargarAperturaCaso(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaTrabajos(_Sistema, _Restriccion, FrmListaTrabajos.enumTipoPresentacion.AperturaCaso, False)
        Return f
    End Function

    Function CargarFacturarCaso(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaTrabajos(_Sistema, _Restriccion, FrmListaTrabajos.enumTipoPresentacion.FacturarCaso, False)
        Return f
    End Function

    Function CargarProformarCaso(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaTrabajos(_Sistema, _Restriccion, FrmListaTrabajos.enumTipoPresentacion.ProformarCaso, False)
        Return f
    End Function

    Function CargarQuirofano(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaTrabajos(_Sistema, _Restriccion, FrmListaTrabajos.enumTipoPresentacion.Quirofano, False)
        Return f
    End Function

    Function CargarCierreCaso(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaTrabajos(_Sistema, _Restriccion, FrmListaTrabajos.enumTipoPresentacion.CierreCaso, False)
        Return f
    End Function

    Function CargarListadoIncautaciones(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaIncautacion(_Sistema, _Restriccion, False)
        Return f
    End Function

    Function CargarListadoItems(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaItems(_Sistema, _Restriccion, False)
        Return f
    End Function

    Function CargarListadoBodegas(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaBodegas(_Sistema, _Restriccion, False)
        Return f
    End Function

    Function CargarListadoTiposPrecios(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaParametroDets(_Sistema, _Restriccion, False)
        f.Parame_Codigo = Enumerados.EnumParametros.TipoPrecio
        Return f
    End Function

    Function CargarListadoFormasPago(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaParametroDets(_Sistema, _Restriccion, False)
        f.Parame_Codigo = Enumerados.EnumParametros.TipoFormaPago
        Return f
    End Function

    Function CargarSecuenciales(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaTipoMovimientoInventarios(_Sistema, _Restriccion, False)
        Return f
    End Function

    Function CargarSecuencialCompraVenta(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaTipoMovimientoCompraVentas(_Sistema, _Restriccion, False)
        Return f
    End Function

    Function CargarMovimientoInventario(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaMovimientosInventarios(_Sistema, _Restriccion, False, False)
        Return f
    End Function

    Function CargarUnidadMedidaConversion(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaUnidadMedidaConversiones(_Sistema, _Restriccion, False)
        Return f
    End Function

    Function CargarTPV(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim _usuario As WWTSUsuario
        _usuario = New WWTSUsuario(_Sistema.OperadorDatos, _Restriccion.Usuari_Codigo)
        If _usuario.Empleado Is Nothing Then
            MsgBox("No se puede relacionar el usuario actual con un vendedor", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End If
        Dim f As New FrmPuntodeVenta(_Sistema, _Restriccion, _usuario.Empleado)
        f.FullScreen = True
        Return f
        Return Nothing
    End Function

    'Function CargarAsientosContablesInventario(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    '  Dim f As New FrmAsientosAutomaticos(_Sistema, _Restriccion)
    '  Return f
    'End Function

#End Region

#Region "Cuentas"
    Function CargarModuloCuentas(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
        Dim _grupos As New List(Of GrupoOpcion)
        If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Cuentas) Then
            _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Cuentas), CargarOpcionesCuentas(_Sistema, False), CargarOpcionesCuentas(_Sistema, True), CargarOpcionesCuentasRep(_Sistema)))
        End If
        Return _grupos
    End Function

    Function CargarOpcionesCuentas(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)

        For Each _restriccion As Restriccion In _Sistema.Restricciones
            If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
                If _restriccion.Restri_Lectura Then
                    Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
                        Case Enumerados.EnumOpciones.ListadoClientes
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarListadoClientes))
                        Case Enumerados.EnumOpciones.ListadoProveedores
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarListadoProveedores))
                        Case Enumerados.EnumOpciones.MovimientoInventario
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarCuentas))
                        Case Enumerados.EnumOpciones.EstadoCuenta
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarEstadoCuenta))
                        Case Enumerados.EnumOpciones.AnalisisCartera
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarAnalisisCartera))
                        Case Enumerados.EnumOpciones.ReportesCuentas
                    End Select
                End If
            End If
        Next
        Return _opciones
    End Function

    Function CargarOpcionesCuentasRep(ByVal _Sistema As Sistema) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)

        For Each _restriccion As Restriccion In _Sistema.Restricciones
            If _restriccion.Restri_Lectura Then
                Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
                    Case Enumerados.EnumOpciones.ReportesCuentas
                        Dim _reportes As Infoware.Reporteador.ReporteList = Infoware.Reporteador.ReporteList.ObtenerLista(_Sistema.OperadorDatos, "REPC")

                        For Each _reporte As Infoware.Reporteador.Reporte In _reportes
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporte, _reporte.NombreReporte, _reporte))
                        Next

                End Select
            End If
        Next
        Return _opciones
    End Function

    'Function CargarMovimientoInventario(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    '  Dim f As New FrmListaParametroDets(_Sistema, _Restriccion, False)
    '  f.Parame_Codigo = Enumerados.EnumParametros.TipoPrecio
    '  Return f
    'End Function

    Function CargarCuentas(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaMovimientosInventarios(_Sistema, _Restriccion, False, True)
        f.SoloPendientes = True

        Return f
    End Function

    Function CargarEstadoCuenta(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmEstadoCuenta(_Sistema, _Restriccion)
        Return f
    End Function

    Function CargarAnalisisCartera(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmAnalisisCartera(_Sistema, _Restriccion)
        Return f
    End Function

#End Region

#Region "Reporteador"
    Function CargarModuloReporteador(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
        Dim _grupos As New List(Of GrupoOpcion)
        If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Reporteador) Then
            _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Reporteador), CargarOpcionesReporteador(_Sistema, False), CargarOpcionesReporteador(_Sistema, True), CargarOpcionesReporteadorRep(_Sistema)))
        End If
        Return _grupos
    End Function

    Function CargarOpcionesReporteador(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)

        For Each _restriccion As Restriccion In _Sistema.Restricciones
            If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
                If _restriccion.Restri_Lectura Then
                    Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
                        Case Enumerados.EnumOpciones.Reporteador
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporteador))
                        Case Enumerados.EnumOpciones.EmailAutomatico
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarEmailautomatico))
                    End Select
                End If
            End If
        Next
        Return _opciones
    End Function

    Function CargarOpcionesReporteadorRep(ByVal _Sistema As Sistema) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)
        Return _opciones
    End Function

    Function CargarReporteador(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmLista(_Sistema, _Restriccion, False)
        Return f
    End Function

    Function CargarEmailautomatico(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmEnvioMailsenLotes(_Sistema, _Restriccion, False)
        Return f
    End Function
#End Region

#Region "Seguridad"
    Function CargarModuloSeguridad(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
        Dim _grupos As New List(Of GrupoOpcion)
        If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Seguridad) Then
            _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Seguridad), CargarOpcionesSeguridad(_Sistema, False), CargarOpcionesSeguridad(_Sistema, True), CargarOpcionesSeguridadRep(_Sistema)))
        End If
        Return _grupos
    End Function

    Function CargarOpcionesSeguridad(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)

        For Each _restriccion As Restriccion In _Sistema.Restricciones
            If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
                If _restriccion.Restri_Lectura Then
                    Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
                        Case Enumerados.EnumOpciones.Usuarios
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarUsuario))
                        Case Enumerados.EnumOpciones.Auditoria
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarAuditoria))
                    End Select
                End If
            End If
        Next
        Return _opciones
    End Function

    Function CargarOpcionesSeguridadRep(ByVal _Sistema As Sistema) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)
        Return _opciones
    End Function

    Function CargarUsuario(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaUsuarios(_Sistema, _Restriccion, False)
        Return f
    End Function

    Function CargarAuditoria(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmAuditoria(_Sistema, _Restriccion)
        Return f
    End Function
#End Region

#Region "Configuracion"
    Function CargarModuloConfiguracion(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
        Dim _grupos As New List(Of GrupoOpcion)
        If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Configuracion) Then
            _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Configuracion), CargarOpcionesConfiguracion(_Sistema, False), CargarOpcionesConfiguracion(_Sistema, True), CargarOpcionesConfiguracionRep(_Sistema)))
        End If
        Return _grupos
    End Function

    Function CargarOpcionesConfiguracion(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)

        For Each _restriccion As Restriccion In _Sistema.Restricciones
            If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
                If _restriccion.Restri_Lectura Then
                    Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
                        'Case Enumerados.EnumOpciones.Empresas
                        '  _opciones.Add(New Opcion(_restriccion, AddressOf CargarEmpresas))
                        Case Enumerados.EnumOpciones.Modulos
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarModulos))
                        Case Enumerados.EnumOpciones.Opciones
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarOpciones))
                        Case Enumerados.EnumOpciones.Formatos
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarFormatos))
                            'Case Enumerados.EnumOpciones.Valores
                            '  _opciones.Add(New Opcion(_restriccion, AddressOf CargarValores))
                    End Select
                End If
            End If
        Next
        Return _opciones
    End Function

    Function CargarOpcionesConfiguracionRep(ByVal _Sistema As Sistema) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)
        Return _opciones
    End Function

    Function CargarEmpresas(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaParametroDets(_Sistema, _Restriccion, False)
        f.Parame_Codigo = Enumerados.EnumParametros.Empresas
        f.PuedeNuevo = True
        Return f
    End Function

    Function CargarModulos(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaParametroDets(_Sistema, _Restriccion, False)
        f.Parame_Codigo = Enumerados.EnumParametros.Modulos
        f.PuedeNuevo = False
        Return f
    End Function

    Function CargarOpciones(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaParametroDets(_Sistema, _Restriccion, False)
        f.Parame_Codigo = Enumerados.EnumParametros.Opciones
        f.PuedeNuevo = False
        Return f
    End Function

    Function CargarFormatos(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaParametroDets(_Sistema, _Restriccion, False)
        f.Parame_Codigo = Enumerados.EnumParametros.Formatos
        f.PuedeNuevo = False
        Return f
    End Function

    'Function CargarValores(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    '  Dim f As New FrmListaParametroDets(_Sistema, _Restriccion, False)
    '  f.Parame_Codigo = Enumerados.EnumParametros.Valores
    '  f.PuedeNuevo = False
    '  Return f
    'End Function
#End Region

End Class
