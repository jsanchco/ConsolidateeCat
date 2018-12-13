namespace eCat.Data.Entities
{
    public class TFichasBaseHistoricoFase
    {
        public string IdInterno { get; set; } // IdInterno (Primary key) (length: 12)
        public byte IdFase { get; set; } // IdFase (Primary key)
        public System.DateTime Fecha { get; set; } // Fecha
        public string IdUsuario { get; set; } // IdUsuario (length: 50)

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [T_FichasBase_Historico_Fase].([IdInterno]) (FK_T_FichasBase_Historico_Fase_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_T_FichasBase_Historico_Fase_FichasBase

        /// <summary>
        /// Parent TFasesMaterial pointed by [T_FichasBase_Historico_Fase].([IdFase]) (FK_T_FichasBase_Historico_Fase_T_FasesMaterial)
        /// </summary>
        public virtual TFasesMaterial TFasesMaterial { get; set; } // FK_T_FichasBase_Historico_Fase_T_FasesMaterial

        /// <summary>
        /// Parent Usuario pointed by [T_FichasBase_Historico_Fase].([IdUsuario]) (FK_T_FichasBase_Historico_Fase_Usuarios)
        /// </summary>
        public virtual Usuario Usuario { get; set; } // FK_T_FichasBase_Historico_Fase_Usuarios

        public TFichasBaseHistoricoFase()
        {
            Fecha = System.DateTime.Now;
        }
    }
}