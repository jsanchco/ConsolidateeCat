namespace eCat.Data.Entities
{
    public class DilveFormatoProducto
    {
        public int IdFormatoProducto { get; set; } // IdFormatoProducto (Primary key)
        public string CodigoFormatoProducto { get; set; } // CodigoFormatoProducto (length: 2)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child DilveFormatoProductoDetallePresentacionEquivalencias where [DILVE_FormatoProducto_DetallePresentacion_Equivalencias].[IdFormatoProducto] point to this entity (FK_DILVE_FormatoProducto_Equivalencias_DILVE_FormatoProducto)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveFormatoProductoDetallePresentacionEquivalencia> DilveFormatoProductoDetallePresentacionEquivalencias { get; set; } // DILVE_FormatoProducto_DetallePresentacion_Equivalencias.FK_DILVE_FormatoProducto_Equivalencias_DILVE_FormatoProducto
        /// <summary>
        /// Child TSoportes (Many-to-Many) mapped by table [DILVE_Soportes_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TSoporte> TSoportes { get; set; } // Many to many mapping

        public DilveFormatoProducto()
        {
            DilveFormatoProductoDetallePresentacionEquivalencias = new System.Collections.Generic.List<DilveFormatoProductoDetallePresentacionEquivalencia>();
            TSoportes = new System.Collections.Generic.List<TSoporte>();
        }
    }
}