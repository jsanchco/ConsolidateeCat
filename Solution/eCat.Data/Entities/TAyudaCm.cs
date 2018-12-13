namespace eCat.Data.Entities
{
    public class TAyudaCm
    {
        public short IdAyuda { get; set; } // idAyuda (Primary key)
        public string CodigoAyuda { get; set; } // CodigoAyuda (length: 50)
        public long IdCmsContenido { get; set; } // IdCMSContenido
        public string Discriminador { get; set; } // Discriminador (length: 100)
        public string Descripcion { get; set; } // Descripcion (length: 100)
    }
}