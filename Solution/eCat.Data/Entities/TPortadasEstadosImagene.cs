namespace eCat.Data.Entities
{
    public class TPortadasEstadosImagene
    {
        public byte IdEstado { get; set; } // IdEstado (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)
        public byte Orden { get; set; } // Orden
    }
}