using System;
using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ContactClasses
{
    public class ContactInstance: Archetype
    {
        private string firstName;
        private string lastName;
        private Contacts contact;

        public Contacts Contact
        {
            get { return SetDefault(ref contact); }
            set { SetValue(ref contact, value); }
        }

        public string FirstName
        {
            get { return SetDefault(ref firstName); }
            set { SetValue(ref firstName, value); }
        }
        public string LastName
        {
            get { return SetDefault(ref lastName); }
            set { SetValue(ref lastName, value); }
        }

        public string UniqueId { get; set; }

        public static ContactInstance Random()
        {
            var e = new ContactInstance();
            e.SetRandomValues();
            return e;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            firstName = GetRandom.String();
            lastName = GetRandom.String();
        }

        public bool IsThisUniqueId(string id)
        {
            if (IsSpaces(id)) return false;
            return UniqueId == id;
        }
    }
}
