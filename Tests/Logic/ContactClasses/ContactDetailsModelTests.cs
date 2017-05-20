using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ContactClasses;
using Open.Logic.ContactClasses;

namespace Open.Tests.Logic.ContactClasses
{
    [TestClass]
    public class ContactDetailsModelTests : ClassTests<ContactDetailsModel>
    {
        private ContactInstance contact;

        [TestInitialize]
        public void Initialize()
        {
            contact = ContactInstance.Random();
        }

        [TestMethod]
        public void FirstNameTest()
        {
            var obj = new ContactDetailsModel(contact);
            TestProperty(() => obj.FirstName, x => obj.FirstName = x, contact.FirstName);
        }

        [TestMethod]
        public void LastNameTest()
        {
            var obj = new ContactDetailsModel(contact);
            TestProperty(() => obj.LastName, x => obj.LastName = x, contact.LastName);
        }
    }
}
