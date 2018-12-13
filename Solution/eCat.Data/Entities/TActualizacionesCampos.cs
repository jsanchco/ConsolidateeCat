namespace eCat.Data.Entities
{
    public class TActualizacionesCampos
    {
        public string CodigoCampoActualizacion { get; set; } // CodigoCampoActualizacion (Primary key) (length: 10)
        public string Campo { get; set; } // Campo (length: 100)
        public byte IdTipoCampoActualizacion { get; set; } // IdTipoCampoActualizacion
        public bool BModificar { get; set; } // bModificar
        public bool BAñadir { get; set; } // bAñadir
        public bool BVaciar { get; set; } // bVaciar
        public bool BEliminar { get; set; } // bEliminar
        public string ConsultaValores { get; set; } // ConsultaValores

        // Reverse navigation

        /// <summary>
        /// Child TActualizacionesCabeceras where [T_Actualizaciones_Cabecera].[CodigoCampoActualizacion] point to this entity (FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Campos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesCabecera> TActualizacionesCabeceras { get; set; } // T_Actualizaciones_Cabecera.FK_T_Actualizaciones_Cabecera_T_Actualizaciones_Campos
        /// <summary>
        /// Child TActualizacionesCamposIdiomas where [T_Actualizaciones_Campos_Idiomas].[CodigoCampoActualizacion] point to this entity (FK_T_Actualizaciones_Campos_Idiomas_T_Actualizaciones_Campos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TActualizacionesCamposIdioma> TActualizacionesCamposIdiomas { get; set; } // T_Actualizaciones_Campos_Idiomas.FK_T_Actualizaciones_Campos_Idiomas_T_Actualizaciones_Campos

        // Foreign keys

        /// <summary>
        /// Parent TActualizacionesTiposCampo pointed by [T_Actualizaciones_Campos].([IdTipoCampoActualizacion]) (FK_T_Actualizaciones_Campos_T_Actualizaciones_TiposCampo)
        /// </summary>
        public virtual TActualizacionesTiposCampo TActualizacionesTiposCampo { get; set; } // FK_T_Actualizaciones_Campos_T_Actualizaciones_TiposCampo

        public TActualizacionesCampos()
        {
            BModificar = true;
            BAñadir = false;
            BVaciar = false;
            BEliminar = false;
            TActualizacionesCabeceras = new System.Collections.Generic.List<TActualizacionesCabecera>();
            TActualizacionesCamposIdiomas = new System.Collections.Generic.List<TActualizacionesCamposIdioma>();
        }
    }
}