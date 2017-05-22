using System.ComponentModel.DataAnnotations;
using Open.Archetypes.ContactClasses;

namespace Open.Logic.ContactClasses
{
    public class ContactViewModel
    {
        public ContactViewModel() { }
        public ContactViewModel(ContactInstance p)
        {
            Id = p.UniqueId;
            FirstName = p.FirstName;
            LastName = p.LastName;
        }
        public string Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}
