namespace eCat.Data.Entities
{
    public class E2AclObjeto
    {

        ///<summary>
        /// Clave del objeto o acción de la aplicación
        ///</summary>
        public int IdObjeto { get; set; } // ID_OBJETO (Primary key)

        ///<summary>
        /// Código del objeto o acción  (único)
        ///</summary>
        public string Codigo { get; set; } // Codigo (length: 10)

        ///<summary>
        /// Nombre del objeto
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 50)

        ///<summary>
        /// Título emergente del objeto
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 100)

        ///<summary>
        /// Antecesor del objeto. En el caso en el que las opciones se presenten en forma de árbol.
        ///</summary>
        public int? IdPadre { get; set; } // IdPadre

        ///<summary>
        /// Icono asociado al objeto o acción en el interface de la aplicación.
        ///</summary>
        public string Icono { get; set; } // Icono (length: 255)

        ///<summary>
        /// Url relativa a la aplicación Web que se ha de llamar al activar el objeto o acción.
        ///</summary>
        public string PantallaUrl { get; set; } // PantallaUrl (length: 1000)

        ///<summary>
        /// Indica si el objeto está habilitado para mostrarse en pantalla o no
        ///</summary>
        public bool Activo { get; set; } // Activo
        public int? Orden { get; set; } // Orden
        public bool EnEscritorio { get; set; } // EnEscritorio

        // Reverse navigation

        /// <summary>
        /// Child E2AclObjetosIdioma where [E2_ACL_OBJETOS_Idioma].[ID_OBJETO] point to this entity (FK_E2_ACL_OBJETOS_Idioma_E2_ACL_OBJETOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2AclObjetosIdioma> E2AclObjetosIdioma { get; set; } // E2_ACL_OBJETOS_Idioma.FK_E2_ACL_OBJETOS_Idioma_E2_ACL_OBJETOS
        /// <summary>
        /// Child E2AclRelGruposobjeto where [E2_ACL_REL_GRUPOSOBJETOS].[ID_OBJETO] point to this entity (FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_OBJETOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2AclRelGruposobjeto> E2AclRelGruposobjeto { get; set; } // E2_ACL_REL_GRUPOSOBJETOS.FK_E2_ACL_REL_GRUPOSOBJETOS_E2_ACL_OBJETOS
        /// <summary>
        /// Child E2AclTiposObjeto (Many-to-Many) mapped by table [E2_ACL_REL_TIPOSOBJETOS]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2AclTiposObjeto> E2AclTiposObjeto { get; set; } // Many to many mapping

        public E2AclObjeto()
        {
            Activo = false;
            EnEscritorio = true;
            E2AclObjetosIdioma = new System.Collections.Generic.List<E2AclObjetosIdioma>();
            E2AclRelGruposobjeto = new System.Collections.Generic.List<E2AclRelGruposobjeto>();
            E2AclTiposObjeto = new System.Collections.Generic.List<E2AclTiposObjeto>();
        }
    }
}