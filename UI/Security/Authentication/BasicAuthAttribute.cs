using System.Web;
using System.Web.Mvc;

namespace UI.Security.Authentication
{
    public class BasicAuthAttribute : ActionFilterAttribute
    {       
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
               // if (!HttpContext.Current.Response.IsRequestBeingRedirected)
                    filterContext.Result = new RedirectResult("/Account/signIn");
            }
        }
    }
}