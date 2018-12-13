namespace eCat.Data.Entities
{
    public class E2FichasBasePremio
    {
        public int IdInternoPremio { get; set; } // IDInternoPremio (Primary key)
        public string IdInterno { get; set; } // IDInterno (length: 12)
        public int IdPremio { get; set; } // IDPremio
        public short? Anyo { get; set; } // Anyo
        public string Comentarios { get; set; } // Comentarios (length: 3000)

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [E2_FichasBase_Premios].([IdInterno]) (FK_E2_FichasBase_Premios_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_E2_FichasBase_Premios_FichasBase

        /// <summary>
        /// Parent Premio pointed by [E2_FichasBase_Premios].([IdPremio]) (FK_E2_FichasBase_Premios_Premios)
        /// </summary>
        public virtual Premio Premio { get; set; } // FK_E2_FichasBase_Premios_Premios
    }
}