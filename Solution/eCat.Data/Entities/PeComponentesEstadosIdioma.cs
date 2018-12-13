namespace eCat.Data.Entities
{
    public class PeComponentesEstadosIdioma
    {
        public byte IdEstado { get; set; } // IdEstado (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent PeComponentesEstado pointed by [PE_Componentes_Estados_Idioma].([IdEstado]) (FK_PE_Componentes_Estados_Idioma_PE_Componentes_Estados)
        /// </summary>
        public virtual PeComponentesEstado PeComponentesEstado { get; set; } // FK_PE_Componentes_Estados_Idioma_PE_Componentes_Estados

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [PE_Componentes_Estados_Idioma].([IdIdiomaInterface]) (FK_PE_Componentes_Estados_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_PE_Componentes_Estados_Idioma_T_Idiomas_Plataforma
    }
}