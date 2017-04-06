using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductSets: Archetypes<ProductSet>
    {
        public static ProductSets Instance { get; } = new ProductSets();

        public static ProductSets Random()
        {
            var r = new ProductSets();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(ProductSet.Random());
            return r;
        }
    }
}
