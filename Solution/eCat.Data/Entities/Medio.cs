namespace eCat.Data.Entities
{
    public class Medio
    {

        ///<summary>
        /// Calve del medio de comunicación
        ///</summary>
        public int IdMedio { get; set; } // IDMedio (Primary key)

        ///<summary>
        /// Clave del tipo de medio al que pertenece
        ///</summary>
        public int? IdTipoMedio { get; set; } // IDTipoMedio

        ///<summary>
        /// Nombre del medio de comunicación
        ///</summary>
        public string Medio_ { get; set; } // Medio (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child Resenas where [Resenas].[IDMedio] point to this entity (FK_Resenas_Medios)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Resena> Resenas { get; set; } // Resenas.FK_Resenas_Medios

        // Foreign keys

        /// <summary>
        /// Parent TiposMedio pointed by [Medios].([IdTipoMedio]) (FK_Medios_TiposMedios)
        /// </summary>
        public virtual TiposMedio TiposMedio { get; set; } // FK_Medios_TiposMedios

        public Medio()
        {
            Resenas = new System.Collections.Generic.List<Resena>();
        }
    }
}