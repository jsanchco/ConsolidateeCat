namespace eCat.Data.Entities
{
    public class TBusquedaGeneralTiposMaterialesIdioma
    {
        public byte IdTipoMaterialBusqueda { get; set; } // IdTipoMaterialBusqueda (Primary key)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)
        public string Valor { get; set; } // Valor (length: 255)

        // Foreign keys

        /// <summary>
        /// Parent TBusquedaGeneralTiposMateriale pointed by [T_BusquedaGeneral_TiposMateriales_Idioma].([IdTipoMaterialBusqueda]) (FK_T_BusquedaGeneral_TiposMateriales_Idioma_T_BusquedaGeneral_TiposMateriales)
        /// </summary>
        public virtual TBusquedaGeneralTiposMateriale TBusquedaGeneralTiposMateriale { get; set; } // FK_T_BusquedaGeneral_TiposMateriales_Idioma_T_BusquedaGeneral_TiposMateriales
    }
}