namespace eCat.Data.Entities
{
    public class TSoportesIdioma
    {
        public byte IdSoporte { get; set; } // IdSoporte (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_Soportes_Idioma].([IdIdiomaInterface]) (FK_T_Soportes_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_Soportes_Idioma_T_Idiomas_Plataforma
    }
}