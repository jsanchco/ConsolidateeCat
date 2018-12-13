namespace eCat.Data.Entities
{
    public class E2GePlantillanodoIdioma
    {
        public int IdPlantilla { get; set; } // ID_PLANTILLA (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
    }
}