using Open.Archetypes.ContactClasses;

namespace Open.Logic.ContactClasses
{
    public class ContactDetailsModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ContactDetailsModel() { }
        public ContactDetailsModel(ContactInstance contact)
        {
            FirstName = contact.FirstName;
            LastName = contact.LastName;
        }
    }
}
