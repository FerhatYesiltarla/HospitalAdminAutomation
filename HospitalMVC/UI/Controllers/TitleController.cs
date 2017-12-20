using DAL.ORM.Entity;
using System.Collections.Generic;
using System.Web.Mvc;
using UI.Security.Authentication;
using UI.Service;

namespace UI.Controllers
{
    public class TitleController : Controller
    {
        // GET: Title
        [HttpPost]
        public ActionResult Title(int Id)
        {
            Title title = null;

            if (ModelState.IsValid)
            {

                title = DataService.Service.TitleService.SelectFirst(x => x.Id == Id);
                return Json(title);
            }

            return Json(null);
        }

        [RestrictToAjax]
        [HttpPost]
        public ActionResult Titles()
        {
            List<Title> titles = null;

            if (ModelState.IsValid)
            {
                titles = DataService.Service.TitleService.SelectAll();
            }

            return View(titles);
        }

        public PartialViewResult Add()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Add(Title titleData)
        {
            DataService.Service.TitleService.Insert(titleData);
            return RedirectToAction("Main", "User");
        }

        public PartialViewResult Update()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Update(Title newTitleData)
        {
            DataService.Service.TitleService.Update(newTitleData);
            return RedirectToAction("Main", "User");
        }

        [HttpPost]
        public ActionResult Delete(int titleId)
        {
            DataService.Service.TitleService.SuperDelete(titleId);
            return RedirectToAction("Main", "User");
        }
    }
}