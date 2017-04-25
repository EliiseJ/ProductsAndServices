using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class PackageTypeTests : CommonTests<PackageType>
    {
        protected override PackageType GetRandomObj()
        {
            return PackageType.Random();
        }

        [TestMethod]
        public void ConstructorTest()
        {
            var a = new PackageType().GetType().BaseType;
            Assert.AreEqual(a, typeof(ProductType));
        }

        [TestMethod]
        public void AddProductTypeTest()
        {
            var p = ProductType.Random();
            var c = ProductTypes.Instance.Count;
            Obj.AddProductType(p);
            Assert.AreEqual(c + 1, ProductTypes.Instance.Count);
            Assert.AreEqual(p, ProductTypes.Instance.Find(x => x.IsSameContent(p)));
        }

        [TestMethod]
        public void AddProductSetTest()
        {
            var p = ProductSet.Random();
            var c = ProductSets.Instance.Count;
            Obj.AddProductSet(p);
            Assert.AreEqual(c + 1, ProductSets.Instance.Count);
            Assert.AreEqual(p, ProductSets.Instance.Find(x => x.IsSameContent(p)));
        }

        [TestMethod]
        public void GetComponentsTest()
        {
            Obj.AddProductType(new ProductType());
            Assert.AreEqual(ProductTypes.Instance.Get(0), Obj.GetComponents()[0]);
        }

        [TestMethod]
        public void GetPricesTest()
        {
            Prices.Instance.Add(new Price());
            Assert.AreEqual(Prices.Instance.Get(0), Obj.GetPrices()[0]);
        }

        [TestMethod]
        public void ValidatePackageTest()
        {
            Assert.AreEqual(false, Obj.ValidatePackage());
        }
    }
}