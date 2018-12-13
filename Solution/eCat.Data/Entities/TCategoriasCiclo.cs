namespace eCat.Data.Entities
{
    public class TCategoriasCiclo
    {
        public int IdCategoriaCiclo { get; set; } // IdCategoriaCiclo

        ///<summary>
        /// Clave de la categoría o ciclo
        ///</summary>
        public string Codigo { get; set; } // Codigo (Primary key) (length: 5)

        ///<summary>
        /// Nombre de la categoría o ciclo
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 255)

        ///<summary>
        /// 1 -&gt; Categoria y 2 -&gt; Ciclo
        ///</summary>
        public byte Tipo { get; set; } // Tipo

        // Reverse navigation

        /// <summary>
        /// Child DilveCicloEducativoAneles (Many-to-Many) mapped by table [DILVE_CicloEducativoANELE_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveCicloEducativoAnele> DilveCicloEducativoAneles { get; set; } // Many to many mapping
        /// <summary>
        /// Child E2RamasClasificacionesGestion where [E2_RAMAS_CLASIFICACIONES_GESTION].[CodCategoriaCiclo] point to this entity (FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_CategoriasCiclos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2RamasClasificacionesGestion> E2RamasClasificacionesGestion { get; set; } // E2_RAMAS_CLASIFICACIONES_GESTION.FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_CategoriasCiclos
        /// <summary>
        /// Child FichasBaseCicloCursoes where [FichasBase_CicloCurso].[IdCiclo] point to this entity (FK_FichasBase_CicloCurso_T_CategoriasCiclos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseCicloCurso> FichasBaseCicloCursoes { get; set; } // FichasBase_CicloCurso.FK_FichasBase_CicloCurso_T_CategoriasCiclos
        /// <summary>
        /// Child PeEstructuraEdadesNivelesEducativoes where [PE_EstructuraEdades_NivelesEducativos].[CodCiclo] point to this entity (FK_PE_Edades_NivelesEducativos_T_CategoriasCiclos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeEstructuraEdadesNivelesEducativo> PeEstructuraEdadesNivelesEducativoes { get; set; } // PE_EstructuraEdades_NivelesEducativos.FK_PE_Edades_NivelesEducativos_T_CategoriasCiclos

        public TCategoriasCiclo()
        {
            E2RamasClasificacionesGestion = new System.Collections.Generic.List<E2RamasClasificacionesGestion>();
            FichasBaseCicloCursoes = new System.Collections.Generic.List<FichasBaseCicloCurso>();
            PeEstructuraEdadesNivelesEducativoes = new System.Collections.Generic.List<PeEstructuraEdadesNivelesEducativo>();
            DilveCicloEducativoAneles = new System.Collections.Generic.List<DilveCicloEducativoAnele>();
        }
    }
}