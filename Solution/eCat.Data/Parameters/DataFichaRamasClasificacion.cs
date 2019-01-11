namespace eCat.Data.Parameters
{
    #region Using

    using System.Web;

    #endregion

    public class DataFichaRamasClasificacion : IData
    {
        public string IdInterno { get; set; }
        public string IdClasificacion { get; set; }
        public string UsuarioCreacion { get; set; }

        public string ToUri()
        {
            var query = HttpUtility.ParseQueryString(string.Empty);

            query["IdInterno"] = IdInterno;
            query["IdClasificacion"] = IdClasificacion;
            query["UsuarioCreacion"] = UsuarioCreacion;

            return query.ToString();
        }
    }
}
