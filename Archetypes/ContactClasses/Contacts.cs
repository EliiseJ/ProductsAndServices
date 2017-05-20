using System;
using System.Collections.Generic;
using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ContactClasses
{
    public class Contacts: Archetypes<ContactInstance>
    {
        public static Contacts Instance = new Contacts();

        public string UniqueId;
        public string FirstName;
        public string LastName;

        public static Contacts Random()
        {
            var r = new Contacts();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(ContactInstance.Random());
            return r;
        }

        public void AddRange(List<ContactInstance> list)
        {
            Safe.Run(() =>
            {
                isAddReange = true;
                foreach (var e in list) Add(e);
                isAddReange = false;
                DoOnChanged(list);
            });
        }
    }
}
