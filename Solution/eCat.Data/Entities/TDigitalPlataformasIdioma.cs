namespace eCat.Data.Entities
{
    public class TDigitalPlataformasIdioma
    {
        public byte IdPlataforma { get; set; } // IdPlataforma (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TDigitalPlataforma pointed by [T_Digital_Plataformas_Idioma].([IdPlataforma]) (FK_T_Digital_Plataformas_Idioma_T_Digital_Plataformas)
        /// </summary>
        public virtual TDigitalPlataforma TDigitalPlataforma { get; set; } // FK_T_Digital_Plataformas_Idioma_T_Digital_Plataformas

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_Digital_Plataformas_Idioma].([IdIdiomaInterface]) (FK_T_Digital_Plataformas_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_Digital_Plataformas_Idioma_T_Idiomas_Plataforma
    }
}