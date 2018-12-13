namespace eCat.Data.Entities
{
    public class E2ConsultasAsistenteCampos
    {
        public decimal IdConsulta { get; set; } // IdConsulta (Primary key)
        public string CodCampo { get; set; } // CodCampo (Primary key) (length: 25)
        public int Orden { get; set; } // Orden

        // Foreign keys

        /// <summary>
        /// Parent E2ConsultasAsistente pointed by [E2_CONSULTAS_ASISTENTE_CAMPOS].([IdConsulta]) (FK_E2_CONSULTAS_ASISTENTE_CAMPOS_E2_CONSULTAS_ASISTENTE)
        /// </summary>
        public virtual E2ConsultasAsistente E2ConsultasAsistente { get; set; } // FK_E2_CONSULTAS_ASISTENTE_CAMPOS_E2_CONSULTAS_ASISTENTE

        public E2ConsultasAsistenteCampos()
        {
            Orden = 0;
        }
    }
}