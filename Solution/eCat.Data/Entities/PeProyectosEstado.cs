namespace eCat.Data.Entities
{
    public class PeProyectosEstado
    {
        public byte IdEstado { get; set; } // IdEstado (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)
        public string Icono { get; set; } // Icono (length: 255)

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) PeProyectosEstado pointed by [PE_Proyectos_Estados_Idioma].[IdEstado] (FK_PE_Proyectos_Estados_Idioma_PE_Proyectos_Estados)
        /// </summary>
        public virtual PeProyectosEstadosIdioma PeProyectosEstadosIdioma { get; set; } // PE_Proyectos_Estados_Idioma.FK_PE_Proyectos_Estados_Idioma_PE_Proyectos_Estados
        /// <summary>
        /// Child PeProyectoes where [PE_Proyectos].[IdEstado] point to this entity (FK_PE_Proyectos_PE_Proyectos_Estados)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyecto> PeProyectoes { get; set; } // PE_Proyectos.FK_PE_Proyectos_PE_Proyectos_Estados

        public PeProyectosEstado()
        {
            PeProyectoes = new System.Collections.Generic.List<PeProyecto>();
        }
    }
}