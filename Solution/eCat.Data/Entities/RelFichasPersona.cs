namespace eCat.Data.Entities
{
    public class RelFichasPersona
    {

        ///<summary>
        /// Clave del material en FichasBase
        ///</summary>
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)

        ///<summary>
        /// Rol o función desempeñada por a persona en la elaboración del material
        ///</summary>
        public string IdRol { get; set; } // IDRol (Primary key) (length: 3)

        ///<summary>
        /// Clave de la persona
        ///</summary>
        public long IdPersona { get; set; } // IDPersona (Primary key)

        ///<summary>
        /// Orden en que se debe mostrar la persona en aplicaciones ofimáticas o páginas Web
        ///</summary>
        public byte? Orden { get; set; } // Orden
        public bool Disponible { get; set; } // Disponible
        public bool Interno { get; set; } // Interno

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [RelFichasPersonas].([IdInterno]) (FK_RelFichasPersonas_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_RelFichasPersonas_FichasBase

        /// <summary>
        /// Parent Persona pointed by [RelFichasPersonas].([IdPersona]) (FK_RelFichasPersonas_Personas)
        /// </summary>
        public virtual Persona Persona { get; set; } // FK_RelFichasPersonas_Personas

        /// <summary>
        /// Parent Role pointed by [RelFichasPersonas].([IdRol]) (FK_RelFichasPersonas_Roles)
        /// </summary>
        public virtual Role Role { get; set; } // FK_RelFichasPersonas_Roles
    }
}