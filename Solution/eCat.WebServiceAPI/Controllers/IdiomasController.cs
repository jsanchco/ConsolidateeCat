using System.Linq;
using eCat.Repository;

namespace eCat.WebServiceAPI.Controllers
{
    #region Using

    using System.Web.Http;
    using IRepository;
    using Service.Interfaces;
    using Service.Services;
    using System.ServiceModel.Web;
    using Data.Entities;

    #endregion

    public class IdiomasController : ApiController
    {
        private readonly IServiceIdiomas _serviceIdiomas;

        #region Constructor
        public IdiomasController(IRepositoryIdiomas repositoryIdiomas)
        {
            _serviceIdiomas = new ServiceIdiomas(repositoryIdiomas);
        }

        #endregion

        // GET api/idiomas/13
        [WebInvoke(Method = "GET")]
        public IHttpActionResult Get(int id)
        {
            var serviceTCampanas = new ServiceTCampanas(new RepositoryTCampanas());

            var tCampanas =  serviceTCampanas.Get().ToList();

            return Json(tCampanas);
            //return Json(_serviceIdiomas.Get(id));
        }

        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public IHttpActionResult Post(Idioma idioma)
        {
            if (idioma == null)
            {
                return BadRequest("Invalid passed data");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var idiomaSave = _serviceIdiomas.SaveIdioma(idioma);
            if (idiomaSave == null)
            {
                return BadRequest("Error in SaveIdioma");
            }

            return Json(idiomaSave);
        }

        [WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        public IHttpActionResult Delete(Idioma idioma)
        {
            if (idioma == null)
            {
                return BadRequest("Invalid passed data");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!_serviceIdiomas.DeleteIdioma(idioma.IdIdioma))
            {
                return BadRequest("Error in SaveIdioma");
            }

            return Json( "OK!!!" );
        }
    }
}
