using Open.Archetypes.ProductClasses;

namespace Open.Tests.Archetypes.ProductClasses
{
    public class ProductCatalogTests: CommonTests<ProductCatalog>
    {
        protected override ProductCatalog GetRandomObj()
        {
            return ProductCatalog.Random();
        }
    }
}
