namespace eCat.Data.Entities
{
    public class TPlanEditorialNivele
    {
        public long IdNivel { get; set; } // IdNivel (Primary key)
        public int IdCampaña { get; set; } // IdCampaña
        public string Nombre { get; set; } // Nombre (length: 255)
        public int Orden { get; set; } // Orden
    }
}