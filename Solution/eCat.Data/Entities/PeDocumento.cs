namespace eCat.Data.Entities
{
    public class PeDocumento
    {
        public long IdDocumento { get; set; } // IdDocumento (Primary key)
        public System.Guid Guid { get; set; } // GUID
        public string Nombre { get; set; } // Nombre (length: 255)
        public string Descripcion { get; set; } // Descripcion
        public bool Baja { get; set; } // Baja
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion
        public string UsuarioCreacion { get; set; } // UsuarioCreacion (length: 50)
        public System.DateTime? FechaModificacion { get; set; } // FechaModificacion
        public string UsuarioModificacion { get; set; } // UsuarioModificacion (length: 50)
        public System.DateTime? FechaBaja { get; set; } // FechaBaja
        public string UsuarioBaja { get; set; } // UsuarioBaja (length: 50)
        public string Path { get; set; } // Path
        public string Extension { get; set; } // Extension (length: 50)
        public string NombreFicheroOriginal { get; set; } // NombreFicheroOriginal (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child PeComponentesDocumentoes where [PE_Componentes_Documentos].[IdDocumento] point to this entity (FK_PE_Componentes_Documentos_PE_Documentos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesDocumento> PeComponentesDocumentoes { get; set; } // PE_Componentes_Documentos.FK_PE_Componentes_Documentos_PE_Documentos
        /// <summary>
        /// Child PePlanesEditorialesDocumentoes where [PE_PlanesEditoriales_Documentos].[IdDocumento] point to this entity (FK_PE_PlanesEditoriales_Documentos_PE_Documentos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePlanesEditorialesDocumento> PePlanesEditorialesDocumentoes { get; set; } // PE_PlanesEditoriales_Documentos.FK_PE_PlanesEditoriales_Documentos_PE_Documentos
        /// <summary>
        /// Child PePmPsDocumentoes where [PE_PMPs_Documentos].[IdDocumento] point to this entity (FK_PE_PMPs_Documentos_PE_Documentos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePmPsDocumento> PePmPsDocumentoes { get; set; } // PE_PMPs_Documentos.FK_PE_PMPs_Documentos_PE_Documentos
        /// <summary>
        /// Child PeProyectosDocumentoes where [PE_Proyectos_Documentos].[IdDocumento] point to this entity (FK_PE_Proyectos_Documentos_PE_Documentos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosDocumento> PeProyectosDocumentoes { get; set; } // PE_Proyectos_Documentos.FK_PE_Proyectos_Documentos_PE_Documentos
        /// <summary>
        /// Child PeProyectosMarcoDocumentoes where [PE_ProyectosMarco_Documentos].[IdDocumento] point to this entity (FK_PE_ProyectosMarco_Documentos_PE_Documentos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosMarcoDocumento> PeProyectosMarcoDocumentoes { get; set; } // PE_ProyectosMarco_Documentos.FK_PE_ProyectosMarco_Documentos_PE_Documentos
        /// <summary>
        /// Child PeTitulosPrincipalesDocumentoes where [PE_TitulosPrincipales_Documentos].[IdDocumento] point to this entity (FK_PE_TitulosPrincipales_Documentos_PE_Documentos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeTitulosPrincipalesDocumento> PeTitulosPrincipalesDocumentoes { get; set; } // PE_TitulosPrincipales_Documentos.FK_PE_TitulosPrincipales_Documentos_PE_Documentos

        // Foreign keys

        /// <summary>
        /// Parent Usuario pointed by [PE_Documentos].([UsuarioBaja]) (FK_PE_Documentos_Usuarios2)
        /// </summary>
        public virtual Usuario Usuario_UsuarioBaja { get; set; } // FK_PE_Documentos_Usuarios2

        /// <summary>
        /// Parent Usuario pointed by [PE_Documentos].([UsuarioCreacion]) (FK_PE_Documentos_Usuarios)
        /// </summary>
        public virtual Usuario Usuario_UsuarioCreacion { get; set; } // FK_PE_Documentos_Usuarios

        /// <summary>
        /// Parent Usuario pointed by [PE_Documentos].([UsuarioModificacion]) (FK_PE_Documentos_Usuarios1)
        /// </summary>
        public virtual Usuario Usuario_UsuarioModificacion { get; set; } // FK_PE_Documentos_Usuarios1

        public PeDocumento()
        {
            Guid = System.Guid.NewGuid();
            Baja = false;
            FechaCreacion = System.DateTime.Now;
            PeComponentesDocumentoes = new System.Collections.Generic.List<PeComponentesDocumento>();
            PePlanesEditorialesDocumentoes = new System.Collections.Generic.List<PePlanesEditorialesDocumento>();
            PePmPsDocumentoes = new System.Collections.Generic.List<PePmPsDocumento>();
            PeProyectosDocumentoes = new System.Collections.Generic.List<PeProyectosDocumento>();
            PeProyectosMarcoDocumentoes = new System.Collections.Generic.List<PeProyectosMarcoDocumento>();
            PeTitulosPrincipalesDocumentoes = new System.Collections.Generic.List<PeTitulosPrincipalesDocumento>();
        }
    }
}