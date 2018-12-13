namespace eCat.Data.Entities
{
    public class Evento
    {

        ///<summary>
        /// Clave del evento
        ///</summary>
        public string IdEvento { get; set; } // IDEvento (Primary key) (length: 5)

        ///<summary>
        /// Nombre del evento
        ///</summary>
        public string Evento_ { get; set; } // Evento (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child Fechas where [Fechas].[IDEvento] point to this entity (FK_Fechas_Eventos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Fecha> Fechas { get; set; } // Fechas.FK_Fechas_Eventos

        public Evento()
        {
            Fechas = new System.Collections.Generic.List<Fecha>();
        }
    }
}