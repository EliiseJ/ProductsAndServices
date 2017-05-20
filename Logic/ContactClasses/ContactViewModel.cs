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
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
