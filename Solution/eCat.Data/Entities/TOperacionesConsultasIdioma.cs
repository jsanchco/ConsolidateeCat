namespace eCat.Data.Entities
{
    public class TOperacionesConsultasIdioma
    {
        public byte IdOperacion { get; set; } // IdOperacion (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_OperacionesConsultas_Idioma].([IdIdiomaInterface]) (FK_T_OperacionesConsultas_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_OperacionesConsultas_Idioma_T_Idiomas_Plataforma

        /// <summary>
        /// Parent TOperacionesConsulta pointed by [T_OperacionesConsultas_Idioma].([IdOperacion]) (FK_T_OperacionesConsultas_Idioma_T_OperacionesConsultas)
        /// </summary>
        public virtual TOperacionesConsulta TOperacionesConsulta { get; set; } // FK_T_OperacionesConsultas_Idioma_T_OperacionesConsultas
    }
}