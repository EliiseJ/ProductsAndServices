using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
using Open.Logic.ProductClasses;

namespace Open.Tests.Logic.ProductClasses
{
    [TestClass]
    public class ProductViewModelTests : ClassTests<ProductViewModel>
    {
        private ProductInstance product;

        [TestInitialize]
        public void Initialize()
        {
            product = ProductInstance.Random();
        }

        [TestMethod]
        public void IdTest()
        {
            var obj = new ProductViewModel(product);
            TestProperty(() => obj.Id, x => obj.Id = x, product.UniqueId);
        }

        [TestMethod]
        public void NameTest()
        {
            var obj = new ProductViewModel(product);
            TestProperty(() => obj.Name, x => obj.Name = x, product.Name);
        }

        [TestMethod]
        public void GenreTest()
        {
            var obj = new ProductViewModel(product);
            TestProperty(() => obj.Genre, x => obj.Genre = x, product.TypeId);
        }
    }
}
