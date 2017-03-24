namespace Open.Archetypes.ProductClasses
{
    public class ProductCatalog
    {
        public void Add(ProductType productType)
        {
            ProductTypes.Instance.Add(productType);
        }

        public void Remove(ProductIdentifier productId)
        {
            ProductIdentifiers.Instance.Remove(productId);
        }

        public void FindByCatalogId(string catalogId)
        {
            ProductTypes.Instance.Find(x => x.CatalogId == catalogId);
        }

        public void FindByProductId(string productId)
        {
            ProductTypes.Instance.Find(x => x.ProductId == productId);
        }

        public void FindByName(string name)
        {
            ProductTypes.Instance.Find(x => x.Name == name);
        }

        

    }
}
