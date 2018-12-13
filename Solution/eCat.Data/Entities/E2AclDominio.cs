namespace eCat.Data.Entities
{
    public class E2AclDominio
    {

        ///<summary>
        /// Clave del dominio
        ///</summary>
        public short IdDominio { get; set; } // IdDominio (Primary key)

        ///<summary>
        /// Nombre del dominio Windows
        ///</summary>
        public string Dominio { get; set; } // DOMINIO (length: 50)
        public string Nombre { get; set; } // Nombre (length: 15)
        public bool Visible { get; set; } // Visible
        public bool IncluidoSap { get; set; } // IncluidoSAP
        public string Prefijo { get; set; } // Prefijo (length: 2)
        public string Icono { get; set; } // Icono (length: 50)
        public string Dominio2000 { get; set; } // Dominio2000 (length: 50)
        public bool IncluidoPs { get; set; } // IncluidoPS

        ///<summary>
        /// id de la rama padre de tesauro
        ///</summary>
        public int? IdArbol { get; set; } // IdArbol

        // Reverse navigation

        /// <summary>
        /// Child E2AclDominiosIdioma where [E2_ACL_DOMINIOS_Idioma].[IdDominio] point to this entity (FK_E2_ACL_DOMINIOS_Idioma_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2AclDominiosIdioma> E2AclDominiosIdioma { get; set; } // E2_ACL_DOMINIOS_Idioma.FK_E2_ACL_DOMINIOS_Idioma_E2_ACL_DOMINIOS
        /// <summary>
        /// Child FichasBases where [FichasBase].[IdPais] point to this entity (FK_FichasBase_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_E2_ACL_DOMINIOS
        /// <summary>
        /// Child LineaNegocios (Many-to-Many) mapped by table [T_Dominios_LineasNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<LineaNegocio> LineaNegocios { get; set; } // Many to many mapping
        /// <summary>
        /// Child PeEstructuraEdades where [PE_EstructuraEdades].[IdPais] point to this entity (FK_PE_Edades_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeEstructuraEdade> PeEstructuraEdades { get; set; } // PE_EstructuraEdades.FK_PE_Edades_E2_ACL_DOMINIOS
        /// <summary>
        /// Child PePlanesEditoriales where [PE_PlanesEditoriales].[IdPais] point to this entity (FK_PE_PlanesEditoriales_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePlanesEditoriale> PePlanesEditoriales { get; set; } // PE_PlanesEditoriales.FK_PE_PlanesEditoriales_E2_ACL_DOMINIOS
        /// <summary>
        /// Child PePmps where [PE_PMPs].[IdPais] point to this entity (FK_PE_PMPs_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePmp> PePmps { get; set; } // PE_PMPs.FK_PE_PMPs_E2_ACL_DOMINIOS
        /// <summary>
        /// Child PeProyectosMarcoes where [PE_ProyectosMarco].[IdPais] point to this entity (FK_PE_ProyectosMarco_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosMarco> PeProyectosMarcoes { get; set; } // PE_ProyectosMarco.FK_PE_ProyectosMarco_E2_ACL_DOMINIOS
        /// <summary>
        /// Child TCampañas (Many-to-Many) mapped by table [T_Campañas_Dominios]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TCampañas> TCampañas { get; set; } // Many to many mapping
        /// <summary>
        /// Child TLineasNegocioCamposLibres where [T_LineasNegocio_CamposLibres].[IdPais] point to this entity (FK_T_LineasNegocio_CamposLibres_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TLineasNegocioCamposLibre> TLineasNegocioCamposLibres { get; set; } // T_LineasNegocio_CamposLibres.FK_T_LineasNegocio_CamposLibres_E2_ACL_DOMINIOS
        /// <summary>
        /// Child TLineasNegocioLineasProductoes where [T_LineasNegocio_LineasProducto].[IdPais] point to this entity (FK_T_LineasNegocio_LineasProducto_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TLineasNegocioLineasProducto> TLineasNegocioLineasProductoes { get; set; } // T_LineasNegocio_LineasProducto.FK_T_LineasNegocio_LineasProducto_E2_ACL_DOMINIOS
        /// <summary>
        /// Child TTiposMaterialesGruposArticulosPais where [T_TiposMateriales_GruposArticulos_Paises].[IdPais] point to this entity (FK_T_TiposMateriales_GruposArticulos_Paises_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposMaterialesGruposArticulosPais> TTiposMaterialesGruposArticulosPais { get; set; } // T_TiposMateriales_GruposArticulos_Paises.FK_T_TiposMateriales_GruposArticulos_Paises_E2_ACL_DOMINIOS

        public E2AclDominio()
        {
            Visible = false;
            IncluidoSap = false;
            IncluidoPs = false;
            E2AclDominiosIdioma = new System.Collections.Generic.List<E2AclDominiosIdioma>();
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            PeEstructuraEdades = new System.Collections.Generic.List<PeEstructuraEdade>();
            PePlanesEditoriales = new System.Collections.Generic.List<PePlanesEditoriale>();
            PePmps = new System.Collections.Generic.List<PePmp>();
            PeProyectosMarcoes = new System.Collections.Generic.List<PeProyectosMarco>();
            TLineasNegocioCamposLibres = new System.Collections.Generic.List<TLineasNegocioCamposLibre>();
            TLineasNegocioLineasProductoes = new System.Collections.Generic.List<TLineasNegocioLineasProducto>();
            TTiposMaterialesGruposArticulosPais = new System.Collections.Generic.List<TTiposMaterialesGruposArticulosPais>();
            TCampañas = new System.Collections.Generic.List<TCampañas>();
            LineaNegocios = new System.Collections.Generic.List<LineaNegocio>();
        }
    }
}