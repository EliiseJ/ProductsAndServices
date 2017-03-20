using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductInstances : Archetypes<ProductInstance>
    {
        public static ProductInstances Instances { get; } = new ProductInstances();
    }
}
