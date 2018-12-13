namespace eCat.Data.Entities
{
    public class TTiposTituloAfin
    {
        public byte IdTipoTituloAfin { get; set; } // IdTipoTituloAfin (Primary key)
        public string TipoTituloAfin { get; set; } // TipoTituloAfin (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child TitulosAfines where [TitulosAfines].[IdTipoTituloAfin] point to this entity (FK_TitulosAfines_T_TiposTituloAfin)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TitulosAfine> TitulosAfines { get; set; } // TitulosAfines.FK_TitulosAfines_T_TiposTituloAfin
        /// <summary>
        /// Child TTiposTituloAfinIdiomas where [T_TiposTituloAfin_Idioma].[IdTipoTituloAfin] point to this entity (FK_T_TiposTituloAfin_Idioma_T_TiposTituloAfin)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposTituloAfinIdioma> TTiposTituloAfinIdiomas { get; set; } // T_TiposTituloAfin_Idioma.FK_T_TiposTituloAfin_Idioma_T_TiposTituloAfin

        public TTiposTituloAfin()
        {
            TTiposTituloAfinIdiomas = new System.Collections.Generic.List<TTiposTituloAfinIdioma>();
            TitulosAfines = new System.Collections.Generic.List<TitulosAfine>();
        }
    }
}