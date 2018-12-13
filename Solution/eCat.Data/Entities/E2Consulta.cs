namespace eCat.Data.Entities
{
    public class E2Consulta
    {
        public byte CodTipoConsulta { get; set; } // COD_TIPO_CONSULTA
        public string CodConsulta { get; set; } // COD_CONSULTA (Primary key) (length: 20)
        public string DesConsulta { get; set; } // DES_CONSULTA (length: 1000)
        public string Usuario { get; set; } // USUARIO (Primary key) (length: 50)

        public E2Consulta()
        {
            CodTipoConsulta = 0;
        }
    }
}