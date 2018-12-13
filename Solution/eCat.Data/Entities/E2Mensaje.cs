namespace eCat.Data.Entities
{
    public class E2Mensaje
    {
        public decimal IdMensaje { get; set; } // IDMensaje (Primary key)
        public string IdUsuarioDe { get; set; } // IDUsuarioDe (length: 50)
        public string IdUsuarioPara { get; set; } // IDUsuarioPara (length: 50)
        public string Asunto { get; set; } // Asunto (length: 255)
        public string Mensaje { get; set; } // Mensaje (length: 4000)
        public byte Importancia { get; set; } // Importancia
        public bool Repetir { get; set; } // Repetir
        public System.DateTime FechaEnvio { get; set; } // FechaEnvio
        public System.DateTime? FechaDesactivado { get; set; } // FechaDesactivado
        public bool Baja { get; set; } // Baja
        public System.DateTime? FechaBaja { get; set; } // FechaBaja

        public E2Mensaje()
        {
            Importancia = 0;
            Repetir = true;
            FechaEnvio = System.DateTime.Now;
            Baja = false;
        }
    }
}