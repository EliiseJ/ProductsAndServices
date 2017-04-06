using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class PackageInstanceTests
    {
        private PackageInstance instance;

        [TestInitialize]
        public void InitializeTest()
        {
            instance = new PackageInstance();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            instance = null;
        }
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(instance);
        }
        [TestMethod]
        public void GetContentsTest()
        {
            Assert.IsNotNull(instance.Contents());
        }
    }
}
