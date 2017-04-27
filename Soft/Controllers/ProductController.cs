using System.Collections.Generic;
using Open.Logic.ProductClasses;
using System.Web.Mvc;
using Open.Archetypes.ProductClasses;

namespace Soft.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var product = ProductInstance.Random();
            Products.Instance.Add(product);
            var model = new List<ProductViewModel>();
            foreach (var p in Products.Instance)
            {
                model.Add(new ProductViewModel(p));
            }
            return View(model);
        }

        public ActionResult AddBook()
        {
            var b = new ProductEditModel();
            return View("AddBook", b);
        }
    }
}