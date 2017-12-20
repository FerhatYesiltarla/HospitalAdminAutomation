using DAL.ORM.Entity;
using System.Collections.Generic;
using System.Web.Mvc;
using UI.Security.Authentication;
using UI.Service;

namespace UI.Controllers
{
    public class AppointmentController : Controller
    {
        [RestrictToAjax]
        [HttpPost]
        public ActionResult Appointments()
        {
            List<Appoinment> appointments = null;

            if (ModelState.IsValid)
            {
                appointments = DataService.Service.AppointmentService.SelectAll();
            }

            return View(appointments);
        }
    }
}