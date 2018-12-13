namespace eCat.Data.Entities
{
    public class FichasAplicacion
    {
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)
        public string IdAplicacion { get; set; } // IDAplicacion (Primary key) (length: 5)
        public string Sinopsis { get; set; } // Sinopsis
        public string Resumen { get; set; } // Resumen
        public string Indice { get; set; } // Indice
        public string Caracteristicas { get; set; } // Caracteristicas
        public string MaterialComunicacion { get; set; } // MaterialComunicacion
        public string InformacionAdicional { get; set; } // InformacionAdicional

        // Foreign keys

        /// <summary>
        /// Parent Aplicacione pointed by [FichasAplicacion].([IdAplicacion]) (FK_FichasAplicacion_Aplicaciones)
        /// </summary>
        public virtual Aplicacione Aplicacione { get; set; } // FK_FichasAplicacion_Aplicaciones

        /// <summary>
        /// Parent FichasBase pointed by [FichasAplicacion].([IdInterno]) (FK_FichasAplicacion_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_FichasAplicacion_FichasBase
    }
}