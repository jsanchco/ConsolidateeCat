namespace eCat.Data.Entities
{
    public class TFichasBaseDilveXml
    {
        public string IdInterno { get; set; } // IdInterno (Primary key) (length: 12)
        public string XmlDilve { get; set; } // XmlDILVE
        public string Comentarios { get; set; } // Comentarios
        public System.DateTime Fecha { get; set; } // Fecha
        public byte IdTipoEnvioDilve { get; set; } // IdTipoEnvioDILVE

        // Foreign keys

        /// <summary>
        /// Parent TTiposEnvioDilve pointed by [T_FichasBase_DILVE_Xml].([IdTipoEnvioDilve]) (FK_T_FichasBase_DILVE_Xml_T_TiposEnvio_DILVE)
        /// </summary>
        public virtual TTiposEnvioDilve TTiposEnvioDilve { get; set; } // FK_T_FichasBase_DILVE_Xml_T_TiposEnvio_DILVE

        public TFichasBaseDilveXml()
        {
            Fecha = System.DateTime.Now;
            IdTipoEnvioDilve = 1;
        }
    }
}