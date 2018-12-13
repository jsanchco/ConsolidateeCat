namespace eCat.Data.Entities
{
    public class E2LineasproductoIdioma
    {
        public string CodLineaP { get; set; } // COD_lineaP (Primary key) (length: 3)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [E2_LINEASPRODUCTO_Idioma].([IdIdiomaInterface]) (FK_E2_LINEASPRODUCTO_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_E2_LINEASPRODUCTO_Idioma_T_Idiomas_Plataforma
    }
}