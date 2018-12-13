namespace eCat.Data.Entities
{
    public class TTiposConsulta
    {
        public byte IdTipoConsulta { get; set; } // IdTipoConsulta (Primary key)
        public string TipoConsulta { get; set; } // TipoConsulta (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child TTiposConsultasIdiomas where [T_TiposConsultas_Idioma].[IdTipoConsulta] point to this entity (FK_T_TiposConsultas_Idioma_T_TiposConsultas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposConsultasIdioma> TTiposConsultasIdiomas { get; set; } // T_TiposConsultas_Idioma.FK_T_TiposConsultas_Idioma_T_TiposConsultas

        public TTiposConsulta()
        {
            TTiposConsultasIdiomas = new System.Collections.Generic.List<TTiposConsultasIdioma>();
        }
    }
}