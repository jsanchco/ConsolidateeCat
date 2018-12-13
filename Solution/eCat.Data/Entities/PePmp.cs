namespace eCat.Data.Entities
{
    public class PePmp
    {
        public int IdPmp { get; set; } // IdPMP (Primary key)
        public string Codigo { get; set; } // Codigo (length: 50)
        public string Descripcion { get; set; } // Descripcion (length: 2559)
        public short IdPais { get; set; } // IdPais
        public short IdCampañaInicial { get; set; } // IdCampañaInicial
        public short IdCampañaFinal { get; set; } // IdCampañaFinal
        public bool Baja { get; set; } // Baja
        public string UsuarioCreacion { get; set; } // UsuarioCreacion (length: 50)
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion
        public string UsuarioModificacion { get; set; } // UsuarioModificacion (length: 50)
        public System.DateTime? FechaModificacion { get; set; } // FechaModificacion
        public string UsuarioBaja { get; set; } // UsuarioBaja (length: 50)
        public System.DateTime? FechaBaja { get; set; } // FechaBaja

        // Reverse navigation

        /// <summary>
        /// Child PePmPsDocumentoes where [PE_PMPs_Documentos].[IdPMP] point to this entity (FK_PE_PMPs_Documentos_PE_PMPs)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePmPsDocumento> PePmPsDocumentoes { get; set; } // PE_PMPs_Documentos.FK_PE_PMPs_Documentos_PE_PMPs

        // Foreign keys

        /// <summary>
        /// Parent E2AclDominio pointed by [PE_PMPs].([IdPais]) (FK_PE_PMPs_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual E2AclDominio E2AclDominio { get; set; } // FK_PE_PMPs_E2_ACL_DOMINIOS

        /// <summary>
        /// Parent TCampañas pointed by [PE_PMPs].([IdCampañaFinal]) (FK_PE_PMPs_T_Campañas1)
        /// </summary>
        public virtual TCampañas TCampañas_IdCampañaFinal { get; set; } // FK_PE_PMPs_T_Campañas1

        /// <summary>
        /// Parent TCampañas pointed by [PE_PMPs].([IdCampañaInicial]) (FK_PE_PMPs_T_Campañas)
        /// </summary>
        public virtual TCampañas TCampañas_IdCampañaInicial { get; set; } // FK_PE_PMPs_T_Campañas

        /// <summary>
        /// Parent Usuario pointed by [PE_PMPs].([UsuarioBaja]) (FK_PE_PMPs_Usuarios2)
        /// </summary>
        public virtual Usuario Usuario_UsuarioBaja { get; set; } // FK_PE_PMPs_Usuarios2

        /// <summary>
        /// Parent Usuario pointed by [PE_PMPs].([UsuarioCreacion]) (FK_PE_PMPs_Usuarios)
        /// </summary>
        public virtual Usuario Usuario_UsuarioCreacion { get; set; } // FK_PE_PMPs_Usuarios

        /// <summary>
        /// Parent Usuario pointed by [PE_PMPs].([UsuarioModificacion]) (FK_PE_PMPs_Usuarios1)
        /// </summary>
        public virtual Usuario Usuario_UsuarioModificacion { get; set; } // FK_PE_PMPs_Usuarios1

        public PePmp()
        {
            Baja = false;
            FechaCreacion = System.DateTime.Now;
            PePmPsDocumentoes = new System.Collections.Generic.List<PePmPsDocumento>();
        }
    }
}