namespace eCat.Data.Entities
{
    public class TFichasBaseHistoricoEstadoSeguimiento
    {
        public long IdHistorico { get; set; } // IdHistorico (Primary key)
        public string IdInterno { get; set; } // IdInterno (length: 12)
        public byte IdEstadoSeguimiento { get; set; } // IdEstadoSeguimiento
        public string IdUsuario { get; set; } // IdUsuario (length: 50)
        public System.DateTime Fecha { get; set; } // Fecha
        public string Comentario { get; set; } // Comentario

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [T_FichasBase_Historico_EstadoSeguimiento].([IdInterno]) (FK_T_FichasBase_Historico_EstadoSeguimiento_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_T_FichasBase_Historico_EstadoSeguimiento_FichasBase

        /// <summary>
        /// Parent TEstadosSeguimiento pointed by [T_FichasBase_Historico_EstadoSeguimiento].([IdEstadoSeguimiento]) (FK_T_FichasBase_Historico_EstadoSeguimiento_T_EstadosSeguimiento)
        /// </summary>
        public virtual TEstadosSeguimiento TEstadosSeguimiento { get; set; } // FK_T_FichasBase_Historico_EstadoSeguimiento_T_EstadosSeguimiento

        /// <summary>
        /// Parent Usuario pointed by [T_FichasBase_Historico_EstadoSeguimiento].([IdUsuario]) (FK_T_FichasBase_Historico_EstadoSeguimiento_Usuarios)
        /// </summary>
        public virtual Usuario Usuario { get; set; } // FK_T_FichasBase_Historico_EstadoSeguimiento_Usuarios
    }
}