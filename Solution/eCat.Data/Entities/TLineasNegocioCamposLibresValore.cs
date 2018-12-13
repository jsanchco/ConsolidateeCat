namespace eCat.Data.Entities
{
    public class TLineasNegocioCamposLibresValore
    {
        public int IdValor { get; set; } // IdValor (Primary key)
        public int IdCampoLn { get; set; } // IdCampoLN
        public string Valor { get; set; } // Valor (length: 255)
        public string CodigoSap { get; set; } // CodigoSAP (length: 20)

        // Reverse navigation

        /// <summary>
        /// Child FichasBaseCamposLibres where [FichasBase_CamposLibres].[IdValor] point to this entity (FK_FichasBase_CamposLibres_T_LineasNegocio_CamposLibres_Valores)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseCamposLibre> FichasBaseCamposLibres { get; set; } // FichasBase_CamposLibres.FK_FichasBase_CamposLibres_T_LineasNegocio_CamposLibres_Valores

        // Foreign keys

        /// <summary>
        /// Parent TLineasNegocioCamposLibre pointed by [T_LineasNegocio_CamposLibres_Valores].([IdCampoLn]) (FK_T_LineasNegocio_CamposLibres_Valores_T_LineasNegocio_CamposLibres)
        /// </summary>
        public virtual TLineasNegocioCamposLibre TLineasNegocioCamposLibre { get; set; } // FK_T_LineasNegocio_CamposLibres_Valores_T_LineasNegocio_CamposLibres

        public TLineasNegocioCamposLibresValore()
        {
            FichasBaseCamposLibres = new System.Collections.Generic.List<FichasBaseCamposLibre>();
        }
    }
}