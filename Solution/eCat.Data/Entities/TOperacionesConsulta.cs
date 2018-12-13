namespace eCat.Data.Entities
{
    public class TOperacionesConsulta
    {
        public byte IdOperacion { get; set; } // IdOperacion (Primary key)
        public string Operacion { get; set; } // Operacion (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child TOperacionesConsultasIdiomas where [T_OperacionesConsultas_Idioma].[IdOperacion] point to this entity (FK_T_OperacionesConsultas_Idioma_T_OperacionesConsultas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TOperacionesConsultasIdioma> TOperacionesConsultasIdiomas { get; set; } // T_OperacionesConsultas_Idioma.FK_T_OperacionesConsultas_Idioma_T_OperacionesConsultas
        /// <summary>
        /// Child TTiposCamposConsultas (Many-to-Many) mapped by table [T_TiposCampos_Operaciones_Consultas]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposCamposConsulta> TTiposCamposConsultas { get; set; } // Many to many mapping

        public TOperacionesConsulta()
        {
            TOperacionesConsultasIdiomas = new System.Collections.Generic.List<TOperacionesConsultasIdioma>();
            TTiposCamposConsultas = new System.Collections.Generic.List<TTiposCamposConsulta>();
        }
    }
}