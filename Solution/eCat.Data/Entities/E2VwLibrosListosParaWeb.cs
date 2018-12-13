namespace eCat.Data.Entities
{
    public class E2VwLibrosListosParaWeb
    {
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)
        public string Isbn { get; set; } // ISBN (length: 13)
        public string Titulo { get; set; } // Titulo (length: 255)
        public string EstadoSap { get; set; } // EstadoSAP (Primary key) (length: 30)
        public string IdClasificacion { get; set; } // ID_CLASIFICACION (Primary key) (length: 60)
    }
}