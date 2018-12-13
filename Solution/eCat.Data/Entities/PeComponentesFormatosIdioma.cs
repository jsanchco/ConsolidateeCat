namespace eCat.Data.Entities
{
    public class PeComponentesFormatosIdioma
    {
        public byte IdFormato { get; set; } // IdFormato (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent PeComponentesFormato pointed by [PE_Componentes_Formatos_Idioma].([IdFormato]) (FK_PE_Componentes_Formatos_Idioma_PE_Componentes_Formatos)
        /// </summary>
        public virtual PeComponentesFormato PeComponentesFormato { get; set; } // FK_PE_Componentes_Formatos_Idioma_PE_Componentes_Formatos

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [PE_Componentes_Formatos_Idioma].([IdIdiomaInterface]) (FK_PE_Componentes_Formatos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_PE_Componentes_Formatos_Idioma_T_Idiomas_Plataforma
    }
}