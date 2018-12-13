namespace eCat.Data.Entities
{
    public class CoEditoriale
    {

        ///<summary>
        /// Identificativo único de la Coeditorial
        ///</summary>
        public int IdCoEditorial { get; set; } // IDCoEditorial (Primary key)

        ///<summary>
        /// Nombre de la CoEditorial
        ///</summary>
        public string CoEditorial { get; set; } // CoEditorial (length: 50)

        ///<summary>
        /// Dirección URL si la tiene
        ///</summary>
        public string Url { get; set; } // URL (length: 2000)

        ///<summary>
        /// True si la editorial pertenece a Grupo SM
        ///</summary>
        public bool EsEditorialGrupo { get; set; } // EsEditorialGrupo
        public byte? PorcentajeCoedicion { get; set; } // PorcentajeCoedicion

        // Reverse navigation

        /// <summary>
        /// Child FichasBases where [FichasBase].[Coeditorial] point to this entity (FK_FichasBase_CoEditoriales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_CoEditoriales

        public CoEditoriale()
        {
            EsEditorialGrupo = false;
            FichasBases = new System.Collections.Generic.List<FichasBase>();
        }
    }
}