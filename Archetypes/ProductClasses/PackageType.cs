using System;
using System.Linq;
using Open.Aids;

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

        public void AddProductSet(ProductSet productSet)
        {
            ProductSets.Instance.Add(productSet);
        }

        public Boolean ValidatePackage()
        {
            return false;
        }

        public new static PackageType Random()
        {
            var e = new PackageType();
            e.SetRandomValues();
            return e;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
        }
    }
}

