namespace eCat.Data.Entities
{
    public class DilveNivelEducativoAnele
    {
        public byte IdNivelEducaticoAnele { get; set; } // IdNivelEducaticoANELE (Primary key)
        public string CodigoNivelEducativoAnele { get; set; } // CodigoNivelEducativoANELE (length: 2)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child TEtapasRangoEdads (Many-to-Many) mapped by table [DILVE_NivelEducativoANELE_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TEtapasRangoEdad> TEtapasRangoEdads { get; set; } // Many to many mapping

        public DilveNivelEducativoAnele()
        {
            TEtapasRangoEdads = new System.Collections.Generic.List<TEtapasRangoEdad>();
        }
    }
}