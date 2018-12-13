namespace eCat.Data.Entities
{
    public class TTiposMaterialesGruposArticulo
    {
        public short IdTipoMaterial { get; set; } // IdTipoMaterial (Primary key)
        public string CodigoGrupo { get; set; } // CodigoGrupo (Primary key) (length: 9)
        public byte IdUsoComercial { get; set; } // IdUsoComercial (Primary key)
        public bool Baja { get; set; } // Baja

        // Foreign keys

        /// <summary>
        /// Parent TTiposMaterialesGruposArticulosPrefijo pointed by [T_TiposMateriales_GruposArticulos].([IdTipoMaterial], [CodigoGrupo]) (FK_T_TiposMateriales_GruposArticulos_T_TiposMateriales_GruposArticulos_Prefijo)
        /// </summary>
        public virtual TTiposMaterialesGruposArticulosPrefijo TTiposMaterialesGruposArticulosPrefijo { get; set; } // FK_T_TiposMateriales_GruposArticulos_T_TiposMateriales_GruposArticulos_Prefijo

        /// <summary>
        /// Parent TUsosComerciale pointed by [T_TiposMateriales_GruposArticulos].([IdUsoComercial]) (FK_T_TiposMateriales_GruposArticulos_T_UsosComerciales)
        /// </summary>
        public virtual TUsosComerciale TUsosComerciale { get; set; } // FK_T_TiposMateriales_GruposArticulos_T_UsosComerciales

        public TTiposMaterialesGruposArticulo()
        {
            Baja = false;
        }
    }
}