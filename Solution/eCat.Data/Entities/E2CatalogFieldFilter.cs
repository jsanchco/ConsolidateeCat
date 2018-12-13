namespace eCat.Data.Entities
{
    public class E2CatalogFieldFilter
    {
        public string Codigo { get; set; } // Codigo (Primary key) (length: 6)
        public string Descripcion { get; set; } // Descripcion (length: 50)
        public string Tag { get; set; } // Tag (length: 50)
        public short Orden { get; set; } // Orden
        public string Calculo { get; set; } // Calculo (length: 100)

        public E2CatalogFieldFilter()
        {
            Orden = 0;
        }
    }
}