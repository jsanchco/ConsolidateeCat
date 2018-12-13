namespace eCat.Data.Entities
{
    public class E2DatosMinimosCampos
    {
        public string CodigoCampo { get; set; } // Codigo_Campo (Primary key) (length: 15)
        public string DescripcionCampo { get; set; } // Descripcion_Campo (length: 255)
        public bool Defecto { get; set; } // Defecto
        public bool Bloqueado { get; set; } // Bloqueado
        public int Orden { get; set; } // Orden

        // Reverse navigation

        /// <summary>
        /// Child E2DatosMinimosJerarquiaCampos where [E2_DATOS_MINIMOS_JERARQUIA_CAMPOS].[Codigo_Campo] point to this entity (FK_E2_DATOS_MINIMOS_JERARQUIA_CAMPOS_E2_DATOS_MINIMOS_CAMPOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2DatosMinimosJerarquiaCampos> E2DatosMinimosJerarquiaCampos { get; set; } // E2_DATOS_MINIMOS_JERARQUIA_CAMPOS.FK_E2_DATOS_MINIMOS_JERARQUIA_CAMPOS_E2_DATOS_MINIMOS_CAMPOS
        /// <summary>
        /// Child E2DatosMinimosJerarquiaValore (Many-to-Many) mapped by table [E2_DATOS_MINIMOS_CAMPOS_VALORES]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<E2DatosMinimosJerarquiaValore> E2DatosMinimosJerarquiaValore { get; set; } // Many to many mapping

        public E2DatosMinimosCampos()
        {
            Defecto = false;
            Bloqueado = false;
            Orden = 0;
            E2DatosMinimosJerarquiaCampos = new System.Collections.Generic.List<E2DatosMinimosJerarquiaCampos>();
            E2DatosMinimosJerarquiaValore = new System.Collections.Generic.List<E2DatosMinimosJerarquiaValore>();
        }
    }
}