namespace eCat.Data.Entities
{
    public class RolesIdioma
    {
        public string IdRol { get; set; } // IdRol (Primary key) (length: 3)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [Roles_Idioma].([IdIdiomaInterface]) (FK_Roles_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_Roles_Idioma_T_Idiomas_Plataforma
    }
}