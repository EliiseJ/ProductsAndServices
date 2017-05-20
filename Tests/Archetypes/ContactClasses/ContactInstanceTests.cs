using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.ContactClasses;
namespace Open.Tests.Archetypes.ContactClasses
{
    [TestClass]
    public class ContactInstanceTests: CommonTests<ContactInstance>
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(Obj);
        }

        [TestMethod]
        public void FirstNameTest()
        {
            TestProperty(() => Obj.FirstName, x => Obj.FirstName = x);
        }

        [TestMethod]
        public void LastNameTest()
        {
            TestProperty(() => Obj.LastName, x => Obj.LastName = x);
        }

        [TestMethod]
        public void ContactTest()
        {
            TestProperty(() => Obj.Contact, x => Obj.Contact = x);
        }

        protected override ContactInstance GetRandomObj()
        {
            return ContactInstance.Random();
        }
    }
}
