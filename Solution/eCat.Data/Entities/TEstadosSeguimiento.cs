namespace eCat.Data.Entities
{
    public class TEstadosSeguimiento
    {
        public byte IdEstadoSeguimiento { get; set; } // IdEstadoSeguimiento (Primary key)
        public string EstadoSeguimiento { get; set; } // EstadoSeguimiento (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child FichasBases where [FichasBase].[IdEstadoSeguimiento] point to this entity (FK_FichasBase_T_EstadosSeguimiento)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_T_EstadosSeguimiento
        /// <summary>
        /// Child TFichasBaseHistoricoEstadoSeguimientoes where [T_FichasBase_Historico_EstadoSeguimiento].[IdEstadoSeguimiento] point to this entity (FK_T_FichasBase_Historico_EstadoSeguimiento_T_EstadosSeguimiento)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseHistoricoEstadoSeguimiento> TFichasBaseHistoricoEstadoSeguimientoes { get; set; } // T_FichasBase_Historico_EstadoSeguimiento.FK_T_FichasBase_Historico_EstadoSeguimiento_T_EstadosSeguimiento

        public TEstadosSeguimiento()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            TFichasBaseHistoricoEstadoSeguimientoes = new System.Collections.Generic.List<TFichasBaseHistoricoEstadoSeguimiento>();
        }
    }
}