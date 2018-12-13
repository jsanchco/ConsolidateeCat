namespace eCat.Data.Entities
{
    public class DilveSituacionCatalogoEditorial
    {
        public byte IdSituacion { get; set; } // IdSituacion (Primary key)
        public string CodigoSituacion { get; set; } // CodigoSituacion (length: 2)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child EstadosSaps (Many-to-Many) mapped by table [DILVE_SituacionCatalogoEditorial_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<EstadosSap> EstadosSaps { get; set; } // Many to many mapping

        public DilveSituacionCatalogoEditorial()
        {
            EstadosSaps = new System.Collections.Generic.List<EstadosSap>();
        }
    }
}