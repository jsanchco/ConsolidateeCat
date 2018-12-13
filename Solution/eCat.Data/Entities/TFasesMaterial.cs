namespace eCat.Data.Entities
{
    public class TFasesMaterial
    {
        public byte IdFase { get; set; } // IdFase (Primary key)
        public string Fase { get; set; } // Fase (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child FichasBases where [FichasBase].[IdFase] point to this entity (FK_FichasBase_T_FasesMaterial)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_T_FasesMaterial
        /// <summary>
        /// Child TFichasBaseHistoricoFases where [T_FichasBase_Historico_Fase].[IdFase] point to this entity (FK_T_FichasBase_Historico_Fase_T_FasesMaterial)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseHistoricoFase> TFichasBaseHistoricoFases { get; set; } // T_FichasBase_Historico_Fase.FK_T_FichasBase_Historico_Fase_T_FasesMaterial

        public TFasesMaterial()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            TFichasBaseHistoricoFases = new System.Collections.Generic.List<TFichasBaseHistoricoFase>();
        }
    }
}