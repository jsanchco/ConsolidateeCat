namespace eCat.Data.Entities
{
    public class DilveFormatoSoporteDigital
    {
        public byte IdFormatoSoporteDigital { get; set; } // IdFormatoSoporteDigital (Primary key)
        public string CodigoFormatoSoporteDigital { get; set; } // CodigoFormatoSoporteDigital (length: 3)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child TiposEncuadernacions (Many-to-Many) mapped by table [DILVE_FormatoSoporteDigital_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TiposEncuadernacion> TiposEncuadernacions { get; set; } // Many to many mapping

        public DilveFormatoSoporteDigital()
        {
            TiposEncuadernacions = new System.Collections.Generic.List<TiposEncuadernacion>();
        }
    }
}