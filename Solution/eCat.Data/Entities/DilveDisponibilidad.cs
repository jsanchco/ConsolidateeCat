namespace eCat.Data.Entities
{
    public class DilveDisponibilidad
    {
        public byte IdDisponibilidadDilve { get; set; } // IdDisponibilidadDILVE (Primary key)
        public string CodigoDisponibilidadDilve { get; set; } // CodigoDisponibilidadDILVE (length: 2)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child EstadosSaps (Many-to-Many) mapped by table [DILVE_Disponibilidad_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<EstadosSap> EstadosSaps { get; set; } // Many to many mapping
        /// <summary>
        /// Child FichasBases where [FichasBase].[IdDisponibilidadDILVE] point to this entity (FK_FichasBase_DILVE_Disponibilidad)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_DILVE_Disponibilidad

        public DilveDisponibilidad()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            EstadosSaps = new System.Collections.Generic.List<EstadosSap>();
        }
    }
}