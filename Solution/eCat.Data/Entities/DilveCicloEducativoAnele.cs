namespace eCat.Data.Entities
{
    public class DilveCicloEducativoAnele
    {
        public byte IdCicloEducaticoAnele { get; set; } // IdCicloEducaticoANELE (Primary key)
        public string CodigoCicloEducativoAnele { get; set; } // CodigoCicloEducativoANELE (length: 2)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child TCategoriasCicloes (Many-to-Many) mapped by table [DILVE_CicloEducativoANELE_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TCategoriasCiclo> TCategoriasCicloes { get; set; } // Many to many mapping

        public DilveCicloEducativoAnele()
        {
            TCategoriasCicloes = new System.Collections.Generic.List<TCategoriasCiclo>();
        }
    }
}