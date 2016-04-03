using IB23_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IB23_2.Controllers
{
    public class TimerController : Controller
    {
        IbDbContext _db = new IbDbContext();
        public ActionResult Index()
        {
            var time = _db.Cycles.Select(x => x.StartTime).ToList().LastOrDefault();
            var delta = DateTime.Now - time;
            var parameter = 20 * 60 * 1000 - (int)delta.TotalSeconds*1000;
            return View(parameter);
        }
	}
}