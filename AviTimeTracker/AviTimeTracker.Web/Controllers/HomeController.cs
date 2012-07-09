using System.Web.Mvc;

namespace AviTimeTracker.Web.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }
    }
}