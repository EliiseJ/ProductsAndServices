using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductIdentifiersTests : CommonTests<ProductIdentifiers>
    {
        protected override ProductIdentifiers GetRandomObj()
        {
            return ProductIdentifiers.Random();
        }
        [TestMethod]
        public void InstanceTest()
        {
            TestSingleton(() => ProductIdentifiers.Instance);
        }
        [TestMethod]
        public void FindTest()
        {
            var s = GetRandom.String();
            Assert.IsNull(ProductIdentifiers.Find(s));
            var t = ProductIdentifier.Random();
            t.UniqueId = s;
            ProductIdentifiers.Instance.Add(t);
            ProductIdentifiers.Instance.AddRange(ProductIdentifiers.Random());
            Assert.AreEqual(t, ProductIdentifiers.Find(s));
        }
    }
}
