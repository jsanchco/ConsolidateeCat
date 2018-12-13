namespace eCat.Data.Entities
{
    public class TDrmIdioma
    {
        public byte IdDrm { get; set; } // IdDRM (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
    }
}