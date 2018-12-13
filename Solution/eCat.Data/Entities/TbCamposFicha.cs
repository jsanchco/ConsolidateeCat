namespace eCat.Data.Entities
{
    public class TbCamposFicha
    {
        public decimal IdCampo { get; set; } // ID_CAMPO (Primary key)
        public string NombreCampo { get; set; } // NombreCampo (length: 100)
        public int NivelTag { get; set; } // NivelTag
        public string CampoLucene { get; set; } // CampoLucene (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child E2GeCatalogo (Many-to-Many) mapped by table [E2_GE_CATALOGOS_REL_CAMPOS_FICHA]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2GeCatalogo> E2GeCatalogo { get; set; } // Many to many mapping
        /// <summary>
        /// Child TbCamposFichaElementoes where [TB_CAMPOS_FICHA_ELEMENTOS].[ID_CAMPO] point to this entity (FK_TB_CAMPOS_FICHA_ELEMENTOS_TB_CAMPOS_FICHA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbCamposFichaElemento> TbCamposFichaElementoes { get; set; } // TB_CAMPOS_FICHA_ELEMENTOS.FK_TB_CAMPOS_FICHA_ELEMENTOS_TB_CAMPOS_FICHA

        // Foreign keys

        /// <summary>
        /// Parent TbCamposNivele pointed by [TB_CAMPOS_FICHA].([NivelTag]) (FK_TB_CAMPOS_FICHA_TB_CAMPOS_NIVELES)
        /// </summary>
        public virtual TbCamposNivele TbCamposNivele { get; set; } // FK_TB_CAMPOS_FICHA_TB_CAMPOS_NIVELES

        public TbCamposFicha()
        {
            NivelTag = 1;
            TbCamposFichaElementoes = new System.Collections.Generic.List<TbCamposFichaElemento>();
            E2GeCatalogo = new System.Collections.Generic.List<E2GeCatalogo>();
        }
    }
}