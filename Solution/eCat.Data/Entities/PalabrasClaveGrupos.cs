namespace eCat.Data.Entities
{
    public class PalabrasClaveGrupos
    {
        public int IdGrupoPalabraClave { get; set; } // IdGrupoPalabraClave (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child PalabrasClaves where [PalabrasClave].[IDGrupoPalabraClave] point to this entity (FK_PalabrasClave_PalabrasClaveGrupos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PalabrasClave> PalabrasClaves { get; set; } // PalabrasClave.FK_PalabrasClave_PalabrasClaveGrupos

        public PalabrasClaveGrupos()
        {
            PalabrasClaves = new System.Collections.Generic.List<PalabrasClave>();
        }
    }
}