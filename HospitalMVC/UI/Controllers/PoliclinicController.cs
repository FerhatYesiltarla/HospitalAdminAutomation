using DAL.ORM.Entity;
using System.Collections.Generic;
using System.Web.Mvc;
using UI.Security.Authentication;
using UI.Service;

namespace UI.Controllers
{
    public class PoliclinicController : Controller
    {
        [HttpPost]
        public ActionResult Policlinic(int Id)
        {
            Policlinic policlinic = null;

            if (ModelState.IsValid)
            {

                policlinic = DataService.Service.PoliclinicService.SelectFirst(x => x.Id == Id);
                return Json(policlinic);
            }

            return Json(null);
        }


        [RestrictToAjax]
        [HttpPost]
        public ActionResult Policlinics()
        {
            List<Policlinic> policlinics = null;

            if (ModelState.IsValid)
            {
                policlinics = DataService.Service.PoliclinicService.SelectAll();
            }

            return View(policlinics);
        }

        public PartialViewResult Add()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Add(Policlinic policlinicData)
        {
            DataService.Service.PoliclinicService.Insert(policlinicData);
            return RedirectToAction("Main", "User");
        }

        public PartialViewResult Update()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Update(Policlinic newPoliclinicData)
        {
            DataService.Service.PoliclinicService.Update(newPoliclinicData);
            return RedirectToAction("Main", "User");
        }

        [HttpPost]
        public ActionResult Delete(int policlinicId)
        {
            DataService.Service.PoliclinicService.SuperDelete(policlinicId);
            return RedirectToAction("Main", "User");
        }
    }
}