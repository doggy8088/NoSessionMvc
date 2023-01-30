using NoSessionMvc.TempDataProviders;
using System.Threading;
using System.Web.Mvc;

namespace NoSessionMvc.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.ReadOnly)]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = Session["State"] ?? TempData["Message"] ?? "No Data";

            return View();
        }

        public ActionResult Contact()
        {
            TempData["Message"] = "TempData from Contact.";

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}