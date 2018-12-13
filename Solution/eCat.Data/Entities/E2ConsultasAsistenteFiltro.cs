namespace eCat.Data.Entities
{
    public class E2ConsultasAsistenteFiltro
    {
        public long IdConsultaAsistenteFiltro { get; set; } // IdConsultaAsistenteFiltro (Primary key)
        public decimal IdConsulta { get; set; } // IdConsulta
        public bool IsNot { get; set; } // IsNot
        public string CodCampo { get; set; } // CodCampo (length: 25)
        public byte CodOperacion { get; set; } // CodOperacion
        public string Valor { get; set; } // Valor (length: 1000)
        public byte? CodCriterio { get; set; } // CodCriterio
        public byte Orden { get; set; } // Orden
        public string ValorFiltro { get; set; } // ValorFiltro (length: 1000)

        // Foreign keys

        /// <summary>
        /// Parent E2ConsultasAsistente pointed by [E2_CONSULTAS_ASISTENTE_FILTROS].([IdConsulta]) (FK_E2_CONSULTAS_ASISTENTE_FILTROS_E2_CONSULTAS_ASISTENTE)
        /// </summary>
        public virtual E2ConsultasAsistente E2ConsultasAsistente { get; set; } // FK_E2_CONSULTAS_ASISTENTE_FILTROS_E2_CONSULTAS_ASISTENTE

        public E2ConsultasAsistenteFiltro()
        {
            IsNot = false;
            Orden = 0;
        }
    }
}