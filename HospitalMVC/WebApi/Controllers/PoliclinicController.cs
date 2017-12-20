using DAL.ORM.Entity;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Service;

namespace WebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class PoliclinicController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetList()
        {
            List<Policlinic> policlinics = DataService.Service.PoliclinicService.SelectAll();
            return Json(policlinics);
        }
    }
}
