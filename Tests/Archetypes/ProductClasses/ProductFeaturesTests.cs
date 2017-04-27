using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    public class ProductFeaturesTests: CommonTests<ProductFeatures>
    {
        protected override ProductFeatures GetRandomObj()
        {
            return ProductFeatures.Random();
        }

        [TestMethod]
        public void InstanceTest()
        {
            TestSingleton(() => ProductFeatures.Instance);
        }

        [TestMethod]
        public void FindTest()
        {
            var s = GetRandom.String();
            Assert.IsNull(ProductFeatures.Find(s));
            var t = ProductFeature.Random();
            t.UniqueId = s;
            ProductFeatures.Instance.Add(t);
            ProductFeatures.Instance.AddRange(ProductFeatures.Random());
            Assert.AreEqual(t, ProductFeatures.Find(s));
        }
    }
}
