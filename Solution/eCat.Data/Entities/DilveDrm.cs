namespace eCat.Data.Entities
{
    public class DilveDrm
    {
        public byte IdDrmdilve { get; set; } // IdDRMDILVE (Primary key)
        public string CodigoDrm { get; set; } // CodigoDRM (length: 2)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child TDrms (Many-to-Many) mapped by table [DILVE_DRM_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TDrm> TDrms { get; set; } // Many to many mapping

        public DilveDrm()
        {
            TDrms = new System.Collections.Generic.List<TDrm>();
        }
    }
}