namespace eCat.Data.Entities
{
    public class PeProyectosMarcoDocumento
    {
        public int IdProyectoMarco { get; set; } // IdProyectoMarco (Primary key)
        public long IdDocumento { get; set; } // IdDocumento (Primary key)
        public bool Principal { get; set; } // Principal

        // Foreign keys

        /// <summary>
        /// Parent PeDocumento pointed by [PE_ProyectosMarco_Documentos].([IdDocumento]) (FK_PE_ProyectosMarco_Documentos_PE_Documentos)
        /// </summary>
        public virtual PeDocumento PeDocumento { get; set; } // FK_PE_ProyectosMarco_Documentos_PE_Documentos

        /// <summary>
        /// Parent PeProyectosMarco pointed by [PE_ProyectosMarco_Documentos].([IdProyectoMarco]) (FK_PE_ProyectosMarco_Documentos_PE_ProyectosMarco)
        /// </summary>
        public virtual PeProyectosMarco PeProyectosMarco { get; set; } // FK_PE_ProyectosMarco_Documentos_PE_ProyectosMarco

        public PeProyectosMarcoDocumento()
        {
            Principal = false;
        }
    }
}