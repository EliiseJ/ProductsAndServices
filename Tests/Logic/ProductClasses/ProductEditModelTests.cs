using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Logic.ProductClasses;

namespace Open.Tests.Logic.ProductClasses
{
    [TestClass]
    public class ProductEditModelTests : ClassTests<ProductViewModel>
    {
        [TestMethod]
        public void IdTest()
        {
            var obj = new ProductEditModel();
            TestProperty(() => obj.Id, x => obj.Id = x);
        }

        [TestMethod]
        public void NameTest()
        {
            var obj = new ProductEditModel();
            TestProperty(() => obj.Name, x => obj.Name = x);
        }

        [TestMethod]
        public void GenreTest()
        {
            var obj = new ProductEditModel();
            TestProperty(() => obj.Genre, x => obj.Genre = x);
        }
    }
}

