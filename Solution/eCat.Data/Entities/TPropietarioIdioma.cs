namespace eCat.Data.Entities
{
    public class TPropietarioIdioma
    {

        ///<summary>
        /// Clave del propietario traducido
        ///</summary>
        public string Codigo { get; set; } // Codigo (Primary key) (length: 5)

        ///<summary>
        /// Nombre de propietario en el idioma de traducción
        ///</summary>
        public string Valor { get; set; } // Valor (length: 255)

        ///<summary>
        /// Clave del idioma de traducción
        ///</summary>
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_Propietario_Idioma].([IdIdiomaInterface]) (FK_T_Propietario_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_Propietario_Idioma_T_Idiomas_Plataforma
    }
}