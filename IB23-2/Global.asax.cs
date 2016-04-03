using IB23_2.Models;
using System;
using System.Data.SqlClient;
using System.Threading;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace IB23_2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public Timer timer;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Shedule sh = new Shedule();
            sh.Start();
            Application["Shedule"] = sh; // чтобы была ссылка на класс (анти-GC)
        }

    }
}
