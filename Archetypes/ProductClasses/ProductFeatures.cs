using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductFeatures : Archetypes<ProductFeature>
    {
        public static ProductFeatures Instance { get; } = new ProductFeatures();

        public static ProductFeature Find(string productId)
        {
            return Instance.Find(x => x.UniqueId == productId);
        }

        public static ProductFeatures Random()
        {
            var r = new ProductFeatures();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(ProductFeature.Random());
            return r;
        }
    }
}
