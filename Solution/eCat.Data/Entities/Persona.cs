namespace eCat.Data.Entities
{
    public class Persona
    {

        ///<summary>
        /// Clave de la persona
        ///</summary>
        public long IdPersona { get; set; } // IDPersona (Primary key)

        ///<summary>
        /// Apellidos
        ///</summary>
        public string Apellidos { get; set; } // Apellidos (length: 255)

        ///<summary>
        /// Nombre
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 50)

        ///<summary>
        /// Nacionalidad
        ///</summary>
        public string Nacionalidad { get; set; } // Nacionalidad (length: 100)

        ///<summary>
        /// En caso de persona física, fecha de su nacimiento
        ///</summary>
        public System.DateTime? FechaNacimiento { get; set; } // FechaNacimiento

        ///<summary>
        /// En caso de persona física, fecha de su fallecimiento
        ///</summary>
        public System.DateTime? FechaFallecimiento { get; set; } // FechaFallecimiento

        ///<summary>
        /// H (Hombre) M (Mujer)
        ///</summary>
        public string Sexo { get; set; } // Sexo (length: 1)

        ///<summary>
        /// URL de la página Web oficial de la persona
        ///</summary>
        public string Url { get; set; } // URL (length: 255)

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) Persona pointed by [Biografias].[IDPersona] (FK_Biografias_Personas)
        /// </summary>
        public virtual Biografia Biografia { get; set; } // Biografias.FK_Biografias_Personas
        /// <summary>
        /// Child RelFichasPersonas where [RelFichasPersonas].[IDPersona] point to this entity (FK_RelFichasPersonas_Personas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<RelFichasPersona> RelFichasPersonas { get; set; } // RelFichasPersonas.FK_RelFichasPersonas_Personas
        /// <summary>
        /// Child TPersonasReferenciasWebs where [T_Personas_ReferenciasWeb].[IdPersona] point to this entity (FK_T_Personas_ReferenciasWeb_Personas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TPersonasReferenciasWeb> TPersonasReferenciasWebs { get; set; } // T_Personas_ReferenciasWeb.FK_T_Personas_ReferenciasWeb_Personas

        public Persona()
        {
            RelFichasPersonas = new System.Collections.Generic.List<RelFichasPersona>();
            TPersonasReferenciasWebs = new System.Collections.Generic.List<TPersonasReferenciasWeb>();
        }
    }
}