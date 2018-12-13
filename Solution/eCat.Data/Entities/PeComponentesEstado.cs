namespace eCat.Data.Entities
{
    public class PeComponentesEstado
    {
        public byte IdEstado { get; set; } // IdEstado (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)
        public string Icono { get; set; } // Icono (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child PeComponentes where [PE_Componentes].[IdEstado] point to this entity (FK_PE_Componentes_PE_Componentes_Estados)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponente> PeComponentes { get; set; } // PE_Componentes.FK_PE_Componentes_PE_Componentes_Estados
        /// <summary>
        /// Child PeComponentesEstadosIdiomas where [PE_Componentes_Estados_Idioma].[IdEstado] point to this entity (FK_PE_Componentes_Estados_Idioma_PE_Componentes_Estados)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesEstadosIdioma> PeComponentesEstadosIdiomas { get; set; } // PE_Componentes_Estados_Idioma.FK_PE_Componentes_Estados_Idioma_PE_Componentes_Estados

        public PeComponentesEstado()
        {
            PeComponentes = new System.Collections.Generic.List<PeComponente>();
            PeComponentesEstadosIdiomas = new System.Collections.Generic.List<PeComponentesEstadosIdioma>();
        }
    }
}