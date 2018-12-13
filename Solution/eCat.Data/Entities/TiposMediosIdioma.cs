namespace eCat.Data.Entities
{
    public class TiposMediosIdioma
    {

        ///<summary>
        /// Clave del tipo de idioma
        ///</summary>
        public int IdTipoMedio { get; set; } // IDTipoMedio (Primary key)

        ///<summary>
        /// Clave del idioma de traducción
        ///</summary>
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        ///<summary>
        /// Término o frase equivalente en el idioma de traducción
        ///</summary>
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [TiposMedios_Idioma].([IdIdiomaInterface]) (FK_TiposMedios_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_TiposMedios_Idioma_T_Idiomas_Plataforma
    }
}