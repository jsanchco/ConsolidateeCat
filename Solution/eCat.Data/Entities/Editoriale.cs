namespace eCat.Data.Entities
{
    public class Editoriale
    {

        ///<summary>
        /// Clave de la editorial.
        ///</summary>
        public int IdEditorial { get; set; } // IdEditorial (Primary key)

        ///<summary>
        /// Nombre de la editorial.
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 50)
    }
}