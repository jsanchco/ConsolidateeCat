namespace eCat.Data.Entities
{
    public class PeProyectosEstadosIdioma
    {
        public byte IdEstado { get; set; } // IdEstado (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent PeProyectosEstado pointed by [PE_Proyectos_Estados_Idioma].([IdEstado]) (FK_PE_Proyectos_Estados_Idioma_PE_Proyectos_Estados)
        /// </summary>
        public virtual PeProyectosEstado PeProyectosEstado { get; set; } // FK_PE_Proyectos_Estados_Idioma_PE_Proyectos_Estados

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [PE_Proyectos_Estados_Idioma].([IdIdiomaInterface]) (FK_PE_Proyectos_Estados_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_PE_Proyectos_Estados_Idioma_T_Idiomas_Plataforma
    }
}