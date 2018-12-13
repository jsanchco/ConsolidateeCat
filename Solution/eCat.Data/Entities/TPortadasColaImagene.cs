namespace eCat.Data.Entities
{
    public class TPortadasColaImagene
    {
        public long Id { get; set; } // Id (Primary key)
        public byte IdEstado { get; set; } // IdEstado
        public string IdInterno { get; set; } // IdInterno (length: 12)
        public string RutaImagen { get; set; } // RutaImagen (length: 255)
        public byte? IdTipoImagen { get; set; } // IdTipoImagen
        public System.DateTime FechaCreacion { get; set; } // FechaCreacion
        public System.DateTime? FechaInicioProceso { get; set; } // FechaInicioProceso
        public System.DateTime? FechaFinProceso { get; set; } // FechaFinProceso
        public System.DateTime? FechaError { get; set; } // FechaError
        public string Error { get; set; } // Error (length: 255)
        public System.DateTime? SiguienteAcceso { get; set; } // SiguienteAcceso
    }
}