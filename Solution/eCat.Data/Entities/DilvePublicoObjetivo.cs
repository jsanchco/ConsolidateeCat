namespace eCat.Data.Entities
{
    public class DilvePublicoObjetivo
    {
        public byte IdPublicoObjetivo { get; set; } // IdPublicoObjetivo (Primary key)
        public string CodigoPublicoObjetivo { get; set; } // CodigoPublicoObjetivo (length: 2)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child E2Lineasproducto (Many-to-Many) mapped by table [DILVE_PublicoObjetivo_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2Lineasproducto> E2Lineasproducto { get; set; } // Many to many mapping

        public DilvePublicoObjetivo()
        {
            E2Lineasproducto = new System.Collections.Generic.List<E2Lineasproducto>();
        }
    }
}