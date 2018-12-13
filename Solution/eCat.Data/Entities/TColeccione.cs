namespace eCat.Data.Entities
{
    public class TColeccione
    {

        ///<summary>
        /// Clave de la colección
        ///</summary>
        public int IdColeccion { get; set; } // IdColeccion (Primary key)

        ///<summary>
        /// Nombre de la colección
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 255)

        ///<summary>
        /// Orden en que se debe mostrar la colección en aplicaciones ofimáticas o páginas Web
        ///</summary>
        public int? Orden { get; set; } // Orden

        // Reverse navigation

        /// <summary>
        /// Child FichasBases where [FichasBase].[IdColeccion] point to this entity (FK_FichasBase_T_Colecciones)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_T_Colecciones
        /// <summary>
        /// Child LineaNegocios (Many-to-Many) mapped by table [T_Colecciones_LineasNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<LineaNegocio> LineaNegocios { get; set; } // Many to many mapping
        /// <summary>
        /// Child TSeries where [T_Series].[IdColeccion] point to this entity (FK_T_Series_T_Colecciones)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TSeries> TSeries { get; set; } // T_Series.FK_T_Series_T_Colecciones

        public TColeccione()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            TSeries = new System.Collections.Generic.List<TSeries>();
            LineaNegocios = new System.Collections.Generic.List<LineaNegocio>();
        }
    }
}