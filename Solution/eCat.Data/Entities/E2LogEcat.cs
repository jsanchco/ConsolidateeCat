namespace eCat.Data.Entities
{
    public class E2LogEcat
    {
        public decimal IdError { get; set; } // IdError (Primary key)
        public string Formulario { get; set; } // Formulario (length: 100)
        public string Funcion { get; set; } // Funcion (length: 500)
        public string Descripcion { get; set; } // Descripcion (length: 4000)
        public string Usuario { get; set; } // Usuario (length: 50)
        public System.DateTime Fecha { get; set; } // Fecha
        public bool Corregido { get; set; } // Corregido
        public System.DateTime? FechaCorregido { get; set; } // FechaCorregido
        public string UsuarioCorregido { get; set; } // UsuarioCorregido (length: 50)
        public bool Error { get; set; } // Error

        public E2LogEcat()
        {
            Fecha = System.DateTime.Now;
            Corregido = false;
            Error = true;
        }
    }
}