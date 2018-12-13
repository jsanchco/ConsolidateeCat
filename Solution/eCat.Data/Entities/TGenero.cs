namespace eCat.Data.Entities
{
    public class TGenero
    {
        public byte IdGenero { get; set; } // IdGenero (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 225)

        // Reverse navigation

        /// <summary>
        /// Child FichasBases where [FichasBase].[IdGenero] point to this entity (FK_FichasBase_T_Generos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_T_Generos

        public TGenero()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
        }
    }
}