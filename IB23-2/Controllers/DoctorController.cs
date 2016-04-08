using System.EnterpriseServices;
using System.Linq;
using System.Web.Helpers;
using System.Web.Mvc;
using IB23_2.Models;
using System.Collections.Generic;

namespace IB23_2.Controllers
{
    [Authorize(Users = "doctor")]
    public class DoctorController : Controller
    {
        readonly IbDbContext _db = new IbDbContext();
        //
        // GET: /Doctor/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Personal(string number)
        {
            return Json(_db.People.Where(x => x.Insurance == number).Select(x => new {
                x.Id, x.Name, x.Insurance
            }), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Illness(int id)
        {
            /*var list = _db.Illness2People.Join(
                _db.Illness,
                ill => ill.Id,
                name => name.Id,
                (ill, name) => new {
                    name = name.Name
                });
            */
            return Json(_db.Illness2People.Where(x => x.PersonId == id).Select(x => new {
                illness = x.IllnessId
            }), JsonRequestBehavior.AllowGet);
        }
	}
}