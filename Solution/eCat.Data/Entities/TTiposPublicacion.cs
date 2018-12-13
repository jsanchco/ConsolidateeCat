namespace eCat.Data.Entities
{
    public class TTiposPublicacion
    {
        public byte IdTipoPublicacion { get; set; } // IdTipoPublicacion (Primary key)
        public string TipoPublicacion { get; set; } // TipoPublicacion (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child FichasBases where [FichasBase].[IdTipoPublicacion] point to this entity (FK_FichasBase_T_TiposPublicacion)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_T_TiposPublicacion

        public TTiposPublicacion()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
        }
    }
}