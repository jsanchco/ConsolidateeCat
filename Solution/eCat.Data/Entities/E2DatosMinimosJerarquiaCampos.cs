namespace eCat.Data.Entities
{
    public class E2DatosMinimosJerarquiaCampos
    {
        public string IdClasificacion { get; set; } // ID_CLASIFICACION (Primary key) (length: 255)
        public string CodigoCampo { get; set; } // Codigo_Campo (Primary key) (length: 15)

        // Foreign keys

        /// <summary>
        /// Parent E2DatosMinimosCampos pointed by [E2_DATOS_MINIMOS_JERARQUIA_CAMPOS].([CodigoCampo]) (FK_E2_DATOS_MINIMOS_JERARQUIA_CAMPOS_E2_DATOS_MINIMOS_CAMPOS)
        /// </summary>
        public virtual E2DatosMinimosCampos E2DatosMinimosCampos { get; set; } // FK_E2_DATOS_MINIMOS_JERARQUIA_CAMPOS_E2_DATOS_MINIMOS_CAMPOS
    }
}