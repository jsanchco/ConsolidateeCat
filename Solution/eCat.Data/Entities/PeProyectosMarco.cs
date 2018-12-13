namespace eCat.Data.Entities
{
    public class PeProyectosMarco
    {
        public int IdProyectoMarco { get; set; } // IdProyectoMarco (Primary key)
        public string Codigo { get; set; } // Codigo (length: 50)
        public string Descripcion { get; set; } // Descripcion (length: 255)
        public short IdPais { get; set; } // IdPais
        public short IdCampañaInicial { get; set; } // IdCampañaInicial
        public int? IdProyectoMarcoOrigen { get; set; } // IdProyectoMarcoOrigen
        public bool Baja { get; set; } // Baja
        public string UsuarioCreacion { get; set; } // UsuarioCreacion (length: 50)
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion
        public string UsuarioModificacion { get; set; } // UsuarioModificacion (length: 50)
        public System.DateTime? FechaModificacion { get; set; } // FechaModificacion
        public string UsuarioBaja { get; set; } // UsuarioBaja (length: 50)
        public System.DateTime? FechaBaja { get; set; } // FechaBaja

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) PeProyectosMarco pointed by [PE_ProyectosMarco_PreferenciasExplotacion].[IdProyectoMarco] (FK_PE_Proyectos_PreferenciasExplotacion_PE_ProyectosMarco)
        /// </summary>
        public virtual PeProyectosMarcoPreferenciasExplotacion PeProyectosMarcoPreferenciasExplotacion { get; set; } // PE_ProyectosMarco_PreferenciasExplotacion.FK_PE_Proyectos_PreferenciasExplotacion_PE_ProyectosMarco
        /// <summary>
        /// Child PeProyectoes where [PE_Proyectos].[IdProyectoMarco] point to this entity (FK_PE_Proyectos_PE_ProyectosMarco)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyecto> PeProyectoes { get; set; } // PE_Proyectos.FK_PE_Proyectos_PE_ProyectosMarco
        /// <summary>
        /// Child PeProyectosMarcoes where [PE_ProyectosMarco].[IdProyectoMarcoOrigen] point to this entity (FK_PE_ProyectosMarco_PE_ProyectosMarco)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosMarco> PeProyectosMarcoes { get; set; } // PE_ProyectosMarco.FK_PE_ProyectosMarco_PE_ProyectosMarco
        /// <summary>
        /// Child PeProyectosMarcoDocumentoes where [PE_ProyectosMarco_Documentos].[IdProyectoMarco] point to this entity (FK_PE_ProyectosMarco_Documentos_PE_ProyectosMarco)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosMarcoDocumento> PeProyectosMarcoDocumentoes { get; set; } // PE_ProyectosMarco_Documentos.FK_PE_ProyectosMarco_Documentos_PE_ProyectosMarco

        // Foreign keys

        /// <summary>
        /// Parent E2AclDominio pointed by [PE_ProyectosMarco].([IdPais]) (FK_PE_ProyectosMarco_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual E2AclDominio E2AclDominio { get; set; } // FK_PE_ProyectosMarco_E2_ACL_DOMINIOS

        /// <summary>
        /// Parent PeProyectosMarco pointed by [PE_ProyectosMarco].([IdProyectoMarcoOrigen]) (FK_PE_ProyectosMarco_PE_ProyectosMarco)
        /// </summary>
        public virtual PeProyectosMarco PeProyectosMarco_IdProyectoMarcoOrigen { get; set; } // FK_PE_ProyectosMarco_PE_ProyectosMarco

        /// <summary>
        /// Parent TCampañas pointed by [PE_ProyectosMarco].([IdCampañaInicial]) (FK_PE_ProyectosMarco_T_Campañas)
        /// </summary>
        public virtual TCampañas TCampañas { get; set; } // FK_PE_ProyectosMarco_T_Campañas

        /// <summary>
        /// Parent Usuario pointed by [PE_ProyectosMarco].([UsuarioBaja]) (FK_PE_ProyectosMarco_Usuarios2)
        /// </summary>
        public virtual Usuario Usuario_UsuarioBaja { get; set; } // FK_PE_ProyectosMarco_Usuarios2

        /// <summary>
        /// Parent Usuario pointed by [PE_ProyectosMarco].([UsuarioCreacion]) (FK_PE_ProyectosMarco_Usuarios)
        /// </summary>
        public virtual Usuario Usuario_UsuarioCreacion { get; set; } // FK_PE_ProyectosMarco_Usuarios

        /// <summary>
        /// Parent Usuario pointed by [PE_ProyectosMarco].([UsuarioModificacion]) (FK_PE_ProyectosMarco_Usuarios1)
        /// </summary>
        public virtual Usuario Usuario_UsuarioModificacion { get; set; } // FK_PE_ProyectosMarco_Usuarios1

        public PeProyectosMarco()
        {
            IdPais = 1;
            Baja = false;
            FechaCreacion = System.DateTime.Now;
            PeProyectoes = new System.Collections.Generic.List<PeProyecto>();
            PeProyectosMarcoes = new System.Collections.Generic.List<PeProyectosMarco>();
            PeProyectosMarcoDocumentoes = new System.Collections.Generic.List<PeProyectosMarcoDocumento>();
        }
    }
}