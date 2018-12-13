namespace eCat.Data.Entities
{
    public class TProyectosGestion
    {
        public int IdProyectoGestion { get; set; } // IdProyectoGestion (Primary key)
        public string CodigoProyectoGestion { get; set; } // CodigoProyectoGestion (length: 30)
        public string ProyectoGestion { get; set; } // ProyectoGestion (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child FichasBases where [FichasBase].[IdProyectoGestion] point to this entity (FK_FichasBase_T_ProyectosGestion)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_T_ProyectosGestion
        /// <summary>
        /// Child LineaNegocios (Many-to-Many) mapped by table [T_ProyectosGestion_LineaNegocio]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<LineaNegocio> LineaNegocios { get; set; } // Many to many mapping
        /// <summary>
        /// Child TProyectosGestionIdiomas where [T_ProyectosGestion_Idioma].[IdProyectoGestion] point to this entity (FK_T_ProyectosGestion_Idioma_T_ProyectosGestion)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TProyectosGestionIdioma> TProyectosGestionIdiomas { get; set; } // T_ProyectosGestion_Idioma.FK_T_ProyectosGestion_Idioma_T_ProyectosGestion

        public TProyectosGestion()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            TProyectosGestionIdiomas = new System.Collections.Generic.List<TProyectosGestionIdioma>();
            LineaNegocios = new System.Collections.Generic.List<LineaNegocio>();
        }
    }
}