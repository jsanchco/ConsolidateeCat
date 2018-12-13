namespace eCat.Data.Entities
{
    public class Edade
    {

        ///<summary>
        /// Clave de edad
        ///</summary>
        public int IdEdad { get; set; } // IdEdad (Primary key)

        ///<summary>
        /// Entero que representa el mínimo de edad
        ///</summary>
        public int Numero { get; set; } // Numero

        ///<summary>
        /// Descrupción del rango de edad
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 64)
        public byte Desde { get; set; } // Desde
        public byte Hasta { get; set; } // Hasta

        public Edade()
        {
            Desde = 0;
            Hasta = 0;
        }
    }
}