namespace eCat.Data.Entities
{
    public class E2EquivalenciaClasificacionesCondicione
    {
        public long IdEquivalenciaClasificacionCondicion { get; set; } // IdEquivalenciaClasificacionCondicion (Primary key)
        public int IdCatalogoGest { get; set; } // ID_CATALOGO_GEST
        public string IdClasifGest { get; set; } // ID_CLASIF_GEST (length: 60)
        public int IdCatalogoPres { get; set; } // ID_CATALOGO_PRES
        public string IdClasifPres { get; set; } // ID_CLASIF_PRES (length: 255)
        public string CodigoCampo { get; set; } // CodigoCampo (length: 15)
        public bool IncluirExcluir { get; set; } // IncluirExcluir
        public string Valor { get; set; } // Valor (length: 255)
        public int Orden { get; set; } // Orden
        public bool AndOr { get; set; } // AndOr

        // Foreign keys

        /// <summary>
        /// Parent E2EquivalenciaClasificacione pointed by [E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES].([IdCatalogoGest], [IdClasifGest], [IdCatalogoPres], [IdClasifPres]) (FK_E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES_E2_EQUIVALENCIA_CLASIFICACIONES)
        /// </summary>
        public virtual E2EquivalenciaClasificacione E2EquivalenciaClasificacione { get; set; } // FK_E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES_E2_EQUIVALENCIA_CLASIFICACIONES

        /// <summary>
        /// Parent E2RamasClasificacionesGestion pointed by [E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES].([IdCatalogoGest], [IdClasifGest]) (FK_E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES_E2_RAMAS_CLASIFICACIONES_GESTION)
        /// </summary>
        public virtual E2RamasClasificacionesGestion E2RamasClasificacionesGestion { get; set; } // FK_E2_EQUIVALENCIA_CLASIFICACIONES_CONDICIONES_E2_RAMAS_CLASIFICACIONES_GESTION

        public E2EquivalenciaClasificacionesCondicione()
        {
            IncluirExcluir = false;
            Orden = 0;
            AndOr = true;
        }
    }
}