namespace eCat.Data.Entities
{
    public class E2GruposArticulo
    {
        public decimal IdGrupo { get; set; } // IdGrupo
        public string CodigoGrupo { get; set; } // CodigoGrupo (Primary key) (length: 9)
        public string DescripcionGrupo { get; set; } // DescripcionGrupo (length: 20)

        // Reverse navigation

        /// <summary>
        /// Child E2GruposArticulosIdioma where [E2_GRUPOS_ARTICULOS_Idioma].[CodigoGrupo] point to this entity (FK_E2_GRUPOS_ARTICULOS_Idioma_E2_GRUPOS_ARTICULOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2GruposArticulosIdioma> E2GruposArticulosIdioma { get; set; } // E2_GRUPOS_ARTICULOS_Idioma.FK_E2_GRUPOS_ARTICULOS_Idioma_E2_GRUPOS_ARTICULOS
        /// <summary>
        /// Child FichasBases where [FichasBase].[CodigoGrupo] point to this entity (FK_FichasBase_E2_GRUPOS_ARTICULOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_E2_GRUPOS_ARTICULOS
        /// <summary>
        /// Child TTiposMaterialesGruposArticulosPrefijoes where [T_TiposMateriales_GruposArticulos_Prefijo].[CodigoGrupo] point to this entity (FK_T_TiposMateriales_GruposArticulos_Prefijo_E2_GRUPOS_ARTICULOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposMaterialesGruposArticulosPrefijo> TTiposMaterialesGruposArticulosPrefijoes { get; set; } // T_TiposMateriales_GruposArticulos_Prefijo.FK_T_TiposMateriales_GruposArticulos_Prefijo_E2_GRUPOS_ARTICULOS

        public E2GruposArticulo()
        {
            E2GruposArticulosIdioma = new System.Collections.Generic.List<E2GruposArticulosIdioma>();
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            TTiposMaterialesGruposArticulosPrefijoes = new System.Collections.Generic.List<TTiposMaterialesGruposArticulosPrefijo>();
        }
    }
}