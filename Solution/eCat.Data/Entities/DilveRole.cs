namespace eCat.Data.Entities
{
    public class DilveRole
    {
        public byte IdRol { get; set; } // IdRol (Primary key)
        public string CodigoRol { get; set; } // CodigoRol (length: 3)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child Roles (Many-to-Many) mapped by table [DILVE_Roles_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Role> Roles { get; set; } // Many to many mapping

        public DilveRole()
        {
            Roles = new System.Collections.Generic.List<Role>();
        }
    }
}