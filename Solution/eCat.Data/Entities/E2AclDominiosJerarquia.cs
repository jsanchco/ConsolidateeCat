namespace eCat.Data.Entities
{
    public class E2AclDominiosJerarquia
    {
        public int IdDominioJerarquia { get; set; } // IdDominioJerarquia (Primary key)
        public string Dominio { get; set; } // DOMINIO (length: 50)
        public int IdCatalogo { get; set; } // ID_CATALOGO
        public string IdClasificacion { get; set; } // ID_CLASIFICACION (length: 60)
        public bool PermiteAlta { get; set; } // PermiteAlta
        public bool PermiteComercializacion { get; set; } // PermiteComercializacion

        // Foreign keys

        /// <summary>
        /// Parent E2ClasificacionesGestion pointed by [E2_ACL_DOMINIOS_JERARQUIAS].([IdCatalogo]) (FK_E2_ACL_DOMINIOS_JERARQUIAS_E2_CLASIFICACIONES_GESTION)
        /// </summary>
        public virtual E2ClasificacionesGestion E2ClasificacionesGestion { get; set; } // FK_E2_ACL_DOMINIOS_JERARQUIAS_E2_CLASIFICACIONES_GESTION

        /// <summary>
        /// Parent E2RamasClasificacionesGestion pointed by [E2_ACL_DOMINIOS_JERARQUIAS].([IdCatalogo], [IdClasificacion]) (FK_E2_ACL_DOMINIOS_JERARQUIAS_E2_RAMAS_CLASIFICACIONES_GESTION)
        /// </summary>
        public virtual E2RamasClasificacionesGestion E2RamasClasificacionesGestion { get; set; } // FK_E2_ACL_DOMINIOS_JERARQUIAS_E2_RAMAS_CLASIFICACIONES_GESTION

        public E2AclDominiosJerarquia()
        {
            PermiteAlta = true;
            PermiteComercializacion = true;
        }
    }
}