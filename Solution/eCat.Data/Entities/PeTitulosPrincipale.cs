namespace eCat.Data.Entities
{
    public class PeTitulosPrincipale
    {
        public long IdTituloPrincipal { get; set; } // IdTituloPrincipal (Primary key)
        public long IdProyecto { get; set; } // IdProyecto
        public string Codigo { get; set; } // Codigo (length: 50)
        public string Nombre { get; set; } // Nombre (length: 255)
        public string Descripcion { get; set; } // Descripcion (length: 255)
        public byte IdEstado { get; set; } // IdEstado
        public string CodEdad { get; set; } // CodEdad (length: 5)
        public string CodEtapa { get; set; } // CodEtapa (length: 5)
        public string CodCiclo { get; set; } // CodCiclo (length: 5)
        public string CodCurso { get; set; } // CodCurso (length: 5)
        public short IdAreaGlobal { get; set; } // IdAreaGlobal
        public string CodMateria { get; set; } // CodMateria (length: 5)
        public bool Baja { get; set; } // Baja
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion
        public string UsuarioCreacion { get; set; } // UsuarioCreacion (length: 50)
        public System.DateTime? FechaModificacion { get; set; } // FechaModificacion
        public string UsuarioModificacion { get; set; } // UsuarioModificacion (length: 50)
        public System.DateTime? FechaBaja { get; set; } // FechaBaja
        public string UsuarioBaja { get; set; } // UsuarioBaja (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child PeComponentes where [PE_Componentes].[IdTituloPrincipal] point to this entity (FK_PE_Componentes_PE_TitulosPrincipales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponente> PeComponentes { get; set; } // PE_Componentes.FK_PE_Componentes_PE_TitulosPrincipales
        /// <summary>
        /// Child PeTitulosPrincipalesComponentes where [PE_TitulosPrincipales_Componentes].[IdTituloPrincipal] point to this entity (FK_PE_TitulosPrincipales_Componentes_PE_TitulosPrincipales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeTitulosPrincipalesComponente> PeTitulosPrincipalesComponentes { get; set; } // PE_TitulosPrincipales_Componentes.FK_PE_TitulosPrincipales_Componentes_PE_TitulosPrincipales
        /// <summary>
        /// Child PeTitulosPrincipalesDocumentoes where [PE_TitulosPrincipales_Documentos].[IdTituloPrincipal] point to this entity (FK_PE_TitulosPrincipales_Documentos_PE_TitulosPrincipales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeTitulosPrincipalesDocumento> PeTitulosPrincipalesDocumentoes { get; set; } // PE_TitulosPrincipales_Documentos.FK_PE_TitulosPrincipales_Documentos_PE_TitulosPrincipales

        // Foreign keys

        /// <summary>
        /// Parent PeProyecto pointed by [PE_TitulosPrincipales].([IdProyecto]) (FK_PE_TitulosPrincipales_PE_Proyectos)
        /// </summary>
        public virtual PeProyecto PeProyecto { get; set; } // FK_PE_TitulosPrincipales_PE_Proyectos

        /// <summary>
        /// Parent PeTitulosPrincipalesEstado pointed by [PE_TitulosPrincipales].([IdEstado]) (FK_PE_TitulosPrincipales_PE_TitulosPrincipales_Estados)
        /// </summary>
        public virtual PeTitulosPrincipalesEstado PeTitulosPrincipalesEstado { get; set; } // FK_PE_TitulosPrincipales_PE_TitulosPrincipales_Estados

        public PeTitulosPrincipale()
        {
            PeComponentes = new System.Collections.Generic.List<PeComponente>();
            PeTitulosPrincipalesComponentes = new System.Collections.Generic.List<PeTitulosPrincipalesComponente>();
            PeTitulosPrincipalesDocumentoes = new System.Collections.Generic.List<PeTitulosPrincipalesDocumento>();
        }
    }
}