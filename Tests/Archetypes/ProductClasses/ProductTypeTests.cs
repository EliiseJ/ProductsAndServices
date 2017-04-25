using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductTypeTests : CommonTests<ProductType>
    {
        protected override ProductType GetRandomObj()
        {
            return ProductType.Random();
        }
        
        [TestMethod]
        public void NameTest()
        {
            Obj = new ProductType();
            TestProperty(() => Obj.Name, x => Obj.Name = x);
        }

        [TestMethod]
        public void DescriptionTest()
        {
            Obj = new ProductType();
            TestProperty(() => Obj.Description, x => Obj.Description = x);
        }

        [TestMethod]
        public void InstancesTest()
        {
            TestSingleton(() => Products.Instance);
        }

        [TestMethod]
        public void TypeTest()
        {
            Assert.IsNull(Obj.Type);
            var t = ProductType.Random();
            t.UniqueId = Obj.TypeId;
            ProductTypes.Instance.AddRange(ProductTypes.Random());
            ProductTypes.Instance.Add(t);
            Assert.AreEqual(t, Obj.Type);
        }

    }
}
