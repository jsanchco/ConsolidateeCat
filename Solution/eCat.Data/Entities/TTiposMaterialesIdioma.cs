namespace eCat.Data.Entities
{
    public class TTiposMaterialesIdioma
    {
        public short IdTipoMaterial { get; set; } // IdTipoMaterial (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_TiposMateriales_Idioma].([IdIdiomaInterface]) (FK_T_TiposMateriales_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_TiposMateriales_Idioma_T_Idiomas_Plataforma

        /// <summary>
        /// Parent TTiposMateriale pointed by [T_TiposMateriales_Idioma].([IdTipoMaterial]) (FK_T_TiposMateriales_Idioma_T_TiposMateriales)
        /// </summary>
        public virtual TTiposMateriale TTiposMateriale { get; set; } // FK_T_TiposMateriales_Idioma_T_TiposMateriales
    }
}