using DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Security.Authentication;
using UI.Service;

namespace UI.Controllers
{
    public class HospitalController : Controller
    {
        // GET: Hospital
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
            return PartialView();
        }

        [HttpPost]
        public ActionResult Add(Hospital hospitalData)
        {
            DataService.Service.HospitalService.Insert(hospitalData);
            return RedirectToAction("Main", "User");
        }

        public PartialViewResult Update()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Update(Hospital newHospitalData)
        {
            DataService.Service.HospitalService.Update(newHospitalData);
            return RedirectToAction("Main","User");
        }

        [HttpPost]
        public ActionResult Delete(int hospitalId)
        {
            DataService.Service.HospitalService.SuperDelete(hospitalId);
            return RedirectToAction("Main", "User");
        }
    }
}