namespace eCat.Data.Entities
{
    public class VwFichasBaseAmbitoCesion
    {
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)
        public System.DateTime Fecha { get; set; } // Fecha (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 1000)
        public string Observaciones { get; set; } // Observaciones (length: 1000)
        public string AmbitoCesion { get; set; } // AmbitoCesion
        public string Estado { get; set; } // Estado (Primary key) (length: 100)
    }
}