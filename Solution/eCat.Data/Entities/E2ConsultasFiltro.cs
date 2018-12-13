namespace eCat.Data.Entities
{
    public class E2ConsultasFiltro
    {
        public long IdConsultaFiltro { get; set; } // IdConsultaFiltro (Primary key)
        public string CodConsulta { get; set; } // COD_CONSULTA (length: 20)
        public string CodUsuario { get; set; } // COD_USUARIO (length: 50)
        public string CodCampo { get; set; } // COD_CAMPO (length: 25)
        public byte CodOperacion { get; set; } // COD_OPERACION
        public string Valor { get; set; } // VALOR (length: 1000)
        public byte? CodCriterio { get; set; } // COD_CRITERIO
        public byte Orden { get; set; } // ORDEN
        public string ValorFiltro { get; set; } // ValorFiltro (length: 1000)

        public E2ConsultasFiltro()
        {
            Orden = 0;
        }
    }
}