using System;
using System.Linq;

namespace Open.Archetypes.ProductClasses
{
    public class PackageType : ProductType
    {
        public void addProductType(ProductType product)
        {
            ProductTypes.Instance.Add(product);
        }

        public ProductType[] getComponents()
        {
            return ProductTypes.Instance.ToArray();
        }

        public Price[] getPrices()
        {
            return Prices.Instance.ToArray();
        }

        public void addProductSet(ProductSet set)
        {
            
        }

        public Boolean validatePackage()
        {
            return false;
        }
    }
}

