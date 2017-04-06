using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.ProductClasses;
using Open.Archetypes.RoleClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class PackageTypeTests: CommonTests<PackageType>
    {
        protected override PackageType GetRandomObj()
        {
            return PackageType.Random();
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            ProductTypes.Instance.AddRange(ProductTypes.Random());
        }
        [TestCleanup]
        public override void TestCleanup()
        {
            base.TestCleanup();
            ProductTypes.Instance.Clear();
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
            Assert.AreEqual(c+1, ProductTypes.Instance.Count);
            Assert.AreEqual(p, ProductTypes.Instance.Find(x => x.IsSameContent(p)));
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