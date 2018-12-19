namespace eCat.Data.Entities
{
    public class TAmbitosCesion
    {
        public short IdAmbitoCesion { get; set; } // IdAmbitoCesion (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 255)
        public int? IdGrupoAmbitoCesion { get; set; } // IdGrupoAmbitoCesion

        // Reverse navigation

        /// <summary>
        /// Child DilvePais (Many-to-Many) mapped by table [DILVE_AmbitosCesion_Paises_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilvePais> DilvePais { get; set; } // Many to many mapping
        /// <summary>
        /// Child DilveTerritorios (Many-to-Many) mapped by table [DILVE_AmbitosCesion_Territorios_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveTerritorio> DilveTerritorios { get; set; } // Many to many mapping
        /// <summary>
        /// Child TFichasBaseAmbitosCesions (Many-to-Many) mapped by table [T_FichasBase_AmbitosCesion_Restricciones]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseAmbitosCesion> TFichasBaseAmbitosCesions { get; set; } // Many to many mapping
        /// <summary>
        /// Child TFichasBaseAmbitosCesionValores where [T_FichasBase_AmbitosCesion_Valores].[IdAmbitoCesion] point to this entity (FK_T_FichasBase_AmbitosCesion_Valores_T_AmbitosCesion)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TFichasBaseAmbitosCesionValore> TFichasBaseAmbitosCesionValores { get; set; } // T_FichasBase_AmbitosCesion_Valores.FK_T_FichasBase_AmbitosCesion_Valores_T_AmbitosCesion
        public virtual System.Collections.Generic.ICollection<TFichasBaseAmbitosCesionRestriccion> TFichasBaseAmbitosCesionRestricciones { get; set; } // T_FichasBase_AmbitosCesion_Restricciones.FK_T_FichasBase_AmbitosCesion_Restricciones_T_AmbitosCesion

        // Foreign keys

        /// <summary>
        /// Parent TAmbitosCesionGrupos pointed by [T_AmbitosCesion].([IdGrupoAmbitoCesion]) (FK_T_AmbitosCesion_T_AmbitosCesion_Grupos)
        /// </summary>
        public virtual TAmbitosCesionGrupos TAmbitosCesionGrupos { get; set; } // FK_T_AmbitosCesion_T_AmbitosCesion_Grupos

        public TAmbitosCesion()
        {
            TFichasBaseAmbitosCesionValores = new System.Collections.Generic.List<TFichasBaseAmbitosCesionValore>();
            TFichasBaseAmbitosCesionRestricciones = new System.Collections.Generic.List<TFichasBaseAmbitosCesionRestriccion>();
            TFichasBaseAmbitosCesions = new System.Collections.Generic.List<TFichasBaseAmbitosCesion>();
            DilvePais = new System.Collections.Generic.List<DilvePais>();
            DilveTerritorios = new System.Collections.Generic.List<DilveTerritorio>();
        }
    }
}