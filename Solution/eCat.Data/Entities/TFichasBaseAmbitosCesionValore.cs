namespace eCat.Data.Entities
{
    public class TFichasBaseAmbitosCesionValore
    {
        public int IdFichasBaseAmbitoCesion { get; set; } // IdFichasBaseAmbitoCesion (Primary key)
        public short IdAmbitoCesion { get; set; } // IdAmbitoCesion (Primary key)
        public bool Exclusivo { get; set; } // Exclusivo

        // Foreign keys

        /// <summary>
        /// Parent TAmbitosCesion pointed by [T_FichasBase_AmbitosCesion_Valores].([IdAmbitoCesion]) (FK_T_FichasBase_AmbitosCesion_Valores_T_AmbitosCesion)
        /// </summary>
        public virtual TAmbitosCesion TAmbitosCesion { get; set; } // FK_T_FichasBase_AmbitosCesion_Valores_T_AmbitosCesion

        /// <summary>
        /// Parent TFichasBaseAmbitosCesion pointed by [T_FichasBase_AmbitosCesion_Valores].([IdFichasBaseAmbitoCesion]) (FK_T_FichasBase_AmbitosCesion_Valores_T_FichasBase_AmbitosCesion)
        /// </summary>
        public virtual TFichasBaseAmbitosCesion TFichasBaseAmbitosCesion { get; set; } // FK_T_FichasBase_AmbitosCesion_Valores_T_FichasBase_AmbitosCesion

        public TFichasBaseAmbitosCesionValore()
        {
            Exclusivo = false;
        }
    }
}