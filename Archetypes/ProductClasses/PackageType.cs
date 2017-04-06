using System;
using System.Linq;

namespace Open.Archetypes.ProductClasses
{
    public class PackageType : ProductType
    {
        public void AddProductType(ProductType product)
        {
            ProductTypes.Instance.Add(product);
        }

        public ProductType[] GetComponents()
        {
            return ProductTypes.Instance.ToArray();
        }

        public Price[] GetPrices()
        {
            return Prices.Instance.ToArray();
        }

        public void AddProductSet(ProductSet set)
        {
            
        }

        public Boolean ValidatePackage()
        {
            return false;
        }
    }
}

