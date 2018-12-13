namespace eCat.Data.Entities
{
    public class TSubcategoriasMateriasIdioma
    {

        ///<summary>
        /// Clave de la subcategoría o materia traducida
        ///</summary>
        public string Codigo { get; set; } // Codigo (Primary key) (length: 5)

        ///<summary>
        /// Nombre de la subcategoría o materia en el idioma de traducción
        ///</summary>
        public string Valor { get; set; } // Valor (length: 255)

        ///<summary>
        /// Clave del idioma de traducción
        ///</summary>
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_SubcategoriasMaterias_Idioma].([IdIdiomaInterface]) (FK_T_SubcategoriasMaterias_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_SubcategoriasMaterias_Idioma_T_Idiomas_Plataforma
    }
}