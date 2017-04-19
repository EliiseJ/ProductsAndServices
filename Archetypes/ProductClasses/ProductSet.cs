using System.Collections.Generic;
using Open.Archetypes.BaseClasses;
using Open.Aids;

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

        public List<string> ProductIdentifiers { get; } = new List<string>();

        public void AddProductReference(string reference)
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

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            name = GetRandom.String();
        }
    }
}
