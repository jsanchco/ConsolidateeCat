namespace eCat.Data.Entities
{
    public class E2ParametrosDominio
    {

        ///<summary>
        /// Clave del dominio
        ///</summary>
        public string Dominio { get; set; } // Dominio (Primary key) (length: 50)

        ///<summary>
        /// Nombre del parámetro
        ///</summary>
        public string Parametro { get; set; } // Parametro (Primary key) (length: 50)

        ///<summary>
        /// Valor del parámetro para ese el dominio especificado
        ///</summary>
        public string Valor { get; set; } // Valor (length: 200)

        ///<summary>
        /// Descripción del parámetro
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 1000)

        // Foreign keys

        /// <summary>
        /// Parent Parametro pointed by [E2_PARAMETROS_DOMINIO].([Parametro]) (FK_E2_PARAMETROS_DOMINIO_Parametros)
        /// </summary>
        public virtual Parametro Parametro_Parametro { get; set; } // FK_E2_PARAMETROS_DOMINIO_Parametros
    }
}