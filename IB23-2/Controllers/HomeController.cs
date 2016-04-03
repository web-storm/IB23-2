using System.Web.Mvc;

namespace IB23_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Rules()
        {
            return View();
        }
    }
}