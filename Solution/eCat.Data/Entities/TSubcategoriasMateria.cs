namespace eCat.Data.Entities
{
    public class TSubcategoriasMateria
    {
        public int IdSubcategoriaMateria { get; set; } // IdSubcategoriaMateria

        ///<summary>
        /// Calve de la subcategoría o materia
        ///</summary>
        public string Codigo { get; set; } // Codigo (Primary key) (length: 5)

        ///<summary>
        /// Nombre de la subcategoría o materia
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 255)

        ///<summary>
        /// 1 -&gt; Subcategoria y 2 -&gt; Materias
        ///</summary>
        public byte Tipo { get; set; } // Tipo

        // Reverse navigation

        /// <summary>
        /// Child DilveMaterias (Many-to-Many) mapped by table [DILVE_Materias_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveMateria> DilveMaterias { get; set; } // Many to many mapping
        /// <summary>
        /// Child E2RamasClasificacionesGestion where [E2_RAMAS_CLASIFICACIONES_GESTION].[CodSubcategoriaMateria] point to this entity (FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_SubcategoriasMaterias)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2RamasClasificacionesGestion> E2RamasClasificacionesGestion { get; set; } // E2_RAMAS_CLASIFICACIONES_GESTION.FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_SubcategoriasMaterias
        /// <summary>
        /// Child PeAreasGlobalesMaterias where [PE_AreasGlobales_Materias].[CodMateria] point to this entity (FK_PE_AreasGlobales_Materias_T_SubcategoriasMaterias)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeAreasGlobalesMateria> PeAreasGlobalesMaterias { get; set; } // PE_AreasGlobales_Materias.FK_PE_AreasGlobales_Materias_T_SubcategoriasMaterias

        public TSubcategoriasMateria()
        {
            E2RamasClasificacionesGestion = new System.Collections.Generic.List<E2RamasClasificacionesGestion>();
            PeAreasGlobalesMaterias = new System.Collections.Generic.List<PeAreasGlobalesMateria>();
            DilveMaterias = new System.Collections.Generic.List<DilveMateria>();
        }
    }
}