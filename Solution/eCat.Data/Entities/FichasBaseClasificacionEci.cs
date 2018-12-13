namespace eCat.Data.Entities
{
    public class FichasBaseClasificacionEci
    {

        ///<summary>
        /// Clave del material relacionado
        ///</summary>
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)

        ///<summary>
        /// Clave del código ECI relacionado con el material
        ///</summary>
        public int IdcLasificacionEci { get; set; } // IDCLasificacionECI (Primary key)

        ///<summary>
        /// Línea de ascendientes con los que el código ECI está relacionado. Necesario para determinar la localización correcta del término en el árbol de códigos ECI, ya que un mismo término podría estar incluído en diferentes ramas del árbol.
        ///</summary>
        public string Clasificacion { get; set; } // Clasificacion
        public long IdFichasBaseClasificacionEci { get; set; } // IdFichasBaseClasificacionECI

        // Foreign keys

        /// <summary>
        /// Parent ClasificacionEci pointed by [FichasBase_ClasificacionECI].([IdcLasificacionEci]) (FK_FichasBase_ClasificacionECI_Clasificacion_ECI)
        /// </summary>
        public virtual ClasificacionEci ClasificacionEci { get; set; } // FK_FichasBase_ClasificacionECI_Clasificacion_ECI

        /// <summary>
        /// Parent FichasBase pointed by [FichasBase_ClasificacionECI].([IdInterno]) (FK_FichasBase_ClasificacionECI_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_FichasBase_ClasificacionECI_FichasBase
    }
}