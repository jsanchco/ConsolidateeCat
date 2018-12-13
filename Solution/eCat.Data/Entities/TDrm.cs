namespace eCat.Data.Entities
{
    public class TDrm
    {
        public byte IdDrm { get; set; } // IdDRM (Primary key)
        public string Drm { get; set; } // DRM (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child DilveDrms (Many-to-Many) mapped by table [DILVE_DRM_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveDrm> DilveDrms { get; set; } // Many to many mapping
        /// <summary>
        /// Child FichasBases where [FichasBase].[IdDRM] point to this entity (FK_FichasBase_T_DRM)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_T_DRM

        public TDrm()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            DilveDrms = new System.Collections.Generic.List<DilveDrm>();
        }
    }
}