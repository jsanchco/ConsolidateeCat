namespace eCat.Data.Entities
{
    public class E2GeCatalogo
    {

        ///<summary>
        /// Clave del catálogo
        ///</summary>
        public int IdCatalogo { get; set; } // ID_CATALOGO (Primary key)

        ///<summary>
        /// Nombre del catálogo (formado a partir de los campos NombreParteDerecha y NombreParteIzquierda)
        ///</summary>
        public string NombreCatalogo { get; set; } // Nombre_Catalogo (length: 80)

        ///<summary>
        /// Descripción en HTML del catálogo de presentación
        ///</summary>
        public string Descripcion { get; set; } // Descripcion

        ///<summary>
        /// True = indica que el catálogo es de estilo libre
        ///</summary>
        public bool EstiloLibre { get; set; } // EstiloLibre

        ///<summary>
        /// Claves de los campos que aparecen en los listados de cada rama del catálogo
        ///</summary>
        public string Campos { get; set; } // Campos (length: 255)

        ///<summary>
        /// True = el catálogo ha sido publicado
        ///</summary>
        public bool Publicado { get; set; } // Publicado

        ///<summary>
        /// True = el catálogo está pendiente de publicar
        ///</summary>
        public bool PendientePublicar { get; set; } // PendientePublicar

        ///<summary>
        /// Fecha de creación del catálogo
        ///</summary>
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion

        ///<summary>
        /// Usuario que creó el catálogo
        ///</summary>
        public string UsuarioCreacion { get; set; } // UsuarioCreacion (length: 50)

        ///<summary>
        /// Fecha de la primera  publicación del catálogo
        ///</summary>
        public System.DateTime? FechaPublicacion { get; set; } // FechaPublicacion

        ///<summary>
        /// Usuario que publicó el catálogo por primera vez
        ///</summary>
        public string UsuarioPublicacion { get; set; } // UsuarioPublicacion (length: 50)

        ///<summary>
        /// Fecha de la última publicación del catálogo
        ///</summary>
        public System.DateTime? FechaUltimaPublicacion { get; set; } // FechaUltimaPublicacion

        ///<summary>
        /// Usuario que publico el catálogo la última vez
        ///</summary>
        public string UsuarioUltimaPublicacion { get; set; } // UsuarioUltimaPublicacion (length: 50)

        ///<summary>
        /// Fecha de la última modificación del catálogo
        ///</summary>
        public System.DateTime? FechaActualizacion { get; set; } // FechaActualizacion

        ///<summary>
        /// Usuario que modificó el catálogo al última vez
        ///</summary>
        public string UsuarioActualizacion { get; set; } // UsuarioActualizacion (length: 50)

        ///<summary>
        /// Fecha de retirada (despublicación) del catálogo
        ///</summary>
        public System.DateTime? FechaRetirada { get; set; } // FechaRetirada

        ///<summary>
        /// Usuario que retiró (despublico) el catálogo
        ///</summary>
        public string UsuarioRetirada { get; set; } // UsuarioRetirada (length: 50)

        ///<summary>
        /// True = el catálogo tiene equivalencias con un catálogo de gestión (jerarquía de producto)
        ///</summary>
        public bool Equivalencias { get; set; } // Equivalencias

        ///<summary>
        /// True = Edición limitada al propietario (creador) del catálogo
        ///</summary>
        public bool Bloqueado { get; set; } // Bloqueado

        ///<summary>
        /// True = Notificación del estado de publicación de un libro cuando este pertenece al catálogo
        ///</summary>
        public bool Notificacion { get; set; } // Notificacion

        ///<summary>
        /// ??
        ///</summary>
        public string XmlFicha { get; set; } // XMLFicha (length: 8000)

        ///<summary>
        /// Código del campo por el cual se ordenan los libros en las ramas del catálogo (1/2)
        ///</summary>
        public string CodigoOrden1 { get; set; } // CodigoOrden1 (length: 10)

        ///<summary>
        /// Código del campo por el cual se ordenan los libros en las ramas del catálogo (2/2)
        ///</summary>
        public string CodigoOrden2 { get; set; } // CodigoOrden2 (length: 10)

        ///<summary>
        /// Orden, ascendente o descendente, correspondiente al primer campo de ordenación
        ///</summary>
        public string TipoOrden1 { get; set; } // TipoOrden1 (length: 4)

        ///<summary>
        /// Orden, ascendente o descendente, correspondiente al segundo campo de ordenación
        ///</summary>
        public string TipoOrden2 { get; set; } // TipoOrden2 (length: 4)

        ///<summary>
        /// ??
        ///</summary>
        public int NBrowser { get; set; } // NBrowser

        ///<summary>
        /// Parte izquierda de Nombre_Catalogo
        ///</summary>
        public string NombreParteIzquierda { get; set; } // NombreParteIzquierda (length: 80)

        ///<summary>
        /// Parte derecha de Nombre_Catalogo. En algunas aplicaciones esta parte se resalta sobre la parte izquierda.
        ///</summary>
        public string NombreParteDerecha { get; set; } // NombreParteDerecha (length: 80)

        ///<summary>
        /// ??
        ///</summary>
        public int NImpresion { get; set; } // NImpresion
        public byte EstadoPublicacion { get; set; } // EstadoPublicacion
        public byte PorcentajePublicacion { get; set; } // PorcentajePublicacion
        public bool IndexacionSavia { get; set; } // IndexacionSAVIA
        public bool GenerarXml { get; set; } // GenerarXML
        public System.DateTime? FechaUltimaGeneracionXml { get; set; } // FechaUltimaGeneracionXML
        public bool PrecioEspecialCatalogo { get; set; } // PrecioEspecialCatalogo

        // Reverse navigation

        /// <summary>
        /// Child E2EquivalenciaClasificacione where [E2_EQUIVALENCIA_CLASIFICACIONES].[ID_CATALOGO_PRES] point to this entity (FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_GE_CATALOGOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2EquivalenciaClasificacione> E2EquivalenciaClasificacione { get; set; } // E2_EQUIVALENCIA_CLASIFICACIONES.FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_GE_CATALOGOS
        /// <summary>
        /// Child E2GeCatalogosCompartido where [E2_GE_CATALOGOS_COMPARTIDOS].[ID_CATALOGO] point to this entity (FK_E2_GE_CATALOGOS_COMPARTIDOS_E2_GE_CATALOGOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2GeCatalogosCompartido> E2GeCatalogosCompartido { get; set; } // E2_GE_CATALOGOS_COMPARTIDOS.FK_E2_GE_CATALOGOS_COMPARTIDOS_E2_GE_CATALOGOS
        /// <summary>
        /// Child E2GeRamasarbol where [E2_GE_RAMASARBOL].[ID_CATALOGO] point to this entity (FK_E2_GE_RAMASARBOL_E2_GE_CATALOGOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2GeRamasarbol> E2GeRamasarbol { get; set; } // E2_GE_RAMASARBOL.FK_E2_GE_RAMASARBOL_E2_GE_CATALOGOS
        /// <summary>
        /// Child E2GeRamaslibro where [E2_GE_RAMASLIBROS].[ID_CATALOGO] point to this entity (FK_E2_GE_RAMASLIBROS_E2_GE_CATALOGOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2GeRamaslibro> E2GeRamaslibro { get; set; } // E2_GE_RAMASLIBROS.FK_E2_GE_RAMASLIBROS_E2_GE_CATALOGOS
        /// <summary>
        /// Child PalabrasClaves (Many-to-Many) mapped by table [E2_GE_CATALOGOS_PALABRASCLAVE]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PalabrasClave> PalabrasClaves { get; set; } // Many to many mapping
        /// <summary>
        /// Child TbCamposFichas (Many-to-Many) mapped by table [E2_GE_CATALOGOS_REL_CAMPOS_FICHA]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbCamposFicha> TbCamposFichas { get; set; } // Many to many mapping

        // Foreign keys

        /// <summary>
        /// Parent Usuario pointed by [E2_GE_CATALOGOS].([UsuarioCreacion]) (FK_E2_GE_CATALOGOS_Usuarios)
        /// </summary>
        public virtual Usuario Usuario { get; set; } // FK_E2_GE_CATALOGOS_Usuarios

        public E2GeCatalogo()
        {
            EstiloLibre = false;
            Publicado = false;
            PendientePublicar = false;
            FechaCreacion = System.DateTime.Now;
            Equivalencias = true;
            Bloqueado = false;
            Notificacion = false;
            NBrowser = 0;
            NImpresion = 0;
            EstadoPublicacion = 0;
            PorcentajePublicacion = 0;
            IndexacionSavia = false;
            GenerarXml = false;
            PrecioEspecialCatalogo = false;
            E2EquivalenciaClasificacione = new System.Collections.Generic.List<E2EquivalenciaClasificacione>();
            E2GeCatalogosCompartido = new System.Collections.Generic.List<E2GeCatalogosCompartido>();
            E2GeRamasarbol = new System.Collections.Generic.List<E2GeRamasarbol>();
            E2GeRamaslibro = new System.Collections.Generic.List<E2GeRamaslibro>();
            PalabrasClaves = new System.Collections.Generic.List<PalabrasClave>();
            TbCamposFichas = new System.Collections.Generic.List<TbCamposFicha>();
        }
    }
}