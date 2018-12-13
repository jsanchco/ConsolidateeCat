namespace eCat.Data.Entities
{
    public class TNoticiasPrincipal
    {
        public int IdNoticia { get; set; } // IdNoticia (Primary key)

        ///<summary>
        /// 1 - Check
        /// 2 - Info
        /// 3 - estrella
        /// 4 - warning
        ///</summary>
        public byte TipoNoticia { get; set; } // TipoNoticia
        public string Titulo { get; set; } // Titulo (length: 200)
        public string Noticia { get; set; } // Noticia
        public System.DateTime FechaCreacion { get; set; } // fechaCreacion

        public TNoticiasPrincipal()
        {
            FechaCreacion = System.DateTime.Now;
        }
    }
}