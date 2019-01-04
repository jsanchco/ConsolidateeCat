namespace eCat.WebServiceAPI.Controllers
{
    #region Using

    using System.Web.Http;
    using IRepository;
    using Service.Interfaces;
    using Service.Services;
    using System.ServiceModel.Web;
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
        [WebInvoke(Method = "GET")]
        public IHttpActionResult Get()
        {
            return Json(_serviceTCampanas.Get().ToList());
        }

        [Authorize]
        [WebInvoke(Method = "GET")]
        [Route("paCampanas")]
        public IHttpActionResult paCampanas()
        {
            return Json(_serviceTCampanas.Get().ToList());
        }
    }
}
