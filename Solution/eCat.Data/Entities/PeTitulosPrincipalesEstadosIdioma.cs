namespace eCat.Data.Entities
{
    public class PeTitulosPrincipalesEstadosIdioma
    {
        public byte IdEstado { get; set; } // IdEstado (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent PeTitulosPrincipalesEstado pointed by [PE_TitulosPrincipales_Estados_Idioma].([IdEstado]) (FK_PE_TitulosPrincipales_Estados_Idioma_PE_TitulosPrincipales_Estados)
        /// </summary>
        public virtual PeTitulosPrincipalesEstado PeTitulosPrincipalesEstado { get; set; } // FK_PE_TitulosPrincipales_Estados_Idioma_PE_TitulosPrincipales_Estados

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [PE_TitulosPrincipales_Estados_Idioma].([IdIdiomaInterface]) (FK_PE_TitulosPrincipales_Estados_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_PE_TitulosPrincipales_Estados_Idioma_T_Idiomas_Plataforma
    }
}