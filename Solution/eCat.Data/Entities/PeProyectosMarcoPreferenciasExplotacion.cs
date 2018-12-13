namespace eCat.Data.Entities
{
    public class PeProyectosMarcoPreferenciasExplotacion
    {
        public int IdProyectoMarco { get; set; } // IdProyectoMarco (Primary key)
        public string Color { get; set; } // Color (length: 6)

        // Foreign keys

        /// <summary>
        /// Parent PeProyectosMarco pointed by [PE_ProyectosMarco_PreferenciasExplotacion].([IdProyectoMarco]) (FK_PE_Proyectos_PreferenciasExplotacion_PE_ProyectosMarco)
        /// </summary>
        public virtual PeProyectosMarco PeProyectosMarco { get; set; } // FK_PE_Proyectos_PreferenciasExplotacion_PE_ProyectosMarco
    }
}