namespace eCat.Data.Entities
{
    public class TIdiomasPlataforma
    {

        ///<summary>
        /// Clave del idioma
        ///</summary>
        public short IdIdiomaPlataforma { get; set; } // IdIdiomaPlataforma (Primary key)

        ///<summary>
        /// Código de idioma ISO
        ///</summary>
        public string CodigoIdioma { get; set; } // CodigoIdioma (length: 50)

        ///<summary>
        /// Nombre del idioma
        ///</summary>
        public string DescripcionIdioma { get; set; } // DescripcionIdioma (length: 255)

        ///<summary>
        /// Indica si el idioma tiene repercusión sobre la plataforma. Los idiomas así marcados pueden asociarse a los usuarios.
        ///</summary>
        public bool EsInterface { get; set; } // EsInterface

        ///<summary>
        /// Si es baja, el idioma no se debe utilizar en las traducciones
        ///</summary>
        public bool Baja { get; set; } // Baja

        // Reverse navigation

        /// <summary>
        /// Child E2AclDominiosIdioma where [E2_ACL_DOMINIOS_Idioma].[IdIdiomaInterface] point to this entity (FK_E2_ACL_DOMINIOS_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2AclDominiosIdioma> E2AclDominiosIdioma { get; set; } // E2_ACL_DOMINIOS_Idioma.FK_E2_ACL_DOMINIOS_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child E2AclObjetosIdioma where [E2_ACL_OBJETOS_Idioma].[IdIdiomaPlataforma] point to this entity (FK_E2_ACL_OBJETOS_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2AclObjetosIdioma> E2AclObjetosIdioma { get; set; } // E2_ACL_OBJETOS_Idioma.FK_E2_ACL_OBJETOS_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child E2CamposConsultaIdioma where [E2_CAMPOS_CONSULTA_Idioma].[IdIdiomaInterface] point to this entity (FK_E2_CAMPOS_CONSULTA_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2CamposConsultaIdioma> E2CamposConsultaIdioma { get; set; } // E2_CAMPOS_CONSULTA_Idioma.FK_E2_CAMPOS_CONSULTA_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child E2GruposArticulosIdioma where [E2_GRUPOS_ARTICULOS_Idioma].[IdIdiomaInterface] point to this entity (FK_E2_GRUPOS_ARTICULOS_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2GruposArticulosIdioma> E2GruposArticulosIdioma { get; set; } // E2_GRUPOS_ARTICULOS_Idioma.FK_E2_GRUPOS_ARTICULOS_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child E2LineasproductoIdioma where [E2_LINEASPRODUCTO_Idioma].[IdIdiomaInterface] point to this entity (FK_E2_LINEASPRODUCTO_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2LineasproductoIdioma> E2LineasproductoIdioma { get; set; } // E2_LINEASPRODUCTO_Idioma.FK_E2_LINEASPRODUCTO_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child EdadesIdiomas where [Edades_Idioma].[IdIdiomaInterface] point to this entity (FK_Edades_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<EdadesIdioma> EdadesIdiomas { get; set; } // Edades_Idioma.FK_Edades_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child EstadosSapIdiomas where [EstadosSAP_Idioma].[IdidiomaInterface] point to this entity (FK_EstadosSAP_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<EstadosSapIdioma> EstadosSapIdiomas { get; set; } // EstadosSAP_Idioma.FK_EstadosSAP_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child IdiomasIdiomas where [Idiomas_Idioma].[IdIdiomaInterface] point to this entity (FK_Idiomas_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<IdiomasIdioma> IdiomasIdiomas { get; set; } // Idiomas_Idioma.FK_Idiomas_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child PeAreasGlobalesIdiomas where [PE_AreasGlobales_Idioma].[IdIdiomaInterface] point to this entity (FK_PE_AreasGlobales_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeAreasGlobalesIdioma> PeAreasGlobalesIdiomas { get; set; } // PE_AreasGlobales_Idioma.FK_PE_AreasGlobales_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child PeComponentesDestinosIdiomas where [PE_Componentes_Destinos_Idioma].[IdIdiomaInterface] point to this entity (FK_PE_Componentes_Destinos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesDestinosIdioma> PeComponentesDestinosIdiomas { get; set; } // PE_Componentes_Destinos_Idioma.FK_PE_Componentes_Destinos_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child PeComponentesEstadosIdiomas where [PE_Componentes_Estados_Idioma].[IdIdiomaInterface] point to this entity (FK_PE_Componentes_Estados_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesEstadosIdioma> PeComponentesEstadosIdiomas { get; set; } // PE_Componentes_Estados_Idioma.FK_PE_Componentes_Estados_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child PeComponentesFormatosIdiomas where [PE_Componentes_Formatos_Idioma].[IdIdiomaInterface] point to this entity (FK_PE_Componentes_Formatos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesFormatosIdioma> PeComponentesFormatosIdiomas { get; set; } // PE_Componentes_Formatos_Idioma.FK_PE_Componentes_Formatos_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child PeComponentesTiposIdiomas where [PE_Componentes_Tipos_Idioma].[IdIdiomaInterface] point to this entity (FK_PE_Componentes_Tipos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesTiposIdioma> PeComponentesTiposIdiomas { get; set; } // PE_Componentes_Tipos_Idioma.FK_PE_Componentes_Tipos_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child PeProyectosEstadosIdiomas where [PE_Proyectos_Estados_Idioma].[IdIdiomaInterface] point to this entity (FK_PE_Proyectos_Estados_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosEstadosIdioma> PeProyectosEstadosIdiomas { get; set; } // PE_Proyectos_Estados_Idioma.FK_PE_Proyectos_Estados_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child PeTitulosPrincipalesEstadosIdiomas where [PE_TitulosPrincipales_Estados_Idioma].[IdIdiomaInterface] point to this entity (FK_PE_TitulosPrincipales_Estados_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeTitulosPrincipalesEstadosIdioma> PeTitulosPrincipalesEstadosIdiomas { get; set; } // PE_TitulosPrincipales_Estados_Idioma.FK_PE_TitulosPrincipales_Estados_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child PremiosIdiomas where [Premios_Idioma].[IdIdiomaInterface] point to this entity (FK_Premios_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PremiosIdioma> PremiosIdiomas { get; set; } // Premios_Idioma.FK_Premios_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child PublicoObjetivoIdiomas where [PublicoObjetivo_Idioma].[IdIdiomaInterface] point to this entity (FK_PublicoObjetivo_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PublicoObjetivoIdioma> PublicoObjetivoIdiomas { get; set; } // PublicoObjetivo_Idioma.FK_PublicoObjetivo_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child RolesIdiomas where [Roles_Idioma].[IdIdiomaInterface] point to this entity (FK_Roles_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<RolesIdioma> RolesIdiomas { get; set; } // Roles_Idioma.FK_Roles_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TActualizacionesCamposIdiomas where [T_Actualizaciones_Campos_Idiomas].[IdIdiomaInterface] point to this entity (FK_T_Actualizaciones_Campos_Idiomas_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesCamposIdioma> TActualizacionesCamposIdiomas { get; set; } // T_Actualizaciones_Campos_Idiomas.FK_T_Actualizaciones_Campos_Idiomas_T_Idiomas_Plataforma
        /// <summary>
        /// Child TActualizacionesEstadosIdiomas where [T_Actualizaciones_Estados_Idioma].[IdIdiomaInterface] point to this entity (FK_T_Actualizaciones_Estados_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesEstadosIdioma> TActualizacionesEstadosIdiomas { get; set; } // T_Actualizaciones_Estados_Idioma.FK_T_Actualizaciones_Estados_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TActualizacionesEstadosMaterialesIdiomas where [T_Actualizaciones_Estados_Materiales_Idioma].[IdIdiomaInterface] point to this entity (FK_T_Actualizaciones_Estados_Materiales_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesEstadosMaterialesIdioma> TActualizacionesEstadosMaterialesIdiomas { get; set; } // T_Actualizaciones_Estados_Materiales_Idioma.FK_T_Actualizaciones_Estados_Materiales_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TActualizacionesTiposActualizacionIdiomas where [T_Actualizaciones_TiposActualizacion_Idioma].[IdIdiomaInterface] point to this entity (FK_T_Actualizaciones_TiposActualizacion_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesTiposActualizacionIdioma> TActualizacionesTiposActualizacionIdiomas { get; set; } // T_Actualizaciones_TiposActualizacion_Idioma.FK_T_Actualizaciones_TiposActualizacion_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TbImagenesTiposIdiomas where [TB_Imagenes_Tipos_Idioma].[IdIdiomaInterface] point to this entity (FK_TB_Imagenes_Tipos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbImagenesTiposIdioma> TbImagenesTiposIdiomas { get; set; } // TB_Imagenes_Tipos_Idioma.FK_TB_Imagenes_Tipos_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TCategoriasCiclosIdiomas where [T_CategoriasCiclos_Idioma].[IdIdiomaInterface] point to this entity (FK_T_CategoriasCiclos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TCategoriasCiclosIdioma> TCategoriasCiclosIdiomas { get; set; } // T_CategoriasCiclos_Idioma.FK_T_CategoriasCiclos_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TDigitalAccesibilidadIdiomas where [T_Digital_Accesibilidad_Idioma].[IdIdiomaInterface] point to this entity (FK_T_Digital_Accesibilidad_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TDigitalAccesibilidadIdioma> TDigitalAccesibilidadIdiomas { get; set; } // T_Digital_Accesibilidad_Idioma.FK_T_Digital_Accesibilidad_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TDigitalPlataformasIdiomas where [T_Digital_Plataformas_Idioma].[IdIdiomaInterface] point to this entity (FK_T_Digital_Plataformas_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TDigitalPlataformasIdioma> TDigitalPlataformasIdiomas { get; set; } // T_Digital_Plataformas_Idioma.FK_T_Digital_Plataformas_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TEdadCursoIdiomas where [T_EdadCurso_Idioma].[IdIdiomaInterface] point to this entity (FK_T_EdadCurso_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TEdadCursoIdioma> TEdadCursoIdiomas { get; set; } // T_EdadCurso_Idioma.FK_T_EdadCurso_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TEtapasRangoEdadIdiomas where [T_EtapasRangoEdad_Idioma].[IdIdiomaInterface] point to this entity (FK_T_EtapasRangoEdad_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TEtapasRangoEdadIdioma> TEtapasRangoEdadIdiomas { get; set; } // T_EtapasRangoEdad_Idioma.FK_T_EtapasRangoEdad_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TFasesMaterialIdiomas where [T_FasesMaterial_Idioma].[IdidiomaInterface] point to this entity (FK_T_FasesMaterial_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFasesMaterialIdioma> TFasesMaterialIdiomas { get; set; } // T_FasesMaterial_Idioma.FK_T_FasesMaterial_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TGenerosIdiomas where [T_Generos_Idioma].[IdIdiomaInterface] point to this entity (FK_T_Generos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TGenerosIdioma> TGenerosIdiomas { get; set; } // T_Generos_Idioma.FK_T_Generos_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TiposArticulosIdiomas where [TiposArticulos_Idioma].[IdIdiomaInterface] point to this entity (FK_TiposArticulos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TiposArticulosIdioma> TiposArticulosIdiomas { get; set; } // TiposArticulos_Idioma.FK_TiposArticulos_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TiposDocumentosIdiomas where [TiposDocumentos_Idioma].[IdIdiomaInterface] point to this entity (FK_TiposDocumentos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TiposDocumentosIdioma> TiposDocumentosIdiomas { get; set; } // TiposDocumentos_Idioma.FK_TiposDocumentos_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TiposEncuadernacionIdiomas where [TiposEncuadernacion_Idioma].[IdIdiomaInterface] point to this entity (FK_TiposEncuadernacion_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TiposEncuadernacionIdioma> TiposEncuadernacionIdiomas { get; set; } // TiposEncuadernacion_Idioma.FK_TiposEncuadernacion_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TiposMediosIdiomas where [TiposMedios_Idioma].[IdIdiomaInterface] point to this entity (FK_TiposMedios_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TiposMediosIdioma> TiposMediosIdiomas { get; set; } // TiposMedios_Idioma.FK_TiposMedios_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TMaterialesreferenciaTiposIdiomas where [T_Materialesreferencia_Tipos_Idioma].[IdIdiomaInterface] point to this entity (FK_T_Materialesreferencia_Tipos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TMaterialesreferenciaTiposIdioma> TMaterialesreferenciaTiposIdiomas { get; set; } // T_Materialesreferencia_Tipos_Idioma.FK_T_Materialesreferencia_Tipos_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TMercadoIdiomas where [T_Mercado_Idioma].[IdIdiomaInterface] point to this entity (FK_T_Mercado_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TMercadoIdioma> TMercadoIdiomas { get; set; } // T_Mercado_Idioma.FK_T_Mercado_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TNegocioIdiomas where [T_Negocio_Idioma].[IdIdiomaInterface] point to this entity (FK_T_Negocio_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TNegocioIdioma> TNegocioIdiomas { get; set; } // T_Negocio_Idioma.FK_T_Negocio_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TOperacionesConsultasIdiomas where [T_OperacionesConsultas_Idioma].[IdIdiomaInterface] point to this entity (FK_T_OperacionesConsultas_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TOperacionesConsultasIdioma> TOperacionesConsultasIdiomas { get; set; } // T_OperacionesConsultas_Idioma.FK_T_OperacionesConsultas_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TPropietarioIdiomas where [T_Propietario_Idioma].[IdIdiomaInterface] point to this entity (FK_T_Propietario_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TPropietarioIdioma> TPropietarioIdiomas { get; set; } // T_Propietario_Idioma.FK_T_Propietario_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TProyectosGestionIdiomas where [T_ProyectosGestion_Idioma].[IdIdiomainterface] point to this entity (FK_T_ProyectosGestion_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TProyectosGestionIdioma> TProyectosGestionIdiomas { get; set; } // T_ProyectosGestion_Idioma.FK_T_ProyectosGestion_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TProyectosIdiomas where [T_Proyectos_Idioma].[IdIdiomaInterface] point to this entity (FK_T_Proyectos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TProyectosIdioma> TProyectosIdiomas { get; set; } // T_Proyectos_Idioma.FK_T_Proyectos_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TSeriesIdiomas where [T_Series_Idioma].[IdIdiomaInterface] point to this entity (FK_T_Series_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TSeriesIdioma> TSeriesIdiomas { get; set; } // T_Series_Idioma.FK_T_Series_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TSoportesIdiomas where [T_Soportes_Idioma].[IdIdiomaInterface] point to this entity (FK_T_Soportes_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TSoportesIdioma> TSoportesIdiomas { get; set; } // T_Soportes_Idioma.FK_T_Soportes_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TSubcategoriasMateriasIdiomas where [T_SubcategoriasMaterias_Idioma].[IdIdiomaInterface] point to this entity (FK_T_SubcategoriasMaterias_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TSubcategoriasMateriasIdioma> TSubcategoriasMateriasIdiomas { get; set; } // T_SubcategoriasMaterias_Idioma.FK_T_SubcategoriasMaterias_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TTiposConsultasIdiomas where [T_TiposConsultas_Idioma].[IdIdiomaInterface] point to this entity (FK_T_TiposConsultas_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposConsultasIdioma> TTiposConsultasIdiomas { get; set; } // T_TiposConsultas_Idioma.FK_T_TiposConsultas_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TTiposMaterialEducativoIdiomas where [T_TiposMaterialEducativo_Idioma].[IdIdiomaInterface] point to this entity (FK_T_TiposMaterialEducativo_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposMaterialEducativoIdioma> TTiposMaterialEducativoIdiomas { get; set; } // T_TiposMaterialEducativo_Idioma.FK_T_TiposMaterialEducativo_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TTiposMaterialesIdiomas where [T_TiposMateriales_Idioma].[IdIdiomaInterface] point to this entity (FK_T_TiposMateriales_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposMaterialesIdioma> TTiposMaterialesIdiomas { get; set; } // T_TiposMateriales_Idioma.FK_T_TiposMateriales_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TTiposPublicacionIdiomas where [T_TiposPublicacion_Idioma].[IdIdiomaInterface] point to this entity (FK_T_TiposPublicacion_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposPublicacionIdioma> TTiposPublicacionIdiomas { get; set; } // T_TiposPublicacion_Idioma.FK_T_TiposPublicacion_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TTiposTituloAfinIdiomas where [T_TiposTituloAfin_Idioma].[IdIdiomaInterface] point to this entity (FK_T_TiposTituloAfin_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposTituloAfinIdioma> TTiposTituloAfinIdiomas { get; set; } // T_TiposTituloAfin_Idioma.FK_T_TiposTituloAfin_Idioma_T_Idiomas_Plataforma
        /// <summary>
        /// Child TUsosComercialesIdiomas where [T_UsosComerciales_Idioma].[IdIdiomaInterface] point to this entity (FK_T_UsosComerciales_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TUsosComercialesIdioma> TUsosComercialesIdiomas { get; set; } // T_UsosComerciales_Idioma.FK_T_UsosComerciales_Idioma_T_Idiomas_Plataforma

        public TIdiomasPlataforma()
        {
            EsInterface = false;
            Baja = false;
            E2AclDominiosIdioma = new System.Collections.Generic.List<E2AclDominiosIdioma>();
            E2AclObjetosIdioma = new System.Collections.Generic.List<E2AclObjetosIdioma>();
            E2CamposConsultaIdioma = new System.Collections.Generic.List<E2CamposConsultaIdioma>();
            E2GruposArticulosIdioma = new System.Collections.Generic.List<E2GruposArticulosIdioma>();
            E2LineasproductoIdioma = new System.Collections.Generic.List<E2LineasproductoIdioma>();
            EdadesIdiomas = new System.Collections.Generic.List<EdadesIdioma>();
            EstadosSapIdiomas = new System.Collections.Generic.List<EstadosSapIdioma>();
            IdiomasIdiomas = new System.Collections.Generic.List<IdiomasIdioma>();
            PeAreasGlobalesIdiomas = new System.Collections.Generic.List<PeAreasGlobalesIdioma>();
            PeComponentesDestinosIdiomas = new System.Collections.Generic.List<PeComponentesDestinosIdioma>();
            PeComponentesEstadosIdiomas = new System.Collections.Generic.List<PeComponentesEstadosIdioma>();
            PeComponentesFormatosIdiomas = new System.Collections.Generic.List<PeComponentesFormatosIdioma>();
            PeComponentesTiposIdiomas = new System.Collections.Generic.List<PeComponentesTiposIdioma>();
            PeProyectosEstadosIdiomas = new System.Collections.Generic.List<PeProyectosEstadosIdioma>();
            PeTitulosPrincipalesEstadosIdiomas = new System.Collections.Generic.List<PeTitulosPrincipalesEstadosIdioma>();
            PremiosIdiomas = new System.Collections.Generic.List<PremiosIdioma>();
            PublicoObjetivoIdiomas = new System.Collections.Generic.List<PublicoObjetivoIdioma>();
            RolesIdiomas = new System.Collections.Generic.List<RolesIdioma>();
            TActualizacionesCamposIdiomas = new System.Collections.Generic.List<TActualizacionesCamposIdioma>();
            TActualizacionesEstadosIdiomas = new System.Collections.Generic.List<TActualizacionesEstadosIdioma>();
            TActualizacionesEstadosMaterialesIdiomas = new System.Collections.Generic.List<TActualizacionesEstadosMaterialesIdioma>();
            TActualizacionesTiposActualizacionIdiomas = new System.Collections.Generic.List<TActualizacionesTiposActualizacionIdioma>();
            TCategoriasCiclosIdiomas = new System.Collections.Generic.List<TCategoriasCiclosIdioma>();
            TDigitalAccesibilidadIdiomas = new System.Collections.Generic.List<TDigitalAccesibilidadIdioma>();
            TDigitalPlataformasIdiomas = new System.Collections.Generic.List<TDigitalPlataformasIdioma>();
            TEdadCursoIdiomas = new System.Collections.Generic.List<TEdadCursoIdioma>();
            TEtapasRangoEdadIdiomas = new System.Collections.Generic.List<TEtapasRangoEdadIdioma>();
            TFasesMaterialIdiomas = new System.Collections.Generic.List<TFasesMaterialIdioma>();
            TGenerosIdiomas = new System.Collections.Generic.List<TGenerosIdioma>();
            TMaterialesreferenciaTiposIdiomas = new System.Collections.Generic.List<TMaterialesreferenciaTiposIdioma>();
            TMercadoIdiomas = new System.Collections.Generic.List<TMercadoIdioma>();
            TNegocioIdiomas = new System.Collections.Generic.List<TNegocioIdioma>();
            TOperacionesConsultasIdiomas = new System.Collections.Generic.List<TOperacionesConsultasIdioma>();
            TPropietarioIdiomas = new System.Collections.Generic.List<TPropietarioIdioma>();
            TProyectosIdiomas = new System.Collections.Generic.List<TProyectosIdioma>();
            TProyectosGestionIdiomas = new System.Collections.Generic.List<TProyectosGestionIdioma>();
            TSeriesIdiomas = new System.Collections.Generic.List<TSeriesIdioma>();
            TSoportesIdiomas = new System.Collections.Generic.List<TSoportesIdioma>();
            TSubcategoriasMateriasIdiomas = new System.Collections.Generic.List<TSubcategoriasMateriasIdioma>();
            TTiposConsultasIdiomas = new System.Collections.Generic.List<TTiposConsultasIdioma>();
            TTiposMaterialEducativoIdiomas = new System.Collections.Generic.List<TTiposMaterialEducativoIdioma>();
            TTiposMaterialesIdiomas = new System.Collections.Generic.List<TTiposMaterialesIdioma>();
            TTiposPublicacionIdiomas = new System.Collections.Generic.List<TTiposPublicacionIdioma>();
            TTiposTituloAfinIdiomas = new System.Collections.Generic.List<TTiposTituloAfinIdioma>();
            TUsosComercialesIdiomas = new System.Collections.Generic.List<TUsosComercialesIdioma>();
            TbImagenesTiposIdiomas = new System.Collections.Generic.List<TbImagenesTiposIdioma>();
            TiposArticulosIdiomas = new System.Collections.Generic.List<TiposArticulosIdioma>();
            TiposDocumentosIdiomas = new System.Collections.Generic.List<TiposDocumentosIdioma>();
            TiposEncuadernacionIdiomas = new System.Collections.Generic.List<TiposEncuadernacionIdioma>();
            TiposMediosIdiomas = new System.Collections.Generic.List<TiposMediosIdioma>();
        }
    }
}