namespace eCat.Data.Entities
{
    public class E2GeRamasarbol
    {

        ///<summary>
        /// Clave del catálogo de presentación
        ///</summary>
        public int IdCatalogo { get; set; } // ID_CATALOGO (Primary key)

        ///<summary>
        /// Clave de la rama dentro del árbol
        ///</summary>
        public string IdClasificacion { get; set; } // ID_CLASIFICACION (Primary key) (length: 255)

        ///<summary>
        /// Antecesor de la rama en el árbol de jerarquía
        ///</summary>
        public string IdPadre { get; set; } // ID_PADRE (length: 255)

        ///<summary>
        /// Nombre de la rama
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 128)

        ///<summary>
        /// Descripción HTML de la rama
        ///</summary>
        public string Descripcion { get; set; } // Descripcion

        ///<summary>
        /// Plantilla que utilizará la aplicación para mostrar esta rama del catálogo de presentación
        ///</summary>
        public int? IdPlantilla { get; set; } // ID_PLANTILLA

        ///<summary>
        /// Tipo de nodo de la rama
        ///</summary>
        public int? IdTiponodo { get; set; } // ID_TIPONODO

        ///<summary>
        /// Nombre de la rama en mayúsculas y sin acentos
        ///</summary>
        public string FoneticaClasif { get; set; } // FONETICA_CLASIF (length: 128)

        ///<summary>
        /// True = rama aún no publicada
        ///</summary>
        public bool PendientePublicar { get; set; } // PendientePublicar

        ///<summary>
        /// True = rama publicada
        ///</summary>
        public bool Publicado { get; set; } // Publicado

        ///<summary>
        /// Fecha de creación de la rama
        ///</summary>
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion

        ///<summary>
        /// Usuario que creó la rama
        ///</summary>
        public string UsuarioCreacion { get; set; } // UsuarioCreacion (length: 50)

        ///<summary>
        /// Fecha de primera publicación de la rama
        ///</summary>
        public System.DateTime? FechaPublicacion { get; set; } // FechaPublicacion

        ///<summary>
        /// Usuario que publicó la rama por primera vez
        ///</summary>
        public string UsuarioPublicacion { get; set; } // UsuarioPublicacion (length: 50)

        ///<summary>
        /// Fecha de la última publicación de la rama
        ///</summary>
        public System.DateTime? FechaUltimaPublicacion { get; set; } // FechaUltimaPublicacion

        ///<summary>
        /// Usuario que publicó la rama la última vez
        ///</summary>
        public string UsuarioUltimaPublicacion { get; set; } // UsuarioUltimaPublicacion (length: 50)

        ///<summary>
        /// Fecha de actualización de la rama
        ///</summary>
        public System.DateTime? FechaActualizacion { get; set; } // FechaActualizacion

        ///<summary>
        /// Usuario que actualizó la rama la última vez
        ///</summary>
        public string UsuarioActualizacion { get; set; } // UsuarioActualizacion (length: 50)

        ///<summary>
        /// Fecha de retirada (despublicación) de la rama
        ///</summary>
        public System.DateTime? FechaRetirada { get; set; } // FechaRetirada

        ///<summary>
        /// Usuario que retiró (despublicó) la rama la última vez
        ///</summary>
        public string UsuarioRetirada { get; set; } // UsuarioRetirada (length: 50)
        public byte EstadoPublicacion { get; set; } // EstadoPublicacion
        public string GuidContenido { get; set; } // GUIDContenido (length: 50)
        public long? IdCmsContenido { get; set; } // IdCMSContenido

        // Reverse navigation

        /// <summary>
        /// Child E2GeRamaslibro where [E2_GE_RAMASLIBROS].([ID_CATALOGO], [ID_CLASIFICACION]) point to this entity (FK_E2_GE_RAMASLIBROS_E2_GE_RAMASARBOL)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2GeRamaslibro> E2GeRamaslibro { get; set; } // E2_GE_RAMASLIBROS.FK_E2_GE_RAMASLIBROS_E2_GE_RAMASARBOL

        // Foreign keys

        /// <summary>
        /// Parent E2GeCatalogo pointed by [E2_GE_RAMASARBOL].([IdCatalogo]) (FK_E2_GE_RAMASARBOL_E2_GE_CATALOGOS)
        /// </summary>
        public virtual E2GeCatalogo E2GeCatalogo { get; set; } // FK_E2_GE_RAMASARBOL_E2_GE_CATALOGOS

        /// <summary>
        /// Parent E2GePlantillanodo pointed by [E2_GE_RAMASARBOL].([IdPlantilla]) (FK_E2_GE_RAMASARBOL_E2_GE_PLANTILLANODO)
        /// </summary>
        public virtual E2GePlantillanodo E2GePlantillanodo { get; set; } // FK_E2_GE_RAMASARBOL_E2_GE_PLANTILLANODO

        /// <summary>
        /// Parent E2GeTiponodo pointed by [E2_GE_RAMASARBOL].([IdTiponodo]) (FK_E2_GE_RAMASARBOL_E2_GE_TIPONODO)
        /// </summary>
        public virtual E2GeTiponodo E2GeTiponodo { get; set; } // FK_E2_GE_RAMASARBOL_E2_GE_TIPONODO

        public E2GeRamasarbol()
        {
            IdPlantilla = 0;
            IdTiponodo = 0;
            PendientePublicar = false;
            Publicado = false;
            FechaCreacion = System.DateTime.Now;
            EstadoPublicacion = 0;
            E2GeRamaslibro = new System.Collections.Generic.List<E2GeRamaslibro>();
        }
    }
}