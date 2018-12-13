namespace eCat.Data.Entities
{
    public class TFasesMaterialIdioma
    {
        public byte IdFase { get; set; } // IdFase (Primary key)
        public short IdidiomaInterface { get; set; } // IdidiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_FasesMaterial_Idioma].([IdidiomaInterface]) (FK_T_FasesMaterial_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_FasesMaterial_Idioma_T_Idiomas_Plataforma
    }
}