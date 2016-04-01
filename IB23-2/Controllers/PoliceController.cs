using System.Web.Mvc;
using IB23_2.Models;

namespace IB23_2.Controllers
{
    [Authorize(Users = "police")]
    public class PoliceController : Controller
    {
        private IbDbContext db = new IbDbContext();
        //
        // GET: /Police/
        public ActionResult Index()
        {
            return RedirectToAction("Search");
        }

        public ActionResult Search()
        {
            return View();
        }
	}
}