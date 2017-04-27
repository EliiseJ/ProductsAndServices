using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    public class PricesTests: CommonTests<Prices>
    {
        protected override Prices GetRandomObj()
        {
            return Prices.Random();
        }

        [TestMethod]
        public void InstanceTest()
        {
            TestSingleton(() => Prices.Instance);
        }

        [TestMethod]
        public void FindTest()
        {
            var s = GetRandom.String();
            Assert.IsNull(Prices.Find(s));
            var t = Price.Random();
            t.UniqueId = s;
            Prices.Instance.Add(t);
            Prices.Instance.AddRange(Prices.Random());
            Assert.AreEqual(t, Prices.Find(s));
        }
    }
}
