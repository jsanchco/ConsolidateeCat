namespace eCat.Data.Entities
{
    public class E2DatosMinimosValore
    {
        public string CodigoValor { get; set; } // Codigo_Valor (Primary key) (length: 15)
        public string DescripcionValor { get; set; } // Descripcion_Valor (length: 255)
        public string SqlValor { get; set; } // Sql_Valor (length: 4000)

        // Reverse navigation

        /// <summary>
        /// Child E2DatosMinimosJerarquiaValore where [E2_DATOS_MINIMOS_JERARQUIA_VALORES].[Codigo_Valor] point to this entity (FK_E2_DATOS_MINIMOS_JERARQUIA_VALORES_E2_DATOS_MINIMOS_VALORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2DatosMinimosJerarquiaValore> E2DatosMinimosJerarquiaValore { get; set; } // E2_DATOS_MINIMOS_JERARQUIA_VALORES.FK_E2_DATOS_MINIMOS_JERARQUIA_VALORES_E2_DATOS_MINIMOS_VALORES

        public E2DatosMinimosValore()
        {
            E2DatosMinimosJerarquiaValore = new System.Collections.Generic.List<E2DatosMinimosJerarquiaValore>();
        }
    }
}