using System.ComponentModel.DataAnnotations.Schema;

namespace eCat.Data.Entities
{
    public class FichasBase
    {

        ///<summary>
        /// Clave del material. Compuesto de prefijo, 2 caracteres alfanuméricos, y código, hasta 10 caracteres numéricos.
        ///</summary>
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)

        ///<summary>
        /// Código ISBN
        ///</summary>
        public string Isbn { get; set; } // ISBN (length: 13)

        ///<summary>
        /// Código de barras
        ///</summary>
        public string Ean13 { get; set; } // EAN13 (length: 13)

        ///<summary>
        /// Título del material en eCat
        ///</summary>
        public string Titulo { get; set; } // Titulo (length: 255)

        ///<summary>
        /// Subtítulo del material en la portada
        ///</summary>
        public string Subtitulo { get; set; } // Subtitulo (length: 255)

        ///<summary>
        /// Número de serie
        ///</summary>
        public short? Numero { get; set; } // Numero

        ///<summary>
        /// Idioma de edición
        ///</summary>
        public byte? Idioma { get; set; } // Idioma

        ///<summary>
        /// Editorial participante en la co-edición del material
        ///</summary>
        public int? Coeditorial { get; set; } // Coeditorial

        ///<summary>
        /// Ancho del material en cm
        ///</summary>
        public decimal? Ancho { get; set; } // Ancho

        ///<summary>
        /// Alto del material en cm
        ///</summary>
        public decimal? Alto { get; set; } // Alto

        ///<summary>
        /// Grosor del material en cm
        ///</summary>
        public decimal? Grosor { get; set; } // Grosor

        ///<summary>
        /// Peso del material en gr
        ///</summary>
        public decimal? Peso { get; set; } // Peso

        ///<summary>
        /// Número de páginas, en el caso de un libro
        ///</summary>
        public short? NumeroPaginas { get; set; } // NumeroPaginas

        ///<summary>
        /// Tipo de encuadernación, en un libro
        ///</summary>
        public byte? TipoEncuadernacion { get; set; } // TipoEncuadernacion

        ///<summary>
        /// Tipo de material: libro, CD,etc.
        ///</summary>
        public byte? IdTipoArticulo { get; set; } // IDTipoArticulo

        ///<summary>
        /// Precio sin IVA
        ///</summary>
        public decimal? PrecioSinIvae { get; set; } // PrecioSinIVAE

        ///<summary>
        /// Precio con IVA incluido
        ///</summary>
        public decimal? PrecioConIvae { get; set; } // PrecioConIVAE

        ///<summary>
        /// Nonbre de la editorial original
        ///</summary>
        public string EditorialOriginal { get; set; } // EditorialOriginal (length: 50)

        ///<summary>
        /// Título original sin traducir
        ///</summary>
        public string TituloOriginal { get; set; } // TituloOriginal (length: 255)

        ///<summary>
        /// Idioma de la edición original
        ///</summary>
        public byte? IdiomaOriginal { get; set; } // IdiomaOriginal

        ///<summary>
        /// Estado heredado del sistema SAP
        ///</summary>
        public string IdEstadoSap { get; set; } // IDEstadoSAP (length: 2)

        ///<summary>
        /// True indica que puede los datos del material se pueden publicar en los sitios Web cuando estos utilicen un catálogo de presentación para la selección y publicación de contenidos
        ///</summary>
        public int? PublicableWeb { get; set; } // PublicableWeb

        ///<summary>
        /// Edad mínima recomendada para el material
        ///</summary>
        public byte? EdadMinima { get; set; } // EdadMinima

        ///<summary>
        /// Edad máxima recomendada para el material
        ///</summary>
        public byte? EdadMaxima { get; set; } // EdadMaxima

        ///<summary>
        /// Línea de producto definida en el sistema SAP
        ///</summary>
        public string CodLineaP { get; set; } // COD_LineaP (length: 3)

        ///<summary>
        /// Tarifa nacional sin IVA
        ///</summary>
        public decimal? PvpsSivaTnac { get; set; } // PVPS_SIVA_TNAC

        ///<summary>
        /// Tarifa nacional con IVA
        ///</summary>
        public decimal? PvpsCivaTnac { get; set; } // PVPS_CIVA_TNAC

        ///<summary>
        /// Tarifa extranjero sin IVA
        ///</summary>
        public decimal? PvpsSivaTextra { get; set; } // PVPS_SIVA_TEXTRA

        ///<summary>
        /// Tanto por ciento de impuesto de IVA
        ///</summary>
        public decimal? IvaPorCiento { get; set; } // IvaPorCiento

        ///<summary>
        /// Código de país. FUERA DE USO
        ///</summary>
        public string CodPais { get; set; } // COD_PAIS (length: 2)

        ///<summary>
        /// Fecha de creación del registro
        ///</summary>
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion

        ///<summary>
        /// Fecha de la última actualización del registro
        ///</summary>
        public System.DateTime? FechaActualizacion { get; set; } // FechaActualizacion

        ///<summary>
        /// OBSOLETO
        ///</summary>
        public decimal? IdPropietarioSubmateria { get; set; } // IDPropietarioSubmateria

        ///<summary>
        /// URL con información realtiva al material: Página Web del autor, Página Web dedicada al libro, etc.
        ///</summary>
        public string UrlEditor { get; set; } // URL_EDITOR (length: 255)

        ///<summary>
        /// OBSOLETO
        ///</summary>
        public string CodAudi { get; set; } // COD_AUDI (length: 3)

        ///<summary>
        /// OBSOLETO
        ///</summary>
        public string CodNivel { get; set; } // COD_NIVEL (length: 1)

        ///<summary>
        /// OBSOLETO
        ///</summary>
        public string CodCaut { get; set; } // COD_CAUT (length: 2)

        ///<summary>
        /// Usuario que ha realizado la última actualización
        ///</summary>
        public string UsuarioActualizacion { get; set; } // UsuarioActualizacion (length: 50)

        ///<summary>
        /// Usuario que ha creado el registro
        ///</summary>
        public string UsuarioCreacion { get; set; } // UsuarioCreacion (length: 50)

        ///<summary>
        /// Indica que el libro es sólo de ilustración o esta ocupa la mayor parte
        ///</summary>
        public bool SoloIlustracion { get; set; } // SoloIlustracion

        ///<summary>
        /// Usuario que ha publicado el material por primera vez
        ///</summary>
        public string UsuarioPublicacion { get; set; } // UsuarioPublicacion (length: 50)

        ///<summary>
        /// Fecha de la primera publicación del material
        ///</summary>
        public System.DateTime? FechaPublicacion { get; set; } // FechaPublicacion

        ///<summary>
        /// Usuario que ha publicado el material la última vez
        ///</summary>
        public string UsuarioUltimaPublicacion { get; set; } // UsuarioUltimaPublicacion (length: 50)

        ///<summary>
        /// Fecha de la última publicación del material
        ///</summary>
        public System.DateTime? FechaUltimaPublicacion { get; set; } // FechaUltimaPublicacion

        ///<summary>
        /// Usuario que ha realizado la retirada (despublicación) del material
        ///</summary>
        public string UsuarioRetirada { get; set; } // UsuarioRetirada (length: 50)

        ///<summary>
        /// Fecha de retirada (despublicación) del material
        ///</summary>
        public System.DateTime? FechaRetirada { get; set; } // FechaRetirada

        ///<summary>
        /// Número de ejemplares por caja (para distribución o comercialización)
        ///</summary>
        public int NEjemplaresCaja { get; set; } // NEjemplaresCaja

        ///<summary>
        /// Fecha de entrada del material en almacén
        ///</summary>
        public System.DateTime? FechaAltaLogistica { get; set; } // FechaAltaLogistica

        ///<summary>
        /// Código del grupo de artículo en el sistema SAP
        ///</summary>
        public string CodigoGrupo { get; set; } // CodigoGrupo (length: 9)

        ///<summary>
        /// PROXIMA UTILIZACION
        ///</summary>
        public System.DateTime? FechaDisponibilidadComercial { get; set; } // FechaDisponibilidadComercial

        ///<summary>
        /// PROXIMA UTILIZACION
        ///</summary>
        public System.DateTime? FechaNecesidadInformacion { get; set; } // FechaNecesidadInformacion

        ///<summary>
        /// Indica si el registro puede pasar a DILVE
        ///</summary>
        public bool? IncluirEnDilve { get; set; } // IncluirEnDILVE

        ///<summary>
        /// Fecha de actualización en DILVE
        ///</summary>
        public System.DateTime? FechaCreacionDilve { get; set; } // FechaCreacionDILVE
        public System.DateTime? FechaRetiradaDilve { get; set; } // FechaRetiradaDILVE

        ///<summary>
        /// Clave de la colección a la que pertenece el material
        ///</summary>
        public int? IdColeccion { get; set; } // IdColeccion

        ///<summary>
        /// Clave de la serie a la que pertenece el material
        ///</summary>
        public int? IdSerie { get; set; } // IdSerie

        ///<summary>
        /// Clave de la campaña en la que se produjo el material
        ///</summary>
        public short? IdCampaña { get; set; } // IdCampaña

        ///<summary>
        /// Identificador del país al cual pertenece el libro
        ///</summary>
        public short? IdPais { get; set; } // IdPais

        ///<summary>
        /// Identificador de la línea de negocio a la cual pertenece el material
        ///</summary>
        public byte? IdLineaNegocio { get; set; } // IdLineaNegocio
        public string TituloDistribuidora { get; set; } // TituloDistribuidora (length: 40)
        public string TituloIsbn { get; set; } // TituloISBN (length: 255)
        public short? IdTipoMaterialSap { get; set; } // IdTipoMaterialSAP
        public int? IdProyecto { get; set; } // IdProyecto
        public byte? IdTipoPublicacion { get; set; } // IdTipoPublicacion
        public byte? IdUsoComercial { get; set; } // IdUsoComercial

        ///<summary>
        /// Indica si el material es bilingue. Es bilingue si el mismo texto aparece en más de un idioma
        ///</summary>
        public bool Bilingue { get; set; } // Bilingue
        public byte? IdFase { get; set; } // IdFase
        public byte? IdEstadoSeguimiento { get; set; } // IdEstadoSeguimiento
        public System.DateTime? FechaCreacionProyectoPs { get; set; } // FechaCreacionProyectoPS
        public System.DateTime? FechaRecepcionPrototipos { get; set; } // FechaRecepcionPrototipos
        public byte? IdZonaGeografica { get; set; } // IdZonaGeografica
        public string TextoDerechos { get; set; } // TextoDerechos
        public byte? IdTipoMaterialEducativo { get; set; } // IdTipoMaterialEducativo
        public short? NumeroColeccion { get; set; } // NumeroColeccion
        public bool Baja { get; set; } // Baja
        public string IdInternoOrigen { get; set; } // IDInternoOrigen (length: 12)
        public string IdInternoOrigenSap { get; set; } // IDInternoOrigenSAP (length: 12)
        public short? NumeroSerie { get; set; } // NumeroSerie
        public byte? IdGenero { get; set; } // IdGenero
        public System.DateTime? FechaBaja { get; set; } // FechaBaja
        public System.DateTime? FechaFinProcesadoInteriores { get; set; } // FechaFinProcesadoInteriores
        public System.DateTime? FechaPuestaEnMarchaFabricacion { get; set; } // FechaPuestaEnMarchaFabricacion

        ///<summary>
        /// Usuario que ha realizado la retirada (despublicación) del material
        ///</summary>
        public string UsuarioBaja { get; set; } // UsuarioBaja (length: 50)
        public byte? IdDrm { get; set; } // IdDRM
        public byte? IdAccesibilidad { get; set; } // IdAccesibilidad
        public System.DateTime? FechaActualizacionParaDilve { get; set; } // FechaActualizacionParaDILVE
        public System.DateTime? FechaUltimaActualizacionDilve { get; set; } // FechaUltimaActualizacionDILVE
        public string UsuarioMarcaDilve { get; set; } // UsuarioMarcaDILVE (length: 50)
        public string UsuarioSubidaDilve { get; set; } // UsuarioSubidaDILVE (length: 50)
        public string UsuarioRetiradaDilve { get; set; } // UsuarioRetiradaDILVE (length: 50)

        ///<summary>
        /// Campo que indica si el material está dado de baja en eCat, permaneciendo en SAP.
        ///</summary>
        public bool BajaSoloECat { get; set; } // BajaSoloECat

        ///<summary>
        /// usuario que ha dado de bajaen eCat pero permanece en SAP
        ///</summary>
        public string UsuarioBajaSoloECat { get; set; } // UsuarioBajaSoloECat (length: 50)
        public bool PublicoDilve { get; set; } // PublicoDILVE
        public string UsuarioActualizacionPublicoDilve { get; set; } // UsuarioActualizacionPublicoDILVE (length: 50)
        public System.DateTime? FechaActualizacionPublicoDilve { get; set; } // FechaActualizacionPublicoDILVE
        public byte? PorcentajeCoedicion { get; set; } // PorcentajeCoedicion
        public byte? IdDisponibilidadDilve { get; set; } // IdDisponibilidadDILVE
        public System.DateTime? FechaDisponibilidadDilve { get; set; } // FechaDisponibilidadDILVE
        public int? IdProyectoAdicional { get; set; } // IdProyectoAdicional
        public int? IdProyectoGestion { get; set; } // IdProyectoGestion

        // Reverse navigation

        /// <summary>
        /// Child Documentoes where [Documentos].[IDInterno] point to this entity (FK_Documentos_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Documento> Documentoes { get; set; } // Documentos.FK_Documentos_FichasBase
        /// <summary>
        /// Child E2FichasBaseComentario where [E2_FichasBase_Comentarios].[IDInterno] point to this entity (FK_E2_FichasBase_Comentarios_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2FichasBaseComentario> E2FichasBaseComentario { get; set; } // E2_FichasBase_Comentarios.FK_E2_FichasBase_Comentarios_FichasBase
        /// <summary>
        /// Child E2FichasBasePalabrasClave where [E2_FichasBase_PalabrasClave].[IDInterno] point to this entity (FK_E2_FichasBase_PalabrasClave_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2FichasBasePalabrasClave> E2FichasBasePalabrasClave { get; set; } // E2_FichasBase_PalabrasClave.FK_E2_FichasBase_PalabrasClave_FichasBase
        /// <summary>
        /// Child E2FichasBasePremio where [E2_FichasBase_Premios].[IDInterno] point to this entity (FK_E2_FichasBase_Premios_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2FichasBasePremio> E2FichasBasePremio { get; set; } // E2_FichasBase_Premios.FK_E2_FichasBase_Premios_FichasBase
        /// <summary>
        /// Child E2GeRamaslibro where [E2_GE_RAMASLIBROS].[ID_INTERNO] point to this entity (FK_E2_GE_RAMASLIBROS_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2GeRamaslibro> E2GeRamaslibro { get; set; } // E2_GE_RAMASLIBROS.FK_E2_GE_RAMASLIBROS_FichasBase
        /// <summary>
        /// Child E2RamasclasifFicha where [E2_RAMASCLASIF_FICHAS].[IDInterno] point to this entity (FK_E2_RAMASCLASIF_FICHAS_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2RamasclasifFicha> E2RamasclasifFicha { get; set; } // E2_RAMASCLASIF_FICHAS.FK_E2_RAMASCLASIF_FICHAS_FichasBase
        /// <summary>
        /// Child E2Tiradasedicion where [E2_TIRADASEDICION].[IDInterno] point to this entity (FK_E2_TIRADASEDICION_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2Tiradasedicion> E2Tiradasedicion { get; set; } // E2_TIRADASEDICION.FK_E2_TIRADASEDICION_FichasBase
        /// <summary>
        /// Child Efemerides (Many-to-Many) mapped by table [RelFichasEfemerides]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Efemeride> Efemerides { get; set; } // Many to many mapping
        /// <summary>
        /// Child Fechas where [Fechas].[IDInterno] point to this entity (FK_Fechas_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Fecha> Fechas { get; set; } // Fechas.FK_Fechas_FichasBase
        /// <summary>
        /// Child FichasAplicacions where [FichasAplicacion].[IDInterno] point to this entity (FK_FichasAplicacion_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasAplicacion> FichasAplicacions { get; set; } // FichasAplicacion.FK_FichasAplicacion_FichasBase
        /// <summary>
        /// Child FichasBaseArchivoHistoricoes where [FichasBase_ArchivoHistorico].[IdInterno] point to this entity (FK_FichasBase_ArchivoHistorico_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseArchivoHistorico> FichasBaseArchivoHistoricoes { get; set; } // FichasBase_ArchivoHistorico.FK_FichasBase_ArchivoHistorico_FichasBase
        /// <summary>
        /// Child FichasBaseCamposLibres where [FichasBase_CamposLibres].[IdInterno] point to this entity (FK_FichasBase_CamposLibres_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseCamposLibre> FichasBaseCamposLibres { get; set; } // FichasBase_CamposLibres.FK_FichasBase_CamposLibres_FichasBase
        /// <summary>
        /// Child FichasBaseCicloCursoes where [FichasBase_CicloCurso].[IdInterno] point to this entity (FK_FichasBase_CicloCurso_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseCicloCurso> FichasBaseCicloCursoes { get; set; } // FichasBase_CicloCurso.FK_FichasBase_CicloCurso_FichasBase
        /// <summary>
        /// Child FichasBaseClasificacionEcis where [FichasBase_ClasificacionECI].[IDInterno] point to this entity (FK_FichasBase_ClasificacionECI_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseClasificacionEci> FichasBaseClasificacionEcis { get; set; } // FichasBase_ClasificacionECI.FK_FichasBase_ClasificacionECI_FichasBase
        /// <summary>
        /// Child FichasBaseCodigoCdus where [FichasBase_CodigoCDU].[IDInterno] point to this entity (FK_FichasBase_CodigoCDU_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseCodigoCdu> FichasBaseCodigoCdus { get; set; } // FichasBase_CodigoCDU.FK_FichasBase_CodigoCDU_FichasBase
        /// <summary>
        /// Child FichasBaseIdiomasSecundarios where [FichasBase_IdiomasSecundarios].[IdInterno] point to this entity (FK_FichasBase_IdiomasSecundarios_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseIdiomasSecundario> FichasBaseIdiomasSecundarios { get; set; } // FichasBase_IdiomasSecundarios.FK_FichasBase_IdiomasSecundarios_FichasBase
        /// <summary>
        /// Child FichasBaseSoportes where [FichasBase_Soporte].[IdInterno] point to this entity (FK_FichasBase_Soporte_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseSoporte> FichasBaseSoportes { get; set; } // FichasBase_Soporte.FK_FichasBase_Soporte_FichasBase
        /// <summary>
        /// Child FichasBaseTesauroes where [FichasBase_Tesauro].[IDInterno] point to this entity (FK_FichasBase_Tesauro_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseTesauro> FichasBaseTesauroes { get; set; } // FichasBase_Tesauro.FK_FichasBase_Tesauro_FichasBase
        /// <summary>
        /// Child RelFichasPersonas where [RelFichasPersonas].[IDInterno] point to this entity (FK_RelFichasPersonas_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<RelFichasPersona> RelFichasPersonas { get; set; } // RelFichasPersonas.FK_RelFichasPersonas_FichasBase
        /// <summary>
        /// Child RelFrasesDescriptivas where [RelFrasesDescriptivas].[IDInterno] point to this entity (FK_RelFrasesDescriptivas_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<RelFrasesDescriptiva> RelFrasesDescriptivas { get; set; } // RelFrasesDescriptivas.FK_RelFrasesDescriptivas_FichasBase
        /// <summary>
        /// Child Resenas where [Resenas].[IDInterno] point to this entity (FK_Resenas_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Resena> Resenas { get; set; } // Resenas.FK_Resenas_FichasBase
        /// <summary>
        /// Child TActualizacionesDetalles where [T_Actualizaciones_Detalle].[IdInterno] point to this entity (FK_T_actualizaciones_Detalle_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesDetalle> TActualizacionesDetalles { get; set; } // T_Actualizaciones_Detalle.FK_T_actualizaciones_Detalle_FichasBase
        /// <summary>
        /// Child TbFichasBaseImagenes where [TB_FichasBase_Imagenes].[IdInterno] point to this entity (FK_TB_FichasBase_Imagenes_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbFichasBaseImagene> TbFichasBaseImagenes { get; set; } // TB_FichasBase_Imagenes.FK_TB_FichasBase_Imagenes_FichasBase
        /// <summary>
        /// Child TDigitalPlataformas (Many-to-Many) mapped by table [T_FichasBase_Digital_Plataformas]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TDigitalPlataforma> TDigitalPlataformas { get; set; } // Many to many mapping
        /// <summary>
        /// Child TFichasBaseAmbitosCesions where [T_FichasBase_AmbitosCesion].[IdInterno] point to this entity (FK_T_FichasBase_AmbitosCesion_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseAmbitosCesion> TFichasBaseAmbitosCesions { get; set; } // T_FichasBase_AmbitosCesion.FK_T_FichasBase_AmbitosCesion_FichasBase
        /// <summary>
        /// Child TFichasBaseHistoricoEstadoSeguimientoes where [T_FichasBase_Historico_EstadoSeguimiento].[IdInterno] point to this entity (FK_T_FichasBase_Historico_EstadoSeguimiento_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseHistoricoEstadoSeguimiento> TFichasBaseHistoricoEstadoSeguimientoes { get; set; } // T_FichasBase_Historico_EstadoSeguimiento.FK_T_FichasBase_Historico_EstadoSeguimiento_FichasBase
        /// <summary>
        /// Child TFichasBaseHistoricoFases where [T_FichasBase_Historico_Fase].[IdInterno] point to this entity (FK_T_FichasBase_Historico_Fase_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseHistoricoFase> TFichasBaseHistoricoFases { get; set; } // T_FichasBase_Historico_Fase.FK_T_FichasBase_Historico_Fase_FichasBase
        /// <summary>
        /// Child TFichasBaseMaterialesReferencias where [T_FichasBase_MaterialesReferencia].[IdInterno] point to this entity (FK_T_FichasBase_MaterialesReferencia_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseMaterialesReferencia> TFichasBaseMaterialesReferencias_IdInterno { get; set; } // T_FichasBase_MaterialesReferencia.FK_T_FichasBase_MaterialesReferencia_FichasBase
        /// <summary>
        /// Child TFichasBaseMaterialesReferencias where [T_FichasBase_MaterialesReferencia].[IdInternoReferencia] point to this entity (FK_T_FichasBase_MaterialesReferencia_FichasBase1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseMaterialesReferencia> TFichasBaseMaterialesReferencias_IdInternoReferencia { get; set; } // T_FichasBase_MaterialesReferencia.FK_T_FichasBase_MaterialesReferencia_FichasBase1
        /// <summary>
        /// Child TitulosAfines where [TitulosAfines].[IDInterno] point to this entity (FK_TitulosAfines_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TitulosAfine> TitulosAfines { get; set; } // TitulosAfines.FK_TitulosAfines_FichasBase
        /// <summary>
        /// Child TitulosAnejoes where [TitulosAnejos].[IDInterno] point to this entity (FK_TitulosAnejos_FichasBase)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TitulosAnejo> TitulosAnejoes { get; set; } // TitulosAnejos.FK_TitulosAnejos_FichasBase

        // Foreign keys

        /// <summary>
        /// Parent CoEditoriale pointed by [FichasBase].([Coeditorial]) (FK_FichasBase_CoEditoriales)
        /// </summary>
        public virtual CoEditoriale CoEditoriale { get; set; } // FK_FichasBase_CoEditoriales

        /// <summary>
        /// Parent DilveDisponibilidad pointed by [FichasBase].([IdDisponibilidadDilve]) (FK_FichasBase_DILVE_Disponibilidad)
        /// </summary>
        public virtual DilveDisponibilidad DilveDisponibilidad { get; set; } // FK_FichasBase_DILVE_Disponibilidad

        /// <summary>
        /// Parent E2AclDominio pointed by [FichasBase].([IdPais]) (FK_FichasBase_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual E2AclDominio E2AclDominio { get; set; } // FK_FichasBase_E2_ACL_DOMINIOS

        /// <summary>
        /// Parent E2GruposArticulo pointed by [FichasBase].([CodigoGrupo]) (FK_FichasBase_E2_GRUPOS_ARTICULOS)
        /// </summary>
        public virtual E2GruposArticulo E2GruposArticulo { get; set; } // FK_FichasBase_E2_GRUPOS_ARTICULOS

        /// <summary>
        /// Parent EstadosSap pointed by [FichasBase].([IdEstadoSap]) (FK_FichasBase_EstadosSAP)
        /// </summary>
        public virtual EstadosSap EstadosSap { get; set; } // FK_FichasBase_EstadosSAP

        /// <summary>
        /// Parent Idioma pointed by [FichasBase].([Idioma]) (FK_FichasBase_Idiomas)
        /// </summary>
        public virtual Idioma Idioma_Idioma { get; set; } // FK_FichasBase_Idiomas

        /// <summary>
        /// Parent LineaNegocio pointed by [FichasBase].([IdLineaNegocio]) (FK_FichasBase_LineaNegocio)
        /// </summary>
        public virtual LineaNegocio LineaNegocio { get; set; } // FK_FichasBase_LineaNegocio

        /// <summary>
        /// Parent TCampañas pointed by [FichasBase].([IdCampaña]) (FK_FichasBase_T_Campañas)
        /// </summary>
        public virtual TCampañas TCampañas { get; set; } // FK_FichasBase_T_Campañas

        /// <summary>
        /// Parent TColeccione pointed by [FichasBase].([IdColeccion]) (FK_FichasBase_T_Colecciones)
        /// </summary>
        public virtual TColeccione TColeccione { get; set; } // FK_FichasBase_T_Colecciones

        /// <summary>
        /// Parent TDigitalAccesibilidad pointed by [FichasBase].([IdAccesibilidad]) (FK_FichasBase_T_Digital_Accesibilidad)
        /// </summary>
        public virtual TDigitalAccesibilidad TDigitalAccesibilidad { get; set; } // FK_FichasBase_T_Digital_Accesibilidad

        /// <summary>
        /// Parent TDrm pointed by [FichasBase].([IdDrm]) (FK_FichasBase_T_DRM)
        /// </summary>
        public virtual TDrm TDrm { get; set; } // FK_FichasBase_T_DRM

        /// <summary>
        /// Parent TEstadosSeguimiento pointed by [FichasBase].([IdEstadoSeguimiento]) (FK_FichasBase_T_EstadosSeguimiento)
        /// </summary>
        public virtual TEstadosSeguimiento TEstadosSeguimiento { get; set; } // FK_FichasBase_T_EstadosSeguimiento

        /// <summary>
        /// Parent TFasesMaterial pointed by [FichasBase].([IdFase]) (FK_FichasBase_T_FasesMaterial)
        /// </summary>
        public virtual TFasesMaterial TFasesMaterial { get; set; } // FK_FichasBase_T_FasesMaterial

        /// <summary>
        /// Parent TGenero pointed by [FichasBase].([IdGenero]) (FK_FichasBase_T_Generos)
        /// </summary>
        public virtual TGenero TGenero { get; set; } // FK_FichasBase_T_Generos

        /// <summary>
        /// Parent TiposArticulo pointed by [FichasBase].([IdTipoArticulo]) (FK_FichasBase_TiposArticulos)
        /// </summary>
        public virtual TiposArticulo TiposArticulo { get; set; } // FK_FichasBase_TiposArticulos

        /// <summary>
        /// Parent TiposEncuadernacion pointed by [FichasBase].([TipoEncuadernacion]) (FK_FichasBase_TiposEncuadernacion)
        /// </summary>
        public virtual TiposEncuadernacion TiposEncuadernacion { get; set; } // FK_FichasBase_TiposEncuadernacion

        /// <summary>
        /// Parent TProyecto pointed by [FichasBase].([IdProyecto]) (FK_FichasBase_T_Proyectos)
        /// </summary>
        public virtual TProyecto TProyecto_IdProyecto { get; set; } // FK_FichasBase_T_Proyectos

        /// <summary>
        /// Parent TProyecto pointed by [FichasBase].([IdProyectoAdicional]) (FK_FichasBase_T_Proyectos_Adicional)
        /// </summary>
        public virtual TProyecto TProyecto_IdProyectoAdicional { get; set; } // FK_FichasBase_T_Proyectos_Adicional

        /// <summary>
        /// Parent TProyectosGestion pointed by [FichasBase].([IdProyectoGestion]) (FK_FichasBase_T_ProyectosGestion)
        /// </summary>
        public virtual TProyectosGestion TProyectosGestion { get; set; } // FK_FichasBase_T_ProyectosGestion

        /// <summary>
        /// Parent TSeries pointed by [FichasBase].([IdSerie]) (FK_FichasBase_T_Series)
        /// </summary>
        public virtual TSeries TSeries { get; set; } // FK_FichasBase_T_Series

        /// <summary>
        /// Parent TTiposMateriale pointed by [FichasBase].([IdTipoMaterialSap]) (FK_FichasBase_T_TiposMateriales)
        /// </summary>
        public virtual TTiposMateriale TTiposMateriale { get; set; } // FK_FichasBase_T_TiposMateriales

        /// <summary>
        /// Parent TTiposMaterialEducativo pointed by [FichasBase].([IdTipoMaterialEducativo]) (FK_FichasBase_T_TiposMaterialEducativo)
        /// </summary>
        public virtual TTiposMaterialEducativo TTiposMaterialEducativo { get; set; } // FK_FichasBase_T_TiposMaterialEducativo

        /// <summary>
        /// Parent TTiposPublicacion pointed by [FichasBase].([IdTipoPublicacion]) (FK_FichasBase_T_TiposPublicacion)
        /// </summary>
        public virtual TTiposPublicacion TTiposPublicacion { get; set; } // FK_FichasBase_T_TiposPublicacion

        /// <summary>
        /// Parent TUsosComerciale pointed by [FichasBase].([IdUsoComercial]) (FK_FichasBase_T_UsosComerciales)
        /// </summary>
        public virtual TUsosComerciale TUsosComerciale { get; set; } // FK_FichasBase_T_UsosComerciales

        /// <summary>
        /// Parent TZonasGeografica pointed by [FichasBase].([IdZonaGeografica]) (FK_FichasBase_T_ZonasGeograficas)
        /// </summary>
        public virtual TZonasGeografica TZonasGeografica { get; set; } // FK_FichasBase_T_ZonasGeograficas

        /// <summary>
        /// Parent Usuario pointed by [FichasBase].([UsuarioPublicacion]) (FK_FichasBase_Usuarios)
        /// </summary>
        public virtual Usuario Usuario_UsuarioPublicacion { get; set; } // FK_FichasBase_Usuarios

        /// <summary>
        /// Parent Usuario pointed by [FichasBase].([UsuarioRetirada]) (FK_FichasBase_Usuarios1)
        /// </summary>
        public virtual Usuario Usuario_UsuarioRetirada { get; set; } // FK_FichasBase_Usuarios1

        [NotMapped]
        public E2Lineasproducto E2Lineasproducto { get; set; } // FK_FichasBase_E2_ACL_DOMINIOS

        public FichasBase()
        {
            PublicableWeb = 0;
            FechaCreacion = System.DateTime.Now;
            UsuarioCreacion = @"REDGESM\SAP";
            SoloIlustracion = false;
            NEjemplaresCaja = 0;
            Bilingue = false;
            Baja = false;
            BajaSoloECat = false;
            PublicoDilve = false;
            Documentoes = new System.Collections.Generic.List<Documento>();
            E2FichasBaseComentario = new System.Collections.Generic.List<E2FichasBaseComentario>();
            E2FichasBasePalabrasClave = new System.Collections.Generic.List<E2FichasBasePalabrasClave>();
            E2FichasBasePremio = new System.Collections.Generic.List<E2FichasBasePremio>();
            E2GeRamaslibro = new System.Collections.Generic.List<E2GeRamaslibro>();
            E2RamasclasifFicha = new System.Collections.Generic.List<E2RamasclasifFicha>();
            E2Tiradasedicion = new System.Collections.Generic.List<E2Tiradasedicion>();
            Fechas = new System.Collections.Generic.List<Fecha>();
            FichasAplicacions = new System.Collections.Generic.List<FichasAplicacion>();
            FichasBaseArchivoHistoricoes = new System.Collections.Generic.List<FichasBaseArchivoHistorico>();
            FichasBaseCamposLibres = new System.Collections.Generic.List<FichasBaseCamposLibre>();
            FichasBaseCicloCursoes = new System.Collections.Generic.List<FichasBaseCicloCurso>();
            FichasBaseClasificacionEcis = new System.Collections.Generic.List<FichasBaseClasificacionEci>();
            FichasBaseCodigoCdus = new System.Collections.Generic.List<FichasBaseCodigoCdu>();
            FichasBaseIdiomasSecundarios = new System.Collections.Generic.List<FichasBaseIdiomasSecundario>();
            FichasBaseSoportes = new System.Collections.Generic.List<FichasBaseSoporte>();
            FichasBaseTesauroes = new System.Collections.Generic.List<FichasBaseTesauro>();
            RelFichasPersonas = new System.Collections.Generic.List<RelFichasPersona>();
            RelFrasesDescriptivas = new System.Collections.Generic.List<RelFrasesDescriptiva>();
            Resenas = new System.Collections.Generic.List<Resena>();
            TActualizacionesDetalles = new System.Collections.Generic.List<TActualizacionesDetalle>();
            TFichasBaseAmbitosCesions = new System.Collections.Generic.List<TFichasBaseAmbitosCesion>();
            TFichasBaseHistoricoEstadoSeguimientoes = new System.Collections.Generic.List<TFichasBaseHistoricoEstadoSeguimiento>();
            TFichasBaseHistoricoFases = new System.Collections.Generic.List<TFichasBaseHistoricoFase>();
            TFichasBaseMaterialesReferencias_IdInterno = new System.Collections.Generic.List<TFichasBaseMaterialesReferencia>();
            TFichasBaseMaterialesReferencias_IdInternoReferencia = new System.Collections.Generic.List<TFichasBaseMaterialesReferencia>();
            TbFichasBaseImagenes = new System.Collections.Generic.List<TbFichasBaseImagene>();
            TitulosAfines = new System.Collections.Generic.List<TitulosAfine>();
            TitulosAnejoes = new System.Collections.Generic.List<TitulosAnejo>();
            Efemerides = new System.Collections.Generic.List<Efemeride>();
            TDigitalPlataformas = new System.Collections.Generic.List<TDigitalPlataforma>();
        }
    }
}