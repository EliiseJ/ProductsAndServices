using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductTypes : Archetypes<ProductType>
    {
        public static ProductTypes Instance { get; } = new ProductTypes();

        public static ProductType Find(string id)
        {
            return Instance.Find(x => x.ProductId == id);
        }
    }
}
