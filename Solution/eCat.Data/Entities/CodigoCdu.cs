namespace eCat.Data.Entities
{
    public class CodigoCdu
    {

        ///<summary>
        /// Clave del código
        ///</summary>
        public int IdCodigoCdu { get; set; } // IDCodigoCDU (Primary key)

        ///<summary>
        /// Clave del antecesor del código en el árbol de códigos
        ///</summary>
        public int? IdPadre { get; set; } // IDPadre

        ///<summary>
        /// Nombre del código
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 256)

        ///<summary>
        /// Código de la clasificación universal
        ///</summary>
        public string Codigo { get; set; } // Codigo (length: 256)

        ///<summary>
        /// Orden del código en aplicaciones ofimáticas o páginas Web en la presentación del árbol de códigos
        ///</summary>
        public int? Orden { get; set; } // Orden

        ///<summary>
        /// No usado
        ///</summary>
        public bool Nivelador { get; set; } // Nivelador

        // Reverse navigation

        /// <summary>
        /// Child FichasBaseCodigoCdus where [FichasBase_CodigoCDU].[IDCodigoCDU] point to this entity (FK_FichasBase_CodigoCDU_Codigo_CDU)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseCodigoCdu> FichasBaseCodigoCdus { get; set; } // FichasBase_CodigoCDU.FK_FichasBase_CodigoCDU_Codigo_CDU

        public CodigoCdu()
        {
            Nivelador = false;
            FichasBaseCodigoCdus = new System.Collections.Generic.List<FichasBaseCodigoCdu>();
        }
    }
}