namespace eCat.Data.Entities
{
    public class E2GeTiponodo
    {

        ///<summary>
        /// Clave del tipo de nodo
        ///</summary>
        public int IdTiponodo { get; set; } // ID_TIPONODO (Primary key)

        ///<summary>
        /// Nombre del tipo de nodo
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child E2GeRamasarbol where [E2_GE_RAMASARBOL].[ID_TIPONODO] point to this entity (FK_E2_GE_RAMASARBOL_E2_GE_TIPONODO)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2GeRamasarbol> E2GeRamasarbol { get; set; } // E2_GE_RAMASARBOL.FK_E2_GE_RAMASARBOL_E2_GE_TIPONODO

        public E2GeTiponodo()
        {
            E2GeRamasarbol = new System.Collections.Generic.List<E2GeRamasarbol>();
        }
    }
}