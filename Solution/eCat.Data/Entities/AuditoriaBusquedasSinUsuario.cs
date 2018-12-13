namespace eCat.Data.Entities
{
    public class AuditoriaBusquedasSinUsuario
    {
        public long IdAuditoriaBusquedas { get; set; } // IdAuditoriaBusquedas (Primary key)
        public System.DateTime FechaAuditoria { get; set; } // FechaAuditoria
        public string Dominio { get; set; } // Dominio (length: 50)
        public string Titulo { get; set; } // Titulo (length: 255)
        public string Autor { get; set; } // Autor (length: 255)
        public string Isbn { get; set; } // ISBN (length: 255)
        public string IdInterno { get; set; } // IdInterno (length: 255)
        public int? Editorial { get; set; } // Editorial
        public int? AnnoEdicion { get; set; } // AnnoEdicion
        public string Etapa { get; set; } // Etapa (length: 5)
        public string Materia { get; set; } // Materia (length: 5)
        public int? Coleccion { get; set; } // Coleccion
        public int? Serie { get; set; } // Serie
        public int? Edad { get; set; } // Edad
        public int? Proyecto { get; set; } // Proyecto
        public int? Pagina { get; set; } // Pagina
        public int MaterialesPagina { get; set; } // MaterialesPagina
        public string Orden { get; set; } // Orden (length: 50)
        public string Sentido { get; set; } // Sentido (length: 50)
        public string TextoLibre { get; set; } // TextoLibre
        public bool? Contenido { get; set; } // Contenido
        public string DominioUsuario { get; set; } // DominioUsuario (length: 50)
        public string DominioExcluyente { get; set; } // DominioExcluyente (length: 50)
        public string Usuario { get; set; } // Usuario (length: 50)

        public AuditoriaBusquedasSinUsuario()
        {
            FechaAuditoria = System.DateTime.Now;
        }
    }
}