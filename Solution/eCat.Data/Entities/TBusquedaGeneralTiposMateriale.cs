namespace eCat.Data.Entities
{
    public class TBusquedaGeneralTiposMateriale
    {
        public byte IdTipoMaterialBusqueda { get; set; } // IdTipoMaterialBusqueda (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child TBusquedaGeneralTiposMaterialesIdiomas where [T_BusquedaGeneral_TiposMateriales_Idioma].[IdTipoMaterialBusqueda] point to this entity (FK_T_BusquedaGeneral_TiposMateriales_Idioma_T_BusquedaGeneral_TiposMateriales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TBusquedaGeneralTiposMaterialesIdioma> TBusquedaGeneralTiposMaterialesIdiomas { get; set; } // T_BusquedaGeneral_TiposMateriales_Idioma.FK_T_BusquedaGeneral_TiposMateriales_Idioma_T_BusquedaGeneral_TiposMateriales
        /// <summary>
        /// Child TTiposMateriales where [T_TiposMateriales].[IdTipoMaterialBusqueda] point to this entity (FK_T_TiposMateriales_T_BusquedaGeneral_TiposMateriales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposMateriale> TTiposMateriales { get; set; } // T_TiposMateriales.FK_T_TiposMateriales_T_BusquedaGeneral_TiposMateriales

        public TBusquedaGeneralTiposMateriale()
        {
            TBusquedaGeneralTiposMaterialesIdiomas = new System.Collections.Generic.List<TBusquedaGeneralTiposMaterialesIdioma>();
            TTiposMateriales = new System.Collections.Generic.List<TTiposMateriale>();
        }
    }
}