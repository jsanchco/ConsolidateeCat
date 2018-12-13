namespace eCat.Data.Entities
{
    public class TMaterialesReferenciaTipos
    {
        public byte IdTipoMaterialReferencia { get; set; } // IdTipoMaterialReferencia (Primary key)
        public string TipoMaterialReferencia { get; set; } // TipoMaterialReferencia (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child TFichasBaseMaterialesReferencias where [T_FichasBase_MaterialesReferencia].[IdTipoMaterialReferencia] point to this entity (FK_T_FichasBase_MaterialesReferencia_T_MaterialesReferencia_Tipos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseMaterialesReferencia> TFichasBaseMaterialesReferencias { get; set; } // T_FichasBase_MaterialesReferencia.FK_T_FichasBase_MaterialesReferencia_T_MaterialesReferencia_Tipos
        /// <summary>
        /// Child TMaterialesreferenciaTiposIdiomas where [T_Materialesreferencia_Tipos_Idioma].[IdTipoMaterialReferencia] point to this entity (FK_T_Materialesreferencia_Tipos_Idioma_T_MaterialesReferencia_Tipos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TMaterialesreferenciaTiposIdioma> TMaterialesreferenciaTiposIdiomas { get; set; } // T_Materialesreferencia_Tipos_Idioma.FK_T_Materialesreferencia_Tipos_Idioma_T_MaterialesReferencia_Tipos

        public TMaterialesReferenciaTipos()
        {
            TFichasBaseMaterialesReferencias = new System.Collections.Generic.List<TFichasBaseMaterialesReferencia>();
            TMaterialesreferenciaTiposIdiomas = new System.Collections.Generic.List<TMaterialesreferenciaTiposIdioma>();
        }
    }
}