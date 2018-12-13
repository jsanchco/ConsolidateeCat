namespace eCat.Data.Entities
{
    public class TiposArticulo
    {

        ///<summary>
        /// Clave del tipo de artículo
        ///</summary>
        public byte IdTipoArticulo { get; set; } // IDTipoArticulo (Primary key)

        ///<summary>
        /// Nombre del tipo de artículo
        ///</summary>
        public string TipoArticulo { get; set; } // TipoArticulo (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child FichasBases where [FichasBase].[IDTipoArticulo] point to this entity (FK_FichasBase_TiposArticulos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_TiposArticulos

        public TiposArticulo()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
        }
    }
}