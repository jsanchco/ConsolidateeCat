namespace eCat.Data.Entities
{
    public class TTiposCamposConsulta
    {
        public byte IdTipoCampo { get; set; } // IdTipoCampo (Primary key)
        public string TipoCampo { get; set; } // TipoCampo (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child TOperacionesConsultas (Many-to-Many) mapped by table [T_TiposCampos_Operaciones_Consultas]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TOperacionesConsulta> TOperacionesConsultas { get; set; } // Many to many mapping

        public TTiposCamposConsulta()
        {
            TOperacionesConsultas = new System.Collections.Generic.List<TOperacionesConsulta>();
        }
    }
}