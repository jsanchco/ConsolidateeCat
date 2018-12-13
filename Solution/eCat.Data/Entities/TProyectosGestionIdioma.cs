namespace eCat.Data.Entities
{
    public class TProyectosGestionIdioma
    {
        public int IdProyectoGestion { get; set; } // IdProyectoGestion (Primary key)
        public string Valor { get; set; } // Valor (length: 255)
        public short IdIdiomainterface { get; set; } // IdIdiomainterface (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent TIdiomasPlataforma pointed by [T_ProyectosGestion_Idioma].([IdIdiomainterface]) (FK_T_ProyectosGestion_Idioma_T_Idiomas_Plataforma)
        /// </summary>
        public virtual TIdiomasPlataforma TIdiomasPlataforma { get; set; } // FK_T_ProyectosGestion_Idioma_T_Idiomas_Plataforma

        /// <summary>
        /// Parent TProyectosGestion pointed by [T_ProyectosGestion_Idioma].([IdProyectoGestion]) (FK_T_ProyectosGestion_Idioma_T_ProyectosGestion)
        /// </summary>
        public virtual TProyectosGestion TProyectosGestion { get; set; } // FK_T_ProyectosGestion_Idioma_T_ProyectosGestion
    }
}