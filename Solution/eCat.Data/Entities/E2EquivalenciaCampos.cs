namespace eCat.Data.Entities
{
    public class E2EquivalenciaCampos
    {
        public string CodigoCampo { get; set; } // CodigoCampo (Primary key) (length: 15)
        public string DescripcionCampo { get; set; } // DescripcionCampo (length: 255)
        public string SqlValor { get; set; } // SqlValor (length: 4000)
    }
}