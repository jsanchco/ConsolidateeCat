namespace eCat.Data.Entities
{
    public class BookmasterBisac
    {
        public int IdBisac { get; set; } // IdBisac (Primary key)
        public string Codigo { get; set; } // Codigo (length: 12)
        public string Descripcion { get; set; } // Descripcion (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child ClasificacionEcis (Many-to-Many) mapped by table [BOOKMASTER_Bisac_Bic_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ClasificacionEci> ClasificacionEcis { get; set; } // Many to many mapping

        public BookmasterBisac()
        {
            ClasificacionEcis = new System.Collections.Generic.List<ClasificacionEci>();
        }
    }
}