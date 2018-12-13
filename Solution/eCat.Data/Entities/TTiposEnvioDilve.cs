namespace eCat.Data.Entities
{
    public class TTiposEnvioDilve
    {
        public byte IdTipoEnvioDilve { get; set; } // IdTipoEnvioDILVE (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child TFichasBaseDilveXmls where [T_FichasBase_DILVE_Xml].[IdTipoEnvioDILVE] point to this entity (FK_T_FichasBase_DILVE_Xml_T_TiposEnvio_DILVE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseDilveXml> TFichasBaseDilveXmls { get; set; } // T_FichasBase_DILVE_Xml.FK_T_FichasBase_DILVE_Xml_T_TiposEnvio_DILVE

        public TTiposEnvioDilve()
        {
            TFichasBaseDilveXmls = new System.Collections.Generic.List<TFichasBaseDilveXml>();
        }
    }
}