using DAL.ORM.Entity;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Service;

namespace WebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class DoctorController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetList()
        {
            List<Staff> doctors = DataService.Service.StaffService.SelectAll();
            return Json(doctors);
        }
    }
}
