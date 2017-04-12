using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductsTests : ClassTests<IProduct>
    {
        private Products p;

        [TestMethod]
        public void ConstructorTest()
        {
            var a = new Products().GetType();
            Assert.AreEqual(a, typeof(Products));
        }

        [TestMethod]
        public void InstanceTest()
        {
            TestSingleton(() => Products.Instance);
        }
    }
}
