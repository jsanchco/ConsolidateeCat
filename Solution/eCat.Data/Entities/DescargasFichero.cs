namespace eCat.Data.Entities
{
    public class DescargasFichero
    {
        public long IdDescarga { get; set; } // IDDescarga (Primary key)
        public System.DateTime Fecha { get; set; } // Fecha
        public decimal IdDocumento { get; set; } // IDDocumento
        public string Nombre { get; set; } // Nombre (length: 1000)
        public string Usuario { get; set; } // Usuario (length: 50)

        public DescargasFichero()
        {
            Fecha = System.DateTime.Now;
        }
    }
}