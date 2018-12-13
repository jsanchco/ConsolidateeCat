namespace eCat.Data.Entities
{
    public class TProyecto
    {
        public int IdProyecto { get; set; } // IdProyecto (Primary key)
        public string Proyecto { get; set; } // Proyecto (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child FichasBases where [FichasBase].[IdProyecto] point to this entity (FK_FichasBase_T_Proyectos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases_IdProyecto { get; set; } // FichasBase.FK_FichasBase_T_Proyectos
        /// <summary>
        /// Child FichasBases where [FichasBase].[IdProyectoAdicional] point to this entity (FK_FichasBase_T_Proyectos_Adicional)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases_IdProyectoAdicional { get; set; } // FichasBase.FK_FichasBase_T_Proyectos_Adicional
        /// <summary>
        /// Child LineaNegocios (Many-to-Many) mapped by table [T_Proyectos_LineaNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<LineaNegocio> LineaNegocios { get; set; } // Many to many mapping
        /// <summary>
        /// Parent (One-to-One) TProyecto pointed by [T_Proyectos_ProyectoSeccion].[IdProyecto] (FK_T_Proyectos_ProyectoSeccion_T_Proyectos)
        /// </summary>
        public virtual TProyectosProyectoSeccion TProyectosProyectoSeccion { get; set; } // T_Proyectos_ProyectoSeccion.FK_T_Proyectos_ProyectoSeccion_T_Proyectos

        public TProyecto()
        {
            FichasBases_IdProyecto = new System.Collections.Generic.List<FichasBase>();
            FichasBases_IdProyectoAdicional = new System.Collections.Generic.List<FichasBase>();
            LineaNegocios = new System.Collections.Generic.List<LineaNegocio>();
        }
    }
}