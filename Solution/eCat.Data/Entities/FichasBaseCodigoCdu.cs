namespace eCat.Data.Entities
{
    public class FichasBaseCodigoCdu
    {

        ///<summary>
        /// Calve del material al cual se le asocia el código CDU
        ///</summary>
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)

        ///<summary>
        /// Clave del CDU asociado al material
        ///</summary>
        public int IdCodigoCdu { get; set; } // IDCodigoCDU (Primary key)

        ///<summary>
        /// Línea de ascendientes con los que el código CDU está relacionado. Necesario para determinar la localización correcta del término en el árbol de códigos CDU, ya que un mismo término podría estar incluído en diferentes ramas del árbol.
        ///</summary>
        public string Clasificacion { get; set; } // Clasificacion
        public long IdFichasBaseCodigoCdu { get; set; } // IdFichasBaseCodigoCDU

        // Foreign keys

        /// <summary>
        /// Parent CodigoCdu pointed by [FichasBase_CodigoCDU].([IdCodigoCdu]) (FK_FichasBase_CodigoCDU_Codigo_CDU)
        /// </summary>
        public virtual CodigoCdu CodigoCdu { get; set; } // FK_FichasBase_CodigoCDU_Codigo_CDU

        /// <summary>
        /// Parent FichasBase pointed by [FichasBase_CodigoCDU].([IdInterno]) (FK_FichasBase_CodigoCDU_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_FichasBase_CodigoCDU_FichasBase
    }
}