namespace eCat.Data.Entities
{
    public class AuditoriaBusquedaGeneral
    {
        public long IdAuditoria { get; set; } // IdAuditoria (Primary key)
        public System.DateTime FechaAuditoria { get; set; } // FechaAuditoria
        public string Dominio { get; set; } // Dominio (length: 50)
        public string CodigoAutorTitulo { get; set; } // CodigoAutorTitulo (length: 255)
        public string PalabrasClave { get; set; } // PalabrasClave (length: 255)
        public int? TipoMaterial { get; set; } // TipoMaterial
        public int? Estado { get; set; } // Estado
        public string Sello { get; set; } // Sello (length: 5)
        public string Etapa { get; set; } // Etapa (length: 5)
        public string Materia { get; set; } // Materia (length: 5)
        public int? Edad { get; set; } // Edad
        public int? Proyecto { get; set; } // Proyecto
        public int? Coleccion { get; set; } // Coleccion
        public string TextoLibre { get; set; } // TextoLibre (length: 255)
        public bool? Contenido { get; set; } // Contenido
        public string Usuario { get; set; } // Usuario (length: 50)

        public AuditoriaBusquedaGeneral()
        {
            FechaAuditoria = System.DateTime.Now;
        }
    }
}