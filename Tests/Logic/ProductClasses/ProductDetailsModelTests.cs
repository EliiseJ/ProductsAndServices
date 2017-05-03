using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
using Open.Logic.ProductClasses;

namespace Open.Tests.Logic.ProductClasses
{
    [TestClass]
    public class ProductDetailsModelTests : ClassTests<ProductDetailsModel>
    {
        private ProductInstance product;

        [TestInitialize]
        public void Initialize()
        {
            product = ProductInstance.Random();
        }

        [TestMethod]
        public void NameTest()
        {
            var obj = new ProductDetailsModel(product);
            TestProperty(() => obj.Name, x => obj.Name = x, product.Name);
        }

        [TestMethod]
        public void GenreTest()
        {
            var obj = new ProductDetailsModel(product);
            TestProperty(() => obj.Genre, x => obj.Genre = x, product.TypeId);
        }
    }
}

