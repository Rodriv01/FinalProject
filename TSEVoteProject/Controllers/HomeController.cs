using System.Linq;
using System.Web.Mvc;

namespace TSEVoteProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Current = "Home";
            return View();
        }
        public ActionResult Results()
        {
            return View();
        }

        public JsonResult SurveyQuiz()
        {
            var poll = new
            {
                question = "Which is your favourite fruit?",
                choices = VotingHub.poll.Select(x => new { name = x.Key, count = x.Value }).ToList()
            };
            return Json(poll, JsonRequestBehavior.AllowGet);
        }
    }
}