namespace eCat.Data.Entities
{
    public class DilveIdioma
    {
        public short IdIdioma { get; set; } // IdIdioma (Primary key)
        public string CodigoIdiomaDilve { get; set; } // CodigoIdiomaDilve (length: 5)
        public string CodigoIdiomaAnele { get; set; } // CodigoIdiomaAnele (length: 50)
        public string Descripcion { get; set; } // Descripcion (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child Idiomas (Many-to-Many) mapped by table [DILVE_Idiomas_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Idioma> Idiomas { get; set; } // Many to many mapping

        public DilveIdioma()
        {
            Idiomas = new System.Collections.Generic.List<Idioma>();
        }
    }
}