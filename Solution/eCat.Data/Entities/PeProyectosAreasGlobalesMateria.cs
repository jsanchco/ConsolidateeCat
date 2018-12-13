namespace eCat.Data.Entities
{
    public class PeProyectosAreasGlobalesMateria
    {
        public long IdProyecto { get; set; } // IdProyecto (Primary key)
        public short IdAreaGlobal { get; set; } // IdAreaGlobal (Primary key)
        public string CodMateria { get; set; } // CodMateria (Primary key) (length: 5)

        // Foreign keys

        /// <summary>
        /// Parent PeAreasGlobalesMateria pointed by [PE_Proyectos_AreasGlobales_Materias].([IdAreaGlobal], [CodMateria]) (FK_PE_Proyectos_AreasGlobales_Materias_PE_AreasGlobales_Materias)
        /// </summary>
        public virtual PeAreasGlobalesMateria PeAreasGlobalesMateria { get; set; } // FK_PE_Proyectos_AreasGlobales_Materias_PE_AreasGlobales_Materias

        /// <summary>
        /// Parent PeProyecto pointed by [PE_Proyectos_AreasGlobales_Materias].([IdProyecto]) (FK_PE_Proyectos_AreasGlobales_Materias_PE_Proyectos)
        /// </summary>
        public virtual PeProyecto PeProyecto { get; set; } // FK_PE_Proyectos_AreasGlobales_Materias_PE_Proyectos

        public PeProyectosAreasGlobalesMateria()
        {
            IdAreaGlobal = 0;
        }
    }
}