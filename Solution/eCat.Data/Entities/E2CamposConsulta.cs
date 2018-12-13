namespace eCat.Data.Entities
{
    public class E2CamposConsulta
    {

        ///<summary>
        /// (0)Fichas Base (1)Fichas Aplicación (2)Catálogo (3)Auditoría
        ///</summary>
        public byte CodConsulta { get; set; } // COD_CONSULTA

        ///<summary>
        /// Nombre del campo en la base de datos
        ///</summary>
        public string CodCampo { get; set; } // COD_CAMPO (Primary key) (length: 25)

        ///<summary>
        /// Descripción del campo a mostrar
        ///</summary>
        public string DesCampo { get; set; } // DES_CAMPO (length: 100)
        public string CampoBbdd { get; set; } // CAMPO_BBDD (length: 100)

        ///<summary>
        /// (0)Texto (1)Entero (2)Decimal (3)Fecha
        ///</summary>
        public byte TipoCampo { get; set; } // TIPO_CAMPO
        public string Listasql { get; set; } // LISTASQL (length: 1000)
        public bool Aplicar { get; set; } // APLICAR
        public string CampoWhere { get; set; } // CAMPO_WHERE (length: 1000)
        public bool Mostrar { get; set; } // MOSTRAR
        public string CampoSelect { get; set; } // CAMPO_SELECT (length: 100)
        public string CampoCalculado { get; set; } // CAMPO_CALCULADO (length: 100)
        public bool EsCodigoLibro { get; set; } // EsCodigoLibro
        public int? Orden { get; set; } // Orden

        // Reverse navigation

        /// <summary>
        /// Child E2CamposConsultaIdioma where [E2_CAMPOS_CONSULTA_Idioma].[COD_CAMPO] point to this entity (FK_E2_CAMPOS_CONSULTA_Idioma_E2_CAMPOS_CONSULTA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2CamposConsultaIdioma> E2CamposConsultaIdioma { get; set; } // E2_CAMPOS_CONSULTA_Idioma.FK_E2_CAMPOS_CONSULTA_Idioma_E2_CAMPOS_CONSULTA
        /// <summary>
        /// Child E2CamposRelacione where [E2_CAMPOS_RELACIONES].[COD_CAMPO] point to this entity (FK_E2_CAMPOS_RELACIONES_E2_CAMPOS_CONSULTA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2CamposRelacione> E2CamposRelacione { get; set; } // E2_CAMPOS_RELACIONES.FK_E2_CAMPOS_RELACIONES_E2_CAMPOS_CONSULTA

        public E2CamposConsulta()
        {
            CodConsulta = 0;
            TipoCampo = 0;
            Aplicar = false;
            Mostrar = false;
            EsCodigoLibro = false;
            E2CamposConsultaIdioma = new System.Collections.Generic.List<E2CamposConsultaIdioma>();
            E2CamposRelacione = new System.Collections.Generic.List<E2CamposRelacione>();
        }
    }
}