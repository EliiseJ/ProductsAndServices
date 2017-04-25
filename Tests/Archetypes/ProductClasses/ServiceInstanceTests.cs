using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
using System.Web.Services.Description;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ServiceInstanceTests : ClassTests<ServiceInstance>
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var a = new Service().GetType().BaseType;
            Assert.AreEqual(a, typeof(ProductInstance));
        }
    }
}