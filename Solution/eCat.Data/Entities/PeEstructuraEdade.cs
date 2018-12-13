namespace eCat.Data.Entities
{
    public class PeEstructuraEdade
    {
        public int IdEstructura { get; set; } // IdEstructura (Primary key)
        public short IdPais { get; set; } // IdPais
        public bool Baja { get; set; } // Baja
        public System.DateTime FechaAlta { get; set; } // FechaAlta
        public System.DateTime? FechaBaja { get; set; } // FechaBaja
        public System.DateTime? FechaUltimaModificacion { get; set; } // FechaUltimaModificacion

        // Reverse navigation

        /// <summary>
        /// Child PeEstructuraEdadesNivelesEducativoes where [PE_EstructuraEdades_NivelesEducativos].[IdEstructura] point to this entity (FK_PE_Edades_NivelesEducativos_PE_Edades)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeEstructuraEdadesNivelesEducativo> PeEstructuraEdadesNivelesEducativoes { get; set; } // PE_EstructuraEdades_NivelesEducativos.FK_PE_Edades_NivelesEducativos_PE_Edades
        /// <summary>
        /// Child PeProyectoes where [PE_Proyectos].[IdEstructuraNNEE] point to this entity (FK_PE_Proyectos_PE_EstructuraEdades)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyecto> PeProyectoes { get; set; } // PE_Proyectos.FK_PE_Proyectos_PE_EstructuraEdades

        // Foreign keys

        /// <summary>
        /// Parent E2AclDominio pointed by [PE_EstructuraEdades].([IdPais]) (FK_PE_Edades_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual E2AclDominio E2AclDominio { get; set; } // FK_PE_Edades_E2_ACL_DOMINIOS

        public PeEstructuraEdade()
        {
            PeEstructuraEdadesNivelesEducativoes = new System.Collections.Generic.List<PeEstructuraEdadesNivelesEducativo>();
            PeProyectoes = new System.Collections.Generic.List<PeProyecto>();
        }
    }
}