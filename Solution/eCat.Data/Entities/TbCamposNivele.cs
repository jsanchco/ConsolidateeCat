namespace eCat.Data.Entities
{
    public class TbCamposNivele
    {
        public int NivelTag { get; set; } // NivelTag (Primary key)
        public string FromTabla { get; set; } // FromTabla (length: 1000)
        public string NombreTag { get; set; } // NombreTag (length: 100)
        public string WhereIdInterno { get; set; } // WhereIDInterno (length: 100)
        public string WhereIdCatalogo { get; set; } // WhereIDCatalogo (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child TbCamposFichas where [TB_CAMPOS_FICHA].[NivelTag] point to this entity (FK_TB_CAMPOS_FICHA_TB_CAMPOS_NIVELES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbCamposFicha> TbCamposFichas { get; set; } // TB_CAMPOS_FICHA.FK_TB_CAMPOS_FICHA_TB_CAMPOS_NIVELES

        public TbCamposNivele()
        {
            TbCamposFichas = new System.Collections.Generic.List<TbCamposFicha>();
        }
    }
}