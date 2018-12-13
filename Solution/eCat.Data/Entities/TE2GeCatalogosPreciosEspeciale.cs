namespace eCat.Data.Entities
{
    public class TE2GeCatalogosPreciosEspeciale
    {
        public int IdCatalogo { get; set; } // IdCatalogo (Primary key via unique index IX_T_E2_GE_CATALOGOS_PreciosEspeciales_Campo)
        public string Campo { get; set; } // Campo (Primary key via unique index IX_T_E2_GE_CATALOGOS_PreciosEspeciales_Campo) (length: 128)
        public string Valor { get; set; } // Valor (length: 128)
        public decimal? Precio { get; set; } // Precio
        public int Orden { get; set; } // Orden

        // Foreign keys

        /// <summary>
        /// Parent TE2GeCatalogosPreciosEspecialesCampos pointed by [T_E2_GE_CATALOGOS_PreciosEspeciales].([Campo]) (FK_T_E2_GE_CATALOGOS_PreciosEspeciales_T_E2_GE_CATALOGOS_PreciosEspeciales_Campos)
        /// </summary>
        public virtual TE2GeCatalogosPreciosEspecialesCampos TE2GeCatalogosPreciosEspecialesCampos { get; set; } // FK_T_E2_GE_CATALOGOS_PreciosEspeciales_T_E2_GE_CATALOGOS_PreciosEspeciales_Campos
    }
}