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
    }
}
