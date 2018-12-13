namespace eCat.Data.Entities
{
    public class FichasBaseCamposLibre
    {
        public string IdInterno { get; set; } // IdInterno (Primary key) (length: 12)
        public int IdCampoLn { get; set; } // IdCampoLN (Primary key)
        public int? IdValor { get; set; } // IdValor
        public string Texto { get; set; } // Texto (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [FichasBase_CamposLibres].([IdInterno]) (FK_FichasBase_CamposLibres_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_FichasBase_CamposLibres_FichasBase

        /// <summary>
        /// Parent TLineasNegocioCamposLibre pointed by [FichasBase_CamposLibres].([IdCampoLn]) (FK_FichasBase_CamposLibres_T_LineasNegocio_CamposLibres)
        /// </summary>
        public virtual TLineasNegocioCamposLibre TLineasNegocioCamposLibre { get; set; } // FK_FichasBase_CamposLibres_T_LineasNegocio_CamposLibres

        /// <summary>
        /// Parent TLineasNegocioCamposLibresValore pointed by [FichasBase_CamposLibres].([IdValor]) (FK_FichasBase_CamposLibres_T_LineasNegocio_CamposLibres_Valores)
        /// </summary>
        public virtual TLineasNegocioCamposLibresValore TLineasNegocioCamposLibresValore { get; set; } // FK_FichasBase_CamposLibres_T_LineasNegocio_CamposLibres_Valores
    }
}