namespace eCat.Data.Entities
{
    public class DilveMaterialEducativoAnele
    {
        public byte IdTipoMaterialEducativoAnele { get; set; } // IdTipoMaterialEducativoANELE (Primary key)
        public string CodigoMaterialEducaticoAnele { get; set; } // CodigoMaterialEducaticoANELE (length: 2)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child TTiposMaterialEducativoes (Many-to-Many) mapped by table [DILVE_MaterialEducativoANELE_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposMaterialEducativo> TTiposMaterialEducativoes { get; set; } // Many to many mapping

        public DilveMaterialEducativoAnele()
        {
            TTiposMaterialEducativoes = new System.Collections.Generic.List<TTiposMaterialEducativo>();
        }
    }
}