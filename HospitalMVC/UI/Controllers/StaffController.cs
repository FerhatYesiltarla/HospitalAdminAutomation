using DAL.ORM.Entity;
using System.Collections.Generic;
using System.Web.Mvc;
using UI.Security.Authentication;
using UI.Service;

namespace UI.Controllers
{
    public class StaffController : Controller
    {
        [RestrictToAjax]
        [HttpPost]
        public ActionResult Staffs()
        {
            List<Staff> staffs = null;

            if (ModelState.IsValid)
            {
                staffs = DataService.Service.StaffService.SelectAll();
            }

            return View(staffs);
        }
    }
}