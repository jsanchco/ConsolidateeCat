namespace eCat.Data.Entities
{
    public class TLineasNegocioCamposLibre
    {
        public int IdCampoLn { get; set; } // IdCampoLN (Primary key)
        public short IdPais { get; set; } // IdPais
        public byte IdLineaNegocio { get; set; } // IdLineaNegocio
        public string NombreCampo { get; set; } // NombreCampo (length: 255)

        ///<summary>
        /// 1 -&gt; Texto libre, 2 -&gt; Lista valores
        ///</summary>
        public short TipoCampo { get; set; } // TipoCampo
        public short Orden { get; set; } // Orden

        // Reverse navigation

        /// <summary>
        /// Child FichasBaseCamposLibres where [FichasBase_CamposLibres].[IdCampoLN] point to this entity (FK_FichasBase_CamposLibres_T_LineasNegocio_CamposLibres)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseCamposLibre> FichasBaseCamposLibres { get; set; } // FichasBase_CamposLibres.FK_FichasBase_CamposLibres_T_LineasNegocio_CamposLibres
        /// <summary>
        /// Child TLineasNegocioCamposLibresValores where [T_LineasNegocio_CamposLibres_Valores].[IdCampoLN] point to this entity (FK_T_LineasNegocio_CamposLibres_Valores_T_LineasNegocio_CamposLibres)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TLineasNegocioCamposLibresValore> TLineasNegocioCamposLibresValores { get; set; } // T_LineasNegocio_CamposLibres_Valores.FK_T_LineasNegocio_CamposLibres_Valores_T_LineasNegocio_CamposLibres

        // Foreign keys

        /// <summary>
        /// Parent E2AclDominio pointed by [T_LineasNegocio_CamposLibres].([IdPais]) (FK_T_LineasNegocio_CamposLibres_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual E2AclDominio E2AclDominio { get; set; } // FK_T_LineasNegocio_CamposLibres_E2_ACL_DOMINIOS

        /// <summary>
        /// Parent LineaNegocio pointed by [T_LineasNegocio_CamposLibres].([IdLineaNegocio]) (FK_T_LineasNegocio_CamposLibres_LineaNegocio)
        /// </summary>
        public virtual LineaNegocio LineaNegocio { get; set; } // FK_T_LineasNegocio_CamposLibres_LineaNegocio

        public TLineasNegocioCamposLibre()
        {
            FichasBaseCamposLibres = new System.Collections.Generic.List<FichasBaseCamposLibre>();
            TLineasNegocioCamposLibresValores = new System.Collections.Generic.List<TLineasNegocioCamposLibresValore>();
        }
    }
}