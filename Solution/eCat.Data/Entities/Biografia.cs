namespace eCat.Data.Entities
{
    public class Biografia
    {

        ///<summary>
        /// Clave de la persona
        ///</summary>
        public long IdPersona { get; set; } // IDPersona (Primary key)

        ///<summary>
        /// Nombre del fichero imagen que contiene la fotografía de la persona
        ///</summary>
        public string Foto { get; set; } // Foto (length: 128)

        ///<summary>
        /// Resumen de la biografía de la persona
        ///</summary>
        public string Sinopsis { get; set; } // Sinopsis

        ///<summary>
        /// Texto de la biografía
        ///</summary>
        public string Comentarios { get; set; } // Comentarios

        // Foreign keys

        /// <summary>
        /// Parent Persona pointed by [Biografias].([IdPersona]) (FK_Biografias_Personas)
        /// </summary>
        public virtual Persona Persona { get; set; } // FK_Biografias_Personas
    }
}