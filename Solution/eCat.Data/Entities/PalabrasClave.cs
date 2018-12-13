namespace eCat.Data.Entities
{
    public class PalabrasClave
    {
        public string IdPalabra { get; set; } // IDPalabra (Primary key) (length: 6)
        public string Palabra { get; set; } // Palabra (length: 50)
        public int? IdGrupoPalabraClave { get; set; } // IDGrupoPalabraClave

        // Reverse navigation

        /// <summary>
        /// Child E2FichasBasePalabrasClave where [E2_FichasBase_PalabrasClave].[IDPalabra] point to this entity (FK_E2_FichasBase_PalabrasClave_PalabrasClave)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2FichasBasePalabrasClave> E2FichasBasePalabrasClave { get; set; } // E2_FichasBase_PalabrasClave.FK_E2_FichasBase_PalabrasClave_PalabrasClave
        /// <summary>
        /// Child E2GeCatalogo (Many-to-Many) mapped by table [E2_GE_CATALOGOS_PALABRASCLAVE]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2GeCatalogo> E2GeCatalogo { get; set; } // Many to many mapping

        // Foreign keys

        /// <summary>
        /// Parent PalabrasClaveGrupos pointed by [PalabrasClave].([IdGrupoPalabraClave]) (FK_PalabrasClave_PalabrasClaveGrupos)
        /// </summary>
        public virtual PalabrasClaveGrupos PalabrasClaveGrupos { get; set; } // FK_PalabrasClave_PalabrasClaveGrupos

        public PalabrasClave()
        {
            E2FichasBasePalabrasClave = new System.Collections.Generic.List<E2FichasBasePalabrasClave>();
            E2GeCatalogo = new System.Collections.Generic.List<E2GeCatalogo>();
        }
    }
}