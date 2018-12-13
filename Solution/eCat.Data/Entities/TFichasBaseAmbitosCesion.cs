namespace eCat.Data.Entities
{
    public class TFichasBaseAmbitosCesion
    {
        public int IdFichasBaseAmbitoCesion { get; set; } // IdFichasBaseAmbitoCesion (Primary key)
        public string IdInterno { get; set; } // IdInterno (length: 12)
        public System.DateTime Fecha { get; set; } // Fecha
        public string ComentariosInternos { get; set; } // ComentariosInternos (length: 1000)
        public byte IdEstado { get; set; } // IdEstado
        public string MasInformacion { get; set; } // MasInformacion (length: 1000)
        public bool EsRestrictivo { get; set; } // EsRestrictivo
        public bool DisponibleVentaDerechos { get; set; } // DisponibleVentaDerechos

        // Reverse navigation

        /// <summary>
        /// Child TAmbitosCesions (Many-to-Many) mapped by table [T_FichasBase_AmbitosCesion_Restricciones]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TAmbitosCesion> TAmbitosCesions { get; set; } // Many to many mapping
        /// <summary>
        /// Child TFichasBaseAmbitosCesionValores where [T_FichasBase_AmbitosCesion_Valores].[IdFichasBaseAmbitoCesion] point to this entity (FK_T_FichasBase_AmbitosCesion_Valores_T_FichasBase_AmbitosCesion)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseAmbitosCesionValore> TFichasBaseAmbitosCesionValores { get; set; } // T_FichasBase_AmbitosCesion_Valores.FK_T_FichasBase_AmbitosCesion_Valores_T_FichasBase_AmbitosCesion

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [T_FichasBase_AmbitosCesion].([IdInterno]) (FK_T_FichasBase_AmbitosCesion_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_T_FichasBase_AmbitosCesion_FichasBase

        /// <summary>
        /// Parent TAmbitosCesionEstado pointed by [T_FichasBase_AmbitosCesion].([IdEstado]) (FK_T_FichasBase_AmbitosCesion_T_AmbitosCesion_Estados)
        /// </summary>
        public virtual TAmbitosCesionEstado TAmbitosCesionEstado { get; set; } // FK_T_FichasBase_AmbitosCesion_T_AmbitosCesion_Estados

        public TFichasBaseAmbitosCesion()
        {
            EsRestrictivo = false;
            DisponibleVentaDerechos = false;
            TFichasBaseAmbitosCesionValores = new System.Collections.Generic.List<TFichasBaseAmbitosCesionValore>();
            TAmbitosCesions = new System.Collections.Generic.List<TAmbitosCesion>();
        }
    }
}