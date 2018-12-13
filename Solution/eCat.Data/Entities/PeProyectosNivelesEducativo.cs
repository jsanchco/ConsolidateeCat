namespace eCat.Data.Entities
{
    public class PeProyectosNivelesEducativo
    {
        public long IdProyecto { get; set; } // IdProyecto (Primary key)
        public int IdEstructura { get; set; } // IdEstructura (Primary key)
        public string CodEdad { get; set; } // CodEdad (Primary key) (length: 5)

        // Foreign keys

        /// <summary>
        /// Parent PeEstructuraEdadesNivelesEducativo pointed by [PE_Proyectos_NivelesEducativos].([IdEstructura], [CodEdad]) (FK_PE_Proyectos_NivelesEducativos_PE_EstructuraEdades_NivelesEducativos)
        /// </summary>
        public virtual PeEstructuraEdadesNivelesEducativo PeEstructuraEdadesNivelesEducativo { get; set; } // FK_PE_Proyectos_NivelesEducativos_PE_EstructuraEdades_NivelesEducativos

        /// <summary>
        /// Parent PeProyecto pointed by [PE_Proyectos_NivelesEducativos].([IdProyecto]) (FK_PE_Proyectos_NivelesEducativos_PE_Proyectos)
        /// </summary>
        public virtual PeProyecto PeProyecto { get; set; } // FK_PE_Proyectos_NivelesEducativos_PE_Proyectos
    }
}