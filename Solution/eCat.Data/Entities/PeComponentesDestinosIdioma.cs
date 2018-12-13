namespace eCat.Data.Entities
{
    public class PeComponentesDestinosIdioma
    {
        public byte IdDestino { get; set; } // IdDestino (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
        public string ValorCorto { get; set; } // ValorCorto (length: 50)

        // Foreign keys

        /// <summary>
        /// Parent PeComponentesDestino pointed by [PE_Componentes_Destinos_Idioma].([IdDestino]) (FK_PE_Componentes_Destinos_Idioma_PE_Componentes_Destinos)
        /// </summary>
        public virtual PeComponentesDestino PeComponentesDestino { get; set; } // FK_PE_Componentes_Destinos_Idioma_PE_Componentes_Destinos

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [PE_Componentes_Destinos_Idioma].([IdIdiomaInterface]) (FK_PE_Componentes_Destinos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_PE_Componentes_Destinos_Idioma_T_Idiomas_Plataforma
    }
}