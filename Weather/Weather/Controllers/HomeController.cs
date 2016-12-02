using System.Web.Mvc;

namespace Weather.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(bool? redirect)
        {
            ViewBag.Title = "Home Page";

            if (redirect.HasValue && redirect.Value)
                return RedirectToActionPermanent("Index", new { redirect = null as object });

            return View();
        }
    }
}
