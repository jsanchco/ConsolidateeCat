namespace eCat.Data.Entities
{
    public class TActualizacionesTiposActualizacion
    {
        public byte IdTipoActualizacion { get; set; } // IdTipoActualizacion (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child TActualizacionesCabeceras where [T_Actualizaciones_Cabecera].[IdTipoActualizacion] point to this entity (FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Tipos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesCabecera> TActualizacionesCabeceras { get; set; } // T_Actualizaciones_Cabecera.FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Tipos
        /// <summary>
        /// Child TActualizacionesTiposActualizacionIdiomas where [T_Actualizaciones_TiposActualizacion_Idioma].[IdTipoActualizacion] point to this entity (FK_T_Actualizaciones_Tipos_Idioma_T_Actualizaciones_Tipos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesTiposActualizacionIdioma> TActualizacionesTiposActualizacionIdiomas { get; set; } // T_Actualizaciones_TiposActualizacion_Idioma.FK_T_Actualizaciones_Tipos_Idioma_T_Actualizaciones_Tipos

        public TActualizacionesTiposActualizacion()
        {
            TActualizacionesCabeceras = new System.Collections.Generic.List<TActualizacionesCabecera>();
            TActualizacionesTiposActualizacionIdiomas = new System.Collections.Generic.List<TActualizacionesTiposActualizacionIdioma>();
        }
    }
}