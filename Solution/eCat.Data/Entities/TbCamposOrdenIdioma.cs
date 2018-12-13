namespace eCat.Data.Entities
{
    public class TbCamposOrdenIdioma
    {
        public string Codigo { get; set; } // Codigo (Primary key) (length: 50)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
    }
}