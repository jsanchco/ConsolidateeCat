namespace eCat.Data.Entities
{
    public class TAmbitosCesionEstado
    {
        public byte IdEstado { get; set; } // IdEstado (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child TFichasBaseAmbitosCesions where [T_FichasBase_AmbitosCesion].[IdEstado] point to this entity (FK_T_FichasBase_AmbitosCesion_T_AmbitosCesion_Estados)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseAmbitosCesion> TFichasBaseAmbitosCesions { get; set; } // T_FichasBase_AmbitosCesion.FK_T_FichasBase_AmbitosCesion_T_AmbitosCesion_Estados

        public TAmbitosCesionEstado()
        {
            TFichasBaseAmbitosCesions = new System.Collections.Generic.List<TFichasBaseAmbitosCesion>();
        }
    }
}