namespace eCat.Data.Entities
{
    public class PeProyectosPreferenciasExplotacion
    {
        public long IdProyecto { get; set; } // IdProyecto (Primary key)
        public string Color { get; set; } // Color (length: 6)

        // Foreign keys

        /// <summary>
        /// Parent PeProyecto pointed by [PE_Proyectos_PreferenciasExplotacion].([IdProyecto]) (FK_PE_Proyectos_PreferenciasExplotacion_PE_Proyectos)
        /// </summary>
        public virtual PeProyecto PeProyecto { get; set; } // FK_PE_Proyectos_PreferenciasExplotacion_PE_Proyectos
    }
}