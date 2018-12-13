namespace eCat.Data.Entities
{
    public class TSoporte
    {
        public byte IdSoporte { get; set; } // IdSoporte (Primary key)
        public string Soporte { get; set; } // Soporte (length: 30)

        // Reverse navigation

        /// <summary>
        /// Child DilveFormatoProductoes (Many-to-Many) mapped by table [DILVE_Soportes_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveFormatoProducto> DilveFormatoProductoes { get; set; } // Many to many mapping
        /// <summary>
        /// Child DilveFormatoProductoDetallePresentacionEquivalencias where [DILVE_FormatoProducto_DetallePresentacion_Equivalencias].[IdSoporte] point to this entity (FK_DILVE_FormatoProducto_Equivalencias_T_Soportes)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveFormatoProductoDetallePresentacionEquivalencia> DilveFormatoProductoDetallePresentacionEquivalencias { get; set; } // DILVE_FormatoProducto_DetallePresentacion_Equivalencias.FK_DILVE_FormatoProducto_Equivalencias_T_Soportes
        /// <summary>
        /// Child FichasBaseSoportes where [FichasBase_Soporte].[IdSoporte] point to this entity (FK_FichasBase_Soporte_T_Soportes)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseSoporte> FichasBaseSoportes { get; set; } // FichasBase_Soporte.FK_FichasBase_Soporte_T_Soportes

        public TSoporte()
        {
            DilveFormatoProductoDetallePresentacionEquivalencias = new System.Collections.Generic.List<DilveFormatoProductoDetallePresentacionEquivalencia>();
            FichasBaseSoportes = new System.Collections.Generic.List<FichasBaseSoporte>();
            DilveFormatoProductoes = new System.Collections.Generic.List<DilveFormatoProducto>();
        }
    }
}