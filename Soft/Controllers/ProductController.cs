﻿using System.Collections.Generic;
using System.Data.Entity;
using Open.Logic.ProductClasses;
using System.Web.Mvc;
using Open.Archetypes.ProductClasses;
using System.Net;
using Open.Aids;
using System.Linq;

namespace Soft.Controllers
{
    public class ProductController : Controller
    {
        private static bool isCreated;
        public ActionResult Index()
        {
            if (!isCreated)
            {
                Products.Instance.AddRange(Products.Random(5));
                Business.Save(Products.Instance);
                isCreated = true;
            }
            
            Products.Instance.AddRange(Business.Load(instance: ));
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
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var book = Products.Instance.Find(x => x.IsThisUniqueId(id));
            if (book == null) return HttpNotFound();
            if (book.Product != null) Products.Instance.Remove(book);
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
        [HttpPost]
        public ActionResult LendBook([Bind(Include = "Id,Name,Genre")] ProductEditModel e)
        {
            if (!ModelState.IsValid) return View("LendBook", e);
            //TODO
            return RedirectToAction("Index");
        }

    }

    public class Business
    {
        public static void Save(Products instance)
        {
            var db = new OpenProduct();
            db.Products.Add(instance);
            db.SaveChanges();
        }

        public static List<Products> Load(Products instance)
        {
            var db = new OpenProduct();
            return db.Products.ToList();
        }
    }

    public class OpenProduct: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.Entity<Products>().ToTable("Products");
            base.OnModelCreating(mb);
        }

        public DbSet<Products> Products { get; set; }

    }
}