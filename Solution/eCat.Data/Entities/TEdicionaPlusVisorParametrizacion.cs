namespace eCat.Data.Entities
{
    public class TEdicionaPlusVisorParametrizacion
    {
        public long IdParametrizacion { get; set; } // IdParametrizacion (Primary key)
        public string Nombre { get; set; } // Nombre (length: 255)
        public short IdPais { get; set; } // IdPais
        public string Query { get; set; } // Query
        public int IdPlataforma { get; set; } // IdPlataforma
        public long IdCarpeta { get; set; } // IdCarpeta
        public int IdUsuario { get; set; } // IdUsuario
        public string ListaDitribucionInforme { get; set; } // ListaDitribucionInforme
        public string ListaDitribucionTerminado { get; set; } // ListaDitribucionTerminado
        public short? IdTipoMaterial { get; set; } // IdTipoMaterial
        public int? IdGrupoArticulo { get; set; } // IdGrupoArticulo
        public byte? IdLineaNegocio { get; set; } // IdLineaNegocio
        public int Orden { get; set; } // Orden
    }
}