using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductSetsTests : CommonTests<ProductSets>
    {
        protected override ProductSets GetRandomObj()
        {
            return ProductSets.Random();
        }

        [TestMethod]
        public void InstanceTest()
        {
            TestSingleton(() => ProductSets.Instance);
        }
    }
}
