namespace eCat.Data.Entities
{
    public class E2GeRamaslibro
    {

        ///<summary>
        /// Clave del catálogo al que se asigna el material
        ///</summary>
        public int IdCatalogo { get; set; } // ID_CATALOGO (Primary key)

        ///<summary>
        /// Calve de la rama del catálogo a la que se asigna el material
        ///</summary>
        public string IdClasificacion { get; set; } // ID_CLASIFICACION (Primary key) (length: 255)

        ///<summary>
        /// Clave del material asignado al catálogo
        ///</summary>
        public string IdInterno { get; set; } // ID_INTERNO (Primary key) (length: 12)

        ///<summary>
        /// Fecha de creación de la asignación
        ///</summary>
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion

        ///<summary>
        /// Usuario que creo la asignación
        ///</summary>
        public string UsuarioCreacion { get; set; } // UsuarioCreacion (length: 50)
        public bool? Destacado { get; set; } // Destacado

        // Foreign keys

        /// <summary>
        /// Parent E2GeCatalogo pointed by [E2_GE_RAMASLIBROS].([IdCatalogo]) (FK_E2_GE_RAMASLIBROS_E2_GE_CATALOGOS)
        /// </summary>
        public virtual E2GeCatalogo E2GeCatalogo { get; set; } // FK_E2_GE_RAMASLIBROS_E2_GE_CATALOGOS

        /// <summary>
        /// Parent E2GeRamasarbol pointed by [E2_GE_RAMASLIBROS].([IdCatalogo], [IdClasificacion]) (FK_E2_GE_RAMASLIBROS_E2_GE_RAMASARBOL)
        /// </summary>
        public virtual E2GeRamasarbol E2GeRamasarbol { get; set; } // FK_E2_GE_RAMASLIBROS_E2_GE_RAMASARBOL

        /// <summary>
        /// Parent FichasBase pointed by [E2_GE_RAMASLIBROS].([IdInterno]) (FK_E2_GE_RAMASLIBROS_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_E2_GE_RAMASLIBROS_FichasBase

        public E2GeRamaslibro()
        {
            FechaCreacion = System.DateTime.Now;
        }
    }
}