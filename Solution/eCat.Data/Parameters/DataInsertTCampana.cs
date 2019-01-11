namespace eCat.Data.Parameters
{
    #region Using

    using System;
    using System.Web;

    #endregion

    public class DataInsertTCampana : IData
    {
        public string Descripcion { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }

        public string ToUri()
        {
            var query = HttpUtility.ParseQueryString(string.Empty);

            query["Descripcion"] = Descripcion;
            query["Desde"] = Desde.ToString("yyyy-MM-dd");
            query["Hasta"] = Hasta.ToString("yyyy-MM-dd");

            return query.ToString();
        }
    }
}
