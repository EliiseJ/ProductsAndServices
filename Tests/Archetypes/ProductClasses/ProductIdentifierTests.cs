using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.ProductClasses;
namespace Open.Tests.Archetypes.ProductClasses
{
    [TestClass]
    public class ProductIdentifierTests : CommonTests<ProductIdentifier>
    {
        protected override ProductIdentifier GetRandomObj()
        {
            return ProductIdentifier.Random();
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            ProductIdentifiers.Instance.AddRange(ProductIdentifiers.Random());
        }

        [TestCleanup]
        public override void TestCleanup()
        {
            base.TestCleanup();
            ProductIdentifiers.Instance.Clear();
        }

        [TestMethod]
        public void ConstructorTest()
        {
            var a = new ProductIdentifier().GetType().BaseType;
            Assert.AreEqual(a, typeof(UniqueEntity));
        }

        public void ProductIdTest()
        {
            Obj = new ProductIdentifier();
            TestProperty(() => Obj.ProductId, x => Obj.ProductId = x);
        }
    }
}
