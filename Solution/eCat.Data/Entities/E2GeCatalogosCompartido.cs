namespace eCat.Data.Entities
{
    public class E2GeCatalogosCompartido
    {

        ///<summary>
        /// Clave del catálogo compartido
        ///</summary>
        public int IdCatalogo { get; set; } // ID_CATALOGO (Primary key)

        ///<summary>
        /// Usuario con el que se comparte el catálogo
        ///</summary>
        public string IdUsuario { get; set; } // IDUsuario (Primary key) (length: 50)

        // Foreign keys

        /// <summary>
        /// Parent E2GeCatalogo pointed by [E2_GE_CATALOGOS_COMPARTIDOS].([IdCatalogo]) (FK_E2_GE_CATALOGOS_COMPARTIDOS_E2_GE_CATALOGOS)
        /// </summary>
        public virtual E2GeCatalogo E2GeCatalogo { get; set; } // FK_E2_GE_CATALOGOS_COMPARTIDOS_E2_GE_CATALOGOS
    }
}