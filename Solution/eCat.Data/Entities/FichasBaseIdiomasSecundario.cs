namespace eCat.Data.Entities
{
    public class FichasBaseIdiomasSecundario
    {
        public string IdInterno { get; set; } // IdInterno (Primary key) (length: 12)
        public byte IdIdioma { get; set; } // IdIdioma (Primary key)
        public byte Orden { get; set; } // Orden

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [FichasBase_IdiomasSecundarios].([IdInterno]) (FK_FichasBase_IdiomasSecundarios_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_FichasBase_IdiomasSecundarios_FichasBase

        /// <summary>
        /// Parent Idioma pointed by [FichasBase_IdiomasSecundarios].([IdIdioma]) (FK_FichasBase_IdiomasSecundarios_Idiomas)
        /// </summary>
        public virtual Idioma Idioma { get; set; } // FK_FichasBase_IdiomasSecundarios_Idiomas
    }
}