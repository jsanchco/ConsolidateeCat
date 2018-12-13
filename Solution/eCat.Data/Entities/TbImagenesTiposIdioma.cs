namespace eCat.Data.Entities
{
    public class TbImagenesTiposIdioma
    {
        public byte IdTipoImagen { get; set; } // IdTipoImagen (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [TB_Imagenes_Tipos_Idioma].([IdIdiomaInterface]) (FK_TB_Imagenes_Tipos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_TB_Imagenes_Tipos_Idioma_T_Idiomas_Plataforma
    }
}