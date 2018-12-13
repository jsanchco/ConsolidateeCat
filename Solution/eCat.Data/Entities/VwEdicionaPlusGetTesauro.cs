namespace eCat.Data.Entities
{
    public class VwEdicionaPlusGetTesauro
    {
        public int IdArbol { get; set; } // IdArbol (Primary key)
        public string Nombre { get; set; } // Nombre (Primary key) (length: 255)
        public string Sinonimos { get; set; } // Sinonimos (length: 2147483647)
        public bool Nivelador { get; set; } // Nivelador (Primary key)
        public int Orden { get; set; } // Orden (Primary key)
        public int? IdPadre { get; set; } // IdPadre
    }
}