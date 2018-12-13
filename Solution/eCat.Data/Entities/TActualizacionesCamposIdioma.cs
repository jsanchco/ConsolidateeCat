namespace eCat.Data.Entities
{
    public class TActualizacionesCamposIdioma
    {
        public string CodigoCampoActualizacion { get; set; } // CodigoCampoActualizacion (Primary key) (length: 10)
        public string Valor { get; set; } // Valor (length: 255)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TActualizacionesCampos pointed by [T_Actualizaciones_Campos_Idiomas].([CodigoCampoActualizacion]) (FK_T_Actualizaciones_Campos_Idiomas_T_Actualizaciones_Campos)
        /// </summary>
        public virtual TActualizacionesCampos TActualizacionesCampos { get; set; } // FK_T_Actualizaciones_Campos_Idiomas_T_Actualizaciones_Campos

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_Actualizaciones_Campos_Idiomas].([IdIdiomaInterface]) (FK_T_Actualizaciones_Campos_Idiomas_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_Actualizaciones_Campos_Idiomas_T_Idiomas_Plataforma
    }
}