namespace eCat.WebServiceAPI.Controllers
{
    #region Using

    using System.Web.Http;
    using Data.Parameters;
    using Service.Services.ConsolidateeCat;

    #endregion

    [RoutePrefix("api/consolidateecat")]
    public class ConsolidateeCatController : ApiController
    {
        [Authorize]
        [HttpGet]
        [Route("insertfichasbase")]
        public IHttpActionResult InsertFichasBase([FromUri] DataFichasBase dataFichasBase)
        {
            return Json(ServiceAddConsolidateeCat.InsertFichaBase(
                System.Configuration.ConfigurationManager.ConnectionStrings["Context"].ConnectionString,
                dataFichasBase));
        }

        #region Dispose       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //_serviceFichasBase.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion
    }
}
