namespace eCat.Data.Entities
{
    public class TMaterialesreferenciaTiposIdioma
    {
        public byte IdTipoMaterialReferencia { get; set; } // IdTipoMaterialReferencia (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_Materialesreferencia_Tipos_Idioma].([IdIdiomaInterface]) (FK_T_Materialesreferencia_Tipos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_Materialesreferencia_Tipos_Idioma_T_Idiomas_Plataforma

        /// <summary>
        /// Parent TMaterialesReferenciaTipos pointed by [T_Materialesreferencia_Tipos_Idioma].([IdTipoMaterialReferencia]) (FK_T_Materialesreferencia_Tipos_Idioma_T_MaterialesReferencia_Tipos)
        /// </summary>
        public virtual TMaterialesReferenciaTipos TMaterialesReferenciaTipos { get; set; } // FK_T_Materialesreferencia_Tipos_Idioma_T_MaterialesReferencia_Tipos
    }
}