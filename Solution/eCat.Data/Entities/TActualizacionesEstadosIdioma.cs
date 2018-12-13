namespace eCat.Data.Entities
{
    public class TActualizacionesEstadosIdioma
    {
        public byte IdEstadoActualizacion { get; set; } // IdEstadoActualizacion (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TActualizacionesEstado pointed by [T_Actualizaciones_Estados_Idioma].([IdEstadoActualizacion]) (FK_T_Actualizaciones_Estados_Idioma_T_Actualizaciones_Estados)
        /// </summary>
        public virtual TActualizacionesEstado TActualizacionesEstado { get; set; } // FK_T_Actualizaciones_Estados_Idioma_T_Actualizaciones_Estados

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_Actualizaciones_Estados_Idioma].([IdIdiomaInterface]) (FK_T_Actualizaciones_Estados_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_Actualizaciones_Estados_Idioma_T_Idiomas_Plataforma
    }
}