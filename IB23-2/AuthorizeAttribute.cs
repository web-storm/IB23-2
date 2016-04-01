using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IB23_2
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class AuthorizeAttribute : System.Web.Mvc.AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(System.Web.Mvc.AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAuthenticated)
            {
                filterContext.Result = new System.Web.Mvc.RedirectToRouteResult(
                    new System.Web.Routing.RouteValueDictionary 
                    { 
                         { "action", "AuthError" },
                         { "controller", "Account" },
                         { "parameterName", "" }
                    });
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }
}