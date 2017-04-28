using System.Collections.Generic;
using Open.Logic.ProductClasses;
using System.Web.Mvc;
using Open.Archetypes.ProductClasses;

namespace Soft.Controllers
{
    public class ProductController : Controller
    {
        private static bool isCreated;
        public ActionResult Index()
        {
            if (!isCreated) Products.Instance.AddRange(Products.Random(10, 30));
            isCreated = true;
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