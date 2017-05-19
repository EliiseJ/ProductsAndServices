using System.Web.Mvc;

namespace Soft.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Products and Services Library";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Products and Services";

            return View();
        }

        public ActionResult Customer()
        {
            ViewBag.Message = "Customer Page";

            return View();
        }
    }
}