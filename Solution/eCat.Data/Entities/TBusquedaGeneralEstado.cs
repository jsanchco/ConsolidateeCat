namespace eCat.Data.Entities
{
    public class TBusquedaGeneralEstado
    {
        public byte IdEstadoBusqueda { get; set; } // IdEstadoBusqueda (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child EstadosSaps where [EstadosSAP].[IdEstadoBusqueda] point to this entity (FK_EstadosSAP_T_BusquedaGeneral_Estados)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<EstadosSap> EstadosSaps { get; set; } // EstadosSAP.FK_EstadosSAP_T_BusquedaGeneral_Estados
        /// <summary>
        /// Child TBusquedaGeneralEstadosIdiomas where [T_BusquedaGeneral_Estados_Idioma].[IdEstadoBusqueda] point to this entity (FK_T_BusquedaGeneral_Estados_Idioma_T_BusquedaGeneral_Estados)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TBusquedaGeneralEstadosIdioma> TBusquedaGeneralEstadosIdiomas { get; set; } // T_BusquedaGeneral_Estados_Idioma.FK_T_BusquedaGeneral_Estados_Idioma_T_BusquedaGeneral_Estados

        public TBusquedaGeneralEstado()
        {
            EstadosSaps = new System.Collections.Generic.List<EstadosSap>();
            TBusquedaGeneralEstadosIdiomas = new System.Collections.Generic.List<TBusquedaGeneralEstadosIdioma>();
        }
    }
}