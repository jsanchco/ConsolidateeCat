namespace eCat.Data.Entities
{
    public class TiposArticulosIdioma
    {

        ///<summary>
        /// Clave del tipo de artículo traducido
        ///</summary>
        public byte IdTipoArticulo { get; set; } // IDTipoArticulo (Primary key)

        ///<summary>
        /// Clave del idioma de traducción
        ///</summary>
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        ///<summary>
        /// Nombre del tipo de artículo en el idioma de traducción
        ///</summary>
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [TiposArticulos_Idioma].([IdIdiomaInterface]) (FK_TiposArticulos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_TiposArticulos_Idioma_T_Idiomas_Plataforma
    }
}