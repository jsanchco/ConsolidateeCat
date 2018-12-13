namespace eCat.Data.Entities
{
    public class TEtapasRangoEdadIdioma
    {

        ///<summary>
        /// Clave de la etapa o rango de edad traducidos
        ///</summary>
        public string Codigo { get; set; } // Codigo (Primary key) (length: 5)

        ///<summary>
        /// Nombre de la etapa o rango de edad en el idioma de traducción
        ///</summary>
        public string Valor { get; set; } // Valor (length: 255)

        ///<summary>
        /// Clave del idioma de traducción
        ///</summary>
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_EtapasRangoEdad_Idioma].([IdIdiomaInterface]) (FK_T_EtapasRangoEdad_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_EtapasRangoEdad_Idioma_T_Idiomas_Plataforma
    }
}