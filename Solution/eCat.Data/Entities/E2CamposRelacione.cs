namespace eCat.Data.Entities
{
    public class E2CamposRelacione
    {
        public long IdCampoRelacion { get; set; } // IdCampoRelacion (Primary key)
        public byte CodConsulta { get; set; } // COD_CONSULTA
        public string CodCampo { get; set; } // COD_CAMPO (length: 25)
        public string Tabla { get; set; } // TABLA (length: 100)
        public string CampoTabla { get; set; } // CAMPO_TABLA (length: 100)
        public string TablaRelacion { get; set; } // TABLA_RELACION (length: 100)
        public string CampoRelacion { get; set; } // CAMPO_RELACION (length: 100)
        public byte Nivel { get; set; } // NIVEL
        public string Comparacion { get; set; } // COMPARACION (length: 10)

        // Foreign keys

        /// <summary>
        /// Parent E2CamposConsulta pointed by [E2_CAMPOS_RELACIONES].([CodCampo]) (FK_E2_CAMPOS_RELACIONES_E2_CAMPOS_CONSULTA)
        /// </summary>
        public virtual E2CamposConsulta E2CamposConsulta { get; set; } // FK_E2_CAMPOS_RELACIONES_E2_CAMPOS_CONSULTA

        public E2CamposRelacione()
        {
            Comparacion = "=";
        }
    }
}