namespace eCat.Data.Entities
{
    public class FichasBaseTesauro
    {

        ///<summary>
        /// Clave de la relación entre Tesauro y material
        ///</summary>
        public long IdTesauroLibro { get; set; } // IDTesauroLibro (Primary key)

        ///<summary>
        /// Clave del material relacionado en FichasBase
        ///</summary>
        public string IdInterno { get; set; } // IDInterno (length: 12)

        ///<summary>
        /// Clave del término del Tesauro con el que se relaciona el material
        ///</summary>
        public int IdArbol { get; set; } // IDArbol

        ///<summary>
        /// Línea de ascendientes con los que el término del Tesauro está relacionado. Necesario para determinar la localización correcta del término en el árbol del Tesauro, ya que un mismo término puede estar incluído en diferentes ramas del árbol.
        ///</summary>
        public string Clasificacion { get; set; } // Clasificacion

        ///<summary>
        /// Hace referencia a que tipo de datos estan en la tabla. 1 = Palabras Clave, 2 = Valore y 3 = Temas
        ///</summary>
        public byte IdTipo { get; set; } // IdTipo

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [FichasBase_Tesauro].([IdInterno]) (FK_FichasBase_Tesauro_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_FichasBase_Tesauro_FichasBase
    }
}