namespace eCat.Data.Entities
{
    public class TActualizacionesEstadosMaterialesIdioma
    {
        public byte IdEstadoActualizacionMaterial { get; set; } // IdEstadoActualizacionMaterial (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TActualizacionesEstadosMateriale pointed by [T_Actualizaciones_Estados_Materiales_Idioma].([IdEstadoActualizacionMaterial]) (FK_T_Actualizaciones_Estados_Materiales_Idioma_T_Actualizaciones_Estados_Materiales)
        /// </summary>
        public virtual TActualizacionesEstadosMateriale TActualizacionesEstadosMateriale { get; set; } // FK_T_Actualizaciones_Estados_Materiales_Idioma_T_Actualizaciones_Estados_Materiales

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_Actualizaciones_Estados_Materiales_Idioma].([IdIdiomaInterface]) (FK_T_Actualizaciones_Estados_Materiales_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_Actualizaciones_Estados_Materiales_Idioma_T_Idiomas_Plataforma
    }
}