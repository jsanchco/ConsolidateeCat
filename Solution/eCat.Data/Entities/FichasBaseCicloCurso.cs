namespace eCat.Data.Entities
{
    public class FichasBaseCicloCurso
    {
        public string IdInterno { get; set; } // IdInterno (Primary key) (length: 12)
        public string IdCiclo { get; set; } // IdCiclo (Primary key) (length: 5)
        public string IdCurso { get; set; } // IdCurso (Primary key) (length: 5)
        public byte Orden { get; set; } // Orden

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [FichasBase_CicloCurso].([IdInterno]) (FK_FichasBase_CicloCurso_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_FichasBase_CicloCurso_FichasBase

        /// <summary>
        /// Parent TCategoriasCiclo pointed by [FichasBase_CicloCurso].([IdCiclo]) (FK_FichasBase_CicloCurso_T_CategoriasCiclos)
        /// </summary>
        public virtual TCategoriasCiclo TCategoriasCiclo { get; set; } // FK_FichasBase_CicloCurso_T_CategoriasCiclos

        /// <summary>
        /// Parent TEdadCurso pointed by [FichasBase_CicloCurso].([IdCurso]) (FK_FichasBase_CicloCurso_T_EdadCurso)
        /// </summary>
        public virtual TEdadCurso TEdadCurso { get; set; } // FK_FichasBase_CicloCurso_T_EdadCurso
    }
}