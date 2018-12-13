namespace eCat.Data.Entities
{
    public class TEtapasRangoEdad
    {
        public int IdEtapaRangoEdad { get; set; } // IdEtapaRangoEdad

        ///<summary>
        /// Clave de la etapa o rango de edad
        ///</summary>
        public string Codigo { get; set; } // Codigo (Primary key) (length: 5)

        ///<summary>
        /// Nombre de la etapa o rango de edad
        ///</summary>
        public string Nombre { get; set; } // Nombre (length: 255)

        ///<summary>
        /// 1 -&gt; Etapas y 2 -&gt; Rango de edad
        ///</summary>
        public byte Tipo { get; set; } // Tipo

        // Reverse navigation

        /// <summary>
        /// Child DilveNivelEducativoAneles (Many-to-Many) mapped by table [DILVE_NivelEducativoANELE_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveNivelEducativoAnele> DilveNivelEducativoAneles { get; set; } // Many to many mapping
        /// <summary>
        /// Child E2RamasClasificacionesGestion where [E2_RAMAS_CLASIFICACIONES_GESTION].[CodEtapaEdad] point to this entity (FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_EtapasRangoEdad)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2RamasClasificacionesGestion> E2RamasClasificacionesGestion { get; set; } // E2_RAMAS_CLASIFICACIONES_GESTION.FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_EtapasRangoEdad
        /// <summary>
        /// Child PeEstructuraEdadesNivelesEducativoes where [PE_EstructuraEdades_NivelesEducativos].[CodEtapa] point to this entity (FK_PE_Edades_NivelesEducativos_T_EtapasRangoEdad)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeEstructuraEdadesNivelesEducativo> PeEstructuraEdadesNivelesEducativoes { get; set; } // PE_EstructuraEdades_NivelesEducativos.FK_PE_Edades_NivelesEducativos_T_EtapasRangoEdad

        public TEtapasRangoEdad()
        {
            E2RamasClasificacionesGestion = new System.Collections.Generic.List<E2RamasClasificacionesGestion>();
            PeEstructuraEdadesNivelesEducativoes = new System.Collections.Generic.List<PeEstructuraEdadesNivelesEducativo>();
            DilveNivelEducativoAneles = new System.Collections.Generic.List<DilveNivelEducativoAnele>();
        }
    }
}