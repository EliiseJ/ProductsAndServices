using System.Collections.Generic;
using Open.Logic.ProductClasses;
using System.Web.Mvc;
using Open.Archetypes.ProductClasses;
using System.Net;
using Open.Aids;

namespace Soft.Controllers
{
    public class ProductController : Controller
    {
        private static bool isCreated;
        public ActionResult Index()
        {
            if (!isCreated) Products.Instance.AddRange(Products.Random(5, 10));
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
        [HttpPost]

        public ActionResult AddBook([Bind(Include = "Id,Name,Genre")] ProductEditModel e)
        {
            if (!ModelState.IsValid) return View("AddBook", e);
            var book = new ProductInstance { Product = new Products() };
            book.UniqueId = GetRandom.String();
            Products.Instance.Add(book);
            e.Update(book);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var book = Products.Instance.Find(x => x.IsThisUniqueId(id));
            if (book == null) return HttpNotFound();
            if (book.Product is Products) return View("EditProduct", new ProductEditModel(book));
            return View("Index");
        }

        [HttpPost]
        public ActionResult EditProduct([Bind(Include = "Id,Name,Genre")] ProductEditModel p)
        {
            if (!ModelState.IsValid) return View("EditProduct", p);
            var book = Products.Instance.Find(x => x.IsThisUniqueId(p.Id));
            if (book == null) return HttpNotFound();
            p.Update(book);
            return RedirectToAction("Index");
        }
    }
}