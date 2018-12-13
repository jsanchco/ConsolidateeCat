namespace eCat.Data.Entities
{
    public class TReferenciasWebTipos
    {
        public short IdTipoReferenciaWeb { get; set; } // IdTipoReferenciaWeb (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)
        public bool Baja { get; set; } // Baja

        // Reverse navigation

        /// <summary>
        /// Child TPersonasReferenciasWebs where [T_Personas_ReferenciasWeb].[IdTipoReferenciaWeb] point to this entity (FK_T_Personas_ReferenciasWeb_T_ReferenciasWeb_Tipos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TPersonasReferenciasWeb> TPersonasReferenciasWebs { get; set; } // T_Personas_ReferenciasWeb.FK_T_Personas_ReferenciasWeb_T_ReferenciasWeb_Tipos

        public TReferenciasWebTipos()
        {
            Baja = false;
            TPersonasReferenciasWebs = new System.Collections.Generic.List<TPersonasReferenciasWeb>();
        }
    }
}