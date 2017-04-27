using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    public class PackageTypesTests: CommonTests<PackageTypes>
    {
        protected override PackageTypes GetRandomObj()
        {
            return PackageTypes.Random();
        }

        [TestMethod]
        public void FindTest()
        {
            var s = GetRandom.String();
            Assert.IsNull(PackageTypes.Find(s));
            var t = PackageType.Random();
            t.UniqueId = s;
            PackageTypes.Instance.Add(t);
            PackageTypes.Instance.AddRange(PackageTypes.Random());
            Assert.AreEqual(t, PackageTypes.Find(s));
        }

        [TestMethod]
        public void InstanceTest()
        {
            TestSingleton(() => PackageTypes.Instance);
        }
    }
}
