using Open.Logic.ProductClasses;
using System.Web.Mvc;

namespace Soft.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddBook()
        {
            var b = new ProductEditModel();
            return View("AddBook", b);
        }
    }
}