namespace eCat.Data.Entities
{
    public class PePmPsDocumento
    {
        public int IdPmp { get; set; } // IdPMP (Primary key)
        public long IdDocumento { get; set; } // IdDocumento (Primary key)
        public bool Principal { get; set; } // Principal

        // Foreign keys

        /// <summary>
        /// Parent PeDocumento pointed by [PE_PMPs_Documentos].([IdDocumento]) (FK_PE_PMPs_Documentos_PE_Documentos)
        /// </summary>
        public virtual PeDocumento PeDocumento { get; set; } // FK_PE_PMPs_Documentos_PE_Documentos

        /// <summary>
        /// Parent PePmp pointed by [PE_PMPs_Documentos].([IdPmp]) (FK_PE_PMPs_Documentos_PE_PMPs)
        /// </summary>
        public virtual PePmp PePmp { get; set; } // FK_PE_PMPs_Documentos_PE_PMPs

        public PePmPsDocumento()
        {
            Principal = false;
        }
    }
}