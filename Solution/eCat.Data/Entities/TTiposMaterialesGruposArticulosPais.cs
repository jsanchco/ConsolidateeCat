namespace eCat.Data.Entities
{
    public class TTiposMaterialesGruposArticulosPais
    {
        public short IdTipoMaterial { get; set; } // IdTipoMaterial (Primary key)
        public string CodigoGrupo { get; set; } // CodigoGrupo (Primary key) (length: 9)
        public short IdPais { get; set; } // IdPais (Primary key)
        public bool Baja { get; set; } // Baja

        ///<summary>
        /// Indica si el material debe llevar un proyecto de gestión asociado (true) o no (false)
        ///</summary>
        public bool ProyectoGestion { get; set; } // ProyectoGestion

        // Foreign keys

        /// <summary>
        /// Parent E2AclDominio pointed by [T_TiposMateriales_GruposArticulos_Paises].([IdPais]) (FK_T_TiposMateriales_GruposArticulos_Paises_E2_ACL_DOMINIOS)
        /// </summary>
        public virtual E2AclDominio E2AclDominio { get; set; } // FK_T_TiposMateriales_GruposArticulos_Paises_E2_ACL_DOMINIOS

        /// <summary>
        /// Parent TTiposMaterialesGruposArticulosPrefijo pointed by [T_TiposMateriales_GruposArticulos_Paises].([IdTipoMaterial], [CodigoGrupo]) (FK_T_TiposMateriales_GruposArticulos_Paises_T_TiposMateriales_GruposArticulos_Prefijo)
        /// </summary>
        public virtual TTiposMaterialesGruposArticulosPrefijo TTiposMaterialesGruposArticulosPrefijo { get; set; } // FK_T_TiposMateriales_GruposArticulos_Paises_T_TiposMateriales_GruposArticulos_Prefijo

        public TTiposMaterialesGruposArticulosPais()
        {
            Baja = false;
            ProyectoGestion = false;
        }
    }
}