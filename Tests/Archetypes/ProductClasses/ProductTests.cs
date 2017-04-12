using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductTests : ClassTests<Product<ProductType>>
    {
        [TestMethod]
        public void TypeIdTest()
        {
            var o = new ProductType();
            TestProperty(() => o.TypeId, x => o.TypeId = x);
        }
    }
}