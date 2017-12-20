using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Security.Authentication
{
    public class RestrictToAjaxAttribute : ActionFilterAttribute
    {        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.HttpContext.Request.IsAjaxRequest())
            {
                filterContext.Result = new RedirectResult("/home/index");
            }
        }
    }
}

//Silebilirsi bu clasııııı