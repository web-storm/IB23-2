using System.Web.Mvc;
using IB23_2.Models;

namespace IB23_2.Controllers
{
    [Authorize(Users = "journalist")]
    public class JournalistController : Controller
    {
        readonly IbDbContext _db = new IbDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public void PutReport(string header, string content)
        {
            _db.News.Add(new News {Header = header, Content = content, IsVisible = false } );
            _db.SaveChanges();
        }
	}
}