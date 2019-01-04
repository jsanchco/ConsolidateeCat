namespace eCat.WebServiceAPI.Controllers
{
    #region Using

    using System.Web.Http;
    using Service.Interfaces;
    using IRepository;
    using Service.Services;
    using System.ServiceModel.Web;

    #endregion

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
        [WebInvoke(Method = "GET")]
        public IHttpActionResult Get(string id)
        {
            return Json(_serviceFichasBase.Get(id));
        }
    }
}
