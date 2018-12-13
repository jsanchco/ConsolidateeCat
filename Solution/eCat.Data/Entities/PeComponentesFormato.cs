namespace eCat.Data.Entities
{
    public class PeComponentesFormato
    {
        public byte IdFormato { get; set; } // IdFormato (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child PeComponentes where [PE_Componentes].[IdFormato] point to this entity (FK_PE_Componentes_PE_Componentes_Formatos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponente> PeComponentes { get; set; } // PE_Componentes.FK_PE_Componentes_PE_Componentes_Formatos
        /// <summary>
        /// Child PeComponentesFormatosIdiomas where [PE_Componentes_Formatos_Idioma].[IdFormato] point to this entity (FK_PE_Componentes_Formatos_Idioma_PE_Componentes_Formatos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesFormatosIdioma> PeComponentesFormatosIdiomas { get; set; } // PE_Componentes_Formatos_Idioma.FK_PE_Componentes_Formatos_Idioma_PE_Componentes_Formatos
        /// <summary>
        /// Child PeComponentesTiposMaterialesGruposArticuloes where [PE_Componentes_TiposMateriales_GruposArticulos].[IdFormato] point to this entity (FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Formatos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesTiposMaterialesGruposArticulo> PeComponentesTiposMaterialesGruposArticuloes { get; set; } // PE_Componentes_TiposMateriales_GruposArticulos.FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Formatos

        public PeComponentesFormato()
        {
            PeComponentes = new System.Collections.Generic.List<PeComponente>();
            PeComponentesFormatosIdiomas = new System.Collections.Generic.List<PeComponentesFormatosIdioma>();
            PeComponentesTiposMaterialesGruposArticuloes = new System.Collections.Generic.List<PeComponentesTiposMaterialesGruposArticulo>();
        }
    }
}