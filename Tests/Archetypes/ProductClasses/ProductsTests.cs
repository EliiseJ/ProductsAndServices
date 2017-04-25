using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductsTests : ClassTests<Products>
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

        protected override Products GetRandomObj()
        {
            return Products.Random();
        }
    }
}
