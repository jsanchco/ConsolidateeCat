namespace eCat.Data.Entities
{
    public class TE2GeCatalogosPreciosEspecialesCampos
    {
        public string Campo { get; set; } // Campo (Primary key) (length: 128)
        public string Descripcion { get; set; } // Descripcion (length: 512)

        // Reverse navigation

        /// <summary>
        /// Child TE2GeCatalogosPreciosEspeciale where [T_E2_GE_CATALOGOS_PreciosEspeciales].[Campo] point to this entity (FK_T_E2_GE_CATALOGOS_PreciosEspeciales_T_E2_GE_CATALOGOS_PreciosEspeciales_Campos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TE2GeCatalogosPreciosEspeciale> TE2GeCatalogosPreciosEspeciale { get; set; } // T_E2_GE_CATALOGOS_PreciosEspeciales.FK_T_E2_GE_CATALOGOS_PreciosEspeciales_T_E2_GE_CATALOGOS_PreciosEspeciales_Campos

        public TE2GeCatalogosPreciosEspecialesCampos()
        {
            TE2GeCatalogosPreciosEspeciale = new System.Collections.Generic.List<TE2GeCatalogosPreciosEspeciale>();
        }
    }
}