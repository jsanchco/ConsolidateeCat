namespace eCat.Data.Entities
{
    public class PePlanesEditoriale
    {
        public int IdPlanEditorial { get; set; } // IdPlanEditorial (Primary key)
        public string Codigo { get; set; } // Codigo (length: 50)
        public string Descripcion { get; set; } // Descripcion (length: 255)
        public short IdPais { get; set; } // IdPais
        public int IdCampaña { get; set; } // IdCampaña
        public int? IdPmp { get; set; } // IdPMP
        public bool Baja { get; set; } // Baja
        public string UsuarioCreacion { get; set; } // UsuarioCreacion (length: 50)
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion
        public string UsuarioModificacion { get; set; } // UsuarioModificacion (length: 50)
        public System.DateTime? FechaModificacion { get; set; } // FechaModificacion
        public string UsuarioBaja { get; set; } // UsuarioBaja (length: 50)
        public System.DateTime? FechaBaja { get; set; } // FechaBaja

        // Reverse navigation

        /// <summary>
        /// Child LineaNegocios (Many-to-Many) mapped by table [PE_PlanesEditoriales_LineaNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<LineaNegocio> LineaNegocios { get; set; } // Many to many mapping
        /// <summary>
        /// Child PePlanesEditorialesDocumentoes where [PE_PlanesEditoriales_Documentos].[IdPlanEditorial] point to this entity (FK_PE_PlanesEditoriales_Documentos_PE_PlanesEditoriales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePlanesEditorialesDocumento> PePlanesEditorialesDocumentoes { get; set; } // PE_PlanesEditoriales_Documentos.FK_PE_PlanesEditoriales_Documentos_PE_PlanesEditoriales
        /// <summary>
        /// Child PeProyectoes where [PE_Proyectos].[IdPlanEditorial] point to this entity (FK_PE_Proyectos_PE_PlanesEditoriales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyecto> PeProyectoes { get; set; } // PE_Proyectos.FK_PE_Proyectos_PE_PlanesEditoriales

        // Foreign keys

        /// <summary>
        /// Parent E2AclDominio pointed by [PE_PlanesEditoriales].([IdPais]) (FK_PE_PlanesEditoriales_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual E2AclDominio E2AclDominio { get; set; } // FK_PE_PlanesEditoriales_E2_ACL_DOMINIOS

        /// <summary>
        /// Parent Usuario pointed by [PE_PlanesEditoriales].([UsuarioBaja]) (FK_PE_PlanesEditoriales_Usuarios2)
        /// </summary>
        public virtual Usuario Usuario_UsuarioBaja { get; set; } // FK_PE_PlanesEditoriales_Usuarios2

        /// <summary>
        /// Parent Usuario pointed by [PE_PlanesEditoriales].([UsuarioCreacion]) (FK_PE_PlanesEditoriales_Usuarios)
        /// </summary>
        public virtual Usuario Usuario_UsuarioCreacion { get; set; } // FK_PE_PlanesEditoriales_Usuarios

        /// <summary>
        /// Parent Usuario pointed by [PE_PlanesEditoriales].([UsuarioModificacion]) (FK_PE_PlanesEditoriales_Usuarios1)
        /// </summary>
        public virtual Usuario Usuario_UsuarioModificacion { get; set; } // FK_PE_PlanesEditoriales_Usuarios1

        public PePlanesEditoriale()
        {
            Baja = false;
            FechaCreacion = System.DateTime.Now;
            PePlanesEditorialesDocumentoes = new System.Collections.Generic.List<PePlanesEditorialesDocumento>();
            PeProyectoes = new System.Collections.Generic.List<PeProyecto>();
            LineaNegocios = new System.Collections.Generic.List<LineaNegocio>();
        }
    }
}