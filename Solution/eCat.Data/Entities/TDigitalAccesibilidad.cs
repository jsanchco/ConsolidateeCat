namespace eCat.Data.Entities
{
    public class TDigitalAccesibilidad
    {
        public byte IdAccesibilidad { get; set; } // IdAccesibilidad (Primary key)
        public string Accesibilidad { get; set; } // Accesibilidad (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child FichasBases where [FichasBase].[IdAccesibilidad] point to this entity (FK_FichasBase_T_Digital_Accesibilidad)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_T_Digital_Accesibilidad
        /// <summary>
        /// Child TDigitalAccesibilidadIdiomas where [T_Digital_Accesibilidad_Idioma].[IdAccesibilidad] point to this entity (FK_T_Digital_Accesibilidad_Idioma_T_Digital_Accesibilidad)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TDigitalAccesibilidadIdioma> TDigitalAccesibilidadIdiomas { get; set; } // T_Digital_Accesibilidad_Idioma.FK_T_Digital_Accesibilidad_Idioma_T_Digital_Accesibilidad

        public TDigitalAccesibilidad()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            TDigitalAccesibilidadIdiomas = new System.Collections.Generic.List<TDigitalAccesibilidadIdioma>();
        }
    }
}