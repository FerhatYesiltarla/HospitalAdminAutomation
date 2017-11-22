using DAL.ORM.Entity;
using System.Collections.Generic;
using System.Web.Mvc;
using UI.Security.Authentication;
using UI.Service;

namespace UI.Controllers
{
    public class UserController : Controller
    {
        [Authorize(Roles = "1")]
        public ActionResult Main()
        {
            return View();
        }

        [RestrictToAjax]
        [HttpPost]
        public ActionResult Hospitals()
        {
            List<Hospital> hospitals = null;

            if (ModelState.IsValid)
            {
                hospitals = DataService.Service.HospitalService.SelectAll();
            }

            return View(hospitals);
        }

        public PartialViewResult Add()
        {
            return PartialView("./Partial/Hospital/Add");
        }

        [HttpPost]
        public ActionResult Add(Hospital hospitalData, int TownId)
        {
            return View();
        }

        public PartialViewResult Update()
        {
            return PartialView("./Partial/Hospital/Update");
        }

        public PartialViewResult Delete()
        {
            return PartialView("./Partial/Hospital/Delete");
        }

        [HttpPost]
        public ActionResult Hospital(int Id)
        {
            Hospital hospital = null;

            if (ModelState.IsValid)
            {

                hospital = DataService.Service.HospitalService.SelectFirst(x => x.Id == Id);
                return Json(hospital);
            }

            return Json(null);
        }

        [HttpPost]
        public ActionResult Policlinics()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Doctors()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Patients()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Appointments()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cities()
        {
            List<City> cities = null;

            if (ModelState.IsValid)
            {
                cities = DataService.Service.CityService.SelectAll();
            }
            return Json(cities);
        }

        [HttpPost]
        public ActionResult Towns(int cityId)
        {
            List<Town> towns = null;

            if (ModelState.IsValid)
            {
                towns = DataService.Service.TownService.SelectByCondition(x => x.CityId == cityId);
            }

            return Json(towns);
        }
    }
}