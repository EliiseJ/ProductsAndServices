using System.Collections.Generic;
using System.Net;
using Open.Logic.ContactClasses;
using System.Web.Mvc;
using Open.Data;
using Open.Archetypes.ContactClasses;
using Open.Aids;

namespace Soft.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            Contacts.Instance.Clear();
            Contacts.Instance.AddRange(BusinessContact.Load());

            var model = new List<ContactViewModel>();
            foreach (var p in Contacts.Instance)
            {
                model.Add(new ContactViewModel(p));
            }
            return View(model);
        }
        public ActionResult AddCustomer()
        {
            var b = new ContactEditModel();
            return View("AddCustomer", b);
        }
        [HttpPost]
        public ActionResult AddCustomer([Bind(Include = "Id,FirstName,LastName")] ContactEditModel e)
        {
            if (!ModelState.IsValid) return View("AddCustomer", e);
            var contact = new ContactInstance { Contact = new Contacts() };
            contact.UniqueId = GetRandom.String();
            e.Update(contact);
            BusinessContact.SaveContactInstance(contact);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var contact = Contacts.Instance.Find(x => x.IsThisUniqueId(id));
            if (contact == null) return HttpNotFound();
            if (contact.Contact != null) return View("EditCustomer", new ContactEditModel(contact));
            return View("Index");
        }

        [HttpPost]
        public ActionResult EditCustomer([Bind(Include = "Id,FirstName,LastName")] ContactEditModel c)
        {
            if (!ModelState.IsValid) return View("EditCustomer", c);
            var contact = Contacts.Instance.Find(x => x.IsThisUniqueId(c.Id));
            if (contact == null) return HttpNotFound();
            c.Update(contact);
            BusinessContact.UpdateContactInstance(contact);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var contact = Contacts.Instance.Find(x => x.IsThisUniqueId(id));
            if (contact == null) return HttpNotFound();
            if (contact.Contact != null) BusinessContact.DeleteContactInstance(contact);
            return RedirectToAction("Index");
        }

        public ActionResult CustomerDetails(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var contact = Contacts.Instance.Find(x => x.IsThisUniqueId(id));
            if (contact == null) return HttpNotFound();
            if (contact.Contact != null) return View("CustomerDetails", new ContactDetailsModel(contact));
            return View("Index");
        }
    }
}