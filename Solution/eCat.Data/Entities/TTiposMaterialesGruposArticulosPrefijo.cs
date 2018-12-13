namespace eCat.Data.Entities
{
    public class TTiposMaterialesGruposArticulosPrefijo
    {
        public short IdTipoMaterial { get; set; } // IdTipoMaterial (Primary key)
        public string CodigoGrupo { get; set; } // CodigoGrupo (Primary key) (length: 9)
        public string Prefijo { get; set; } // Prefijo (length: 1)
        public bool BDependenciaImagenes { get; set; } // bDependenciaImagenes
        public bool Baja { get; set; } // Baja

        // Reverse navigation

        /// <summary>
        /// Child PeComponentesTiposMaterialesGruposArticuloes where [PE_Componentes_TiposMateriales_GruposArticulos].([CodigoGrupo], [IdTipoMaterial]) point to this entity (FK_PE_Componentes_TiposMateriales_GruposArticulos_T_TiposMateriales_GruposArticulos_Prefijo)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesTiposMaterialesGruposArticulo> PeComponentesTiposMaterialesGruposArticuloes { get; set; } // PE_Componentes_TiposMateriales_GruposArticulos.FK_PE_Componentes_TiposMateriales_GruposArticulos_T_TiposMateriales_GruposArticulos_Prefijo
        /// <summary>
        /// Child TTiposMaterialesGruposArticuloes where [T_TiposMateriales_GruposArticulos].([CodigoGrupo], [IdTipoMaterial]) point to this entity (FK_T_TiposMateriales_GruposArticulos_T_TiposMateriales_GruposArticulos_Prefijo)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposMaterialesGruposArticulo> TTiposMaterialesGruposArticuloes { get; set; } // T_TiposMateriales_GruposArticulos.FK_T_TiposMateriales_GruposArticulos_T_TiposMateriales_GruposArticulos_Prefijo
        /// <summary>
        /// Child TTiposMaterialesGruposArticulosPais where [T_TiposMateriales_GruposArticulos_Paises].([CodigoGrupo], [IdTipoMaterial]) point to this entity (FK_T_TiposMateriales_GruposArticulos_Paises_T_TiposMateriales_GruposArticulos_Prefijo)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposMaterialesGruposArticulosPais> TTiposMaterialesGruposArticulosPais { get; set; } // T_TiposMateriales_GruposArticulos_Paises.FK_T_TiposMateriales_GruposArticulos_Paises_T_TiposMateriales_GruposArticulos_Prefijo

        // Foreign keys

        /// <summary>
        /// Parent E2GruposArticulo pointed by [T_TiposMateriales_GruposArticulos_Prefijo].([CodigoGrupo]) (FK_T_TiposMateriales_GruposArticulos_Prefijo_E2_GRUPOS_ARTICULOS)
        /// </summary>
        public virtual E2GruposArticulo E2GruposArticulo { get; set; } // FK_T_TiposMateriales_GruposArticulos_Prefijo_E2_GRUPOS_ARTICULOS

        /// <summary>
        /// Parent TTiposMateriale pointed by [T_TiposMateriales_GruposArticulos_Prefijo].([IdTipoMaterial]) (FK_T_TiposMateriales_GruposArticulos_Prefijo_T_TiposMateriales)
        /// </summary>
        public virtual TTiposMateriale TTiposMateriale { get; set; } // FK_T_TiposMateriales_GruposArticulos_Prefijo_T_TiposMateriales

        public TTiposMaterialesGruposArticulosPrefijo()
        {
            BDependenciaImagenes = false;
            Baja = false;
            PeComponentesTiposMaterialesGruposArticuloes = new System.Collections.Generic.List<PeComponentesTiposMaterialesGruposArticulo>();
            TTiposMaterialesGruposArticuloes = new System.Collections.Generic.List<TTiposMaterialesGruposArticulo>();
            TTiposMaterialesGruposArticulosPais = new System.Collections.Generic.List<TTiposMaterialesGruposArticulosPais>();
        }
    }
}