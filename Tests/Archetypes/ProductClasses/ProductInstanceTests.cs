using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductInstanceTests : CommonTests<ProductInstance>
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(Obj);
        }

        [TestMethod]
        public void NameTest()
        {
            TestProperty(() => Obj.Name, x => Obj.Name = x);
        }

        [TestMethod]
        public void SerialNumberTest()
        {
            TestProperty(() => Obj.SerialNumber, x => Obj.SerialNumber = x);
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
        public void FeatureTest()
        {
            var t = ProductFeature.Random();
            Obj.UniqueId = t.UniqueId;
            ProductFeatures.Instance.Add(t);
            Assert.AreEqual(t, Obj.Feature);
        }

        [TestMethod]
        public void PriceTest()
        {
            TestProperty(() => Obj.Price, x => Obj.Price = x);
        }
        [TestMethod]
        public void PackageIdTest()
        {
            TestProperty(() => Obj.PackageId, x => Obj.PackageId = x);
        }
        protected override ProductInstance GetRandomObj()
        {
            return ProductInstance.Random();
        }
        [TestMethod]
        public void GetRandomDerivedTest()
        {
            var a = ProductInstance.GetRandomDerived();
            var b = ProductInstance.GetRandomDerived();
            Assert.AreNotEqual(a.ToString(), b.ToString());
            Assert.AreNotEqual(string.Empty, a.ToString());
        }
    }
}
