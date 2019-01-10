namespace eCat.WebServiceAPI.Controllers
{
    #region Using

    using System.Web.Http;
    using Service.Interfaces;
    using IRepository;
    using Service.Services;
    using Data.Parameters;

    #endregion

    [RoutePrefix("api/fichasbase")]
    public class FichasBaseController : ApiController
    {
        private readonly IServiceFichasBase _serviceFichasBase;

        #region Constructor

        public FichasBaseController(IRepositoryFichasBase repositoryFichasBase)
        {
            _serviceFichasBase = new ServiceFichasBase(repositoryFichasBase);
        }

        #endregion

        // GET api/fichasbase/AR100090
        [Authorize]
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            return Json(_serviceFichasBase.Get(id));
        }

        [Authorize]
        [HttpGet]
        [Route("pa_InsertFichasBase")]
        public IHttpActionResult pa_InsertFichasBase([FromUri] DataFichasBase dataFichasBase)
        {
            return Json(_serviceFichasBase.pa_InsertFichasBase(dataFichasBase));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _serviceFichasBase.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
