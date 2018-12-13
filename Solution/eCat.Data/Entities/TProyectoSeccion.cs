namespace eCat.Data.Entities
{
    public class TProyectoSeccion
    {
        public byte IdProyectoSeccion { get; set; } // IdProyectoSeccion (Primary key)
        public string ProyectoSeccion { get; set; } // ProyectoSeccion (length: 64)
        public bool Defecto { get; set; } // Defecto

        // Reverse navigation

        /// <summary>
        /// Child TProyectosProyectoSeccions where [T_Proyectos_ProyectoSeccion].[IdProyectoSeccion] point to this entity (FK_T_Proyectos_ProyectoSeccion_T_ProyectoSeccion)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TProyectosProyectoSeccion> TProyectosProyectoSeccions { get; set; } // T_Proyectos_ProyectoSeccion.FK_T_Proyectos_ProyectoSeccion_T_ProyectoSeccion

        public TProyectoSeccion()
        {
            Defecto = false;
            TProyectosProyectoSeccions = new System.Collections.Generic.List<TProyectosProyectoSeccion>();
        }
    }
}