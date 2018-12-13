namespace eCat.Data.Entities
{
    public class PeTitulosPrincipalesComponente
    {
        public long IdTituloPrincipal { get; set; } // IdTituloPrincipal (Primary key)
        public long IdComponente { get; set; } // IdComponente (Primary key)
        public bool Principal { get; set; } // Principal

        // Foreign keys

        /// <summary>
        /// Parent PeComponente pointed by [PE_TitulosPrincipales_Componentes].([IdComponente]) (FK_PE_TitulosPrincipales_Componentes_PE_Componentes)
        /// </summary>
        public virtual PeComponente PeComponente { get; set; } // FK_PE_TitulosPrincipales_Componentes_PE_Componentes

        /// <summary>
        /// Parent PeTitulosPrincipale pointed by [PE_TitulosPrincipales_Componentes].([IdTituloPrincipal]) (FK_PE_TitulosPrincipales_Componentes_PE_TitulosPrincipales)
        /// </summary>
        public virtual PeTitulosPrincipale PeTitulosPrincipale { get; set; } // FK_PE_TitulosPrincipales_Componentes_PE_TitulosPrincipales

        public PeTitulosPrincipalesComponente()
        {
            Principal = false;
        }
    }
}