namespace eCat.Data.Entities
{
    public class Resena
    {

        ///<summary>
        /// Clave del material al cual hace referencia la reseña
        ///</summary>
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)

        ///<summary>
        /// Clave de la reseña
        ///</summary>
        public int IdResena { get; set; } // IDResena (Primary key)

        ///<summary>
        /// Clave del medio de comunicación donde apareció la reseña
        ///</summary>
        public int IdMedio { get; set; } // IDMedio

        ///<summary>
        /// Fecha de aparición de la reseña
        ///</summary>
        public System.DateTime Fecha { get; set; } // Fecha

        ///<summary>
        /// Puede contener un código de referencia de la reseña en el archivo o biblioteca de SM, el número del depósito legal o texto literal o resumido de la reseña
        ///</summary>
        public string Resena_ { get; set; } // Resena

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [Resenas].([IdInterno]) (FK_Resenas_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_Resenas_FichasBase

        /// <summary>
        /// Parent Medio pointed by [Resenas].([IdMedio]) (FK_Resenas_Medios)
        /// </summary>
        public virtual Medio Medio { get; set; } // FK_Resenas_Medios
    }
}