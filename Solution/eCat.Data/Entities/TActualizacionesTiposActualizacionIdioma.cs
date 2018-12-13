namespace eCat.Data.Entities
{
    public class TActualizacionesTiposActualizacionIdioma
    {
        public byte IdTipoActualizacion { get; set; } // IdTipoActualizacion (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TActualizacionesTiposActualizacion pointed by [T_Actualizaciones_TiposActualizacion_Idioma].([IdTipoActualizacion]) (FK_T_Actualizaciones_Tipos_Idioma_T_Actualizaciones_Tipos)
        /// </summary>
        public virtual TActualizacionesTiposActualizacion TActualizacionesTiposActualizacion { get; set; } // FK_T_Actualizaciones_Tipos_Idioma_T_Actualizaciones_Tipos

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_Actualizaciones_TiposActualizacion_Idioma].([IdIdiomaInterface]) (FK_T_Actualizaciones_TiposActualizacion_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_Actualizaciones_TiposActualizacion_Idioma_T_Idiomas_Plataforma
    }
}