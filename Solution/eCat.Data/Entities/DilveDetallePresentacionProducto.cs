namespace eCat.Data.Entities
{
    public class DilveDetallePresentacionProducto
    {
        public int IdDetallePresentacionProducto { get; set; } // IdDetallePresentacionProducto (Primary key)
        public string CodigoDetallePresentacionProducto { get; set; } // CodigoDetallePresentacionProducto (length: 4)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child DilveFormatoProductoDetallePresentacionEquivalencias where [DILVE_FormatoProducto_DetallePresentacion_Equivalencias].[IdDetallePresentacionProducto] point to this entity (FK_DILVE_FormatoProducto_Equivalencias_DILVE_DetallePresentacionProducto)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveFormatoProductoDetallePresentacionEquivalencia> DilveFormatoProductoDetallePresentacionEquivalencias { get; set; } // DILVE_FormatoProducto_DetallePresentacion_Equivalencias.FK_DILVE_FormatoProducto_Equivalencias_DILVE_DetallePresentacionProducto

        public DilveDetallePresentacionProducto()
        {
            DilveFormatoProductoDetallePresentacionEquivalencias = new System.Collections.Generic.List<DilveFormatoProductoDetallePresentacionEquivalencia>();
        }
    }
}