namespace eCat.Data.Entities
{
    public class TAccessToken
    {
        public long Id { get; set; } // Id (Primary key)
        public System.Guid TokenId { get; set; } // TokenId
        public string Usuario { get; set; } // Usuario (length: 50)
        public string Origen { get; set; } // Origen (length: 1000)
        public int Validez { get; set; } // Validez
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion
        public string Parametros { get; set; } // Parametros

        public TAccessToken()
        {
            TokenId = System.Guid.NewGuid();
        }
    }
}