using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ContactClasses;

namespace Open.Tests.Archetypes.ContactClasses
{
    public class ContactsTests : CommonTests<Contacts>
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var a = new Contacts().GetType();
            Assert.AreEqual(a, typeof(Contacts));
        }

        [TestMethod]
        public void InstanceTest()
        {
            TestSingleton(() => Contacts.Instance);
        }

        protected override Contacts GetRandomObj()
        {
            return Contacts.Random();
        }
    }
}
