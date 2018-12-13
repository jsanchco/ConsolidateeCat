namespace eCat.Data.Entities
{
    public class SinliSubmateria
    {
        public string CodTsec { get; set; } // COD_TSEC (Primary key) (length: 10)
        public string CodTprinc { get; set; } // COD_TPRINC (length: 10)
        public string Descripcion { get; set; } // Descripcion (length: 255)
    }
}