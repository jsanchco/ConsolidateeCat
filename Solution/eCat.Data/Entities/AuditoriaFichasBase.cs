namespace eCat.Data.Entities
{
    public class AuditoriaFichasBase
    {
        public long IdAuditoriaFichasBase { get; set; } // IdAuditoriaFichasBase (Primary key)
        public System.DateTime FechaAuditoria { get; set; } // FechaAuditoria
        public string IdInterno { get; set; } // IDInterno (length: 12)
        public string Isbn { get; set; } // ISBN (length: 13)
        public string Ean13 { get; set; } // EAN13 (length: 13)
        public string Titulo { get; set; } // Titulo (length: 255)
        public string Subtitulo { get; set; } // Subtitulo (length: 255)
        public short? Numero { get; set; } // Numero
        public byte? Idioma { get; set; } // Idioma
        public int? Coeditorial { get; set; } // Coeditorial
        public decimal? Ancho { get; set; } // Ancho
        public decimal? Alto { get; set; } // Alto
        public decimal? Grosor { get; set; } // Grosor
        public decimal? Peso { get; set; } // Peso
        public short? NumeroPaginas { get; set; } // NumeroPaginas
        public byte? TipoEncuadernacion { get; set; } // TipoEncuadernacion
        public byte? IdTipoArticulo { get; set; } // IDTipoArticulo
        public decimal? PrecioSinIvae { get; set; } // PrecioSinIVAE
        public decimal? PrecioConIvae { get; set; } // PrecioConIVAE
        public string EditorialOriginal { get; set; } // EditorialOriginal (length: 50)
        public string TituloOriginal { get; set; } // TituloOriginal (length: 255)
        public byte? IdiomaOriginal { get; set; } // IdiomaOriginal
        public string IdEstadoSap { get; set; } // IDEstadoSAP (length: 2)
        public int? PublicableWeb { get; set; } // PublicableWeb
        public byte? EdadMinima { get; set; } // EdadMinima
        public byte? EdadMaxima { get; set; } // EdadMaxima
        public string CodLineaP { get; set; } // COD_LineaP (length: 3)
        public decimal? PvpsSivaTnac { get; set; } // PVPS_SIVA_TNAC
        public decimal? PvpsCivaTnac { get; set; } // PVPS_CIVA_TNAC
        public decimal? PvpsSivaTextra { get; set; } // PVPS_SIVA_TEXTRA
        public decimal? IvaPorCiento { get; set; } // IvaPorCiento
        public string CodPais { get; set; } // COD_PAIS (length: 2)
        public System.DateTime? FechaCreacion { get; set; } // FechaCreacion
        public System.DateTime? FechaActualizacion { get; set; } // FechaActualizacion
        public decimal? IdPropietarioSubmateria { get; set; } // IDPropietarioSubmateria
        public string UrlEditor { get; set; } // URL_EDITOR (length: 255)
        public string CodAudi { get; set; } // COD_AUDI (length: 3)
        public string CodNivel { get; set; } // COD_NIVEL (length: 1)
        public string CodCaut { get; set; } // COD_CAUT (length: 2)
        public string UsuarioActualizacion { get; set; } // UsuarioActualizacion (length: 50)
        public string UsuarioCreacion { get; set; } // UsuarioCreacion (length: 50)
        public bool? SoloIlustracion { get; set; } // SoloIlustracion
        public string UsuarioPublicacion { get; set; } // UsuarioPublicacion (length: 50)
        public System.DateTime? FechaPublicacion { get; set; } // FechaPublicacion
        public string UsuarioUltimaPublicacion { get; set; } // UsuarioUltimaPublicacion (length: 50)
        public System.DateTime? FechaUltimaPublicacion { get; set; } // FechaUltimaPublicacion
        public string UsuarioRetirada { get; set; } // UsuarioRetirada (length: 50)
        public System.DateTime? FechaRetirada { get; set; } // FechaRetirada
        public int? NEjemplaresCaja { get; set; } // NEjemplaresCaja
        public System.DateTime? FechaAltaLogistica { get; set; } // FechaAltaLogistica
        public string CodigoGrupo { get; set; } // CodigoGrupo (length: 9)
        public System.DateTime? FechaDisponibilidadComercial { get; set; } // FechaDisponibilidadComercial
        public System.DateTime? FechaNecesidadInformacion { get; set; } // FechaNecesidadInformacion
        public bool? IncluirEnDilve { get; set; } // IncluirEnDILVE
        public System.DateTime? FechaCreacionDilve { get; set; } // FechaCreacionDILVE
        public System.DateTime? FechaRetiradaDilve { get; set; } // FechaRetiradaDILVE
        public int? IdColeccion { get; set; } // IdColeccion
        public int? IdSerie { get; set; } // IdSerie
        public short? IdCampaña { get; set; } // IdCampaña
        public short? IdPais { get; set; } // IdPais
        public byte? IdLineaNegocio { get; set; } // IdLineaNegocio
        public string TituloDistribuidora { get; set; } // TituloDistribuidora (length: 40)
        public string TituloIsbn { get; set; } // TituloISBN (length: 255)
        public short? IdTipoMaterialSap { get; set; } // IdTipoMaterialSAP
        public int? IdProyecto { get; set; } // IdProyecto
        public byte? IdTipoPublicacion { get; set; } // IdTipoPublicacion
        public byte? IdUsoComercial { get; set; } // IdUsoComercial
        public bool? Bilingue { get; set; } // Bilingue
        public byte? IdFase { get; set; } // IdFase
        public byte? IdEstadoSeguimiento { get; set; } // IdEstadoSeguimiento
        public System.DateTime? FechaCreacionProyectoPs { get; set; } // FechaCreacionProyectoPS
        public System.DateTime? FechaRecepcionPrototipos { get; set; } // FechaRecepcionPrototipos
        public byte? IdZonaGeografica { get; set; } // IdZonaGeografica
        public string TextoDerechos { get; set; } // TextoDerechos
        public byte? IdTipoMaterialEducativo { get; set; } // IdTipoMaterialEducativo
        public short? NumeroColeccion { get; set; } // NumeroColeccion
        public bool? Baja { get; set; } // Baja
        public string IdInternoOrigen { get; set; } // IDInternoOrigen (length: 12)
        public string IdInternoOrigenSap { get; set; } // IDInternoOrigenSAP (length: 12)
        public short? NumeroSerie { get; set; } // NumeroSerie
        public byte? IdGenero { get; set; } // IdGenero
        public System.DateTime? FechaBaja { get; set; } // FechaBaja
        public System.DateTime? FechaFinProcesadoInteriores { get; set; } // FechaFinProcesadoInteriores
        public System.DateTime? FechaPuestaEnMarchaFabricacion { get; set; } // FechaPuestaEnMarchaFabricacion
        public string UsuarioBaja { get; set; } // UsuarioBaja (length: 50)
        public byte? IdDrm { get; set; } // IdDRM
        public byte? IdAccesibilidad { get; set; } // IdAccesibilidad
        public System.DateTime? FechaActualizacionParaDilve { get; set; } // FechaActualizacionParaDILVE
        public System.DateTime? FechaUltimaActualizacionDilve { get; set; } // FechaUltimaActualizacionDILVE
        public string UsuarioMarcaDilve { get; set; } // UsuarioMarcaDILVE (length: 50)
        public string UsuarioSubidaDilve { get; set; } // UsuarioSubidaDILVE (length: 50)
        public string UsuarioRetiradaDilve { get; set; } // UsuarioRetiradaDILVE (length: 50)
        public bool? BajaSoloECat { get; set; } // BajaSoloECat
        public string UsuarioBajaSoloECat { get; set; } // UsuarioBajaSoloECat (length: 50)
        public bool? PublicoDilve { get; set; } // PublicoDILVE
        public string UsuarioActualizacionPublicoDilve { get; set; } // UsuarioActualizacionPublicoDILVE (length: 50)
        public System.DateTime? FechaActualizacionPublicoDilve { get; set; } // FechaActualizacionPublicoDILVE
        public byte? PorcentajeCoedicion { get; set; } // PorcentajeCoedicion
        public byte? IdDisponibilidadDilve { get; set; } // IdDisponibilidadDILVE
        public System.DateTime? FechaDisponibilidadDilve { get; set; } // FechaDisponibilidadDILVE
        public int? IdProyectoAdicional { get; set; } // IdProyectoAdicional
        public int? IdProyectoGestion { get; set; } // IdProyectoGestion

        public AuditoriaFichasBase()
        {
            FechaAuditoria = System.DateTime.Now;
        }
    }
}