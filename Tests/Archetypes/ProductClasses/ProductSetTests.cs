using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductSetTests : CommonTests<ProductSet>
    {
        protected override ProductSet GetRandomObj()
        {
            return ProductSet.Random();
        }
        [TestMethod]
        public void ConstructorTest()
        {
            var a = new ProductSet().GetType();
            Assert.AreEqual(a, typeof(ProductSet));
        }

        [TestMethod]
        public void AddProductReferenceTest()
        {
            Obj.AddProductReference(new ProductIdentifier());
            Assert.AreEqual(1, Obj.ProductIdentifiers.Count);
        }

        [TestMethod]
        public void CountTest()
        {
            Assert.AreEqual(0, Obj.Count());
        }

        [TestMethod]
        public void NameTest()
        {
            TestProperty(() => Obj.Name, x => Obj.Name = x);        
        }

        [TestMethod]
        public void ProductIdentifiersTest()
        {
            TestSingleton(() => Obj.ProductIdentifiers);
        }
    }
}
