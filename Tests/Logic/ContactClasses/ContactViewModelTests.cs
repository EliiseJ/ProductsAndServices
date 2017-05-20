using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ContactClasses;
using Open.Logic.ContactClasses;

namespace Open.Tests.Logic.ContactClasses
{
    [TestClass]
    public class ContactViewModelTests : ClassTests<ContactViewModel>
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
            var obj = new ContactViewModel(contact);
            TestProperty(() => obj.Id, x => obj.Id = x, contact.UniqueId);
        }

        [TestMethod]
        public void FirstNameTest()
        {
            var obj = new ContactViewModel(contact);
            TestProperty(() => obj.FirstName, x => obj.FirstName = x, contact.FirstName);
        }

        [TestMethod]
        public void LastNameTest()
        {
            var obj = new ContactViewModel(contact);
            TestProperty(() => obj.LastName, x => obj.LastName = x, contact.LastName);
        }
    }
}
