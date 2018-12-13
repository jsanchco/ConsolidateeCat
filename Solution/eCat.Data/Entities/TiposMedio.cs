namespace eCat.Data.Entities
{
    public class TiposMedio
    {

        ///<summary>
        /// Clave del tipo de medio
        ///</summary>
        public int IdTipoMedio { get; set; } // IDTipoMedio (Primary key)

        ///<summary>
        /// Descripción del tipo de medio
        ///</summary>
        public string TipoMedio { get; set; } // TipoMedio (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child Medios where [Medios].[IDTipoMedio] point to this entity (FK_Medios_TiposMedios)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Medio> Medios { get; set; } // Medios.FK_Medios_TiposMedios

        public TiposMedio()
        {
            Medios = new System.Collections.Generic.List<Medio>();
        }
    }
}