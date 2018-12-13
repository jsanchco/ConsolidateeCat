namespace eCat.Data.Entities
{
    public class PeTitulosPrincipalesEstado
    {
        public byte IdEstado { get; set; } // IdEstado (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)
        public string Icono { get; set; } // Icono (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child PeTitulosPrincipales where [PE_TitulosPrincipales].[IdEstado] point to this entity (FK_PE_TitulosPrincipales_PE_TitulosPrincipales_Estados)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeTitulosPrincipale> PeTitulosPrincipales { get; set; } // PE_TitulosPrincipales.FK_PE_TitulosPrincipales_PE_TitulosPrincipales_Estados
        /// <summary>
        /// Child PeTitulosPrincipalesEstadosIdiomas where [PE_TitulosPrincipales_Estados_Idioma].[IdEstado] point to this entity (FK_PE_TitulosPrincipales_Estados_Idioma_PE_TitulosPrincipales_Estados)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeTitulosPrincipalesEstadosIdioma> PeTitulosPrincipalesEstadosIdiomas { get; set; } // PE_TitulosPrincipales_Estados_Idioma.FK_PE_TitulosPrincipales_Estados_Idioma_PE_TitulosPrincipales_Estados

        public PeTitulosPrincipalesEstado()
        {
            PeTitulosPrincipales = new System.Collections.Generic.List<PeTitulosPrincipale>();
            PeTitulosPrincipalesEstadosIdiomas = new System.Collections.Generic.List<PeTitulosPrincipalesEstadosIdioma>();
        }
    }
}