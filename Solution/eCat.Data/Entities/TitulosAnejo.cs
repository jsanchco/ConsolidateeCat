namespace eCat.Data.Entities
{
    public class TitulosAnejo
    {

        ///<summary>
        /// Clave del material relacionado
        ///</summary>
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)

        ///<summary>
        /// Orden en el que se quiere que aparezcan los títulos relacionados
        ///</summary>
        public byte Orden { get; set; } // Orden

        ///<summary>
        /// Clave del material ajeno relacionado
        ///</summary>
        public string IdObraAneja { get; set; } // IDObraAneja (Primary key) (length: 12)

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [TitulosAnejos].([IdInterno]) (FK_TitulosAnejos_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_TitulosAnejos_FichasBase
    }
}