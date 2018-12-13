namespace eCat.Data.Entities
{
    public class Fecha
    {

        ///<summary>
        /// Clave del material relacionado
        ///</summary>
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)

        ///<summary>
        /// Clave del evento que producido
        ///</summary>
        public string IdEvento { get; set; } // IDEvento (Primary key) (length: 5)

        ///<summary>
        /// Fecha en que se ha producido el evento
        ///</summary>
        public System.DateTime Fecha_ { get; set; } // Fecha

        ///<summary>
        /// Anotaciones sobre el evento
        ///</summary>
        public string Comentarios { get; set; } // Comentarios

        // Foreign keys

        /// <summary>
        /// Parent Evento pointed by [Fechas].([IdEvento]) (FK_Fechas_Eventos)
        /// </summary>
        public virtual Evento Evento { get; set; } // FK_Fechas_Eventos

        /// <summary>
        /// Parent FichasBase pointed by [Fechas].([IdInterno]) (FK_Fechas_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_Fechas_FichasBase
    }
}