namespace eCat.Data.Entities
{
    public class PeAreasGlobalesIdioma
    {
        public short IdAreaGlobal { get; set; } // IdAreaGlobal (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent PeAreasGlobale pointed by [PE_AreasGlobales_Idioma].([IdAreaGlobal]) (FK_PE_AreasGlobales_Idioma_PE_AreasGlobales)
        /// </summary>
        public virtual PeAreasGlobale PeAreasGlobale { get; set; } // FK_PE_AreasGlobales_Idioma_PE_AreasGlobales

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [PE_AreasGlobales_Idioma].([IdIdiomaInterface]) (FK_PE_AreasGlobales_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_PE_AreasGlobales_Idioma_T_Idiomas_Plataforma
    }
}