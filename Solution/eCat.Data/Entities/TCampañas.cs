namespace eCat.Data.Entities
{
    public class TCampañas
    {

        ///<summary>
        /// Clave de campaña
        ///</summary>
        public short IdCampaña { get; set; } // IdCampaña (Primary key)

        ///<summary>
        /// Nombre de la campaña
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 50)
        public System.DateTime? Inicio { get; set; } // Inicio
        public System.DateTime? Fin { get; set; } // Fin

        // Reverse navigation

        /// <summary>
        /// Child E2AclDominio (Many-to-Many) mapped by table [T_Campañas_Dominios]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2AclDominio> E2AclDominio { get; set; } // Many to many mapping
        /// <summary>
        /// Child FichasBases where [FichasBase].[IdCampaña] point to this entity (FK_FichasBase_T_Campañas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_T_Campañas
        /// <summary>
        /// Child PePmps where [PE_PMPs].[IdCampañaFinal] point to this entity (FK_PE_PMPs_T_Campañas1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePmp> PePmps_IdCampañaFinal { get; set; } // PE_PMPs.FK_PE_PMPs_T_Campañas1
        /// <summary>
        /// Child PePmps where [PE_PMPs].[IdCampañaInicial] point to this entity (FK_PE_PMPs_T_Campañas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PePmp> PePmps_IdCampañaInicial { get; set; } // PE_PMPs.FK_PE_PMPs_T_Campañas
        /// <summary>
        /// Child PeProyectosMarcoes where [PE_ProyectosMarco].[IdCampañaInicial] point to this entity (FK_PE_ProyectosMarco_T_Campañas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosMarco> PeProyectosMarcoes { get; set; } // PE_ProyectosMarco.FK_PE_ProyectosMarco_T_Campañas

        public TCampañas()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            PePmps_IdCampañaFinal = new System.Collections.Generic.List<PePmp>();
            PePmps_IdCampañaInicial = new System.Collections.Generic.List<PePmp>();
            PeProyectosMarcoes = new System.Collections.Generic.List<PeProyectosMarco>();
            E2AclDominio = new System.Collections.Generic.List<E2AclDominio>();
        }
    }
}