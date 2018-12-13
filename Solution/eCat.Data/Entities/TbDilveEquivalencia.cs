namespace eCat.Data.Entities
{
    public class TbDilveEquivalencia
    {
        public string Codigo { get; set; } // Codigo (Primary key) (length: 3)
        public string Descripcion { get; set; } // Descripcion (length: 255)
        public string SqlOrigen { get; set; } // SQLOrigen
        public string SqlDilve { get; set; } // SQLDilve
        public string Tabla { get; set; } // Tabla (length: 255)
        public string CampoECat { get; set; } // CampoECat (length: 255)
        public string CampoDilve { get; set; } // CampoDilve (length: 255)
        public bool EsNumerico { get; set; } // EsNumerico
    }
}