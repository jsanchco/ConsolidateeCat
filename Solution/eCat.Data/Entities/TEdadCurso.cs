namespace eCat.Data.Entities
{
    public class TEdadCurso
    {
        public int IdCursoGradoEdad { get; set; } // IdCursoGradoEdad

        ///<summary>
        /// Clave de la edad o curso
        ///</summary>
        public string Codigo { get; set; } // Codigo (Primary key) (length: 5)

        ///<summary>
        /// Nombre de la edad o curso
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 255)

        ///<summary>
        /// 1 -&gt; Edad y 2 -&gt; Curso
        ///</summary>
        public byte Tipo { get; set; } // Tipo
        public bool Hpe { get; set; } // HPE

        // Reverse navigation

        /// <summary>
        /// Child DilveCursoAneles (Many-to-Many) mapped by table [DILVE_CursoANELE_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveCursoAnele> DilveCursoAneles { get; set; } // Many to many mapping
        /// <summary>
        /// Child E2RamasClasificacionesGestion where [E2_RAMAS_CLASIFICACIONES_GESTION].[CodEdadCurso] point to this entity (FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_EdadCurso)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2RamasClasificacionesGestion> E2RamasClasificacionesGestion { get; set; } // E2_RAMAS_CLASIFICACIONES_GESTION.FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_EdadCurso
        /// <summary>
        /// Child FichasBaseCicloCursoes where [FichasBase_CicloCurso].[IdCurso] point to this entity (FK_FichasBase_CicloCurso_T_EdadCurso)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseCicloCurso> FichasBaseCicloCursoes { get; set; } // FichasBase_CicloCurso.FK_FichasBase_CicloCurso_T_EdadCurso
        /// <summary>
        /// Child PeEstructuraEdadesNivelesEducativoes where [PE_EstructuraEdades_NivelesEducativos].[CodCurso] point to this entity (FK_PE_Edades_NivelesEducativos_T_EdadCurso1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeEstructuraEdadesNivelesEducativo> PeEstructuraEdadesNivelesEducativoes_CodCurso { get; set; } // PE_EstructuraEdades_NivelesEducativos.FK_PE_Edades_NivelesEducativos_T_EdadCurso1
        /// <summary>
        /// Child PeEstructuraEdadesNivelesEducativoes where [PE_EstructuraEdades_NivelesEducativos].[CodEdad] point to this entity (FK_PE_Edades_NivelesEducativos_T_EdadCurso)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeEstructuraEdadesNivelesEducativo> PeEstructuraEdadesNivelesEducativoes_CodEdad { get; set; } // PE_EstructuraEdades_NivelesEducativos.FK_PE_Edades_NivelesEducativos_T_EdadCurso

        public TEdadCurso()
        {
            Hpe = false;
            E2RamasClasificacionesGestion = new System.Collections.Generic.List<E2RamasClasificacionesGestion>();
            FichasBaseCicloCursoes = new System.Collections.Generic.List<FichasBaseCicloCurso>();
            PeEstructuraEdadesNivelesEducativoes_CodCurso = new System.Collections.Generic.List<PeEstructuraEdadesNivelesEducativo>();
            PeEstructuraEdadesNivelesEducativoes_CodEdad = new System.Collections.Generic.List<PeEstructuraEdadesNivelesEducativo>();
            DilveCursoAneles = new System.Collections.Generic.List<DilveCursoAnele>();
        }
    }
}