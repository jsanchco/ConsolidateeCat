namespace eCat.Data.Entities
{
    public class TiposEncuadernacion
    {

        ///<summary>
        /// Clave del tipo de encuadernación
        ///</summary>
        public byte IdTipoEncuadernacion { get; set; } // IDTipoEncuadernacion (Primary key)

        ///<summary>
        /// Nombre del tipo de encuadernación
        ///</summary>
        public string Encuadernacion { get; set; } // Encuadernacion (length: 15)

        // Reverse navigation

        /// <summary>
        /// Child DilveFormatoProductoDetallePresentacionEquivalencias where [DILVE_FormatoProducto_DetallePresentacion_Equivalencias].[IdTipoEncuadernacion] point to this entity (FK_DILVE_FormatoProducto_Equivalencias_TiposEncuadernacion)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveFormatoProductoDetallePresentacionEquivalencia> DilveFormatoProductoDetallePresentacionEquivalencias { get; set; } // DILVE_FormatoProducto_DetallePresentacion_Equivalencias.FK_DILVE_FormatoProducto_Equivalencias_TiposEncuadernacion
        /// <summary>
        /// Child DilveFormatoSoporteDigitals (Many-to-Many) mapped by table [DILVE_FormatoSoporteDigital_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveFormatoSoporteDigital> DilveFormatoSoporteDigitals { get; set; } // Many to many mapping
        /// <summary>
        /// Child FichasBases where [FichasBase].[TipoEncuadernacion] point to this entity (FK_FichasBase_TiposEncuadernacion)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_TiposEncuadernacion

        public TiposEncuadernacion()
        {
            DilveFormatoProductoDetallePresentacionEquivalencias = new System.Collections.Generic.List<DilveFormatoProductoDetallePresentacionEquivalencia>();
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            DilveFormatoSoporteDigitals = new System.Collections.Generic.List<DilveFormatoSoporteDigital>();
        }
    }
}