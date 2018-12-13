namespace eCat.Data.Entities
{
    public class E2Lineasproducto
    {
        public int IdLineaP { get; set; } // IdLineaP (Primary key)
        public string CodLineaP { get; set; } // COD_lineaP (length: 3)
        public string Descripcion { get; set; } // Descripcion (length: 50)
        public bool Texto { get; set; } // Texto
        public bool ProyectoGestion { get; set; } // ProyectoGestion

        // Reverse navigation

        /// <summary>
        /// Child DilvePublicoObjetivoes (Many-to-Many) mapped by table [DILVE_PublicoObjetivo_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilvePublicoObjetivo> DilvePublicoObjetivoes { get; set; } // Many to many mapping
        /// <summary>
        /// Child TLineasNegocioLineasProductoes where [T_LineasNegocio_LineasProducto].[IdLineaProducto] point to this entity (FK_T_LineasNegocio_LineasProducto_E2_LINEASPRODUCTO)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TLineasNegocioLineasProducto> TLineasNegocioLineasProductoes { get; set; } // T_LineasNegocio_LineasProducto.FK_T_LineasNegocio_LineasProducto_E2_LINEASPRODUCTO

        public E2Lineasproducto()
        {
            Texto = false;
            ProyectoGestion = false;
            TLineasNegocioLineasProductoes = new System.Collections.Generic.List<TLineasNegocioLineasProducto>();
            DilvePublicoObjetivoes = new System.Collections.Generic.List<DilvePublicoObjetivo>();
        }
    }
}