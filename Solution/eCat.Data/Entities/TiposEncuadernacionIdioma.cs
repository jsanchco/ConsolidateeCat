namespace eCat.Data.Entities
{
    public class TiposEncuadernacionIdioma
    {

        ///<summary>
        /// Clave del tipo de encuadernación
        ///</summary>
        public byte IdTipoEncuadernacion { get; set; } // IDTipoEncuadernacion (Primary key)

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
        /// Parent TIdiomasPlataforma pointed by [TiposEncuadernacion_Idioma].([IdIdiomaInterface]) (FK_TiposEncuadernacion_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_TiposEncuadernacion_Idioma_T_Idiomas_Plataforma
    }
}