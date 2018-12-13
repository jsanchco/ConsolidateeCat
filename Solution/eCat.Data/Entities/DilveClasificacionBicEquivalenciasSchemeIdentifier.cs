namespace eCat.Data.Entities
{
    public class DilveClasificacionBicEquivalenciasSchemeIdentifier
    {
        public int IdClasificacionBic { get; set; } // IdClasificacionBIC (Primary key)
        public string SchemeIdentifier { get; set; } // SchemeIdentifier (length: 10)

        // Foreign keys

        /// <summary>
        /// Parent ClasificacionEci pointed by [DILVE_ClasificacionBIC_Equivalencias_SchemeIdentifier].([IdClasificacionBic]) (FK_DILVE_ClasificacionBIC_Equivalencias_SchemeIdentifier_Clasificacion_ECI)
        /// </summary>
        public virtual ClasificacionEci ClasificacionEci { get; set; } // FK_DILVE_ClasificacionBIC_Equivalencias_SchemeIdentifier_Clasificacion_ECI
    }
}