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
            set.AddProductReference(new ProductIdentifier());
            Assert.AreEqual(1, set.ProductIdentifiers.Count);
        }

        [TestMethod]
        public void CountTest()
        {
            Assert.AreEqual(0, set.Count());
        }
    }
}
