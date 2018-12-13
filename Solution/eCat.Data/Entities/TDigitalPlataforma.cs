namespace eCat.Data.Entities
{
    public class TDigitalPlataforma
    {
        public byte IdPlataforma { get; set; } // IdPlataforma (Primary key)
        public string Plataforma { get; set; } // Plataforma (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child FichasBases (Many-to-Many) mapped by table [T_FichasBase_Digital_Plataformas]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // Many to many mapping
        /// <summary>
        /// Child TDigitalPlataformasIdiomas where [T_Digital_Plataformas_Idioma].[IdPlataforma] point to this entity (FK_T_Digital_Plataformas_Idioma_T_Digital_Plataformas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TDigitalPlataformasIdioma> TDigitalPlataformasIdiomas { get; set; } // T_Digital_Plataformas_Idioma.FK_T_Digital_Plataformas_Idioma_T_Digital_Plataformas

        public TDigitalPlataforma()
        {
            TDigitalPlataformasIdiomas = new System.Collections.Generic.List<TDigitalPlataformasIdioma>();
            FichasBases = new System.Collections.Generic.List<FichasBase>();
        }
    }
}