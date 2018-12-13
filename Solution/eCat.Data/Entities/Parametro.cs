namespace eCat.Data.Entities
{
    public class Parametro
    {

        ///<summary>
        /// Nombre del parámetrp
        ///</summary>
        public string Parametro_ { get; set; } // Parametro (Primary key) (length: 50)

        ///<summary>
        /// Valor del parámetro
        ///</summary>
        public string Valor { get; set; } // Valor (length: 200)

        ///<summary>
        /// Descripción del parámetro
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 1000)

        // Reverse navigation

        /// <summary>
        /// Child E2ParametrosDominio where [E2_PARAMETROS_DOMINIO].[Parametro] point to this entity (FK_E2_PARAMETROS_DOMINIO_Parametros)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2ParametrosDominio> E2ParametrosDominio { get; set; } // E2_PARAMETROS_DOMINIO.FK_E2_PARAMETROS_DOMINIO_Parametros

        public Parametro()
        {
            E2ParametrosDominio = new System.Collections.Generic.List<E2ParametrosDominio>();
        }
    }
}