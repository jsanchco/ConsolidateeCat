namespace eCat.Data.Entities
{
    public class TFichasBaseMaterialesReferencia
    {
        public string IdInterno { get; set; } // IdInterno (Primary key) (length: 12)
        public byte IdTipoMaterialReferencia { get; set; } // IdTipoMaterialReferencia (Primary key)
        public string IdInternoReferencia { get; set; } // IdInternoReferencia (Primary key) (length: 12)

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [T_FichasBase_MaterialesReferencia].([IdInterno]) (FK_T_FichasBase_MaterialesReferencia_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase_IdInterno { get; set; } // FK_T_FichasBase_MaterialesReferencia_FichasBase

        /// <summary>
        /// Parent FichasBase pointed by [T_FichasBase_MaterialesReferencia].([IdInternoReferencia]) (FK_T_FichasBase_MaterialesReferencia_FichasBase1)
        /// </summary>
        public virtual FichasBase FichasBase_IdInternoReferencia { get; set; } // FK_T_FichasBase_MaterialesReferencia_FichasBase1

        /// <summary>
        /// Parent TMaterialesReferenciaTipos pointed by [T_FichasBase_MaterialesReferencia].([IdTipoMaterialReferencia]) (FK_T_FichasBase_MaterialesReferencia_T_MaterialesReferencia_Tipos)
        /// </summary>
        public virtual TMaterialesReferenciaTipos TMaterialesReferenciaTipos { get; set; } // FK_T_FichasBase_MaterialesReferencia_T_MaterialesReferencia_Tipos
    }
}