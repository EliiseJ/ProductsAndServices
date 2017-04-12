using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductFeatures: Archetypes<ProductFeature>
    {
        public static ProductFeatures Instance { get; } = new ProductFeatures();

        public static ProductFeature Find(string productId)
        {
            return Instance.Find(x => x.UniqueId == productId);
        }
    }
}
