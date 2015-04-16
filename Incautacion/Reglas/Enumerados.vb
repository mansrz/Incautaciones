Public Class Enumerados
#Region "Opciones del sistema"
  Enum EnumModulos
    Empresa = 100
    Inventario = 400
    Cuentas = 500
    Reporteador = 800
    Seguridad = 900
    Configuracion = 9000
  End Enum

  Enum EnumOpciones
    Sistema = 1

    Empresa = 110
    Sucursal = 111
    ListadoClientes = 112
    ListadoProveedores = 114
    ListadoEmpleados = 116
        ListadoPersonas = 118
        ListadoContribuyentes = 120
    Reportes = 199

    AperturaSobre = 402
    ProcesarSobre = 404
    ImprimirSobre = 406
    FacturacionSobre = 408
    EntregaSobre = 409

    ListadoItems = 410
    ListadoBodegas = 412
    ListadoTiposPrecios = 414
    ListadoFormasPago = 415
    Secuenciales = 416
    SecuencialCompraVenta = 417
    MovimientoInventario = 418
    UnidadMedidaConversion = 420
    TPV = 422
    AsientosContablesInventario = 425
    ReportesInventario = 499

    Cuentas = 510
    EstadoCuenta = 520
    AnalisisCartera = 530
    ReportesCuentas = 599

    Reporteador = 810
    EmailAutomatico = 815

    Usuarios = 910
    Auditoria = 912

    Modulos = 9005
    Opciones = 9010
    Formatos = 9015
    Valores = 9020
  End Enum

  Enum enumTipoAccion
    Ingreso = 1
    Salida = 2
    Adicion = 3
    Modificacion = 4
    Eliminacion = 5
    Impresion = 6
    Confidencial = 7
  End Enum
#End Region

#Region "Parametros"
  Enum EnumParametros
    Empresas = 2
    Modulos = 4
    Opciones = 5
    TipoAccion = 10
    Formatos = 20

    TipoObjeto = 100
    TipoEntidad = 110
    TipoLugar = 115
    TipoIdentificacion = 120
    TipoDireccion = 125
    SectorDomicilio = 127
    TipoOtrosDatos = 130

    TipoTelefono = 131
    TipoEmail = 132

    Sexo = 140
    EstadoCivil = 141

    TipoContribuyente = 145

    TipoEmpleado = 150

    Pais = 200
    Provincia = 210
    Ciudad = 220
    Parroquia = 230

    Banco = 300
    TarjetaCredito = 305
    TipoCtaBan = 310

    TipotrabajoSobre = 425
    EstadoSobre = 426

    TipoMovInventario = 440
    TipoCompra = 441
    TipoVenta = 442

    TipoPrecio = 450
    TipoFormaPago = 460
    TipoMovPagos = 470

    TipoDiscapacidad = 707
    Nacionalidad = 710
    TipoSangre = 715
    FormaPagoRol = 720
    MotivoPago = 722
    SeguroCorporativo = 724

    Adjuntos = 2000
    Adjuntosdetalle = 2005

    Grupo = 400
    Marca = 410
    TipoInventario = 420
    UnidadMedida = 430

    TipoCuenta = 444

    ConceptoRetencion = 473
    TipoRetencionIVa = 474
    RetencionIVA = 475
  End Enum
#End Region

#Region "TipoEntidad"
  Enum EnumTipoEntidad
    Natural = 1
    Juridica = 2
    Lugar = 3
  End Enum
#End Region

#Region "TipoLugar"
  Enum EnumTipoLugar
    Sucursal = 1
    Bodega = 2
  End Enum
#End Region

#Region "TipoOtrosDatos"
  Enum enumTipoOtrosDatos
    Telefono = 1
    Email = 2
    TelefonoDomicilio = 3
  End Enum
#End Region

#Region "TipoDireccion"
  Enum enumTipoDireccion
    Trabajo = 1
    Domicilio = 2
  End Enum
#End Region

#Region "TipoTelefono"
  Enum enumTipoTelefono
    Trabajo = 1
    Fax = 2
    Domicilio = 3
  End Enum
#End Region

#Region "TipoEmail"
  Enum enumTipoEmail
    Trabajo = 1
    Trabajo1 = 2
    Domicilio = 3
  End Enum
#End Region

#Region "TipoIdentificacion"
  Enum enumTipoIdentificacion
    RUC = 1
    Cedula = 2
    Pasaporte = 3
    CedulaMilitar = 4
    LicenciaConducir = 5
    CarnetSeguro = 10

    PrefijoFacturas = 6
  End Enum
#End Region

#Region "Forma de pago Rol"
  Enum enumFormaPagoRol As Byte
    Cheque = 1
    Efectivo = 2
    Deposito = 3
  End Enum
#End Region

#Region "TipoPrecio"
  Enum enumTipoPrecio
    PrecioContado = 1
  End Enum
#End Region

#Region "TipoInventario"
  Enum EnumTipoInventario
    Facturable = 1
    Produccion = 2
    ActivoFijo = 3
  End Enum
#End Region

#Region "TipoMovInv"
  Enum enumTipoMovInv
    InvInicial = 1
    Compra = 2
    DevVenta = 4
    AjustePos = 5
    Cxc = 8
    OrdenDesensamble = 6
    Incautacion = 7
    Transferencia = 9
    Venta = 10
    Consumo = 11
    DesperdicioOP = 12
    DevCompra = 13
    AjusteNeg = 14
    OrdenProduccion = 15
    Cortesia = 16
        Cxp = 18
    DevIncautacion = 20
    DevIncautacionDonacion = 21
    DevIncautacionChatarra = 22
  End Enum
#End Region

#Region "TipoCuenta"
  Enum enumTipoCuenta
    cxc = 1
    cxp = 2
  End Enum
#End Region

#Region "TipoCompra"
  Enum enumTipoCompra
    Compra = 1
    Importacion = 2
    Liqcompra = 3
  End Enum
#End Region

#Region "TipoVenta"
  Enum enumTipoVenta
    Factura = 1
    NotaVenta = 2
    TicketPOS = 3
    Proforma = 4
  End Enum
#End Region

#Region "TipoFormaPago"
  Enum enumTipoFormaPago
    Contado = 1
  End Enum
#End Region

#Region "TipoMovPagos"
  Enum enumTipoMovPagos
    Documento = 99
    Efectivo = 1
    Cheque = 2
    Tarjetadecredito = 3
    Comisiontarjeta = 4
    Notadedebito = 5
    Notadecredito = 6
    Depositobancario = 7
    Multaprotesto = 8
    Retencionfuente = 9
    RetencionIVA = 10
  End Enum
#End Region

#Region "EstadoSobre"
  Enum enumEstadoSobre
    CasoAperturado = 1
    SobreRechazado = 2
    TomadoProforma = 3
    RechazadoEditores = 4
    LiberadoEditores = 5
    TomadoQuirofano = 6
    RechazadoImprenta = 7
    LiberadoImprenta = 8
    TomadoFacturacion = 9
    RechazadoFacturacion = 10
    LiberadoFacturacion = 11
    TomadoCierre = 12
    RechazadoEntrega = 13
    LiberadoEntrega = 14
  End Enum

#End Region
End Class
