using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
using Open.Logic.ProductClasses;

namespace Open.Tests.Logic.ProductClasses
{
    [TestClass]
    public class ProductEditModelTests : ClassTests<ProductEditModel>
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
            var obj = new ProductEditModel(product);
            TestProperty(() => obj.Id, x => obj.Id = x, product.UniqueId);
        }

        [TestMethod]
        public void NameTest()
        {
            var obj = new ProductEditModel(product);
            TestProperty(() => obj.Name, x => obj.Name = x, product.Name);
        }

        [TestMethod]
        public void GenreTest()
        {
            var obj = new ProductEditModel(product);
            TestProperty(() => obj.Genre, x => obj.Genre = x, product.TypeId);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var obj = new ProductEditModel(product);
            TestProperty(() => obj.Genre, x => obj.Genre = x, product.TypeId);
            ProductInstance newInstance = ProductInstance.Random();
            obj.Update(newInstance);
            TestProperty(() => obj.Genre, x => obj.Genre = x, newInstance.TypeId);
        }
    }
}

