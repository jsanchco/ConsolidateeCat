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
        //[Authorize]
        [HttpGet]
        [Route("insertfichasbase")]
        public IHttpActionResult InsertFichasBase([FromUri] DataFichasBase dataFichasBase)
        {
            return Json(ServiceAdd.InsertFichaBase(
                System.Configuration.ConfigurationManager.ConnectionStrings["Context"].ConnectionString,
                dataFichasBase));
        }

        [Authorize]
        [HttpGet]
        [Route("insertcampana")]
        public IHttpActionResult InsertCampana([FromUri] DataInsertTCampana dataInsertTCampana)
        {
            return Json(ServiceMasterMaintenance.InsertCampana(
                System.Configuration.ConfigurationManager.ConnectionStrings["Context"].ConnectionString,
                dataInsertTCampana));
        }

        //[Authorize]
        [HttpGet]
        [Route("getlog")]
        public IHttpActionResult GetLog()
        {
            return Json(Util.GetLog());
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
