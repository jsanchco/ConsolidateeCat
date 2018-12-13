namespace eCat.Data.Entities
{
    public class PeComponentesDestino
    {
        public byte IdDestino { get; set; } // IdDestino (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)
        public string DescripcionCorta { get; set; } // DescripcionCorta (length: 10)

        // Reverse navigation

        /// <summary>
        /// Child PeComponentes where [PE_Componentes].[IdDestino] point to this entity (FK_PE_Componentes_PE_Componentes_Destinos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponente> PeComponentes { get; set; } // PE_Componentes.FK_PE_Componentes_PE_Componentes_Destinos
        /// <summary>
        /// Child PeComponentesDestinosIdiomas where [PE_Componentes_Destinos_Idioma].[IdDestino] point to this entity (FK_PE_Componentes_Destinos_Idioma_PE_Componentes_Destinos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesDestinosIdioma> PeComponentesDestinosIdiomas { get; set; } // PE_Componentes_Destinos_Idioma.FK_PE_Componentes_Destinos_Idioma_PE_Componentes_Destinos
        /// <summary>
        /// Child PeComponentesTiposMaterialesGruposArticuloes where [PE_Componentes_TiposMateriales_GruposArticulos].[IdDestino] point to this entity (FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Destinos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesTiposMaterialesGruposArticulo> PeComponentesTiposMaterialesGruposArticuloes { get; set; } // PE_Componentes_TiposMateriales_GruposArticulos.FK_PE_Componentes_TiposMateriales_GruposArticulos_PE_Componentes_Destinos

        public PeComponentesDestino()
        {
            PeComponentes = new System.Collections.Generic.List<PeComponente>();
            PeComponentesDestinosIdiomas = new System.Collections.Generic.List<PeComponentesDestinosIdioma>();
            PeComponentesTiposMaterialesGruposArticuloes = new System.Collections.Generic.List<PeComponentesTiposMaterialesGruposArticulo>();
        }
    }
}