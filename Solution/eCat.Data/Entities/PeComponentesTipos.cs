namespace eCat.Data.Entities
{
    public class PeComponentesTipos
    {
        public byte IdTipo { get; set; } // IdTipo (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)
        public string DescripcionCorta { get; set; } // DescripcionCorta (length: 15)

        // Reverse navigation

        /// <summary>
        /// Child PeComponentes where [PE_Componentes].[IdTipo] point to this entity (FK_PE_Componentes_PE_Componentes_Tipos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponente> PeComponentes { get; set; } // PE_Componentes.FK_PE_Componentes_PE_Componentes_Tipos
        /// <summary>
        /// Child PeComponentesTiposIdiomas where [PE_Componentes_Tipos_Idioma].[IdTipo] point to this entity (FK_PE_Componentes_Tipos_Idioma_PE_Componentes_Tipos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesTiposIdioma> PeComponentesTiposIdiomas { get; set; } // PE_Componentes_Tipos_Idioma.FK_PE_Componentes_Tipos_Idioma_PE_Componentes_Tipos
        /// <summary>
        /// Child PeComponentesTiposMaterialesGruposArticuloes where [PE_Componentes_TiposMateriales_GruposArticulos].[IdTipo] point to this entity (FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Tipos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesTiposMaterialesGruposArticulo> PeComponentesTiposMaterialesGruposArticuloes { get; set; } // PE_Componentes_TiposMateriales_GruposArticulos.FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Tipos

        public PeComponentesTipos()
        {
            PeComponentes = new System.Collections.Generic.List<PeComponente>();
            PeComponentesTiposIdiomas = new System.Collections.Generic.List<PeComponentesTiposIdioma>();
            PeComponentesTiposMaterialesGruposArticuloes = new System.Collections.Generic.List<PeComponentesTiposMaterialesGruposArticulo>();
        }
    }
}