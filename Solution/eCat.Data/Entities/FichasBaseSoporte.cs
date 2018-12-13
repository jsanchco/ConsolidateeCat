namespace eCat.Data.Entities
{
    public class FichasBaseSoporte
    {
        public string IdInterno { get; set; } // IdInterno (Primary key) (length: 12)
        public byte IdSoporte { get; set; } // IdSoporte (Primary key)
        public byte Cantidad { get; set; } // Cantidad
        public byte Orden { get; set; } // Orden

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [FichasBase_Soporte].([IdInterno]) (FK_FichasBase_Soporte_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_FichasBase_Soporte_FichasBase

        /// <summary>
        /// Parent TSoporte pointed by [FichasBase_Soporte].([IdSoporte]) (FK_FichasBase_Soporte_T_Soportes)
        /// </summary>
        public virtual TSoporte TSoporte { get; set; } // FK_FichasBase_Soporte_T_Soportes
    }
}