namespace eCat.Data.Entities
{
    public class FichasBaseArchivoHistorico
    {
        public int IdArchivoHistorico { get; set; } // IdArchivoHistorico (Primary key)
        public string IdInterno { get; set; } // IdInterno (length: 12)
        public short? Año { get; set; } // Año
        public string Texto { get; set; } // Texto (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [FichasBase_ArchivoHistorico].([IdInterno]) (FK_FichasBase_ArchivoHistorico_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_FichasBase_ArchivoHistorico_FichasBase
    }
}