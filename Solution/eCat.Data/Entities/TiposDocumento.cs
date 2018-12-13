namespace eCat.Data.Entities
{
    public class TiposDocumento
    {

        ///<summary>
        /// Clave del tipo de documento
        ///</summary>
        public byte IdTipoDocumento { get; set; } // IDTipoDocumento (Primary key)

        ///<summary>
        /// Nombre del tipo de documento
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 100)

        ///<summary>
        /// Extensiones y descripción de las mismas en formato de los filtros de los dialogos de aplicaciones Windows. Definen los tipos de ficheros que se corresponden con el tipo de documento.
        ///</summary>
        public string Extensiones { get; set; } // Extensiones (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child Documentoes where [Documentos].[Tipo] point to this entity (FK_Documentos_TiposDocumentos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Documento> Documentoes { get; set; } // Documentos.FK_Documentos_TiposDocumentos

        public TiposDocumento()
        {
            Documentoes = new System.Collections.Generic.List<Documento>();
        }
    }
}