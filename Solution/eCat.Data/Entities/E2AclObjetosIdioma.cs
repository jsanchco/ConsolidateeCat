namespace eCat.Data.Entities
{
    public class E2AclObjetosIdioma
    {

        ///<summary>
        /// Clave del objeto de menú traducido
        ///</summary>
        public int IdObjeto { get; set; } // ID_OBJETO (Primary key)

        ///<summary>
        /// Nombre del objeto de menú en el idioma de traducción
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 50)

        ///<summary>
        /// Título emergente del objeto de menú en el idioma de traducción
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 100)

        ///<summary>
        /// Calve del idioma de traducción
        ///</summary>
        public short IdIdiomaPlataforma { get; set; } // IdIdiomaPlataforma (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent E2AclObjeto pointed by [E2_ACL_OBJETOS_Idioma].([IdObjeto]) (FK_E2_ACL_OBJETOS_Idioma_E2_ACL_OBJETOS)
        /// </summary>
        public virtual E2AclObjeto E2AclObjeto { get; set; } // FK_E2_ACL_OBJETOS_Idioma_E2_ACL_OBJETOS

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [E2_ACL_OBJETOS_Idioma].([IdIdiomaPlataforma]) (FK_E2_ACL_OBJETOS_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_E2_ACL_OBJETOS_Idioma_T_Idiomas_Plataforma
    }
}