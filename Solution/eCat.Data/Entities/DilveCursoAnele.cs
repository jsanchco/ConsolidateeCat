namespace eCat.Data.Entities
{
    public class DilveCursoAnele
    {
        public byte IdCursoAnele { get; set; } // IdCursoANELE (Primary key)
        public string CodigoCursoAnele { get; set; } // CodigoCursoANELE (length: 2)
        public string Descripcion { get; set; } // Descripcion (length: 128)

        // Reverse navigation

        /// <summary>
        /// Child TEdadCursoes (Many-to-Many) mapped by table [DILVE_CursoANELE_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TEdadCurso> TEdadCursoes { get; set; } // Many to many mapping

        public DilveCursoAnele()
        {
            TEdadCursoes = new System.Collections.Generic.List<TEdadCurso>();
        }
    }
}