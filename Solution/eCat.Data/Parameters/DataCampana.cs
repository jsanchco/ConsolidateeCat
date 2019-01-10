namespace eCat.Data.Parameters
{
    #region Using

    using System.Web;

    #endregion

    public class DataCampana : IData
    {
        public int IdLineaP { get; set; }
        public int Pagina { get; set; }
        public int Cantidad { get; set; }
        public string FechaInicio { get; set; }

        public string ToUri()
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["IdLineaP"] = IdLineaP.ToString();
            query["Pagina"] = Pagina.ToString();
            query["Cantidad"] = Cantidad.ToString();
            query["FechaInicio"] = FechaInicio;

            return query.ToString();
        }
    }
}
