// ReSharper disable InconsistentNaming
namespace eCat.WebServiceAPI.Controllers
{
    #region Using

    using System.Web.Http;
    using IRepository;
    using Service.Interfaces;
    using Service.Services;
    using Data.Parameters;
    using System.Linq;

    #endregion

    [RoutePrefix("api/campanas")]
    public class CampanasController : ApiController
    {
        private readonly IServiceTCampanas _serviceTCampanas;

        #region Constructor

        public CampanasController(IRepositoryTCampanas repositoryCampanas)
        {
            _serviceTCampanas = new ServiceTCampanas(repositoryCampanas);
        }

        #endregion 

        // GET api/campanas
        [Authorize]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Json(_serviceTCampanas.Get().ToList());
        }

        [HttpGet]
        [Authorize]
        [Route("paCampanas")]
        public IHttpActionResult paCampanas([FromUri] DataCampana dataCampana)
        {
            return Json(_serviceTCampanas.Get_pa_TCampanas(dataCampana));
        }

        [Authorize]
        [HttpGet]
        [Route("pa_Insert_T_Campanas")]
        public IHttpActionResult pa_Insert_T_Campanas([FromUri] DataInsertTCampana dataInsertTCampana)
        {
            return Json(_serviceTCampanas.pa_Insert_T_Campanas(dataInsertTCampana));
        }

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _serviceTCampanas.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

    }
}
