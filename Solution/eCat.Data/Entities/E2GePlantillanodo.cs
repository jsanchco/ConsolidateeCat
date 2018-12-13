namespace eCat.Data.Entities
{
    public class E2GePlantillanodo
    {

        ///<summary>
        /// Clave de la plantilla
        ///</summary>
        public int IdPlantilla { get; set; } // ID_PLANTILLA (Primary key)

        ///<summary>
        /// Nombre de la plantilla
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 128)

        ///<summary>
        /// Nombre del fichero que contiene la estructura de la plantilla
        ///</summary>
        public string NombreFichero { get; set; } // NombreFichero (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child E2GeRamasarbol where [E2_GE_RAMASARBOL].[ID_PLANTILLA] point to this entity (FK_E2_GE_RAMASARBOL_E2_GE_PLANTILLANODO)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2GeRamasarbol> E2GeRamasarbol { get; set; } // E2_GE_RAMASARBOL.FK_E2_GE_RAMASARBOL_E2_GE_PLANTILLANODO

        public E2GePlantillanodo()
        {
            E2GeRamasarbol = new System.Collections.Generic.List<E2GeRamasarbol>();
        }
    }
}