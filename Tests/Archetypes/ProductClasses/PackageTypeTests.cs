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
            packageType = new PackageType(PricingStrategy.Aggregated);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            packageType = null;
        }

        [TestMethod]
        public void PackageTypeConstructorTest()
        {
            expected = "Aggregated";
            actual = packageType.PricingStrategy.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}