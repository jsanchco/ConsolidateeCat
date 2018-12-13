namespace eCat.Data.Entities
{
    public class PeComponente
    {
        public long IdComponente { get; set; } // IdComponente (Primary key)
        public long IdTituloPrincipal { get; set; } // IdTituloPrincipal
        public string Codigo { get; set; } // Codigo (length: 50)
        public string Nombre { get; set; } // Nombre (length: 255)
        public string Descripcion { get; set; } // Descripcion (length: 255)
        public byte IdFormato { get; set; } // IdFormato
        public byte IdDestino { get; set; } // IdDestino
        public byte? IdUsoComercial { get; set; } // IdUsoComercial
        public byte IdTipo { get; set; } // IdTipo
        public byte IdEstado { get; set; } // IdEstado
        public bool Baja { get; set; } // Baja
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion
        public string UsuarioCreacion { get; set; } // UsuarioCreacion (length: 50)
        public System.DateTime? FechaModificacion { get; set; } // FechaModificacion
        public string UsuarioModificacion { get; set; } // UsuarioModificacion (length: 50)
        public System.DateTime? FechaBaja { get; set; } // FechaBaja
        public string UsuarioBaja { get; set; } // UsuarioBaja (length: 50)
        public bool Principal { get; set; } // Principal

        // Reverse navigation

        /// <summary>
        /// Child PeComponentesDocumentoes where [PE_Componentes_Documentos].[IdComponente] point to this entity (FK_PE_Componentes_Documentos_PE_Componentes)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesDocumento> PeComponentesDocumentoes { get; set; } // PE_Componentes_Documentos.FK_PE_Componentes_Documentos_PE_Componentes
        /// <summary>
        /// Child PeTitulosPrincipalesComponentes where [PE_TitulosPrincipales_Componentes].[IdComponente] point to this entity (FK_PE_TitulosPrincipales_Componentes_PE_Componentes)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeTitulosPrincipalesComponente> PeTitulosPrincipalesComponentes { get; set; } // PE_TitulosPrincipales_Componentes.FK_PE_TitulosPrincipales_Componentes_PE_Componentes

        // Foreign keys

        /// <summary>
        /// Parent PeComponentesDestino pointed by [PE_Componentes].([IdDestino]) (FK_PE_Componentes_PE_Componentes_Destinos)
        /// </summary>
        public virtual PeComponentesDestino PeComponentesDestino { get; set; } // FK_PE_Componentes_PE_Componentes_Destinos

        /// <summary>
        /// Parent PeComponentesEstado pointed by [PE_Componentes].([IdEstado]) (FK_PE_Componentes_PE_Componentes_Estados)
        /// </summary>
        public virtual PeComponentesEstado PeComponentesEstado { get; set; } // FK_PE_Componentes_PE_Componentes_Estados

        /// <summary>
        /// Parent PeComponentesFormato pointed by [PE_Componentes].([IdFormato]) (FK_PE_Componentes_PE_Componentes_Formatos)
        /// </summary>
        public virtual PeComponentesFormato PeComponentesFormato { get; set; } // FK_PE_Componentes_PE_Componentes_Formatos

        /// <summary>
        /// Parent PeComponentesTipos pointed by [PE_Componentes].([IdTipo]) (FK_PE_Componentes_PE_Componentes_Tipos)
        /// </summary>
        public virtual PeComponentesTipos PeComponentesTipos { get; set; } // FK_PE_Componentes_PE_Componentes_Tipos

        /// <summary>
        /// Parent PeTitulosPrincipale pointed by [PE_Componentes].([IdTituloPrincipal]) (FK_PE_Componentes_PE_TitulosPrincipales)
        /// </summary>
        public virtual PeTitulosPrincipale PeTitulosPrincipale { get; set; } // FK_PE_Componentes_PE_TitulosPrincipales

        /// <summary>
        /// Parent TUsosComerciale pointed by [PE_Componentes].([IdUsoComercial]) (FK_PE_Componentes_T_UsosComerciales)
        /// </summary>
        public virtual TUsosComerciale TUsosComerciale { get; set; } // FK_PE_Componentes_T_UsosComerciales

        public PeComponente()
        {
            Principal = false;
            PeComponentesDocumentoes = new System.Collections.Generic.List<PeComponentesDocumento>();
            PeTitulosPrincipalesComponentes = new System.Collections.Generic.List<PeTitulosPrincipalesComponente>();
        }
    }
}