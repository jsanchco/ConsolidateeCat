namespace eCat.Data.Entities
{
    public class DilveFormatoProductoDetallePresentacionEquivalencia
    {
        public int IdDilveFormatoProducto { get; set; } // IdDilveFormatoProducto (Primary key)
        public byte IdSoporte { get; set; } // IdSoporte
        public byte? IdTipoEncuadernacion { get; set; } // IdTipoEncuadernacion
        public int IdFormatoProducto { get; set; } // IdFormatoProducto
        public int? IdDetallePresentacionProducto { get; set; } // IdDetallePresentacionProducto

        // Foreign keys

        /// <summary>
        /// Parent DilveDetallePresentacionProducto pointed by [DILVE_FormatoProducto_DetallePresentacion_Equivalencias].([IdDetallePresentacionProducto]) (FK_DILVE_FormatoProducto_Equivalencias_DILVE_DetallePresentacionProducto)
        /// </summary>
        public virtual DilveDetallePresentacionProducto DilveDetallePresentacionProducto { get; set; } // FK_DILVE_FormatoProducto_Equivalencias_DILVE_DetallePresentacionProducto

        /// <summary>
        /// Parent DilveFormatoProducto pointed by [DILVE_FormatoProducto_DetallePresentacion_Equivalencias].([IdFormatoProducto]) (FK_DILVE_FormatoProducto_Equivalencias_DILVE_FormatoProducto)
        /// </summary>
        public virtual DilveFormatoProducto DilveFormatoProducto { get; set; } // FK_DILVE_FormatoProducto_Equivalencias_DILVE_FormatoProducto

        /// <summary>
        /// Parent TiposEncuadernacion pointed by [DILVE_FormatoProducto_DetallePresentacion_Equivalencias].([IdTipoEncuadernacion]) (FK_DILVE_FormatoProducto_Equivalencias_TiposEncuadernacion)
        /// </summary>
        public virtual TiposEncuadernacion TiposEncuadernacion { get; set; } // FK_DILVE_FormatoProducto_Equivalencias_TiposEncuadernacion

        /// <summary>
        /// Parent TSoporte pointed by [DILVE_FormatoProducto_DetallePresentacion_Equivalencias].([IdSoporte]) (FK_DILVE_FormatoProducto_Equivalencias_T_Soportes)
        /// </summary>
        public virtual TSoporte TSoporte { get; set; } // FK_DILVE_FormatoProducto_Equivalencias_T_Soportes
    }
}