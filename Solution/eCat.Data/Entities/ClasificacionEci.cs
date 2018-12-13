namespace eCat.Data.Entities
{
    public class ClasificacionEci
    {

        ///<summary>
        /// Clave de la clasificación ECI
        ///</summary>
        public int IdClasificacionEci { get; set; } // IDClasificacionECI (Primary key)

        ///<summary>
        /// Clave del antecesor en el árbol de códigos ECI
        ///</summary>
        public int? IdPadre { get; set; } // IdPadre

        ///<summary>
        /// Nombre del código
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 255)

        ///<summary>
        /// Código de la clasificación de  El Corte Inglés
        ///</summary>
        public string Codigo { get; set; } // Codigo (length: 255)

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
        /// Parent (One-to-One) ClasificacionEci pointed by [DILVE_ClasificacionBIC_Equivalencias_SchemeIdentifier].[IdClasificacionBIC] (FK_DILVE_ClasificacionBIC_Equivalencias_SchemeIdentifier_Clasificacion_ECI)
        /// </summary>
        public virtual DilveClasificacionBicEquivalenciasSchemeIdentifier DilveClasificacionBicEquivalenciasSchemeIdentifier { get; set; } // DILVE_ClasificacionBIC_Equivalencias_SchemeIdentifier.FK_DILVE_ClasificacionBIC_Equivalencias_SchemeIdentifier_Clasificacion_ECI
        /// <summary>
        /// Child BookmasterBisacs (Many-to-Many) mapped by table [BOOKMASTER_Bisac_Bic_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<BookmasterBisac> BookmasterBisacs { get; set; } // Many to many mapping
        /// <summary>
        /// Child FichasBaseClasificacionEcis where [FichasBase_ClasificacionECI].[IDCLasificacionECI] point to this entity (FK_FichasBase_ClasificacionECI_Clasificacion_ECI)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBaseClasificacionEci> FichasBaseClasificacionEcis { get; set; } // FichasBase_ClasificacionECI.FK_FichasBase_ClasificacionECI_Clasificacion_ECI

        public ClasificacionEci()
        {
            Nivelador = false;
            FichasBaseClasificacionEcis = new System.Collections.Generic.List<FichasBaseClasificacionEci>();
            BookmasterBisacs = new System.Collections.Generic.List<BookmasterBisac>();
        }
    }
}