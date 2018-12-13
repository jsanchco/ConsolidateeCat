namespace eCat.Data.Entities
{
    public class TProyectosProyectoSeccion
    {
        public int IdProyecto { get; set; } // IdProyecto (Primary key)
        public byte IdProyectoSeccion { get; set; } // IdProyectoSeccion

        // Foreign keys

        /// <summary>
        /// Parent TProyecto pointed by [T_Proyectos_ProyectoSeccion].([IdProyecto]) (FK_T_Proyectos_ProyectoSeccion_T_Proyectos)
        /// </summary>
        public virtual TProyecto TProyecto { get; set; } // FK_T_Proyectos_ProyectoSeccion_T_Proyectos

        /// <summary>
        /// Parent TProyectoSeccion pointed by [T_Proyectos_ProyectoSeccion].([IdProyectoSeccion]) (FK_T_Proyectos_ProyectoSeccion_T_ProyectoSeccion)
        /// </summary>
        public virtual TProyectoSeccion TProyectoSeccion { get; set; } // FK_T_Proyectos_ProyectoSeccion_T_ProyectoSeccion
    }
}