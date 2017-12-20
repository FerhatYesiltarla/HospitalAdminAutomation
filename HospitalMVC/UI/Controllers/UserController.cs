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

        [HttpPost]
        public ActionResult Hospitals()
        {
            List<Hospital> hospitals = null;

            if (ModelState.IsValid)
            {
                hospitals = DataService.Service.HospitalService.SelectAll();
            }
            return Json(hospitals);
        }

        [HttpPost]
        public ActionResult UserGet(int Id)
        {
            User user = null;

            if (ModelState.IsValid)
            {

                user = DataService.Service.UserService.SelectFirst(x => x.Id == Id);
                return Json(user);
            }

            return Json(null);
        }

        [HttpPost]
        public ActionResult Users()
        {
            List<User> users = null;

            if (ModelState.IsValid)
            {
                users = DataService.Service.UserService.SelectAll();
            }
            return View(users);
        }

        public PartialViewResult Update()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Update(User newUserData)
        {
            DataService.Service.UserService.Update(newUserData);
            return RedirectToAction("Main", "User");
        }

        [HttpPost]
        public ActionResult Delete(int userId)
        {
            DataService.Service.UserService.SuperDelete(userId);
            return RedirectToAction("Main", "User");
        }
    }
}