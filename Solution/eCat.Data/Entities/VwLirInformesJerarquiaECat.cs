namespace eCat.Data.Entities
{
    public class VwLirInformesJerarquiaECat
    {
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)
        public string IdClasificacion { get; set; } // ID_CLASIFICACION (Primary key) (length: 60)
        public string CodPropietario { get; set; } // CodPropietario (length: 5)
        public string CodMercado { get; set; } // CodMercado (length: 5)
        public string CodNegocio { get; set; } // CodNegocio (length: 5)
        public string CodEtapaEdad { get; set; } // CodEtapaEdad (length: 5)
        public string CodCategoriaCiclo { get; set; } // CodCategoriaCiclo (length: 5)
        public string CodSubcategoriaMateria { get; set; } // CodSubcategoriaMateria (length: 5)
        public string CodEdadCurso { get; set; } // CodEdadCurso (length: 5)
        public string Propietario { get; set; } // propietario (length: 255)
        public string Mercado { get; set; } // mercado (length: 255)
        public string Negocio { get; set; } // negocio (length: 255)
        public string EtapaEdad { get; set; } // etapaEdad (length: 255)
        public string CategoriaCiclo { get; set; } // categoriaCiclo (length: 255)
        public string SubcategoriaMateria { get; set; } // subcategoriaMateria (length: 255)
        public string EdadCurso { get; set; } // edadCurso (length: 255)
    }
}