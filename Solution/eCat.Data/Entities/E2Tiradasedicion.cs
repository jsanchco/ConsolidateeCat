namespace eCat.Data.Entities
{
    public class E2Tiradasedicion
    {

        ///<summary>
        /// Clave del material para el que se detalla la edición
        ///</summary>
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)

        ///<summary>
        /// Número de edición
        ///</summary>
        public byte NumeroEdicion { get; set; } // Numero_Edicion (Primary key)

        ///<summary>
        /// Número de ejemplares en la edición
        ///</summary>
        public int? Tirada { get; set; } // Tirada

        ///<summary>
        /// Fecha de la edición
        ///</summary>
        public System.DateTime? Fecha { get; set; } // Fecha
        public string DepositoLegal { get; set; } // DepositoLegal (length: 25)

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [E2_TIRADASEDICION].([IdInterno]) (FK_E2_TIRADASEDICION_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_E2_TIRADASEDICION_FichasBase
    }
}