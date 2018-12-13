namespace eCat.Data.Entities
{
    public class TZonasGeografica
    {

        ///<summary>
        /// Clave de comunidad autónoma o región
        ///</summary>
        public byte IdZonaGeografica { get; set; } // IdZonaGeografica (Primary key)

        ///<summary>
        /// Nombre de la comunidad autónoma o región
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 255)

        ///<summary>
        /// Clave de dominio al que pertenece la comunidad autónoma o región
        ///</summary>
        public short IdDominio { get; set; } // IdDominio

        // Reverse navigation

        /// <summary>
        /// Child DilveComunidadAutonomas (Many-to-Many) mapped by table [DILVE_ComunidadAutonoma_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveComunidadAutonoma> DilveComunidadAutonomas { get; set; } // Many to many mapping
        /// <summary>
        /// Child FichasBases where [FichasBase].[IdZonaGeografica] point to this entity (FK_FichasBase_T_ZonasGeograficas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_T_ZonasGeograficas

        public TZonasGeografica()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            DilveComunidadAutonomas = new System.Collections.Generic.List<DilveComunidadAutonoma>();
        }
    }
}