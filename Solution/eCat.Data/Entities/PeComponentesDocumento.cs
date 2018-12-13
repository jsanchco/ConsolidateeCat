namespace eCat.Data.Entities
{
    public class PeComponentesDocumento
    {
        public long IdComponente { get; set; } // IdComponente (Primary key)
        public long IdDocumento { get; set; } // IdDocumento (Primary key)
        public bool Principal { get; set; } // Principal

        // Foreign keys

        /// <summary>
        /// Parent PeComponente pointed by [PE_Componentes_Documentos].([IdComponente]) (FK_PE_Componentes_Documentos_PE_Componentes)
        /// </summary>
        public virtual PeComponente PeComponente { get; set; } // FK_PE_Componentes_Documentos_PE_Componentes

        /// <summary>
        /// Parent PeDocumento pointed by [PE_Componentes_Documentos].([IdDocumento]) (FK_PE_Componentes_Documentos_PE_Documentos)
        /// </summary>
        public virtual PeDocumento PeDocumento { get; set; } // FK_PE_Componentes_Documentos_PE_Documentos

        public PeComponentesDocumento()
        {
            Principal = false;
        }
    }
}