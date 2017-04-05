using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class PackageTypeTests
    {
        private PackageType packageType;

        [TestInitialize]
        public void InitializeTest()
        {
            packageType = new PackageType();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            packageType = null;
        }

        [TestMethod]
        public void AddProductTypeTest()
        {
            packageType.addProductType(new ProductType());
            Assert.AreEqual(1, ProductTypes.Instance.Count);
        }

        [TestMethod]
        public void GetComponentsTest()
        {
            packageType.addProductType(new ProductType());
            Assert.AreEqual(ProductTypes.Instance.Get(0), packageType.getComponents()[0]);
        }

        [TestMethod]
        public void GetPricesTest()
        {
            Prices.Instance.Add(new Price());
            Assert.AreEqual(Prices.Instance.Get(0), packageType.getPrices()[0]);
        }

        [TestMethod]
        public void ValidatePackageTest()
        {
            Assert.AreEqual(false, packageType.validatePackage());
        }
    }
}