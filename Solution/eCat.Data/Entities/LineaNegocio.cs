namespace eCat.Data.Entities
{
    public class LineaNegocio
    {

        ///<summary>
        /// Clave de la línea de negocio
        ///</summary>
        public byte IdLineaNegocio { get; set; } // IdLineaNegocio (Primary key)
        public string CodigoLineaNegocio { get; set; } // CodigoLineaNegocio (length: 5)

        ///<summary>
        /// Nombre de la línea de negocio
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 255)
        public string Url { get; set; } // URL (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child E2AclDominio (Many-to-Many) mapped by table [T_Dominios_LineasNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2AclDominio> E2AclDominio { get; set; } // Many to many mapping
        /// <summary>
        /// Child FichasBases where [FichasBase].[IdLineaNegocio] point to this entity (FK_FichasBase_LineaNegocio)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_LineaNegocio
        /// <summary>
        /// Child PePlanesEditoriales (Many-to-Many) mapped by table [PE_PlanesEditoriales_LineaNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePlanesEditoriale> PePlanesEditoriales { get; set; } // Many to many mapping
        /// <summary>
        /// Child PeProyectoes (Many-to-Many) mapped by table [PE_Proyectos_LineaNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyecto> PeProyectoes { get; set; } // Many to many mapping
        /// <summary>
        /// Child TColecciones (Many-to-Many) mapped by table [T_Colecciones_LineasNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TColeccione> TColecciones { get; set; } // Many to many mapping
        /// <summary>
        /// Child TLineasNegocioCamposLibres where [T_LineasNegocio_CamposLibres].[IdLineaNegocio] point to this entity (FK_T_LineasNegocio_CamposLibres_LineaNegocio)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TLineasNegocioCamposLibre> TLineasNegocioCamposLibres { get; set; } // T_LineasNegocio_CamposLibres.FK_T_LineasNegocio_CamposLibres_LineaNegocio
        /// <summary>
        /// Child TLineasNegocioLineasProductoes where [T_LineasNegocio_LineasProducto].[IdLineaNegocio] point to this entity (FK_T_LineasNegocio_LineasProducto_LineaNegocio)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TLineasNegocioLineasProducto> TLineasNegocioLineasProductoes { get; set; } // T_LineasNegocio_LineasProducto.FK_T_LineasNegocio_LineasProducto_LineaNegocio
        /// <summary>
        /// Child TProyectoes (Many-to-Many) mapped by table [T_Proyectos_LineaNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TProyecto> TProyectoes { get; set; } // Many to many mapping
        /// <summary>
        /// Child TProyectosGestions (Many-to-Many) mapped by table [T_ProyectosGestion_LineaNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TProyectosGestion> TProyectosGestions { get; set; } // Many to many mapping
        /// <summary>
        /// Child TSeries (Many-to-Many) mapped by table [T_Series_LineasNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TSeries> TSeries { get; set; } // Many to many mapping
        /// <summary>
        /// Child Usuarios (Many-to-Many) mapped by table [T_Usuarios_LineaNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Usuario> Usuarios { get; set; } // Many to many mapping

        public LineaNegocio()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            TLineasNegocioCamposLibres = new System.Collections.Generic.List<TLineasNegocioCamposLibre>();
            TLineasNegocioLineasProductoes = new System.Collections.Generic.List<TLineasNegocioLineasProducto>();
            TProyectosGestions = new System.Collections.Generic.List<TProyectosGestion>();
            PePlanesEditoriales = new System.Collections.Generic.List<PePlanesEditoriale>();
            PeProyectoes = new System.Collections.Generic.List<PeProyecto>();
            TProyectoes = new System.Collections.Generic.List<TProyecto>();
            TColecciones = new System.Collections.Generic.List<TColeccione>();
            TSeries = new System.Collections.Generic.List<TSeries>();
            E2AclDominio = new System.Collections.Generic.List<E2AclDominio>();
            Usuarios = new System.Collections.Generic.List<Usuario>();
        }
    }
}