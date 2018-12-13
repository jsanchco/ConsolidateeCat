namespace eCat.Data.Entities
{
    public class TTiposElementosIdioma
    {
        public int IdTipoElemento { get; set; } // IdTipoElemento (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
    }
}