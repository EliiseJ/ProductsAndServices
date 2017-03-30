using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductCatalog: Archetype
    {
        public void Add(ProductType productType)
        {
            ProductTypes.Instance.Add(productType);
        }

        public void Remove(ProductIdentifier productId)
        {
            ProductIdentifiers.Instance.Remove(productId);
        }

        public ProductType FindByCatalogId(string catalogId)
        {
            var c = CatalogEntries.Find(catalogId);
            return ProductTypes.Find(c.TypeId);
        }

        public ProductType FindByProductId(string productId)
        {
            var p = Products.Find(productId);
            return ProductTypes.Find(p.TypeId);
        }

        public void FindByName(string name)
        {
            ProductTypes.Instance.Find(x => x.Name == name);
        }

        

    }
}
