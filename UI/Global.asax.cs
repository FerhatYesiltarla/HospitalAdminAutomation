using System.Web.Mvc;
using System.Web.Routing;
using UI.App_Start;

namespace UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters); 
            
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
