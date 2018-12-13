namespace eCat.Data.Entities
{
    public class EfemeridesGrupos
    {
        public int IdGrupoEfemeride { get; set; } // IDGrupoEfemeride (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child Efemerides where [Efemerides].[IDGrupoEfemeride] point to this entity (FK_Efemerides_EfemeridesGrupos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Efemeride> Efemerides { get; set; } // Efemerides.FK_Efemerides_EfemeridesGrupos

        public EfemeridesGrupos()
        {
            Efemerides = new System.Collections.Generic.List<Efemeride>();
        }
    }
}