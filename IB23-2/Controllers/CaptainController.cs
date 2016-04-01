using System.Web.Security;
using IB23_2.Models;
using System;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace IB23_2.Controllers
{
    [Authorize(Users = "captain")]
    public class CaptainController : Controller
    {
        private IbDbContext db = new IbDbContext();

        public ActionResult Index()
        {
            return RedirectToAction("Report");
        }
        
        public ActionResult Report()
        {
            return View(db.Codes.Where(x => x.SessionId != 0)
                .ToList().Last().SessionId);
        }

        public static string ConvertToJson(Type e)
        {

            var ret = "{";

            foreach (var val in Enum.GetValues(e))
            {

                var name = Enum.GetName(e, val);

                ret += name + ":" + ((int)val).ToString() + ",";

            }
            ret += "}";
            return ret;

        }

        public JsonResult GetSession(int number)
        {
            return Json(db.Codes.Where(x => x.SessionId == number).Select(
                x => new
                {
                    function = x.EmployeeId,
                    status = x.Pos4 + x.Pos5 == 4
                        ? "<span class=\"label label-success\">Success</span>"
                        : x.Pos4 + x.Pos5 == 3
                            ? "<span class=\"label label-warning\">Warning</span>"
                            : "<span class=\"label label-danger\">Critical</span>",
                    reportString = x.Pos4 + x.Pos5 == 4
                        ? "Функция выполнена на 100%"
                        : x.Pos4 + x.Pos5 == 3
                            ? "Функция выполнена на 50%"
                            : "Функция выполнена на 0%"
                }
                ), JsonRequestBehavior.AllowGet);
        }
	}
}