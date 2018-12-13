namespace eCat.Data.Entities
{
    public class TNegocio
    {
        public short IdNegocio { get; set; } // IdNegocio

        ///<summary>
        /// Clave del negocio
        ///</summary>
        public string Codigo { get; set; } // Codigo (Primary key) (length: 5)

        ///<summary>
        /// Nombre del negocio
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child E2RamasClasificacionesGestion where [E2_RAMAS_CLASIFICACIONES_GESTION].[CodNegocio] point to this entity (FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Negocio)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2RamasClasificacionesGestion> E2RamasClasificacionesGestion { get; set; } // E2_RAMAS_CLASIFICACIONES_GESTION.FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Negocio

        public TNegocio()
        {
            E2RamasClasificacionesGestion = new System.Collections.Generic.List<E2RamasClasificacionesGestion>();
        }
    }
}