namespace eCat.Data.Entities
{
    public class TUsosComercialesIdioma
    {
        public byte IdUsoComercial { get; set; } // IdUsoComercial (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_UsosComerciales_Idioma].([IdIdiomaInterface]) (FK_T_UsosComerciales_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_UsosComerciales_Idioma_T_Idiomas_Plataforma

        /// <summary>
        /// Parent TUsosComerciale pointed by [T_UsosComerciales_Idioma].([IdUsoComercial]) (FK_T_UsosComerciales_Idioma_T_UsosComerciales)
        /// </summary>
        public virtual TUsosComerciale TUsosComerciale { get; set; } // FK_T_UsosComerciales_Idioma_T_UsosComerciales
    }
}