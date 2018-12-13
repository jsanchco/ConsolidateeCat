namespace eCat.Data.Entities
{
    public class TActualizacionesTiposCampo
    {
        public byte IdTipoCampoActualizacion { get; set; } // IdTipoCampoActualizacion (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child TActualizacionesCampos where [T_Actualizaciones_Campos].[IdTipoCampoActualizacion] point to this entity (FK_T_Actualizaciones_Campos_T_Actualizaciones_TiposCampo)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesCampos> TActualizacionesCampos { get; set; } // T_Actualizaciones_Campos.FK_T_Actualizaciones_Campos_T_Actualizaciones_TiposCampo

        public TActualizacionesTiposCampo()
        {
            TActualizacionesCampos = new System.Collections.Generic.List<TActualizacionesCampos>();
        }
    }
}