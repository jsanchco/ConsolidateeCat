namespace eCat.Data.Entities
{
    public class TEdadCursoIdioma
    {

        ///<summary>
        /// Calve de la edad o curso traducido
        ///</summary>
        public string Codigo { get; set; } // Codigo (Primary key) (length: 5)

        ///<summary>
        /// Nombre de la edad o curso en el idioma de traducción
        ///</summary>
        public string Valor { get; set; } // Valor (length: 255)

        ///<summary>
        /// Clave del idioma de traducción
        ///</summary>
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_EdadCurso_Idioma].([IdIdiomaInterface]) (FK_T_EdadCurso_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_EdadCurso_Idioma_T_Idiomas_Plataforma
    }
}