using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ContactClasses;
using Open.Logic.ContactClasses;

namespace Open.Tests.Logic.ContactClasses
{
    [TestClass]
    public class ContactEditModelTests : ClassTests<ContactEditModel>
    {
        private ContactInstance contact;

        [TestInitialize]
        public void Initialize()
        {
            contact = ContactInstance.Random();
        }

        [TestMethod]
        public void IdTest()
        {
            var obj = new ContactEditModel(contact);
            TestProperty(() => obj.Id, x => obj.Id = x, contact.UniqueId);
        }

        [TestMethod]
        public void FirstNameTest()
        {
            var obj = new ContactEditModel(contact);
            TestProperty(() => obj.FirstName, x => obj.FirstName = x, contact.FirstName);
        }

        [TestMethod]
        public void LastNameTest()
        {
            var obj = new ContactEditModel(contact);
            TestProperty(() => obj.LastName, x => obj.LastName = x, contact.LastName);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var obj = new ContactEditModel(contact);
            TestProperty(() => obj.FirstName, x => obj.FirstName = x, contact.FirstName);
            ContactInstance newInstance = ContactInstance.Random();
            obj.Update(newInstance);
            TestProperty(() => obj.FirstName, x => obj.FirstName = x, newInstance.FirstName);
        }
    }
}
