using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using Open.Archetypes.ProductClasses;

namespace Open.Data
{
    public class Business: DbContext
    {
        public static void Save(Products instance)
        {
            var db = new ProductBook();
            foreach (var i in instance)
            {
                db.Products.Add(new ProductDal(i));
            }
            db.SaveChanges();
        }

        public static List<ProductInstance> Load()
        {
            var db = new ProductBook();
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
