namespace eCat.Data.Entities
{
    public class E2RamasclasifFicha
    {

        ///<summary>
        /// Calve del catálogo de gestión
        ///</summary>
        public int IdCatalogo { get; set; } // ID_CATALOGO (Primary key)

        ///<summary>
        /// Clave de la rama del catálogo de gestión
        ///</summary>
        public string IdClasificacion { get; set; } // ID_CLASIFICACION (Primary key) (length: 60)

        ///<summary>
        /// Clave del material que se quiere asociar a la rama del catálogo
        ///</summary>
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)

        // Foreign keys

        /// <summary>
        /// Parent E2RamasClasificacionesGestion pointed by [E2_RAMASCLASIF_FICHAS].([IdCatalogo], [IdClasificacion]) (FK_E2_RAMASCLASIF_FICHAS_E2_RAMAS_CLASIFICACIONES_GESTION)
        /// </summary>
        public virtual E2RamasClasificacionesGestion E2RamasClasificacionesGestion { get; set; } // FK_E2_RAMASCLASIF_FICHAS_E2_RAMAS_CLASIFICACIONES_GESTION

        /// <summary>
        /// Parent FichasBase pointed by [E2_RAMASCLASIF_FICHAS].([IdInterno]) (FK_E2_RAMASCLASIF_FICHAS_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_E2_RAMASCLASIF_FICHAS_FichasBase
    }
}