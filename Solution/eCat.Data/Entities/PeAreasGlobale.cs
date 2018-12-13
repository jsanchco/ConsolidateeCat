namespace eCat.Data.Entities
{
    public class PeAreasGlobale
    {
        public short IdAreaGlobal { get; set; } // IdAreaGlobal (Primary key)
        public string Codigo { get; set; } // Codigo (length: 10)
        public string Descripcion { get; set; } // Descripcion (length: 255)
        public short Orden { get; set; } // Orden
        public bool Baja { get; set; } // Baja

        // Reverse navigation

        /// <summary>
        /// Child PeAreasGlobalesIdiomas where [PE_AreasGlobales_Idioma].[IdAreaGlobal] point to this entity (FK_PE_AreasGlobales_Idioma_PE_AreasGlobales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeAreasGlobalesIdioma> PeAreasGlobalesIdiomas { get; set; } // PE_AreasGlobales_Idioma.FK_PE_AreasGlobales_Idioma_PE_AreasGlobales
        /// <summary>
        /// Child PeAreasGlobalesMaterias where [PE_AreasGlobales_Materias].[IdAreaGlobal] point to this entity (FK_PE_AreasGlobales_Materias_PE_AreasGlobales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeAreasGlobalesMateria> PeAreasGlobalesMaterias { get; set; } // PE_AreasGlobales_Materias.FK_PE_AreasGlobales_Materias_PE_AreasGlobales

        public PeAreasGlobale()
        {
            Baja = false;
            PeAreasGlobalesIdiomas = new System.Collections.Generic.List<PeAreasGlobalesIdioma>();
            PeAreasGlobalesMaterias = new System.Collections.Generic.List<PeAreasGlobalesMateria>();
        }
    }
}