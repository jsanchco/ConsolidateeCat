namespace eCat.Data.Entities
{
    public class TAmbitosCesionGrupos
    {
        public int IdGrupoAmbitoCesion { get; set; } // IdGrupoAmbitoCesion (Primary key)
        public string GrupoAmbitoCesion { get; set; } // GrupoAmbitoCesion (length: 255)

        // Reverse navigation

        /// <summary>
        /// Child TAmbitosCesions where [T_AmbitosCesion].[IdGrupoAmbitoCesion] point to this entity (FK_T_AmbitosCesion_T_AmbitosCesion_Grupos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TAmbitosCesion> TAmbitosCesions { get; set; } // T_AmbitosCesion.FK_T_AmbitosCesion_T_AmbitosCesion_Grupos

        public TAmbitosCesionGrupos()
        {
            TAmbitosCesions = new System.Collections.Generic.List<TAmbitosCesion>();
        }
    }
}