namespace eCat.Data.Entities
{
    public class TAuditoria
    {
        public long IdAuditoria { get; set; } // IdAuditoria (Primary key)
        public string IdInterno { get; set; } // IdInterno (length: 12)
        public string Usuario { get; set; } // Usuario (length: 50)
        public System.DateTime Fecha { get; set; } // Fecha
        public string Modificacion { get; set; } // Modificacion
    }
}