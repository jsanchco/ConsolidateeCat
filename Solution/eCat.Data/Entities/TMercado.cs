namespace eCat.Data.Entities
{
    public class TMercado
    {
        public int IdMercado { get; set; } // IdMercado

        ///<summary>
        /// Clave del mercado
        ///</summary>
        public string Codigo { get; set; } // Codigo (Primary key) (length: 5)

        ///<summary>
        /// Nombre del mercado
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child E2RamasClasificacionesGestion where [E2_RAMAS_CLASIFICACIONES_GESTION].[CodMercado] point to this entity (FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Mercado)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2RamasClasificacionesGestion> E2RamasClasificacionesGestion { get; set; } // E2_RAMAS_CLASIFICACIONES_GESTION.FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Mercado

        public TMercado()
        {
            E2RamasClasificacionesGestion = new System.Collections.Generic.List<E2RamasClasificacionesGestion>();
        }
    }
}