namespace eCat.Data.Entities
{
    public class TitulosAfine
    {

        ///<summary>
        /// Clave del material relacionado
        ///</summary>
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)

        ///<summary>
        /// Orden en que se ha de mostrar los materiales afines en las aplicaciones de explotación
        ///</summary>
        public byte Orden { get; set; } // Orden

        ///<summary>
        /// Clave del material afín realcionado
        ///</summary>
        public string IdObraAfin { get; set; } // IDObraAfin (Primary key) (length: 12)
        public byte IdTipoTituloAfin { get; set; } // IdTipoTituloAfin (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [TitulosAfines].([IdInterno]) (FK_TitulosAfines_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_TitulosAfines_FichasBase

        /// <summary>
        /// Parent TTiposTituloAfin pointed by [TitulosAfines].([IdTipoTituloAfin]) (FK_TitulosAfines_T_TiposTituloAfin)
        /// </summary>
        public virtual TTiposTituloAfin TTiposTituloAfin { get; set; } // FK_TitulosAfines_T_TiposTituloAfin
    }
}