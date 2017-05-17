using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Open.Archetypes.ProductClasses;

namespace Open.Data
{
    public class Business: DbContext
    {
        private static ProductBook db = new ProductBook();

        public static void SaveProducts(Products instance)
        {
            foreach (var i in instance)
            {
                db.Products.Add(new ProductDal(i));
            }
            db.SaveChanges();
        }

        public static void SaveProductInstance(ProductInstance instance)
        {
            db.Products.Add(new ProductDal(instance));
            db.SaveChanges();
        }

        public static void DeleteProductInstance(ProductInstance instance)
        {
            ProductDal dbProductDal = db.Products.Find(instance.UniqueId);
            if (dbProductDal == null)
            {
                Console.WriteLine("Couldn't find entity to delete!");
            }
            else
            {
                db.Products.Remove(entity: dbProductDal);
                db.SaveChanges();
            }
        }

        public static List<ProductInstance> Load()
        {
            var list = new List<ProductInstance>();
            foreach (var u in db.Products)
            {
                var au = new ProductInstance();
                au.UniqueId = u.Id;
                au.Name = u.Name;
                au.TypeId = u.Genre;
                list.Add(au);
            }
            return list;
        }

        public static void UpdateProductInstance(ProductInstance instance)
        {
            ProductDal dbProductDal = db.Products.Find(instance.UniqueId);
            if (dbProductDal == null)
            {
                Console.WriteLine("Couldn't find entity to update!");
            }
            else
            {
                dbProductDal.Name = instance.Name;
                dbProductDal.Genre = instance.TypeId;
                db.Products.AddOrUpdate(dbProductDal);
                db.SaveChanges();
            }
        }
    }

    public class ProductBook : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.Entity<ProductDal>().ToTable("Books");
            base.OnModelCreating(mb);
        }

        public DbSet<ProductDal> Products { get; set; }
    }

    public class ProductDal
    {
        public ProductDal() { }
        public ProductDal(ProductInstance p)
        {
            Id = p.UniqueId;
            Name = p.Name;
            Genre = p.TypeId;
        }

        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
    }
}
