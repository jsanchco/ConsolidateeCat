namespace eCat.Data.Entities
{
    public class Idioma
    {

        ///<summary>
        /// Clave del idioma
        ///</summary>
        public byte IdIdioma { get; set; } // IDIdioma (Primary key)

        ///<summary>
        /// Código del idioma
        ///</summary>
        public string Codigo { get; set; } // Codigo (length: 3)

        ///<summary>
        /// Nombre del idioma en castellano
        ///</summary>
        public string Es { get; set; } // ES (length: 50)

        ///<summary>
        /// Nombre del idioma en catalán
        ///</summary>
        public string Cat { get; set; } // CAT (length: 50)

        ///<summary>
        /// Nombre del idioma en inglés
        ///</summary>
        public string En { get; set; } // EN (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child DilveIdiomas (Many-to-Many) mapped by table [DILVE_Idiomas_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveIdioma> DilveIdiomas { get; set; } // Many to many mapping
        /// <summary>
        /// Child FichasBases where [FichasBase].[Idioma] point to this entity (FK_FichasBase_Idiomas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_Idiomas
        /// <summary>
        /// Child FichasBaseIdiomasSecundarios where [FichasBase_IdiomasSecundarios].[IdIdioma] point to this entity (FK_FichasBase_IdiomasSecundarios_Idiomas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseIdiomasSecundario> FichasBaseIdiomasSecundarios { get; set; } // FichasBase_IdiomasSecundarios.FK_FichasBase_IdiomasSecundarios_Idiomas

        public Idioma()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            FichasBaseIdiomasSecundarios = new System.Collections.Generic.List<FichasBaseIdiomasSecundario>();
            DilveIdiomas = new System.Collections.Generic.List<DilveIdioma>();
        }
    }
}