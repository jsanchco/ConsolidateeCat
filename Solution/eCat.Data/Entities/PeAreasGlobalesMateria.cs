namespace eCat.Data.Entities
{
    public class PeAreasGlobalesMateria
    {
        public short IdAreaGlobal { get; set; } // IdAreaGlobal (Primary key)
        public string CodMateria { get; set; } // CodMateria (Primary key) (length: 5)
        public bool Baja { get; set; } // Baja

        // Reverse navigation

        /// <summary>
        /// Child PeProyectosAreasGlobalesMaterias where [PE_Proyectos_AreasGlobales_Materias].([CodMateria], [IdAreaGlobal]) point to this entity (FK_PE_Proyectos_AreasGlobales_Materias_PE_AreasGlobales_Materias)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosAreasGlobalesMateria> PeProyectosAreasGlobalesMaterias { get; set; } // PE_Proyectos_AreasGlobales_Materias.FK_PE_Proyectos_AreasGlobales_Materias_PE_AreasGlobales_Materias

        // Foreign keys

        /// <summary>
        /// Parent PeAreasGlobale pointed by [PE_AreasGlobales_Materias].([IdAreaGlobal]) (FK_PE_AreasGlobales_Materias_PE_AreasGlobales)
        /// </summary>
        public virtual PeAreasGlobale PeAreasGlobale { get; set; } // FK_PE_AreasGlobales_Materias_PE_AreasGlobales

        /// <summary>
        /// Parent TSubcategoriasMateria pointed by [PE_AreasGlobales_Materias].([CodMateria]) (FK_PE_AreasGlobales_Materias_T_SubcategoriasMaterias)
        /// </summary>
        public virtual TSubcategoriasMateria TSubcategoriasMateria { get; set; } // FK_PE_AreasGlobales_Materias_T_SubcategoriasMaterias

        public PeAreasGlobalesMateria()
        {
            IdAreaGlobal = 0;
            Baja = false;
            PeProyectosAreasGlobalesMaterias = new System.Collections.Generic.List<PeProyectosAreasGlobalesMateria>();
        }
    }
}