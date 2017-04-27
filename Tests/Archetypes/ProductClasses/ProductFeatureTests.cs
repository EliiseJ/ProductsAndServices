using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    public class ProductFeatureTests: CommonTests<ProductFeature>
    {
        protected override ProductFeature GetRandomObj()
        {
            return ProductFeature.Random();
        }
    }
}
