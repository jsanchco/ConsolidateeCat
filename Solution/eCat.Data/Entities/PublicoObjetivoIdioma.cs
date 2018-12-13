namespace eCat.Data.Entities
{
    public class PublicoObjetivoIdioma
    {
        public int IdPublicoObjetivo { get; set; } // IDPublicoObjetivo (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [PublicoObjetivo_Idioma].([IdIdiomaInterface]) (FK_PublicoObjetivo_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_PublicoObjetivo_Idioma_T_Idiomas_Plataforma
    }
}