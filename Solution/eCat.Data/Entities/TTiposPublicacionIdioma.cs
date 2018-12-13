namespace eCat.Data.Entities
{
    public class TTiposPublicacionIdioma
    {
        public int IdTipoPublicacion { get; set; } // IdTipoPublicacion (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_TiposPublicacion_Idioma].([IdIdiomaInterface]) (FK_T_TiposPublicacion_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_TiposPublicacion_Idioma_T_Idiomas_Plataforma
    }
}