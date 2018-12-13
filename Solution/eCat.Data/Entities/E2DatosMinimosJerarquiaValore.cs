namespace eCat.Data.Entities
{
    public class E2DatosMinimosJerarquiaValore
    {
        public decimal IdJerarquiaValor { get; set; } // Id_Jerarquia_Valor (Primary key)
        public string IdClasificacion { get; set; } // ID_CLASIFICACION (length: 255)
        public string CodigoValor { get; set; } // Codigo_Valor (length: 15)
        public string Valor { get; set; } // Valor (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child E2DatosMinimosCampos (Many-to-Many) mapped by table [E2_DATOS_MINIMOS_CAMPOS_VALORES]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2DatosMinimosCampos> E2DatosMinimosCampos { get; set; } // Many to many mapping

        // Foreign keys

        /// <summary>
        /// Parent E2DatosMinimosValore pointed by [E2_DATOS_MINIMOS_JERARQUIA_VALORES].([CodigoValor]) (FK_E2_DATOS_MINIMOS_JERARQUIA_VALORES_E2_DATOS_MINIMOS_VALORES)
        /// </summary>
        public virtual E2DatosMinimosValore E2DatosMinimosValore { get; set; } // FK_E2_DATOS_MINIMOS_JERARQUIA_VALORES_E2_DATOS_MINIMOS_VALORES

        public E2DatosMinimosJerarquiaValore()
        {
            E2DatosMinimosCampos = new System.Collections.Generic.List<E2DatosMinimosCampos>();
        }
    }
}