namespace eCat.Data.Entities
{
    public class TBusquedaGeneralEstadosIdioma
    {
        public byte IdEstadoBusqueda { get; set; } // IdEstadoBusqueda (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TBusquedaGeneralEstado pointed by [T_BusquedaGeneral_Estados_Idioma].([IdEstadoBusqueda]) (FK_T_BusquedaGeneral_Estados_Idioma_T_BusquedaGeneral_Estados)
        /// </summary>
        public virtual TBusquedaGeneralEstado TBusquedaGeneralEstado { get; set; } // FK_T_BusquedaGeneral_Estados_Idioma_T_BusquedaGeneral_Estados
    }
}