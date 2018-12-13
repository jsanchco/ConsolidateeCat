namespace eCat.Data.Entities
{
    public class E2CamposConsultaIdioma
    {
        public string CodCampo { get; set; } // COD_CAMPO (Primary key) (length: 25)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent E2CamposConsulta pointed by [E2_CAMPOS_CONSULTA_Idioma].([CodCampo]) (FK_E2_CAMPOS_CONSULTA_Idioma_E2_CAMPOS_CONSULTA)
        /// </summary>
        public virtual E2CamposConsulta E2CamposConsulta { get; set; } // FK_E2_CAMPOS_CONSULTA_Idioma_E2_CAMPOS_CONSULTA

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [E2_CAMPOS_CONSULTA_Idioma].([IdIdiomaInterface]) (FK_E2_CAMPOS_CONSULTA_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_E2_CAMPOS_CONSULTA_Idioma_T_Idiomas_Plataforma
    }
}