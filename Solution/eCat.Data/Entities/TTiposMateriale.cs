namespace eCat.Data.Entities
{
    public class TTiposMateriale
    {
        public short IdTipoMaterial { get; set; } // IdTipoMaterial (Primary key)
        public string CodigoTipoMaterial { get; set; } // CodigoTipoMaterial (length: 5)
        public string TipoMaterial { get; set; } // TipoMaterial (length: 50)
        public string Prefijo { get; set; } // Prefijo (length: 1)
        public byte IdTipoMaterialBusqueda { get; set; } // IdTipoMaterialBusqueda
        public bool RevisarStock { get; set; } // RevisarStock
        public bool Digital { get; set; } // Digital

        // Reverse navigation

        /// <summary>
        /// Child FichasBases where [FichasBase].[IdTipoMaterialSAP] point to this entity (FK_FichasBase_T_TiposMateriales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_T_TiposMateriales
        /// <summary>
        /// Child TTiposMaterialesGruposArticulosPrefijoes where [T_TiposMateriales_GruposArticulos_Prefijo].[IdTipoMaterial] point to this entity (FK_T_TiposMateriales_GruposArticulos_Prefijo_T_TiposMateriales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposMaterialesGruposArticulosPrefijo> TTiposMaterialesGruposArticulosPrefijoes { get; set; } // T_TiposMateriales_GruposArticulos_Prefijo.FK_T_TiposMateriales_GruposArticulos_Prefijo_T_TiposMateriales
        /// <summary>
        /// Child TTiposMaterialesIdiomas where [T_TiposMateriales_Idioma].[IdTipoMaterial] point to this entity (FK_T_TiposMateriales_Idioma_T_TiposMateriales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposMaterialesIdioma> TTiposMaterialesIdiomas { get; set; } // T_TiposMateriales_Idioma.FK_T_TiposMateriales_Idioma_T_TiposMateriales

        // Foreign keys

        /// <summary>
        /// Parent TBusquedaGeneralTiposMateriale pointed by [T_TiposMateriales].([IdTipoMaterialBusqueda]) (FK_T_TiposMateriales_T_BusquedaGeneral_TiposMateriales)
        /// </summary>
        public virtual TBusquedaGeneralTiposMateriale TBusquedaGeneralTiposMateriale { get; set; } // FK_T_TiposMateriales_T_BusquedaGeneral_TiposMateriales

        public TTiposMateriale()
        {
            RevisarStock = true;
            Digital = false;
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            TTiposMaterialesGruposArticulosPrefijoes = new System.Collections.Generic.List<TTiposMaterialesGruposArticulosPrefijo>();
            TTiposMaterialesIdiomas = new System.Collections.Generic.List<TTiposMaterialesIdioma>();
        }
    }
}