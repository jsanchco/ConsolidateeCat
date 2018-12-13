namespace eCat.Data.Entities
{
    public class TPlanEditorialSubNivele
    {
        public long IdSubNivel { get; set; } // IdSubNivel (Primary key)
        public long IdNivel { get; set; } // IdNivel
        public string Nombre { get; set; } // Nombre (length: 255)
        public int Orden { get; set; } // Orden
    }
}