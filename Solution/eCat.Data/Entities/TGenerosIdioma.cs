namespace eCat.Data.Entities
{
    public class TGenerosIdioma
    {
        public byte IdGenero { get; set; } // IdGenero (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_Generos_Idioma].([IdIdiomaInterface]) (FK_T_Generos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_Generos_Idioma_T_Idiomas_Plataforma
    }
}