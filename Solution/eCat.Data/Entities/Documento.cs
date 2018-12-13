namespace eCat.Data.Entities
{
    public class Documento
    {

        ///<summary>
        /// Clave del material con el que se relaciona el documento
        ///</summary>
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)

        ///<summary>
        /// Orden de visualización del documento en las aplicaciones ofimáticas o páginas Web.
        ///</summary>
        public byte Orden { get; set; } // Orden

        ///<summary>
        /// Descripción del documento.
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 100)

        ///<summary>
        /// Si se trata de un documento &quot;físico&quot;, representa el nombre del archivo. En caso de que sea un enlace, la URL del mismo.
        ///</summary>
        public string Path { get; set; } // Path (length: 1000)

        ///<summary>
        /// Tipo de documento
        ///</summary>
        public byte Tipo { get; set; } // Tipo

        ///<summary>
        /// Clave del documento
        ///</summary>
        public decimal IdDocumento { get; set; } // IDDocumento (Primary key)

        ///<summary>
        /// Indica si el docujento es un enlace
        ///</summary>
        public bool TipoLink { get; set; } // TipoLink

        ///<summary>
        /// Si el documento es un enlace, el IdVisor es la clave del Libro Interactivo en Red (o Libro Digital)
        ///</summary>
        public long? IdVisor { get; set; } // IdVisor

        ///<summary>
        /// Indica el estado de revición del documento
        ///</summary>
        public bool Revisado { get; set; } // Revisado

        ///<summary>
        /// Nombre del fichero original a partir del cual fué generado
        ///</summary>
        public string DocumentoOriginal { get; set; } // DocumentoOriginal (length: 1000)

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [Documentos].([IdInterno]) (FK_Documentos_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_Documentos_FichasBase

        /// <summary>
        /// Parent TiposDocumento pointed by [Documentos].([Tipo]) (FK_Documentos_TiposDocumentos)
        /// </summary>
        public virtual TiposDocumento TiposDocumento { get; set; } // FK_Documentos_TiposDocumentos

        public Documento()
        {
            TipoLink = false;
            Revisado = false;
        }
    }
}