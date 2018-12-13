namespace eCat.Data.Entities
{
    public class TConfiguracionMantenimientosGenericosECat
    {

        ///<summary>
        /// Clave del objeto menú. Se corresponde con el código de E2_ACL_Objetos
        ///</summary>
        public string IdObjeto { get; set; } // ID_OBJETO (Primary key) (length: 10)

        ///<summary>
        /// Título de la pantalla de mantenimiento para este objeto
        ///</summary>
        public string Titulo { get; set; } // Titulo (length: 500)

        ///<summary>
        /// Nombre de la tabla para la que se hace el mantenimiento
        ///</summary>
        public string Tabla { get; set; } // Tabla (length: 200)

        ///<summary>
        /// Nombre del campo clave de la tabla para la que se hace el mantenimiento
        ///</summary>
        public string ColumnaId { get; set; } // ColumnaId (length: 200)

        ///<summary>
        /// Nombre del campo valor de la tabla para la que se hace el mantenimiento
        ///</summary>
        public string ColumnaValor { get; set; } // ColumnaValor (length: 200)

        ///<summary>
        /// Tamaño en caracteres de la columna valor de la tabla para la que se hace el mantenimiento
        ///</summary>
        public int TamanyoValor { get; set; } // TamanyoValor

        ///<summary>
        /// Nombre del procedimiento almacenado que realizará las comprobaciones de eliminación de registros durante el mantenimiento
        ///</summary>
        public string ProcedureComprobacion { get; set; } // ProcedureComprobacion (length: 500)

        ///<summary>
        /// True = indica que la pantalla de mantenimiento tiene multilenguaje
        ///</summary>
        public bool ConMultilenguaje { get; set; } // ConMultilenguaje
        public bool ActualizarSap { get; set; } // ActualizarSAP

        public TConfiguracionMantenimientosGenericosECat()
        {
            ConMultilenguaje = true;
            ActualizarSap = false;
        }
    }
}