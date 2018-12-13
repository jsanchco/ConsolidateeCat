namespace eCat.Data.Entities
{
    public class TbCamposFichaElemento
    {
        public decimal IdCampo { get; set; } // ID_CAMPO (Primary key)
        public int NumElemento { get; set; } // NumElemento (Primary key)
        public string Tag { get; set; } // Tag (length: 100)
        public string CampoSelect { get; set; } // CampoSelect (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TbCamposFicha pointed by [TB_CAMPOS_FICHA_ELEMENTOS].([IdCampo]) (FK_TB_CAMPOS_FICHA_ELEMENTOS_TB_CAMPOS_FICHA)
        /// </summary>
        public virtual TbCamposFicha TbCamposFicha { get; set; } // FK_TB_CAMPOS_FICHA_ELEMENTOS_TB_CAMPOS_FICHA

        public TbCamposFichaElemento()
        {
            CampoSelect = "";
        }
    }
}