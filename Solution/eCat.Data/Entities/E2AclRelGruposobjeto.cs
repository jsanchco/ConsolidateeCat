namespace eCat.Data.Entities
{
    public class E2AclRelGruposobjeto
    {

        ///<summary>
        /// Clave del grupo relacionado
        ///</summary>
        public int IdGrupo { get; set; } // ID_GRUPO (Primary key)

        ///<summary>
        /// Clave del objeto al que se le da acceso
        ///</summary>
        public int IdObjeto { get; set; } // ID_OBJETO (Primary key)

        ///<summary>
        /// Clave del tipo de objeto al que se da acceso
        ///</summary>
        public int IdTipo { get; set; } // ID_TIPO (Primary key)

        ///<summary>
        /// Descripción de la asignación del objeto al grupo
        ///</summary>
        public string Info { get; set; } // INFO (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent E2AclGrupos pointed by [E2_ACL_REL_GRUPOSOBJETOS].([IdGrupo]) (FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_GRUPOS)
        /// </summary>
        public virtual E2AclGrupos E2AclGrupos { get; set; } // FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_GRUPOS

        /// <summary>
        /// Parent E2AclObjeto pointed by [E2_ACL_REL_GRUPOSOBJETOS].([IdObjeto]) (FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_OBJETOS)
        /// </summary>
        public virtual E2AclObjeto E2AclObjeto { get; set; } // FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_OBJETOS

        /// <summary>
        /// Parent E2AclTiposObjeto pointed by [E2_ACL_REL_GRUPOSOBJETOS].([IdTipo]) (FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_TIPOS_OBJETOS)
        /// </summary>
        public virtual E2AclTiposObjeto E2AclTiposObjeto { get; set; } // FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_TIPOS_OBJETOS
    }
}