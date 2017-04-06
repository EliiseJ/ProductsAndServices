using System.Collections.Generic;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductSet : Archetype
    {
        private string name;
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }

        public List<ProductIdentifier> ProductIdentifiers { get; } = new List<ProductIdentifier>();

        public void AddProductReference(ProductIdentifier reference)
        {
            ProductIdentifiers.Add(reference);
        }

        public int Count()
        {
            return ProductIdentifiers.Count;
        }

        public static ProductSet Random()
        {
            var e = new ProductSet();
            e.SetRandomValues();
            return e;
        }
    }
}
