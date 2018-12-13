namespace eCat.Data.Entities
{
    public class E2GeTiponodoIdioma
    {
        public int IdTiponodo { get; set; } // ID_TIPONODO (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
    }
}