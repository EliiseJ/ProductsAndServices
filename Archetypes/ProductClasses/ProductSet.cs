using System.Collections.Generic;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductSet : Archetype
    {
        public string name { get; set; }

        public List<ProductIdentifier> productIdentifiers { get; } = new List<ProductIdentifier>();

        public void AddProductReference(ProductIdentifier reference)
        {
            productIdentifiers.Add(reference);
        }

        public int Count()
        {
            return productIdentifiers.Count;
        }
    }
}
