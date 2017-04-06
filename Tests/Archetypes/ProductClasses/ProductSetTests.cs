using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductSetTests
    {
        private ProductSet set;

        [TestInitialize]
        public void InitializeTest()
        {
            set = new ProductSet();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            set = null;
        }

        [TestMethod]
        public void AddProductReferenceTest()
        {
            set.addProductReference(new ProductIdentifier());
            Assert.AreEqual(1, set.productIdentifiers.Count);
        }

        [TestMethod]
        public void CountTest()
        {
            Assert.AreEqual(0, set.Count());
        }
    }
}
