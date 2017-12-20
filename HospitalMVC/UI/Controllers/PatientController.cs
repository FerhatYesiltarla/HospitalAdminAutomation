using DAL.ORM.Entity;
using System.Collections.Generic;
using System.Web.Mvc;
using UI.Security.Authentication;
using UI.Service;

namespace UI.Controllers
{
    public class PatientController : Controller
    {
        [RestrictToAjax]
        [HttpPost]
        public ActionResult Patients()
        {
            List<Patient> patients = null;

            if (ModelState.IsValid)
            {
                patients = DataService.Service.PatientService.SelectAll();
            }

            return View(patients);
        }
    }
}