using System.Collections.Generic;
using Open.Logic.ProductClasses;
using System.Web.Mvc;
using Open.Archetypes.ProductClasses;
using System.Net;
using System.Web.Routing;
using Open.Aids;
using Open.Archetypes.ContactClasses;
using Open.Data;
using Open.Logic.ContactClasses;

namespace Soft.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            Products.Instance.Clear();
            Products.Instance.AddRange(BusinessProduct.Load());
            
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
            e.Update(book);
            BusinessProduct.SaveProductInstance(book);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var book = Products.Instance.Find(x => x.IsThisUniqueId(id));
            if (book == null) return HttpNotFound();
            if (book.Product != null) return View("EditProduct", new ProductEditModel(book));
            return View("Index");
        }

        [HttpPost]
        public ActionResult EditProduct([Bind(Include = "Id,Name,Genre")] ProductEditModel p)
        {
            if (!ModelState.IsValid) return View("EditProduct", p);
            var book = Products.Instance.Find(x => x.IsThisUniqueId(p.Id));
            if (book == null) return HttpNotFound();
            p.Update(book);
            BusinessProduct.UpdateProductInstance(book);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var book = Products.Instance.Find(x => x.IsThisUniqueId(id));
            if (book == null) return HttpNotFound();
            if (book.Product != null) BusinessProduct.DeleteProductInstance(book);
            return RedirectToAction("Index");
        }

        public ActionResult Details(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var book = Products.Instance.Find(x => x.IsThisUniqueId(id));
            if (book == null) return HttpNotFound();
            if (book.Product != null) return View("ProductDetails", new ProductDetailsModel(book));
            return View("Index");
        }
        public ActionResult LendBook()
        {
            if (!ModelState.IsValid) return View("LendBook");
            var model = new LendBookModel();
            model.Products = BusinessProduct.GetProducts();
            model.Contacts = BusinessContact.GetContacts();
            return View("LendBook", model);
        }

        [HttpPost]
        public ActionResult LendBook(LendBookModel e)
        {
            if (!ModelState.IsValid) return View("LendBook");

            BusinessProduct.LendBook(e.SelectedProductId, e.SelectedCustomerId);

            RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
            routeValueDictionary.Add("id", e.SelectedCustomerId);
            return RedirectToAction("CustomerDetails", "Customer", routeValueDictionary);
        }
        public ActionResult ReturnBook()
        {

            var model = new ReturnBookModel();
            model.Contacts = BusinessContact.GetContacts();

            return View("ReturnBook", model);
        }

        public ActionResult ReturnBookImpl(string id, string customerId)
        {
            BusinessProduct.ReturnBook(id);
            RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
            routeValueDictionary.Add("id", customerId);
            return RedirectToAction("CustomerDetails", "Customer", routeValueDictionary);
        }
    }
}