namespace eCat.Data.Entities
{
    public class EdadesIdioma
    {
        public int IdEdad { get; set; } // IdEdad (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [Edades_Idioma].([IdIdiomaInterface]) (FK_Edades_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_Edades_Idioma_T_Idiomas_Plataforma
    }
}