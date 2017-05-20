using System.Data.Entity;
using Open.Archetypes.ContactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations;

namespace Open.Data
{
    public class BusinessContact : DbContext
    {
        private static ContactBook db = new ContactBook();

        public static void SaveContacts(Contacts instance)
        {
            foreach (var i in instance)
            {
                db.Contacts.Add(new ContactDal(i));
            }
            db.SaveChanges();
        }

        public static void SaveContactInstance(ContactInstance instance)
        {
            db.Contacts.Add(new ContactDal(instance));
            db.SaveChanges();
        }

        public static void DeleteContactInstance(ContactInstance instance)
        {
            ContactDal dbContactDal = db.Contacts.Find(instance.UniqueId);
            if (dbContactDal == null)
            {
                Console.WriteLine("Couldn't find entity to delete!");
            }
            else
            {
                db.Contacts.Remove(entity: dbContactDal);
                db.SaveChanges();
            }
        }

        public static List<ContactInstance> Load()
        {
            var list = new List<ContactInstance>();
            foreach (var u in db.Contacts)
            {
                var au = new ContactInstance();
                au.UniqueId = u.Id;
                au.FirstName = u.FirstName;
                au.LastName = u.LastName;
                list.Add(au);
            }
            return list;
        }

        public static void UpdateContactInstance(ContactInstance instance)
        {
            ContactDal dbContactDal = db.Contacts.Find(instance.UniqueId);
            if (dbContactDal == null)
            {
                Console.WriteLine("Couldn't find entity to update!");
            }
            else
            {
                dbContactDal.FirstName = instance.FirstName;
                dbContactDal.LastName = instance.LastName;
                db.Contacts.AddOrUpdate(dbContactDal);
                db.SaveChanges();
            }
        }
    }

    public class ContactBook : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.Entity<ContactDal>().ToTable("Customers");
            base.OnModelCreating(mb);
        }

        public DbSet<ContactDal> Contacts { get; set; }
    }

    public class ContactDal
    {
        public ContactDal() { }
        public ContactDal(ContactInstance c)
        {
            Id = c.UniqueId;
            FirstName = c.FirstName;
            LastName = c.LastName;
        }

        [Key]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
