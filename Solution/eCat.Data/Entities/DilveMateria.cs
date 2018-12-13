namespace eCat.Data.Entities
{
    public class DilveMateria
    {
        public short IdMateriaDilve { get; set; } // IdMateriaDILVE (Primary key)
        public string CodigoMateriaDilve { get; set; } // CodigoMateriaDILVE (length: 7)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child TSubcategoriasMaterias (Many-to-Many) mapped by table [DILVE_Materias_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TSubcategoriasMateria> TSubcategoriasMaterias { get; set; } // Many to many mapping

        public DilveMateria()
        {
            TSubcategoriasMaterias = new System.Collections.Generic.List<TSubcategoriasMateria>();
        }
    }
}