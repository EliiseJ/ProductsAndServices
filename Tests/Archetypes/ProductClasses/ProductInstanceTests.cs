using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductInstanceTests
    {
        private ProductInstance i;

        [TestInitialize]
        public void InitializeTest()
        {
            i = new ProductInstance();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            i = null;
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(i);
        }

        [TestMethod]
        public void NameTest()
        {
            var x = GetRandom.String();
            i.SetValue(ref x, i.Name);
            Assert.AreEqual(i.Name, x);
        }

        //[TestMethod]
        //public void ProductTypeTest()
        //{
        //    var x = new ProductType();
        //    i.SetValue(ref x, i.ProductType);
        //    Assert.AreEqual(i.ProductType, x);
        //}

        //[TestMethod]
        //public void PriceTest()
        //{
        //    var x = new Price();
        //    i.SetValue(ref x, i.Price);
        //    Assert.AreEqual(i.Price, x);
        //}
    }
}
