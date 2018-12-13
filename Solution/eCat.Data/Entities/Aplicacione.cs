namespace eCat.Data.Entities
{
    public class Aplicacione
    {

        ///<summary>
        /// Identificación de aplicación
        ///</summary>
        public string IdAplicacion { get; set; } // IDAplicacion (Primary key) (length: 5)

        ///<summary>
        /// Nombre de aplicación
        ///</summary>
        public string Aplicacion { get; set; } // Aplicacion (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child FichasAplicacions where [FichasAplicacion].[IDAplicacion] point to this entity (FK_FichasAplicacion_Aplicaciones)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasAplicacion> FichasAplicacions { get; set; } // FichasAplicacion.FK_FichasAplicacion_Aplicaciones
        /// <summary>
        /// Child PublicoObjetivoes where [PublicoObjetivo].[IDAplicacion] point to this entity (FK_PublicoObjetivo_Aplicaciones)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PublicoObjetivo> PublicoObjetivoes { get; set; } // PublicoObjetivo.FK_PublicoObjetivo_Aplicaciones

        public Aplicacione()
        {
            FichasAplicacions = new System.Collections.Generic.List<FichasAplicacion>();
            PublicoObjetivoes = new System.Collections.Generic.List<PublicoObjetivo>();
        }
    }
}