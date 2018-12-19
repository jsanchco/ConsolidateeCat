namespace eCat.Data.Entities
{
    public class TFichasBaseAmbitosCesionRestriccion
    {
        public int IdFichasBaseAmbitoCesion { get; set; } // IdFichasBaseAmbitoCesion (Primary key)
        public short IdAmbitoCesionRestriccion { get; set; } // IdAmbitoCesion (Primary key)

        public virtual TFichasBaseAmbitosCesion TFichasBaseAmbitosCesion { get; set; }
        public virtual TAmbitosCesion TAmbitosCesion { get; set; }
    }
}
