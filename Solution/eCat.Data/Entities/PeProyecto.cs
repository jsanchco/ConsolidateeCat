namespace eCat.Data.Entities
{
    public class PeProyecto
    {
        public long IdProyecto { get; set; } // IdProyecto (Primary key)
        public string Codigo { get; set; } // Codigo (length: 50)
        public string Titulo { get; set; } // Titulo (length: 255)
        public string Descripcion { get; set; } // Descripcion (length: 255)
        public int IdPlanEditorial { get; set; } // IdPlanEditorial
        public int? IdProyectoMarco { get; set; } // IdProyectoMarco
        public int? IdEstructuraNnee { get; set; } // IdEstructuraNNEE
        public byte? IdEstado { get; set; } // IdEstado
        public bool Baja { get; set; } // Baja
        public string UsuarioCreacion { get; set; } // UsuarioCreacion (length: 50)
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion
        public string UsuarioModificacion { get; set; } // UsuarioModificacion (length: 50)
        public System.DateTime? FechaModificacion { get; set; } // FechaModificacion
        public string UsuarioBaja { get; set; } // UsuarioBaja (length: 50)
        public System.DateTime? FechaBaja { get; set; } // FechaBaja

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) PeProyecto pointed by [PE_Proyectos_PreferenciasExplotacion].[IdProyecto] (FK_PE_Proyectos_PreferenciasExplotacion_PE_Proyectos)
        /// </summary>
        public virtual PeProyectosPreferenciasExplotacion PeProyectosPreferenciasExplotacion { get; set; } // PE_Proyectos_PreferenciasExplotacion.FK_PE_Proyectos_PreferenciasExplotacion_PE_Proyectos
        /// <summary>
        /// Child LineaNegocios (Many-to-Many) mapped by table [PE_Proyectos_LineaNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<LineaNegocio> LineaNegocios { get; set; } // Many to many mapping
        /// <summary>
        /// Child PeProyectosAreasGlobalesMaterias where [PE_Proyectos_AreasGlobales_Materias].[IdProyecto] point to this entity (FK_PE_Proyectos_AreasGlobales_Materias_PE_Proyectos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosAreasGlobalesMateria> PeProyectosAreasGlobalesMaterias { get; set; } // PE_Proyectos_AreasGlobales_Materias.FK_PE_Proyectos_AreasGlobales_Materias_PE_Proyectos
        /// <summary>
        /// Child PeProyectosDocumentoes where [PE_Proyectos_Documentos].[IdProyecto] point to this entity (FK_PE_Proyectos_Documentos_PE_Proyectos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosDocumento> PeProyectosDocumentoes { get; set; } // PE_Proyectos_Documentos.FK_PE_Proyectos_Documentos_PE_Proyectos
        /// <summary>
        /// Child PeProyectosNivelesEducativoes where [PE_Proyectos_NivelesEducativos].[IdProyecto] point to this entity (FK_PE_Proyectos_NivelesEducativos_PE_Proyectos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosNivelesEducativo> PeProyectosNivelesEducativoes { get; set; } // PE_Proyectos_NivelesEducativos.FK_PE_Proyectos_NivelesEducativos_PE_Proyectos
        /// <summary>
        /// Child PeTitulosPrincipales where [PE_TitulosPrincipales].[IdProyecto] point to this entity (FK_PE_TitulosPrincipales_PE_Proyectos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeTitulosPrincipale> PeTitulosPrincipales { get; set; } // PE_TitulosPrincipales.FK_PE_TitulosPrincipales_PE_Proyectos

        // Foreign keys

        /// <summary>
        /// Parent PeEstructuraEdade pointed by [PE_Proyectos].([IdEstructuraNnee]) (FK_PE_Proyectos_PE_EstructuraEdades)
        /// </summary>
        public virtual PeEstructuraEdade PeEstructuraEdade { get; set; } // FK_PE_Proyectos_PE_EstructuraEdades

        /// <summary>
        /// Parent PePlanesEditoriale pointed by [PE_Proyectos].([IdPlanEditorial]) (FK_PE_Proyectos_PE_PlanesEditoriales)
        /// </summary>
        public virtual PePlanesEditoriale PePlanesEditoriale { get; set; } // FK_PE_Proyectos_PE_PlanesEditoriales

        /// <summary>
        /// Parent PeProyectosEstado pointed by [PE_Proyectos].([IdEstado]) (FK_PE_Proyectos_PE_Proyectos_Estados)
        /// </summary>
        public virtual PeProyectosEstado PeProyectosEstado { get; set; } // FK_PE_Proyectos_PE_Proyectos_Estados

        /// <summary>
        /// Parent PeProyectosMarco pointed by [PE_Proyectos].([IdProyectoMarco]) (FK_PE_Proyectos_PE_ProyectosMarco)
        /// </summary>
        public virtual PeProyectosMarco PeProyectosMarco { get; set; } // FK_PE_Proyectos_PE_ProyectosMarco

        /// <summary>
        /// Parent Usuario pointed by [PE_Proyectos].([UsuarioBaja]) (FK_PE_Proyectos_Usuarios2)
        /// </summary>
        public virtual Usuario Usuario_UsuarioBaja { get; set; } // FK_PE_Proyectos_Usuarios2

        /// <summary>
        /// Parent Usuario pointed by [PE_Proyectos].([UsuarioCreacion]) (FK_PE_Proyectos_Usuarios)
        /// </summary>
        public virtual Usuario Usuario_UsuarioCreacion { get; set; } // FK_PE_Proyectos_Usuarios

        /// <summary>
        /// Parent Usuario pointed by [PE_Proyectos].([UsuarioModificacion]) (FK_PE_Proyectos_Usuarios1)
        /// </summary>
        public virtual Usuario Usuario_UsuarioModificacion { get; set; } // FK_PE_Proyectos_Usuarios1

        public PeProyecto()
        {
            Baja = false;
            FechaCreacion = System.DateTime.Now;
            PeProyectosAreasGlobalesMaterias = new System.Collections.Generic.List<PeProyectosAreasGlobalesMateria>();
            PeProyectosDocumentoes = new System.Collections.Generic.List<PeProyectosDocumento>();
            PeProyectosNivelesEducativoes = new System.Collections.Generic.List<PeProyectosNivelesEducativo>();
            PeTitulosPrincipales = new System.Collections.Generic.List<PeTitulosPrincipale>();
            LineaNegocios = new System.Collections.Generic.List<LineaNegocio>();
        }
    }
}