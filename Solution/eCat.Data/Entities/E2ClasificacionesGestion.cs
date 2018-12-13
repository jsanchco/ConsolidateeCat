namespace eCat.Data.Entities
{
    public class E2ClasificacionesGestion
    {
        public int IdCatalogo { get; set; } // ID_CATALOGO (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)
        public string PlantillaNiveles { get; set; } // PlantillaNiveles (length: 50)
        public bool Editable { get; set; } // Editable

        // Reverse navigation

        /// <summary>
        /// Child E2AclDominiosJerarquia where [E2_ACL_DOMINIOS_JERARQUIAS].[ID_CATALOGO] point to this entity (FK_E2_ACL_DOMINIOS_JERARQUIAS_E2_CLASIFICACIONES_GESTION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2AclDominiosJerarquia> E2AclDominiosJerarquia { get; set; } // E2_ACL_DOMINIOS_JERARQUIAS.FK_E2_ACL_DOMINIOS_JERARQUIAS_E2_CLASIFICACIONES_GESTION
        /// <summary>
        /// Child E2EquivalenciaClasificacione where [E2_EQUIVALENCIA_CLASIFICACIONES].[ID_CATALOGO_GEST] point to this entity (FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_CLASIFICACIONES_GESTION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2EquivalenciaClasificacione> E2EquivalenciaClasificacione { get; set; } // E2_EQUIVALENCIA_CLASIFICACIONES.FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_CLASIFICACIONES_GESTION
        /// <summary>
        /// Child E2RamasClasificacionesGestion where [E2_RAMAS_CLASIFICACIONES_GESTION].[ID_CATALOGO] point to this entity (FK_E2_RAMAS_CLASIFICACIONES_GESTION_E2_CLASIFICACIONES_GESTION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2RamasClasificacionesGestion> E2RamasClasificacionesGestion { get; set; } // E2_RAMAS_CLASIFICACIONES_GESTION.FK_E2_RAMAS_CLASIFICACIONES_GESTION_E2_CLASIFICACIONES_GESTION

        public E2ClasificacionesGestion()
        {
            Editable = false;
            E2AclDominiosJerarquia = new System.Collections.Generic.List<E2AclDominiosJerarquia>();
            E2EquivalenciaClasificacione = new System.Collections.Generic.List<E2EquivalenciaClasificacione>();
            E2RamasClasificacionesGestion = new System.Collections.Generic.List<E2RamasClasificacionesGestion>();
        }
    }
}