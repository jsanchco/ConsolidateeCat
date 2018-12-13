namespace eCat.Data.Entities
{
    public class TActualizacionesCabecera
    {
        public long IdActualizacion { get; set; } // IdActualizacion (Primary key)
        public string IdUsuario { get; set; } // IdUsuario (length: 50)
        public decimal IdConsulta { get; set; } // IdConsulta
        public string CodigoCampoActualizacion { get; set; } // CodigoCampoActualizacion (length: 10)
        public byte IdTipoActualizacion { get; set; } // IdTipoActualizacion
        public string NuevoValor { get; set; } // NuevoValor (length: 500)
        public string NuevoValorDescripcion { get; set; } // NuevoValorDescripcion (length: 500)
        public byte IdEstadoActualizacion { get; set; } // IdEstadoActualizacion
        public string Comentarios { get; set; } // Comentarios (length: 1000)
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion
        public System.DateTime? FechaEjecucionInicio { get; set; } // FechaEjecucionInicio
        public System.DateTime? FechaEjecucionFin { get; set; } // FechaEjecucionFin

        // Reverse navigation

        /// <summary>
        /// Child TActualizacionesDetalles where [T_Actualizaciones_Detalle].[IdActualizacion] point to this entity (FK_T_actualizaciones_Detalle_T_Actualizaciones_Cabecera)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesDetalle> TActualizacionesDetalles { get; set; } // T_Actualizaciones_Detalle.FK_T_actualizaciones_Detalle_T_Actualizaciones_Cabecera

        // Foreign keys

        /// <summary>
        /// Parent E2ConsultasAsistente pointed by [T_Actualizaciones_Cabecera].([IdConsulta]) (FK_T_Actualizaciones_Cabecera_E2_CONSULTAS_ASISTENTE)
        /// </summary>
        public virtual E2ConsultasAsistente E2ConsultasAsistente { get; set; } // FK_T_Actualizaciones_Cabecera_E2_CONSULTAS_ASISTENTE

        /// <summary>
        /// Parent TActualizacionesCampos pointed by [T_Actualizaciones_Cabecera].([CodigoCampoActualizacion]) (FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Campos)
        /// </summary>
        public virtual TActualizacionesCampos TActualizacionesCampos { get; set; } // FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Campos

        /// <summary>
        /// Parent TActualizacionesEstado pointed by [T_Actualizaciones_Cabecera].([IdEstadoActualizacion]) (FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Estados)
        /// </summary>
        public virtual TActualizacionesEstado TActualizacionesEstado { get; set; } // FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Estados

        /// <summary>
        /// Parent TActualizacionesTiposActualizacion pointed by [T_Actualizaciones_Cabecera].([IdTipoActualizacion]) (FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Tipos)
        /// </summary>
        public virtual TActualizacionesTiposActualizacion TActualizacionesTiposActualizacion { get; set; } // FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Tipos

        /// <summary>
        /// Parent Usuario pointed by [T_Actualizaciones_Cabecera].([IdUsuario]) (FK_T_Actualizaciones_Cabecera_Usuarios)
        /// </summary>
        public virtual Usuario Usuario { get; set; } // FK_T_Actualizaciones_Cabecera_Usuarios

        public TActualizacionesCabecera()
        {
            IdEstadoActualizacion = 0;
            FechaCreacion = System.DateTime.Now;
            TActualizacionesDetalles = new System.Collections.Generic.List<TActualizacionesDetalle>();
        }
    }
}