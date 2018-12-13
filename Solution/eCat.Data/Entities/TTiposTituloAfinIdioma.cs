namespace eCat.Data.Entities
{
    public class TTiposTituloAfinIdioma
    {
        public byte IdTipoTituloAfin { get; set; } // IdTipoTituloAfin (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_TiposTituloAfin_Idioma].([IdIdiomaInterface]) (FK_T_TiposTituloAfin_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_TiposTituloAfin_Idioma_T_Idiomas_Plataforma

        /// <summary>
        /// Parent TTiposTituloAfin pointed by [T_TiposTituloAfin_Idioma].([IdTipoTituloAfin]) (FK_T_TiposTituloAfin_Idioma_T_TiposTituloAfin)
        /// </summary>
        public virtual TTiposTituloAfin TTiposTituloAfin { get; set; } // FK_T_TiposTituloAfin_Idioma_T_TiposTituloAfin
    }
}