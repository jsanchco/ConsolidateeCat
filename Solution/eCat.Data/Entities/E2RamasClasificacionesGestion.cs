namespace eCat.Data.Entities
{
    public class E2RamasClasificacionesGestion
    {

        ///<summary>
        /// Clave del catálog para el que se define la jerarquía
        ///</summary>
        public int IdCatalogo { get; set; } // ID_CATALOGO (Primary key)

        ///<summary>
        /// Clave de la rama de clasificación. Se compone de la concatenación de las claves de los niveles que definen la rama de clasificación del producto.
        ///</summary>
        public string IdClasificacion { get; set; } // ID_CLASIFICACION (Primary key) (length: 60)

        ///<summary>
        /// Clave de la rama antecesora en la estructura de árbol
        ///</summary>
        public string IdPadre { get; set; } // ID_PADRE (length: 60)

        ///<summary>
        /// Nombre de la rama de jerarquía
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 50)

        ///<summary>
        /// Fecha de alta de la rama
        ///</summary>
        public System.DateTime? FechaAlta { get; set; } // FechaAlta

        ///<summary>
        /// Fecha de la última modificación de la rama
        ///</summary>
        public System.DateTime? FechaUltModif { get; set; } // FechaUltModif

        ///<summary>
        /// Nivel de profundidad de la clave de la rama dentro de los elementos que la forman
        ///</summary>
        public byte Nivel { get; set; } // Nivel

        ///<summary>
        /// Indicación de baja de la rama. No se puede utilizar la rama en la clasificación de materiales.
        ///</summary>
        public bool Baja { get; set; } // Baja

        ///<summary>
        /// ???
        ///</summary>
        public bool Personalizado { get; set; } // Personalizado

        ///<summary>
        /// Clave del primer nivel de la jerarquía de producto.
        ///</summary>
        public string CodPropietario { get; set; } // CodPropietario (length: 5)

        ///<summary>
        /// Clave del segundo nivel de la jerarquía de producto.
        ///</summary>
        public string CodMercado { get; set; } // CodMercado (length: 5)

        ///<summary>
        /// Clave del tercer nivel de la jerarquía de producto.
        ///</summary>
        public string CodNegocio { get; set; } // CodNegocio (length: 5)

        ///<summary>
        /// Clave del cuarto nivel de la jerarquía de producto.
        ///</summary>
        public string CodEtapaEdad { get; set; } // CodEtapaEdad (length: 5)

        ///<summary>
        /// Clave del quinto nivel de la jerarquía de producto.
        ///</summary>
        public string CodCategoriaCiclo { get; set; } // CodCategoriaCiclo (length: 5)

        ///<summary>
        /// Clave del sexto nivel de la jerarquía de producto.
        ///</summary>
        public string CodSubcategoriaMateria { get; set; } // CodSubcategoriaMateria (length: 5)

        ///<summary>
        /// Clave del séptimo nivel de la jerarquía de producto.
        ///</summary>
        public string CodEdadCurso { get; set; } // CodEdadCurso (length: 5)
        public bool Pendiente { get; set; } // Pendiente

        // Reverse navigation

        /// <summary>
        /// Child E2AclDominiosJerarquia where [E2_ACL_DOMINIOS_JERARQUIAS].([ID_CATALOGO], [ID_CLASIFICACION]) point to this entity (FK_E2_ACL_DOMINIOS_JERARQUIAS_E2_RAMAS_CLASIFICACIONES_GESTION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2AclDominiosJerarquia> E2AclDominiosJerarquia { get; set; } // E2_ACL_DOMINIOS_JERARQUIAS.FK_E2_ACL_DOMINIOS_JERARQUIAS_E2_RAMAS_CLASIFICACIONES_GESTION
        /// <summary>
        /// Child E2EquivalenciaClasificacione where [E2_EQUIVALENCIA_CLASIFICACIONES].([ID_CATALOGO_GEST], [ID_CLASIF_GEST]) point to this entity (FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_RAMAS_CLASIFICACIONES_GESTION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2EquivalenciaClasificacione> E2EquivalenciaClasificacione { get; set; } // E2_EQUIVALENCIA_CLASIFICACIONES.FK_E2_EQUIVALENCIA_CLASIFICACIONES_E2_RAMAS_CLASIFICACIONES_GESTION
        /// <summary>
        /// Child E2EquivalenciaClasificacionesCondicione where [E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES].([ID_CATALOGO_GEST], [ID_CLASIF_GEST]) point to this entity (FK_E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES_E2_RAMAS_CLASIFICACIONES_GESTION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2EquivalenciaClasificacionesCondicione> E2EquivalenciaClasificacionesCondicione { get; set; } // E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES.FK_E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES_E2_RAMAS_CLASIFICACIONES_GESTION
        /// <summary>
        /// Child E2RamasclasifFicha where [E2_RAMASCLASIF_FICHAS].([ID_CATALOGO], [ID_CLASIFICACION]) point to this entity (FK_E2_RAMASCLASIF_FICHAS_E2_RAMAS_CLASIFICACIONES_GESTION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2RamasclasifFicha> E2RamasclasifFicha { get; set; } // E2_RAMASCLASIF_FICHAS.FK_E2_RAMASCLASIF_FICHAS_E2_RAMAS_CLASIFICACIONES_GESTION

        // Foreign keys

        /// <summary>
        /// Parent E2ClasificacionesGestion pointed by [E2_RAMAS_CLASIFICACIONES_GESTION].([IdCatalogo]) (FK_E2_RAMAS_CLASIFICACIONES_GESTION_E2_CLASIFICACIONES_GESTION)
        /// </summary>
        public virtual E2ClasificacionesGestion E2ClasificacionesGestion { get; set; } // FK_E2_RAMAS_CLASIFICACIONES_GESTION_E2_CLASIFICACIONES_GESTION

        /// <summary>
        /// Parent TCategoriasCiclo pointed by [E2_RAMAS_CLASIFICACIONES_GESTION].([CodCategoriaCiclo]) (FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_CategoriasCiclos)
        /// </summary>
        public virtual TCategoriasCiclo TCategoriasCiclo { get; set; } // FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_CategoriasCiclos

        /// <summary>
        /// Parent TEdadCurso pointed by [E2_RAMAS_CLASIFICACIONES_GESTION].([CodEdadCurso]) (FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_EdadCurso)
        /// </summary>
        public virtual TEdadCurso TEdadCurso { get; set; } // FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_EdadCurso

        /// <summary>
        /// Parent TEtapasRangoEdad pointed by [E2_RAMAS_CLASIFICACIONES_GESTION].([CodEtapaEdad]) (FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_EtapasRangoEdad)
        /// </summary>
        public virtual TEtapasRangoEdad TEtapasRangoEdad { get; set; } // FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_EtapasRangoEdad

        /// <summary>
        /// Parent TMercado pointed by [E2_RAMAS_CLASIFICACIONES_GESTION].([CodMercado]) (FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Mercado)
        /// </summary>
        public virtual TMercado TMercado { get; set; } // FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Mercado

        /// <summary>
        /// Parent TNegocio pointed by [E2_RAMAS_CLASIFICACIONES_GESTION].([CodNegocio]) (FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Negocio)
        /// </summary>
        public virtual TNegocio TNegocio { get; set; } // FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Negocio

        /// <summary>
        /// Parent TPropietario pointed by [E2_RAMAS_CLASIFICACIONES_GESTION].([CodPropietario]) (FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Propietario)
        /// </summary>
        public virtual TPropietario TPropietario { get; set; } // FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_Propietario

        /// <summary>
        /// Parent TSubcategoriasMateria pointed by [E2_RAMAS_CLASIFICACIONES_GESTION].([CodSubcategoriaMateria]) (FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_SubcategoriasMaterias)
        /// </summary>
        public virtual TSubcategoriasMateria TSubcategoriasMateria { get; set; } // FK_E2_RAMAS_CLASIFICACIONES_GESTION_T_SubcategoriasMaterias

        public E2RamasClasificacionesGestion()
        {
            Nivel = 0;
            Baja = false;
            Personalizado = false;
            Pendiente = true;
            E2AclDominiosJerarquia = new System.Collections.Generic.List<E2AclDominiosJerarquia>();
            E2EquivalenciaClasificacione = new System.Collections.Generic.List<E2EquivalenciaClasificacione>();
            E2EquivalenciaClasificacionesCondicione = new System.Collections.Generic.List<E2EquivalenciaClasificacionesCondicione>();
            E2RamasclasifFicha = new System.Collections.Generic.List<E2RamasclasifFicha>();
        }
    }
}