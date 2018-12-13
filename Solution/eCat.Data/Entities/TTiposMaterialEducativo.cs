namespace eCat.Data.Entities
{
    public class TTiposMaterialEducativo
    {
        public byte IdTipoMaterialEducativo { get; set; } // IdTipoMaterialEducativo (Primary key)
        public string TipoMaterialEducativo { get; set; } // TipoMaterialEducativo (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child DilveMaterialEducativoAneles (Many-to-Many) mapped by table [DILVE_MaterialEducativoANELE_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveMaterialEducativoAnele> DilveMaterialEducativoAneles { get; set; } // Many to many mapping
        /// <summary>
        /// Child FichasBases where [FichasBase].[IdTipoMaterialEducativo] point to this entity (FK_FichasBase_T_TiposMaterialEducativo)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_T_TiposMaterialEducativo

        public TTiposMaterialEducativo()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            DilveMaterialEducativoAneles = new System.Collections.Generic.List<DilveMaterialEducativoAnele>();
        }
    }
}