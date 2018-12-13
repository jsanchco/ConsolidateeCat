namespace eCat.Data.Entities
{
    public class TUsuariosImpersonacion
    {
        public string Login { get; set; } // Login (Primary key) (length: 50)
        public string Dominio { get; set; } // Dominio (Primary key) (length: 50)
        public bool Defecto { get; set; } // Defecto

        public TUsuariosImpersonacion()
        {
            Defecto = false;
        }
    }
}