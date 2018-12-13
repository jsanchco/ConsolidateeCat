namespace eCat.Data.Entities
{
    public class TiposDocumentosIdioma
    {
        public byte IdTipoDocumento { get; set; } // IDTipoDocumento (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [TiposDocumentos_Idioma].([IdIdiomaInterface]) (FK_TiposDocumentos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_TiposDocumentos_Idioma_T_Idiomas_Plataforma
    }
}