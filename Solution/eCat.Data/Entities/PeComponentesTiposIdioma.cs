namespace eCat.Data.Entities
{
    public class PeComponentesTiposIdioma
    {
        public byte IdTipo { get; set; } // IdTipo (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
        public string ValorCorto { get; set; } // ValorCorto (length: 25)

        // Foreign keys

        /// <summary>
        /// Parent PeComponentesTipos pointed by [PE_Componentes_Tipos_Idioma].([IdTipo]) (FK_PE_Componentes_Tipos_Idioma_PE_Componentes_Tipos)
        /// </summary>
        public virtual PeComponentesTipos PeComponentesTipos { get; set; } // FK_PE_Componentes_Tipos_Idioma_PE_Componentes_Tipos

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [PE_Componentes_Tipos_Idioma].([IdIdiomaInterface]) (FK_PE_Componentes_Tipos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_PE_Componentes_Tipos_Idioma_T_Idiomas_Plataforma
    }
}