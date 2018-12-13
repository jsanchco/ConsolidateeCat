namespace eCat.Data.Entities
{
    public class E2GruposArticulosIdioma
    {
        public string CodigoGrupo { get; set; } // CodigoGrupo (Primary key) (length: 9)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent E2GruposArticulo pointed by [E2_GRUPOS_ARTICULOS_Idioma].([CodigoGrupo]) (FK_E2_GRUPOS_ARTICULOS_Idioma_E2_GRUPOS_ARTICULOS)
        /// </summary>
        public virtual E2GruposArticulo E2GruposArticulo { get; set; } // FK_E2_GRUPOS_ARTICULOS_Idioma_E2_GRUPOS_ARTICULOS

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [E2_GRUPOS_ARTICULOS_Idioma].([IdIdiomaInterface]) (FK_E2_GRUPOS_ARTICULOS_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_E2_GRUPOS_ARTICULOS_Idioma_T_Idiomas_Plataforma
    }
}