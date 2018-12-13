namespace eCat.Data.Entities
{
    public class TDigitalAccesibilidadIdioma
    {
        public byte IdAccesibilidad { get; set; } // IdAccesibilidad (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TDigitalAccesibilidad pointed by [T_Digital_Accesibilidad_Idioma].([IdAccesibilidad]) (FK_T_Digital_Accesibilidad_Idioma_T_Digital_Accesibilidad)
        /// </summary>
        public virtual TDigitalAccesibilidad TDigitalAccesibilidad { get; set; } // FK_T_Digital_Accesibilidad_Idioma_T_Digital_Accesibilidad

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_Digital_Accesibilidad_Idioma].([IdIdiomaInterface]) (FK_T_Digital_Accesibilidad_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_Digital_Accesibilidad_Idioma_T_Idiomas_Plataforma
    }
}