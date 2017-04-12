using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductInstanceTests : CommonTests<ProductInstance>
    {
        //private ProductInstance i;

        //[TestInitialize]
        //public void InitializeTest()
        //{
        //    i = new ProductInstance();
        //}

        //[TestCleanup]
        //public void TestCleanup()
        //{
        //    i = null;
        //}

        //[TestMethod]
        //public void ConstructorTest()
        //{
        //    Assert.IsNotNull(i);
        //}

        [TestMethod]
        public void NameTest()
        {
            TestProperty(() => Obj.Name, x => Obj.Name = x);
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
        public void PriceTest()
        {
            TestProperty(() => Obj.Price, x => Obj.Price = x);
        }
        protected override ProductInstance GetRandomObj()
        {
            return ProductInstance.Random();
        }
    }
}
