using System.ComponentModel.DataAnnotations;
using Open.Archetypes.ContactClasses;

namespace Open.Logic.ContactClasses
{
    public class ContactEditModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Id { get; set; }

        public ContactEditModel() { }
        public ContactEditModel(ContactInstance contact)
        {
            Id = contact.UniqueId;
            FirstName = contact.FirstName;
            LastName = contact.LastName;
        }

        public void Update(ContactInstance p)
        {
            var a = p.Contact as Contacts;
            p.FirstName = FirstName;
            p.LastName = LastName;
        }
    }
}
