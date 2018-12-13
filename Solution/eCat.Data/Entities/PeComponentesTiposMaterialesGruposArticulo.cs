namespace eCat.Data.Entities
{
    public class PeComponentesTiposMaterialesGruposArticulo
    {
        public int Id { get; set; } // Id (Primary key)
        public byte IdFormato { get; set; } // IdFormato
        public byte IdDestino { get; set; } // IdDestino
        public byte? IdUsoComercial { get; set; } // IdUsoComercial
        public byte IdTipo { get; set; } // IdTipo
        public short IdTipoMaterial { get; set; } // IdTipoMaterial
        public string CodigoGrupo { get; set; } // CodigoGrupo (length: 9)
        public byte? IdTipoMaterialEducativo { get; set; } // IdTipoMaterialEducativo
        public bool Baja { get; set; } // Baja

        // Foreign keys

        /// <summary>
        /// Parent PeComponentesDestino pointed by [PE_Componentes_TiposMateriales_GruposArticulos].([IdDestino]) (FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Destinos)
        /// </summary>
        public virtual PeComponentesDestino PeComponentesDestino { get; set; } // FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Destinos

        /// <summary>
        /// Parent PeComponentesFormato pointed by [PE_Componentes_TiposMateriales_GruposArticulos].([IdFormato]) (FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Formatos)
        /// </summary>
        public virtual PeComponentesFormato PeComponentesFormato { get; set; } // FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Formatos

        /// <summary>
        /// Parent PeComponentesTipos pointed by [PE_Componentes_TiposMateriales_GruposArticulos].([IdTipo]) (FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Tipos)
        /// </summary>
        public virtual PeComponentesTipos PeComponentesTipos { get; set; } // FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Tipos

        /// <summary>
        /// Parent TTiposMaterialesGruposArticulosPrefijo pointed by [PE_Componentes_TiposMateriales_GruposArticulos].([IdTipoMaterial], [CodigoGrupo]) (FK_PE_Componentes_TiposMateriales_GruposArticulos_T_TiposMateriales_GruposArticulos_Prefijo)
        /// </summary>
        public virtual TTiposMaterialesGruposArticulosPrefijo TTiposMaterialesGruposArticulosPrefijo { get; set; } // FK_PE_Componentes_TiposMateriales_GruposArticulos_T_TiposMateriales_GruposArticulos_Prefijo

        /// <summary>
        /// Parent TUsosComerciale pointed by [PE_Componentes_TiposMateriales_GruposArticulos].([IdUsoComercial]) (FK_PE_Componentes_TiposMateriales_GruposArticulos_T_UsosComerciales)
        /// </summary>
        public virtual TUsosComerciale TUsosComerciale { get; set; } // FK_PE_Componentes_TiposMateriales_GruposArticulos_T_UsosComerciales

        public PeComponentesTiposMaterialesGruposArticulo()
        {
            Baja = false;
        }
    }
}