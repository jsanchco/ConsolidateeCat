namespace eCat.Data.Entities
{
    public class DilveComunidadAutonoma
    {
        public byte IdComunidadAutonoma { get; set; } // IdComunidadAutonoma (Primary key)
        public string CodigoComunidadAutonoma { get; set; } // CodigoComunidadAutonoma (length: 2)
        public string Descripcion { get; set; } // Descripcion (length: 64)

        // Reverse navigation

        /// <summary>
        /// Child TZonasGeograficas (Many-to-Many) mapped by table [DILVE_ComunidadAutonoma_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TZonasGeografica> TZonasGeograficas { get; set; } // Many to many mapping

        public DilveComunidadAutonoma()
        {
            TZonasGeograficas = new System.Collections.Generic.List<TZonasGeografica>();
        }
    }
}