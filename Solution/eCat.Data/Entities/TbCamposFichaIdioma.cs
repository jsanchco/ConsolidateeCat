namespace eCat.Data.Entities
{
    public class TbCamposFichaIdioma
    {
        public decimal IdCampo { get; set; } // ID_CAMPO (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
    }
}