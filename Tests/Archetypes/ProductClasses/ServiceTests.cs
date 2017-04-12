using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
using System.Web.Services.Description;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ServiceTests : ClassTests<Service<ServiceType>>
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var a = new Service().GetType();
            Assert.AreEqual(a, typeof(Product<ServiceType>));
        }

        [TestMethod]
        public void TypeIdTest()
        {
            var o = new ServiceType();
            TestProperty(() => o.TypeId, x => o.TypeId = x);
        }
    }
}