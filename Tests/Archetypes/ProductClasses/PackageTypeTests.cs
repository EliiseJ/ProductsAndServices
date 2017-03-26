using System.Linq;
using Archetypes.ProductClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;

namespace Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class PackageTypeTests
    {
        private PackageType packageType;
        private string expected;
        private string actual;

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
        public void addProductTypeTest()
        {
            packageType.addProductType(new ProductType());
            Assert.AreEqual(1, ProductTypes.Instance.Count);
        }

        [TestMethod]
        public void getComponentsTest()
        {
            packageType.addProductType(new ProductType());
            Assert.AreEqual(ProductTypes.Instance.Get(0), packageType.getComponents()[0]);
        }

        [TestMethod]
        public void getPricesTest()
        {
            Prices.Instance.Add(new Price());
            Assert.AreEqual(Prices.Instance.Get(0), packageType.getPrices()[0]);
        }

        [TestMethod]
        public void validatePackageTest()
        {
            Assert.AreEqual(false, packageType.validatePackage());
        }


        /*[TestMethod]
        public void PackageTypeConstructorTest()
        {
            expected = "Aggregated";
            actual = packageType.PricingStrategy.ToString();
            Assert.AreEqual(expected, actual);
        }*/
    }
}