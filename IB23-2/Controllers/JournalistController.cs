using System.Web.Mvc;

namespace IB23_2.Controllers
{
    [Authorize(Users = "journalist")]
    public class JournalistController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}