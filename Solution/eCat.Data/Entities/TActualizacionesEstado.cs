namespace eCat.Data.Entities
{
    public class TActualizacionesEstado
    {
        public byte IdEstadoActualizacion { get; set; } // IdEstadoActualizacion (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child TActualizacionesCabeceras where [T_Actualizaciones_Cabecera].[IdEstadoActualizacion] point to this entity (FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Estados)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesCabecera> TActualizacionesCabeceras { get; set; } // T_Actualizaciones_Cabecera.FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Estados
        /// <summary>
        /// Child TActualizacionesEstadosIdiomas where [T_Actualizaciones_Estados_Idioma].[IdEstadoActualizacion] point to this entity (FK_T_Actualizaciones_Estados_Idioma_T_Actualizaciones_Estados)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesEstadosIdioma> TActualizacionesEstadosIdiomas { get; set; } // T_Actualizaciones_Estados_Idioma.FK_T_Actualizaciones_Estados_Idioma_T_Actualizaciones_Estados

        public TActualizacionesEstado()
        {
            TActualizacionesCabeceras = new System.Collections.Generic.List<TActualizacionesCabecera>();
            TActualizacionesEstadosIdiomas = new System.Collections.Generic.List<TActualizacionesEstadosIdioma>();
        }
    }
}