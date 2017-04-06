using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass] public class ProductTests : ClassTests<Product<ProductType>>
    {
        //vaadata kuidas Piho testis BaseEntity ja ....Type

        [TestMethod]
        public void TypeIdTest()
        {
            var o = new ProductType();
            TestProperty(() => o.TypeId, x => o.TypeId = x);
        }
    }
}