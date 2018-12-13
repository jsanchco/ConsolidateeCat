namespace eCat.Data.Entities
{
    public class PremiosIdioma
    {
        public int IdPremio { get; set; } // IDPremio (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [Premios_Idioma].([IdIdiomaInterface]) (FK_Premios_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_Premios_Idioma_T_Idiomas_Plataforma
    }
}