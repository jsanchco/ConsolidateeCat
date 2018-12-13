namespace eCat.Data.Entities
{
    public class Premio
    {
        public int IdPremio { get; set; } // IDPremio (Primary key)
        public string Premio_ { get; set; } // Premio (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child E2FichasBasePremio where [E2_FichasBase_Premios].[IDPremio] point to this entity (FK_E2_FichasBase_Premios_Premios)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2FichasBasePremio> E2FichasBasePremio { get; set; } // E2_FichasBase_Premios.FK_E2_FichasBase_Premios_Premios

        public Premio()
        {
            E2FichasBasePremio = new System.Collections.Generic.List<E2FichasBasePremio>();
        }
    }
}