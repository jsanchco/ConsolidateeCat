namespace eCat.Data.Entities
{
    public class PeProyectosDocumento
    {
        public long IdProyecto { get; set; } // IdProyecto (Primary key)
        public long IdDocumento { get; set; } // IdDocumento (Primary key)
        public bool Principal { get; set; } // Principal

        // Foreign keys

        /// <summary>
        /// Parent PeDocumento pointed by [PE_Proyectos_Documentos].([IdDocumento]) (FK_PE_Proyectos_Documentos_PE_Documentos)
        /// </summary>
        public virtual PeDocumento PeDocumento { get; set; } // FK_PE_Proyectos_Documentos_PE_Documentos

        /// <summary>
        /// Parent PeProyecto pointed by [PE_Proyectos_Documentos].([IdProyecto]) (FK_PE_Proyectos_Documentos_PE_Proyectos)
        /// </summary>
        public virtual PeProyecto PeProyecto { get; set; } // FK_PE_Proyectos_Documentos_PE_Proyectos

        public PeProyectosDocumento()
        {
            Principal = false;
        }
    }
}