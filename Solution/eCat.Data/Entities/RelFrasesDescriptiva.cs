namespace eCat.Data.Entities
{
    public class RelFrasesDescriptiva
    {
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)
        public int IdPublicoObjetivo { get; set; } // IDPublicoObjetivo (Primary key)
        public int IdFraseDescriptiva { get; set; } // IDFraseDescriptiva (Primary key)
        public string FraseDescriptiva { get; set; } // FraseDescriptiva (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [RelFrasesDescriptivas].([IdInterno]) (FK_RelFrasesDescriptivas_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_RelFrasesDescriptivas_FichasBase

        /// <summary>
        /// Parent PublicoObjetivo pointed by [RelFrasesDescriptivas].([IdPublicoObjetivo]) (FK_RelFrasesDescriptivas_PublicoObjetivo)
        /// </summary>
        public virtual PublicoObjetivo PublicoObjetivo { get; set; } // FK_RelFrasesDescriptivas_PublicoObjetivo
    }
}