using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class PackageInstanceTests : CommonTests<PackageInstance>
    {
        protected override PackageInstance GetRandomObj()
        {
            return PackageInstance.Random();
        }

        [TestMethod]
        public void ConstructorTest()
        {
            var a = new PackageInstance().GetType().BaseType;
            Assert.AreEqual(a, typeof(ProductInstance));
        }

        [TestMethod]
        public void GetContentsTest()
        {
            Assert.IsNotNull(Obj.Contents());
        }
    }
}

