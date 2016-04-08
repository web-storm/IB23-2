using System.Linq;
using System.Web.Mvc;
using IB23_2.Models;

namespace IB23_2.Controllers
{
    public class HomeController : Controller
    {

        readonly IbDbContext _db = new IbDbContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Rules()
        {
            return View();
        }
        public ActionResult News()
        {
            return View(_db.News.Where(x => x.IsVisible).ToList().LastOrDefault());
        }
    }
}