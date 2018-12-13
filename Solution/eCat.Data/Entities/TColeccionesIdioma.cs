namespace eCat.Data.Entities
{
    public class TColeccionesIdioma
    {

        ///<summary>
        /// Clave de la colección traducida
        ///</summary>
        public int IdColeccion { get; set; } // IdColeccion (Primary key)

        ///<summary>
        /// Clave del idioma de traducción
        ///</summary>
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        ///<summary>
        /// Nombre de la colección en el idioma de traducción
        ///</summary>
        public string Valor { get; set; } // Valor (length: 255)
    }
}