namespace eCat.Data.Entities
{
    public class E2FichasBaseComentario
    {
        public string IdInterno { get; set; } // IDInterno (Primary key) (length: 12)
        public byte TipoDocumento { get; set; } // TipoDocumento (Primary key)
        public string Comentario { get; set; } // Comentario

        // Foreign keys

        /// <summary>
        /// Parent FichasBase pointed by [E2_FichasBase_Comentarios].([IdInterno]) (FK_E2_FichasBase_Comentarios_FichasBase)
        /// </summary>
        public virtual FichasBase FichasBase { get; set; } // FK_E2_FichasBase_Comentarios_FichasBase
    }
}