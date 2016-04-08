using System.EnterpriseServices;
using System.Linq;
using System.Web.Helpers;
using System.Web.Mvc;
using IB23_2.Models;

namespace IB23_2.Controllers
{
    [Authorize(Users = "police")]
    public class PoliceController : Controller
    {
        private IbDbContext _db = new IbDbContext();
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

        public JsonResult Passport(string number)
        {
            return Json(_db.People.Where(x => x.Passport == number).Select(
                x => new
                {
                    x.Name, x.Position, x.Licence
                }
                ), JsonRequestBehavior.AllowGet);
        }
	}
}