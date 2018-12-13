namespace eCat.Data.Entities
{
    public class E2AclGrupos
    {

        ///<summary>
        /// Clave del grupo de usuario
        ///</summary>
        public int IdGrupo { get; set; } // ID_GRUPO (Primary key)

        ///<summary>
        /// Nombre del grupo de usuarios
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 50)

        ///<summary>
        /// Descripción del grupo de usuarios
        ///</summary>
        public string Descripción { get; set; } // Descripción (length: 100)

        ///<summary>
        /// Fecha de creación del grupo
        ///</summary>
        public System.DateTime FCreacion { get; set; } // FCreacion

        ///<summary>
        /// Fecha de modificación del grupo
        ///</summary>
        public System.DateTime FModificacion { get; set; } // FModificacion

        // Reverse navigation

        /// <summary>
        /// Child E2AclRelGruposobjeto where [E2_ACL_REL_GRUPOSOBJETOS].[ID_GRUPO] point to this entity (FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_GRUPOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2AclRelGruposobjeto> E2AclRelGruposobjeto { get; set; } // E2_ACL_REL_GRUPOSOBJETOS.FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_GRUPOS
        /// <summary>
        /// Child Usuarios (Many-to-Many) mapped by table [E2_ACL_REL_USUARIOSGRUPOS]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Usuario> Usuarios { get; set; } // Many to many mapping

        public E2AclGrupos()
        {
            FCreacion = System.DateTime.Now;
            FModificacion = System.DateTime.Now;
            E2AclRelGruposobjeto = new System.Collections.Generic.List<E2AclRelGruposobjeto>();
            Usuarios = new System.Collections.Generic.List<Usuario>();
        }
    }
}