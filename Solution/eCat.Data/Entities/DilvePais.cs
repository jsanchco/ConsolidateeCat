namespace eCat.Data.Entities
{
    public class DilvePais
    {
        public short IdPaisDilve { get; set; } // IdPaisDILVE (Primary key)
        public string CodigoPaisDilve { get; set; } // CodigoPaisDILVE (length: 255)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child TAmbitosCesions (Many-to-Many) mapped by table [DILVE_AmbitosCesion_Paises_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TAmbitosCesion> TAmbitosCesions { get; set; } // Many to many mapping

        public DilvePais()
        {
            TAmbitosCesions = new System.Collections.Generic.List<TAmbitosCesion>();
        }
    }
}