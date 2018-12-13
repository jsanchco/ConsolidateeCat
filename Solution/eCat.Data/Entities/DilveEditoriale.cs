namespace eCat.Data.Entities
{
    public class DilveEditoriale
    {
        public byte IdEditorialDilve { get; set; } // IdEditorialDILVE (Primary key)
        public string CodigoEditorialDilve { get; set; } // CodigoEditorialDILVE (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child TPropietarios (Many-to-Many) mapped by table [DILVE_Editoriales_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TPropietario> TPropietarios { get; set; } // Many to many mapping

        public DilveEditoriale()
        {
            TPropietarios = new System.Collections.Generic.List<TPropietario>();
        }
    }
}