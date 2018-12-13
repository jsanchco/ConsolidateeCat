namespace eCat.Data.Entities
{
    public class TSeries
    {

        ///<summary>
        /// Clave de la rerie
        ///</summary>
        public int IdSerie { get; set; } // IdSerie (Primary key)

        ///<summary>
        /// Clave de la colección a la que pertenece
        ///</summary>
        public int? IdColeccion { get; set; } // IdColeccion

        ///<summary>
        /// Nombre de la serie
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 255)

        ///<summary>
        /// Orden en el que debe aparecer la serie en aplicaciones ofimáticas o páginas Web
        ///</summary>
        public byte? Orden { get; set; } // Orden

        // Reverse navigation

        /// <summary>
        /// Child FichasBases where [FichasBase].[IdSerie] point to this entity (FK_FichasBase_T_Series)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_T_Series
        /// <summary>
        /// Child LineaNegocios (Many-to-Many) mapped by table [T_Series_LineasNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<LineaNegocio> LineaNegocios { get; set; } // Many to many mapping

        // Foreign keys

        /// <summary>
        /// Parent TColeccione pointed by [T_Series].([IdColeccion]) (FK_T_Series_T_Colecciones)
        /// </summary>
        public virtual TColeccione TColeccione { get; set; } // FK_T_Series_T_Colecciones

        public TSeries()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            LineaNegocios = new System.Collections.Generic.List<LineaNegocio>();
        }
    }
}