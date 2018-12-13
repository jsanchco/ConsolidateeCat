namespace eCat.Data.Entities
{
    public class E2EquivalenciaClasificacione
    {
        public int IdCatalogoGest { get; set; } // ID_CATALOGO_GEST (Primary key)
        public string IdClasifGest { get; set; } // ID_CLASIF_GEST (Primary key) (length: 60)
        public int IdCatalogoPres { get; set; } // ID_CATALOGO_PRES (Primary key)
        public string IdClasifPres { get; set; } // ID_CLASIF_PRES (Primary key) (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child E2EquivalenciaClasificacionesCondicione where [E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES].([ID_CATALOGO_GEST], [ID_CATALOGO_PRES], [ID_CLASIF_GEST], [ID_CLASIF_PRES]) point to this entity (FK_E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES_E2_EQUIVALENCIA_CLASIFICACIONES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2EquivalenciaClasificacionesCondicione> E2EquivalenciaClasificacionesCondicione { get; set; } // E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES.FK_E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES_E2_EQUIVALENCIA_CLASIFICACIONES

        // Foreign keys

        /// <summary>
        /// Parent E2ClasificacionesGestion pointed by [E2_EQUIVALENCIA_CLASIFICACIONES].([IdCatalogoGest]) (FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_CLASIFICACIONES_GESTION)
        /// </summary>
        public virtual E2ClasificacionesGestion E2ClasificacionesGestion { get; set; } // FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_CLASIFICACIONES_GESTION

        /// <summary>
        /// Parent E2GeCatalogo pointed by [E2_EQUIVALENCIA_CLASIFICACIONES].([IdCatalogoPres]) (FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_GE_CATALOGOS)
        /// </summary>
        public virtual E2GeCatalogo E2GeCatalogo { get; set; } // FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_GE_CATALOGOS

        /// <summary>
        /// Parent E2RamasClasificacionesGestion pointed by [E2_EQUIVALENCIA_CLASIFICACIONES].([IdCatalogoGest], [IdClasifGest]) (FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_RAMAS_CLASIFICACIONES_GESTION)
        /// </summary>
        public virtual E2RamasClasificacionesGestion E2RamasClasificacionesGestion { get; set; } // FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_RAMAS_CLASIFICACIONES_GESTION

        public E2EquivalenciaClasificacione()
        {
            E2EquivalenciaClasificacionesCondicione = new System.Collections.Generic.List<E2EquivalenciaClasificacionesCondicione>();
        }
    }
}