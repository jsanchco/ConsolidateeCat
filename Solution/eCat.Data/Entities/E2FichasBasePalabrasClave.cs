namespace eCat.Data.Entities
{
    public class E2FichasBasePalabrasClave
    {
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)
        public string IdPalabra { get; set; } // IDPalabra (Primary key) (length: 6)
        public int? Orden { get; set; } // Orden

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [E2_FichasBase_PalabrasClave].([IdInterno]) (FK_E2_FichasBase_PalabrasClave_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_E2_FichasBase_PalabrasClave_FichasBase

        /// <summary>
        /// Parent PalabrasClave pointed by [E2_FichasBase_PalabrasClave].([IdPalabra]) (FK_E2_FichasBase_PalabrasClave_PalabrasClave)
        /// </summary>
        public virtual PalabrasClave PalabrasClave { get; set; } // FK_E2_FichasBase_PalabrasClave_PalabrasClave
    }
}