namespace eCat.Data.Entities
{
    public class TUsosComerciale
    {
        public byte IdUsoComercial { get; set; } // IdUsoComercial (Primary key)
        public string CodigoUsoComercial { get; set; } // CodigoUsoComercial (length: 5)
        public string UsoComercial { get; set; } // UsoComercial (length: 30)

        // Reverse navigation

        /// <summary>
        /// Child FichasBases where [FichasBase].[IdUsoComercial] point to this entity (FK_FichasBase_T_UsosComerciales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_T_UsosComerciales
        /// <summary>
        /// Child PeComponentes where [PE_Componentes].[IdUsoComercial] point to this entity (FK_PE_Componentes_T_UsosComerciales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponente> PeComponentes { get; set; } // PE_Componentes.FK_PE_Componentes_T_UsosComerciales
        /// <summary>
        /// Child PeComponentesTiposMaterialesGruposArticuloes where [PE_Componentes_TiposMateriales_GruposArticulos].[IdUsoComercial] point to this entity (FK_PE_Componentes_TiposMateriales_GruposArticulos_T_UsosComerciales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<PeComponentesTiposMaterialesGruposArticulo> PeComponentesTiposMaterialesGruposArticuloes { get; set; } // PE_Componentes_TiposMateriales_GruposArticulos.FK_PE_Componentes_TiposMateriales_GruposArticulos_T_UsosComerciales
        /// <summary>
        /// Child TTiposMaterialesGruposArticuloes where [T_TiposMateriales_GruposArticulos].[IdUsoComercial] point to this entity (FK_T_TiposMateriales_GruposArticulos_T_UsosComerciales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TTiposMaterialesGruposArticulo> TTiposMaterialesGruposArticuloes { get; set; } // T_TiposMateriales_GruposArticulos.FK_T_TiposMateriales_GruposArticulos_T_UsosComerciales
        /// <summary>
        /// Child TUsosComercialesIdiomas where [T_UsosComerciales_Idioma].[IdUsoComercial] point to this entity (FK_T_UsosComerciales_Idioma_T_UsosComerciales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TUsosComercialesIdioma> TUsosComercialesIdiomas { get; set; } // T_UsosComerciales_Idioma.FK_T_UsosComerciales_Idioma_T_UsosComerciales

        public TUsosComerciale()
        {
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            PeComponentes = new System.Collections.Generic.List<PeComponente>();
            PeComponentesTiposMaterialesGruposArticuloes = new System.Collections.Generic.List<PeComponentesTiposMaterialesGruposArticulo>();
            TTiposMaterialesGruposArticuloes = new System.Collections.Generic.List<TTiposMaterialesGruposArticulo>();
            TUsosComercialesIdiomas = new System.Collections.Generic.List<TUsosComercialesIdioma>();
        }
    }
}