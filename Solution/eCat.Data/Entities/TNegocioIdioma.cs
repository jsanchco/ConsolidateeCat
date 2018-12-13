namespace eCat.Data.Entities
{
    public class TNegocioIdioma
    {

        ///<summary>
        /// Clave del negocio traducido
        ///</summary>
        public string Codigo { get; set; } // Codigo (Primary key) (length: 5)

        ///<summary>
        /// Nombre del negocio en el idioma de traducción
        ///</summary>
        public string Valor { get; set; } // Valor (length: 255)

        ///<summary>
        /// Clave del idioma de traducción
        ///</summary>
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_Negocio_Idioma].([IdIdiomaInterface]) (FK_T_Negocio_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_Negocio_Idioma_T_Idiomas_Plataforma
    }
}