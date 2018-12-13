namespace eCat.Data.Entities
{
    public class IdiomasIdioma
    {

        ///<summary>
        /// Clave del idioma traducido
        ///</summary>
        public byte IdIdioma { get; set; } // IDIdioma (Primary key)

        ///<summary>
        /// Clave del idioma de traducción
        ///</summary>
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        ///<summary>
        /// Nombre del idioma en el idioma de traducción
        ///</summary>
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [Idiomas_Idioma].([IdIdiomaInterface]) (FK_Idiomas_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_Idiomas_Idioma_T_Idiomas_Plataforma
    }
}