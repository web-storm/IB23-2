using System.Web.Mvc;

namespace IB23_2.Controllers
{
    [Authorize(Users = "doctor")]
    public class DoctorController : Controller
    {
        //
        // GET: /Doctor/
        public ActionResult Index()
        {
            return View();
        }
	}
}