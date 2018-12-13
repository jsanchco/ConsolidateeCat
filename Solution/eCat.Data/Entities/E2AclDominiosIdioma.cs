namespace eCat.Data.Entities
{
    public class E2AclDominiosIdioma
    {
        public short IdDominio { get; set; } // IdDominio (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent E2AclDominio pointed by [E2_ACL_DOMINIOS_Idioma].([IdDominio]) (FK_E2_ACL_DOMINIOS_Idioma_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual E2AclDominio E2AclDominio { get; set; } // FK_E2_ACL_DOMINIOS_Idioma_E2_ACL_DOMINIOS

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [E2_ACL_DOMINIOS_Idioma].([IdIdiomaInterface]) (FK_E2_ACL_DOMINIOS_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_E2_ACL_DOMINIOS_Idioma_T_Idiomas_Plataforma
    }
}