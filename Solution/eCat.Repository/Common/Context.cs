namespace eCat.Repository.Common
{
    #region Using

    using System.Data.Entity;
    using Data.Entities;
    using Mapped;

    #endregion

    public class Context : DbContext
    {
        #region Members

        public System.Data.Entity.DbSet<Aplicacione> Aplicaciones { get; set; } // Aplicaciones
        public System.Data.Entity.DbSet<AuditoriaBusqueda> AuditoriaBusquedas { get; set; } // Auditoria_Busquedas
        public System.Data.Entity.DbSet<AuditoriaBusquedaGeneral> AuditoriaBusquedaGenerals { get; set; } // Auditoria_BusquedaGeneral
        public System.Data.Entity.DbSet<AuditoriaBusquedasSinUsuario> AuditoriaBusquedasSinUsuarios { get; set; } // Auditoria_Busquedas_Sin_Usuario
        public System.Data.Entity.DbSet<AuditoriaFichasBase> AuditoriaFichasBases { get; set; } // Auditoria_FichasBase
        public System.Data.Entity.DbSet<Biografia> Biografias { get; set; } // Biografias
        public System.Data.Entity.DbSet<BiografiasBackupProduccion20160420> BiografiasBackupProduccion20160420 { get; set; } // __Biografias_Backup_Produccion_20160420
        public System.Data.Entity.DbSet<BookmasterBisac> BookmasterBisacs { get; set; } // BOOKMASTER_Bisac
        public System.Data.Entity.DbSet<ClasificacionEci> ClasificacionEcis { get; set; } // Clasificacion_ECI
        public System.Data.Entity.DbSet<CodigoCdu> CodigoCdus { get; set; } // Codigo_CDU
        public System.Data.Entity.DbSet<CoEditoriale> CoEditoriales { get; set; } // CoEditoriales
        public System.Data.Entity.DbSet<Consulta> Consultas { get; set; } // _Consultas
        public System.Data.Entity.DbSet<Consultassql> Consultassqls { get; set; } // consultassql
        public System.Data.Entity.DbSet<DescargasFichero> DescargasFicheroes { get; set; } // DescargasFicheros
        public System.Data.Entity.DbSet<DilveCicloEducativoAnele> DilveCicloEducativoAneles { get; set; } // DILVE_CicloEducativoANELE
        public System.Data.Entity.DbSet<DilveClasificacionBicEquivalenciasSchemeIdentifier> DilveClasificacionBicEquivalenciasSchemeIdentifiers { get; set; } // DILVE_ClasificacionBIC_Equivalencias_SchemeIdentifier
        public System.Data.Entity.DbSet<DilveComunidadAutonoma> DilveComunidadAutonomas { get; set; } // DILVE_ComunidadAutonoma
        public System.Data.Entity.DbSet<DilveCursoAnele> DilveCursoAneles { get; set; } // DILVE_CursoANELE
        public System.Data.Entity.DbSet<DilveDetallePresentacionProducto> DilveDetallePresentacionProductoes { get; set; } // DILVE_DetallePresentacionProducto
        public System.Data.Entity.DbSet<DilveDisponibilidad> DilveDisponibilidads { get; set; } // DILVE_Disponibilidad
        public System.Data.Entity.DbSet<DilveDrm> DilveDrms { get; set; } // DILVE_DRM
        public System.Data.Entity.DbSet<DilveEditoriale> DilveEditoriales { get; set; } // DILVE_Editoriales
        public System.Data.Entity.DbSet<DilveEstado> DilveEstadoes { get; set; } // DILVE_Estados
        public System.Data.Entity.DbSet<DilveFormatoProducto> DilveFormatoProductoes { get; set; } // DILVE_FormatoProducto
        public System.Data.Entity.DbSet<DilveFormatoProductoDetallePresentacionEquivalencia> DilveFormatoProductoDetallePresentacionEquivalencias { get; set; } // DILVE_FormatoProducto_DetallePresentacion_Equivalencias
        public System.Data.Entity.DbSet<DilveFormatoSoporteDigital> DilveFormatoSoporteDigitals { get; set; } // DILVE_FormatoSoporteDigital
        public System.Data.Entity.DbSet<DilveIdioma> DilveIdiomas { get; set; } // DILVE_Idiomas
        public System.Data.Entity.DbSet<DilveMateria> DilveMaterias { get; set; } // DILVE_Materias
        public System.Data.Entity.DbSet<DilveMaterialEducativoAnele> DilveMaterialEducativoAneles { get; set; } // DILVE_MaterialEducativoANELE
        public System.Data.Entity.DbSet<DilveNivelEducativoAnele> DilveNivelEducativoAneles { get; set; } // DILVE_NivelEducativoANELE
        public System.Data.Entity.DbSet<DilvePais> DilvePais { get; set; } // DILVE_Paises
        public System.Data.Entity.DbSet<DilvePublicoObjetivo> DilvePublicoObjetivoes { get; set; } // DILVE_PublicoObjetivo
        public System.Data.Entity.DbSet<DilveRole> DilveRoles { get; set; } // DILVE_Roles
        public System.Data.Entity.DbSet<DilveSituacionCatalogoEditorial> DilveSituacionCatalogoEditorials { get; set; } // DILVE_SituacionCatalogoEditorial
        public System.Data.Entity.DbSet<DilveTerritorio> DilveTerritorios { get; set; } // DILVE_Territorios
        public System.Data.Entity.DbSet<Documento> Documentoes { get; set; } // Documentos
        public System.Data.Entity.DbSet<Dtproperty> Dtproperties { get; set; } // dtproperties
        public System.Data.Entity.DbSet<E2AclDominio> E2AclDominio { get; set; } // E2_ACL_DOMINIOS
        public System.Data.Entity.DbSet<E2AclDominiosIdioma> E2AclDominiosIdioma { get; set; } // E2_ACL_DOMINIOS_Idioma
        public System.Data.Entity.DbSet<E2AclDominiosJerarquia> E2AclDominiosJerarquia { get; set; } // E2_ACL_DOMINIOS_JERARQUIAS
        public System.Data.Entity.DbSet<E2AclDominiosJerarquiasLineaNegocio> E2AclDominiosJerarquiasLineaNegocio { get; set; } // E2_ACL_DOMINIOS_JERARQUIAS_LineaNegocio
        public System.Data.Entity.DbSet<E2AclGrupos> E2AclGrupos { get; set; } // E2_ACL_GRUPOS
        public System.Data.Entity.DbSet<E2AclObjeto> E2AclObjeto { get; set; } // E2_ACL_OBJETOS
        public System.Data.Entity.DbSet<E2AclObjetosIdioma> E2AclObjetosIdioma { get; set; } // E2_ACL_OBJETOS_Idioma
        public System.Data.Entity.DbSet<E2AclRelGruposobjeto> E2AclRelGruposobjeto { get; set; } // E2_ACL_REL_GRUPOSOBJETOS
        public System.Data.Entity.DbSet<E2AclTiposObjeto> E2AclTiposObjeto { get; set; } // E2_ACL_TIPOS_OBJETOS
        public System.Data.Entity.DbSet<E2CamposConsulta> E2CamposConsulta { get; set; } // E2_CAMPOS_CONSULTA
        public System.Data.Entity.DbSet<E2CamposConsultaIdioma> E2CamposConsultaIdioma { get; set; } // E2_CAMPOS_CONSULTA_Idioma
        public System.Data.Entity.DbSet<E2CamposRelacione> E2CamposRelacione { get; set; } // E2_CAMPOS_RELACIONES
        public System.Data.Entity.DbSet<E2CatalogFieldFilter> E2CatalogFieldFilter { get; set; } // E2_CatalogFieldFilters
        public System.Data.Entity.DbSet<E2CatalogFieldFiltersIdioma> E2CatalogFieldFiltersIdioma { get; set; } // E2_CatalogFieldFilters_Idioma
        public System.Data.Entity.DbSet<E2ClasificacionesGestion> E2ClasificacionesGestion { get; set; } // E2_CLASIFICACIONES_GESTION
        public System.Data.Entity.DbSet<E2Consulta> E2Consulta { get; set; } // E2_CONSULTAS
        public System.Data.Entity.DbSet<E2ConsultasAsistente> E2ConsultasAsistente { get; set; } // E2_CONSULTAS_ASISTENTE
        public System.Data.Entity.DbSet<E2ConsultasAsistenteCampos> E2ConsultasAsistenteCampos { get; set; } // E2_CONSULTAS_ASISTENTE_CAMPOS
        public System.Data.Entity.DbSet<E2ConsultasAsistenteFiltro> E2ConsultasAsistenteFiltro { get; set; } // E2_CONSULTAS_ASISTENTE_FILTROS
        public System.Data.Entity.DbSet<E2ConsultasFiltro> E2ConsultasFiltro { get; set; } // E2_CONSULTAS_FILTROS
        public System.Data.Entity.DbSet<E2DatosMinimosCampos> E2DatosMinimosCampos { get; set; } // E2_DATOS_MINIMOS_CAMPOS
        public System.Data.Entity.DbSet<E2DatosMinimosJerarquiaCampos> E2DatosMinimosJerarquiaCampos { get; set; } // E2_DATOS_MINIMOS_JERARQUIA_CAMPOS
        public System.Data.Entity.DbSet<E2DatosMinimosJerarquiaValore> E2DatosMinimosJerarquiaValore { get; set; } // E2_DATOS_MINIMOS_JERARQUIA_VALORES
        public System.Data.Entity.DbSet<E2DatosMinimosValore> E2DatosMinimosValore { get; set; } // E2_DATOS_MINIMOS_VALORES
        public System.Data.Entity.DbSet<E2EquivalenciaCampos> E2EquivalenciaCampos { get; set; } // E2_EQUIVALENCIA_CAMPOS
        public System.Data.Entity.DbSet<E2EquivalenciaClasificacione> E2EquivalenciaClasificacione { get; set; } // E2_EQUIVALENCIA_CLASIFICACIONES
        public System.Data.Entity.DbSet<E2EquivalenciaClasificacionesCondicione> E2EquivalenciaClasificacionesCondicione { get; set; } // E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES
        public System.Data.Entity.DbSet<E2FichasBaseComentario> E2FichasBaseComentario { get; set; } // E2_FichasBase_Comentarios
        public System.Data.Entity.DbSet<E2FichasBasePalabrasClave> E2FichasBasePalabrasClave { get; set; } // E2_FichasBase_PalabrasClave
        public System.Data.Entity.DbSet<E2FichasBasePremio> E2FichasBasePremio { get; set; } // E2_FichasBase_Premios
        public System.Data.Entity.DbSet<E2GeCatalogo> E2GeCatalogo { get; set; } // E2_GE_CATALOGOS
        public System.Data.Entity.DbSet<E2GeCatalogosCompartido> E2GeCatalogosCompartido { get; set; } // E2_GE_CATALOGOS_COMPARTIDOS
        public System.Data.Entity.DbSet<E2GePlantillanodo> E2GePlantillanodo { get; set; } // E2_GE_PLANTILLANODO
        public System.Data.Entity.DbSet<E2GePlantillanodoIdioma> E2GePlantillanodoIdioma { get; set; } // E2_GE_PLANTILLANODO_Idioma
        public System.Data.Entity.DbSet<E2GeRamasarbol> E2GeRamasarbol { get; set; } // E2_GE_RAMASARBOL
        public System.Data.Entity.DbSet<E2GeRamaslibro> E2GeRamaslibro { get; set; } // E2_GE_RAMASLIBROS
        public System.Data.Entity.DbSet<E2GeTiponodo> E2GeTiponodo { get; set; } // E2_GE_TIPONODO
        public System.Data.Entity.DbSet<E2GeTiponodoIdioma> E2GeTiponodoIdioma { get; set; } // E2_GE_TIPONODO_Idioma
        public System.Data.Entity.DbSet<E2GruposArticulo> E2GruposArticulo { get; set; } // E2_GRUPOS_ARTICULOS
        public System.Data.Entity.DbSet<E2GruposArticulosIdioma> E2GruposArticulosIdioma { get; set; } // E2_GRUPOS_ARTICULOS_Idioma
        public System.Data.Entity.DbSet<E2Lineasproducto> E2Lineasproducto { get; set; } // E2_LINEASPRODUCTO
        public System.Data.Entity.DbSet<E2LineasproductoIdioma> E2LineasproductoIdioma { get; set; } // E2_LINEASPRODUCTO_Idioma
        public System.Data.Entity.DbSet<E2LogEcat> E2LogEcat { get; set; } // E2_LOG_ECAT
        public System.Data.Entity.DbSet<E2Mensaje> E2Mensaje { get; set; } // E2_MENSAJES
        public System.Data.Entity.DbSet<E2ParametrosDominio> E2ParametrosDominio { get; set; } // E2_PARAMETROS_DOMINIO
        public System.Data.Entity.DbSet<E2RamasclasifFicha> E2RamasclasifFicha { get; set; } // E2_RAMASCLASIF_FICHAS
        public System.Data.Entity.DbSet<E2RamasClasificacionesGestion> E2RamasClasificacionesGestion { get; set; } // E2_RAMAS_CLASIFICACIONES_GESTION
        public System.Data.Entity.DbSet<E2Tiradasedicion> E2Tiradasedicion { get; set; } // E2_TIRADASEDICION
        public System.Data.Entity.DbSet<E2VwLibrosListosParaWeb> E2VwLibrosListosParaWeb { get; set; } // E2_vw_LibrosListosParaWeb
        public System.Data.Entity.DbSet<E2VwMaximaEdicion> E2VwMaximaEdicion { get; set; } // E2_vw_MaximaEdicion
        public System.Data.Entity.DbSet<E2VwNumeroEdicione> E2VwNumeroEdicione { get; set; } // E2_vw_NumeroEdiciones
        public System.Data.Entity.DbSet<Edade> Edades { get; set; } // Edades
        public System.Data.Entity.DbSet<EdadesIdioma> EdadesIdiomas { get; set; } // Edades_Idioma
        public System.Data.Entity.DbSet<Editoriale> Editoriales { get; set; } // Editoriales
        public System.Data.Entity.DbSet<Efemeride> Efemerides { get; set; } // Efemerides
        public System.Data.Entity.DbSet<EfemeridesGrupos> EfemeridesGrupos { get; set; } // EfemeridesGrupos
        public System.Data.Entity.DbSet<EstadosSap> EstadosSaps { get; set; } // EstadosSAP
        public System.Data.Entity.DbSet<EstadosSapIdioma> EstadosSapIdiomas { get; set; } // EstadosSAP_Idioma
        public System.Data.Entity.DbSet<Evento> Eventoes { get; set; } // Eventos
        public System.Data.Entity.DbSet<Fecha> Fechas { get; set; } // Fechas
        public System.Data.Entity.DbSet<FichasAplicacion> FichasAplicacions { get; set; } // FichasAplicacion
        public System.Data.Entity.DbSet<FichasBase> FichasBases { get; set; } // FichasBase
        public System.Data.Entity.DbSet<FichasBaseArchivoHistorico> FichasBaseArchivoHistoricoes { get; set; } // FichasBase_ArchivoHistorico
        public System.Data.Entity.DbSet<FichasBaseCamposLibre> FichasBaseCamposLibres { get; set; } // FichasBase_CamposLibres
        public System.Data.Entity.DbSet<FichasBaseCicloCurso> FichasBaseCicloCursoes { get; set; } // FichasBase_CicloCurso
        public System.Data.Entity.DbSet<FichasBaseClasificacionEci> FichasBaseClasificacionEcis { get; set; } // FichasBase_ClasificacionECI
        public System.Data.Entity.DbSet<FichasBaseCodigoCdu> FichasBaseCodigoCdus { get; set; } // FichasBase_CodigoCDU
        public System.Data.Entity.DbSet<FichasBaseIdiomasSecundario> FichasBaseIdiomasSecundarios { get; set; } // FichasBase_IdiomasSecundarios
        public System.Data.Entity.DbSet<FichasBaseNavidadMarianista> FichasBaseNavidadMarianistas { get; set; } // FichasBase_NavidadMarianista
        public System.Data.Entity.DbSet<FichasBaseSoporte> FichasBaseSoportes { get; set; } // FichasBase_Soporte
        public System.Data.Entity.DbSet<FichasBaseTesauro> FichasBaseTesauroes { get; set; } // FichasBase_Tesauro
        public System.Data.Entity.DbSet<Idioma> Idiomas { get; set; } // Idiomas
        public System.Data.Entity.DbSet<IdiomasIdioma> IdiomasIdiomas { get; set; } // Idiomas_Idioma
        public System.Data.Entity.DbSet<LineaNegocio> LineaNegocios { get; set; } // LineaNegocio
        public System.Data.Entity.DbSet<Medio> Medios { get; set; } // Medios
        public System.Data.Entity.DbSet<PalabrasClave> PalabrasClaves { get; set; } // PalabrasClave
        public System.Data.Entity.DbSet<PalabrasClaveGrupos> PalabrasClaveGrupos { get; set; } // PalabrasClaveGrupos
        public System.Data.Entity.DbSet<Parametro> Parametroes { get; set; } // Parametros
        public System.Data.Entity.DbSet<PeAreasGlobale> PeAreasGlobales { get; set; } // PE_AreasGlobales
        public System.Data.Entity.DbSet<PeAreasGlobalesIdioma> PeAreasGlobalesIdiomas { get; set; } // PE_AreasGlobales_Idioma
        public System.Data.Entity.DbSet<PeAreasGlobalesMateria> PeAreasGlobalesMaterias { get; set; } // PE_AreasGlobales_Materias
        public System.Data.Entity.DbSet<PeComponente> PeComponentes { get; set; } // PE_Componentes
        public System.Data.Entity.DbSet<PeComponentesDestino> PeComponentesDestinoes { get; set; } // PE_Componentes_Destinos
        public System.Data.Entity.DbSet<PeComponentesDestinosIdioma> PeComponentesDestinosIdiomas { get; set; } // PE_Componentes_Destinos_Idioma
        public System.Data.Entity.DbSet<PeComponentesDocumento> PeComponentesDocumentoes { get; set; } // PE_Componentes_Documentos
        public System.Data.Entity.DbSet<PeComponentesEstado> PeComponentesEstadoes { get; set; } // PE_Componentes_Estados
        public System.Data.Entity.DbSet<PeComponentesEstadosIdioma> PeComponentesEstadosIdiomas { get; set; } // PE_Componentes_Estados_Idioma
        public System.Data.Entity.DbSet<PeComponentesFormato> PeComponentesFormatoes { get; set; } // PE_Componentes_Formatos
        public System.Data.Entity.DbSet<PeComponentesFormatosIdioma> PeComponentesFormatosIdiomas { get; set; } // PE_Componentes_Formatos_Idioma
        public System.Data.Entity.DbSet<PeComponentesTipos> PeComponentesTipos { get; set; } // PE_Componentes_Tipos
        public System.Data.Entity.DbSet<PeComponentesTiposIdioma> PeComponentesTiposIdiomas { get; set; } // PE_Componentes_Tipos_Idioma
        public System.Data.Entity.DbSet<PeComponentesTiposMaterialesGruposArticulo> PeComponentesTiposMaterialesGruposArticuloes { get; set; } // PE_Componentes_TiposMateriales_GruposArticulos
        public System.Data.Entity.DbSet<PeDocumento> PeDocumentoes { get; set; } // PE_Documentos
        public System.Data.Entity.DbSet<PeDocumentosExtensionesPermitida> PeDocumentosExtensionesPermitidas { get; set; } // PE_Documentos_ExtensionesPermitidas
        public System.Data.Entity.DbSet<PeEstructuraEdade> PeEstructuraEdades { get; set; } // PE_EstructuraEdades
        public System.Data.Entity.DbSet<PeEstructuraEdadesNivelesEducativo> PeEstructuraEdadesNivelesEducativoes { get; set; } // PE_EstructuraEdades_NivelesEducativos
        public System.Data.Entity.DbSet<PePlanesEditoriale> PePlanesEditoriales { get; set; } // PE_PlanesEditoriales
        public System.Data.Entity.DbSet<PePlanesEditorialesDocumento> PePlanesEditorialesDocumentoes { get; set; } // PE_PlanesEditoriales_Documentos
        public System.Data.Entity.DbSet<PePmp> PePmps { get; set; } // PE_PMPs
        public System.Data.Entity.DbSet<PePmPsDocumento> PePmPsDocumentoes { get; set; } // PE_PMPs_Documentos
        public System.Data.Entity.DbSet<PeProyecto> PeProyectoes { get; set; } // PE_Proyectos
        public System.Data.Entity.DbSet<PeProyectosAreasGlobalesMateria> PeProyectosAreasGlobalesMaterias { get; set; } // PE_Proyectos_AreasGlobales_Materias
        public System.Data.Entity.DbSet<PeProyectosDocumento> PeProyectosDocumentoes { get; set; } // PE_Proyectos_Documentos
        public System.Data.Entity.DbSet<PeProyectosEstado> PeProyectosEstadoes { get; set; } // PE_Proyectos_Estados
        public System.Data.Entity.DbSet<PeProyectosEstadosIdioma> PeProyectosEstadosIdiomas { get; set; } // PE_Proyectos_Estados_Idioma
        public System.Data.Entity.DbSet<PeProyectosMarco> PeProyectosMarcoes { get; set; } // PE_ProyectosMarco
        public System.Data.Entity.DbSet<PeProyectosMarcoDocumento> PeProyectosMarcoDocumentoes { get; set; } // PE_ProyectosMarco_Documentos
        public System.Data.Entity.DbSet<PeProyectosMarcoPreferenciasExplotacion> PeProyectosMarcoPreferenciasExplotacions { get; set; } // PE_ProyectosMarco_PreferenciasExplotacion
        public System.Data.Entity.DbSet<PeProyectosNivelesEducativo> PeProyectosNivelesEducativoes { get; set; } // PE_Proyectos_NivelesEducativos
        public System.Data.Entity.DbSet<PeProyectosPreferenciasExplotacion> PeProyectosPreferenciasExplotacions { get; set; } // PE_Proyectos_PreferenciasExplotacion
        public System.Data.Entity.DbSet<Persona> Personas { get; set; } // Personas
        public System.Data.Entity.DbSet<PeTitulosPrincipale> PeTitulosPrincipales { get; set; } // PE_TitulosPrincipales
        public System.Data.Entity.DbSet<PeTitulosPrincipalesComponente> PeTitulosPrincipalesComponentes { get; set; } // PE_TitulosPrincipales_Componentes
        public System.Data.Entity.DbSet<PeTitulosPrincipalesDocumento> PeTitulosPrincipalesDocumentoes { get; set; } // PE_TitulosPrincipales_Documentos
        public System.Data.Entity.DbSet<PeTitulosPrincipalesEstado> PeTitulosPrincipalesEstadoes { get; set; } // PE_TitulosPrincipales_Estados
        public System.Data.Entity.DbSet<PeTitulosPrincipalesEstadosIdioma> PeTitulosPrincipalesEstadosIdiomas { get; set; } // PE_TitulosPrincipales_Estados_Idioma
        public System.Data.Entity.DbSet<Premio> Premios { get; set; } // Premios
        public System.Data.Entity.DbSet<PremiosIdioma> PremiosIdiomas { get; set; } // Premios_Idioma
        public System.Data.Entity.DbSet<PublicoObjetivo> PublicoObjetivoes { get; set; } // PublicoObjetivo
        public System.Data.Entity.DbSet<PublicoObjetivoIdioma> PublicoObjetivoIdiomas { get; set; } // PublicoObjetivo_Idioma
        public System.Data.Entity.DbSet<RelFichasPersona> RelFichasPersonas { get; set; } // RelFichasPersonas
        public System.Data.Entity.DbSet<RelFrasesDescriptiva> RelFrasesDescriptivas { get; set; } // RelFrasesDescriptivas
        public System.Data.Entity.DbSet<Resena> Resenas { get; set; } // Resenas
        public System.Data.Entity.DbSet<Role> Roles { get; set; } // Roles
        public System.Data.Entity.DbSet<RolesIdioma> RolesIdiomas { get; set; } // Roles_Idioma
        public System.Data.Entity.DbSet<SinliAudiencia> SinliAudiencias { get; set; } // SINLI_AUDIENCIAS
        public System.Data.Entity.DbSet<SinliCautonoma> SinliCautonomas { get; set; } // SINLI_CAUTONOMAS
        public System.Data.Entity.DbSet<SinliE2Encuadernacione> SinliE2Encuadernacione { get; set; } // SINLI_E2_ENCUADERNACIONES
        public System.Data.Entity.DbSet<SinliE2Estado> SinliE2Estado { get; set; } // SINLI_E2_ESTADOS
        public System.Data.Entity.DbSet<SinliE2Lengua> SinliE2Lengua { get; set; } // SINLI_E2_LENGUAS
        public System.Data.Entity.DbSet<SinliE2Tiposproducto> SinliE2Tiposproducto { get; set; } // SINLI_E2_TIPOSPRODUCTO
        public System.Data.Entity.DbSet<SinliEncuadernacione> SinliEncuadernaciones { get; set; } // SINLI_ENCUADERNACIONES
        public System.Data.Entity.DbSet<SinliEstado> SinliEstadoes { get; set; } // SINLI_ESTADOS
        public System.Data.Entity.DbSet<SinliLengua> SinliLenguas { get; set; } // SINLI_LENGUAS
        public System.Data.Entity.DbSet<SinliMateria> SinliMaterias { get; set; } // SINLI_MATERIAS
        public System.Data.Entity.DbSet<SinliNiveleslectura> SinliNiveleslecturas { get; set; } // SINLI_NIVELESLECTURA
        public System.Data.Entity.DbSet<SinliPais> SinliPais { get; set; } // SINLI_PAISES
        public System.Data.Entity.DbSet<SinliSubmateria> SinliSubmaterias { get; set; } // SINLI_SUBMATERIAS
        public System.Data.Entity.DbSet<SinliTiposproducto> SinliTiposproductoes { get; set; } // SINLI_TIPOSPRODUCTO
        public System.Data.Entity.DbSet<TAccessToken> TAccessTokens { get; set; } // T_Access_Token
        public System.Data.Entity.DbSet<TActualizacionesCabecera> TActualizacionesCabeceras { get; set; } // T_Actualizaciones_Cabecera
        public System.Data.Entity.DbSet<TActualizacionesCampos> TActualizacionesCampos { get; set; } // T_Actualizaciones_Campos
        public System.Data.Entity.DbSet<TActualizacionesCamposIdioma> TActualizacionesCamposIdiomas { get; set; } // T_Actualizaciones_Campos_Idiomas
        public System.Data.Entity.DbSet<TActualizacionesDetalle> TActualizacionesDetalles { get; set; } // T_Actualizaciones_Detalle
        public System.Data.Entity.DbSet<TActualizacionesEstado> TActualizacionesEstadoes { get; set; } // T_Actualizaciones_Estados
        public System.Data.Entity.DbSet<TActualizacionesEstadosIdioma> TActualizacionesEstadosIdiomas { get; set; } // T_Actualizaciones_Estados_Idioma
        public System.Data.Entity.DbSet<TActualizacionesEstadosMateriale> TActualizacionesEstadosMateriales { get; set; } // T_Actualizaciones_Estados_Materiales
        public System.Data.Entity.DbSet<TActualizacionesEstadosMaterialesIdioma> TActualizacionesEstadosMaterialesIdiomas { get; set; } // T_Actualizaciones_Estados_Materiales_Idioma
        public System.Data.Entity.DbSet<TActualizacionesTiposActualizacion> TActualizacionesTiposActualizacions { get; set; } // T_Actualizaciones_TiposActualizacion
        public System.Data.Entity.DbSet<TActualizacionesTiposActualizacionIdioma> TActualizacionesTiposActualizacionIdiomas { get; set; } // T_Actualizaciones_TiposActualizacion_Idioma
        public System.Data.Entity.DbSet<TActualizacionesTiposCampo> TActualizacionesTiposCampoes { get; set; } // T_Actualizaciones_TiposCampo
        public System.Data.Entity.DbSet<TAmbitosCesion> TAmbitosCesions { get; set; } // T_AmbitosCesion
        public System.Data.Entity.DbSet<TAmbitosCesionEstado> TAmbitosCesionEstadoes { get; set; } // T_AmbitosCesion_Estados
        public System.Data.Entity.DbSet<TAmbitosCesionGrupos> TAmbitosCesionGrupos { get; set; } // T_AmbitosCesion_Grupos
        public System.Data.Entity.DbSet<TAuditoria> TAuditorias { get; set; } // T_Auditoria
        public System.Data.Entity.DbSet<TAyudaCm> TAyudaCms { get; set; } // T_ayuda_CMS
        public System.Data.Entity.DbSet<TbCamposFicha> TbCamposFichas { get; set; } // TB_CAMPOS_FICHA
        public System.Data.Entity.DbSet<TbCamposFichaElemento> TbCamposFichaElementoes { get; set; } // TB_CAMPOS_FICHA_ELEMENTOS
        public System.Data.Entity.DbSet<TbCamposFichaIdioma> TbCamposFichaIdiomas { get; set; } // TB_Campos_Ficha_Idioma
        public System.Data.Entity.DbSet<TbCamposNivele> TbCamposNiveles { get; set; } // TB_CAMPOS_NIVELES
        public System.Data.Entity.DbSet<TbCamposOrden> TbCamposOrdens { get; set; } // TB_CAMPOS_ORDEN
        public System.Data.Entity.DbSet<TbCamposOrdenIdioma> TbCamposOrdenIdiomas { get; set; } // TB_Campos_Orden_Idioma
        public System.Data.Entity.DbSet<TbDilveEquivalencia> TbDilveEquivalencias { get; set; } // TB_DILVE_EQUIVALENCIAS
        public System.Data.Entity.DbSet<TbFichasBaseImagene> TbFichasBaseImagenes { get; set; } // TB_FichasBase_Imagenes
        public System.Data.Entity.DbSet<TbImagenesTipos> TbImagenesTipos { get; set; } // TB_Imagenes_Tipos
        public System.Data.Entity.DbSet<TbImagenesTiposIdioma> TbImagenesTiposIdiomas { get; set; } // TB_Imagenes_Tipos_Idioma
        public System.Data.Entity.DbSet<TBusquedaGeneralEstado> TBusquedaGeneralEstadoes { get; set; } // T_BusquedaGeneral_Estados
        public System.Data.Entity.DbSet<TBusquedaGeneralEstadosIdioma> TBusquedaGeneralEstadosIdiomas { get; set; } // T_BusquedaGeneral_Estados_Idioma
        public System.Data.Entity.DbSet<TBusquedaGeneralTiposMateriale> TBusquedaGeneralTiposMateriales { get; set; } // T_BusquedaGeneral_TiposMateriales
        public System.Data.Entity.DbSet<TBusquedaGeneralTiposMaterialesIdioma> TBusquedaGeneralTiposMaterialesIdiomas { get; set; } // T_BusquedaGeneral_TiposMateriales_Idioma
        public System.Data.Entity.DbSet<TCampañas> TCampañas { get; set; } // T_Campañas
        public System.Data.Entity.DbSet<TCategoriasCiclo> TCategoriasCicloes { get; set; } // T_CategoriasCiclos
        public System.Data.Entity.DbSet<TCategoriasCiclosIdioma> TCategoriasCiclosIdiomas { get; set; } // T_CategoriasCiclos_Idioma
        public System.Data.Entity.DbSet<TCodigosErrorDilve> TCodigosErrorDilves { get; set; } // T_CodigosError_DILVE
        public System.Data.Entity.DbSet<TColeccione> TColecciones { get; set; } // T_Colecciones
        public System.Data.Entity.DbSet<TColeccionesIdioma> TColeccionesIdiomas { get; set; } // T_Colecciones_Idioma
        public System.Data.Entity.DbSet<TConfiguracionMantenimientosGenericosECat> TConfiguracionMantenimientosGenericosECats { get; set; } // T_Configuracion_MantenimientosGenericos_eCat
        public System.Data.Entity.DbSet<TDigitalAccesibilidad> TDigitalAccesibilidads { get; set; } // T_Digital_Accesibilidad
        public System.Data.Entity.DbSet<TDigitalAccesibilidadIdioma> TDigitalAccesibilidadIdiomas { get; set; } // T_Digital_Accesibilidad_Idioma
        public System.Data.Entity.DbSet<TDigitalPlataforma> TDigitalPlataformas { get; set; } // T_Digital_Plataformas
        public System.Data.Entity.DbSet<TDigitalPlataformasIdioma> TDigitalPlataformasIdiomas { get; set; } // T_Digital_Plataformas_Idioma
        public System.Data.Entity.DbSet<TDrm> TDrms { get; set; } // T_DRM
        public System.Data.Entity.DbSet<TDrmIdioma> TDrmIdiomas { get; set; } // T_DRM_Idioma
        public System.Data.Entity.DbSet<TE2GeCatalogosPreciosEspeciale> TE2GeCatalogosPreciosEspeciale { get; set; } // T_E2_GE_CATALOGOS_PreciosEspeciales
        public System.Data.Entity.DbSet<TE2GeCatalogosPreciosEspecialesCampos> TE2GeCatalogosPreciosEspecialesCampos { get; set; } // T_E2_GE_CATALOGOS_PreciosEspeciales_Campos
        public System.Data.Entity.DbSet<TEdadCurso> TEdadCursoes { get; set; } // T_EdadCurso
        public System.Data.Entity.DbSet<TEdadCursoIdioma> TEdadCursoIdiomas { get; set; } // T_EdadCurso_Idioma
        public System.Data.Entity.DbSet<TEdicionaPlusVisorParametrizacion> TEdicionaPlusVisorParametrizacions { get; set; } // T_EdicionaPlus_Visor_Parametrizacion
        public System.Data.Entity.DbSet<TempUsuariosEncuentrosSm> TempUsuariosEncuentrosSms { get; set; } // TEMP_UsuariosEncuentrosSM
        public System.Data.Entity.DbSet<TEstadosSeguimiento> TEstadosSeguimientoes { get; set; } // T_EstadosSeguimiento
        public System.Data.Entity.DbSet<TEtapasRangoEdad> TEtapasRangoEdads { get; set; } // T_EtapasRangoEdad
        public System.Data.Entity.DbSet<TEtapasRangoEdadIdioma> TEtapasRangoEdadIdiomas { get; set; } // T_EtapasRangoEdad_Idioma
        public System.Data.Entity.DbSet<TFasesMaterial> TFasesMaterials { get; set; } // T_FasesMaterial
        public System.Data.Entity.DbSet<TFasesMaterialIdioma> TFasesMaterialIdiomas { get; set; } // T_FasesMaterial_Idioma
        public System.Data.Entity.DbSet<TFichasBaseAmbitosCesion> TFichasBaseAmbitosCesions { get; set; } // T_FichasBase_AmbitosCesion
        public System.Data.Entity.DbSet<TFichasBaseAmbitosCesionValore> TFichasBaseAmbitosCesionValores { get; set; } // T_FichasBase_AmbitosCesion_Valores
        public System.Data.Entity.DbSet<TFichasBaseAmbitosCesionRestriccion> TFichasBaseAmbitosCesionRestricciones { get; set; }
        public System.Data.Entity.DbSet<TFichasBaseDilveXml> TFichasBaseDilveXmls { get; set; } // T_FichasBase_DILVE_Xml
        public System.Data.Entity.DbSet<TFichasBaseHistoricoEstadoSeguimiento> TFichasBaseHistoricoEstadoSeguimientoes { get; set; } // T_FichasBase_Historico_EstadoSeguimiento
        public System.Data.Entity.DbSet<TFichasBaseHistoricoFase> TFichasBaseHistoricoFases { get; set; } // T_FichasBase_Historico_Fase
        public System.Data.Entity.DbSet<TFichasBaseMaterialesReferencia> TFichasBaseMaterialesReferencias { get; set; } // T_FichasBase_MaterialesReferencia
        public System.Data.Entity.DbSet<TGenero> TGeneroes { get; set; } // T_Generos
        public System.Data.Entity.DbSet<TGenerosIdioma> TGenerosIdiomas { get; set; } // T_Generos_Idioma
        public System.Data.Entity.DbSet<TIdiomasPlataforma> TIdiomasPlataformas { get; set; } // T_Idiomas_Plataforma
        public System.Data.Entity.DbSet<TiposArticulo> TiposArticuloes { get; set; } // TiposArticulos
        public System.Data.Entity.DbSet<TiposArticulosIdioma> TiposArticulosIdiomas { get; set; } // TiposArticulos_Idioma
        public System.Data.Entity.DbSet<TiposDocumento> TiposDocumentoes { get; set; } // TiposDocumentos
        public System.Data.Entity.DbSet<TiposDocumentosIdioma> TiposDocumentosIdiomas { get; set; } // TiposDocumentos_Idioma
        public System.Data.Entity.DbSet<TiposEncuadernacion> TiposEncuadernacions { get; set; } // TiposEncuadernacion
        public System.Data.Entity.DbSet<TiposEncuadernacionIdioma> TiposEncuadernacionIdiomas { get; set; } // TiposEncuadernacion_Idioma
        public System.Data.Entity.DbSet<TiposMedio> TiposMedios { get; set; } // TiposMedios
        public System.Data.Entity.DbSet<TiposMediosIdioma> TiposMediosIdiomas { get; set; } // TiposMedios_Idioma
        public System.Data.Entity.DbSet<TitulosAfine> TitulosAfines { get; set; } // TitulosAfines
        public System.Data.Entity.DbSet<TitulosAnejo> TitulosAnejoes { get; set; } // TitulosAnejos
        public System.Data.Entity.DbSet<TLineasNegocioCamposLibre> TLineasNegocioCamposLibres { get; set; } // T_LineasNegocio_CamposLibres
        public System.Data.Entity.DbSet<TLineasNegocioCamposLibresValore> TLineasNegocioCamposLibresValores { get; set; } // T_LineasNegocio_CamposLibres_Valores
        public System.Data.Entity.DbSet<TLineasNegocioLineasProducto> TLineasNegocioLineasProductoes { get; set; } // T_LineasNegocio_LineasProducto
        public System.Data.Entity.DbSet<TMaterialesReferenciaTipos> TMaterialesReferenciaTipos { get; set; } // T_MaterialesReferencia_Tipos
        public System.Data.Entity.DbSet<TMaterialesreferenciaTiposIdioma> TMaterialesreferenciaTiposIdiomas { get; set; } // T_Materialesreferencia_Tipos_Idioma
        public System.Data.Entity.DbSet<TMercado> TMercadoes { get; set; } // T_Mercado
        public System.Data.Entity.DbSet<TMercadoIdioma> TMercadoIdiomas { get; set; } // T_Mercado_Idioma
        public System.Data.Entity.DbSet<TNegocio> TNegocios { get; set; } // T_Negocio
        public System.Data.Entity.DbSet<TNegocioIdioma> TNegocioIdiomas { get; set; } // T_Negocio_Idioma
        public System.Data.Entity.DbSet<TNoticiasPrincipal> TNoticiasPrincipals { get; set; } // T_NoticiasPrincipal
        public System.Data.Entity.DbSet<TOperacionesConsulta> TOperacionesConsultas { get; set; } // T_OperacionesConsultas
        public System.Data.Entity.DbSet<TOperacionesConsultasIdioma> TOperacionesConsultasIdiomas { get; set; } // T_OperacionesConsultas_Idioma
        public System.Data.Entity.DbSet<TPersonasReferenciasWeb> TPersonasReferenciasWebs { get; set; } // T_Personas_ReferenciasWeb
        public System.Data.Entity.DbSet<TPlanEditorialNivele> TPlanEditorialNiveles { get; set; } // T_PlanEditorial_Niveles
        public System.Data.Entity.DbSet<TPlanEditorialSubNivele> TPlanEditorialSubNiveles { get; set; } // T_PlanEditorial_SubNiveles
        public System.Data.Entity.DbSet<TPortadasColaImagene> TPortadasColaImagenes { get; set; } // T_Portadas_ColaImagenes
        public System.Data.Entity.DbSet<TPortadasEstadosImagene> TPortadasEstadosImagenes { get; set; } // T_Portadas_EstadosImagenes
        public System.Data.Entity.DbSet<TPropietario> TPropietarios { get; set; } // T_Propietario
        public System.Data.Entity.DbSet<TPropietarioIdioma> TPropietarioIdiomas { get; set; } // T_Propietario_Idioma
        public System.Data.Entity.DbSet<TProyecto> TProyectoes { get; set; } // T_Proyectos
        public System.Data.Entity.DbSet<TProyectoSeccion> TProyectoSeccions { get; set; } // T_ProyectoSeccion
        public System.Data.Entity.DbSet<TProyectosGestion> TProyectosGestions { get; set; } // T_ProyectosGestion
        public System.Data.Entity.DbSet<TProyectosGestionIdioma> TProyectosGestionIdiomas { get; set; } // T_ProyectosGestion_Idioma
        public System.Data.Entity.DbSet<TProyectosIdioma> TProyectosIdiomas { get; set; } // T_Proyectos_Idioma
        public System.Data.Entity.DbSet<TProyectosProyectoSeccion> TProyectosProyectoSeccions { get; set; } // T_Proyectos_ProyectoSeccion
        public System.Data.Entity.DbSet<TReferenciasWebTipos> TReferenciasWebTipos { get; set; } // T_ReferenciasWeb_Tipos
        public System.Data.Entity.DbSet<TSeries> TSeries { get; set; } // T_Series
        public System.Data.Entity.DbSet<TSeriesIdioma> TSeriesIdiomas { get; set; } // T_Series_Idioma
        public System.Data.Entity.DbSet<TSoporte> TSoportes { get; set; } // T_Soportes
        public System.Data.Entity.DbSet<TSoportesIdioma> TSoportesIdiomas { get; set; } // T_Soportes_Idioma
        public System.Data.Entity.DbSet<TSubcategoriasMateria> TSubcategoriasMaterias { get; set; } // T_SubcategoriasMaterias
        public System.Data.Entity.DbSet<TSubcategoriasMateriasIdioma> TSubcategoriasMateriasIdiomas { get; set; } // T_SubcategoriasMaterias_Idioma
        public System.Data.Entity.DbSet<TTiposCamposConsulta> TTiposCamposConsultas { get; set; } // T_TiposCampos_Consultas
        public System.Data.Entity.DbSet<TTiposConsulta> TTiposConsultas { get; set; } // T_TiposConsultas
        public System.Data.Entity.DbSet<TTiposConsultasIdioma> TTiposConsultasIdiomas { get; set; } // T_TiposConsultas_Idioma
        public System.Data.Entity.DbSet<TTiposElemento> TTiposElementoes { get; set; } // T_TiposElementos
        public System.Data.Entity.DbSet<TTiposElementosIdioma> TTiposElementosIdiomas { get; set; } // T_TiposElementos_Idioma
        public System.Data.Entity.DbSet<TTiposEnvioDilve> TTiposEnvioDilves { get; set; } // T_TiposEnvio_DILVE
        public System.Data.Entity.DbSet<TTiposMateriale> TTiposMateriales { get; set; } // T_TiposMateriales
        public System.Data.Entity.DbSet<TTiposMaterialEducativo> TTiposMaterialEducativoes { get; set; } // T_TiposMaterialEducativo
        public System.Data.Entity.DbSet<TTiposMaterialEducativoIdioma> TTiposMaterialEducativoIdiomas { get; set; } // T_TiposMaterialEducativo_Idioma
        public System.Data.Entity.DbSet<TTiposMaterialesGruposArticulo> TTiposMaterialesGruposArticuloes { get; set; } // T_TiposMateriales_GruposArticulos
        public System.Data.Entity.DbSet<TTiposMaterialesGruposArticulosPais> TTiposMaterialesGruposArticulosPais { get; set; } // T_TiposMateriales_GruposArticulos_Paises
        public System.Data.Entity.DbSet<TTiposMaterialesGruposArticulosPrefijo> TTiposMaterialesGruposArticulosPrefijoes { get; set; } // T_TiposMateriales_GruposArticulos_Prefijo
        public System.Data.Entity.DbSet<TTiposMaterialesIdioma> TTiposMaterialesIdiomas { get; set; } // T_TiposMateriales_Idioma
        public System.Data.Entity.DbSet<TTiposPublicacion> TTiposPublicacions { get; set; } // T_TiposPublicacion
        public System.Data.Entity.DbSet<TTiposPublicacionIdioma> TTiposPublicacionIdiomas { get; set; } // T_TiposPublicacion_Idioma
        public System.Data.Entity.DbSet<TTiposTituloAfin> TTiposTituloAfins { get; set; } // T_TiposTituloAfin
        public System.Data.Entity.DbSet<TTiposTituloAfinIdioma> TTiposTituloAfinIdiomas { get; set; } // T_TiposTituloAfin_Idioma
        public System.Data.Entity.DbSet<TUsosComerciale> TUsosComerciales { get; set; } // T_UsosComerciales
        public System.Data.Entity.DbSet<TUsosComercialesIdioma> TUsosComercialesIdiomas { get; set; } // T_UsosComerciales_Idioma
        public System.Data.Entity.DbSet<TUsuariosImpersonacion> TUsuariosImpersonacions { get; set; } // T_Usuarios_impersonacion
        public System.Data.Entity.DbSet<TZonasGeografica> TZonasGeograficas { get; set; } // T_ZonasGeograficas
        public System.Data.Entity.DbSet<Usuario> Usuarios { get; set; } // Usuarios
        public System.Data.Entity.DbSet<VwEdicionaPlusGetTesauro> VwEdicionaPlusGetTesauroes { get; set; } // vw_EdicionaPlus_GetTesauro
        public System.Data.Entity.DbSet<VwFichasBaseAmbitoCesion> VwFichasBaseAmbitoCesions { get; set; } // vw_FichasBase_AmbitoCesion
        public System.Data.Entity.DbSet<VwLirInformesJerarquiaECat> VwLirInformesJerarquiaECats { get; set; } // vw_LIR_Informes_Jerarquia_ECat
        public System.Data.Entity.DbSet<VwPortada> VwPortadas { get; set; } // vw_Portadas
        public System.Data.Entity.DbSet<VwProductosrelacionado> VwProductosrelacionadoes { get; set; } // vw_Productosrelacionados

        #endregion

        #region Constructor

        public Context()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public Context(string connectionString) : base(connectionString)
        {

        }

        #endregion

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AplicacioneConfiguration());
            modelBuilder.Configurations.Add(new AuditoriaBusquedaConfiguration());
            modelBuilder.Configurations.Add(new AuditoriaBusquedaGeneralConfiguration());
            modelBuilder.Configurations.Add(new AuditoriaBusquedasSinUsuarioConfiguration());
            modelBuilder.Configurations.Add(new AuditoriaFichasBaseConfiguration());
            modelBuilder.Configurations.Add(new BiografiaConfiguration());
            modelBuilder.Configurations.Add(new BiografiasBackupProduccion20160420Configuration());
            modelBuilder.Configurations.Add(new BookmasterBisacConfiguration());
            modelBuilder.Configurations.Add(new ClasificacionEciConfiguration());
            modelBuilder.Configurations.Add(new CodigoCduConfiguration());
            modelBuilder.Configurations.Add(new CoEditorialeConfiguration());
            modelBuilder.Configurations.Add(new ConsultaConfiguration());
            modelBuilder.Configurations.Add(new ConsultassqlConfiguration());
            modelBuilder.Configurations.Add(new DescargasFicheroConfiguration());
            modelBuilder.Configurations.Add(new DilveCicloEducativoAneleConfiguration());
            modelBuilder.Configurations.Add(new DilveClasificacionBicEquivalenciasSchemeIdentifierConfiguration());
            modelBuilder.Configurations.Add(new DilveComunidadAutonomaConfiguration());
            modelBuilder.Configurations.Add(new DilveCursoAneleConfiguration());
            modelBuilder.Configurations.Add(new DilveDetallePresentacionProductoConfiguration());
            modelBuilder.Configurations.Add(new DilveDisponibilidadConfiguration());
            modelBuilder.Configurations.Add(new DilveDrmConfiguration());
            modelBuilder.Configurations.Add(new DilveEditorialeConfiguration());
            modelBuilder.Configurations.Add(new DilveEstadoConfiguration());
            modelBuilder.Configurations.Add(new DilveFormatoProductoConfiguration());
            modelBuilder.Configurations.Add(new DilveFormatoProductoDetallePresentacionEquivalenciaConfiguration());
            modelBuilder.Configurations.Add(new DilveFormatoSoporteDigitalConfiguration());
            modelBuilder.Configurations.Add(new DilveIdiomaConfiguration());
            modelBuilder.Configurations.Add(new DilveMateriaConfiguration());
            modelBuilder.Configurations.Add(new DilveMaterialEducativoAneleConfiguration());
            modelBuilder.Configurations.Add(new DilveNivelEducativoAneleConfiguration());
            modelBuilder.Configurations.Add(new DilvePaisConfiguration());
            modelBuilder.Configurations.Add(new DilvePublicoObjetivoConfiguration());
            modelBuilder.Configurations.Add(new DilveRoleConfiguration());
            modelBuilder.Configurations.Add(new DilveSituacionCatalogoEditorialConfiguration());
            modelBuilder.Configurations.Add(new DilveTerritorioConfiguration());
            modelBuilder.Configurations.Add(new DocumentoConfiguration());
            modelBuilder.Configurations.Add(new DtpropertyConfiguration());
            modelBuilder.Configurations.Add(new E2AclDominioConfiguration());
            modelBuilder.Configurations.Add(new E2AclDominiosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new E2AclDominiosJerarquiaConfiguration());
            modelBuilder.Configurations.Add(new E2AclDominiosJerarquiasLineaNegocioConfiguration());
            modelBuilder.Configurations.Add(new E2AclGruposConfiguration());
            modelBuilder.Configurations.Add(new E2AclObjetoConfiguration());
            modelBuilder.Configurations.Add(new E2AclObjetosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new E2AclRelGruposobjetoConfiguration());
            modelBuilder.Configurations.Add(new E2AclTiposObjetoConfiguration());
            modelBuilder.Configurations.Add(new E2CamposConsultaConfiguration());
            modelBuilder.Configurations.Add(new E2CamposConsultaIdiomaConfiguration());
            modelBuilder.Configurations.Add(new E2CamposRelacioneConfiguration());
            modelBuilder.Configurations.Add(new E2CatalogFieldFilterConfiguration());
            modelBuilder.Configurations.Add(new E2CatalogFieldFiltersIdiomaConfiguration());
            modelBuilder.Configurations.Add(new E2ClasificacionesGestionConfiguration());
            modelBuilder.Configurations.Add(new E2ConsultaConfiguration());
            modelBuilder.Configurations.Add(new E2ConsultasAsistenteConfiguration());
            modelBuilder.Configurations.Add(new E2ConsultasAsistenteCamposConfiguration());
            modelBuilder.Configurations.Add(new E2ConsultasAsistenteFiltroConfiguration());
            modelBuilder.Configurations.Add(new E2ConsultasFiltroConfiguration());
            modelBuilder.Configurations.Add(new E2DatosMinimosCamposConfiguration());
            modelBuilder.Configurations.Add(new E2DatosMinimosJerarquiaCamposConfiguration());
            modelBuilder.Configurations.Add(new E2DatosMinimosJerarquiaValoreConfiguration());
            modelBuilder.Configurations.Add(new E2DatosMinimosValoreConfiguration());
            modelBuilder.Configurations.Add(new E2EquivalenciaCamposConfiguration());
            modelBuilder.Configurations.Add(new E2EquivalenciaClasificacioneConfiguration());
            modelBuilder.Configurations.Add(new E2EquivalenciaClasificacionesCondicioneConfiguration());
            modelBuilder.Configurations.Add(new E2FichasBaseComentarioConfiguration());
            modelBuilder.Configurations.Add(new E2FichasBasePalabrasClaveConfiguration());
            modelBuilder.Configurations.Add(new E2FichasBasePremioConfiguration());
            modelBuilder.Configurations.Add(new E2GeCatalogoConfiguration());
            modelBuilder.Configurations.Add(new E2GeCatalogosCompartidoConfiguration());
            modelBuilder.Configurations.Add(new E2GePlantillanodoConfiguration());
            modelBuilder.Configurations.Add(new E2GePlantillanodoIdiomaConfiguration());
            modelBuilder.Configurations.Add(new E2GeRamasarbolConfiguration());
            modelBuilder.Configurations.Add(new E2GeRamaslibroConfiguration());
            modelBuilder.Configurations.Add(new E2GeTiponodoConfiguration());
            modelBuilder.Configurations.Add(new E2GeTiponodoIdiomaConfiguration());
            modelBuilder.Configurations.Add(new E2GruposArticuloConfiguration());
            modelBuilder.Configurations.Add(new E2GruposArticulosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new E2LineasproductoConfiguration());
            modelBuilder.Configurations.Add(new E2LineasproductoIdiomaConfiguration());
            modelBuilder.Configurations.Add(new E2LogEcatConfiguration());
            modelBuilder.Configurations.Add(new E2MensajeConfiguration());
            modelBuilder.Configurations.Add(new E2ParametrosDominioConfiguration());
            modelBuilder.Configurations.Add(new E2RamasclasifFichaConfiguration());
            modelBuilder.Configurations.Add(new E2RamasClasificacionesGestionConfiguration());
            modelBuilder.Configurations.Add(new E2TiradasedicionConfiguration());
            modelBuilder.Configurations.Add(new E2VwLibrosListosParaWebConfiguration());
            modelBuilder.Configurations.Add(new E2VwMaximaEdicionConfiguration());
            modelBuilder.Configurations.Add(new E2VwNumeroEdicioneConfiguration());
            modelBuilder.Configurations.Add(new EdadeConfiguration());
            modelBuilder.Configurations.Add(new EdadesIdiomaConfiguration());
            modelBuilder.Configurations.Add(new EditorialeConfiguration());
            modelBuilder.Configurations.Add(new EfemerideConfiguration());
            modelBuilder.Configurations.Add(new EfemeridesGruposConfiguration());
            modelBuilder.Configurations.Add(new EstadosSapConfiguration());
            modelBuilder.Configurations.Add(new EstadosSapIdiomaConfiguration());
            modelBuilder.Configurations.Add(new EventoConfiguration());
            modelBuilder.Configurations.Add(new FechaConfiguration());
            modelBuilder.Configurations.Add(new FichasAplicacionConfiguration());
            modelBuilder.Configurations.Add(new FichasBaseConfiguration());
            modelBuilder.Configurations.Add(new FichasBaseArchivoHistoricoConfiguration());
            modelBuilder.Configurations.Add(new FichasBaseCamposLibreConfiguration());
            modelBuilder.Configurations.Add(new FichasBaseCicloCursoConfiguration());
            modelBuilder.Configurations.Add(new FichasBaseClasificacionEciConfiguration());
            modelBuilder.Configurations.Add(new FichasBaseCodigoCduConfiguration());
            modelBuilder.Configurations.Add(new FichasBaseIdiomasSecundarioConfiguration());
            modelBuilder.Configurations.Add(new FichasBaseNavidadMarianistaConfiguration());
            modelBuilder.Configurations.Add(new FichasBaseSoporteConfiguration());
            modelBuilder.Configurations.Add(new FichasBaseTesauroConfiguration());
            modelBuilder.Configurations.Add(new IdiomaConfiguration());
            modelBuilder.Configurations.Add(new IdiomasIdiomaConfiguration());
            modelBuilder.Configurations.Add(new LineaNegocioConfiguration());
            modelBuilder.Configurations.Add(new MedioConfiguration());
            modelBuilder.Configurations.Add(new PalabrasClaveConfiguration());
            modelBuilder.Configurations.Add(new PalabrasClaveGruposConfiguration());
            modelBuilder.Configurations.Add(new ParametroConfiguration());
            modelBuilder.Configurations.Add(new PeAreasGlobaleConfiguration());
            modelBuilder.Configurations.Add(new PeAreasGlobalesIdiomaConfiguration());
            modelBuilder.Configurations.Add(new PeAreasGlobalesMateriaConfiguration());
            modelBuilder.Configurations.Add(new PeComponenteConfiguration());
            modelBuilder.Configurations.Add(new PeComponentesDestinoConfiguration());
            modelBuilder.Configurations.Add(new PeComponentesDestinosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new PeComponentesDocumentoConfiguration());
            modelBuilder.Configurations.Add(new PeComponentesEstadoConfiguration());
            modelBuilder.Configurations.Add(new PeComponentesEstadosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new PeComponentesFormatoConfiguration());
            modelBuilder.Configurations.Add(new PeComponentesFormatosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new PeComponentesTiposConfiguration());
            modelBuilder.Configurations.Add(new PeComponentesTiposIdiomaConfiguration());
            modelBuilder.Configurations.Add(new PeComponentesTiposMaterialesGruposArticuloConfiguration());
            modelBuilder.Configurations.Add(new PeDocumentoConfiguration());
            modelBuilder.Configurations.Add(new PeDocumentosExtensionesPermitidaConfiguration());
            modelBuilder.Configurations.Add(new PeEstructuraEdadeConfiguration());
            modelBuilder.Configurations.Add(new PeEstructuraEdadesNivelesEducativoConfiguration());
            modelBuilder.Configurations.Add(new PePlanesEditorialeConfiguration());
            modelBuilder.Configurations.Add(new PePlanesEditorialesDocumentoConfiguration());
            modelBuilder.Configurations.Add(new PePmpConfiguration());
            modelBuilder.Configurations.Add(new PePmPsDocumentoConfiguration());
            modelBuilder.Configurations.Add(new PeProyectoConfiguration());
            modelBuilder.Configurations.Add(new PeProyectosAreasGlobalesMateriaConfiguration());
            modelBuilder.Configurations.Add(new PeProyectosDocumentoConfiguration());
            modelBuilder.Configurations.Add(new PeProyectosEstadoConfiguration());
            modelBuilder.Configurations.Add(new PeProyectosEstadosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new PeProyectosMarcoConfiguration());
            modelBuilder.Configurations.Add(new PeProyectosMarcoDocumentoConfiguration());
            modelBuilder.Configurations.Add(new PeProyectosMarcoPreferenciasExplotacionConfiguration());
            modelBuilder.Configurations.Add(new PeProyectosNivelesEducativoConfiguration());
            modelBuilder.Configurations.Add(new PeProyectosPreferenciasExplotacionConfiguration());
            modelBuilder.Configurations.Add(new PersonaConfiguration());
            modelBuilder.Configurations.Add(new PeTitulosPrincipaleConfiguration());
            modelBuilder.Configurations.Add(new PeTitulosPrincipalesComponenteConfiguration());
            modelBuilder.Configurations.Add(new PeTitulosPrincipalesDocumentoConfiguration());
            modelBuilder.Configurations.Add(new PeTitulosPrincipalesEstadoConfiguration());
            modelBuilder.Configurations.Add(new PeTitulosPrincipalesEstadosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new PremioConfiguration());
            modelBuilder.Configurations.Add(new PremiosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new PublicoObjetivoConfiguration());
            modelBuilder.Configurations.Add(new PublicoObjetivoIdiomaConfiguration());
            modelBuilder.Configurations.Add(new RelFichasPersonaConfiguration());
            modelBuilder.Configurations.Add(new RelFrasesDescriptivaConfiguration());
            modelBuilder.Configurations.Add(new ResenaConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new RolesIdiomaConfiguration());
            modelBuilder.Configurations.Add(new SinliAudienciaConfiguration());
            modelBuilder.Configurations.Add(new SinliCautonomaConfiguration());
            modelBuilder.Configurations.Add(new SinliE2EncuadernacioneConfiguration());
            modelBuilder.Configurations.Add(new SinliE2EstadoConfiguration());
            modelBuilder.Configurations.Add(new SinliE2LenguaConfiguration());
            modelBuilder.Configurations.Add(new SinliE2TiposproductoConfiguration());
            modelBuilder.Configurations.Add(new SinliEncuadernacioneConfiguration());
            modelBuilder.Configurations.Add(new SinliEstadoConfiguration());
            modelBuilder.Configurations.Add(new SinliLenguaConfiguration());
            modelBuilder.Configurations.Add(new SinliMateriaConfiguration());
            modelBuilder.Configurations.Add(new SinliNiveleslecturaConfiguration());
            modelBuilder.Configurations.Add(new SinliPaisConfiguration());
            modelBuilder.Configurations.Add(new SinliSubmateriaConfiguration());
            modelBuilder.Configurations.Add(new SinliTiposproductoConfiguration());
            modelBuilder.Configurations.Add(new TAccessTokenConfiguration());
            modelBuilder.Configurations.Add(new TActualizacionesCabeceraConfiguration());
            modelBuilder.Configurations.Add(new TActualizacionesCamposConfiguration());
            modelBuilder.Configurations.Add(new TActualizacionesCamposIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TActualizacionesDetalleConfiguration());
            modelBuilder.Configurations.Add(new TActualizacionesEstadoConfiguration());
            modelBuilder.Configurations.Add(new TActualizacionesEstadosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TActualizacionesEstadosMaterialeConfiguration());
            modelBuilder.Configurations.Add(new TActualizacionesEstadosMaterialesIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TActualizacionesTiposActualizacionConfiguration());
            modelBuilder.Configurations.Add(new TActualizacionesTiposActualizacionIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TActualizacionesTiposCampoConfiguration());
            modelBuilder.Configurations.Add(new TAmbitosCesionConfiguration());
            modelBuilder.Configurations.Add(new TAmbitosCesionEstadoConfiguration());
            modelBuilder.Configurations.Add(new TAmbitosCesionGruposConfiguration());
            modelBuilder.Configurations.Add(new TAuditoriaConfiguration());
            modelBuilder.Configurations.Add(new TAyudaCmConfiguration());
            modelBuilder.Configurations.Add(new TbCamposFichaConfiguration());
            modelBuilder.Configurations.Add(new TbCamposFichaElementoConfiguration());
            modelBuilder.Configurations.Add(new TbCamposFichaIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TbCamposNiveleConfiguration());
            modelBuilder.Configurations.Add(new TbCamposOrdenConfiguration());
            modelBuilder.Configurations.Add(new TbCamposOrdenIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TbDilveEquivalenciaConfiguration());
            modelBuilder.Configurations.Add(new TbFichasBaseImageneConfiguration());
            modelBuilder.Configurations.Add(new TbImagenesTiposConfiguration());
            modelBuilder.Configurations.Add(new TbImagenesTiposIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TBusquedaGeneralEstadoConfiguration());
            modelBuilder.Configurations.Add(new TBusquedaGeneralEstadosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TBusquedaGeneralTiposMaterialeConfiguration());
            modelBuilder.Configurations.Add(new TBusquedaGeneralTiposMaterialesIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TCampañasConfiguration());
            modelBuilder.Configurations.Add(new TCategoriasCicloConfiguration());
            modelBuilder.Configurations.Add(new TCategoriasCiclosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TCodigosErrorDilveConfiguration());
            modelBuilder.Configurations.Add(new TColeccioneConfiguration());
            modelBuilder.Configurations.Add(new TColeccionesIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TConfiguracionMantenimientosGenericosECatConfiguration());
            modelBuilder.Configurations.Add(new TDigitalAccesibilidadConfiguration());
            modelBuilder.Configurations.Add(new TDigitalAccesibilidadIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TDigitalPlataformaConfiguration());
            modelBuilder.Configurations.Add(new TDigitalPlataformasIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TDrmConfiguration());
            modelBuilder.Configurations.Add(new TDrmIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TE2GeCatalogosPreciosEspecialeConfiguration());
            modelBuilder.Configurations.Add(new TE2GeCatalogosPreciosEspecialesCamposConfiguration());
            modelBuilder.Configurations.Add(new TEdadCursoConfiguration());
            modelBuilder.Configurations.Add(new TEdadCursoIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TEdicionaPlusVisorParametrizacionConfiguration());
            modelBuilder.Configurations.Add(new TempUsuariosEncuentrosSmConfiguration());
            modelBuilder.Configurations.Add(new TEstadosSeguimientoConfiguration());
            modelBuilder.Configurations.Add(new TEtapasRangoEdadConfiguration());
            modelBuilder.Configurations.Add(new TEtapasRangoEdadIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TFasesMaterialConfiguration());
            modelBuilder.Configurations.Add(new TFasesMaterialIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TFichasBaseAmbitosCesionConfiguration());
            modelBuilder.Configurations.Add(new TFichasBaseAmbitosCesionValoreConfiguration());
            modelBuilder.Configurations.Add(new TFichasBaseAmbitosCesionRestriccionConfiguration());
            modelBuilder.Configurations.Add(new TFichasBaseDilveXmlConfiguration());
            modelBuilder.Configurations.Add(new TFichasBaseHistoricoEstadoSeguimientoConfiguration());
            modelBuilder.Configurations.Add(new TFichasBaseHistoricoFaseConfiguration());
            modelBuilder.Configurations.Add(new TFichasBaseMaterialesReferenciaConfiguration());
            modelBuilder.Configurations.Add(new TGeneroConfiguration());
            modelBuilder.Configurations.Add(new TGenerosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TIdiomasPlataformaConfiguration());
            modelBuilder.Configurations.Add(new TiposArticuloConfiguration());
            modelBuilder.Configurations.Add(new TiposArticulosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TiposDocumentoConfiguration());
            modelBuilder.Configurations.Add(new TiposDocumentosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TiposEncuadernacionConfiguration());
            modelBuilder.Configurations.Add(new TiposEncuadernacionIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TiposMedioConfiguration());
            modelBuilder.Configurations.Add(new TiposMediosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TitulosAfineConfiguration());
            modelBuilder.Configurations.Add(new TitulosAnejoConfiguration());
            modelBuilder.Configurations.Add(new TLineasNegocioCamposLibreConfiguration());
            modelBuilder.Configurations.Add(new TLineasNegocioCamposLibresValoreConfiguration());
            modelBuilder.Configurations.Add(new TLineasNegocioLineasProductoConfiguration());
            modelBuilder.Configurations.Add(new TMaterialesReferenciaTiposConfiguration());
            modelBuilder.Configurations.Add(new TMaterialesreferenciaTiposIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TMercadoConfiguration());
            modelBuilder.Configurations.Add(new TMercadoIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TNegocioConfiguration());
            modelBuilder.Configurations.Add(new TNegocioIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TNoticiasPrincipalConfiguration());
            modelBuilder.Configurations.Add(new TOperacionesConsultaConfiguration());
            modelBuilder.Configurations.Add(new TOperacionesConsultasIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TPersonasReferenciasWebConfiguration());
            modelBuilder.Configurations.Add(new TPlanEditorialNiveleConfiguration());
            modelBuilder.Configurations.Add(new TPlanEditorialSubNiveleConfiguration());
            modelBuilder.Configurations.Add(new TPortadasColaImageneConfiguration());
            modelBuilder.Configurations.Add(new TPortadasEstadosImageneConfiguration());
            modelBuilder.Configurations.Add(new TPropietarioConfiguration());
            modelBuilder.Configurations.Add(new TPropietarioIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TProyectoConfiguration());
            modelBuilder.Configurations.Add(new TProyectoSeccionConfiguration());
            modelBuilder.Configurations.Add(new TProyectosGestionConfiguration());
            modelBuilder.Configurations.Add(new TProyectosGestionIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TProyectosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TProyectosProyectoSeccionConfiguration());
            modelBuilder.Configurations.Add(new TReferenciasWebTiposConfiguration());
            modelBuilder.Configurations.Add(new TSeriesConfiguration());
            modelBuilder.Configurations.Add(new TSeriesIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TSoporteConfiguration());
            modelBuilder.Configurations.Add(new TSoportesIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TSubcategoriasMateriaConfiguration());
            modelBuilder.Configurations.Add(new TSubcategoriasMateriasIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TTiposCamposConsultaConfiguration());
            modelBuilder.Configurations.Add(new TTiposConsultaConfiguration());
            modelBuilder.Configurations.Add(new TTiposConsultasIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TTiposElementoConfiguration());
            modelBuilder.Configurations.Add(new TTiposElementosIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TTiposEnvioDilveConfiguration());
            modelBuilder.Configurations.Add(new TTiposMaterialeConfiguration());
            modelBuilder.Configurations.Add(new TTiposMaterialEducativoConfiguration());
            modelBuilder.Configurations.Add(new TTiposMaterialEducativoIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TTiposMaterialesGruposArticuloConfiguration());
            modelBuilder.Configurations.Add(new TTiposMaterialesGruposArticulosPaisConfiguration());
            modelBuilder.Configurations.Add(new TTiposMaterialesGruposArticulosPrefijoConfiguration());
            modelBuilder.Configurations.Add(new TTiposMaterialesIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TTiposPublicacionConfiguration());
            modelBuilder.Configurations.Add(new TTiposPublicacionIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TTiposTituloAfinConfiguration());
            modelBuilder.Configurations.Add(new TTiposTituloAfinIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TUsosComercialeConfiguration());
            modelBuilder.Configurations.Add(new TUsosComercialesIdiomaConfiguration());
            modelBuilder.Configurations.Add(new TUsuariosImpersonacionConfiguration());
            modelBuilder.Configurations.Add(new TZonasGeograficaConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new VwEdicionaPlusGetTesauroConfiguration());
            modelBuilder.Configurations.Add(new VwFichasBaseAmbitoCesionConfiguration());
            modelBuilder.Configurations.Add(new VwLirInformesJerarquiaECatConfiguration());
            modelBuilder.Configurations.Add(new VwPortadaConfiguration());
            modelBuilder.Configurations.Add(new VwProductosrelacionadoConfiguration());
        }
    }
}
