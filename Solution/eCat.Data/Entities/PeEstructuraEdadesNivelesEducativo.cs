namespace eCat.Data.Entities
{
    public class PeEstructuraEdadesNivelesEducativo
    {
        public int IdEstructura { get; set; } // IdEstructura (Primary key)
        public string CodEdad { get; set; } // CodEdad (Primary key) (length: 5)
        public string CodEtapa { get; set; } // CodEtapa (length: 5)
        public string CodCiclo { get; set; } // CodCiclo (length: 5)
        public string CodCurso { get; set; } // CodCurso (length: 5)
        public System.DateTime FechaAlta { get; set; } // FechaAlta
        public System.DateTime? FechaUltimaModificacion { get; set; } // FechaUltimaModificacion

        // Reverse navigation

        /// <summary>
        /// Child PeProyectosNivelesEducativoes where [PE_Proyectos_NivelesEducativos].([CodEdad], [IdEstructura]) point to this entity (FK_PE_Proyectos_NivelesEducativos_PE_EstructuraEdades_NivelesEducativos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeProyectosNivelesEducativo> PeProyectosNivelesEducativoes { get; set; } // PE_Proyectos_NivelesEducativos.FK_PE_Proyectos_NivelesEducativos_PE_EstructuraEdades_NivelesEducativos

        // Foreign keys

        /// <summary>
        /// Parent PeEstructuraEdade pointed by [PE_EstructuraEdades_NivelesEducativos].([IdEstructura]) (FK_PE_Edades_NivelesEducativos_PE_Edades)
        /// </summary>
        public virtual PeEstructuraEdade PeEstructuraEdade { get; set; } // FK_PE_Edades_NivelesEducativos_PE_Edades

        /// <summary>
        /// Parent TCategoriasCiclo pointed by [PE_EstructuraEdades_NivelesEducativos].([CodCiclo]) (FK_PE_Edades_NivelesEducativos_T_CategoriasCiclos)
        /// </summary>
        public virtual TCategoriasCiclo TCategoriasCiclo { get; set; } // FK_PE_Edades_NivelesEducativos_T_CategoriasCiclos

        /// <summary>
        /// Parent TEdadCurso pointed by [PE_EstructuraEdades_NivelesEducativos].([CodCurso]) (FK_PE_Edades_NivelesEducativos_T_EdadCurso1)
        /// </summary>
        public virtual TEdadCurso TEdadCurso_CodCurso { get; set; } // FK_PE_Edades_NivelesEducativos_T_EdadCurso1

        /// <summary>
        /// Parent TEdadCurso pointed by [PE_EstructuraEdades_NivelesEducativos].([CodEdad]) (FK_PE_Edades_NivelesEducativos_T_EdadCurso)
        /// </summary>
        public virtual TEdadCurso TEdadCurso_CodEdad { get; set; } // FK_PE_Edades_NivelesEducativos_T_EdadCurso

        /// <summary>
        /// Parent TEtapasRangoEdad pointed by [PE_EstructuraEdades_NivelesEducativos].([CodEtapa]) (FK_PE_Edades_NivelesEducativos_T_EtapasRangoEdad)
        /// </summary>
        public virtual TEtapasRangoEdad TEtapasRangoEdad { get; set; } // FK_PE_Edades_NivelesEducativos_T_EtapasRangoEdad

        public PeEstructuraEdadesNivelesEducativo()
        {
            PeProyectosNivelesEducativoes = new System.Collections.Generic.List<PeProyectosNivelesEducativo>();
        }
    }
}