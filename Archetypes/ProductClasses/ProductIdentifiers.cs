using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductIdentifiers : Archetypes<ProductIdentifier>
    {
        public static ProductIdentifiers Instance { get; } = new ProductIdentifiers();

        public static ProductIdentifier Find(string uniqueId)
        {
            return Instance.Find(x => x.UniqueId == uniqueId);
        }
        public static ProductIdentifiers Random()
        {
            var r = new ProductIdentifiers();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(ProductIdentifier.Random());
            return r;
        }
    }
}
