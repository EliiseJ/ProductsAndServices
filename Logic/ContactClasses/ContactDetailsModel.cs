using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Open.Archetypes.ContactClasses;
using Open.Archetypes.ProductClasses;

namespace Open.Logic.ContactClasses
{
    public class ContactDetailsModel
    {
        public List<ProductInstance> LendedBooks { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        public string CustomerId { get; set; }

        public ContactDetailsModel() { }
        public ContactDetailsModel(ContactInstance contact)
        {
            FirstName = contact.FirstName;
            LastName = contact.LastName;
            CustomerId = contact.UniqueId;
            LendedBooks = new List<ProductInstance>();
        }
    }
}
