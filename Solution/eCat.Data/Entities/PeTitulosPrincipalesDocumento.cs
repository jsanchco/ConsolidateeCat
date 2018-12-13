namespace eCat.Data.Entities
{
    public class PeTitulosPrincipalesDocumento
    {
        public long IdTituloPrincipal { get; set; } // IdTituloPrincipal (Primary key)
        public long IdDocumento { get; set; } // IdDocumento (Primary key)
        public bool Principal { get; set; } // Principal

        // Foreign keys

        /// <summary>
        /// Parent PeDocumento pointed by [PE_TitulosPrincipales_Documentos].([IdDocumento]) (FK_PE_TitulosPrincipales_Documentos_PE_Documentos)
        /// </summary>
        public virtual PeDocumento PeDocumento { get; set; } // FK_PE_TitulosPrincipales_Documentos_PE_Documentos

        /// <summary>
        /// Parent PeTitulosPrincipale pointed by [PE_TitulosPrincipales_Documentos].([IdTituloPrincipal]) (FK_PE_TitulosPrincipales_Documentos_PE_TitulosPrincipales)
        /// </summary>
        public virtual PeTitulosPrincipale PeTitulosPrincipale { get; set; } // FK_PE_TitulosPrincipales_Documentos_PE_TitulosPrincipales

        public PeTitulosPrincipalesDocumento()
        {
            Principal = false;
        }
    }
}