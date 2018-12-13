namespace eCat.Data.Entities
{
    public class TPropietario
    {
        public short IdPropietario { get; set; } // IdPropietario

        ///<summary>
        /// Clave del propietario
        ///</summary>
        public string Codigo { get; set; } // Codigo (Primary key) (length: 5)

        ///<summary>
        /// Nombre del propietario
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 255)
        public byte? IdIdioma { get; set; } // IDIdioma

        // Reverse navigation

        /// <summary>
        /// Child DilveEditoriales (Many-to-Many) mapped by table [DILVE_Editoriales_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveEditoriale> DilveEditoriales { get; set; } // Many to many mapping
        /// <summary>
        /// Child E2RamasClasificacionesGestion where [E2_RAMAS_CLASIFICACIONES_GESTION].[CodPropietario] point to this entity (FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Propietario)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2RamasClasificacionesGestion> E2RamasClasificacionesGestion { get; set; } // E2_RAMAS_CLASIFICACIONES_GESTION.FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Propietario

        public TPropietario()
        {
            E2RamasClasificacionesGestion = new System.Collections.Generic.List<E2RamasClasificacionesGestion>();
            DilveEditoriales = new System.Collections.Generic.List<DilveEditoriale>();
        }
    }
}