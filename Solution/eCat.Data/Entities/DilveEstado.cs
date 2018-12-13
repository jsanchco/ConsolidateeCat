namespace eCat.Data.Entities
{
    public class DilveEstado
    {
        public byte IdEstadoDilve { get; set; } // IdEstadoDILVE (Primary key)
        public string CodigoEstado { get; set; } // CodigoEstado (length: 2)
        public string Estado { get; set; } // Estado (length: 30)

        // Reverse navigation

        /// <summary>
        /// Child EstadosSaps (Many-to-Many) mapped by table [DILVE_Estados_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<EstadosSap> EstadosSaps { get; set; } // Many to many mapping

        public DilveEstado()
        {
            EstadosSaps = new System.Collections.Generic.List<EstadosSap>();
        }
    }
}