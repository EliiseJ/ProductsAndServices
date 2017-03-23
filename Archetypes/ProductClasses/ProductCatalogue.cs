namespace Open.Archetypes.ProductClasses
{
    public class ProductCatalogue
    {
        public void add(ProductType productType)
        {
            ProductTypes.Instance.Add(productType);
            //ProductTypes.Instance.Find(x =>x.Name == name)
        }
    }
}
