using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class CatalogEntryTests : CommonTests<CatalogEntry>
    {
        protected override CatalogEntry GetRandomObj()
        {
            return CatalogEntry.Random();
        }

        [TestMethod]
        public void CatalogIdTest()
        {
            Obj = new CatalogEntry();
            TestProperty(() => Obj.CatalogId, x => Obj.CatalogId = x);
        }

        [TestMethod]
        public void ProductIdTest()
        {
            Obj = new CatalogEntry();
            TestProperty(() => Obj.ProductId, x => Obj.ProductId = x);
        }

        [TestMethod]
        public void DescriptionTest()
        {
            Obj = new CatalogEntry();
            TestProperty(() => Obj.Description, x => Obj.Description = x);
        }
        [TestMethod]
        public void ProductInstanceIdTest()
        {
            Obj = new CatalogEntry();
            TestProperty(() => Obj.ProductInstanceId, x => Obj.ProductInstanceId = x);
        }
        [TestMethod]
        public void ProductTypeTest()
        {
            var t = ProductType.Random();
            Obj.ProductInstanceId = t.UniqueId;
            ProductTypes.Instance.Add(t);
            Assert.AreEqual(t, Obj.ProductType);
        }

        [TestMethod]
        public void TypeTest()
        {
            var t = ProductType.Random();
            Obj.TypeId = t.UniqueId;
            ProductTypes.Instance.Add(t);
            Assert.AreEqual(t, Obj.Type);
        }

        [TestMethod]
        public void GetCategoriesTest()
        {

        }
    }
}
