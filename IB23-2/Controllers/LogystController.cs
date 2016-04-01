using System.Linq;
using System.Web.Mvc;
using IB23_2.Models;

namespace IB23_2.Controllers
{
    [Authorize(Users = "logyst")]
    public class LogystController : Controller
    {
        private readonly IbDbContext _db = new IbDbContext();

        public ActionResult Index()
        {
            return View(); 
        }

        public ActionResult List()
        {
            return View(_db.Codes.Where(x => x.SessionId == 0).Select(item => item.EmployeeId));
        }

        public string Add(int pos1, int pos2, int pos3, int pos4, int pos5)
        {           
            var isAlreadyAdded = _db.Codes.Where(x => x.SessionId == 0).Count(x => 
                (x.Pos1 == pos1 && x.Pos2 == pos2 && x.Pos3 == pos3)) != 0;
            var isSessionfinished = _db.Codes.Count(x => x.SessionId == 0) == 10;
            if (!isAlreadyAdded && !isSessionfinished)
            {
                _db.Codes.Add(
                    new Code(
                    pos1, pos2, pos3, pos4, pos5));
                _db.SaveChanges();
            }
            return isAlreadyAdded 
                ? "Такой отчет уже был добавлен!" 
                : isSessionfinished ? "Все 10 отчетов заполнены! Необходимо начать новую сессию!"
                                    :"Отчет успешно добавлен!" ;
        }

        public string NewSession()
        {
            var isSessionfinished = _db.Codes.Count(x => x.SessionId == 0) == 10;
            if (isSessionfinished)
            {
                _db.Sessions.Add(new Session());
                _db.SaveChanges();
                var newSessionId = _db.Sessions.Select(x => x.Id).ToList().Last();
                var codes = _db.Codes.Where(x => x.SessionId == 0);
                foreach (var code in codes) 
                {
                    code.SessionId = newSessionId;
                }
                _db.SaveChanges();
            }
            //TODO:
            //здесь должен быть код разработки отчета для капитана и очищения таблицы кодов.
            return isSessionfinished 
                ? "Начинаем новую сессию.."
                : "Вы не можете начать новую сесию! Проверьте наличие всех отчетов!";
        }
	}
}