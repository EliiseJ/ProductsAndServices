using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductTypesTests : CommonTests<ProductTypes>
    {
        protected override ProductTypes GetRandomObj()
        {
            return ProductTypes.Random();
        }

        [TestMethod]
        public void FindTest()
        {
            var s = GetRandom.String();
            Assert.IsNull(ProductTypes.Find(s));
            var t = ProductType.Random();
            t.UniqueId = s;
            ProductTypes.Instance.Add(t);
            ProductTypes.Instance.AddRange(ProductTypes.Random());
            Assert.AreEqual(t, ProductTypes.Find(s));
        }

        [TestMethod]
        public void InstanceTest()
        {
            TestSingleton(() => ProductTypes.Instance);
        }
    }
}
