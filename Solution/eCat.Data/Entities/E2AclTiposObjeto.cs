namespace eCat.Data.Entities
{
    public class E2AclTiposObjeto
    {

        ///<summary>
        /// Clave del tipo de objeto
        ///</summary>
        public int IdTipo { get; set; } // ID_TIPO (Primary key)

        ///<summary>
        /// Nombre del objeto
        ///</summary>
        public string Objeto { get; set; } // Objeto (length: 50)

        ///<summary>
        /// Descripción del objeto
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child E2AclObjeto (Many-to-Many) mapped by table [E2_ACL_REL_TIPOSOBJETOS]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2AclObjeto> E2AclObjeto { get; set; } // Many to many mapping
        /// <summary>
        /// Child E2AclRelGruposobjeto where [E2_ACL_REL_GRUPOSOBJETOS].[ID_TIPO] point to this entity (FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_TIPOS_OBJETOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2AclRelGruposobjeto> E2AclRelGruposobjeto { get; set; } // E2_ACL_REL_GRUPOSOBJETOS.FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_TIPOS_OBJETOS

        public E2AclTiposObjeto()
        {
            E2AclRelGruposobjeto = new System.Collections.Generic.List<E2AclRelGruposobjeto>();
            E2AclObjeto = new System.Collections.Generic.List<E2AclObjeto>();
        }
    }
}