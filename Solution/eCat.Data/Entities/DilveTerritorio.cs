namespace eCat.Data.Entities
{
    public class DilveTerritorio
    {
        public short IdTerritorioDilve { get; set; } // IdTerritorioDILVE (Primary key)
        public string CodigoTerritorioDilve { get; set; } // CodigoTerritorioDILVE (length: 255)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child TAmbitosCesions (Many-to-Many) mapped by table [DILVE_AmbitosCesion_Territorios_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TAmbitosCesion> TAmbitosCesions { get; set; } // Many to many mapping

        public DilveTerritorio()
        {
            TAmbitosCesions = new System.Collections.Generic.List<TAmbitosCesion>();
        }
    }
}