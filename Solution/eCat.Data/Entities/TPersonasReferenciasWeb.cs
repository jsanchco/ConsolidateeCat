namespace eCat.Data.Entities
{
    public class TPersonasReferenciasWeb
    {
        public long IdReferenciaWeb { get; set; } // IdReferenciaWeb (Primary key)
        public long IdPersona { get; set; } // IdPersona
        public short IdTipoReferenciaWeb { get; set; } // IdTipoReferenciaWeb
        public string Url { get; set; } // URL (length: 255)
        public long Orden { get; set; } // Orden
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion
        public System.DateTime? FechaModificacion { get; set; } // FechaModificacion

        // Foreign keys

        /// <summary>
        /// Parent Persona pointed by [T_Personas_ReferenciasWeb].([IdPersona]) (FK_T_Personas_ReferenciasWeb_Personas)
        /// </summary>
        public virtual Persona Persona { get; set; } // FK_T_Personas_ReferenciasWeb_Personas

        /// <summary>
        /// Parent TReferenciasWebTipos pointed by [T_Personas_ReferenciasWeb].([IdTipoReferenciaWeb]) (FK_T_Personas_ReferenciasWeb_T_ReferenciasWeb_Tipos)
        /// </summary>
        public virtual TReferenciasWebTipos TReferenciasWebTipos { get; set; } // FK_T_Personas_ReferenciasWeb_T_ReferenciasWeb_Tipos

        public TPersonasReferenciasWeb()
        {
            FechaCreacion = System.DateTime.Now;
        }
    }
}