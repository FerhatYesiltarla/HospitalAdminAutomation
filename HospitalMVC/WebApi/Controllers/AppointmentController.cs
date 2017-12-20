using DAL.ORM.Context;
using DAL.ORM.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Service;

namespace WebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AppointmentController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetList()
        {
            List<Appoinment> appointments = DataService.Service.AppointmentService.SelectAll();
            return Json(appointments);
        }

        [HttpPost]
        public IHttpActionResult Add(Appoinment appData)
        {
            DataService.Service.AppointmentService.Insert(appData);
            return Ok();
        }
    }
}
