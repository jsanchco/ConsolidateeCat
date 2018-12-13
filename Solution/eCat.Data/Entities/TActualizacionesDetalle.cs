namespace eCat.Data.Entities
{
    public class TActualizacionesDetalle
    {
        public long IdActualizacion { get; set; } // IdActualizacion (Primary key)
        public string IdInterno { get; set; } // IdInterno (Primary key) (length: 12)
        public byte IdEstadoActualizacionMaterial { get; set; } // IdEstadoActualizacionMaterial
        public string Comentarios { get; set; } // Comentarios (length: 1000)

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [T_Actualizaciones_Detalle].([IdInterno]) (FK_T_actualizaciones_Detalle_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_T_actualizaciones_Detalle_FichasBase

        /// <summary>
        /// Parent TActualizacionesCabecera pointed by [T_Actualizaciones_Detalle].([IdActualizacion]) (FK_T_actualizaciones_Detalle_T_Actualizaciones_Cabecera)
        /// </summary>
        public virtual TActualizacionesCabecera TActualizacionesCabecera { get; set; } // FK_T_actualizaciones_Detalle_T_Actualizaciones_Cabecera

        /// <summary>
        /// Parent TActualizacionesEstadosMateriale pointed by [T_Actualizaciones_Detalle].([IdEstadoActualizacionMaterial]) (FK_T_actualizaciones_Detalle_T_Actualizaciones_Estados_Materiales)
        /// </summary>
        public virtual TActualizacionesEstadosMateriale TActualizacionesEstadosMateriale { get; set; } // FK_T_actualizaciones_Detalle_T_Actualizaciones_Estados_Materiales
    }
}