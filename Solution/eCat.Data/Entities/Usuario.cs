namespace eCat.Data.Entities
{
    public class Usuario
    {

        ///<summary>
        /// Clave del usuario
        ///</summary>
        public string IdUsuario { get; set; } // IDUsuario (Primary key) (length: 50)

        ///<summary>
        /// Nombre del usuario : dominio\usuario
        ///</summary>
        public string Usuario_ { get; set; } // Usuario (length: 50)

        ///<summary>
        /// Contraseña del usuario
        ///</summary>
        public string Pwd { get; set; } // Pwd (length: 10)

        ///<summary>
        /// Idioma en de interface para el usuario en las diferenctes aplicaciones de explotación
        ///</summary>
        public short? IdIdioma { get; set; } // IdIdioma
        public bool Baja { get; set; } // Baja

        ///<summary>
        /// Indica si el usuario esta impersonado ono, en realidad si es real o no.
        ///</summary>
        public bool Impersonado { get; set; } // Impersonado

        // Reverse navigation

        /// <summary>
        /// Child E2AclGrupos (Many-to-Many) mapped by table [E2_ACL_REL_USUARIOSGRUPOS]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2AclGrupos> E2AclGrupos { get; set; } // Many to many mapping
        /// <summary>
        /// Child E2GeCatalogo where [E2_GE_CATALOGOS].[UsuarioCreacion] point to this entity (FK_E2_GE_CATALOGOS_Usuarios)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2GeCatalogo> E2GeCatalogo { get; set; } // E2_GE_CATALOGOS.FK_E2_GE_CATALOGOS_Usuarios
        /// <summary>
        /// Child FichasBases where [FichasBase].[UsuarioPublicacion] point to this entity (FK_FichasBase_Usuarios)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases_UsuarioPublicacion { get; set; } // FichasBase.FK_FichasBase_Usuarios
        /// <summary>
        /// Child FichasBases where [FichasBase].[UsuarioRetirada] point to this entity (FK_FichasBase_Usuarios1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases_UsuarioRetirada { get; set; } // FichasBase.FK_FichasBase_Usuarios1
        /// <summary>
        /// Child LineaNegocios (Many-to-Many) mapped by table [T_Usuarios_LineaNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<LineaNegocio> LineaNegocios { get; set; } // Many to many mapping
        /// <summary>
        /// Child PeDocumentoes where [PE_Documentos].[UsuarioBaja] point to this entity (FK_PE_Documentos_Usuarios2)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeDocumento> PeDocumentoes_UsuarioBaja { get; set; } // PE_Documentos.FK_PE_Documentos_Usuarios2
        /// <summary>
        /// Child PeDocumentoes where [PE_Documentos].[UsuarioCreacion] point to this entity (FK_PE_Documentos_Usuarios)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeDocumento> PeDocumentoes_UsuarioCreacion { get; set; } // PE_Documentos.FK_PE_Documentos_Usuarios
        /// <summary>
        /// Child PeDocumentoes where [PE_Documentos].[UsuarioModificacion] point to this entity (FK_PE_Documentos_Usuarios1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeDocumento> PeDocumentoes_UsuarioModificacion { get; set; } // PE_Documentos.FK_PE_Documentos_Usuarios1
        /// <summary>
        /// Child PePlanesEditoriales where [PE_PlanesEditoriales].[UsuarioBaja] point to this entity (FK_PE_PlanesEditoriales_Usuarios2)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePlanesEditoriale> PePlanesEditoriales_UsuarioBaja { get; set; } // PE_PlanesEditoriales.FK_PE_PlanesEditoriales_Usuarios2
        /// <summary>
        /// Child PePlanesEditoriales where [PE_PlanesEditoriales].[UsuarioCreacion] point to this entity (FK_PE_PlanesEditoriales_Usuarios)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePlanesEditoriale> PePlanesEditoriales_UsuarioCreacion { get; set; } // PE_PlanesEditoriales.FK_PE_PlanesEditoriales_Usuarios
        /// <summary>
        /// Child PePlanesEditoriales where [PE_PlanesEditoriales].[UsuarioModificacion] point to this entity (FK_PE_PlanesEditoriales_Usuarios1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePlanesEditoriale> PePlanesEditoriales_UsuarioModificacion { get; set; } // PE_PlanesEditoriales.FK_PE_PlanesEditoriales_Usuarios1
        /// <summary>
        /// Child PePmps where [PE_PMPs].[UsuarioBaja] point to this entity (FK_PE_PMPs_Usuarios2)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePmp> PePmps_UsuarioBaja { get; set; } // PE_PMPs.FK_PE_PMPs_Usuarios2
        /// <summary>
        /// Child PePmps where [PE_PMPs].[UsuarioCreacion] point to this entity (FK_PE_PMPs_Usuarios)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePmp> PePmps_UsuarioCreacion { get; set; } // PE_PMPs.FK_PE_PMPs_Usuarios
        /// <summary>
        /// Child PePmps where [PE_PMPs].[UsuarioModificacion] point to this entity (FK_PE_PMPs_Usuarios1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePmp> PePmps_UsuarioModificacion { get; set; } // PE_PMPs.FK_PE_PMPs_Usuarios1
        /// <summary>
        /// Child PeProyectoes where [PE_Proyectos].[UsuarioBaja] point to this entity (FK_PE_Proyectos_Usuarios2)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyecto> PeProyectoes_UsuarioBaja { get; set; } // PE_Proyectos.FK_PE_Proyectos_Usuarios2
        /// <summary>
        /// Child PeProyectoes where [PE_Proyectos].[UsuarioCreacion] point to this entity (FK_PE_Proyectos_Usuarios)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyecto> PeProyectoes_UsuarioCreacion { get; set; } // PE_Proyectos.FK_PE_Proyectos_Usuarios
        /// <summary>
        /// Child PeProyectoes where [PE_Proyectos].[UsuarioModificacion] point to this entity (FK_PE_Proyectos_Usuarios1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyecto> PeProyectoes_UsuarioModificacion { get; set; } // PE_Proyectos.FK_PE_Proyectos_Usuarios1
        /// <summary>
        /// Child PeProyectosMarcoes where [PE_ProyectosMarco].[UsuarioBaja] point to this entity (FK_PE_ProyectosMarco_Usuarios2)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosMarco> PeProyectosMarcoes_UsuarioBaja { get; set; } // PE_ProyectosMarco.FK_PE_ProyectosMarco_Usuarios2
        /// <summary>
        /// Child PeProyectosMarcoes where [PE_ProyectosMarco].[UsuarioCreacion] point to this entity (FK_PE_ProyectosMarco_Usuarios)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosMarco> PeProyectosMarcoes_UsuarioCreacion { get; set; } // PE_ProyectosMarco.FK_PE_ProyectosMarco_Usuarios
        /// <summary>
        /// Child PeProyectosMarcoes where [PE_ProyectosMarco].[UsuarioModificacion] point to this entity (FK_PE_ProyectosMarco_Usuarios1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosMarco> PeProyectosMarcoes_UsuarioModificacion { get; set; } // PE_ProyectosMarco.FK_PE_ProyectosMarco_Usuarios1
        /// <summary>
        /// Child TActualizacionesCabeceras where [T_Actualizaciones_Cabecera].[IdUsuario] point to this entity (FK_T_Actualizaciones_Cabecera_Usuarios)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesCabecera> TActualizacionesCabeceras { get; set; } // T_Actualizaciones_Cabecera.FK_T_Actualizaciones_Cabecera_Usuarios
        /// <summary>
        /// Child TFichasBaseHistoricoEstadoSeguimientoes where [T_FichasBase_Historico_EstadoSeguimiento].[IdUsuario] point to this entity (FK_T_FichasBase_Historico_EstadoSeguimiento_Usuarios)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseHistoricoEstadoSeguimiento> TFichasBaseHistoricoEstadoSeguimientoes { get; set; } // T_FichasBase_Historico_EstadoSeguimiento.FK_T_FichasBase_Historico_EstadoSeguimiento_Usuarios
        /// <summary>
        /// Child TFichasBaseHistoricoFases where [T_FichasBase_Historico_Fase].[IdUsuario] point to this entity (FK_T_FichasBase_Historico_Fase_Usuarios)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseHistoricoFase> TFichasBaseHistoricoFases { get; set; } // T_FichasBase_Historico_Fase.FK_T_FichasBase_Historico_Fase_Usuarios

        public Usuario()
        {
            Baja = false;
            Impersonado = false;
            E2GeCatalogo = new System.Collections.Generic.List<E2GeCatalogo>();
            FichasBases_UsuarioPublicacion = new System.Collections.Generic.List<FichasBase>();
            FichasBases_UsuarioRetirada = new System.Collections.Generic.List<FichasBase>();
            PeDocumentoes_UsuarioBaja = new System.Collections.Generic.List<PeDocumento>();
            PeDocumentoes_UsuarioCreacion = new System.Collections.Generic.List<PeDocumento>();
            PeDocumentoes_UsuarioModificacion = new System.Collections.Generic.List<PeDocumento>();
            PePlanesEditoriales_UsuarioBaja = new System.Collections.Generic.List<PePlanesEditoriale>();
            PePlanesEditoriales_UsuarioCreacion = new System.Collections.Generic.List<PePlanesEditoriale>();
            PePlanesEditoriales_UsuarioModificacion = new System.Collections.Generic.List<PePlanesEditoriale>();
            PePmps_UsuarioBaja = new System.Collections.Generic.List<PePmp>();
            PePmps_UsuarioCreacion = new System.Collections.Generic.List<PePmp>();
            PePmps_UsuarioModificacion = new System.Collections.Generic.List<PePmp>();
            PeProyectoes_UsuarioBaja = new System.Collections.Generic.List<PeProyecto>();
            PeProyectoes_UsuarioCreacion = new System.Collections.Generic.List<PeProyecto>();
            PeProyectoes_UsuarioModificacion = new System.Collections.Generic.List<PeProyecto>();
            PeProyectosMarcoes_UsuarioBaja = new System.Collections.Generic.List<PeProyectosMarco>();
            PeProyectosMarcoes_UsuarioCreacion = new System.Collections.Generic.List<PeProyectosMarco>();
            PeProyectosMarcoes_UsuarioModificacion = new System.Collections.Generic.List<PeProyectosMarco>();
            TActualizacionesCabeceras = new System.Collections.Generic.List<TActualizacionesCabecera>();
            TFichasBaseHistoricoEstadoSeguimientoes = new System.Collections.Generic.List<TFichasBaseHistoricoEstadoSeguimiento>();
            TFichasBaseHistoricoFases = new System.Collections.Generic.List<TFichasBaseHistoricoFase>();
            E2AclGrupos = new System.Collections.Generic.List<E2AclGrupos>();
            LineaNegocios = new System.Collections.Generic.List<LineaNegocio>();
        }
    }
}