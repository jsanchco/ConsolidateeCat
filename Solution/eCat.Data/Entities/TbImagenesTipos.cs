namespace eCat.Data.Entities
{
    public class TbImagenesTipos
    {

        ///<summary>
        /// Clave del tipo de imágen
        ///</summary>
        public byte IdTipoImagen { get; set; } // IdTipoImagen (Primary key)

        ///<summary>
        /// Nombre del tipo de imágen
        ///</summary>
        public string TipoImagen { get; set; } // TipoImagen (length: 50)

        ///<summary>
        /// True = Tipo de imágen no utilizable
        ///</summary>
        public bool Baja { get; set; } // Baja
        public bool Redimensionar3 { get; set; } // Redimensionar3

        // Reverse navigation

        /// <summary>
        /// Child TbFichasBaseImagenes where [TB_FichasBase_Imagenes].[IdTipoImagen] point to this entity (FK_TB_FichasBase_Imagenes_TB_Imagenes_Tipos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbFichasBaseImagene> TbFichasBaseImagenes { get; set; } // TB_FichasBase_Imagenes.FK_TB_FichasBase_Imagenes_TB_Imagenes_Tipos

        public TbImagenesTipos()
        {
            Baja = false;
            Redimensionar3 = false;
            TbFichasBaseImagenes = new System.Collections.Generic.List<TbFichasBaseImagene>();
        }
    }
}