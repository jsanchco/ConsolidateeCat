namespace eCat.Data.Entities
{
    public class EstadosSapIdioma
    {
        public string IdEstadoSap { get; set; } // IDEstadoSAP (Primary key) (length: 2)
        public short IdidiomaInterface { get; set; } // IdidiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent EstadosSap pointed by [EstadosSAP_Idioma].([IdEstadoSap]) (FK_EstadosSAP_Idioma_EstadosSAP)
        /// </summary>
        public virtual EstadosSap EstadosSap { get; set; } // FK_EstadosSAP_Idioma_EstadosSAP

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [EstadosSAP_Idioma].([IdidiomaInterface]) (FK_EstadosSAP_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_EstadosSAP_Idioma_T_Idiomas_Plataforma
    }
}