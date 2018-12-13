namespace eCat.Data.Entities
{
    public class Role
    {

        ///<summary>
        /// Clave del rol o función
        ///</summary>
        public string IdRol { get; set; } // IDRol (Primary key) (length: 3)

        ///<summary>
        /// Nombre del rol en castellano
        ///</summary>
        public string Es { get; set; } // ES (length: 50)

        ///<summary>
        /// Nombre del rol en catalán
        ///</summary>
        public string Cat { get; set; } // CAT (length: 50)

        ///<summary>
        /// Nombre del rol en inglés
        ///</summary>
        public string En { get; set; } // EN (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child DilveRoles (Many-to-Many) mapped by table [DILVE_Roles_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveRole> DilveRoles { get; set; } // Many to many mapping
        /// <summary>
        /// Child RelFichasPersonas where [RelFichasPersonas].[IDRol] point to this entity (FK_RelFichasPersonas_Roles)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<RelFichasPersona> RelFichasPersonas { get; set; } // RelFichasPersonas.FK_RelFichasPersonas_Roles

        public Role()
        {
            RelFichasPersonas = new System.Collections.Generic.List<RelFichasPersona>();
            DilveRoles = new System.Collections.Generic.List<DilveRole>();
        }
    }
}