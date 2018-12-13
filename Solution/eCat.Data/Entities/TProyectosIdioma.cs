namespace eCat.Data.Entities
{
    public class TProyectosIdioma
    {
        public int IdProyecto { get; set; } // IdProyecto (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
        public short IdIdiomaInterface { get; set; } // IdIdiomaInterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_Proyectos_Idioma].([IdIdiomaInterface]) (FK_T_Proyectos_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_Proyectos_Idioma_T_Idiomas_Plataforma
    }
}