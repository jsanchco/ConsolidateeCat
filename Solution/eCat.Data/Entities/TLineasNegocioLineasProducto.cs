namespace eCat.Data.Entities
{
    public class TLineasNegocioLineasProducto
    {
        public short IdPais { get; set; } // IdPais (Primary key)
        public byte IdLineaNegocio { get; set; } // IdLineaNegocio (Primary key)
        public int IdLineaProducto { get; set; } // IdLineaProducto (Primary key)
        public bool Baja { get; set; } // Baja

        // Foreign keys

        /// <summary>
        /// Parent E2AclDominio pointed by [T_LineasNegocio_LineasProducto].([IdPais]) (FK_T_LineasNegocio_LineasProducto_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual E2AclDominio E2AclDominio { get; set; } // FK_T_LineasNegocio_LineasProducto_E2_ACL_DOMINIOS

        /// <summary>
        /// Parent E2Lineasproducto pointed by [T_LineasNegocio_LineasProducto].([IdLineaProducto]) (FK_T_LineasNegocio_LineasProducto_E2_LINEASPRODUCTO)
        /// </summary>
        public virtual E2Lineasproducto E2Lineasproducto { get; set; } // FK_T_LineasNegocio_LineasProducto_E2_LINEASPRODUCTO

        /// <summary>
        /// Parent LineaNegocio pointed by [T_LineasNegocio_LineasProducto].([IdLineaNegocio]) (FK_T_LineasNegocio_LineasProducto_LineaNegocio)
        /// </summary>
        public virtual LineaNegocio LineaNegocio { get; set; } // FK_T_LineasNegocio_LineasProducto_LineaNegocio

        public TLineasNegocioLineasProducto()
        {
            Baja = false;
        }
    }
}