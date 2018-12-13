namespace eCat.Data.Entities
{
    public class TTiposConsultasIdioma
    {
        public byte IdTipoConsulta { get; set; } // IdTipoConsulta (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_TiposConsultas_Idioma].([IdIdiomaInterface]) (FK_T_TiposConsultas_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_TiposConsultas_Idioma_T_Idiomas_Plataforma

        /// <summary>
        /// Parent TTiposConsulta pointed by [T_TiposConsultas_Idioma].([IdTipoConsulta]) (FK_T_TiposConsultas_Idioma_T_TiposConsultas)
        /// </summary>
        public virtual TTiposConsulta TTiposConsulta { get; set; } // FK_T_TiposConsultas_Idioma_T_TiposConsultas
    }
}