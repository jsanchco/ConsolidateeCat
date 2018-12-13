namespace eCat.Data.Entities
{
    public class E2ConsultasAsistente
    {
        public decimal IdConsulta { get; set; } // IdConsulta (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 1000)
        public string Usuario { get; set; } // Usuario (length: 50)
        public bool Baja { get; set; } // Baja
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion

        // Reverse navigation

        /// <summary>
        /// Child E2ConsultasAsistenteCampos where [E2_CONSULTAS_ASISTENTE_CAMPOS].[IdConsulta] point to this entity (FK_E2_CONSULTAS_ASISTENTE_CAMPOS_E2_CONSULTAS_ASISTENTE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2ConsultasAsistenteCampos> E2ConsultasAsistenteCampos { get; set; } // E2_CONSULTAS_ASISTENTE_CAMPOS.FK_E2_CONSULTAS_ASISTENTE_CAMPOS_E2_CONSULTAS_ASISTENTE
        /// <summary>
        /// Child E2ConsultasAsistenteFiltro where [E2_CONSULTAS_ASISTENTE_FILTROS].[IdConsulta] point to this entity (FK_E2_CONSULTAS_ASISTENTE_FILTROS_E2_CONSULTAS_ASISTENTE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2ConsultasAsistenteFiltro> E2ConsultasAsistenteFiltro { get; set; } // E2_CONSULTAS_ASISTENTE_FILTROS.FK_E2_CONSULTAS_ASISTENTE_FILTROS_E2_CONSULTAS_ASISTENTE
        /// <summary>
        /// Child TActualizacionesCabeceras where [T_Actualizaciones_Cabecera].[IdConsulta] point to this entity (FK_T_Actualizaciones_Cabecera_E2_CONSULTAS_ASISTENTE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesCabecera> TActualizacionesCabeceras { get; set; } // T_Actualizaciones_Cabecera.FK_T_Actualizaciones_Cabecera_E2_CONSULTAS_ASISTENTE

        public E2ConsultasAsistente()
        {
            Baja = false;
            FechaCreacion = System.DateTime.Now;
            E2ConsultasAsistenteCampos = new System.Collections.Generic.List<E2ConsultasAsistenteCampos>();
            E2ConsultasAsistenteFiltro = new System.Collections.Generic.List<E2ConsultasAsistenteFiltro>();
            TActualizacionesCabeceras = new System.Collections.Generic.List<TActualizacionesCabecera>();
        }
    }
}