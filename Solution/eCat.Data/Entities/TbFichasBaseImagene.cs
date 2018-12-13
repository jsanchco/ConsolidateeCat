namespace eCat.Data.Entities
{
    public class TbFichasBaseImagene
    {

        ///<summary>
        /// Clave de la imagen relacionada
        ///</summary>
        public long IdFichasBaseImagen { get; set; } // IdFichasBaseImagen (Primary key)

        ///<summary>
        /// Clave del material con el que se relaciona
        ///</summary>
        public string IdInterno { get; set; } // IdInterno (length: 12)

        ///<summary>
        /// Clave del tipo de imagen
        ///</summary>
        public byte IdTipoImagen { get; set; } // IdTipoImagen

        ///<summary>
        /// Descripción de la imagen
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 255)

        ///<summary>
        /// Path del fichero de imagen
        ///</summary>
        public string Fichero { get; set; } // Fichero (length: 255)

        ///<summary>
        /// Pie de imagen a mostrar en las aplicaciones de explotación
        ///</summary>
        public string Pie { get; set; } // Pie

        ///<summary>
        /// True = indica que es la imagen a mostrar por defecto en la ficha del material asociado en una aplicación de explotación
        ///</summary>
        public bool Defecto { get; set; } // Defecto

        ///<summary>
        /// True = Indica que la imagen proviene de un servicio automático de generación de imágenes
        ///</summary>
        public bool Automatico { get; set; } // Automatico

        ///<summary>
        /// 1 - Alta Calidad, Otros - Baja calidad
        ///</summary>
        public byte Calidad { get; set; } // Calidad

        ///<summary>
        /// True = La imagen no puede ser utilizada
        ///</summary>
        public bool Baja { get; set; } // Baja

        ///<summary>
        /// Clave de la imagen relacionada
        ///</summary>
        public long? IdFichasBaseImagenOrigen { get; set; } // IdFichasBaseImagenOrigen
        public System.DateTime? FechaCreacion { get; set; } // FechaCreacion

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [TB_FichasBase_Imagenes].([IdInterno]) (FK_TB_FichasBase_Imagenes_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_TB_FichasBase_Imagenes_FichasBase

        /// <summary>
        /// Parent TbImagenesTipos pointed by [TB_FichasBase_Imagenes].([IdTipoImagen]) (FK_TB_FichasBase_Imagenes_TB_Imagenes_Tipos)
        /// </summary>
        public virtual TbImagenesTipos TbImagenesTipos { get; set; } // FK_TB_FichasBase_Imagenes_TB_Imagenes_Tipos

        public TbFichasBaseImagene()
        {
            Defecto = false;
            Automatico = false;
            Calidad = 0;
            Baja = false;
            FechaCreacion = System.DateTime.Now;
        }
    }
}