using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductsTests : ClassTests<IProduct>
    {
        private Products products;

        [TestInitialize]
        public void InitializeTest()
        {
            products = new Products();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            products = null;
        }


        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(products);
        }

        [TestMethod]
        public void InstanceTest()
        {
            TestSingleton(() => Products.Instance);
        }
    }
}
