using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductSetTests : ClassTests<ProductSet>
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var a = new ProductSet().GetType();
            Assert.AreEqual(a, typeof(ProductSet));
        }

        //[TestMethod]
        //public void AddProductReferenceTest()
        //{
        //    set.AddProductReference(new ProductIdentifier());
        //    Assert.AreEqual(1, set.ProductIdentifiers.Count);
        //}

        //[TestMethod]
        //public void CountTest()
        //{
        //    Assert.AreEqual(0, set.Count());
        //}
    }
}
