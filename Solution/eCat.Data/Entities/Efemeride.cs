namespace eCat.Data.Entities
{
    public class Efemeride
    {
        public int IdEfemeride { get; set; } // IDEfemeride (Primary key)
        public string Efemeride_ { get; set; } // Efemeride (length: 125)
        public byte? Dia { get; set; } // Dia
        public byte? Mes { get; set; } // Mes
        public short? Anyo { get; set; } // Anyo
        public int? IdGrupoEfemeride { get; set; } // IDGrupoEfemeride

        // Reverse navigation

        /// <summary>
        /// Child FichasBases (Many-to-Many) mapped by table [RelFichasEfemerides]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // Many to many mapping

        // Foreign keys

        /// <summary>
        /// Parent EfemeridesGrupos pointed by [Efemerides].([IdGrupoEfemeride]) (FK_Efemerides_EfemeridesGrupos)
        /// </summary>
        public virtual EfemeridesGrupos EfemeridesGrupos { get; set; } // FK_Efemerides_EfemeridesGrupos

        public Efemeride()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
        }
    }
}