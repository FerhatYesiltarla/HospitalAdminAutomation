using System.Web.Mvc;
using UI.Security.Authentication;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [BasicAuth]
        public ActionResult Index()
        {
            return View();
        }  
    }
}