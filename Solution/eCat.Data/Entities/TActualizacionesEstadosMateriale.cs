namespace eCat.Data.Entities
{
    public class TActualizacionesEstadosMateriale
    {
        public byte IdEstadoActualizacionMaterial { get; set; } // IdEstadoActualizacionMaterial (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child TActualizacionesDetalles where [T_Actualizaciones_Detalle].[IdEstadoActualizacionMaterial] point to this entity (FK_T_actualizaciones_Detalle_T_Actualizaciones_Estados_Materiales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesDetalle> TActualizacionesDetalles { get; set; } // T_Actualizaciones_Detalle.FK_T_actualizaciones_Detalle_T_Actualizaciones_Estados_Materiales
        /// <summary>
        /// Child TActualizacionesEstadosMaterialesIdiomas where [T_Actualizaciones_Estados_Materiales_Idioma].[IdEstadoActualizacionMaterial] point to this entity (FK_T_Actualizaciones_Estados_Materiales_Idioma_T_Actualizaciones_Estados_Materiales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesEstadosMaterialesIdioma> TActualizacionesEstadosMaterialesIdiomas { get; set; } // T_Actualizaciones_Estados_Materiales_Idioma.FK_T_Actualizaciones_Estados_Materiales_Idioma_T_Actualizaciones_Estados_Materiales

        public TActualizacionesEstadosMateriale()
        {
            TActualizacionesDetalles = new System.Collections.Generic.List<TActualizacionesDetalle>();
            TActualizacionesEstadosMaterialesIdiomas = new System.Collections.Generic.List<TActualizacionesEstadosMaterialesIdioma>();
        }
    }
}