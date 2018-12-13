namespace eCat.Data.Entities
{
    public class TSeriesIdioma
    {

        ///<summary>
        /// Clave de la serie traducida
        ///</summary>
        public int IdSerie { get; set; } // IdSerie (Primary key)

        ///<summary>
        /// Clave del idioma de traducción
        ///</summary>
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        ///<summary>
        /// Nombre de la serie en el idioma de traducción
        ///</summary>
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_Series_Idioma].([IdIdiomaInterface]) (FK_T_Series_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_Series_Idioma_T_Idiomas_Plataforma
    }
}